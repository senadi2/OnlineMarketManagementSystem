using OnlineMarketPLace.services;
using System;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class UpdateOrderStatusForm : Form
    {
        private readonly int orderId;

        public UpdateOrderStatusForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadStatusOptions();
        }

        private void UpdateOrderStatus_Load (object sender, EventArgs e)
        {

        }

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string newStatus = cmbStatus.SelectedItem.ToString();
            OrderService orderService = new OrderService();
            bool success = orderService.UpdateOrderStatus(orderId.ToString(), newStatus);

            if (success)
            {
                MessageBox.Show("Order status updated.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update status.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
