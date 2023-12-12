namespace ProductionPlanner.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            grb_products = new GroupBox();
            menu_product = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            addToPlanToolStripMenuItem = new ToolStripMenuItem();
            removeOnPlanToolStripMenuItem = new ToolStripMenuItem();
            txt_quantity = new TextBox();
            lab_product_quantity = new Label();
            txt_product_profit = new TextBox();
            lab_product_profit = new Label();
            txt_upper = new TextBox();
            lab_product_upper = new Label();
            txt_lower = new TextBox();
            lab_txt_lower = new Label();
            txt_material = new TextBox();
            lab_product_material = new Label();
            txt_labor = new TextBox();
            dtgv_product = new DataGridView();
            lab_product_labor = new Label();
            txt_product_name = new TextBox();
            lab_product_name = new Label();
            grb_capacity = new GroupBox();
            txt_hours = new TextBox();
            dtgv_capacity = new DataGridView();
            lab_cap_hours = new Label();
            menu_capacity = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            txt_capacity_budget = new TextBox();
            lab_cap_budget = new Label();
            lab_cap_name = new Label();
            txt_capacity_name = new TextBox();
            menu_main = new MenuStrip();
            lockToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            viToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            changePassToolStripMenuItem = new ToolStripMenuItem();
            managerToolStripMenuItem = new ToolStripMenuItem();
            grb_plan = new GroupBox();
            txt_num = new TextBox();
            lab_plan_N = new Label();
            dtgv_plan = new DataGridView();
            dtpk_creat = new DateTimePicker();
            txt_total_profit = new TextBox();
            lab_plan_profit = new Label();
            lab_plan_date = new Label();
            txt_author = new TextBox();
            lab_plan_author = new Label();
            txt_plan_name = new TextBox();
            lab_plan_name = new Label();
            menu_plan = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            grb_products.SuspendLayout();
            menu_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_product).BeginInit();
            grb_capacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_capacity).BeginInit();
            menu_capacity.SuspendLayout();
            menu_main.SuspendLayout();
            grb_plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_plan).BeginInit();
            menu_plan.SuspendLayout();
            SuspendLayout();
            // 
            // grb_products
            // 
            grb_products.BackColor = Color.Transparent;
            grb_products.Controls.Add(menu_product);
            grb_products.Controls.Add(txt_quantity);
            grb_products.Controls.Add(lab_product_quantity);
            grb_products.Controls.Add(txt_product_profit);
            grb_products.Controls.Add(lab_product_profit);
            grb_products.Controls.Add(txt_upper);
            grb_products.Controls.Add(lab_product_upper);
            grb_products.Controls.Add(txt_lower);
            grb_products.Controls.Add(lab_txt_lower);
            grb_products.Controls.Add(txt_material);
            grb_products.Controls.Add(lab_product_material);
            grb_products.Controls.Add(txt_labor);
            grb_products.Controls.Add(dtgv_product);
            grb_products.Controls.Add(lab_product_labor);
            grb_products.Controls.Add(txt_product_name);
            grb_products.Controls.Add(lab_product_name);
            grb_products.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_products.Location = new Point(6, 39);
            grb_products.Name = "grb_products";
            grb_products.Size = new Size(774, 810);
            grb_products.TabIndex = 0;
            grb_products.TabStop = false;
            grb_products.Text = "Products";
            // 
            // menu_product
            // 
            menu_product.BackColor = Color.PowderBlue;
            menu_product.ImageScalingSize = new Size(20, 20);
            menu_product.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, addToPlanToolStripMenuItem, removeOnPlanToolStripMenuItem });
            menu_product.Location = new Point(3, 25);
            menu_product.Name = "menu_product";
            menu_product.Size = new Size(768, 28);
            menu_product.TabIndex = 26;
            menu_product.Text = "menuStrip4";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(61, 24);
            toolStripMenuItem3.Text = "Add";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(59, 24);
            toolStripMenuItem4.Text = "Edit";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = (Image)resources.GetObject("toolStripMenuItem5.Image");
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(72, 24);
            toolStripMenuItem5.Text = "Delete";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // addToPlanToolStripMenuItem
            // 
            addToPlanToolStripMenuItem.Image = (Image)resources.GetObject("addToPlanToolStripMenuItem.Image");
            addToPlanToolStripMenuItem.Name = "addToPlanToolStripMenuItem";
            addToPlanToolStripMenuItem.Size = new Size(101, 24);
            addToPlanToolStripMenuItem.Text = "Add to plan";
            addToPlanToolStripMenuItem.Click += addToPlanToolStripMenuItem_Click;
            // 
            // removeOnPlanToolStripMenuItem
            // 
            removeOnPlanToolStripMenuItem.Image = (Image)resources.GetObject("removeOnPlanToolStripMenuItem.Image");
            removeOnPlanToolStripMenuItem.Name = "removeOnPlanToolStripMenuItem";
            removeOnPlanToolStripMenuItem.Size = new Size(125, 24);
            removeOnPlanToolStripMenuItem.Text = "Remove on plan";
            removeOnPlanToolStripMenuItem.Click += removeOnPlanToolStripMenuItem_Click;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(658, 119);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(109, 29);
            txt_quantity.TabIndex = 24;
            // 
            // lab_product_quantity
            // 
            lab_product_quantity.AutoSize = true;
            lab_product_quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_quantity.Location = new Point(565, 122);
            lab_product_quantity.Name = "lab_product_quantity";
            lab_product_quantity.Size = new Size(72, 21);
            lab_product_quantity.TabIndex = 23;
            lab_product_quantity.Text = "Quantity";
            // 
            // txt_product_profit
            // 
            txt_product_profit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_product_profit.Location = new Point(445, 119);
            txt_product_profit.Name = "txt_product_profit";
            txt_product_profit.Size = new Size(109, 29);
            txt_product_profit.TabIndex = 22;
            // 
            // lab_product_profit
            // 
            lab_product_profit.AutoSize = true;
            lab_product_profit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_profit.Location = new Point(380, 122);
            lab_product_profit.Name = "lab_product_profit";
            lab_product_profit.Size = new Size(51, 21);
            lab_product_profit.TabIndex = 21;
            lab_product_profit.Text = "Profit";
            // 
            // txt_upper
            // 
            txt_upper.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_upper.Location = new Point(271, 119);
            txt_upper.Name = "txt_upper";
            txt_upper.Size = new Size(92, 29);
            txt_upper.TabIndex = 20;
            // 
            // lab_product_upper
            // 
            lab_product_upper.AutoSize = true;
            lab_product_upper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_upper.Location = new Point(197, 122);
            lab_product_upper.Name = "lab_product_upper";
            lab_product_upper.Size = new Size(56, 21);
            lab_product_upper.TabIndex = 19;
            lab_product_upper.Text = "Upper";
            // 
            // txt_lower
            // 
            txt_lower.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lower.Location = new Point(94, 119);
            txt_lower.Name = "txt_lower";
            txt_lower.Size = new Size(90, 29);
            txt_lower.TabIndex = 18;
            // 
            // lab_txt_lower
            // 
            lab_txt_lower.AutoSize = true;
            lab_txt_lower.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_txt_lower.Location = new Point(23, 122);
            lab_txt_lower.Name = "lab_txt_lower";
            lab_txt_lower.Size = new Size(55, 21);
            lab_txt_lower.TabIndex = 17;
            lab_txt_lower.Text = "Lower";
            // 
            // txt_material
            // 
            txt_material.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_material.Location = new Point(658, 75);
            txt_material.Name = "txt_material";
            txt_material.Size = new Size(109, 29);
            txt_material.TabIndex = 16;
            // 
            // lab_product_material
            // 
            lab_product_material.AutoSize = true;
            lab_product_material.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_material.Location = new Point(570, 78);
            lab_product_material.Name = "lab_product_material";
            lab_product_material.Size = new Size(70, 21);
            lab_product_material.TabIndex = 15;
            lab_product_material.Text = "Material";
            // 
            // txt_labor
            // 
            txt_labor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_labor.Location = new Point(445, 75);
            txt_labor.Name = "txt_labor";
            txt_labor.Size = new Size(109, 29);
            txt_labor.TabIndex = 14;
            // 
            // dtgv_product
            // 
            dtgv_product.AllowUserToAddRows = false;
            dtgv_product.AllowUserToDeleteRows = false;
            dtgv_product.AllowUserToResizeColumns = false;
            dtgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_product.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_product.Location = new Point(6, 168);
            dtgv_product.MultiSelect = false;
            dtgv_product.Name = "dtgv_product";
            dtgv_product.ReadOnly = true;
            dtgv_product.RowHeadersWidth = 51;
            dtgv_product.RowTemplate.Height = 29;
            dtgv_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_product.Size = new Size(762, 636);
            dtgv_product.TabIndex = 11;
            dtgv_product.RowEnter += dtgv_product_RowEnter;
            // 
            // lab_product_labor
            // 
            lab_product_labor.AutoSize = true;
            lab_product_labor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_labor.Location = new Point(380, 78);
            lab_product_labor.Name = "lab_product_labor";
            lab_product_labor.Size = new Size(52, 21);
            lab_product_labor.TabIndex = 13;
            lab_product_labor.Text = "Labor";
            // 
            // txt_product_name
            // 
            txt_product_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_product_name.Location = new Point(94, 75);
            txt_product_name.Name = "txt_product_name";
            txt_product_name.Size = new Size(269, 29);
            txt_product_name.TabIndex = 12;
            // 
            // lab_product_name
            // 
            lab_product_name.AutoSize = true;
            lab_product_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_product_name.Location = new Point(5, 78);
            lab_product_name.Name = "lab_product_name";
            lab_product_name.Size = new Size(68, 21);
            lab_product_name.TabIndex = 11;
            lab_product_name.Text = "Product";
            // 
            // grb_capacity
            // 
            grb_capacity.BackColor = Color.Transparent;
            grb_capacity.Controls.Add(txt_hours);
            grb_capacity.Controls.Add(dtgv_capacity);
            grb_capacity.Controls.Add(lab_cap_hours);
            grb_capacity.Controls.Add(menu_capacity);
            grb_capacity.Controls.Add(txt_capacity_budget);
            grb_capacity.Controls.Add(lab_cap_budget);
            grb_capacity.Controls.Add(lab_cap_name);
            grb_capacity.Controls.Add(txt_capacity_name);
            grb_capacity.Location = new Point(793, 563);
            grb_capacity.Name = "grb_capacity";
            grb_capacity.Size = new Size(622, 286);
            grb_capacity.TabIndex = 1;
            grb_capacity.TabStop = false;
            grb_capacity.Text = "Capacity";
            // 
            // txt_hours
            // 
            txt_hours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_hours.Location = new Point(515, 73);
            txt_hours.Name = "txt_hours";
            txt_hours.Size = new Size(102, 29);
            txt_hours.TabIndex = 32;
            // 
            // dtgv_capacity
            // 
            dtgv_capacity.AllowUserToAddRows = false;
            dtgv_capacity.AllowUserToDeleteRows = false;
            dtgv_capacity.AllowUserToResizeColumns = false;
            dtgv_capacity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_capacity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_capacity.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgv_capacity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_capacity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgv_capacity.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_capacity.Location = new Point(6, 108);
            dtgv_capacity.MultiSelect = false;
            dtgv_capacity.Name = "dtgv_capacity";
            dtgv_capacity.ReadOnly = true;
            dtgv_capacity.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtgv_capacity.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_capacity.RowTemplate.Height = 29;
            dtgv_capacity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_capacity.Size = new Size(613, 172);
            dtgv_capacity.TabIndex = 13;
            dtgv_capacity.RowEnter += dtgv_capacity_RowEnter;
            // 
            // lab_cap_hours
            // 
            lab_cap_hours.AutoSize = true;
            lab_cap_hours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_cap_hours.Location = new Point(445, 76);
            lab_cap_hours.Name = "lab_cap_hours";
            lab_cap_hours.Size = new Size(54, 21);
            lab_cap_hours.TabIndex = 31;
            lab_cap_hours.Text = "Hours";
            // 
            // menu_capacity
            // 
            menu_capacity.BackColor = Color.LightBlue;
            menu_capacity.ImageScalingSize = new Size(20, 20);
            menu_capacity.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            menu_capacity.Location = new Point(3, 28);
            menu_capacity.Name = "menu_capacity";
            menu_capacity.Size = new Size(616, 28);
            menu_capacity.TabIndex = 0;
            menu_capacity.Text = "menuStrip2";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = (Image)resources.GetObject("addToolStripMenuItem.Image");
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(61, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(72, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // txt_capacity_budget
            // 
            txt_capacity_budget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_capacity_budget.Location = new Point(328, 73);
            txt_capacity_budget.Name = "txt_capacity_budget";
            txt_capacity_budget.Size = new Size(108, 29);
            txt_capacity_budget.TabIndex = 30;
            // 
            // lab_cap_budget
            // 
            lab_cap_budget.AutoSize = true;
            lab_cap_budget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_cap_budget.Location = new Point(247, 76);
            lab_cap_budget.Name = "lab_cap_budget";
            lab_cap_budget.Size = new Size(64, 21);
            lab_cap_budget.TabIndex = 29;
            lab_cap_budget.Text = "Budget";
            // 
            // lab_cap_name
            // 
            lab_cap_name.AutoSize = true;
            lab_cap_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_cap_name.Location = new Point(6, 76);
            lab_cap_name.Name = "lab_cap_name";
            lab_cap_name.Size = new Size(53, 21);
            lab_cap_name.TabIndex = 27;
            lab_cap_name.Text = "Name";
            // 
            // txt_capacity_name
            // 
            txt_capacity_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_capacity_name.Location = new Point(77, 73);
            txt_capacity_name.Name = "txt_capacity_name";
            txt_capacity_name.Size = new Size(157, 29);
            txt_capacity_name.TabIndex = 28;
            // 
            // menu_main
            // 
            menu_main.BackColor = Color.LightBlue;
            menu_main.ImageScalingSize = new Size(20, 20);
            menu_main.Items.AddRange(new ToolStripItem[] { lockToolStripMenuItem, languageToolStripMenuItem, reportToolStripMenuItem, accountToolStripMenuItem, managerToolStripMenuItem });
            menu_main.Location = new Point(0, 0);
            menu_main.Name = "menu_main";
            menu_main.Size = new Size(1424, 28);
            menu_main.TabIndex = 2;
            menu_main.Text = "menuStrip3";
            // 
            // lockToolStripMenuItem
            // 
            lockToolStripMenuItem.Image = (Image)resources.GetObject("lockToolStripMenuItem.Image");
            lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            lockToolStripMenuItem.Size = new Size(64, 24);
            lockToolStripMenuItem.Text = "Lock";
            lockToolStripMenuItem.Click += lockToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viToolStripMenuItem, englishToolStripMenuItem });
            languageToolStripMenuItem.Image = (Image)resources.GetObject("languageToolStripMenuItem.Image");
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(91, 24);
            languageToolStripMenuItem.Text = "Language";
            // 
            // viToolStripMenuItem
            // 
            viToolStripMenuItem.Image = (Image)resources.GetObject("viToolStripMenuItem.Image");
            viToolStripMenuItem.Name = "viToolStripMenuItem";
            viToolStripMenuItem.Size = new Size(122, 26);
            viToolStripMenuItem.Text = "Vietnam";
            viToolStripMenuItem.Click += viToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Enabled = false;
            englishToolStripMenuItem.Image = (Image)resources.GetObject("englishToolStripMenuItem.Image");
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(122, 26);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Image = (Image)resources.GetObject("reportToolStripMenuItem.Image");
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(74, 24);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, changePassToolStripMenuItem });
            accountToolStripMenuItem.Image = (Image)resources.GetObject("accountToolStripMenuItem.Image");
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(84, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(184, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // changePassToolStripMenuItem
            // 
            changePassToolStripMenuItem.Image = (Image)resources.GetObject("changePassToolStripMenuItem.Image");
            changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            changePassToolStripMenuItem.Size = new Size(184, 26);
            changePassToolStripMenuItem.Text = "Change pass";
            changePassToolStripMenuItem.Click += changePassToolStripMenuItem_Click;
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.Image = (Image)resources.GetObject("managerToolStripMenuItem.Image");
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(86, 24);
            managerToolStripMenuItem.Text = "Manager";
            managerToolStripMenuItem.Click += managerToolStripMenuItem_Click;
            // 
            // grb_plan
            // 
            grb_plan.BackColor = Color.Transparent;
            grb_plan.Controls.Add(txt_num);
            grb_plan.Controls.Add(lab_plan_N);
            grb_plan.Controls.Add(dtgv_plan);
            grb_plan.Controls.Add(dtpk_creat);
            grb_plan.Controls.Add(txt_total_profit);
            grb_plan.Controls.Add(lab_plan_profit);
            grb_plan.Controls.Add(lab_plan_date);
            grb_plan.Controls.Add(txt_author);
            grb_plan.Controls.Add(lab_plan_author);
            grb_plan.Controls.Add(txt_plan_name);
            grb_plan.Controls.Add(lab_plan_name);
            grb_plan.Controls.Add(menu_plan);
            grb_plan.Location = new Point(793, 39);
            grb_plan.Name = "grb_plan";
            grb_plan.Size = new Size(625, 518);
            grb_plan.TabIndex = 2;
            grb_plan.TabStop = false;
            grb_plan.Text = "Plans";
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_num.Location = new Point(312, 121);
            txt_num.Name = "txt_num";
            txt_num.ReadOnly = true;
            txt_num.Size = new Size(111, 29);
            txt_num.TabIndex = 12;
            // 
            // lab_plan_N
            // 
            lab_plan_N.AutoSize = true;
            lab_plan_N.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_plan_N.Location = new Point(276, 124);
            lab_plan_N.Name = "lab_plan_N";
            lab_plan_N.Size = new Size(26, 21);
            lab_plan_N.TabIndex = 11;
            lab_plan_N.Text = "N:";
            // 
            // dtgv_plan
            // 
            dtgv_plan.AllowUserToAddRows = false;
            dtgv_plan.AllowUserToDeleteRows = false;
            dtgv_plan.AllowUserToResizeColumns = false;
            dtgv_plan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_plan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_plan.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgv_plan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_plan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgv_plan.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_plan.Location = new Point(6, 168);
            dtgv_plan.MultiSelect = false;
            dtgv_plan.Name = "dtgv_plan";
            dtgv_plan.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgv_plan.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgv_plan.RowHeadersWidth = 51;
            dtgv_plan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_plan.RowTemplate.Height = 29;
            dtgv_plan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_plan.Size = new Size(613, 344);
            dtgv_plan.TabIndex = 10;
            dtgv_plan.RowEnter += dtgv_plan_RowEnter;
            // 
            // dtpk_creat
            // 
            dtpk_creat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_creat.Format = DateTimePickerFormat.Short;
            dtpk_creat.Location = new Point(110, 118);
            dtpk_creat.Name = "dtpk_creat";
            dtpk_creat.Size = new Size(150, 29);
            dtpk_creat.TabIndex = 9;
            // 
            // txt_total_profit
            // 
            txt_total_profit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_total_profit.Location = new Point(506, 120);
            txt_total_profit.Name = "txt_total_profit";
            txt_total_profit.ReadOnly = true;
            txt_total_profit.Size = new Size(112, 29);
            txt_total_profit.TabIndex = 8;
            // 
            // lab_plan_profit
            // 
            lab_plan_profit.AutoSize = true;
            lab_plan_profit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_plan_profit.Location = new Point(441, 123);
            lab_plan_profit.Name = "lab_plan_profit";
            lab_plan_profit.Size = new Size(51, 21);
            lab_plan_profit.TabIndex = 7;
            lab_plan_profit.Text = "Profit";
            // 
            // lab_plan_date
            // 
            lab_plan_date.AutoSize = true;
            lab_plan_date.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_plan_date.Location = new Point(26, 118);
            lab_plan_date.Name = "lab_plan_date";
            lab_plan_date.Size = new Size(44, 21);
            lab_plan_date.TabIndex = 5;
            lab_plan_date.Text = "Date";
            // 
            // txt_author
            // 
            txt_author.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_author.Location = new Point(413, 75);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(206, 29);
            txt_author.TabIndex = 4;
            // 
            // lab_plan_author
            // 
            lab_plan_author.AutoSize = true;
            lab_plan_author.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_plan_author.Location = new Point(332, 78);
            lab_plan_author.Name = "lab_plan_author";
            lab_plan_author.Size = new Size(61, 21);
            lab_plan_author.TabIndex = 3;
            lab_plan_author.Text = "Author";
            // 
            // txt_plan_name
            // 
            txt_plan_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_plan_name.Location = new Point(111, 75);
            txt_plan_name.Name = "txt_plan_name";
            txt_plan_name.Size = new Size(190, 29);
            txt_plan_name.TabIndex = 2;
            // 
            // lab_plan_name
            // 
            lab_plan_name.AutoSize = true;
            lab_plan_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_plan_name.Location = new Point(1, 78);
            lab_plan_name.Name = "lab_plan_name";
            lab_plan_name.Size = new Size(84, 21);
            lab_plan_name.TabIndex = 1;
            lab_plan_name.Text = "Plan name";
            // 
            // menu_plan
            // 
            menu_plan.BackColor = Color.PowderBlue;
            menu_plan.ImageScalingSize = new Size(20, 20);
            menu_plan.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, editToolStripMenuItem2, toolStripMenuItem2 });
            menu_plan.Location = new Point(3, 28);
            menu_plan.Name = "menu_plan";
            menu_plan.Size = new Size(619, 28);
            menu_plan.TabIndex = 0;
            menu_plan.Text = "menuStrip4";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 24);
            toolStripMenuItem1.Text = "Add";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem2
            // 
            editToolStripMenuItem2.Image = (Image)resources.GetObject("editToolStripMenuItem2.Image");
            editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            editToolStripMenuItem2.Size = new Size(59, 24);
            editToolStripMenuItem2.Text = "Edit";
            editToolStripMenuItem2.Click += editToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(72, 24);
            toolStripMenuItem2.Text = "Delete";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 32768;
            timer1.Tick += timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1424, 861);
            Controls.Add(grb_plan);
            Controls.Add(grb_capacity);
            Controls.Add(grb_products);
            Controls.Add(menu_main);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Production";
            FormClosing += FormMain_FormClosing;
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            MouseClick += FormMain_MouseClick;
            MouseEnter += FormMain_MouseEnter;
            grb_products.ResumeLayout(false);
            grb_products.PerformLayout();
            menu_product.ResumeLayout(false);
            menu_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_product).EndInit();
            grb_capacity.ResumeLayout(false);
            grb_capacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_capacity).EndInit();
            menu_capacity.ResumeLayout(false);
            menu_capacity.PerformLayout();
            menu_main.ResumeLayout(false);
            menu_main.PerformLayout();
            grb_plan.ResumeLayout(false);
            grb_plan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_plan).EndInit();
            menu_plan.ResumeLayout(false);
            menu_plan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_products;
        private GroupBox grb_capacity;
        private MenuStrip menu_capacity;
        private MenuStrip menu_main;
        private ToolStripMenuItem managerToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private GroupBox grb_plan;
        private MenuStrip menu_plan;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem2;
        private TextBox txt_author;
        private Label lab_plan_author;
        private TextBox txt_plan_name;
        private Label lab_plan_name;
        private DateTimePicker dtpk_creat;
        private TextBox txt_total_profit;
        private Label lab_plan_profit;
        private Label lab_plan_date;
        private DataGridView dtgv_plan;
        private DataGridView dtgv_product;
        private TextBox txt_labor;
        private Label lab_product_labor;
        private TextBox txt_product_name;
        private Label lab_product_name;
        private TextBox txt_material;
        private Label lab_product_material;
        private TextBox txt_upper;
        private Label lab_product_upper;
        private TextBox txt_lower;
        private Label lab_txt_lower;
        private TextBox txt_quantity;
        private Label lab_product_quantity;
        private TextBox txt_product_profit;
        private Label lab_product_profit;
        private TextBox txt_num;
        private Label lab_plan_N;
        private ToolStripMenuItem viToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private MenuStrip menu_product;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem addToPlanToolStripMenuItem;
        private ToolStripMenuItem removeOnPlanToolStripMenuItem;
        private DataGridView dtgv_capacity;
        private TextBox txt_hours;
        private Label lab_cap_hours;
        private TextBox txt_capacity_budget;
        private Label lab_cap_budget;
        private Label lab_cap_name;
        private TextBox txt_capacity_name;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem lockToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem changePassToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}