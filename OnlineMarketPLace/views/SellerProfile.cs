using System;
using System.Windows.Forms;
using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System.Collections.Generic;

namespace OnlineMarketPLace.views
{
    public partial class SellerProfileForm : Form
    {
        private string sellerUsername;

        public SellerProfileForm(string sellerUsername)
        {
            InitializeComponent();
            this.sellerUsername = sellerUsername;
        }

        

        private void SellerProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
            LoadReviews();
        }

        private void LoadProfile()
        {
            UserService userService = new UserService();
            User seller = userService.Get(sellerUsername);

            if (seller != null)
            {
                lblSellerName.Text = seller.Username;
                lblSellerProfile.Text = seller.Role;
                // Add other profile fields if needed, e.g. email, joined date etc.
            }
            else
            {
                MessageBox.Show("Seller profile not found.");
            }
        }

        private void LoadReviews()
        {
            ReviewService reviewService = new ReviewService();
            List<Review> reviews = reviewService.GetReviewsForSeller(sellerUsername);

            txtRating.Clear();
            foreach (var review in reviews)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    review.BuyerUsername,
                    review.Rating.ToString(),
                    review.Comment,
                    review.ReviewDate.ToShortDateString()
                });

                txtRating.Add(item);
            }
        }
    }
}
