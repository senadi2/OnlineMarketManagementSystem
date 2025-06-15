using OnlineMarketPLace.views;
using System.Windows.Forms;
using System;

namespace OnlineMarketplace
{
    public partial class BuyerDashboardForm : Form
    {
        private string buyerName;

        public BuyerDashboardForm(string buyerUsername)
        {
            InitializeComponent();
            buyerName = buyerUsername;
            lblTitle.Text = $"Welcome, {buyerUsername}";
        }

        private void BuyerDashBoard_Load(object sender, EventArgs e)
        {

        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            ProductListForm productList = new ProductListForm();
            productList.Show();
        }

        private void BtnViewOrder_Click(object sender, EventArgs e) // NO 's' at the end
        {
            OrderList orderList = new OrderList(buyerName, "buyer");
            orderList.Show();
        }

        private void BtnTrackOrder_Click(object sender, EventArgs e)
        {
            TrackOrder trackForm = new TrackOrder(buyerName);
            trackForm.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}