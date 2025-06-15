namespace OnlineMarketPLace.views
{
    partial class SellerProfileForm
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
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.BtnReviewList = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSellerProfile
            // 
            this.lblSellerProfile.AutoSize = true;
            this.lblSellerProfile.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerProfile.Location = new System.Drawing.Point(322, 13);
            this.lblSellerProfile.Name = "lblSellerProfile";
            this.lblSellerProfile.Size = new System.Drawing.Size(181, 30);
            this.lblSellerProfile.TabIndex = 0;
            this.lblSellerProfile.Text = "Seller Profile";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.Location = new System.Drawing.Point(44, 67);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(98, 21);
            this.lblSellerName.TabIndex = 1;
            this.lblSellerName.Text = "Seller Name";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(44, 153);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 21);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(172, 68);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(511, 22);
            this.txtSellerName.TabIndex = 3;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(172, 152);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(511, 22);
            this.txtRating.TabIndex = 4;
            // 
            // BtnReviewList
            // 
            this.BtnReviewList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReviewList.Location = new System.Drawing.Point(149, 326);
            this.BtnReviewList.Name = "BtnReviewList";
            this.BtnReviewList.Size = new System.Drawing.Size(133, 32);
            this.BtnReviewList.TabIndex = 5;
            this.BtnReviewList.Text = "ReviewList";
            this.BtnReviewList.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(462, 326);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 32);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // SellerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReviewList);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.lblSellerProfile);
            this.Name = "SellerProfile";
            this.Text = "SellerProfile";
            this.Load += new System.EventHandler(this.SellerProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerProfile;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button BtnReviewList;
        private System.Windows.Forms.Button BtnBack;
    }
}