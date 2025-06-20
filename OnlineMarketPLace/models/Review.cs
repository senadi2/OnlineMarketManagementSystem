﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    public class Review
    {
        public string ReviewId { get; set; }
        public string ProductId { get; set; }
        public string BuyerUsername { get; set; }
        public string SellerUsername { get; set; }
        public int Rating { get; set; } 
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review() { }

        public Review(string reviewId, string productId, string buyerUsername, string sellerUsername, int rating, string comment)
        {
            ReviewId = reviewId;
            ProductId = productId;
            BuyerUsername = buyerUsername;
            SellerUsername = sellerUsername;
            Rating = rating;
            Comment = comment;
            ReviewDate = DateTime.Now;
        }

        public bool IsValidRating()
        {
            return Rating >= 1 && Rating <= 5;
        }

        public bool IsValidComment()
        {
            if (string.IsNullOrWhiteSpace(Comment)) return false;
            if (Comment.Length > 500) return false;
            return true;
        }


        public void DisplayReview()
        {
            Console.WriteLine($"Review ID: {ReviewId}");
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Buyer: {BuyerUsername}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Rating: {Rating}/5");
            Console.WriteLine($"Comment: {Comment}");
            Console.WriteLine($"Date: {ReviewDate}");
        }
    }
}
