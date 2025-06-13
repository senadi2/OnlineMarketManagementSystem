using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    public class Seller : User
    {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

        public Seller() { }

        public Seller(int userID, string username, string password, string email, string storeName, string storeAddress)
            : base(userID, username, password, email)
        {
            StoreName = storeName;
            StoreAddress = storeAddress;
        }

        public void AddProduct()
        {
            Console.WriteLine($"{Username} added a new product.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Store Name: {StoreName}");
            Console.WriteLine($"Store Address: {StoreAddress}");
        }
    }
}