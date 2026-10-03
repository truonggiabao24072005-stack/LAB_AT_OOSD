namespace QuanLyBanHang.Forms {
 partial class FrmCatalog {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProducts_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts_Nhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts_NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(800, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SẢN PHẨM";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblGroup
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Location = new System.Drawing.Point(25, 72);
            this.lblGroup.Size = new System.Drawing.Size(170, 28);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "Nhóm sản phẩm";
            // cboGroup
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Location = new System.Drawing.Point(180, 67);
            this.cboGroup.Size = new System.Drawing.Size(280, 28);
            this.cboGroup.TabIndex = 2;
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // btnReload
            this.btnReload.Name = "btnReload";
            this.btnReload.Location = new System.Drawing.Point(490, 63);
            this.btnReload.Size = new System.Drawing.Size(155, 38);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Tải danh sách";
            this.btnReload.UseVisualStyleBackColor = true;
            // dgvProducts
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Location = new System.Drawing.Point(25, 120);
            this.dgvProducts.Size = new System.Drawing.Size(950, 360);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 239, 244);
            this.dgvProducts.ColumnHeadersHeight = 32;
            this.dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvProducts_MaSP.Name = "dgvProducts_MaSP";
            this.dgvProducts_MaSP.DataPropertyName = "MaSP";
            this.dgvProducts_MaSP.HeaderText = "Mã SP";
            this.dgvProducts_MaSP.FillWeight = 60F;
            this.dgvProducts_MaSP.ReadOnly = true;
            this.dgvProducts.Columns.Add(this.dgvProducts_MaSP);
            this.dgvProducts_TenSP.Name = "dgvProducts_TenSP";
            this.dgvProducts_TenSP.DataPropertyName = "TenSP";
            this.dgvProducts_TenSP.HeaderText = "Tên sản phẩm";
            this.dgvProducts_TenSP.FillWeight = 170F;
            this.dgvProducts_TenSP.ReadOnly = true;
            this.dgvProducts.Columns.Add(this.dgvProducts_TenSP);
            this.dgvProducts_Nhom.Name = "dgvProducts_Nhom";
            this.dgvProducts_Nhom.DataPropertyName = "Nhom";
            this.dgvProducts_Nhom.HeaderText = "Nhóm";
            this.dgvProducts_Nhom.FillWeight = 105F;
            this.dgvProducts_Nhom.ReadOnly = true;
            this.dgvProducts.Columns.Add(this.dgvProducts_Nhom);
            this.dgvProducts_NhaSanXuat.Name = "dgvProducts_NhaSanXuat";
            this.dgvProducts_NhaSanXuat.DataPropertyName = "NhaSanXuat";
            this.dgvProducts_NhaSanXuat.HeaderText = "Nhà sản xuất";
            this.dgvProducts_NhaSanXuat.FillWeight = 120F;
            this.dgvProducts_NhaSanXuat.ReadOnly = true;
            this.dgvProducts.Columns.Add(this.dgvProducts_NhaSanXuat);
            this.dgvProducts_Gia.Name = "dgvProducts_Gia";
            this.dgvProducts_Gia.DataPropertyName = "Gia";
            this.dgvProducts_Gia.HeaderText = "Giá bán";
            this.dgvProducts_Gia.FillWeight = 100F;
            this.dgvProducts_Gia.ReadOnly = true;
            this.dgvProducts_Gia.DefaultCellStyle.Format = "N0";
            this.dgvProducts_Gia.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvProducts.Columns.Add(this.dgvProducts_Gia);
            this.dgvProducts_TinhTrang.Name = "dgvProducts_TinhTrang";
            this.dgvProducts_TinhTrang.DataPropertyName = "TinhTrang";
            this.dgvProducts_TinhTrang.HeaderText = "Tình trạng";
            this.dgvProducts_TinhTrang.FillWeight = 90F;
            this.dgvProducts_TinhTrang.ReadOnly = true;
            this.dgvProducts.Columns.Add(this.dgvProducts_TinhTrang);
            // btnDetail
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Location = new System.Drawing.Point(25, 505);
            this.btnDetail.Size = new System.Drawing.Size(155, 38);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Location = new System.Drawing.Point(195, 505);
            this.btnAdd.Size = new System.Drawing.Size(155, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm vào giỏ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // btnCart
            this.btnCart.Name = "btnCart";
            this.btnCart.Location = new System.Drawing.Point(365, 505);
            this.btnCart.Size = new System.Drawing.Size(155, 38);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.UseVisualStyleBackColor = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(820, 505);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1000, 610);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Sản phẩm";
   this.Name = "FrmCatalog";
   this.Load += new System.EventHandler(this.FrmCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_Nhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducts_TinhTrang;
 }
}
