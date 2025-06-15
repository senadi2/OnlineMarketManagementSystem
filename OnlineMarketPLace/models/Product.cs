using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string SellerUsername { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int QuantityAvailable { get; set; }
        public int Seller_id { get; set; }

        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }  

        public Product() { }

        public Product(int productId, string sellerUsername, string name, string description, decimal price,string catergoty, int quantityAvailable, int seller_id)
        {
            ProductId = productId;
            SellerUsername = sellerUsername;
            Name = name;
            Description = description;
            Price = price;
            Category = catergoty;
            QuantityAvailable = quantityAvailable;
            Seller_id = seller_id;
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
            Console.WriteLine($"Catergoty: {Category}");
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
