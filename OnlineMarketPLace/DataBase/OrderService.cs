using System.Collections.Generic;
using OnlineMarketPLace.models;

namespace OnlineMarketPLace.services
{
    public class OrderService
    {

        private static List<Order> _orders = new List<Order>();

        // Place an order
        public bool PlaceOrder(Order order)
        {
            _orders.Add(order);
            return true;
        }

        // Get all orders
        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        // Get orders by buyer
        public List<Order> GetOrdersByBuyer(string buyerUsername)
        {
            return _orders.FindAll(o => o.BuyerUsername == buyerUsername);
        }

        // Get orders by seller
        public List<Order> GetOrdersBySeller(string sellerUsername)
        {
            return _orders.FindAll(o => o.SellerUsername == sellerUsername);
        }

        // Cancel an order
        public bool CancelOrder(string orderId)
        {
            Order order = _orders.Find(o => o.OrderId == orderId);
            if (order != null && order.Status != "Cancelled")
            {
                order.Status = "Cancelled";
                return true;
            }
            return false;
        }

        // Update order status
        public bool UpdateOrderStatus(string orderId, string newStatus)
        {
            Order order = _orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                order.Status = newStatus;
                return true;
            }
            return false;
        }
    }
}
