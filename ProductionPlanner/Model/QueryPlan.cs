using ProductionPlanner.Object;
using System.Data.SqlClient;
using System.Data;

namespace ProductionPlanner.Model
{
    internal class QueryPlan
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;
        private Cryption cryption = new Cryption();

        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT * FROM Plans";
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

        public void insert(Plan plan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "INSERT INTO Plans VALUES ('"
                        + cryption.getEncrypt(plan.Name) + "', '"
                        + cryption.getEncrypt(plan.Author) + "', '"
                        + cryption.getEncrypt(plan.Date) + "', '"
                        + plan.get_list_id() + "',"
                        + plan.Total_profit + ")";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn insert Plans\n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void update(Plan plan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE Plans SET "
                            + "author = '" + cryption.getEncrypt(plan.Author)
                            + "', creat_date = '" + cryption.getEncrypt(plan.Date)
                            + "', list_product = '" + plan.get_list_id()
                            + "', total_profit = " + plan.Total_profit
                        + "WHERE id = " + plan.Id;

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn update Plans\n" + ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void delete(int id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete Plan Where id = " + id;

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();
            }
            catch 
            {

            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
