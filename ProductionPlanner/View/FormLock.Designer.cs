﻿namespace ProductionPlanner.View
{
    partial class FormLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLock));
            label1 = new Label();
            txt_pass = new TextBox();
            btn_ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(168, 12);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(441, 43);
            txt_pass.TabIndex = 1;
            // 
            // btn_ok
            // 
            btn_ok.BackColor = SystemColors.HotTrack;
            btn_ok.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ok.ForeColor = SystemColors.ButtonHighlight;
            btn_ok.Location = new Point(394, 61);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(94, 40);
            btn_ok.TabIndex = 2;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // FormLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(621, 113);
            Controls.Add(btn_ok);
            Controls.Add(txt_pass);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLock";
            Text = "Unlock";
            FormClosed += FormLock_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_pass;
        private Button btn_ok;
    }
}