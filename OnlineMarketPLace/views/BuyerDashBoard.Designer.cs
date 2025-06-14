namespace OnlineMarketplace
{
    partial class BuyerDashboardForm
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
            this.gtvSearch = new System.Windows.Forms.GroupBox();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblProductList = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnTrack = new System.Windows.Forms.Button();
            this.BtnViewOrder = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gtvSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gtvSearch
            // 
            this.gtvSearch.Controls.Add(this.dgvgrid);
            this.gtvSearch.Controls.Add(this.lblProductList);
            this.gtvSearch.Location = new System.Drawing.Point(118, 201);
            this.gtvSearch.Name = "gtvSearch";
            this.gtvSearch.Size = new System.Drawing.Size(585, 331);
            this.gtvSearch.TabIndex = 15;
            this.gtvSearch.TabStop = false;
            // 
            // dgvgrid
            // 
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrid.Location = new System.Drawing.Point(133, 80);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(318, 220);
            this.dgvgrid.TabIndex = 6;
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(232, 30);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(118, 21);
            this.lblProductList.TabIndex = 5;
            this.lblProductList.Text = "Product List :  ";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.Location = new System.Drawing.Point(564, 589);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(139, 34);
            this.BtnLogout.TabIndex = 14;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnTrack
            // 
            this.BtnTrack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnTrack.Location = new System.Drawing.Point(347, 589);
            this.BtnTrack.Name = "BtnTrack";
            this.BtnTrack.Size = new System.Drawing.Size(139, 34);
            this.BtnTrack.TabIndex = 13;
            this.BtnTrack.Text = "Track Order";
            this.BtnTrack.UseVisualStyleBackColor = true;
            this.BtnTrack.Click += new System.EventHandler(this.BtnTrackOrder_Click);
            // 
            // BtnViewOrder
            // 
            this.BtnViewOrder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnViewOrder.Location = new System.Drawing.Point(97, 589);
            this.BtnViewOrder.Name = "BtnViewOrder";
            this.BtnViewOrder.Size = new System.Drawing.Size(166, 34);
            this.BtnViewOrder.TabIndex = 12;
            this.BtnViewOrder.Text = "View Order";
            this.BtnViewOrder.UseVisualStyleBackColor = true;
            this.BtnViewOrder.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.Location = new System.Drawing.Point(368, 132);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(89, 34);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(118, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(363, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 30);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome";
            // 
            // BuyerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.gtvSearch);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnTrack);
            this.Controls.Add(this.BtnViewOrder);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWelcome);
            this.Name = "BuyerDashboardForm";
            this.Text = "BuyerDashboard";
            this.Load += new System.EventHandler(this.BuyerDashBoard_Load);
            this.gtvSearch.ResumeLayout(false);
            this.gtvSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gtvSearch;
        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnTrack;
        private System.Windows.Forms.Button BtnViewOrder;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWelcome;
    }
}
