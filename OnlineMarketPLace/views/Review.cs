using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Windows.Forms;

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

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            // Initialize rating combo box if needed
            if (cmbRating.Items.Count == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    cmbRating.Items.Add(i.ToString());
                }
                cmbRating.SelectedIndex = 4; // Default to 5 stars
            }
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

            var productService = new ProductService();
            var product = productService.GetProductById(int.Parse(productId));

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                this.Close();
                return;
            }

            Review review = new Review
            {
                ReviewId = Guid.NewGuid().ToString(),
                ProductId = productId,
                BuyerUsername = buyerUsername,
                SellerUsername = product.SellerUsername,
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
