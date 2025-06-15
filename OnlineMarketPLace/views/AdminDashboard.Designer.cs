namespace OnlineMarketPLace.views
{
    partial class AdminDashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.BtnResolveDisputes = new System.Windows.Forms.Button();
            this.BtnViewOrders = new System.Windows.Forms.Button();
            this.BtnManageUsers = new System.Windows.Forms.Button();
            this.lblAdminControlPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(255, 247);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(170, 29);
            this.lblNotifications.TabIndex = 12;
            this.lblNotifications.Text = "Notifications";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(260, 335);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // BtnResolveDisputes
            // 
            this.BtnResolveDisputes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResolveDisputes.Location = new System.Drawing.Point(683, 135);
            this.BtnResolveDisputes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResolveDisputes.Name = "BtnResolveDisputes";
            this.BtnResolveDisputes.Size = new System.Drawing.Size(188, 32);
            this.BtnResolveDisputes.TabIndex = 10;
            this.BtnResolveDisputes.Text = "Resolve Disputes";
            this.BtnResolveDisputes.UseVisualStyleBackColor = true;
            // 
            // BtnViewOrders
            // 
            this.BtnViewOrders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewOrders.Location = new System.Drawing.Point(471, 135);
            this.BtnViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnViewOrders.Name = "BtnViewOrders";
            this.BtnViewOrders.Size = new System.Drawing.Size(167, 32);
            this.BtnViewOrders.TabIndex = 9;
            this.BtnViewOrders.Text = "View Orders";
            this.BtnViewOrders.UseVisualStyleBackColor = true;
            // 
            // BtnManageUsers
            // 
            this.BtnManageUsers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageUsers.Location = new System.Drawing.Point(260, 135);
            this.BtnManageUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManageUsers.Name = "BtnManageUsers";
            this.BtnManageUsers.Size = new System.Drawing.Size(167, 32);
            this.BtnManageUsers.TabIndex = 8;
            this.BtnManageUsers.Text = "Manage Users";
            this.BtnManageUsers.UseVisualStyleBackColor = true;
            // 
            // lblAdminControlPanel
            // 
            this.lblAdminControlPanel.AutoSize = true;
            this.lblAdminControlPanel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControlPanel.Location = new System.Drawing.Point(429, 51);
            this.lblAdminControlPanel.Name = "lblAdminControlPanel";
            this.lblAdminControlPanel.Size = new System.Drawing.Size(272, 29);
            this.lblAdminControlPanel.TabIndex = 7;
            this.lblAdminControlPanel.Text = "Admin Control Panel";
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.BtnResolveDisputes);
            this.Controls.Add(this.BtnViewOrders);
            this.Controls.Add(this.BtnManageUsers);
            this.Controls.Add(this.lblAdminControlPanel);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button BtnResolveDisputes;
        private System.Windows.Forms.Button BtnViewOrders;
        private System.Windows.Forms.Button BtnManageUsers;
        private System.Windows.Forms.Label lblAdminControlPanel;
    }
}