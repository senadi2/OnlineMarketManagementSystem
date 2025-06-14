namespace OnlineMarketPLace.views
{
    partial class TrackOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderIdT = new System.Windows.Forms.Label();
            this.lblStatusT = new System.Windows.Forms.Label();
            this.lblDeliveryT = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(273, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " Track Order Status   ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(135, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrderIdT);
            this.groupBox1.Controls.Add(this.lblStatusT);
            this.groupBox1.Controls.Add(this.lblDeliveryT);
            this.groupBox1.Controls.Add(this.lblOrderId);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblDelivery);
            this.groupBox1.Location = new System.Drawing.Point(135, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 255);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status";
            // 
            // lblOrderIdT
            // 
            this.lblOrderIdT.AutoSize = true;
            this.lblOrderIdT.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdT.Location = new System.Drawing.Point(87, 54);
            this.lblOrderIdT.Name = "lblOrderIdT";
            this.lblOrderIdT.Size = new System.Drawing.Size(71, 21);
            this.lblOrderIdT.TabIndex = 12;
            this.lblOrderIdT.Text = "OrderID";
            // 
            // lblStatusT
            // 
            this.lblStatusT.AutoSize = true;
            this.lblStatusT.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusT.Location = new System.Drawing.Point(87, 115);
            this.lblStatusT.Name = "lblStatusT";
            this.lblStatusT.Size = new System.Drawing.Size(54, 21);
            this.lblStatusT.TabIndex = 11;
            this.lblStatusT.Text = "Status";
            // 
            // lblDeliveryT
            // 
            this.lblDeliveryT.AutoSize = true;
            this.lblDeliveryT.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryT.Location = new System.Drawing.Point(87, 173);
            this.lblDeliveryT.Name = "lblDeliveryT";
            this.lblDeliveryT.Size = new System.Drawing.Size(150, 21);
            this.lblDeliveryT.TabIndex = 10;
            this.lblDeliveryT.Text = "Estimated Delivery";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(325, 54);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(54, 21);
            this.lblOrderId.TabIndex = 9;
            this.lblOrderId.Text = "label4";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(325, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 21);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label3";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(325, 173);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(54, 21);
            this.lblDelivery.TabIndex = 7;
            this.lblDelivery.Text = "label7";
            // 
            // TrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "TrackOrder";
            this.Text = "TrackOrder";
            this.Load += new System.EventHandler(this.TrackOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderIdT;
        private System.Windows.Forms.Label lblStatusT;
        private System.Windows.Forms.Label lblDeliveryT;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDelivery;
    }
}