using ProductionPlanner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionPlanner.View
{
    public partial class FormLock : Form
    {
        private bool is_exit = true;
        private string pass
            = "jfksfhiwfy9yfdhfkfhkafhkafhakfhakfh";
        public FormLock(string pass)
        {
            InitializeComponent();
            this.pass = pass;
        }

        private void FormLock_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (is_exit)
            {
                Application.Exit();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Cryption cryption = new Cryption();
            if (cryption.getMD5(txt_pass.Text).Equals(pass))
            {
                is_exit = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Your password is wrong");
            }
        }
    }
}
