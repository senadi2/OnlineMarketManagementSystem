using OnlineMarketPLace.models;
using OnlineMarketPLace.services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineMarketPLace.views
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }


        private void LoadUsers()
        {
            UserService userService = new UserService();
            List<User> users = userService.GetAllUsers();

            listView1.Items.Clear();
            foreach (var user in users)
            {
                listView1.Items.Add(new ListViewItem(new string[] {
                    user.Username,
                    user.Email,
                    user.Status,
                    user.Role,
                    user.DateJoined.ToString("yyyy-MM-dd"),
                }));
            }
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            string username = listView1.SelectedItems[0].SubItems[0].Text;
            UserService userService = new UserService();
            userService.BlockUser(username);
            MessageBox.Show("User blocked.");
            LoadUsers();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            string username = listView1.SelectedItems[0].SubItems[0].Text;
            UserService userService = new UserService();
            userService.DeleteUser(username);
            MessageBox.Show("User deleted.");
            LoadUsers();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}