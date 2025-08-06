using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using ShopManager.Data.Models;

namespace ShopManager.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;

        public int AddProduct(Product product)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO products (Name, Description, Price, StockQuantity, CategoryId)
                    VALUES (@Name, @Description, @Price, @StockQuantity, @CategoryId);
                    SELECT last_insert_rowid();";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId ?? (object)DBNull.Value);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public Product GetProductById(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.*, c.Name AS CategoryName 
                    FROM products p 
                    LEFT JOIN categories c ON p.CategoryId = c.Id 
                    WHERE p.Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4),
                                CategoryId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                CategoryName = reader.IsDBNull(6) ? null : reader.GetString(6)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.*, c.Name AS CategoryName 
                    FROM products p 
                    LEFT JOIN categories c ON p.CategoryId = c.Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4),
                                CategoryId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                CategoryName = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return products;
        }

        public IEnumerable<Product> GetByCategory(int categoryId)
        {
            var products = new List<Product>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.*, c.Name AS CategoryName 
                    FROM products p 
                    LEFT JOIN categories c ON p.CategoryId = c.Id 
                    WHERE p.CategoryId = @CategoryId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4),
                                CategoryId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                CategoryName = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return products;
        }

        public bool UpdateProduct(Product product)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE products 
                    SET Name = @Name, Description = @Description, Price = @Price, 
                        StockQuantity = @StockQuantity, CategoryId = @CategoryId 
                    WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId ?? (object)DBNull.Value);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteProduct(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM products WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateStockQuantity(int productId, int quantity)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE products 
                    SET StockQuantity = StockQuantity + @Quantity 
                    WHERE Id = @Id AND (StockQuantity + @Quantity) >= 0";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", productId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}