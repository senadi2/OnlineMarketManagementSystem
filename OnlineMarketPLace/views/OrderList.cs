using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    public partial class OrderList : Form
    {
        private string buyerName;
        private string role;

        public OrderList(string buyerName, string role)
        {
            InitializeComponent();
            this.buyerName = buyerName;
            this.role = role;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {

        }
    }
}





