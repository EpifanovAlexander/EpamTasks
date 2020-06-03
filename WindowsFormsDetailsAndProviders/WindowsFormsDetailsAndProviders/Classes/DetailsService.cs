using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WorkWithAdo
{
    class DetailsService
    {
        static string connectionString = @"Data Source=(local);Initial Catalog=ProvidersAndDetails;Integrated Security=SSPI;Pooling=False";

        public static Details Get(int key)
        {
            Details detail = new Details();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"SELECT Dnum, Dname, Dprice
                                            FROM Details
                                            WHERE Dnum = @Key";
                    command.Parameters.AddWithValue("@Key", key);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                detail.Dnum = reader.GetInt32(0);
                                detail.Dname = reader.GetString(1);
                                detail.Dprice = reader.GetInt32(2);
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Ошибка! Записи с таким номером нет в базе данных!");
                        }
                    }
                }
                connection.Close();
            }
            return detail;
        }

        public static List<Details> GetTop(int top)
        {
            List<Details> details = new List<Details>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    if (top > 0)
                    {
                        command.CommandText = $@"SELECT Top(@number) Dnum, Dname, Dprice
                                                FROM Details";
                        command.Parameters.AddWithValue("@number", top);
                    }
                    else
                    {
                        command.CommandText = @"SELECT * FROM Details";
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                details.Add(new Details(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return details;
        }


        public static bool Insert(Details detail)
        {
            int result;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"INSERT INTO Details VALUES (@Dname, @Dprice)";
                    command.Parameters.AddWithValue("@Dname", detail.Dname);
                    command.Parameters.AddWithValue("@Dprice", detail.Dprice);

                    result = command.ExecuteNonQuery();                    
                }
                connection.Close();
            }
            if (result.Equals(1)) return true;
            else return false;
        }


        public static bool Update(int key, Details detail)
        {
            int result;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"UPDATE Details
                                             SET Dname=@Dname, Dprice=@Dprice WHERE Dnum=@Dnum";
                    command.Parameters.AddWithValue("@Dnum", key);
                    command.Parameters.AddWithValue("@Dname", detail.Dname);
                    command.Parameters.AddWithValue("@Dprice", detail.Dprice);

                    result = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            if (result >= 1) return true;
            else return false;
        }


        public static bool Delete(int key)
        {
            int result;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Delete From Details where Dnum = @Key";
                    command.Parameters.AddWithValue("@Key", key);
                    result = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            if (result.Equals(1)) return true;
            else return false;
        }

    }
}
