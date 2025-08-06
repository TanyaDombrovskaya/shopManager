using ShopManager.Data.Models;
using ShopManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace ShopManager.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly string _connectionString;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, string connectionString)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public Order GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order != null)
            {
                order.Details = _orderRepository.GetOrderDetails(id).ToList();
            }
            return order;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders().ToList();
            foreach (var order in orders)
            {
                order.Details = _orderRepository.GetOrderDetails(order.Id).ToList();
            }
            return orders;
        }

        public IEnumerable<Order> GetUserOrders(int userId)
        {
            var orders = _orderRepository.GetUserOrders(userId).ToList();
            foreach (var order in orders)
            {
                order.Details = _orderRepository.GetOrderDetails(order.Id).ToList();
            }
            return orders;
        }

        public Order CreateOrder(int userId, List<OrderDetail> items)
        {
            if (items == null || !items.Any())
            {
                throw new ArgumentException("Заказ не может быть пустым");
            }

            foreach (var item in items)
            {
                var product = _productRepository.GetProductById(item.ProductId);
                if (product == null)
                {
                    throw new ArgumentException($"Товар с ID {item.ProductId} не найден");
                }

                if (product.StockQuantity < item.Quantity)
                {
                    throw new ArgumentException($"Недостаточно товара {product.Name} на складе");
                }
            }

            var order = new Order
            {
                UserId = userId,
                TotalAmount = items.Sum(i => i.UnitPrice * i.Quantity),
                Status = "Pending",
                Details = items
            };

            _orderRepository.CreateOrder(order);

            foreach (var item in items)
            {
                _productRepository.UpdateStockQuantity(item.ProductId, -item.Quantity);
            }

            return GetOrderById(order.Id);
        }

        public bool UpdateOrderStatus(int orderId, string status)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order == null)
            {
                return false;
            }

            order.Status = status;
            _orderRepository.UpdateOrderStatus(orderId, status);
            return true;
        }

        public bool CancelOrder(int orderId)
        {
            return _orderRepository.CancelOrder(orderId, _connectionString);
        }

        public bool DeleteOrder(int orderId)
        {
            return _orderRepository.Delete(orderId);
        }

        public IEnumerable<Order> GetUserOrdersWithDetails(int userId)
        {
            return _orderRepository.GetUserOrdersWithDetails(userId);
        }
    }
}