using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace OnlineMarketPLace.Services
{
    public static class AuthService
    {
        private static string connectionString = "server=localhost;user id=root;password=;database=online_marketplace_system;";

        public static string AuthenticateUser(string username, string password)
        {
            string role = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Simple query - you should hash & salt passwords in production!
                string query = "SELECT role FROM users WHERE username = @username AND password = @password LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // For demo, store hashed passwords in real apps

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
            }

            return role;
        }
    }
}
