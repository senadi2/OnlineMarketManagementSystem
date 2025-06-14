namespace OnlineMarketPLace.views
{
    partial class DashBoardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gtvSearch = new System.Windows.Forms.GroupBox();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblProductList = new System.Windows.Forms.Label();
            this.gtvSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(333, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(88, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(338, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Location = new System.Drawing.Point(67, 572);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(166, 34);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            // 
            // btnTrack
            // 
            this.btnTrack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrack.Location = new System.Drawing.Point(317, 572);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(139, 34);
            this.btnTrack.TabIndex = 6;
            this.btnTrack.Text = "Track Order";
            this.btnTrack.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(534, 572);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 34);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // gtvSearch
            // 
            this.gtvSearch.Controls.Add(this.dgvgrid);
            this.gtvSearch.Controls.Add(this.lblProductList);
            this.gtvSearch.Location = new System.Drawing.Point(88, 184);
            this.gtvSearch.Name = "gtvSearch";
            this.gtvSearch.Size = new System.Drawing.Size(585, 331);
            this.gtvSearch.TabIndex = 8;
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
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.gtvSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.gtvSearch.ResumeLayout(false);
            this.gtvSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gtvSearch;
        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblProductList;
    }
}