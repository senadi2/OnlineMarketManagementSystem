using OnlineMarketPLace.models;
using OnlineMarketPLace.views;
using OnlineMarketPLace.services; // Add this for ProductService
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineMarketplace
{
    public partial class ProductListForm : Form
    {
        private string searchKeyword;
        private ProductService productService;

        public ProductListForm(string keyword = "")
        {
            InitializeComponent();
            searchKeyword = keyword;
            productService = new ProductService(); 
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = productService.GetProducts(searchKeyword); 

            dgvAvailProducts.Rows.Clear();

            foreach (var product in products)
            {
                dgvAvailProducts.Rows.Add(
                    product.ProductId,
                    product.SellerUsername,
                    product.Name,
                    product.Description,
                    product.Price,
                    product.QuantityAvailable
                );
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchKeyword = txtSearch.Text.Trim();
            LoadProducts();
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvAvailProducts.CurrentRow != null)
            {
                string productId = dgvAvailProducts.CurrentRow.Cells["ProductID"].Value.ToString();
                ProductDetails detailsForm = new ProductDetails(productId);
                detailsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to view details.");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
