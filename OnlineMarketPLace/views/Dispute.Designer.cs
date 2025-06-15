namespace OnlineMarketPLace.views
{
    partial class Dispute
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colComplaints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnResolve = new System.Windows.Forms.Button();
            this.lblDisputeResolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComplaints});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(262, 186);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(436, 78);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colComplaints
            // 
            this.colComplaints.Text = "Complaints";
            this.colComplaints.Width = 150;
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDismiss.Location = new System.Drawing.Point(505, 362);
            this.BtnDismiss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(167, 32);
            this.BtnDismiss.TabIndex = 11;
            this.BtnDismiss.Text = "Dismiss";
            this.BtnDismiss.UseVisualStyleBackColor = true;
            // 
            // BtnResolve
            // 
            this.BtnResolve.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResolve.Location = new System.Drawing.Point(294, 362);
            this.BtnResolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResolve.Name = "BtnResolve";
            this.BtnResolve.Size = new System.Drawing.Size(167, 32);
            this.BtnResolve.TabIndex = 10;
            this.BtnResolve.Text = "Resolve";
            this.BtnResolve.UseVisualStyleBackColor = true;
            // 
            // lblDisputeResolution
            // 
            this.lblDisputeResolution.AutoSize = true;
            this.lblDisputeResolution.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisputeResolution.Location = new System.Drawing.Point(357, 80);
            this.lblDisputeResolution.Name = "lblDisputeResolution";
            this.lblDisputeResolution.Size = new System.Drawing.Size(241, 29);
            this.lblDisputeResolution.TabIndex = 9;
            this.lblDisputeResolution.Text = "Dispute Resolution";
            // 
            // Dispute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 474);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnDismiss);
            this.Controls.Add(this.BtnResolve);
            this.Controls.Add(this.lblDisputeResolution);
            this.Name = "Dispute";
            this.Text = "Dispute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colComplaints;
        private System.Windows.Forms.Button BtnDismiss;
        private System.Windows.Forms.Button BtnResolve;
        private System.Windows.Forms.Label lblDisputeResolution;
    }
}