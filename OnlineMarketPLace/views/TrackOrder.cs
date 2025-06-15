using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class TrackOrderForm : Form
    {
        private readonly int orderId;

        public TrackOrderForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadOrderDetails();
        }

        private void TrackOrder_Load(object sender, EventArgs e)
        {

        }

        private void LoadOrderDetails()
        {
            OrderService orderService = new OrderService();
            Order order = orderService.GetOrderById(orderId.ToString());

            if (order != null)
            {
                lblOrderId.Text = order.OrderId;
                lblStatus.Text = order.Status;
                lblDelivery.Text = order.OrderDate.ToString("g"); // General date/time pattern
            }
            else
            {
                MessageBox.Show("Order not found.");
                this.Close();
            }
        }
    }
}
