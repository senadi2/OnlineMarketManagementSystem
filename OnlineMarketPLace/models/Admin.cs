using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineMarketPLace.models
{
    public class Admin : User
    {
        public string Role { get; set; }

        public Admin() { }

        public Admin(int userID, string username, string password, string email, string role)
            : base(userID, username, password, email) // Call User constructor
        {
            Role = role;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call parent DisplayInfo()
            Console.WriteLine($"Role: {Role}");
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

        public void MonitorSellerActivity(string sellerUsername)
        {
            Console.WriteLine($"Monitoring activity for seller: {sellerUsername}");
        }

        public void ResolveDispute(string disputeId)
        {
            Console.WriteLine($"Resolving dispute with ID: {disputeId}");
        }

        public void BanUser(string username)
        {
            Console.WriteLine($"User {username} has been banned.");
        }

        public void UnbanUser(string username)
        {
            Console.WriteLine($"User {username} has been unbanned.");
        }

        public void MonitorSystem()
        {
            Console.WriteLine($"{Username} is monitoring the system.");
        }
    }
}
