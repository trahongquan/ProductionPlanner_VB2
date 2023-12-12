using ProductionPlanner.Model;
using ProductionPlanner.Object;

namespace ProductionPlanner.View
{
    public partial class FormMgr : Form
    {
        // Cac thuoc tinh
        private QueryMgr queryMgr = new QueryMgr();
        private Cryption cryption = new Cryption();
        public FormMgr()
        {
            InitializeComponent();
        }

        private bool isVerify(string st)
        {
            FormVerify frVrf = new FormVerify(st);

            if (!frVrf.ShowDialog().Equals(DialogResult.OK))
            {
                return false;
            }

            return true;
        }

        private void FormMgr_Load(object sender, EventArgs e)
        {
            get_table();
        }

        private void get_table()
        {
            try
            {
                dtgv_mgr.DataSource = null;
                dtgv_mgr.DataSource = queryMgr.get_data_source();
                for (int i = 0; i < dtgv_mgr.Rows.Count; ++i)
                {
                    dtgv_mgr.Rows[i].Cells[1].Value =
                        cryption.getDecrypt(dtgv_mgr.Rows[i].Cells[1].Value.ToString());

                    dtgv_mgr.Rows[i].Cells[2].Value = "●●●●●●";
                }
            }
            catch
            { }
        }

        private Manager get_mgr()
        {
            try
            {
                return new Manager(txt_user.Text, txt_pass.Text, ckb_rights.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager mgr = get_mgr();

            if (!isVerify("Vice President"))
            {
                return;
            }

            queryMgr.insert(mgr);
            get_table();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgv_mgr.SelectedRows[0].Cells[0].Value.ToString());
            if (!isVerify("Vice President"))
            {
                return;
            }
            queryMgr.delete(id);
            get_table();
        }

        private void dtgv_mgr_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_user.Text =
                dtgv_mgr.SelectedRows[0].Cells[1].Value.ToString();

                txt_pass.Text = "●●●●●●";

                ckb_rights.Checked =
                    dtgv_mgr.SelectedRows[0].Cells[3].Value.ToString().Equals("True");
            }
            catch
            { }

        }
    }
}
