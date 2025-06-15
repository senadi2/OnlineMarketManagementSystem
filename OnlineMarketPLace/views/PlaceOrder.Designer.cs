namespace OnlineMarketPLace.views
{
    partial class PlaceOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProductT = new System.Windows.Forms.Label();
            this.lblQuantityT = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceT = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.lblProductT);
            this.groupBox1.Controls.Add(this.lblQuantityT);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblPriceT);
            this.groupBox1.Location = new System.Drawing.Point(165, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 211);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmation";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(209, 158);
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(166, 22);
            this.numQuantity.TabIndex = 16;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblProductT
            // 
            this.lblProductT.AutoSize = true;
            this.lblProductT.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblProductT.Location = new System.Drawing.Point(82, 54);
            this.lblProductT.Name = "lblProductT";
            this.lblProductT.Size = new System.Drawing.Size(72, 21);
            this.lblProductT.TabIndex = 15;
            this.lblProductT.Text = "Product:";
            // 
            // lblQuantityT
            // 
            this.lblQuantityT.AutoSize = true;
            this.lblQuantityT.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblQuantityT.Location = new System.Drawing.Point(82, 156);
            this.lblQuantityT.Name = "lblQuantityT";
            this.lblQuantityT.Size = new System.Drawing.Size(79, 21);
            this.lblQuantityT.TabIndex = 11;
            this.lblQuantityT.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblProduct.Location = new System.Drawing.Point(205, 57);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 21);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "label6";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblPrice.Location = new System.Drawing.Point(205, 111);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 21);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "label4";
            // 
            // lblPriceT
            // 
            this.lblPriceT.AutoSize = true;
            this.lblPriceT.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblPriceT.Location = new System.Drawing.Point(82, 108);
            this.lblPriceT.Name = "lblPriceT";
            this.lblPriceT.Size = new System.Drawing.Size(53, 21);
            this.lblPriceT.TabIndex = 13;
            this.lblPriceT.Text = "Price:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(183, 371);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 35);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(500, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(283, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 30);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = " Confirm Order ";
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Name = "PlaceOrderForm";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblProductT;
        private System.Windows.Forms.Label lblQuantityT;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceT;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}
