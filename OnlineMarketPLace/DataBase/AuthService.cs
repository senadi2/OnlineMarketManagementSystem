using MySql.Data.MySqlClient;

namespace OnlineMarketPLace.DataBase
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
                string query = "SELECT role FROM users WHERE username = @Username AND password = @Password LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // For demo, store hashed passwords in real apps

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
