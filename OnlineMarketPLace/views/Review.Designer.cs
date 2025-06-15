using System;
using System.Windows.Forms;

namespace OnlineMarketPLace.views
{
    partial class ReviewForm : Form
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblCommentT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(318, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Leave a Review";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSubmit.Location = new System.Drawing.Point(105, 375);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(87, 38);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(617, 375);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 38);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.cmbRating);
            this.groupBox1.Controls.Add(this.lblRating);
            this.groupBox1.Controls.Add(this.lblCommentT);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9F);
            this.groupBox1.Location = new System.Drawing.Point(105, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Review";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(148, 95);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(420, 103);
            this.txtComment.TabIndex = 1;
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "★☆☆☆☆",
            "★★☆☆☆",
            "★★★☆☆",
            "★★★★☆",
            "★★★★★"});
            this.cmbRating.Location = new System.Drawing.Point(148, 40);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(121, 25);
            this.cmbRating.TabIndex = 0;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblRating.Location = new System.Drawing.Point(31, 40);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 21);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating";
            // 
            // lblCommentT
            // 
            this.lblCommentT.AutoSize = true;
            this.lblCommentT.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblCommentT.Location = new System.Drawing.Point(31, 95);
            this.lblCommentT.Name = "lblCommentT";
            this.lblCommentT.Size = new System.Drawing.Size(79, 21);
            this.lblCommentT.TabIndex = 3;
            this.lblCommentT.Text = "Comment";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReviewForm";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblCommentT;
    }
}
