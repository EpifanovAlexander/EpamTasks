using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDetailsAndProviders.Classes
{
    class AdminService
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public bool IsCorrect(Administrator admin)
        {
            bool CorrectAdmin;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"SELECT * FROM Admins
                                            WHERE Admin=@admin AND Pass=@pass";
                    command.Parameters.AddWithValue("@admin", admin.Name);
                    command.Parameters.AddWithValue("@pass", admin.Pass);

                    using (var reader = command.ExecuteReader())
                    {
                        CorrectAdmin = (reader.HasRows) ? true : false;
                    }
                }
            }
            return CorrectAdmin;
        }
    }
}
