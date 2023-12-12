namespace ProductionPlanner.View
{
    partial class FormChangePass
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
            lab_tit = new Label();
            lab_old = new Label();
            txt_old = new TextBox();
            txt_new = new TextBox();
            lab_new = new Label();
            txt_reenter = new TextBox();
            label2 = new Label();
            btn_ok = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // lab_tit
            // 
            lab_tit.AutoSize = true;
            lab_tit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lab_tit.Location = new Point(202, 28);
            lab_tit.Name = "lab_tit";
            lab_tit.Size = new Size(178, 30);
            lab_tit.TabIndex = 0;
            lab_tit.Text = "Password change";
            // 
            // lab_old
            // 
            lab_old.AutoSize = true;
            lab_old.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_old.Location = new Point(57, 86);
            lab_old.Name = "lab_old";
            lab_old.Size = new Size(84, 25);
            lab_old.TabIndex = 1;
            lab_old.Text = "Old pass";
            // 
            // txt_old
            // 
            txt_old.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_old.Location = new Point(157, 83);
            txt_old.Name = "txt_old";
            txt_old.Size = new Size(348, 33);
            txt_old.TabIndex = 2;
            // 
            // txt_new
            // 
            txt_new.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_new.Location = new Point(157, 135);
            txt_new.Name = "txt_new";
            txt_new.Size = new Size(348, 33);
            txt_new.TabIndex = 4;
            // 
            // lab_new
            // 
            lab_new.AutoSize = true;
            lab_new.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_new.Location = new Point(57, 138);
            lab_new.Name = "lab_new";
            lab_new.Size = new Size(93, 25);
            lab_new.TabIndex = 3;
            lab_new.Text = "New pass";
            // 
            // txt_reenter
            // 
            txt_reenter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_reenter.Location = new Point(157, 187);
            txt_reenter.Name = "txt_reenter";
            txt_reenter.Size = new Size(348, 33);
            txt_reenter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 190);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Reenter";
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ok.Location = new Point(234, 242);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 33);
            btn_ok.TabIndex = 7;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel.Location = new Point(333, 242);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(80, 33);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // FormChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(579, 298);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            Controls.Add(txt_reenter);
            Controls.Add(label2);
            Controls.Add(txt_new);
            Controls.Add(lab_new);
            Controls.Add(txt_old);
            Controls.Add(lab_old);
            Controls.Add(lab_tit);
            Name = "FormChangePass";
            Text = "FormChangePass";
            Load += FormChangePass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_tit;
        private Label lab_old;
        private TextBox txt_old;
        private TextBox txt_new;
        private Label lab_new;
        private TextBox txt_reenter;
        private Label label2;
        private Button btn_ok;
        private Button btn_cancel;
    }
}