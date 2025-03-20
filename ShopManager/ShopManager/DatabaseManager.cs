using MySql.Data.MySqlClient;
using System.Data;

namespace ShopManager
{
    public class DatabaseManager
    {
        private DBConnection _connectionDB;
        private MySqlDataAdapter _adapter;

        public DatabaseManager()
        {
            _connectionDB = new DBConnection();
            _adapter = new MySqlDataAdapter();
        }

        public string GetUser(string login, string password)
        {
            string role = null;

            using (var connection = _connectionDB.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT dostup FROM `users` WHERE `username` = @l AND `password` = @p", connection);
                cmd.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;

                connection.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    role = reader["dostup"].ToString();
                }
            }

            return role;
        }

        //добавить функцию для регистрации
    }
}
