using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineMarketPLace.models;

namespace OnlineMarketPLace.views
{
    public partial class OrderList : Form
    {
        private readonly string userName;
        private readonly string role;

        public OrderList(string userName, string role)
        {
            InitializeComponent();
            this.userName = userName;
            this.role = role;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            List<Order> allOrders = GetAllOrders();

            List<Order> filteredOrders;

            if (role.Equals("Seller", StringComparison.OrdinalIgnoreCase))
            {
                filteredOrders = allOrders.FindAll(o => o.SellerUsername == userName);
            }
            else if (role.Equals("Buyer", StringComparison.OrdinalIgnoreCase))
            {
                filteredOrders = allOrders.FindAll(o => o.BuyerUsername == userName);
            }
            else
            {
                filteredOrders = new List<Order>();
            }

            dgvGrid.DataSource = filteredOrders;
        }

        // Sample method to simulate retrieving all orders
        private List<Order> GetAllOrders()
        {
            return new List<Order>()
            {
                new Order("O1", "buyer1", "seller1", 1, 2, 100m) { Status = "Pending" },
                new Order("O2", "buyer2", "seller1", 2, 1, 50m) { Status = "Shipped" },
                new Order("O3", "buyer1", "seller2", 3, 3, 150m) { Status = "Delivered" },
            };
        }
    }
}
