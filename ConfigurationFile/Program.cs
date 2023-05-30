using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConfigurationFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ////两种读取DB连接字符串方法均可
            string connection = ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString;
            //connection = ConfigurationManager.ConnectionStrings["localConnection"].ToString();
            Console.WriteLine(connection);

            ////两种读取配置信息方法均可
            string setting = ConfigurationManager.AppSettings["projectName"];
            //setting = ConfigurationManager.AppSettings["projectName"].ToString();
            Console.WriteLine(setting);

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = "select * from Company";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.ExecuteNonQuery();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    var index = sqlDataReader.GetOrdinal("ShortName");
                    Console.WriteLine(sqlDataReader.GetValue(index));
                }
            }
        }
    }
}
