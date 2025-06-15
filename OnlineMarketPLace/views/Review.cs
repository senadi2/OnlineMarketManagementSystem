using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineMarketPLace.views
{
    public partial class ReviewForm : Form
    {
        private string productId;
        private string buyerUsername;

        public ReviewForm(string productId, string buyerUsername)
        {
            InitializeComponent();
            this.productId = productId;
            this.buyerUsername = buyerUsername;
        }
        private void Review_Load (object sender, EventArgs e)
            {

            }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rating = cmbRating.SelectedIndex + 1;
            string comment = txtComment.Text.Trim();

            if (rating < 1 || string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter a valid rating and comment.");
                return;
            }

            Review review = new Review
            {
                ReviewId = Guid.NewGuid().ToString(),
                ProductId = productId,
                BuyerUsername = buyerUsername,
                SellerUsername = new ProductService().GetProductById(int.Parse(productId)).SellerUsername,
                Rating = rating,
                Comment = comment,
                ReviewDate = DateTime.Now
            };

            ReviewService service = new ReviewService();
            service.AddReview(review);

            MessageBox.Show("Review submitted successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
