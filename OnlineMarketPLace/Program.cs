using OnlineMarketplace;
using OnlineMarketPLace.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace OnlineMarketPLace
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();   // Makes the app look modern
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
      
