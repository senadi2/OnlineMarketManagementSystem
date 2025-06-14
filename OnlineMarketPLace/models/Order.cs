using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    class Order
    {
        public string OrderId { get; set; }
        public string BuyerUsername { get; set; }
        public string SellerUsername { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }  
        public string Status { get; set; }       
        public DateTime OrderDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public Order() { }

        public Order(string orderId, string buyerUsername, string sellerUsername, string productId, int quantity, decimal totalPrice)
        {
            OrderId = orderId;
            BuyerUsername = buyerUsername;
            SellerUsername = sellerUsername;
            ProductId = productId;
            Quantity = quantity;
            TotalPrice = totalPrice;
            Status = "Pending";
            OrderDate = DateTime.Now;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;

            if (newStatus == "Shipped")
            {
                ShippingDate = DateTime.Now;
            }
            else if (newStatus == "Delivered")
            {
                DeliveryDate = DateTime.Now;
            }
            else if (newStatus == "Cancelled")
            {
            }
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Buyer: {BuyerUsername}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Price: {TotalPrice:C}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Order Date: {OrderDate}");

            if (ShippingDate.HasValue)
                Console.WriteLine($"Shipped On: {ShippingDate.Value}");

            if (DeliveryDate.HasValue)
                Console.WriteLine($"Delivered On: {DeliveryDate.Value}");
        }


    }
}

