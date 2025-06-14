namespace OnlineMarketPLace.views
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnResolveDisputes = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.lblAdminControlPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(246, 261);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(192, 40);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(473, 261);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(192, 40);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // btnResolveDisputes
            // 
            this.btnResolveDisputes.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolveDisputes.Location = new System.Drawing.Point(703, 261);
            this.btnResolveDisputes.Name = "btnResolveDisputes";
            this.btnResolveDisputes.Size = new System.Drawing.Size(226, 40);
            this.btnResolveDisputes.TabIndex = 2;
            this.btnResolveDisputes.Text = "Resolve Disputes";
            this.btnResolveDisputes.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(254, 491);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(248, 382);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(195, 34);
            this.lblNotifications.TabIndex = 4;
            this.lblNotifications.Text = "Notifications";
            // 
            // lblAdminControlPanel
            // 
            this.lblAdminControlPanel.AutoSize = true;
            this.lblAdminControlPanel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControlPanel.Location = new System.Drawing.Point(429, 141);
            this.lblAdminControlPanel.Name = "lblAdminControlPanel";
            this.lblAdminControlPanel.Size = new System.Drawing.Size(313, 34);
            this.lblAdminControlPanel.TabIndex = 5;
            this.lblAdminControlPanel.Text = "Admin Control Panel";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 770);
            this.Controls.Add(this.lblAdminControlPanel);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnResolveDisputes);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnManageUsers);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnResolveDisputes;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label lblAdminControlPanel;
    }
}