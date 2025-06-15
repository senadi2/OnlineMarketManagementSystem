using MySql.Data.MySqlClient;
using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using OnlineMarketPLace.DataBase;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class AddProduct : Form
    {
        private int? productId;
        private string sellerUsername;

        public AddProduct(string sellerUsername, int? productId = null)
        {
            InitializeComponent();
            this.productId = productId;
            this.sellerUsername = sellerUsername;

            if (productId.HasValue)
            {
                LoadProductData();
            }
        }

        private void AddProduct_Load (object sender, EventArgs e)
        {

        }

        private void LoadProductData()
        {
            ProductService service = new ProductService();
            Product product = service.GetProductById(productId.Value);

            if (product != null)
            if (product != null)
            {
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
                txtCatergory.Text = product.Category;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserService userService = new UserService();
                int sellerId = userService.GetUserIdByUsername(sellerUsername);


                ProductService service = new ProductService();
                Product product = new Product
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Price = price,
                    Category = txtCatergory.Text.Trim(),
                    Seller_id = sellerId // ✅ Pass valid FK ID
                };

                service.AddProduct(product);
                MessageBox.Show("Product added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
