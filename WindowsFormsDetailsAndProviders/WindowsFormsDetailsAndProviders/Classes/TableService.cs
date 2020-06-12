using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class TableService
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlDataAdapter adapter;


        public DataTable GetTable(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, new SqlConnection(connectionString));
            adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        public bool UpdateTable(int SelectedIndex, DataTable dataTable)
        {
            bool result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                switch (SelectedIndex)
                {
                    case 0:
                        {
                            adapter = new SqlDataAdapter("Select * From Details", connection);
                            adapter.InsertCommand = new SqlCommand("sp_CreateDetail", connection);
                            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@dname", SqlDbType.NChar, 50, "Dname"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@dprice", SqlDbType.Int, 10, "Dprice"));
                            break;
                        }
                    case 1:
                        {
                            adapter = new SqlDataAdapter("Select * From Providers", connection);
                            adapter.InsertCommand = new SqlCommand("sp_CreateProvider", connection);
                            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar, 50, "pname"));
                            break;
                        }
                    case 2:
                        {
                            adapter = new SqlDataAdapter("Select * FROM Delivery", connection);
                            adapter.InsertCommand = new SqlCommand("sp_CreateNewDelivery", connection);
                            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pnum", SqlDbType.Int, 10, "pnum"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dnum", SqlDbType.Int, 10, "dnum"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Volume", SqlDbType.Int, 10, "volume"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime, 100, "date"));
                            break;
                        }
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                try
                {
                    adapter.Update(dataTable);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;
        }

    }
}
