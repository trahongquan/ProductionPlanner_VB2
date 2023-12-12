namespace ProductionPlanner.View
{
    partial class FormVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerify));
            lab_tit = new Label();
            lab_verify = new Label();
            txt_code = new TextBox();
            btn_ok = new Button();
            btn_esc = new Button();
            lab_countdown = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lab_tit
            // 
            lab_tit.AutoSize = true;
            lab_tit.BackColor = Color.Transparent;
            lab_tit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_tit.ForeColor = Color.Yellow;
            lab_tit.Location = new Point(181, 52);
            lab_tit.Name = "lab_tit";
            lab_tit.Size = new Size(165, 37);
            lab_tit.TabIndex = 0;
            lab_tit.Text = "Verification";
            // 
            // lab_verify
            // 
            lab_verify.AutoSize = true;
            lab_verify.BackColor = Color.Transparent;
            lab_verify.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lab_verify.ForeColor = SystemColors.ButtonHighlight;
            lab_verify.Location = new Point(43, 120);
            lab_verify.Name = "lab_verify";
            lab_verify.Size = new Size(75, 32);
            lab_verify.TabIndex = 1;
            lab_verify.Text = "Verify";
            // 
            // txt_code
            // 
            txt_code.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_code.Location = new Point(124, 117);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(340, 39);
            txt_code.TabIndex = 2;
            txt_code.KeyPress += txt_code_KeyPress;
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.Location = new Point(181, 185);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 35);
            btn_ok.TabIndex = 3;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_esc
            // 
            btn_esc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_esc.Location = new Point(271, 185);
            btn_esc.Name = "btn_esc";
            btn_esc.Size = new Size(75, 35);
            btn_esc.TabIndex = 4;
            btn_esc.Text = "ESC";
            btn_esc.UseVisualStyleBackColor = true;
            btn_esc.Click += btn_esc_Click;
            // 
            // lab_countdown
            // 
            lab_countdown.AutoSize = true;
            lab_countdown.BackColor = Color.Transparent;
            lab_countdown.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_countdown.ForeColor = Color.Yellow;
            lab_countdown.Location = new Point(12, 23);
            lab_countdown.Name = "lab_countdown";
            lab_countdown.Size = new Size(60, 47);
            lab_countdown.TabIndex = 5;
            lab_countdown.Text = "90";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormVerify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(495, 250);
            Controls.Add(lab_countdown);
            Controls.Add(btn_esc);
            Controls.Add(btn_ok);
            Controls.Add(txt_code);
            Controls.Add(lab_verify);
            Controls.Add(lab_tit);
            Name = "FormVerify";
            Text = "Verify";
            FormClosed += FormVerify_FormClosed;
            Load += FormVerify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_tit;
        private Label lab_verify;
        private TextBox txt_code;
        private Button btn_ok;
        private Button btn_esc;
        private Label lab_countdown;
        private System.Windows.Forms.Timer timer1;
    }
}