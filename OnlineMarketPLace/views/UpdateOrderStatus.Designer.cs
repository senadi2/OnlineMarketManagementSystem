namespace OnlineMarketPLace.views
{
    partial class UpdateOrderStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUpdateOrder.Location = new System.Drawing.Point(245, 18);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(263, 30);
            this.lblUpdateOrder.TabIndex = 0;
            this.lblUpdateOrder.Text = "Update Order Status";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblOrderID.Location = new System.Drawing.Point(49, 83);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(75, 21);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblNewStatus.Location = new System.Drawing.Point(49, 171);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(90, 21);
            this.lblNewStatus.TabIndex = 2;
            this.lblNewStatus.Text = "New Status";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(184, 76);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(450, 22);
            this.txtOrder.TabIndex = 3;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.Location = new System.Drawing.Point(184, 318);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(87, 30);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(539, 318);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 30);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
                "Pending",
                "Processing",
                "Shipped",
                "Delivered",
                "Cancelled"
            });
            this.cmbStatus.Location = new System.Drawing.Point(184, 171);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(450, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // UpdateOrderStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblNewStatus);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblUpdateOrder);
            this.Name = "UpdateOrderStatusForm";
            this.Text = "Update Order Status";
            this.Load += new System.EventHandler(this.UpdateOrderStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
