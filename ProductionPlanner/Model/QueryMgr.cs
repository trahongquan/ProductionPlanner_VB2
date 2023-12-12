using ProductionPlanner.Object;
using System.Data.SqlClient;
using System.Data;

namespace ProductionPlanner.Model
{
    internal class QueryMgr
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;
        private Cryption cryption = new Cryption();

        public int login_accept(string user, string password)
        {
            try
            {
                SqlConnection adminCnt = Connection.getConnection();
                adminCnt.Open();

                string query = "select id from Manager WHERE username = '" + user + "' and password = '" + password + "'";

                SqlCommand cmd = new SqlCommand(query, adminCnt);

                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read())
                {
                    data.Close();
                    cmd.Cancel();

                    query = "select id from Manager WHERE username = '" + user + "' and password = '" + password + "' and edit_right = 0";
                    cmd = new SqlCommand(query, adminCnt);
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        adminCnt.Close();
                        return 0;
                    }
                    data.Close();
                    cmd.Cancel();

                    query = "select id from Manager WHERE username = '" + user + "' and password = '" + password + "' and edit_right = 1";
                    cmd = new SqlCommand(query, adminCnt);
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        adminCnt.Close();
                        return 1;
                    }
                    data.Close();
                    cmd.Cancel();

                    adminCnt.Close();
                }

                adminCnt.Close();
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT id AS 'ID', username AS 'Username', " +
                "password AS 'Password', edit_right AS 'edit_right'" +
                " FROM Manager";
            try
            {
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(accountTab);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

            return accountTab;
        }

        public void insert(Manager mgr)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            string st = "0";
            if (mgr.Edit_rights) 
            {
                st = "1";
            }

            try
            {
                string query = "INSERT INTO Manager VALUES ('"
                        + cryption.getEncrypt(mgr.Use_name) + "', '"
                        + mgr.get_password() + "', "
                        + st + ")";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void update(Manager mgr)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE Manager SET "
                            + "password = '" + mgr.get_password()
                            + "' WHERE username = '" + cryption.getEncrypt(mgr.Use_name) + "'";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void delete(int ma_so)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete Manager Where ID = " + ma_so;

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n", ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
