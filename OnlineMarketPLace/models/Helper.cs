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

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

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

        public static bool IsValidRating(int rating)
        {
            return rating >= 1 && rating <= 5;
        }

        public static bool IsValidQuantity(int quantity)
        {
            return quantity > 0;
        }
    }
}
    
