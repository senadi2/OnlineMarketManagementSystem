using MySql.Data.MySqlClient;
using OnlineMarketPLace.DataBase;
using OnlineMarketPLace.models;
using System;
using System.Collections.Generic;

namespace OnlineMarketPLace.services
{
    public class UserService
    {
        public int GetUserIdByUsername(string username)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT id FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Seller not found.");
                }
            }
        }

        // New method to block a user (set status = 'Blocked')
        public bool BlockUser(string username)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "UPDATE users SET status = 'Blocked' WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // New method to delete a user record
        public bool DeleteUser(string username)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        internal List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
