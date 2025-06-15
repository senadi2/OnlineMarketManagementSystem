using OnlineMarketPLace.models;
using OnlineMarketPLace.views;
using System;
using System.Windows.Forms;

namespace OnlineMarketPlace.views
{
    public partial class SellerDashBoard : Form
    {
        private string sellerUsername;

        public SellerDashBoard(string username)
        {
            InitializeComponent();
            sellerUsername = username;
            lblTopic.Text = $"Welcome, {sellerUsername}";
            LoadProducts();
        }

        private void SellerDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            // TODO: Load products for this seller from database/service
            // Example placeholder:
            // dgvProducts.DataSource = ProductService.GetProductsBySeller(sellerUsername);
        }


        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddProduct(sellerUsername); 
            addEditForm.ShowDialog();
            LoadProducts();

        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvGrid.CurrentRow != null)
            {
                int productID = Convert.ToInt32(dgvGrid.CurrentRow.Cells["ProductId"].Value);
                var addEditForm = new AddProduct(sellerUsername, productID); 
                addEditForm.ShowDialog();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrid.CurrentRow != null)
            {
                var productId = dgvGrid.CurrentRow.Cells["ProductId"].Value.ToString();
                // TODO: Delete product via service or DB
                MessageBox.Show($"Deleted product {productId} (not implemented).");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrderList(sellerUsername, "Seller");
            ordersForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
