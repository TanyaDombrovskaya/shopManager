using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using ShopManager.Data.Models;

namespace ShopManager.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;

        public void CreateOrder(Order order)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertOrder = @"
                            INSERT INTO orders (UserId, OrderDate, Status, TotalAmount)
                            VALUES (@UserId, @OrderDate, @Status, @TotalAmount);
                            SELECT last_insert_rowid();";
                        using (var command = new SQLiteCommand(insertOrder, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", order.UserId);
                            command.Parameters.AddWithValue("@OrderDate", order.OrderDate == default ? DateTime.Now : order.OrderDate);
                            command.Parameters.AddWithValue("@Status", order.Status);
                            command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                            order.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                        string insertDetail = @"
                            INSERT INTO orderdetails (OrderId, ProductId, ProductName, Quantity, UnitPrice)
                            VALUES (@OrderId, @ProductId, @ProductName, @Quantity, @UnitPrice)";
                        foreach (var detail in order.Details ?? new List<OrderDetail>())
                        {
                            using (var command = new SQLiteCommand(insertDetail, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderId", order.Id);
                                command.Parameters.AddWithValue("@ProductId", detail.ProductId);
                                command.Parameters.AddWithValue("@ProductName", detail.ProductName ?? string.Empty);
                                command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                command.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public Order GetOrderById(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT o.Id, o.UserId, o.OrderDate, o.Status, o.TotalAmount,
                           od.Id AS DetailId, od.OrderId, od.ProductId, od.ProductName, od.Quantity, od.UnitPrice
                    FROM orders o
                    LEFT JOIN orderdetails od ON o.Id = od.OrderId
                    WHERE o.Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        Order order = null;
                        while (reader.Read())
                        {
                            if (order == null)
                            {
                                order = new Order
                                {
                                    Id = reader.GetInt32(0),
                                    UserId = reader.GetInt32(1),
                                    OrderDate = reader.GetDateTime(2),
                                    Status = reader.GetString(3),
                                    TotalAmount = reader.GetDecimal(4),
                                    Details = new List<OrderDetail>()
                                };
                            }

                            if (!reader.IsDBNull(5))
                            {
                                order.Details.Add(new OrderDetail
                                {
                                    Id = reader.GetInt32(5),
                                    OrderId = reader.GetInt32(6),
                                    ProductId = reader.GetInt32(7),
                                    ProductName = reader.GetString(8),
                                    Quantity = reader.GetInt32(9),
                                    UnitPrice = reader.GetDecimal(10)
                                });
                            }
                        }
                        return order;
                    }
                }
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = new Dictionary<int, Order>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT o.Id, o.UserId, o.OrderDate, o.Status, o.TotalAmount,
                           od.Id AS DetailId, od.OrderId, od.ProductId, od.ProductName, od.Quantity, od.UnitPrice
                    FROM orders o
                    LEFT JOIN orderdetails od ON o.Id = od.OrderId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            if (!orders.ContainsKey(orderId))
                            {
                                orders[orderId] = new Order
                                {
                                    Id = orderId,
                                    UserId = reader.GetInt32(1),
                                    OrderDate = reader.GetDateTime(2),
                                    Status = reader.GetString(3),
                                    TotalAmount = reader.GetDecimal(4),
                                    Details = new List<OrderDetail>()
                                };
                            }

                            if (!reader.IsDBNull(5))
                            {
                                orders[orderId].Details.Add(new OrderDetail
                                {
                                    Id = reader.GetInt32(5),
                                    OrderId = reader.GetInt32(6),
                                    ProductId = reader.GetInt32(7),
                                    ProductName = reader.GetString(8),
                                    Quantity = reader.GetInt32(9),
                                    UnitPrice = reader.GetDecimal(10)
                                });
                            }
                        }
                    }
                }
            }
            return orders.Values;
        }

        public IEnumerable<Order> GetUserOrders(int userId)
        {
            var orders = new Dictionary<int, Order>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT o.Id, o.UserId, o.OrderDate, o.Status, o.TotalAmount,
                           od.Id AS DetailId, od.OrderId, od.ProductId, od.ProductName, od.Quantity, od.UnitPrice
                    FROM orders o
                    LEFT JOIN orderdetails od ON o.Id = od.OrderId
                    WHERE o.UserId = @UserId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            if (!orders.ContainsKey(orderId))
                            {
                                orders[orderId] = new Order
                                {
                                    Id = orderId,
                                    UserId = reader.GetInt32(1),
                                    OrderDate = reader.GetDateTime(2),
                                    Status = reader.GetString(3),
                                    TotalAmount = reader.GetDecimal(4),
                                    Details = new List<OrderDetail>()
                                };
                            }

                            if (!reader.IsDBNull(5))
                            {
                                orders[orderId].Details.Add(new OrderDetail
                                {
                                    Id = reader.GetInt32(5),
                                    OrderId = reader.GetInt32(6),
                                    ProductId = reader.GetInt32(7),
                                    ProductName = reader.GetString(8),
                                    Quantity = reader.GetInt32(9),
                                    UnitPrice = reader.GetDecimal(10)
                                });
                            }
                        }
                    }
                }
            }
            return orders.Values;
        }

        public IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            var details = new List<OrderDetail>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT Id, OrderId, ProductId, ProductName, Quantity, UnitPrice
                    FROM orderdetails
                    WHERE OrderId = @OrderId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new OrderDetail
                            {
                                Id = reader.GetInt32(0),
                                OrderId = reader.GetInt32(1),
                                ProductId = reader.GetInt32(2),
                                ProductName = reader.GetString(3),
                                Quantity = reader.GetInt32(4),
                                UnitPrice = reader.GetDecimal(5)
                            });
                        }
                    }
                }
            }
            return details;
        }

        public void AddOrderDetail(OrderDetail detail)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO orderdetails (OrderId, ProductId, ProductName, Quantity, UnitPrice)
                    VALUES (@OrderId, @ProductId, @ProductName, @Quantity, @UnitPrice)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", detail.OrderId);
                    command.Parameters.AddWithValue("@ProductId", detail.ProductId);
                    command.Parameters.AddWithValue("@ProductName", detail.ProductName ?? string.Empty);
                    command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    command.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE orders 
                    SET Status = @Status 
                    WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", orderId);
                    command.Parameters.AddWithValue("@Status", status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Update(Order order)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE orders 
                    SET UserId = @UserId, OrderDate = @OrderDate, Status = @Status, TotalAmount = @TotalAmount
                    WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", order.Id);
                    command.Parameters.AddWithValue("@UserId", order.UserId);
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool Delete(int orderId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteDetails = "DELETE FROM orderdetails WHERE OrderId = @OrderId";
                        using (var command = new SQLiteCommand(deleteDetails, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderId", orderId);
                            command.ExecuteNonQuery();
                        }

                        string deleteOrder = "DELETE FROM orders WHERE Id = @OrderId";
                        using (var command = new SQLiteCommand(deleteOrder, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderId", orderId);
                            int rowsAffected = command.ExecuteNonQuery();
                            transaction.Commit();
                            return rowsAffected > 0;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public IEnumerable<Order> GetUserOrdersWithDetails(int userId)
        {
            var ordersDict = new Dictionary<int, Order>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                SELECT o.Id, o.UserId, o.OrderDate, o.Status, o.TotalAmount,
                       d.Id, d.OrderId, d.ProductId, d.ProductName, d.Quantity, d.UnitPrice
                FROM Orders o
                LEFT JOIN OrderDetails d ON o.Id = d.OrderId
                WHERE o.UserId = @userId
                ORDER BY o.Id";
                command.Parameters.AddWithValue("@userId", userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderId = reader.GetInt32(0);

                        if (!ordersDict.ContainsKey(orderId))
                        {
                            ordersDict[orderId] = new Order
                            {
                                Id = orderId,
                                UserId = reader.GetInt32(1),
                                OrderDate = reader.GetDateTime(2),
                                Status = reader.GetString(3),
                                TotalAmount = reader.GetDecimal(4),
                                Details = new List<OrderDetail>()
                            };
                        }

                        if (!reader.IsDBNull(5))
                        {
                            ordersDict[orderId].Details.Add(new OrderDetail
                            {
                                Id = reader.GetInt32(5),
                                OrderId = reader.GetInt32(6),
                                ProductId = reader.GetInt32(7),
                                ProductName = reader.IsDBNull(8) ? null : reader.GetString(8),
                                Quantity = reader.GetInt32(9),
                                UnitPrice = reader.GetDecimal(10)
                            });
                        }
                    }
                }
            }

            return ordersDict.Values.ToList();
        }

        public bool CancelOrder(int orderId, string connectionString)
        {
            var order = GetOrderById(orderId);
            if (order == null || order.Status == "Cancelled")
            {
                return false;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Обновляем статус заказа
                        string updateStatusQuery = "UPDATE orders SET Status = @Status WHERE Id = @Id";
                        using (var command = new SQLiteCommand(updateStatusQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Id", orderId);
                            command.Parameters.AddWithValue("@Status", "Cancelled");
                            command.ExecuteNonQuery();
                        }

                        // Возвращаем товары на склад
                        foreach (var detail in order.Details)
                        {
                            string updateStockQuery = @"
                        UPDATE products 
                        SET StockQuantity = StockQuantity + @Quantity 
                        WHERE Id = @ProductId";
                            using (var command = new SQLiteCommand(updateStockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ProductId", detail.ProductId);
                                command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}