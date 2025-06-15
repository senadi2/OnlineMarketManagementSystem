using System;

namespace OnlineMarketPLace.models
{
    public class Dispute
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string BuyerUsername { get; set; } 
        public string Description { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public DateTime? DateResolved { get; set; } 

        public Dispute() { }

        public Dispute(string id, string orderId, string buyerUsername, string description, string status, string resolution)
        {
            Id = id;
            OrderId = orderId;
            BuyerUsername = buyerUsername;
            Description = description;
            Status = status;
            Resolution = resolution;
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
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Buyer: {BuyerUsername}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Resolution: {Resolution}");
            if (DateResolved.HasValue)
                Console.WriteLine($"Resolved On: {DateResolved.Value}");
        }
    }
}
