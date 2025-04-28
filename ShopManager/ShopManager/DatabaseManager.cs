using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

    public int GetID(string username)
        {
            int ID = 0;

            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT `userID` FROM `users` WHERE `username` = @us", connection);
                    cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;

                    connection.Open();

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ID = Convert.ToInt32(reader["userID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            return ID;
        }

        public string GetUserName(int id)
        {
            string userName = "";

            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT `username` FROM `users` WHERE `userID` = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        userName = reader["username"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            return userName;
        }

        public bool AddUser(string login, string password, string name, string surname, string email)
        {
            using (var connection = _connectionDB.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` " +
                    "(`userID`, `username`, `password`, `dostup`, `name`, `surname`, `email`) " +
                    "VALUES (NULL, @u, @p, @d, @n, @s, @e)", connection);

                cmd.Parameters.Add("@u", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@d", MySqlDbType.VarChar).Value = "user";
                cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = surname;
                cmd.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;

                connection.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool UserConnect(string login)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `status` = @st WHERE `username` = @user", connection);
                    cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = "yes";
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = login;

                    connection.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка доступа к базе данных: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.GetType().Name} - {ex.Message}");
                return false;
            }
        }

        public string UserDostup(int id)
        {
            string dostup = null;

            using (var connection = _connectionDB.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT `dostup` FROM `users` WHERE `userID` = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dostup = reader["dostup"].ToString();
                }
            }

            return dostup;
        }

        public bool ExitAccaunt(int ID)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `status` = @st WHERE `userID` = @id", connection);
                    cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = "no";
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = ID;

                    connection.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка доступа к базе данных: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.GetType().Name} - {ex.Message}");
                return false;
            }
        }

        public void LoadTable(DataGridView dataGridView, string table)
        {
            string query = $"SELECT * FROM {table}";

            using (var connection = _connectionDB.GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.Refresh();
            }
        }

        public List<string> UserList()
        {
            List<string> users = new List<string>();

            using (var connection = _connectionDB.GetConnection())
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT username FROM users", connection);

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(reader["username"].ToString());
                    }
                }
            }

            return users;
        }

        public void ChangePrava(string dostup, string username)
        {
            using (var connection = _connectionDB.GetConnection())
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `dostup` = @d WHERE `username` = @u", connection);
                command.Parameters.Add("@d", MySqlDbType.VarChar).Value = dostup;
                command.Parameters.Add("@u", MySqlDbType.VarChar).Value = username;

                command.ExecuteNonQuery();
            }
        }

    }
}
