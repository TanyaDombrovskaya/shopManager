using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using ShopManager.Data.Models;

namespace ShopManager.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;

        public void AddUser(User user)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO users (Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance)
                    VALUES (@Username, @Email, @PasswordHash, @Role, @IsBanned, @CreatedAt, @Balance);
                    SELECT last_insert_rowid();";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@IsBanned", user.IsBanned ? 1 : 0);
                    command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt == default ? DateTime.Now : user.CreatedAt);
                    command.Parameters.AddWithValue("@Balance", user.Balance);
                    user.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public User GetUserById(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance FROM users WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Email = reader.IsDBNull(2) ? null : reader.GetString(2),
                                PasswordHash = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Role = reader.IsDBNull(4) ? "User" : reader.GetString(4),
                                IsBanned = reader.IsDBNull(5) ? false : reader.GetInt32(5) == 1,
                                CreatedAt = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6),
                                Balance = reader.IsDBNull(7) ? 0.00m : reader.GetDecimal(7)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public User GetUserByUsername(string username)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance FROM users WHERE Username = @Username";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Email = reader.IsDBNull(2) ? null : reader.GetString(2),
                                PasswordHash = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Role = reader.IsDBNull(4) ? "User" : reader.GetString(4),
                                IsBanned = reader.IsDBNull(5) ? false : reader.GetInt32(5) == 1,
                                CreatedAt = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6),
                                Balance = reader.IsDBNull(7) ? 0.00m : reader.GetDecimal(7)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance FROM users WHERE Email = @Email";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Email = reader.IsDBNull(2) ? null : reader.GetString(2),
                                PasswordHash = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Role = reader.IsDBNull(4) ? "User" : reader.GetString(4),
                                IsBanned = reader.IsDBNull(5) ? false : reader.GetInt32(5) == 1,
                                CreatedAt = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6),
                                Balance = reader.IsDBNull(7) ? 0.00m : reader.GetDecimal(7)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance FROM users";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Email = reader.GetString(2),
                                PasswordHash = reader.GetString(3),
                                Role = reader.GetString(4),
                                IsBanned = reader.GetInt32(5) == 1,
                                CreatedAt = reader.GetDateTime(6),
                                Balance = reader.GetDecimal(7)
                            });
                        }
                    }
                }
            }
            return users;
        }

        public bool UpdateUser(User user)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE users 
                    SET Username = @Username, Email = @Email, PasswordHash = @PasswordHash, 
                        Role = @Role, IsBanned = @IsBanned, Balance = @Balance
                    WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@IsBanned", user.IsBanned ? 1 : 0);
                    command.Parameters.AddWithValue("@Balance", user.Balance);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteUser(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM users WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool BanUser(int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET IsBanned = 1 WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UnbanUser(int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET IsBanned = 0 WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool ChangeRole(int userId, string newRole)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET Role = @Role WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Role", newRole);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public decimal GetBalance(int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Balance FROM users WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetDecimal(0);
                        }
                    }
                }
            }
            return 0.00m;
        }

        public bool AddBalance(int userId, decimal amount)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET Balance = Balance + @Amount WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Amount", amount);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}