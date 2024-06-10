using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
    internal class ConnectDb
    {
        private static string connectionString;

        static ConnectDb()
        {
            connectionString = "Data Source=DESKTOP-LQ6C6N6;Initial Catalog=QuanLy;Integrated Security=True";
        }
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }
    }
}
