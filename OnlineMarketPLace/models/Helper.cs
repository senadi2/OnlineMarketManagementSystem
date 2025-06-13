using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlineMarketPLace.models
{
    class Helper
    {
        private static Random _random = new Random();

        // Generate a unique alphanumeric ID of given length
        public static string GenerateId(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] id = new char[length];
            for (int i = 0; i < length; i++)
            {
                id[i] = chars[_random.Next(chars.Length)];
            }
            return new string(id);
        }

        // Validate email format
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Simple email pattern check
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        // Validate password (example: at least 6 chars, one digit)
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                return false;

            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                    break;
                }
            }
            return hasDigit;
        }

        // Validate rating value (1 to 5)
        public static bool IsValidRating(int rating)
        {
            return rating >= 1 && rating <= 5;
        }

        // Validate quantity (positive number)
        public static bool IsValidQuantity(int quantity)
        {
            return quantity > 0;
        }
    }
}
    
