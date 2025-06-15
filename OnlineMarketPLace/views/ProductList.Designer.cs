namespace OnlineMarketplace
{
    partial class ProductListForm
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
            this.lblMyOrder = new System.Windows.Forms.Label();
            this.lblTbs = new System.Windows.Forms.Label();
            this.txtTabs = new System.Windows.Forms.TextBox();
            this.dgvAvailProducts = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyOrder
            // 
            this.lblMyOrder.AutoSize = true;
            this.lblMyOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblMyOrder.Location = new System.Drawing.Point(309, 13);
            this.lblMyOrder.Name = "lblMyOrder";
            this.lblMyOrder.Size = new System.Drawing.Size(130, 30);
            this.lblMyOrder.TabIndex = 0;
            this.lblMyOrder.Text = "My Order";
            // 
            // lblTbs
            // 
            this.lblTbs.AutoSize = true;
            this.lblTbs.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblTbs.Location = new System.Drawing.Point(59, 68);
            this.lblTbs.Name = "lblTbs";
            this.lblTbs.Size = new System.Drawing.Size(44, 21);
            this.lblTbs.TabIndex = 1;
            this.lblTbs.Text = "Tabs";
            // 
            // txtTabs
            // 
            this.txtTabs.Location = new System.Drawing.Point(140, 69);
            this.txtTabs.Name = "txtTabs";
            this.txtTabs.Size = new System.Drawing.Size(100, 22);
            this.txtTabs.TabIndex = 2;
            // 
            // dgvAvailProducts
            // 
            this.dgvAvailProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailProducts.Location = new System.Drawing.Point(162, 114);
            this.dgvAvailProducts.Name = "dgvAvailProducts";
            this.dgvAvailProducts.RowHeadersWidth = 51;
            this.dgvAvailProducts.RowTemplate.Height = 24;
            this.dgvAvailProducts.Size = new System.Drawing.Size(480, 200);
            this.dgvAvailProducts.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(114, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 33);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.Location = new System.Drawing.Point(371, 347);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 33);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvAvailProducts);
            this.Controls.Add(this.txtTabs);
            this.Controls.Add(this.lblTbs);
            this.Controls.Add(this.lblMyOrder);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMyOrder;
        private System.Windows.Forms.Label lblTbs;
        private System.Windows.Forms.TextBox txtTabs;
        private System.Windows.Forms.DataGridView dgvAvailProducts;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnUpdate;
    }
}
