using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class DetailsTableService : TableServiceBase
    {
        protected override string SelectQuery { get; set; } = MyTableSqlCommands.AboutDetails;

        public DataTable EasyTable()
        {
            SelectQuery = MyTableSqlCommands.EasyAboutDetails;
            return GetTable();
        }

        public bool Update(DataTable dataTable)
        {
            return UpdateTable(BuildAdapter(), dataTable);
        }

        private SqlDataAdapter BuildAdapter()
        {
            adapter = new SqlDataAdapter(SelectQuery, connection);
            adapter.InsertCommand = new SqlCommand("sp_CreateDetail", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@dname", SqlDbType.NChar, 50, "Dname"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@dprice", SqlDbType.Int, 10, "Dprice"));
            return adapter;
        }
    }
}
