using OnlineMarketPLace.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- User ---
            User user = new User(1, "user01", "userpass", "user01@example.com");
            user.DisplayInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Admin ---
            Admin admin = new Admin(100, "admin01", "adminpass", "admin@example.com", "admin");
            admin.DisplayInfo();           // Inherited + extended
            admin.MonitorSystem();


            Console.WriteLine("\n-----------------------------------\n");

            // --- Buyer ---
            Buyer buyer = new Buyer(2, "buyer01", "pass123", "buyer@example.com", "123 Green Lane");
            buyer.DisplayInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Seller ---
            Seller seller = new Seller(3, "seller01", "pass456", "seller@example.com", "Best Seller Inc.", "123 Green Lane");
            seller.DisplayInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Product ---
            Product product = new Product("P001", "seller1", "Laptop", "High performance laptop", 1200.00m, 8, "image1.png");
            product.DisplayProductInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Order ---
            Order order = new Order("O1001", "buyer01", "seller01", "P001", 1, 1200.00m);
            order.DisplayOrderInfo();
            order.UpdateStatus("Shipped");
            Console.WriteLine("After status update:");
            order.DisplayOrderInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Review ---
            Review review = new Review("R1001", "buyer01", "P001", "P002", 5, "Excellent product!");
            review.DisplayReview();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Dispute ---
            Dispute dispute = new Dispute("D001", "buyer01", "seller01", "Order delayed", "Open");
            dispute.DisplayDisputeInfo();

            Console.WriteLine("\n-----------------------------------\n");

            // --- Helper ---
            string newId = Helper.GenerateId();
            Console.WriteLine($"Generated new ID: {newId}");

            Console.WriteLine("\nProgram execution finished.");
        }
    }
}
      
