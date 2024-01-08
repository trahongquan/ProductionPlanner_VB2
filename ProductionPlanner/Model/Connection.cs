using System.Data.SqlClient;

namespace ProductionPlanner.Model
{
    internal class Connection
    {
        private static string link = @"Data Source=Trhquan\TRHQUANMS;Initial Catalog=ProductDB;Integrated Security=True";

        public Connection()
        {

        }
        public static SqlConnection getConnection()
        {
            SqlConnection x = new SqlConnection();
            try
            {
                x = new SqlConnection(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo liên kết\n" + ex.Message);
                throw ex;
            }

            return x;
        }
    }
}
