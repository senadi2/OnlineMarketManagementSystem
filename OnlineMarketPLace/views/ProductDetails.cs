using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{

    public partial class ProductDetails : Form
    {
        private string productId;

        public ProductDetails(string productId)
        {
            InitializeComponent();
            this.productId = productId;

            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
          
            ProductService service = new ProductService();
            Product product = service.GetProductById(productId); 

            if (product != null)
            {
                lblName.Text = product.Name;
                txtDescription.Text = product.Description;
                lblPrice.Text = product.Price.ToString("C");
                lblAvailability.Text = product.QuantityAvailable.ToString();
          
            }
            else
            {
                MessageBox.Show("Product not found.");
                this.Close();
            }
        }


        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
