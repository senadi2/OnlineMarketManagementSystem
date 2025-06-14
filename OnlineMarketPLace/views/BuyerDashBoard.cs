using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OnlineMarketPLace.views;

namespace OnlineMarketplace
{
    public partial class BuyerDashboardForm : Form
    {
        private string buyerName;

        public BuyerDashboardForm(string buyerUsername)
        {
            InitializeComponent();
            buyerName = buyerUsername;
            lblWelcome.Text = $"Welcome, {buyerUsername}";
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

        private void BtnViewOrders_Click(object sender, EventArgs e)
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