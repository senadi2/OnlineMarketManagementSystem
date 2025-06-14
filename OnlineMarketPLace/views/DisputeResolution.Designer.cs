namespace OnlineMarketPLace.views
{
    partial class DisputeResolution
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
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnResolve = new System.Windows.Forms.Button();
            this.lblDisputeResolution = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colComplaints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDismiss.Location = new System.Drawing.Point(765, 548);
            this.BtnDismiss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(188, 40);
            this.BtnDismiss.TabIndex = 7;
            this.BtnDismiss.Text = "Dismiss";
            this.BtnDismiss.UseVisualStyleBackColor = true;
            // 
            // BtnResolve
            // 
            this.BtnResolve.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResolve.Location = new System.Drawing.Point(528, 548);
            this.BtnResolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResolve.Name = "BtnResolve";
            this.BtnResolve.Size = new System.Drawing.Size(188, 40);
            this.BtnResolve.TabIndex = 6;
            this.BtnResolve.Text = "Resolve";
            this.BtnResolve.UseVisualStyleBackColor = true;
            // 
            // lblDisputeResolution
            // 
            this.lblDisputeResolution.AutoSize = true;
            this.lblDisputeResolution.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisputeResolution.Location = new System.Drawing.Point(598, 195);
            this.lblDisputeResolution.Name = "lblDisputeResolution";
            this.lblDisputeResolution.Size = new System.Drawing.Size(280, 34);
            this.lblDisputeResolution.TabIndex = 5;
            this.lblDisputeResolution.Text = "Dispute Resolution";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComplaints});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(492, 328);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 96);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colComplaints
            // 
            this.colComplaints.Text = "Complaints";
            this.colComplaints.Width = 150;
            // 
            // DisputeResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 929);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnDismiss);
            this.Controls.Add(this.BtnResolve);
            this.Controls.Add(this.lblDisputeResolution);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisputeResolution";
            this.Text = "DisputeResolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDismiss;
        private System.Windows.Forms.Button BtnResolve;
        private System.Windows.Forms.Label lblDisputeResolution;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colComplaints;
    }
}