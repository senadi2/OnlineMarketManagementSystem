using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class PlaceOrderForm : Form
    {
        private Product product;
        private string buyerUsername;

        public PlaceOrderForm(Product product, string buyerUsername)
        {
            InitializeComponent();
            this.product = product;
            this.buyerUsername = buyerUsername;
            LoadProductDetails();
        }

        private void PlaceOrder_Load (object sender, EventArgs e)
        {

        }

        private void LoadProductDetails()
        {
            lblProduct.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(numQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (quantity > product.QuantityAvailable)
            {
                MessageBox.Show("Requested quantity exceeds available stock.");
                return;
            }

            OrderService orderService = new OrderService();
            Order order = new Order
            {
                OrderId = Helper.GenerateId(),
                BuyerUsername = buyerUsername,
                SellerUsername = product.SellerUsername,
                ProductId = product.ProductId,
                Quantity = quantity,
                TotalPrice = product.Price * quantity,
                Status = "Pending"
            };

            bool success = orderService.PlaceOrder(order);

            if (success)
            {
                MessageBox.Show("Order placed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to place the order.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
