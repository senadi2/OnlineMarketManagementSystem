using System;
using System.Windows.Forms;
using OnlineMarketPLace.models;
using OnlineMarketPLace.services;

namespace OnlineMarketPLace.views
{
    public partial class ProductDetailsForm : Form
    {
        private string productId;

        public ProductDetailsForm(string productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadProductDetails();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadProductDetails()
        {
            ProductService service = new ProductService();
            Product product = service.GetProductById(int.Parse(productId));

            if (product != null)
            {
                lblName.Text = product.Name;
                txtDescription.Text = product.Description;
                lblPrice.Text = product.Price.ToString("C");

           
            }
            else
            {
                MessageBox.Show("Product not found.");
                this.Close();
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Place Order clicked for product: " + lblName.Text);
          
        }

        private void BtnLeaveReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave Review clicked for product: " + lblName.Text);
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
