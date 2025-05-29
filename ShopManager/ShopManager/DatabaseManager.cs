using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ShopManager
{
    public class DatabaseManager
    {
        private readonly DBConnection _connectionDB;
        private readonly MySqlDataAdapter _adapter;
        private List<string> _idName = new List<string> { "productID", "categoryID", "orderID", "orderDetailID" };

        public DatabaseManager()
        {
            _connectionDB = new DBConnection();
            _adapter = new MySqlDataAdapter();
        }

        public int GetID(string username)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand("SELECT `userID` FROM `users` WHERE `username` = @us", connection))
                {
                    cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? Convert.ToInt32(reader["userID"]) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при получении ID пользователя {username}", ex);
                return 0;
            }
        }

        public string GetUserName(int id)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand("SELECT `username` FROM `users` WHERE `userID` = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? reader["username"].ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при получении имени пользователя с ID {id}", ex);
                return string.Empty;
            }
        }

        public bool AddUser(string login, string password, string name, string surname, string email)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO `users` (`userID`, `username`, `password`, `dostup`, `name`, `surname`, `email`) " +
                    "VALUES (NULL, @u, @p, @d, @n, @s, @e)", connection))
                {
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
            catch (Exception ex)
            {
                LogError($"Ошибка при добавлении пользователя {login}", ex);
                return false;
            }
        }

        public bool UserConnect(string login)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE `users` SET `status` = @st WHERE `username` = @user", connection))
                {
                    cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = "yes";
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = login;

                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при подключении пользователя {login}", ex);
                return false;
            }
        }

        public string UserDostup(int id)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand(
                    "SELECT `dostup` FROM `users` WHERE `userID` = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? reader["dostup"].ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при получении уровня доступа пользователя с ID {id}", ex);
                return null;
            }
        }

        public bool ExitAccaunt(int ID)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE `users` SET `status` = @st WHERE `userID` = @id", connection))
                {
                    cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = "no";
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = ID;

                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при выходе из аккаунта с ID {ID}", ex);
                return false;
            }
        }

        public void LoadTable(DataGridView dataGridView, string table)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var adapter = new MySqlDataAdapter($"SELECT * FROM {table}", connection))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.Invoke((MethodInvoker)(() =>
                    {
                        dataGridView.DataSource = dataTable;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView.Refresh();
                    }));
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при загрузке таблицы {table}", ex);
            }
        }

        public List<string> UserList()
        {
            var users = new List<string>();

            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var command = new MySqlCommand("SELECT username FROM users", connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(reader["username"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Ошибка при получении списка пользователей", ex);
            }

            return users;
        }

        public void ChangePrava(string dostup, string username)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var command = new MySqlCommand(
                    "UPDATE `users` SET `dostup` = @d WHERE `username` = @u", connection))
                {
                    command.Parameters.Add("@d", MySqlDbType.VarChar).Value = dostup;
                    command.Parameters.Add("@u", MySqlDbType.VarChar).Value = username;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при изменении прав пользователя {username}", ex);
                throw;
            }
        }

        public void UserBan(string username)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                using (var command = new MySqlCommand(
                    "UPDATE `users` SET `dostup` = @d WHERE `username` = @u", connection))
                {
                    command.Parameters.Add("@d", MySqlDbType.VarChar).Value = "no";
                    command.Parameters.Add("@u", MySqlDbType.VarChar).Value = username;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при блокировке пользователя {username}", ex);
                throw;
            }
        }

        public string GetColumnNameFromId(string table, int colIndex, MySqlConnection connection)
        {
            try
            {
                int id = colIndex - 1;

                using (var command = new MySqlCommand(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                    "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @t " +
                    "ORDER BY ORDINAL_POSITION " +
                    "LIMIT 1 OFFSET @i", connection))
                {
                    command.Parameters.Add("@t", MySqlDbType.VarChar).Value = table;
                    command.Parameters.Add("@i", MySqlDbType.Int32).Value = id;

                    return command.ExecuteScalar() as string;
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при получении имени столбца для таблицы {table}", ex);
                throw;
            }
        }

        public bool IsPrimaryKey(string table, string columnName, MySqlConnection connection)
        {
            try
            {
                string primaryKeyQuery = @"SELECT COUNT(*) 
                                 FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                                 WHERE TABLE_SCHEMA = DATABASE() 
                                   AND TABLE_NAME = @tableName 
                                   AND COLUMN_NAME = @columnName 
                                   AND CONSTRAINT_NAME = 'PRIMARY'";

                using (var command = new MySqlCommand(primaryKeyQuery, connection))
                {
                    command.Parameters.Add("@tableName", MySqlDbType.VarChar).Value = table;
                    command.Parameters.Add("@columnName", MySqlDbType.VarChar).Value = columnName;

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при проверке первичного ключа для столбца {columnName} в таблице {table}", ex);
                throw;
            }
        }

        public int GetIdByRowNumber(string table, int rowNumber, MySqlConnection connection)
        {
            try
            {
                string idColumnName = table.ToLower() switch
                {
                    "products" => "productID",
                    "categories" => "categoryID",
                    "orders" => "orderID",
                    "orderdetails" => "orderDetailID",
                    _ => throw new ArgumentException("Неизвестное имя таблицы")
                };

                string sql = $"SELECT {idColumnName} FROM {table} ORDER BY {idColumnName} LIMIT 1 OFFSET @rowOffset";

                using (var command = new MySqlCommand(sql, connection))
                {
                    int offset = rowNumber - 1;
                    command.Parameters.AddWithValue("@rowOffset", offset < 0 ? 0 : offset);

                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при получении ID для строки {rowNumber} из таблицы {table}", ex);
                return -1;
            }
        }

        public void ChangeValue(string table, int rowIndex, int colIndex, object newValue)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    connection.Open();

                    int id = GetIdByRowNumber(table, rowIndex, connection);
                    if (id == -1)
                        throw new InvalidOperationException("Не удалось найти запись с указанным номером строки.");

                    string columnName = GetColumnNameFromId(table, colIndex, connection);
                    if (string.IsNullOrEmpty(columnName))
                        throw new ArgumentException("Указанный столбец не найден");

                    if (table.Equals("orders", StringComparison.OrdinalIgnoreCase) &&
                        columnName.Equals("orderDate", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new InvalidOperationException("Невозможно изменить значение в столбце 'orderDate' таблицы 'orders'.");
                    }

                    if (IsPrimaryKey(table, columnName, connection))
                    {
                        throw new InvalidOperationException($"Невозможно изменить значение столбца '{columnName}' так как он является первичным или внешним ключом");
                    }

                    string primaryKey = table switch
                    {
                        "products" => "productID",
                        "categories" => "categoryID",
                        "orders" => "orderID",
                        "orderdetails" => "orderDetailID",
                        _ => throw new ArgumentException("Неизвестное имя таблицы")
                    };


                    using (var command = new MySqlCommand($"UPDATE `{table}` SET `{columnName}` = @nv WHERE `{primaryKey}` = @id", connection))
                    {
                        command.Parameters.Add("@nv", MySqlDbType.VarChar).Value = newValue.ToString();
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                        if (command.ExecuteNonQuery() == 0)
                            throw new InvalidOperationException("Не удалось обновить значение. Возможно, указанный ID не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при изменении значения в таблице {table}", ex);
                throw;
            }
        }

        public int GetRowsCount(string table)
        {
            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    using (var command = new MySqlCommand($"SELECT COUNT(*) FROM {table}", connection))
                    {
                        connection.Open();

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Ошибка ", ex);
                return 0;
            }
        }

        public string GetIdName(string table)
        {
            switch (table.ToLower())
            {
                case "products":
                    return _idName[0];
                case "categories":
                    return _idName[1];
                case "orders":
                    return _idName[2];
                case "orderdetails":
                    return _idName[3];
                default:
                    throw new ArgumentException($"Неизвестная таблица: {table}");
            }
        }

        public void DeleteRow(string table, int rowId)
        {
            string idName = GetIdName(table);

            try
            {
                using (var connection = _connectionDB.GetConnection())
                {
                    using (var command = new MySqlCommand($"DELETE FROM {table} WHERE {idName} = @id", connection))
                    {
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = rowId;

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Ошибка при удалении строки из таблицы {table}", ex);
            }
        }

        private void LogError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}");
        }
    }
}