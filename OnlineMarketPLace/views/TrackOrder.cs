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
    public partial class TrackOrder: Form
    {
        private string buyerName;

        public TrackOrder(string buyerName)
        {
            InitializeComponent();
            this.buyerName = buyerName;
            LoadTrackingInfo();
        }

        private void LoadTrackingInfo()
        {

        }
        private void TrackOrder_Load(object sender, EventArgs e)
        {

        }


    }
}
