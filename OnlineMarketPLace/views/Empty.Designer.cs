namespace OnlineMarketPLace.views
{
    partial class Empty
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
            this.lblempty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(545, 293);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(52, 20);
            this.lblempty.TabIndex = 0;
            this.lblempty.Text = "empty";
            // 
            // Empty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 793);
            this.Controls.Add(this.lblempty);
            this.Name = "Empty";
            this.Text = "Empty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempty;
    }
}