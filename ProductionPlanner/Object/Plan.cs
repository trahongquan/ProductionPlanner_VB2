using ProductionPlanner.Model;
using ProductionPlanner.Services;

namespace ProductionPlanner.Object
{
    internal class Plan
    {
        // Cac thuoc tinh
        private int id;
        private string name;
        private string author;
        private string date;
        private double total_profit;
        private List<Product> list_product;

        // Cac phuong thuc

        public Plan(int id, string name, string author, string date)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.date = date;
            this.total_profit = total_profit;
            list_product = new List<Product>();
        }
        public Plan(int id, string name, string author, string date, double total_profit)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.date = date;
            this.total_profit = total_profit;
            list_product = new List<Product>();
        }

        public Plan(int id, string name, string author, string date, double total_profit, bool b)
        {
            Cryption cryption = new Cryption();
            this.id = id;
            this.name = cryption.getDecrypt(name);
            this.author = cryption.getDecrypt(author);
            this.date = cryption.getDecrypt(date);
            this.total_profit = total_profit;
            list_product = new List<Product>();
        }

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Date { get => date; set => date = value; }
        public double Total_profit { get => total_profit; set => total_profit = value; }
        public int Id { get => id; }
        internal List<Product> List_product { get => list_product; set => list_product = value; }

        public bool add_product(Product product)
        {
            int n = list_product.Count;
            for (int i = 0; i < n; ++i)
            {
                if (list_product[i].Id == product.Id)
                {
                    return false;
                }
            }

            list_product.Add(product);
            return true;
        }
        public bool remove_product(int id)
        {
            int n = list_product.Count;
            for (int i = 0; i < n; ++i)
            {
                if (list_product[i].Id == id)
                {
                    list_product.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool update_product(Product product)
        {
            int n = list_product.Count;

            for (int i = 0; i < n; ++i)
            {
                if (list_product[i].Id == product.Id)
                {
                    list_product[i] = product;
                    return true;
                }
            }
            return false;
        }
        public string get_list_id()
        {
            if (list_product.Count == 0) return "";
            string st = list_product[0].Id.ToString();
            int n = list_product.Count;

            for (int i = 1; i < n; ++i)
            {
                st += "," + list_product[i].Id;
            }

            return st;
        }

        private Constraint get_budget_constraint(double budget)
        {
            int n = list_product.Count;
            double b;
            double[] variables = new double[n];

            for (int i = 0; i < n; ++i)
            {
                variables[i] = list_product[i].Material_cost;
            }

            return new Constraint(variables, budget, "=");
        }

        private Constraint get_hour_constraint(double hour)
        {
            int n = list_product.Count;
            double b;
            double[] variables = new double[n];

            for (int i = 0; i < n; ++i)
            {
                variables[i] = list_product[i].Labor_cost;
            }

            return new Constraint(variables, hour, "=");
        }


        public void simplex_solve(double budget, double hour)
        {
            total_profit = 0;
            int n = list_product.Count;
            double tmp_labor = 0, tmp_budget = 0;
            for (int i = 0; i < n; ++i)
            {
                //Lấy ra biến tạm 
                tmp_labor += list_product[i].Lower * list_product[i].Labor_cost; // số lượng thấp nhất * giá nhân công = Min_labor
                tmp_budget += list_product[i].Lower * list_product[i].Material_cost; // số lượng thấp nhất * giá vật liệu = Min_buget
            }

            if (tmp_labor <= hour && tmp_budget <= budget)
            {
                // dap ung
                for (int i = 0; i < n; ++i)
                {
                    list_product[i].Quantity = list_product[i].Lower;
                    
                }

                budget -= tmp_budget;
                hour -= tmp_labor;
            }
            else
            {
                // khong dap ung
                for (int i = 0; i < n; ++i)
                {
                    list_product[i].Quantity = -1;
                }
                total_profit = -1;
                return;
            }

            // Thiết lập Các rang buoc
            int variablesCount = list_product.Count;
            int constraintsCount = (variablesCount << 1) + 2; //<<: Toán tử dịch bit sang trái.
                                                              //vd: variablesCount = 3 (là 11) thì constraintsCount = 6 (111)
                                                              //"+2": Thêm 2 để bao gồm ràng buộc tổng sản lượng và ràng buộc phi âm.

            Constraint[] constraints = new Constraint[constraintsCount];
            double[] variables = new double[variablesCount];

            constraints[constraintsCount - 1] = get_budget_constraint(budget);
            constraints[constraintsCount - 2] = get_hour_constraint(hour);

            for (int i = 0; i < variablesCount; i++)
            {
                Array.Clear(variables, 0, variablesCount);
                variables[i] = 1;

                constraints[i] = new Constraint(variables, 0, ">=");
                constraints[i + variablesCount] = new Constraint(variables, list_product[i].Upper, "<=");
            }

            // Thiết lập Ham mục tiêu
            double[] functionVariables = new double[variablesCount];
            for (int i = 0; i < variablesCount; i++)
            {
                functionVariables[i] = list_product[i].Profit;
            }
            double c = 0;
            Function function = new Function(functionVariables, c, true); //true == MAX

            // Tinh gia tri
            Simplex simplex = new Simplex(function, constraints);

            Tuple<List<SimplexSnap>, SimplexResult> result = simplex.GetResult();

            //MessageBox.Show(result.Item2.ToString());
            n = result.Item1.Last().C.Length;

            for (int i = 0; i < n; ++i)
            {
                if (result.Item1.Last().C[i] < variablesCount)
                {
                    list_product[result.Item1.Last().C[i]].Quantity += Convert.ToInt32(result.Item1.Last().b[i]);
                    if (Convert.ToInt32(result.Item1.Last().b[i]) > result.Item1.Last().b[i])
                    {
                        --list_product[result.Item1.Last().C[i]].Quantity;
                    }
                }
            }

            for (int i = 0; i < variablesCount; ++i)
            {
                total_profit += list_product[i].Quantity * list_product[i].Profit;
            }
        }
    }
}
