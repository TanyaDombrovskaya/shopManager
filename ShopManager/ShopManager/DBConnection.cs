using MySql.Data.MySqlClient;
using System;

namespace ShopManager
{
    public class DBConnection
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;database=shop2");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        { 
            return connection;
        }
    }
}
