﻿namespace OnlineMarketplace
{
    partial class RegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.txtConfirmP = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.lbltopic = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccType);
            this.groupBox1.Controls.Add(this.txtConfirmP);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.lblconfirm);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(98, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 274);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Buyer",
            "Seller",
            "Admin"});
            this.cmbAccType.Location = new System.Drawing.Point(277, 213);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(249, 24);
            this.cmbAccType.TabIndex = 16;
            // 
            // txtConfirmP
            // 
            this.txtConfirmP.Location = new System.Drawing.Point(277, 152);
            this.txtConfirmP.Name = "txtConfirmP";
            this.txtConfirmP.Size = new System.Drawing.Size(249, 22);
            this.txtConfirmP.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(277, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(277, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 22);
            this.txtName.TabIndex = 13;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblAccount.Location = new System.Drawing.Point(78, 211);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(108, 21);
            this.lblAccount.TabIndex = 12;
            this.lblAccount.Text = "Account Type";
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblconfirm.Location = new System.Drawing.Point(78, 153);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(56, 21);
            this.lblconfirm.TabIndex = 11;
            this.lblconfirm.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblPassword.Location = new System.Drawing.Point(78, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.lblName.Location = new System.Drawing.Point(78, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Username";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(535, 393);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 40);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegister.Location = new System.Drawing.Point(152, 393);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(116, 40);
            this.BtnRegister.TabIndex = 13;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lbltopic
            // 
            this.lbltopic.AutoSize = true;
            this.lbltopic.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbltopic.Location = new System.Drawing.Point(287, 17);
            this.lbltopic.Name = "lbltopic";
            this.lbltopic.Size = new System.Drawing.Size(213, 30);
            this.lbltopic.TabIndex = 12;
            this.lbltopic.Text = "Create Account  ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.lbltopic);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.TextBox txtConfirmP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label lbltopic;
    }
}
