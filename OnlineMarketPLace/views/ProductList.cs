using System;
using System.Windows.Forms;
using OnlineMarketPLace.services;
using OnlineMarketPLace.models;
using OnlineMarketPLace.views;

namespace OnlineMarketplace
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductService productService = new ProductService();
            var products = productService.GetProducts(""); // Empty keyword to get all or modify as needed

            dgvAvailProducts.DataSource = products;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAvailProducts.CurrentRow != null)
            {
                var selectedProduct = dgvAvailProducts.CurrentRow.DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    MessageBox.Show($"Update product: {selectedProduct.Name}");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        // --- Added: View Details button handler to open ProductDetailsForm ---
        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvAvailProducts.CurrentRow != null)
            {
                var selectedProduct = dgvAvailProducts.CurrentRow.DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    ProductDetailsForm detailsForm = new ProductDetailsForm(selectedProduct.ProductId.ToString());
                    detailsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to view details.");
            }
        }
    }
}
