using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
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
    public partial class Dispute : Form
    {
        public Dispute()
        {
            InitializeComponent();
            LoadDisputes();
        }

        private void Dispute_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDisputes()
        {
            DisputeService disputeService = new DisputeService();
            List<Dispute> disputes = disputeService.GetAllOpenDisputes();

            listView1.Items.Clear();

            foreach (var dispute in disputes)
            {
                listView1.Items.Add(new ListViewItem(new string[]
                {
                        dispute.Id,
                        dispute.OrderId,
                        dispute.BuyerUsername,
                        dispute.Description,
                        dispute.Status
                            }));
            }
        }
        private void btnResolve_Click(object sender, EventArgs e)
        {
            if (lstDisputes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a dispute first.");
                return;
            }

            int disputeId = int.Parse(lstDisputes.SelectedItems[0].SubItems[0].Text);
            DisputeService disputeService = new DisputeService();
            disputeService.ResolveDispute(disputeId);
            MessageBox.Show("Dispute resolved.");
            LoadDisputes();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if (lstDisputes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a dispute first.");
                return;
            }

            int disputeId = int.Parse(lstDisputes.SelectedItems[0].SubItems[0].Text);
            DisputeService disputeService = new DisputeService();
            disputeService.DismissDispute(disputeId);
            MessageBox.Show("Dispute dismissed.");
            LoadDisputes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
