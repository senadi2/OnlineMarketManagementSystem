namespace OnlineMarketPLace.views
{
    partial class ViewProductReviews
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
            this.lblReviews = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bBnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(203, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Reviews";
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(276, 130);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(68, 21);
            this.lblReviews.TabIndex = 1;
            this.lblReviews.Text = "Reviews";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(174, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 248);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bBnBack
            // 
            this.bBnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBnBack.Location = new System.Drawing.Point(174, 480);
            this.bBnBack.Name = "bBnBack";
            this.bBnBack.Size = new System.Drawing.Size(89, 38);
            this.bBnBack.TabIndex = 3;
            this.bBnBack.Text = "Back";
            this.bBnBack.UseVisualStyleBackColor = true;
            // 
            // ViewProductReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 530);
            this.Controls.Add(this.bBnBack);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblReviews);
            this.Controls.Add(this.lblTitle);
            this.Name = "ViewProductReviews";
            this.Text = "ViewProductReviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bBnBack;
    }
}