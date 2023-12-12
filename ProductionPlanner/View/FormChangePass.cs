using ProductionPlanner.Model;
using ProductionPlanner.Object;

namespace ProductionPlanner.View
{
    public partial class FormChangePass : Form
    {
        private string user = "";
        private string pass = "sfksisfhidffif";
        public FormChangePass(string user, string pass)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {
            this.Text = "Change pass: " + user;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Cryption cryption = new Cryption();

            if (!cryption.getMD5(txt_old.Text).Equals(pass))
            {
                MessageBox.Show("Old password is invalid");
                return;
            }

            if (!txt_new.Text.Equals(txt_reenter.Text)) 
            {
                MessageBox.Show("New password is not confirm");
                return;
            }
            Manager mgr = new Manager(user, txt_reenter.Text, false);
            QueryMgr queryMgr = new QueryMgr();
            queryMgr.update(mgr);
            this.Close();
        }
    }
}
