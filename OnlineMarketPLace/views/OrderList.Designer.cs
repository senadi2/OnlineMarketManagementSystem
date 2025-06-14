namespace OnlineMarketPLace.views
{
    partial class OrderList
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
            this.lblMyOrder = new System.Windows.Forms.Label();
            this.lblTbs = new System.Windows.Forms.Label();
            this.txtTabs = new System.Windows.Forms.TextBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyOrder
            // 
            this.lblMyOrder.AutoSize = true;
            this.lblMyOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyOrder.Location = new System.Drawing.Point(309, 13);
            this.lblMyOrder.Name = "lblMyOrder";
            this.lblMyOrder.Size = new System.Drawing.Size(130, 30);
            this.lblMyOrder.TabIndex = 0;
            this.lblMyOrder.Text = "My Order";
            // 
            // lblTbs
            // 
            this.lblTbs.AutoSize = true;
            this.lblTbs.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(162, 114);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 24;
            this.dgvGrid.Size = new System.Drawing.Size(240, 150);
            this.dgvGrid.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(114, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(371, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.txtTabs);
            this.Controls.Add(this.lblTbs);
            this.Controls.Add(this.lblMyOrder);
            this.Name = "OrderList";
            this.Text = "OrderList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyOrder;
        private System.Windows.Forms.Label lblTbs;
        private System.Windows.Forms.TextBox txtTabs;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}