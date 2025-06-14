using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string SellerUsername { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
<<<<<<< HEAD
=======
        public string ImageUrl { get; set; }  
>>>>>>> 7f07bd1720f77b80256e548a9b1d1a5be9e64028
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }  

        public Product() { }

        public Product(string productId, string sellerUsername, string name, string description, decimal price, int quantityAvailable)
        {
            ProductId = productId;
            SellerUsername = sellerUsername;
            Name = name;
            Description = description;
            Price = price;
            QuantityAvailable = quantityAvailable;
            DateAdded = DateTime.Now;
            IsActive = true;
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name)) return false;
            if (Price <= 0) return false;
            if (QuantityAvailable < 0) return false;
            return true;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity Available: {QuantityAvailable}");
            Console.WriteLine($"Date Added: {DateAdded}");
            Console.WriteLine($"Active: {IsActive}");
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice > 0)
                Price = newPrice;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity >= 0)
                QuantityAvailable = newQuantity;
        }

        public void RemoveProduct()
        {
            IsActive = false;
        }
    }

}
