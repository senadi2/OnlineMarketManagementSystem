using OnlineMarketPLace.views;
using System;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class AdminDashboardForm : Form
    {
        private string adminUsername;

        public AdminDashboardForm(string username)
        {
            InitializeComponent();
            adminUsername = username;
            lblAdminControlPanel.Text = $"Admin Control Panel - {adminUsername}";
            LoadSummary();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadSummary()
        {
            // TODO: Load notifications or summary info (optional)
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            var userMgmtForm = new ManageUsers();
            userMgmtForm.ShowDialog();
        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            var orderListForm = new OrderList(null, "Admin");
            orderListForm.ShowDialog();

        }

        private void BtnResolveDisputes_Click(object sender, EventArgs e)
        {
            var disputeForm = new Dispute();
            disputeForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
