namespace ProductionPlanner.View
{
    partial class FormMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMgr));
            menuMgr = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lab_user = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            lab_pass = new Label();
            ckb_rights = new CheckBox();
            dtgv_mgr = new DataGridView();
            menuMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_mgr).BeginInit();
            SuspendLayout();
            // 
            // menuMgr
            // 
            menuMgr.BackColor = Color.Transparent;
            menuMgr.ImageScalingSize = new Size(20, 20);
            menuMgr.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            menuMgr.Location = new Point(0, 0);
            menuMgr.Name = "menuMgr";
            menuMgr.Padding = new Padding(5, 2, 0, 2);
            menuMgr.Size = new Size(700, 28);
            menuMgr.TabIndex = 0;
            menuMgr.Text = "menuStrip1";
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
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.BackColor = Color.Transparent;
            lab_user.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_user.ForeColor = SystemColors.ButtonHighlight;
            lab_user.Location = new Point(8, 50);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(43, 21);
            lab_user.TabIndex = 1;
            lab_user.Text = "User";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(60, 47);
            txt_user.Margin = new Padding(3, 2, 3, 2);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(174, 29);
            txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(354, 47);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(174, 29);
            txt_pass.TabIndex = 4;
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.Transparent;
            lab_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_pass.ForeColor = SystemColors.ButtonHighlight;
            lab_pass.Location = new Point(264, 50);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(79, 21);
            lab_pass.TabIndex = 3;
            lab_pass.Text = "Password";
            // 
            // ckb_rights
            // 
            ckb_rights.AutoSize = true;
            ckb_rights.BackColor = Color.Transparent;
            ckb_rights.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_rights.ForeColor = SystemColors.ButtonHighlight;
            ckb_rights.Location = new Point(579, 49);
            ckb_rights.Margin = new Padding(3, 2, 3, 2);
            ckb_rights.Name = "ckb_rights";
            ckb_rights.Size = new Size(99, 25);
            ckb_rights.TabIndex = 5;
            ckb_rights.Text = "Edit rights";
            ckb_rights.UseVisualStyleBackColor = false;
            // 
            // dtgv_mgr
            // 
            dtgv_mgr.AllowUserToAddRows = false;
            dtgv_mgr.AllowUserToResizeRows = false;
            dtgv_mgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_mgr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_mgr.Location = new Point(10, 88);
            dtgv_mgr.Margin = new Padding(3, 2, 3, 2);
            dtgv_mgr.MultiSelect = false;
            dtgv_mgr.Name = "dtgv_mgr";
            dtgv_mgr.ReadOnly = true;
            dtgv_mgr.RowHeadersWidth = 51;
            dtgv_mgr.RowTemplate.Height = 29;
            dtgv_mgr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_mgr.Size = new Size(676, 241);
            dtgv_mgr.TabIndex = 6;
            dtgv_mgr.TabStop = false;
            dtgv_mgr.RowEnter += dtgv_mgr_RowEnter;
            // 
            // FormMgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(dtgv_mgr);
            Controls.Add(ckb_rights);
            Controls.Add(txt_pass);
            Controls.Add(lab_pass);
            Controls.Add(txt_user);
            Controls.Add(lab_user);
            Controls.Add(menuMgr);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMgr;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMgr";
            Text = "Managers";
            Load += FormMgr_Load;
            menuMgr.ResumeLayout(false);
            menuMgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_mgr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMgr;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lab_user;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label lab_pass;
        private CheckBox ckb_rights;
        private DataGridView dtgv_mgr;
    }
}