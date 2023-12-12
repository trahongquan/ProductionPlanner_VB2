using ProductionPlanner.Object;
using System.Data.SqlClient;
using System.Data;

namespace ProductionPlanner.Model
{
    internal class QueryProduct
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;
        private Cryption cryption = new Cryption();

        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT * FROM Products";
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

        public void insert(Product product)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "INSERT INTO Products VALUES ('"
                        + cryption.getEncrypt(product.Name) + "', "
                        + product.Material_cost + ", "
                        + product.Labor_cost + ", "
                        + product.Lower + ", "
                        + product.Upper + ", "
                        + product.Profit + ")";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn insert Products\n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void update(Product product)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE Products SET "
                            + "name = '" + cryption.getEncrypt(product.Name)
                            + "', material_cost = " + product.Material_cost
                            + ", labor_cost = " + product.Labor_cost
                            + ", _lower = " + product.Lower
                            + ", _upper = " + product.Upper
                            + ", profit = " + product.Profit
                        + "WHERE id = " + product.Id;

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn update Products\n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void delete(int ID)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete Products Where ID = " + ID;

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
