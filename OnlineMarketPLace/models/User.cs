using System;


namespace OnlineMarketPLace.models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(int userID, string username, string password, string email)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {UserID}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
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

