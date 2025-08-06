using ShopManager.Data.Models;
using System.Collections.Generic;

namespace ShopManager.Data.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetUserOrders(int userId);
        IEnumerable<OrderDetail> GetOrderDetails(int orderId);
        void AddOrderDetail(OrderDetail detail);
        void UpdateOrderStatus(int orderId, string status);
        bool Update(Order order);
        bool Delete(int orderId);
        IEnumerable<Order> GetUserOrdersWithDetails(int userId);
        bool CancelOrder(int orderId, string connectionString);
    }
}