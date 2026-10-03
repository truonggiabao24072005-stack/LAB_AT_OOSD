namespace QuanLyBanHang.Forms {
 partial class FrmLogin {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(550, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblUsername
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Location = new System.Drawing.Point(35, 100);
            this.lblUsername.Size = new System.Drawing.Size(170, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập";
            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Location = new System.Drawing.Point(210, 95);
            this.txtUsername.Size = new System.Drawing.Size(345, 28);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.MaxLength = 50;
            // lblPassword
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Location = new System.Drawing.Point(35, 155);
            this.lblPassword.Size = new System.Drawing.Size(170, 28);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu";
            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(210, 150);
            this.txtPassword.Size = new System.Drawing.Size(345, 28);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.MaxLength = 100;
            this.txtPassword.UseSystemPasswordChar = true;
            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(35, 230);
            this.btnLogin.Size = new System.Drawing.Size(155, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Location = new System.Drawing.Point(215, 230);
            this.btnRegister.Size = new System.Drawing.Size(155, 38);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Đăng ký mới";
            this.btnRegister.UseVisualStyleBackColor = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(400, 230);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(610, 330);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Đăng nhập";
   this.Name = "FrmLogin";
   this.Load += new System.EventHandler(this.FrmLogin_Load);

   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
 }
}
