namespace OnlineMarketPLace.views
{
    partial class UpdateOrderStatus
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
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOrder.Location = new System.Drawing.Point(245, 18);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(263, 30);
            this.lblUpdateOrder.TabIndex = 0;
            this.lblUpdateOrder.Text = "Update Order Status";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(49, 83);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(75, 21);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(184, 165);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(450, 22);
            this.txtStatus.TabIndex = 4;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(184, 318);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(87, 30);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(539, 318);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 30);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblNewStatus);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblUpdateOrder);
            this.Name = "UpdateOrderStatus";
            this.Text = "UpdateOrderStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
    }
}