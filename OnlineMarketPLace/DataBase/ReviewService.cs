using System.Collections.Generic;
using OnlineMarketPLace.models;

namespace OnlineMarketPLace.services
{
    public class ReviewService
    {
        private static List<Review> _reviews = new List<Review>();

        // Add a review
        public void AddReview(Review review)
        {
            _reviews.Add(review);
        }

        // Get all reviews for a specific product
        public List<Review> GetReviewsByProductId(string productId)
        {
            return _reviews.FindAll(r => r.ProductId == productId);
        }

        // Get reviews by a specific buyer
        public List<Review> GetReviewsByBuyer(string buyerUsername)
        {
            return _reviews.FindAll(r => r.BuyerUsername == buyerUsername);
        }
    }
}
