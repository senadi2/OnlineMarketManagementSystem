using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    public class Buyer : User
    {
        public string ShippingAddress { get; set; }

        public Buyer() { }

        public Buyer(int userID, string username, string password, string email, string role, DateTime createdAt, string shippingAddress)
     : base(userID, username, password, email, role, createdAt)
        {
            ShippingAddress = shippingAddress;
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"{Username} placed an order.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Shipping Address: {ShippingAddress}");
        }
    }
}

