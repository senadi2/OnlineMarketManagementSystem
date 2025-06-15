using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace OnlineMarketplace
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassword.Text;
            string email = txtConfirmP.Text;
            string accountType = cmbAccType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(accountType))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "server=localhost;user id=root;password=;database=online_marketplace_system;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (username, password,email, role) VALUES (@Username, @Password,@Email, @Role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Role", accountType);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successful.");
                            this.Hide();
                            new LoginForm().Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Optional: Add code here if you want to do something when the form loads
        }
    }
}