using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Admin() { }

        public Admin(int adminId, string username, string password, string email, string role)
        {
            AdminId = adminId;
            Username = username;
            Password = password;
            Email = email;
            Role = role;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Admin ID: {AdminId}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Role: {Role}");
        }

        public bool Authenticate(string password)
        {
            // Simple authentication check
            return Password == password;
        }

        public void MonitorSellerActivity(string sellerUsername)
        {
            Console.WriteLine($"Monitoring activity for seller: {sellerUsername}");
            // Implement monitoring logic here
        }

        public void ResolveDispute(string disputeId)
        {
            Console.WriteLine($"Resolving dispute with ID: {disputeId}");
            // Implement dispute resolution logic here
        }

        public void BanUser(string username)
        {
            Console.WriteLine($"User {username} has been banned.");
            // Implement user ban logic here
        }

        public void UnbanUser(string username)
        {
            Console.WriteLine($"User {username} has been unbanned.");
            // Implement user unban logic here
        }

        public void MonitorSystem()
        {
            Console.WriteLine($"{Username} is monitoring the system.");
        }
    }
}
  
