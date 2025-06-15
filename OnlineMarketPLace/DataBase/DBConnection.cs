using MySql.Data.MySqlClient;

namespace OnlineMarketPLace.DataBase
{
    public static class DBConnection
    {
        private static string connectionString = "server=localhost;user id=root;password=;database=online_marketplace_system;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
