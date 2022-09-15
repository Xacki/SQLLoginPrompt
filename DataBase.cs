using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQLLoginPrompt
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=vk ;Integrated Security=True");

        public  void OpenConnection()
        {
            if (sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

    }
}
