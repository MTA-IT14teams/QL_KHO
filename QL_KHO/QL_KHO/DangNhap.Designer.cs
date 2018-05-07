namespace QL_KHO
{
    partial class frmDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbForgetAccount = new System.Windows.Forms.LinkLabel();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.cbSaveInfo = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbForgetAccount
            // 
            this.lbForgetAccount.AutoSize = true;
            this.lbForgetAccount.Location = new System.Drawing.Point(238, 264);
            this.lbForgetAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbForgetAccount.Name = "lbForgetAccount";
            this.lbForgetAccount.Size = new System.Drawing.Size(91, 13);
            this.lbForgetAccount.TabIndex = 12;
            this.lbForgetAccount.TabStop = true;
            this.lbForgetAccount.Text = "Quên Tài Khoản?";
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(217, 358);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(97, 17);
            this.cbShowPass.TabIndex = 11;
            this.cbShowPass.Text = "Hiện Mật Khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            // 
            // cbSaveInfo
            // 
            this.cbSaveInfo.AutoSize = true;
            this.cbSaveInfo.Checked = true;
            this.cbSaveInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSaveInfo.Location = new System.Drawing.Point(79, 359);
            this.cbSaveInfo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSaveInfo.Name = "cbSaveInfo";
            this.cbSaveInfo.Size = new System.Drawing.Size(99, 18);
            this.cbSaveInfo.TabIndex = 10;
            this.cbSaveInfo.Text = "Nhớ tài khoản";
            this.cbSaveInfo.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(85, 295);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(244, 33);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(85, 240);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(245, 20);
            this.txtPassWord.TabIndex = 8;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(84, 200);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(245, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbForgetAccount);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.cbSaveInfo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmDangNhap";
            this.Text = "DangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbForgetAccount;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.CheckBox cbSaveInfo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
    }
}