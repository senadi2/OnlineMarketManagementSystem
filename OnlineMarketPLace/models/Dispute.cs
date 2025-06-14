using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    class Dispute
    {
        public string DisputeId { get; set; }
        public string OrderId { get; set; }       
        public string BuyerUsername { get; set; }
        public string SellerUsername { get; set; }
        public string Reason { get; set; }        
        public string Status { get; set; }        
        public DateTime DateFiled { get; set; }
        public DateTime? DateResolved { get; set; }

        public Dispute() { }

        public Dispute(string disputeId, string orderId, string buyerUsername, string sellerUsername, string reason)
        {
            DisputeId = disputeId;
            OrderId = orderId;
            BuyerUsername = buyerUsername;
            SellerUsername = sellerUsername;
            Reason = reason;
            Status = "Open";
            DateFiled = DateTime.Now;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;

            if (newStatus == "Resolved" || newStatus == "Closed")
            {
                DateResolved = DateTime.Now;
            }
        }

        public void DisplayDisputeInfo()
        {
            Console.WriteLine($"Dispute ID: {DisputeId}");
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Buyer: {BuyerUsername}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Reason: {Reason}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Filed On: {DateFiled}");

            if (DateResolved.HasValue)
                Console.WriteLine($"Resolved On: {DateResolved.Value}");
        }
    }
}
    
