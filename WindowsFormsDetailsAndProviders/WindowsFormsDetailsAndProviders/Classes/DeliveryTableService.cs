using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class DeliveryTableService : TableServiceBase
    {
        protected override string SelectQuery { get; set; } = MyTableSqlCommands.AboutDelivery;

        public DataTable EasyTable()
        {
            SelectQuery = MyTableSqlCommands.EasyAboutDelivery;
            return GetTable();
        }

        public bool Update(DataTable dataTable)
        {
            return UpdateTable(BuildAdapter(), dataTable);
        }

        private SqlDataAdapter BuildAdapter()
        {
            adapter = new SqlDataAdapter(SelectQuery, connection);
            adapter.InsertCommand = new SqlCommand("sp_CreateNewDelivery", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pnum", SqlDbType.Int, 10, "pnum"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dnum", SqlDbType.Int, 10, "dnum"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Volume", SqlDbType.Int, 10, "volume"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime, 100, "date"));
            return adapter;
        }
    }
}
