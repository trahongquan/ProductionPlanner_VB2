using ProductionPlanner.Model;

namespace ProductionPlanner.View
{
    public partial class Login : Form
    {
        private bool is_vie = false;

        private void tran_to_vie()
        {
            lab_tit.Text = "Đăng nhập";
            lab_user.Text = "Tên";
            lab_pass.Text = "Mật khẩu";
            ckb_pass.Text = "Hiện mật khẩu";
            btn_accept.Text = "Xác nhận";
            btn_cancel.Text = "Thoát";
            vietnamToolStripMenuItem.Enabled = false;
            englishToolStripMenuItem.Enabled = true;
            is_vie = true;
        }

        private void tran_to_eng()
        {
            lab_tit.Text = "Login";
            lab_user.Text = "User";
            lab_pass.Text = "Password";
            ckb_pass.Text = "Show password";
            btn_accept.Text = "Accept";
            btn_cancel.Text = "Cancel";
            englishToolStripMenuItem.Enabled = false;
            vietnamToolStripMenuItem.Enabled = true;
            is_vie = false;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            Cryption cryption = new Cryption();
            QueryMgr queryMgr = new QueryMgr();

            string user = cryption.getEncrypt(txt_user.Text);
            string pass = cryption.getMD5(txt_pass.Text);

            int t = queryMgr.login_accept(user, pass);

            if (t != -1)
            {
                Form form = new FormMain(t == 1, is_vie, txt_user.Text, pass);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vietnamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tran_to_vie();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tran_to_eng();
        }

        private void ckb_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !ckb_pass.Checked;
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_accept_Click(sender, e);
            }
        }
    }
}
