using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace ShopManager.Services
{
    public class ReportService
    {
        private readonly string connectionString;

        public ReportService()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;
        }

        public DataTable GetSalesReport(DateTime startDate, DateTime endDate)
        {
            var report = new DataTable();
            report.Columns.Add("ProductName", typeof(string));
            report.Columns.Add("QuantitySold", typeof(int));
            report.Columns.Add("TotalRevenue", typeof(decimal));

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.Name as ProductName, 
                           SUM(od.Quantity) as QuantitySold, 
                           SUM(od.Quantity * od.UnitPrice) as TotalRevenue
                    FROM (
                        SELECT OrderId, ProductId, SUM(Quantity) as Quantity, MAX(UnitPrice) as UnitPrice
                        FROM orderdetails
                        GROUP BY OrderId, ProductId
                    ) od
                    JOIN products p ON od.ProductId = p.Id
                    JOIN (
                        SELECT DISTINCT Id, OrderDate
                        FROM orders
                    ) o ON od.OrderId = o.Id
                    WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                    GROUP BY p.Id, p.Name
                    ORDER BY TotalRevenue DESC";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report.Rows.Add(
                                reader.GetString("ProductName"),
                                reader.GetInt32("QuantitySold"),
                                reader.GetDecimal("TotalRevenue")
                            );
                        }
                    }
                }
            }

            return report;
        }

        public DataTable GetInventoryReport()
        {
            var report = new DataTable();
            report.Columns.Add("ProductName", typeof(string));
            report.Columns.Add("Category", typeof(string));
            report.Columns.Add("Price", typeof(decimal));
            report.Columns.Add("StockQuantity", typeof(int));
            report.Columns.Add("TotalValue", typeof(decimal));

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.Name as ProductName, 
                           c.Name as Category, 
                           p.Price, 
                           p.StockQuantity,
                           (p.Price * p.StockQuantity) as TotalValue
                    FROM products p
                    LEFT JOIN categories c ON p.CategoryId = c.Id
                    ORDER BY TotalValue DESC";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report.Rows.Add(
                                reader.GetString("ProductName"),
                                reader.IsDBNull(reader.GetOrdinal("Category")) ? "Без категории" : reader.GetString("Category"),
                                reader.GetDecimal("Price"),
                                reader.GetInt32("StockQuantity"),
                                reader.GetDecimal("TotalValue")
                            );
                        }
                    }
                }
            }

            return report;
        }

        public decimal GetInventoryTotalValue()
        {
            decimal totalValue = 0;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT SUM(p.Price * p.StockQuantity) as TotalValue
                    FROM products p";

                using (var command = new SQLiteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalValue = Convert.ToDecimal(result);
                    }
                }
            }

            return totalValue;
        }

        public DataTable GetTopSellingProducts(int topCount = 10)
        {
            var report = new DataTable();
            report.Columns.Add("ProductName", typeof(string));
            report.Columns.Add("TotalSold", typeof(int));
            report.Columns.Add("TotalRevenue", typeof(decimal));

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT p.Name as ProductName, 
                   SUM(od.Quantity) as TotalSold, 
                   SUM(od.Quantity * od.UnitPrice) as TotalRevenue
            FROM (
                SELECT OrderId, ProductId, SUM(Quantity) as Quantity, MAX(UnitPrice) as UnitPrice
                FROM orderdetails
                GROUP BY OrderId, ProductId
            ) od
            JOIN products p ON od.ProductId = p.Id
            JOIN orders o ON od.OrderId = o.Id
            WHERE o.Status != 'Cancelled'
            GROUP BY p.Id, p.Name
            ORDER BY TotalSold DESC
            LIMIT @TopCount";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TopCount", topCount);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report.Rows.Add(
                                reader.GetString("ProductName"),
                                reader.GetInt32("TotalSold"),
                                reader.GetDecimal("TotalRevenue")
                            );
                        }
                    }
                }
            }

            return report;
        }

        public decimal GetSalesTotalAmount(DateTime startDate, DateTime endDate)
        {
            decimal totalAmount = 0;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT SUM(od.Quantity * od.UnitPrice) as TotalAmount
                    FROM (
                        SELECT OrderId, ProductId, SUM(Quantity) as Quantity, MAX(UnitPrice) as UnitPrice
                        FROM orderdetails
                        GROUP BY OrderId, ProductId
                    ) od
                    JOIN (
                        SELECT DISTINCT Id, OrderDate
                        FROM orders
                    ) o ON od.OrderId = o.Id
                    WHERE o.OrderDate BETWEEN @StartDate AND @EndDate";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalAmount = Convert.ToDecimal(result);
                    }
                }
            }

            return totalAmount;
        }
    }
}