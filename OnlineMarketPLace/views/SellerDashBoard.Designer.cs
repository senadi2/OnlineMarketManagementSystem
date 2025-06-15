namespace OnlineMarketPlace.views
{
    partial class SellerDashBoard
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
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnViewOrder = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTopic.Location = new System.Drawing.Point(334, 33);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(123, 30);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Welcome";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblProduct.Location = new System.Drawing.Point(67, 91);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(109, 21);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Your Product";
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(118, 142);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 24;
            this.dgvGrid.Size = new System.Drawing.Size(453, 150);
            this.dgvGrid.TabIndex = 2;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(198, 92);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(385, 22);
            this.txtProduct.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(70, 328);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 31);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.Location = new System.Drawing.Point(313, 328);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 31);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Location = new System.Drawing.Point(540, 328);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnViewOrder
            // 
            this.BtnViewOrder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnViewOrder.Location = new System.Drawing.Point(150, 393);
            this.BtnViewOrder.Name = "BtnViewOrder";
            this.BtnViewOrder.Size = new System.Drawing.Size(123, 29);
            this.BtnViewOrder.TabIndex = 7;
            this.BtnViewOrder.Text = "View Orders";
            this.BtnViewOrder.UseVisualStyleBackColor = true;
            this.BtnViewOrder.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogOut.Location = new System.Drawing.Point(447, 385);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(94, 45);
            this.BtnLogOut.TabIndex = 8;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // SellerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnViewOrder);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTopic);
            this.Name = "SellerDashboard";
            this.Text = "Seller Dashboard";
            this.Load += new System.EventHandler(this.SellerDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnViewOrder;
        private System.Windows.Forms.Button BtnLogOut;
    }
}
