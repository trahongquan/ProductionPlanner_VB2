
using ProductionPlanner.Object;
using System.Data.SqlClient;
using System.Data;

namespace ProductionPlanner.Model
{
    internal class QueryCapacity
        //truy vấn đến dữ liệu về công suất
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;
        private Cryption cryption = new Cryption();

        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT * FROM Capacity";
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

        public void insert(Capacity capacity)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "INSERT INTO Capacity VALUES ('"
                        + cryption.getEncrypt(capacity.Decrip) + "', '"
                        + cryption.getEncrypt(capacity.Date) + "', "
                        + capacity.Budget + ", "
                        + capacity.Total_work_hours + ")";

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
            string query = "Delete Capacity Where ID = " + ma_so;

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
