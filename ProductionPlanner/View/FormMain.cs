using ProductionPlanner.Model;
using ProductionPlanner.Object;
using ClosedXML.Excel;
using System.Data;
using static DocumentFormat.OpenXml.Packaging.RelationshipErrorHandler;

namespace ProductionPlanner.View
{
    public partial class FormMain : Form
    {
        #region Cac thuoc tinh
        private QueryCapacity queryCapacity = new QueryCapacity();
        private QueryMgr queryMgr = new QueryMgr();
        private QueryPlan queryPlan = new QueryPlan();
        private QueryProduct queryProduct = new QueryProduct();

        private List<Product> products = new List<Product>();
        private List<Plan> plans = new List<Plan>();
        private List<Capacity> capacitys = new List<Capacity>();

        private string user = "";
        private string pass = "fsjghshfishfiosfhiosfhosfhzo";

        private int product_basic_id = 0, product_curent_id = 0;
        private int plan_basic_id = 0, plan_curent_id = 0;
        private int capacity_basic_id = 0, capacity_curent_id = 0;

        private bool is_exit = true;
        private bool is_change = false;
        private bool is_admin = false;
        private bool is_vie = false;
        #endregion
        public FormMain(bool is_admin, bool is_vie, string user, string pass)
        {
            this.is_admin = is_admin;
            this.is_vie = is_vie;
            this.user = user;
            this.pass = pass;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!is_admin)
            {
                reportToolStripMenuItem.Enabled = false;
                accountToolStripMenuItem.Enabled = false;
                managerToolStripMenuItem.Enabled = false;

                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem5.Enabled = false;
                addToPlanToolStripMenuItem.Enabled = false;
                removeOnPlanToolStripMenuItem.Enabled = false;

                toolStripMenuItem1.Enabled = false;
                editToolStripMenuItem2.Enabled = false;
                toolStripMenuItem2.Enabled = false;

                addToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }


            init();
            if (is_vie)
            {
                tran_to_Vie();
            }
            RowEnter();
        }

        #region Init

        private void init()
        {
            try
            {
                try
                {
                    init_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Err Tab", ex.Message);
                }

                init_list();

                try
                {
                    edit_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Err editTab", ex.Message);
                }
                //edit_table();

                if (dtgv_capacity.Rows.Count > 1)
                {
                    dtgv_capacity.Rows[0].Selected = true;
                    RowEnter();
                } 
                if (dtgv_plan.Rows.Count > 1) dtgv_plan.Rows[0].Selected = true;


                for (int i = 0; i < plans.Count; ++i)
                {
                    Update_plan(i);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error", e.Message);
            }

        }
        private List<int> get_list_product(string list_st)
        {
            int id_tmp;
            string st = "";
            List<int> ls_tmp = new List<int>();

            int n = list_st.Length;

            for (int i = 0; i < n; ++i)
            {
                if (list_st[i] != ',')
                {
                    st += list_st[i];
                }
                else
                {
                    id_tmp = Convert.ToInt32(st);
                    ls_tmp.Add(id_tmp);
                    st = "";
                }
            }

            id_tmp = Convert.ToInt32(st);
            ls_tmp.Add(id_tmp);

            return ls_tmp;
        }
        private Plan create_plan_from_dtgv(int i)
        {

            Plan plan = new Plan(
                Convert.ToInt32(dtgv_plan.Rows[i].Cells[0].Value.ToString()),   // id
                dtgv_plan.Rows[i].Cells[1].Value.ToString(),                    // name
                dtgv_plan.Rows[i].Cells[2].Value.ToString(),                    // author
                dtgv_plan.Rows[i].Cells[3].Value.ToString(),                    // date
                Convert.ToDouble(dtgv_plan.Rows[i].Cells[5].Value.ToString()),  // profit
                true);

            if (dtgv_plan.Rows[i].Cells[4].Value.ToString().Equals("")) return plan;
            List<int> ids = get_list_product(dtgv_plan.Rows[i].Cells[4].Value.ToString());
            for (int j = 0; j < products.Count; ++j)
            {
                for (int t = 0; t < ids.Count; ++t)
                {
                    if (products[j].Id == ids[t])
                    {
                        plan.List_product.Add(products[j]);
                        ids.RemoveAt(t);
                    }
                }
            }

            return plan;
        }
        private Product create_product_from_dtgv(int i)
        {

            return new Product(
                Convert.ToInt32(dtgv_product.Rows[i].Cells[0].Value.ToString()),// id
                dtgv_product.Rows[i].Cells[1].Value.ToString(),                 // name
                Convert.ToDouble(dtgv_product.Rows[i].Cells[2].Value.ToString()),//material
                Convert.ToDouble(dtgv_product.Rows[i].Cells[3].Value.ToString()),//labor
                Convert.ToInt32(dtgv_product.Rows[i].Cells[4].Value.ToString()),// low
                Convert.ToInt32(dtgv_product.Rows[i].Cells[5].Value.ToString()),// up
                Convert.ToDouble(dtgv_product.Rows[i].Cells[6].Value.ToString()), true);//profit
        }
        private Capacity create_capacity_from_dtgv(int i)
        {
            return new Capacity(
               Convert.ToInt32(dtgv_capacity.Rows[i].Cells[0].Value.ToString()),//id
               dtgv_capacity.Rows[i].Cells[1].Value.ToString(),                 //name
               dtgv_capacity.Rows[i].Cells[2].Value.ToString(),                 // date
               Convert.ToDouble(dtgv_capacity.Rows[i].Cells[3].Value.ToString()),//budget
               Convert.ToDouble(dtgv_capacity.Rows[i].Cells[4].Value.ToString()), true);//hours
        }
        private void init_table()
        {
            try
            {
                dtgv_plan.DataSource = queryPlan.get_data_source();
                dtgv_product.DataSource = queryProduct.get_data_source();
                dtgv_capacity.DataSource = queryCapacity.get_data_source();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datasource", ex.Message);
            }

        }
        private void init_list()
        {
            // tao cac list plans, products tu bang

            int n = dtgv_product.Rows.Count - 1;
            for (int i = 0; i <= n; ++i)
            {
                products.Add(create_product_from_dtgv(i));
            }
            if (n >= 0)
                product_basic_id = product_curent_id = products[n].Id;

            n = dtgv_plan.Rows.Count - 1;
            for (int i = 0; i <= n; ++i)
            {
                plans.Add(create_plan_from_dtgv(i));
            }

            if (n >= 0)
                plan_basic_id = plan_curent_id = plans[n].Id;

            n = dtgv_capacity.Rows.Count - 1;
            for (int i = 0; i <= n; ++i)
            {
                capacitys.Add(create_capacity_from_dtgv(i));
            }
            if (n >= 0)
                capacity_basic_id = capacity_curent_id = capacitys[n].Id;
        }
        private void edit_table()
        {
            try
            {
                dtgv_capacity.Columns.Clear();
                dtgv_plan.Columns.Clear();
                dtgv_product.Columns.Clear();
                dtgv_capacity.DataSource = null;
                dtgv_plan.DataSource = null;
                dtgv_product.DataSource = null;

                dtgv_capacity.Columns.Add("name", "Name");
                dtgv_capacity.Columns.Add("date", "Date");
                dtgv_capacity.Columns.Add("budget", "Budget");
                dtgv_capacity.Columns.Add("total_hours", "Total work hours");

                for (int i = 0; i < 3; ++i)
                {
                    dtgv_capacity.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }


                for (int i = 0; i < capacitys.Count; ++i)
                {
                    dtgv_capacity.Rows.Add(capacitys[i].Decrip, capacitys[i].Date,
                        capacitys[i].Budget.ToString(), capacitys[i].Total_work_hours.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("capacity_err", ex.Message);
            }

            try
            {
                dtgv_product.Columns.Add("name", "Name");
                dtgv_product.Columns.Add("material", "Material");
                dtgv_product.Columns.Add("labor", "Labor");
                dtgv_product.Columns.Add("lower", "Lower");
                dtgv_product.Columns.Add("upper", "Upper");
                dtgv_product.Columns.Add("profit", "Profit");
                dtgv_product.Columns.Add("quantity", "Quantity");

                for (int i = 0; i < 7; ++i)
                {
                    dtgv_product.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 0; i < products.Count; ++i)
                {
                    dtgv_product.Rows.Add(products[i].Name, products[i].Material_cost.ToString(),
                        products[i].Labor_cost.ToString(), products[i].Lower.ToString(),
                        products[i].Upper.ToString(), products[i].Profit.ToString(), "0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("product_err", ex.Message);
            }

            try
            {
                dtgv_plan.Columns.Add("name", "Name");
                dtgv_plan.Columns.Add("author", "Author");
                dtgv_plan.Columns.Add("date", "Date");
                dtgv_plan.Columns.Add("n_product", "N.product");
                dtgv_plan.Columns.Add("total_profit", "Total profit");

                for (int i = 0; i < 5; ++i)
                {
                    dtgv_plan.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 0; i < plans.Count; ++i)
                {
                    dtgv_plan.Rows.Add(plans[i].Name, plans[i].Author,
                        plans[i].Date, plans[i].List_product.Count.ToString(), plans[i].Total_profit.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("plan_err", ex.Message);
            }


        }
        #endregion

        #region Product
        private Product get_product_from_txtbox()
        {
            string name = txt_product_name.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name is invalid");
                throw new Exception("Name is invalid");
            }

            for (int i = 0; i < products.Count; ++i)
            {
                if (name.Equals(products[i].Name))
                {
                    MessageBox.Show("Name already exist");
                    throw new Exception("Name already exist");
                }
            }

            //int id = product_basic_id = ++product_basic_id;
            //++product_basic_id;
            return new Product(
                ++product_basic_id,
                name,
                Convert.ToDouble(txt_material.Text),
                Convert.ToDouble(txt_labor.Text),
                Convert.ToInt32(txt_lower.Text),
                Convert.ToInt32(txt_upper.Text),
                Convert.ToDouble(txt_product_profit.Text));
        }
        private Product get_product_from_txtbox(int id)
        {
            string name = txt_product_name.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name is invalid");
                throw new Exception("Name is invalid");
            }

            for (int i = 0; i < products.Count; ++i)
            {
                if (name.Equals(products[i].Name))
                {
                    MessageBox.Show("Name already exist");
                    throw new Exception("Name already exist");
                }
            }

            return new Product(
                id,
                txt_product_name.Text,
                Convert.ToDouble(txt_material.Text),
                Convert.ToDouble(txt_labor.Text),
                Convert.ToInt32(txt_lower.Text),
                Convert.ToInt32(txt_upper.Text),
                Convert.ToDouble(txt_product_profit.Text));
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            is_change = true;
            // Add product
            try
            {
                Product product = get_product_from_txtbox();
                products.Add(product);
                dtgv_product.Rows.Add(product.Name, product.Material_cost.ToString(),
                    product.Labor_cost.ToString(), product.Lower.ToString(), product.Upper.ToString(),
                        product.Profit.ToString());
                queryProduct.insert(new Product(product));
                reloadToolStripMenuItem1_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Lỗi add item product");
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            is_change = true;
            // Edit product
            try
            {
                int idx = dtgv_product.SelectedRows[0].Index;
                Product product = get_product_from_txtbox(products[idx].Id);
                products[idx] = product;
                for (int i = 0; i < plans.Count; ++i)
                {
                    if (plans[i].update_product(product))
                        Update_plan(i);
                }

                dtgv_product.Rows[idx].Cells[0].Value = product.Name;
                dtgv_product.Rows[idx].Cells[1].Value = product.Material_cost;
                dtgv_product.Rows[idx].Cells[2].Value = product.Labor_cost;
                dtgv_product.Rows[idx].Cells[3].Value = product.Lower;
                dtgv_product.Rows[idx].Cells[4].Value = product.Upper;
                dtgv_product.Rows[idx].Cells[5].Value = product.Profit;
                
                queryProduct.update(product);
                reloadToolStripMenuItem1_Click(sender, e);
            }
            catch
            {

            }
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            is_change = true;
            // Delete product
            try
            {
                int idx = dtgv_product.SelectedRows[0].Index;

                int idP = products[idx].Id;

                products.RemoveAt(idx);

                dtgv_product.Rows.RemoveAt(idx);

                try
                {
                    queryProduct.delete(idP);
                }
                catch
                {
                    //tính cả trường hợp không tồn tại trong CSDL
                }
                for (int i = 0; i < plans.Count; ++i)
                {
                    if (plans[i].remove_product(idx))
                        Update_plan(i);
                }
                reloadToolStripMenuItem1_Click(sender, e);
            }
            catch
            { }

        }
        private void dtgv_product_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            try
            {
                txt_product_name.Text = dtgv_product.SelectedRows[0].Cells[0].Value.ToString();
                txt_material.Text = dtgv_product.SelectedRows[0].Cells[1].Value.ToString();
                txt_labor.Text = dtgv_product.SelectedRows[0].Cells[2].Value.ToString();
                txt_lower.Text = dtgv_product.SelectedRows[0].Cells[3].Value.ToString();
                txt_upper.Text = dtgv_product.SelectedRows[0].Cells[4].Value.ToString();
                txt_product_profit.Text = dtgv_product.SelectedRows[0].Cells[5].Value.ToString();
                txt_quantity.Text = dtgv_product.SelectedRows[0].Cells[6].Value != null ? dtgv_product.SelectedRows[0].Cells[6].Value.ToString() : "";
            }
            catch
            { }

        }
        private void addToPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_change = true;
            int idx = dtgv_plan.SelectedRows[0].Index;
            if (plans[idx].add_product(products[dtgv_product.SelectedRows[0].Index]))
            {
                Update_plan(idx);
            }
            else
            {
                MessageBox.Show("This product already exists", "Fail");
            }

        }
        private void removeOnPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_change = true;
            int idx = dtgv_plan.SelectedRows[0].Index;
            if (plans[idx].remove_product(products[dtgv_product.SelectedRows[0].Index].Id))
            {
                Update_plan(idx);
            }
            else
            {
                MessageBox.Show("This product does not exists", "Fail");
            }

        }
        private void Update_plan(int idx)
        {
            double budget = Convert.ToDouble(dtgv_capacity.SelectedRows[0].Cells[2].Value.ToString());
            double hours = Convert.ToDouble(dtgv_capacity.SelectedRows[0].Cells[3].Value.ToString());
            plans[idx].simplex_solve(budget, hours);
            dtgv_plan.Rows[idx].Cells[3].Value = plans[idx].List_product.Count.ToString();
            dtgv_plan.Rows[idx].Cells[4].Value = plans[idx].Total_profit.ToString();

            if (idx == dtgv_plan.SelectedRows[0].Index)
            {
                txt_total_profit.Text = plans[idx].Total_profit.ToString();
                txt_num.Text = plans[idx].List_product.Count.ToString();
            }
        }
        #endregion

        #region Plan
        private Plan get_plan_from_txtbox()
        {
            string name = txt_plan_name.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name is invalid");
                throw new Exception("Name is invalid");
            }

            for (int i = 0; i < plans.Count; ++i)
            {
                if (name.Equals(plans[i].Name))
                {
                    MessageBox.Show("Name already exist");
                    throw new Exception("Name already exist");
                }
            }

            return new Plan(
                ++plan_curent_id,
                txt_plan_name.Text,
                txt_author.Text,
                dtpk_creat.Text
                );
        }

        private Plan get_plan_from_txtbox(int id)
        {
            string name = txt_plan_name.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name is invalid");
                throw new Exception("Name is invalid");
            }

            for (int i = 0; i < plans.Count; ++i)
            {
                if (name.Equals(plans[i].Name))
                {
                    MessageBox.Show("Name already exist");
                    throw new Exception("Name already exist");
                }
            }
            return new Plan(
                id,
                txt_plan_name.Text,
                txt_author.Text,
                dtpk_creat.Text,
                Convert.ToDouble(txt_total_profit.Text));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            is_change = true;
            // Add plan
            try
            {
                Plan plan = get_plan_from_txtbox();
                plans.Add(plan);
                dtgv_plan.Rows.Add(plan.Name, plan.Author, plan.Date, plan.Total_profit.ToString());
            }
            catch
            {
                return;
            }


        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            is_change = true;
            // Edit plan
            try
            {
                int idx = dtgv_plan.SelectedRows[0].Index;
                Plan plan = get_plan_from_txtbox(plans[idx].Id);
                plans[idx] = plan;

                dtgv_plan.Rows[idx].Cells[0].Value = plan.Name;
                dtgv_plan.Rows[idx].Cells[1].Value = plan.Author;
                dtgv_plan.Rows[idx].Cells[2].Value = plan.Date;
                dtgv_plan.Rows[idx].Cells[3].Value = plan.Total_profit.ToString();
            }
            catch
            { return; }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //delete plans
            is_change = true;
            if (plans.Count <= 1)
            {
                return;
            }

            int idx = dtgv_plan.SelectedRows[0].Index;
            plans.RemoveAt(idx);
            dtgv_plan.Rows.RemoveAt(idx);
        }

        private void dtgv_plan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            RowEnter();
            timer1.Start();

        }

        private void RowEnter()
        {
            try
            {
                int idx = dtgv_plan.SelectedRows[0].Index;
                txt_plan_name.Text = dtgv_plan.Rows[idx].Cells[0].Value.ToString();
                txt_author.Text = dtgv_plan.Rows[idx].Cells[1].Value.ToString();
                dtpk_creat.Text = DateTime.Parse(dtgv_plan.Rows[idx].Cells[2].Value.ToString()).ToShortDateString();
                txt_total_profit.Text = dtgv_plan.Rows[idx].Cells[4].Value != null ? dtgv_plan.Rows[idx].Cells[4].Value.ToString() : "";
                txt_num.Text = plans[idx].List_product.Count.ToString();

                for (int i = 0; i < products.Count; ++i)
                {
                    dtgv_product.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dtgv_product.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    dtgv_product.Rows[i].Cells[6].Value = "0";

                    for (int j = 0; j < plans[idx].List_product.Count; ++j)
                    {
                        if (plans[idx].List_product[j].Id == products[i].Id)
                        {
                            dtgv_product.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            dtgv_product.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Gold;
                            dtgv_product.Rows[i].Cells[6].Value = plans[idx].List_product[i].Quantity.ToString();
                        }
                    }
                }
            }
            catch { }
        }

        #endregion

        #region Capacity
        private bool isVerify(string st)
        {
            FormVerify frVrf = new FormVerify(st);

            if (!frVrf.ShowDialog().Equals(DialogResult.OK))
            {
                return false;
            }

            return true;
        }
        private Capacity get_capacity_from_txtbox()
        {
            string name = txt_capacity_name.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name is invalid");
                throw new Exception("Name is invalid");
            }

            for (int i = 0; i < capacitys.Count; ++i)
            {
                if (name.Equals(capacitys[i].Decrip))
                {
                    MessageBox.Show("Name already exist");
                    throw new Exception("Name already exist");
                }
            }
            return new Capacity(
                ++capacity_curent_id,
                txt_capacity_name.Text,
                DateTime.Now.Date.ToShortDateString(),
                Convert.ToDouble(txt_capacity_budget.Text),
                Convert.ToDouble(txt_hours.Text));
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                timer1.Stop();
                if (!isVerify("Factory Manager"))
                {
                    return;
                }
                timer1.Start();
                Capacity capacity = get_capacity_from_txtbox();

                capacitys.Add(capacity);
                dtgv_capacity.Rows.Add(capacity.Decrip, capacity.Date, capacity.Budget, capacity.Total_work_hours);
                queryCapacity.insert(capacity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capacitys.Count == 0)
            {
                return;
            }


            try
            {
                timer1.Stop();
                if (!isVerify("Factory Manager"))
                {
                    return;
                }
                timer1.Start();

                int idx = dtgv_capacity.SelectedRows[0].Index;
                queryCapacity.delete(capacitys[idx].Id);
                capacitys.RemoveAt(idx);
                dtgv_capacity.Rows.RemoveAt(idx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgv_capacity_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            try
            {
                txt_capacity_name.Text = dtgv_capacity.SelectedRows[0].Cells[0].Value.ToString();
                txt_capacity_budget.Text = dtgv_capacity.SelectedRows[0].Cells[2].Value.ToString();
                txt_hours.Text = dtgv_capacity.SelectedRows[0].Cells[3].Value.ToString();

                for (int i = 0; i < plans.Count; ++i)
                {
                    Update_plan(i);
                }
            }
            catch { }
        }

        #endregion

        #region Cac menu_btn khac
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_exit = false;
            this.Close();
        }
        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form fm = new FormMgr();
            fm.ShowDialog();
            timer1.Start();

        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bool tmp = is_change;
            is_change = false;
            this.Hide();
            Form fm = new FormLock(pass);
            fm.ShowDialog();
            this.Show();
            timer1.Start();
            is_change = tmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lockToolStripMenuItem_Click(sender, e);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (is_exit)
            {
                Application.Exit();
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void FormMain_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            //SaveProject();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FormChangePass frm = new FormChangePass(user, pass);
            frm.ShowDialog();
            timer1.Start();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add((DataTable)dtgv_product.DataSource, "Products List");
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Sucessfuly Export to Excel", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed Export to Excel", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Translate
        private void tran_to_Vie()
        {
            viToolStripMenuItem.Enabled = false;
            englishToolStripMenuItem.Enabled = true;

            lockToolStripMenuItem.Text = "Khóa";
            reportToolStripMenuItem.Text = "Tạo báo cáo";
            accountToolStripMenuItem.Text = "Tài khoản";
            logoutToolStripMenuItem.Text = "Đăng xuất";
            changePassToolStripMenuItem.Text = "Đổi mật khẩu";
            managerToolStripMenuItem.Text = "Quản trị";

            toolStripMenuItem3.Text = "Thêm";
            toolStripMenuItem4.Text = "Sửa";
            toolStripMenuItem5.Text = "Xóa";
            addToPlanToolStripMenuItem.Text = "Thêm vào KH";
            removeOnPlanToolStripMenuItem.Text = "Loại khỏi KH";

            toolStripMenuItem1.Text = "Thêm";
            editToolStripMenuItem2.Text = "Sửa";
            toolStripMenuItem2.Text = "Xóa";

            addToolStripMenuItem.Text = "Thêm";
            deleteToolStripMenuItem.Text = "Xóa";

            grb_products.Text = "Sản phẩm";
            lab_product_name.Text = "Tên";
            lab_product_labor.Text = "Nhân công";
            lab_product_material.Text = "Vật liệu";
            lab_txt_lower.Text = "Tối thiểu";
            lab_product_upper.Text = "Tối đa";
            lab_product_profit.Text = "Lợi nhuận";
            lab_product_quantity.Text = "Số lượng";
            dtgv_product.Columns[0].HeaderText = "Tên";
            dtgv_product.Columns[1].HeaderText = "Vật liệu";
            dtgv_product.Columns[2].HeaderText = "Nhân công";
            dtgv_product.Columns[3].HeaderText = "Tối thiểu";
            dtgv_product.Columns[4].HeaderText = "Tối đa";
            dtgv_product.Columns[5].HeaderText = "Lợi nhuận";
            dtgv_product.Columns[6].HeaderText = "Số lượng";

            grb_plan.Text = "Kế hoạch";
            lab_plan_name.Text = "Tên";
            lab_plan_author.Text = "T.giả";
            lab_plan_date.Text = "Ngày";
            lab_plan_profit.Text = "Tổng lãi";
            dtgv_plan.Columns[0].HeaderText = "Tên";
            dtgv_plan.Columns[1].HeaderText = "Tác giả";
            dtgv_plan.Columns[2].HeaderText = "Ngày";
            dtgv_plan.Columns[3].HeaderText = "Số sp";
            dtgv_plan.Columns[4].HeaderText = "Tổng lãi";

            grb_capacity.Text = "Công suất nhà máy";
            lab_cap_name.Text = "Tên";
            lab_cap_budget.Text = "Ngân sách";
            lab_cap_hours.Text = "Giờ công";
            dtgv_capacity.Columns[0].HeaderText = "Tên";
            dtgv_capacity.Columns[1].HeaderText = "Ngày";
            dtgv_capacity.Columns[2].HeaderText = "Ngân sách";
            dtgv_capacity.Columns[3].HeaderText = "Giờ công";
        }

        private void tran_to_Eng()
        {
            viToolStripMenuItem.Enabled = true;
            englishToolStripMenuItem.Enabled = false;

            lockToolStripMenuItem.Text = "Lock";
            reportToolStripMenuItem.Text = "Report";
            accountToolStripMenuItem.Text = "Account";
            logoutToolStripMenuItem.Text = "Logout";
            changePassToolStripMenuItem.Text = "Change pass";
            managerToolStripMenuItem.Text = "Manager";

            toolStripMenuItem3.Text = "Add";
            toolStripMenuItem4.Text = "Edit";
            toolStripMenuItem5.Text = "Delete";
            addToPlanToolStripMenuItem.Text = "Add to plan";
            removeOnPlanToolStripMenuItem.Text = "Remove on plan";

            toolStripMenuItem1.Text = "Add";
            editToolStripMenuItem2.Text = "Edit";
            toolStripMenuItem2.Text = "Delete";

            addToolStripMenuItem.Text = "Add";
            deleteToolStripMenuItem.Text = "Delete";

            grb_products.Text = "Products";
            lab_product_name.Text = "Product";
            lab_product_labor.Text = "Labor";
            lab_product_material.Text = "Material";
            lab_txt_lower.Text = "Lower";
            lab_product_upper.Text = "Upper";
            lab_product_profit.Text = "Profit";
            lab_product_quantity.Text = "Quantity";
            dtgv_product.Columns[0].HeaderText = "Name";
            dtgv_product.Columns[1].HeaderText = "Material";
            dtgv_product.Columns[2].HeaderText = "Labor";
            dtgv_product.Columns[3].HeaderText = "Lower";
            dtgv_product.Columns[4].HeaderText = "Upper";
            dtgv_product.Columns[5].HeaderText = "Profit";
            dtgv_product.Columns[6].HeaderText = "Quantity";

            grb_plan.Text = "Plans";
            lab_plan_name.Text = "Name";
            lab_plan_author.Text = "Author";
            lab_plan_date.Text = "Date";
            lab_plan_profit.Text = "Profit";
            dtgv_plan.Columns[0].HeaderText = "Name";
            dtgv_plan.Columns[1].HeaderText = "Author";
            dtgv_plan.Columns[2].HeaderText = "Date";
            dtgv_plan.Columns[3].HeaderText = "N.product";
            dtgv_plan.Columns[4].HeaderText = "Total profit";

            grb_capacity.Text = "Capacity";
            lab_cap_name.Text = "Name";
            lab_cap_budget.Text = "Budget";
            lab_cap_hours.Text = "Hours";
            dtgv_capacity.Columns[0].HeaderText = "Name";
            dtgv_capacity.Columns[1].HeaderText = "Date";
            dtgv_capacity.Columns[2].HeaderText = "Budget";
            dtgv_capacity.Columns[3].HeaderText = "Total work hours";
        }

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tran_to_Vie();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tran_to_Eng();
        }
        #endregion

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            edit_table();
            for (int i = 0; i < plans.Count; ++i)
            {
                Update_plan(i);
            }
        }

        private void SaveProject()
        {
            if (!is_change)
            {
                return;
            }

            DialogResult dlr = new DialogResult();

            dlr = (DialogResult)MessageBox.Show("Save changes?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr.Equals(DialogResult.No))
            {
                return;
            }
            #region Product
            int n = products.Count;

            //Edit + Delete
            for (int id = 1; id <= product_basic_id; ++id)
            {
                for (int idx = 0; idx < n; ++idx)
                {
                    if (products[idx].Id == id)
                    {
                        queryProduct.update(products[idx]);
                        break;
                    }

                    if (products[idx].Id >= product_basic_id)
                    {
                        // ko co trong list
                        queryProduct.delete(id);
                        break;
                    }
                }
            }

            // Add
            for (int i = 0; i < n; ++i)
            {
                if (products[i].Id > product_curent_id)
                {

                    try
                    {
                        Product findProduct = queryProduct.get_Product_by_name(products[i].Name);
                        findProduct.Id = products[i].Id;
                        findProduct.Name = products[i].Name;
                        findProduct.Labor_cost = products[i].Labor_cost;
                        findProduct.Material_cost = products[i].Material_cost;
                        findProduct.Lower = products[i].Lower;
                        findProduct.Upper = products[i].Upper;
                        findProduct.Profit = products[i].Profit;
                        queryProduct.update(findProduct);
                    }
                    catch
                    {
                        queryProduct.insert(new Product(products[i]));
                        //MessageBox.Show("Lỗi tại ProductAdd");
                    }


                }
            }
            #endregion

            #region Plan
            n = plans.Count;

            //Edit + Delete
            for (int i = 1; i <= plan_basic_id; ++i)
            {
                for (int idx = 0; idx < n; ++idx)
                {
                    if (plans[idx].Id == i)
                    {
                        queryPlan.update(plans[idx]);
                        break;
                    }
                    if (plans[idx].Id >= plan_basic_id)
                    {
                        // ko co trong list
                        queryPlan.delete(i);
                        break;
                    }
                }
            }

            // Add
            for (int i = 0; i < n; ++i)
            {
                if (plans[i].Id > plan_basic_id)
                {
                    queryPlan.insert(plans[i]);
                }
            }
            #endregion
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }
    }
}
