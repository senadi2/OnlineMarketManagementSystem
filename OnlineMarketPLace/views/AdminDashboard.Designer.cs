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
            this.lblAdminControlPanel = new System.Windows.Forms.Label();
            this.BtnManageUsers = new System.Windows.Forms.Button();
            this.BtnViewOrders = new System.Windows.Forms.Button();
            this.BtnResolveDisputes = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdminControlPanel
            // 
            this.lblAdminControlPanel.AutoSize = true;
            this.lblAdminControlPanel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControlPanel.Location = new System.Drawing.Point(438, 109);
            this.lblAdminControlPanel.Name = "lblAdminControlPanel";
            this.lblAdminControlPanel.Size = new System.Drawing.Size(313, 34);
            this.lblAdminControlPanel.TabIndex = 0;
            this.lblAdminControlPanel.Text = "Admin Control Panel";
            // 
            // BtnManageUsers
            // 
            this.BtnManageUsers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageUsers.Location = new System.Drawing.Point(248, 214);
            this.BtnManageUsers.Name = "BtnManageUsers";
            this.BtnManageUsers.Size = new System.Drawing.Size(188, 40);
            this.BtnManageUsers.TabIndex = 1;
            this.BtnManageUsers.Text = "Manage Users";
            this.BtnManageUsers.UseVisualStyleBackColor = true;
            // 
            // BtnViewOrders
            // 
            this.BtnViewOrders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewOrders.Location = new System.Drawing.Point(485, 214);
            this.BtnViewOrders.Name = "BtnViewOrders";
            this.BtnViewOrders.Size = new System.Drawing.Size(188, 40);
            this.BtnViewOrders.TabIndex = 2;
            this.BtnViewOrders.Text = "View Orders";
            this.BtnViewOrders.UseVisualStyleBackColor = true;
            // 
            // BtnResolveDisputes
            // 
            this.BtnResolveDisputes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResolveDisputes.Location = new System.Drawing.Point(723, 214);
            this.BtnResolveDisputes.Name = "BtnResolveDisputes";
            this.BtnResolveDisputes.Size = new System.Drawing.Size(212, 40);
            this.BtnResolveDisputes.TabIndex = 3;
            this.BtnResolveDisputes.Text = "Resolve Disputes";
            this.BtnResolveDisputes.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(248, 464);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(112, 40);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(242, 354);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(195, 34);
            this.lblNotifications.TabIndex = 5;
            this.lblNotifications.Text = "Notifications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnResolveDisputes);
            this.Controls.Add(this.BtnViewOrders);
            this.Controls.Add(this.BtnManageUsers);
            this.Controls.Add(this.lblAdminControlPanel);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminControlPanel;
        private System.Windows.Forms.Button BtnManageUsers;
        private System.Windows.Forms.Button BtnViewOrders;
        private System.Windows.Forms.Button BtnResolveDisputes;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label label1;
    }
}