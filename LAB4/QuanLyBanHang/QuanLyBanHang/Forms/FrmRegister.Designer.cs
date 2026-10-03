namespace QuanLyBanHang.Forms {
 partial class FrmRegister {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(740, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblName
            this.lblName.Name = "lblName";
            this.lblName.Location = new System.Drawing.Point(25, 80);
            this.lblName.Size = new System.Drawing.Size(200, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên *";
            // txtName
            this.txtName.Name = "txtName";
            this.txtName.Location = new System.Drawing.Point(245, 75);
            this.txtName.Size = new System.Drawing.Size(510, 28);
            this.txtName.TabIndex = 2;
            this.txtName.MaxLength = 100;
            // lblIdentity
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Location = new System.Drawing.Point(25, 129);
            this.lblIdentity.Size = new System.Drawing.Size(200, 28);
            this.lblIdentity.TabIndex = 3;
            this.lblIdentity.Text = "CMND / Passport *";
            // txtIdentity
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Location = new System.Drawing.Point(245, 124);
            this.txtIdentity.Size = new System.Drawing.Size(510, 28);
            this.txtIdentity.TabIndex = 4;
            this.txtIdentity.MaxLength = 30;
            // lblAddress
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Location = new System.Drawing.Point(25, 178);
            this.lblAddress.Size = new System.Drawing.Size(200, 28);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa chỉ *";
            // txtAddress
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Location = new System.Drawing.Point(245, 173);
            this.txtAddress.Size = new System.Drawing.Size(510, 28);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.MaxLength = 250;
            // lblPhone
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Location = new System.Drawing.Point(25, 227);
            this.lblPhone.Size = new System.Drawing.Size(200, 28);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Điện thoại *";
            // txtPhone
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Location = new System.Drawing.Point(245, 222);
            this.txtPhone.Size = new System.Drawing.Size(510, 28);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.MaxLength = 20;
            // lblUsername
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Location = new System.Drawing.Point(25, 276);
            this.lblUsername.Size = new System.Drawing.Size(200, 28);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Tên đăng nhập *";
            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Location = new System.Drawing.Point(245, 271);
            this.txtUsername.Size = new System.Drawing.Size(510, 28);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.MaxLength = 50;
            // lblPassword
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Location = new System.Drawing.Point(25, 325);
            this.lblPassword.Size = new System.Drawing.Size(200, 28);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Mật khẩu *";
            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(245, 320);
            this.txtPassword.Size = new System.Drawing.Size(510, 28);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.MaxLength = 100;
            this.txtPassword.UseSystemPasswordChar = true;
            // lblConfirm
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Location = new System.Drawing.Point(25, 374);
            this.lblConfirm.Size = new System.Drawing.Size(200, 28);
            this.lblConfirm.TabIndex = 13;
            this.lblConfirm.Text = "Nhập lại mật khẩu *";
            // txtConfirm
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Location = new System.Drawing.Point(245, 369);
            this.txtConfirm.Size = new System.Drawing.Size(510, 28);
            this.txtConfirm.TabIndex = 14;
            this.txtConfirm.MaxLength = 100;
            this.txtConfirm.UseSystemPasswordChar = true;
            // lblEmail
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Location = new System.Drawing.Point(25, 423);
            this.lblEmail.Size = new System.Drawing.Size(200, 28);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email (tùy chọn)";
            // txtEmail
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(245, 418);
            this.txtEmail.Size = new System.Drawing.Size(510, 28);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.MaxLength = 254;
            // lblBirth
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Location = new System.Drawing.Point(25, 475);
            this.lblBirth.Size = new System.Drawing.Size(200, 28);
            this.lblBirth.TabIndex = 17;
            this.lblBirth.Text = "Ngày sinh *";
            // dtBirth
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Location = new System.Drawing.Point(245, 470);
            this.dtBirth.Size = new System.Drawing.Size(220, 28);
            this.dtBirth.TabIndex = 18;
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirth.CustomFormat = "dd/MM/yyyy";
            // lblNote
            this.lblNote.Name = "lblNote";
            this.lblNote.Location = new System.Drawing.Point(25, 515);
            this.lblNote.Size = new System.Drawing.Size(730, 45);
            this.lblNote.TabIndex = 19;
            this.lblNote.Text = "* Bắt buộc. Mật khẩu ít nhất 8 ký tự; tên đăng nhập 3–50 ký tự, dùng chữ, số hoặc _.";
            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Location = new System.Drawing.Point(245, 580);
            this.btnRegister.Size = new System.Drawing.Size(155, 38);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(600, 580);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(790, 650);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Đăng ký tài khoản";
   this.Name = "FrmRegister";
   this.Load += new System.EventHandler(this.FrmRegister_Load);

   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
 }
}
