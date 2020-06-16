using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class TableServiceBase
    {
        protected static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected SqlConnection connection = new SqlConnection(connectionString);

        protected SqlDataAdapter adapter;
        protected virtual string SelectQuery { get; set; }


        public DataTable GetTable()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(new SqlCommand(SelectQuery, connection));
                adapter.Fill(table);
            }
            return table;
        }


        protected bool UpdateTable(SqlDataAdapter adapter, DataTable dataTable)
        {
            bool result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
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
