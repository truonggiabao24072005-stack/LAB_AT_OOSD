namespace QuanLyBanHang.Forms {
 partial class FrmMain {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Size = new System.Drawing.Size(940, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CỬA HÀNG ONLINE e-SHOPPING";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.Location = new System.Drawing.Point(30, 100);
            this.lblUser.Size = new System.Drawing.Size(940, 28);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Chưa đăng nhập";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnCatalog
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Location = new System.Drawing.Point(30, 150);
            this.btnCatalog.Size = new System.Drawing.Size(290, 80);
            this.btnCatalog.TabIndex = 2;
            this.btnCatalog.Text = "Xem sản phẩm";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalog.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnCart
            this.btnCart.Name = "btnCart";
            this.btnCart.Location = new System.Drawing.Point(355, 150);
            this.btnCart.Size = new System.Drawing.Size(290, 80);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnOrders
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Location = new System.Drawing.Point(680, 150);
            this.btnOrders.Size = new System.Drawing.Size(290, 80);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Đơn hàng của tôi";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(30, 265);
            this.btnLogin.Size = new System.Drawing.Size(290, 80);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Location = new System.Drawing.Point(355, 265);
            this.btnRegister.Size = new System.Drawing.Size(290, 80);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Location = new System.Drawing.Point(680, 265);
            this.btnLogout.Size = new System.Drawing.Size(290, 80);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            // btnExit
            this.btnExit.Name = "btnExit";
            this.btnExit.Location = new System.Drawing.Point(355, 380);
            this.btnExit.Size = new System.Drawing.Size(290, 80);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1000, 530);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "LAB4 - Cửa hàng online e-SHOPPING";
   this.Name = "FrmMain";
   this.Load += new System.EventHandler(this.FrmMain_Load);

   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
 }
}
