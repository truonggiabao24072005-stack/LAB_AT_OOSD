namespace QuanLyThueVanPhong.Forms
{
    partial class FrmNhanVienTheXe
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

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grpTheXe = new System.Windows.Forms.GroupBox();
            this.btnCapTheXe = new System.Windows.Forms.Button();
            this.txtMauXe = new System.Windows.Forms.TextBox();
            this.lblMauXe = new System.Windows.Forms.Label();
            this.txtNhanHieu = new System.Windows.Forms.TextBox();
            this.lblNhanHieu = new System.Windows.Forms.Label();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.cboNhanVienTheXe = new System.Windows.Forms.ComboBox();
            this.lblNVTheXe = new System.Windows.Forms.Label();
            this.dgvTheXe = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grpTheXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(685, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN VĂN PHÒNG && CẤP PHÁT THẺ GIỮ XE CAO ỐC (AN TOÀN)";
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.btnThemNV);
            this.grpNhanVien.Controls.Add(this.txtEmail);
            this.grpNhanVien.Controls.Add(this.lblEmail);
            this.grpNhanVien.Controls.Add(this.txtSDT);
            this.grpNhanVien.Controls.Add(this.lblSDT);
            this.grpNhanVien.Controls.Add(this.cboPhong);
            this.grpNhanVien.Controls.Add(this.lblPhong);
            this.grpNhanVien.Controls.Add(this.cboTang);
            this.grpNhanVien.Controls.Add(this.lblTang);
            this.grpNhanVien.Controls.Add(this.txtChucVu);
            this.grpNhanVien.Controls.Add(this.lblChucVu);
            this.grpNhanVien.Controls.Add(this.cboCongTy);
            this.grpNhanVien.Controls.Add(this.lblCongTy);
            this.grpNhanVien.Controls.Add(this.txtHoTen);
            this.grpNhanVien.Controls.Add(this.lblHoTen);
            this.grpNhanVien.Controls.Add(this.txtMaNV);
            this.grpNhanVien.Controls.Add(this.lblMaNV);
            this.grpNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpNhanVien.Location = new System.Drawing.Point(18, 65);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(465, 240);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Tiếp Nhận Báo Cáo Nhân Viên Mới";
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(120, 195);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(325, 32);
            this.btnThemNV.TabIndex = 16;
            this.btnThemNV.Text = "TIẾP NHẬN BÁO CÁO NHÂN VIÊN";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(315, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(265, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(120, 160);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 23);
            this.txtSDT.TabIndex = 13;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT.Location = new System.Drawing.Point(15, 164);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(79, 15);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(315, 126);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(130, 23);
            this.cboPhong.TabIndex = 11;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhong.Location = new System.Drawing.Point(265, 130);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(44, 15);
            this.lblPhong.TabIndex = 10;
            this.lblPhong.Text = "Phòng:";
            // 
            // cboTang
            // 
            this.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(120, 126);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(130, 23);
            this.cboTang.TabIndex = 9;
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTang.Location = new System.Drawing.Point(15, 130);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(55, 15);
            this.lblTang.TabIndex = 8;
            this.lblTang.Text = "Tầng lầu:";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChucVu.Location = new System.Drawing.Point(120, 93);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(325, 23);
            this.txtChucVu.TabIndex = 7;
            this.txtChucVu.Text = "Chuyên viên Kỹ thuật";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChucVu.Location = new System.Drawing.Point(15, 96);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(54, 15);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // cboCongTy
            // 
            this.cboCongTy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongTy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCongTy.FormattingEnabled = true;
            this.cboCongTy.Location = new System.Drawing.Point(120, 60);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(325, 23);
            this.cboCongTy.TabIndex = 5;
            // 
            // lblCongTy
            // 
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCongTy.Location = new System.Drawing.Point(15, 63);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(52, 15);
            this.lblCongTy.TabIndex = 4;
            this.lblCongTy.Text = "Công ty:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(280, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(165, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(220, 31);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 15);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(120, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(90, 23);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaNV.Location = new System.Drawing.Point(15, 31);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(82, 15);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(18, 315);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 25;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(465, 195);
            this.dgvNhanVien.TabIndex = 2;
            // 
            // grpTheXe
            // 
            this.grpTheXe.Controls.Add(this.btnCapTheXe);
            this.grpTheXe.Controls.Add(this.txtMauXe);
            this.grpTheXe.Controls.Add(this.lblMauXe);
            this.grpTheXe.Controls.Add(this.txtNhanHieu);
            this.grpTheXe.Controls.Add(this.lblNhanHieu);
            this.grpTheXe.Controls.Add(this.cboLoaiXe);
            this.grpTheXe.Controls.Add(this.lblLoaiXe);
            this.grpTheXe.Controls.Add(this.txtBienSo);
            this.grpTheXe.Controls.Add(this.lblBienSo);
            this.grpTheXe.Controls.Add(this.cboNhanVienTheXe);
            this.grpTheXe.Controls.Add(this.lblNVTheXe);
            this.grpTheXe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTheXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpTheXe.Location = new System.Drawing.Point(500, 65);
            this.grpTheXe.Name = "grpTheXe";
            this.grpTheXe.Size = new System.Drawing.Size(465, 240);
            this.grpTheXe.TabIndex = 3;
            this.grpTheXe.TabStop = false;
            this.grpTheXe.Text = "Cấp Thẻ Giữ Xe Cho Nhân Viên";
            // 
            // btnCapTheXe
            // 
            this.btnCapTheXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnCapTheXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapTheXe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCapTheXe.ForeColor = System.Drawing.Color.White;
            this.btnCapTheXe.Location = new System.Drawing.Point(120, 195);
            this.btnCapTheXe.Name = "btnCapTheXe";
            this.btnCapTheXe.Size = new System.Drawing.Size(325, 32);
            this.btnCapTheXe.TabIndex = 10;
            this.btnCapTheXe.Text = "CẤP THẺ GIỮ XE CAO ỐC";
            this.btnCapTheXe.UseVisualStyleBackColor = false;
            this.btnCapTheXe.Click += new System.EventHandler(this.btnCapTheXe_Click);
            // 
            // txtMauXe
            // 
            this.txtMauXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMauXe.Location = new System.Drawing.Point(325, 126);
            this.txtMauXe.Name = "txtMauXe";
            this.txtMauXe.Size = new System.Drawing.Size(120, 23);
            this.txtMauXe.TabIndex = 9;
            this.txtMauXe.Text = "Trắng";
            // 
            // lblMauXe
            // 
            this.lblMauXe.AutoSize = true;
            this.lblMauXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMauXe.Location = new System.Drawing.Point(265, 130);
            this.lblMauXe.Name = "lblMauXe";
            this.lblMauXe.Size = new System.Drawing.Size(50, 15);
            this.lblMauXe.TabIndex = 8;
            this.lblMauXe.Text = "Màu xe:";
            // 
            // txtNhanHieu
            // 
            this.txtNhanHieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhanHieu.Location = new System.Drawing.Point(120, 126);
            this.txtNhanHieu.Name = "txtNhanHieu";
            this.txtNhanHieu.Size = new System.Drawing.Size(130, 23);
            this.txtNhanHieu.TabIndex = 7;
            this.txtNhanHieu.Text = "Honda AirBlade";
            // 
            // lblNhanHieu
            // 
            this.lblNhanHieu.AutoSize = true;
            this.lblNhanHieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanHieu.Location = new System.Drawing.Point(15, 130);
            this.lblNhanHieu.Name = "lblNhanHieu";
            this.lblNhanHieu.Size = new System.Drawing.Size(65, 15);
            this.lblNhanHieu.TabIndex = 6;
            this.lblNhanHieu.Text = "Nhãn hiệu:";
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Items.AddRange(new object[] {
            "Xe máy",
            "Xe ô tô",
            "Xe đạp điện"});
            this.cboLoaiXe.Location = new System.Drawing.Point(120, 93);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(325, 23);
            this.cboLoaiXe.TabIndex = 5;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiXe.Location = new System.Drawing.Point(15, 96);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(47, 15);
            this.lblLoaiXe.TabIndex = 4;
            this.lblLoaiXe.Text = "Loại xe:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBienSo.Location = new System.Drawing.Point(120, 60);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(325, 23);
            this.txtBienSo.TabIndex = 3;
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBienSo.Location = new System.Drawing.Point(15, 63);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(65, 15);
            this.lblBienSo.TabIndex = 2;
            this.lblBienSo.Text = "Biển số xe:";
            // 
            // cboNhanVienTheXe
            // 
            this.cboNhanVienTheXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTheXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVienTheXe.FormattingEnabled = true;
            this.cboNhanVienTheXe.Location = new System.Drawing.Point(120, 27);
            this.cboNhanVienTheXe.Name = "cboNhanVienTheXe";
            this.cboNhanVienTheXe.Size = new System.Drawing.Size(325, 23);
            this.cboNhanVienTheXe.TabIndex = 1;
            // 
            // lblNVTheXe
            // 
            this.lblNVTheXe.AutoSize = true;
            this.lblNVTheXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNVTheXe.Location = new System.Drawing.Point(15, 31);
            this.lblNVTheXe.Name = "lblNVTheXe";
            this.lblNVTheXe.Size = new System.Drawing.Size(95, 15);
            this.lblNVTheXe.TabIndex = 0;
            this.lblNVTheXe.Text = "Chọn nhân viên:";
            // 
            // dgvTheXe
            // 
            this.dgvTheXe.AllowUserToAddRows = false;
            this.dgvTheXe.AllowUserToDeleteRows = false;
            this.dgvTheXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheXe.Location = new System.Drawing.Point(500, 315);
            this.dgvTheXe.Name = "dgvTheXe";
            this.dgvTheXe.ReadOnly = true;
            this.dgvTheXe.RowHeadersWidth = 25;
            this.dgvTheXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheXe.Size = new System.Drawing.Size(465, 195);
            this.dgvTheXe.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnDong.Location = new System.Drawing.Point(825, 520);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 35);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNhanVienTheXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvTheXe);
            this.Controls.Add(this.grpTheXe);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.grpNhanVien);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhanVienTheXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nhân Viên Công Ty & Cấp Thẻ Giữ Xe";
            this.Load += new System.EventHandler(this.FrmNhanVienTheXe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grpTheXe.ResumeLayout(false);
            this.grpTheXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grpTheXe;
        private System.Windows.Forms.ComboBox cboNhanVienTheXe;
        private System.Windows.Forms.Label lblNVTheXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.TextBox txtNhanHieu;
        private System.Windows.Forms.Label lblNhanHieu;
        private System.Windows.Forms.TextBox txtMauXe;
        private System.Windows.Forms.Label lblMauXe;
        private System.Windows.Forms.Button btnCapTheXe;
        private System.Windows.Forms.DataGridView dgvTheXe;
        private System.Windows.Forms.Button btnDong;
    }
}
