using System;


namespace OnlineMarketPLace.models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public DateTime DateJoined { get; set; }



        public User() { }

        public User(int userID, string username, string email, string status, string role, DateTime datejoined)
        {
            UserID = userID;
            Username = username;
            Email = email;
            Status = status;
            Role = role;
            DateJoined = datejoined;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {UserID}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Date Joined: {DateJoined}");
        }

        public void Login()
        {
            Console.WriteLine($"{Username} logged in.");
        }

        public void Logout()
        {
            Console.WriteLine($"{Username} logged out.");
        }
    }
}

