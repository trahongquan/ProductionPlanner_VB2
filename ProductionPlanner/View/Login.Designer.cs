namespace ProductionPlanner.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lab_tit = new Label();
            lab_user = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            lab_pass = new Label();
            ckb_pass = new CheckBox();
            btn_accept = new Button();
            btn_cancel = new Button();
            menuStrip1 = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            vietnamToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lab_tit
            // 
            lab_tit.AutoSize = true;
            lab_tit.BackColor = Color.Transparent;
            lab_tit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lab_tit.ForeColor = Color.MidnightBlue;
            lab_tit.Location = new Point(320, 34);
            lab_tit.Margin = new Padding(5, 0, 5, 0);
            lab_tit.Name = "lab_tit";
            lab_tit.Size = new Size(74, 32);
            lab_tit.TabIndex = 0;
            lab_tit.Text = "Login";
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.BackColor = Color.Transparent;
            lab_user.ForeColor = SystemColors.ActiveCaptionText;
            lab_user.Location = new Point(158, 110);
            lab_user.Margin = new Padding(5, 0, 5, 0);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(56, 25);
            lab_user.TabIndex = 1;
            lab_user.Text = "User:";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(258, 107);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(366, 33);
            txt_user.TabIndex = 2;
            txt_user.Text = "admin";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(258, 165);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(366, 33);
            txt_pass.TabIndex = 4;
            txt_pass.Text = "123";
            txt_pass.UseSystemPasswordChar = true;
            txt_pass.KeyPress += txt_pass_KeyPress;
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.Transparent;
            lab_pass.ForeColor = SystemColors.ActiveCaptionText;
            lab_pass.Location = new Point(108, 165);
            lab_pass.Margin = new Padding(5, 0, 5, 0);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(96, 25);
            lab_pass.TabIndex = 3;
            lab_pass.Text = "Password:";
            // 
            // ckb_pass
            // 
            ckb_pass.AutoSize = true;
            ckb_pass.BackColor = Color.Transparent;
            ckb_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_pass.ForeColor = SystemColors.ActiveCaptionText;
            ckb_pass.Location = new Point(258, 220);
            ckb_pass.Name = "ckb_pass";
            ckb_pass.Size = new Size(162, 29);
            ckb_pass.TabIndex = 5;
            ckb_pass.Text = "Show password";
            ckb_pass.UseVisualStyleBackColor = false;
            ckb_pass.CheckedChanged += ckb_pass_CheckedChanged;
            // 
            // btn_accept
            // 
            btn_accept.BackColor = Color.LightBlue;
            btn_accept.BackgroundImageLayout = ImageLayout.None;
            btn_accept.ForeColor = SystemColors.ActiveCaptionText;
            btn_accept.Location = new Point(283, 290);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new Size(102, 42);
            btn_accept.TabIndex = 6;
            btn_accept.Text = "Accept";
            btn_accept.UseVisualStyleBackColor = false;
            btn_accept.Click += btn_accept_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.LightBlue;
            btn_cancel.BackgroundImageLayout = ImageLayout.None;
            btn_cancel.ForeColor = SystemColors.ActiveCaptionText;
            btn_cancel.Location = new Point(400, 290);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(102, 42);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(732, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vietnamToolStripMenuItem, englishToolStripMenuItem });
            languageToolStripMenuItem.Image = (Image)resources.GetObject("languageToolStripMenuItem.Image");
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(91, 24);
            languageToolStripMenuItem.Text = "Language";
            // 
            // vietnamToolStripMenuItem
            // 
            vietnamToolStripMenuItem.Image = (Image)resources.GetObject("vietnamToolStripMenuItem.Image");
            vietnamToolStripMenuItem.Name = "vietnamToolStripMenuItem";
            vietnamToolStripMenuItem.Size = new Size(122, 26);
            vietnamToolStripMenuItem.Text = "Vietnam";
            vietnamToolStripMenuItem.Click += vietnamToolStripMenuItem_Click;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 373);
            Controls.Add(btn_cancel);
            Controls.Add(btn_accept);
            Controls.Add(ckb_pass);
            Controls.Add(txt_pass);
            Controls.Add(lab_pass);
            Controls.Add(txt_user);
            Controls.Add(lab_user);
            Controls.Add(lab_tit);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Login";
            Text = "Login";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_tit;
        private Label lab_user;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label lab_pass;
        private CheckBox ckb_pass;
        private Button btn_accept;
        private Button btn_cancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem vietnamToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
    }
}