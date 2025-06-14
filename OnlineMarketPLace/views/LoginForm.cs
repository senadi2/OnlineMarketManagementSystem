using OnlineMarketPLace.views;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OnlineMarketPLace.DataBase;

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

            string role = AuthService.AuthenticateUser(username,password);

            if (role == "buyer")
            {
                this.Hide();
                BuyerDashBoard buyerDashboard = new BuyerDashBoard();
                buyerDashboard.Show();
            }
            else if (role == "seller")
            {
                this.Hide();
                SellerDashBoard sellerDashboard = new SellerDashBoard();
                sellerDashboard.Show();
            }
            else if (role == "admin")
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
            RegisterForm registerForm = new RegisterForm();
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