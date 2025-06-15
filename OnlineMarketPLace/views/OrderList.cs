using System.Windows.Forms;
using System;

namespace OnlineMarketPLace.views
{
    public partial class OrderList : Form
    {
        private string buyerName;
        private string role;

        public OrderList(string buyerName, string role)
        {
            InitializeComponent();
            this.buyerName = buyerName;
            this.role = role;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {

        }
    }
}