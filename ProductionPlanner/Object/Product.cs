using ProductionPlanner.Model;

namespace ProductionPlanner.Object
{
    internal class Product
    {
        //attribute
        private int id;
        private string name;
        private double material_cost;
        private double labor_cost;
        private double profit;
        private int lower;
        private int upper;
        private int quantity;

        // methods
        public Product(int id, string name, double material_cost, double labor_cost, int lower, int upper, double profit)
        {
            if (lower < 0) 
                { lower = 0;}

            if (upper <= 0) 
            {
                upper = Int32.MaxValue;
            }

            if (lower > upper)
            {
                MessageBox.Show("Lower must smaller of equal than Upper");
                throw new Exception("Lower must smaller of equal than Upper");
            }

            this.id = id;
            this.name = name;
            this.material_cost = material_cost;
            this.labor_cost = labor_cost;
            this.profit = profit;
            this.lower = lower;
            this.upper = upper;
        }
        public Product(int id, string name, double material_cost, double labor_cost, int lower, int upper, double profit, bool b)
        {
            if (lower < 0)
            { lower = 0; }

            if (upper <= 0)
            {
                upper = Int32.MaxValue;
            }

            if (lower > upper)
            {
                MessageBox.Show("Lower must smaller of equal than Upper");
                throw new Exception("Lower must smaller of equal than Upper");
            }
            Cryption cryption = new Cryption();
            this.id = id;
            this.name = cryption.getDecrypt(name);
            this.material_cost = material_cost;
            this.labor_cost = labor_cost;
            this.profit = profit;
            this.lower = lower;
            this.upper = upper;
        }
        public string Name { get => name; set => name = value; }
        public double Material_cost { get => material_cost; set => material_cost = value; }
        public double Labor_cost { get => labor_cost; set => labor_cost = value; }
        public double Profit { get => profit; set => profit = value; }
        public int Lower { get => lower; set => lower = value; }
        public int Upper { get => upper; set => upper = value; }
        public int Id { get => id;}
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
