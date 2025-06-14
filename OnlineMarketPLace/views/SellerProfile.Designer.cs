namespace OnlineMarketPLace.views
{
    partial class SellerProfile
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
            this.lblSellerProfile = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSellerProfile
            // 
            this.lblSellerProfile.AutoSize = true;
            this.lblSellerProfile.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerProfile.Location = new System.Drawing.Point(308, 31);
            this.lblSellerProfile.Name = "lblSellerProfile";
            this.lblSellerProfile.Size = new System.Drawing.Size(181, 30);
            this.lblSellerProfile.TabIndex = 0;
            this.lblSellerProfile.Text = "Seller Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(79, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Seller Name";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(79, 173);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 21);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating";
            // 
            // btnReviews
            // 
            this.btnReviews.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Location = new System.Drawing.Point(82, 287);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(102, 30);
            this.btnReviews.TabIndex = 3;
            this.btnReviews.Text = "Review";
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(484, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(398, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(200, 167);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(398, 22);
            this.txtRating.TabIndex = 6;
            // 
            // SellerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReviews);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSellerProfile);
            this.Name = "SellerProfile";
            this.Text = "SellerProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRating;
    }
}