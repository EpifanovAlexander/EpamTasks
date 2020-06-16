using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class ProvidersTableService : TableServiceBase
    {
        protected override string SelectQuery { get; set; } = MyTableSqlCommands.AboutProviders;

        public DataTable EasyTable()
        {
            SelectQuery = MyTableSqlCommands.EasyAboutProviders;
            return GetTable();
        }

        public bool Update(DataTable dataTable)
        {
            return UpdateTable(BuildAdapter(), dataTable);
        }

        private SqlDataAdapter BuildAdapter()
        {
            adapter = new SqlDataAdapter(SelectQuery, connection);
            adapter.InsertCommand = new SqlCommand("sp_CreateProvider", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar, 50, "pname"));
            return adapter;
        }
    }
}
