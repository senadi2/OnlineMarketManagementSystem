namespace OnlineMarketPLace.views
{
    partial class ManageUsers
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
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateJoined = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.Location = new System.Drawing.Point(491, 176);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(208, 34);
            this.lblManageUsers.TabIndex = 5;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserName,
            this.colEmail,
            this.colStatus,
            this.colRole,
            this.colDateJoined});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(200, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 113);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colUserName
            // 
            this.colUserName.Text = "UserName";
            this.colUserName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmail.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 150;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRole.Width = 150;
            // 
            // colDateJoined
            // 
            this.colDateJoined.Text = "Date Joined";
            this.colDateJoined.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDateJoined.Width = 170;
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.Location = new System.Drawing.Point(435, 466);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(112, 40);
            this.btnBlock.TabIndex = 7;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(655, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 822);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblManageUsers);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colDateJoined;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnDelete;
    }
}