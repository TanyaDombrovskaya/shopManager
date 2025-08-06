using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using ShopManager.Utilities;

namespace ShopManager.Data
{
    public static class DatabaseManager
    {
        private static readonly string connectionString = GetConnectionString();

        private static string GetConnectionString()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ConfigurationErrorsException("Connection string 'ShopConnection' is missing or empty in App.config.");
                }

                if (connectionString.Contains("Data Source="))
                {
                    var dataSource = connectionString.Split(new[] { "Data Source=" }, StringSplitOptions.None)[1].Split(';')[0];
                    if (!Path.IsPathRooted(dataSource))
                    {
                        var absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataSource);
                        connectionString = connectionString.Replace(dataSource, absolutePath);
                    }
                }

                return connectionString;
            }
            catch (Exception ex)
            {
                throw new ConfigurationErrorsException($"Failed to load connection string: {ex.Message}", ex);
            }
        }

        public static void InitializeDatabase()
        {
            try
            {
                var dbPath = GetDatabasePath();
                var directory = Path.GetDirectoryName(dbPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createUsersTable = @"
                        CREATE TABLE IF NOT EXISTS users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Email TEXT NOT NULL UNIQUE,
                            PasswordHash TEXT NOT NULL,
                            Role TEXT NOT NULL,
                            IsBanned INTEGER NOT NULL DEFAULT 0,
                            CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            Balance DECIMAL(10,2) NOT NULL DEFAULT 0.00
                        )";

                    string createCategoriesTable = @"
                        CREATE TABLE IF NOT EXISTS categories (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL
                        )";

                    string createProductsTable = @"
                        CREATE TABLE IF NOT EXISTS products (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Description TEXT,
                            Price DECIMAL(10,2) NOT NULL,
                            StockQuantity INTEGER NOT NULL,
                            CategoryId INTEGER,
                            FOREIGN KEY (CategoryId) REFERENCES categories(Id)
                        )";

                    string createOrdersTable = @"
                        CREATE TABLE IF NOT EXISTS orders (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            UserId INTEGER NOT NULL,
                            OrderDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            Status TEXT NOT NULL,
                            TotalAmount DECIMAL(10,2) NOT NULL DEFAULT 0,
                            FOREIGN KEY (UserId) REFERENCES users(Id)
                        )";

                    string createOrderDetailsTable = @"
                        CREATE TABLE IF NOT EXISTS orderdetails (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            OrderId INTEGER NOT NULL,
                            ProductId INTEGER NOT NULL,
                            ProductName TEXT NOT NULL,
                            Quantity INTEGER NOT NULL,
                            UnitPrice DECIMAL(10,2) NOT NULL,
                            FOREIGN KEY (OrderId) REFERENCES orders(Id),
                            FOREIGN KEY (ProductId) REFERENCES products(Id)
                        )";

                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createUsersTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createCategoriesTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createProductsTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createOrdersTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createOrderDetailsTable;
                        command.ExecuteNonQuery();
                    }

                    // Миграция: добавляем колонку Balance если её нет
                    try
                    {
                        string checkBalanceColumn = "PRAGMA table_info(users)";
                        bool hasBalanceColumn = false;
                        
                        using (var command = new SQLiteCommand(checkBalanceColumn, connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string columnName = reader["name"].ToString();
                                    if (columnName.Equals("Balance", StringComparison.OrdinalIgnoreCase))
                                    {
                                        hasBalanceColumn = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!hasBalanceColumn)
                        {
                            string addBalanceColumn = "ALTER TABLE users ADD COLUMN Balance DECIMAL(10,2) NOT NULL DEFAULT 0.00";
                            using (var command = new SQLiteCommand(addBalanceColumn, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        FormHelper.ShowError($"Ошибка при добавлении колонки Balance: {ex.Message}");
                    }

                    string checkAdmin = "SELECT COUNT(*) FROM users WHERE Username = 'admin'";
                    using (var command = new SQLiteCommand(checkAdmin, connection))
                    {
                        long count = (long)command.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertAdmin = @"
                                INSERT INTO users (Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance)
                                VALUES ('admin', 'admin@example.com', @PasswordHash, 'Admin', 0, @CreatedAt, 10000.00)";
                            using (var insertCommand = new SQLiteCommand(insertAdmin, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@PasswordHash", PasswordHasher.HashPassword("admin123"));
                                insertCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    // Создание тестового пользователя
                    string checkTestUser = "SELECT COUNT(*) FROM users WHERE Username = 'user'";
                    using (var command = new SQLiteCommand(checkTestUser, connection))
                    {
                        long count = (long)command.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertTestUser = @"
                                INSERT INTO users (Username, Email, PasswordHash, Role, IsBanned, CreatedAt, Balance)
                                VALUES ('user', 'user@example.com', @PasswordHash, 'User', 0, @CreatedAt, 5000.00)";
                            using (var insertCommand = new SQLiteCommand(insertTestUser, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@PasswordHash", PasswordHasher.HashPassword("user123"));
                                insertCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    // Создание категорий
                    string checkCategories = "SELECT COUNT(*) FROM categories";
                    using (var command = new SQLiteCommand(checkCategories, connection))
                    {
                        long count = (long)command.ExecuteScalar();
                        if (count == 0)
                        {
                            string[] categories = { "Электроника", "Одежда", "Книги", "Еда и напитки", "Спорт и отдых" };
                            foreach (string category in categories)
                            {
                                string insertCategory = "INSERT INTO categories (Name) VALUES (@Name)";
                                using (var insertCommand = new SQLiteCommand(insertCategory, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@Name", category);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    // Создание товаров
                    string checkProducts = "SELECT COUNT(*) FROM products";
                    using (var command = new SQLiteCommand(checkProducts, connection))
                    {
                        long count = (long)command.ExecuteScalar();
                        if (count == 0)
                        {
                            var products = new[]
                            {
                                // Электроника (CategoryId = 1)
                                new { Name = "Смартфон Samsung Galaxy", Description = "Современный смартфон с большим экраном", Price = 45000.00m, Stock = 25, CategoryId = 1 },
                                new { Name = "Ноутбук ASUS", Description = "Игровой ноутбук с мощной видеокартой", Price = 85000.00m, Stock = 10, CategoryId = 1 },
                                new { Name = "Наушники Sony", Description = "Беспроводные наушники с шумоподавлением", Price = 15000.00m, Stock = 50, CategoryId = 1 },
                                new { Name = "Планшет iPad", Description = "Планшет Apple с Retina дисплеем", Price = 65000.00m, Stock = 15, CategoryId = 1 },
                                
                                // Одежда (CategoryId = 2)
                                new { Name = "Футболка Nike", Description = "Спортивная футболка из дышащей ткани", Price = 2500.00m, Stock = 100, CategoryId = 2 },
                                new { Name = "Джинсы Levi's", Description = "Классические прямые джинсы", Price = 6500.00m, Stock = 75, CategoryId = 2 },
                                new { Name = "Кроссовки Adidas", Description = "Беговые кроссовки с амортизацией", Price = 8500.00m, Stock = 60, CategoryId = 2 },
                                new { Name = "Куртка зимняя", Description = "Теплая зимняя куртка с капюшоном", Price = 12000.00m, Stock = 30, CategoryId = 2 },
                                
                                // Книги (CategoryId = 3)
                                new { Name = "Война и мир", Description = "Классический роман Л.Н. Толстого", Price = 850.00m, Stock = 200, CategoryId = 3 },
                                new { Name = "Программирование на C#", Description = "Учебник по разработке на C#", Price = 2200.00m, Stock = 80, CategoryId = 3 },
                                new { Name = "Гарри Поттер", Description = "Серия книг о юном волшебнике", Price = 1500.00m, Stock = 150, CategoryId = 3 },
                                
                                // Еда и напитки (CategoryId = 4)
                                new { Name = "Кофе Jacobs", Description = "Растворимый кофе премиум класса", Price = 450.00m, Stock = 300, CategoryId = 4 },
                                new { Name = "Чай Earl Grey", Description = "Черный чай с бергамотом", Price = 320.00m, Stock = 250, CategoryId = 4 },
                                new { Name = "Шоколад Lindt", Description = "Швейцарский молочный шоколад", Price = 380.00m, Stock = 180, CategoryId = 4 },
                                
                                // Спорт и отдых (CategoryId = 5)
                                new { Name = "Мяч футбольный", Description = "Профессиональный футбольный мяч", Price = 2800.00m, Stock = 40, CategoryId = 5 },
                                new { Name = "Велосипед горный", Description = "Горный велосипед с 21 скоростью", Price = 35000.00m, Stock = 8, CategoryId = 5 },
                                new { Name = "Коврик для йоги", Description = "Нескользящий коврик для занятий йогой", Price = 1200.00m, Stock = 90, CategoryId = 5 }
                            };

                            foreach (var product in products)
                            {
                                string insertProduct = @"
                                    INSERT INTO products (Name, Description, Price, StockQuantity, CategoryId)
                                    VALUES (@Name, @Description, @Price, @StockQuantity, @CategoryId)";
                                using (var insertCommand = new SQLiteCommand(insertProduct, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@Name", product.Name);
                                    insertCommand.Parameters.AddWithValue("@Description", product.Description);
                                    insertCommand.Parameters.AddWithValue("@Price", product.Price);
                                    insertCommand.Parameters.AddWithValue("@StockQuantity", product.Stock);
                                    insertCommand.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                FormHelper.ShowError($"Ошибка SQLite при инициализации базы данных: {ex.Message}\nКод ошибки: {ex.ErrorCode}");
            }
            catch (ConfigurationErrorsException ex)
            {
                FormHelper.ShowError($"Ошибка конфигурации: {ex.Message}");
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Общая ошибка при инициализации базы данных: {ex.Message}\nПодробности: {ex.InnerException?.Message}");
            }
        }

        private static string GetDatabasePath()
        {
            var dataSource = connectionString.Split(new[] { "Data Source=" }, StringSplitOptions.None)[1].Split(';')[0];
            return Path.IsPathRooted(dataSource) ? dataSource : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataSource);
        }
    }
}