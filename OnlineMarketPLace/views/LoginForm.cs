using OnlineMarketPLace.views;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OnlineMarketPLace.Services;

namespace OnlineMarketplace
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;

            string role = AuthService.AuthenticateUser(username , password);

            if (role == "Buyer")
            {
                this.Hide();
                BuyerDashBoard buyerDashboard = new BuyerDashBoard();
                buyerDashboard.Show();
            }
            else if (role == "Seller")
            {
                this.Hide();
                SellerDashBoard sellerDashboard = new SellerDashBoard();
                sellerDashboard.Show();
            }
            else if (role == "Admin")
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void chkshpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkshpass.Checked;
        }

    }
}