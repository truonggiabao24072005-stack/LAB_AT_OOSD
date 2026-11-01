namespace QuanLyThueVanPhong.Forms
{
    partial class FrmHopDongThue
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
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.btnTaoHopDong = new System.Windows.Forms.Button();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.lblTienCocTitle = new System.Windows.Forms.Label();
            this.lblTien6ThangDau = new System.Windows.Forms.Label();
            this.lblTien6ThangTitle = new System.Windows.Forms.Label();
            this.lblTongTien1Thang = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.numThoiHan = new System.Windows.Forms.NumericUpDown();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.chkListPhong = new System.Windows.Forms.CheckedListBox();
            this.lblChonPhong = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.lblDsHopDong = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(760, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP HỢP ĐỒNG THUÊ VĂN PHÒNG (THUÊ NHIỀU PHÒNG, THỜI HẠN TỐI THIỂU 6 THÁNG)";
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.btnTaoHopDong);
            this.grpNhapLieu.Controls.Add(this.lblTienCoc);
            this.grpNhapLieu.Controls.Add(this.lblTienCocTitle);
            this.grpNhapLieu.Controls.Add(this.lblTien6ThangDau);
            this.grpNhapLieu.Controls.Add(this.lblTien6ThangTitle);
            this.grpNhapLieu.Controls.Add(this.lblTongTien1Thang);
            this.grpNhapLieu.Controls.Add(this.lblTongTienTitle);
            this.grpNhapLieu.Controls.Add(this.dtpNgayBatDau);
            this.grpNhapLieu.Controls.Add(this.lblNgayBatDau);
            this.grpNhapLieu.Controls.Add(this.numThoiHan);
            this.grpNhapLieu.Controls.Add(this.lblThoiHan);
            this.grpNhapLieu.Controls.Add(this.chkListPhong);
            this.grpNhapLieu.Controls.Add(this.lblChonPhong);
            this.grpNhapLieu.Controls.Add(this.cboKhachHang);
            this.grpNhapLieu.Controls.Add(this.lblKhachHang);
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNhapLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpNhapLieu.Location = new System.Drawing.Point(18, 65);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(948, 220);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông Tin Ký Kết Hợp Đồng Thuê Văn Phòng";
            // 
            // btnTaoHopDong
            // 
            this.btnTaoHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(90)))));
            this.btnTaoHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHopDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoHopDong.ForeColor = System.Drawing.Color.White;
            this.btnTaoHopDong.Location = new System.Drawing.Point(620, 160);
            this.btnTaoHopDong.Name = "btnTaoHopDong";
            this.btnTaoHopDong.Size = new System.Drawing.Size(305, 45);
            this.btnTaoHopDong.TabIndex = 14;
            this.btnTaoHopDong.Text = "XÁC NHẬN KÝ HỢP ĐỒNG && TẠO HÓA ĐƠN 6 THÁNG";
            this.btnTaoHopDong.UseVisualStyleBackColor = false;
            this.btnTaoHopDong.Click += new System.EventHandler(this.btnTaoHopDong_Click);
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTienCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.lblTienCoc.Location = new System.Drawing.Point(785, 125);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(49, 19);
            this.lblTienCoc.TabIndex = 13;
            this.lblTienCoc.Text = "0 VNĐ";
            // 
            // lblTienCocTitle
            // 
            this.lblTienCocTitle.AutoSize = true;
            this.lblTienCocTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienCocTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.lblTienCocTitle.Location = new System.Drawing.Point(615, 127);
            this.lblTienCocTitle.Name = "lblTienCocTitle";
            this.lblTienCocTitle.Size = new System.Drawing.Size(130, 15);
            this.lblTienCocTitle.TabIndex = 12;
            this.lblTienCocTitle.Text = "Tiền đặt cọc (2 tháng):";
            // 
            // lblTien6ThangDau
            // 
            this.lblTien6ThangDau.AutoSize = true;
            this.lblTien6ThangDau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTien6ThangDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTien6ThangDau.Location = new System.Drawing.Point(785, 92);
            this.lblTien6ThangDau.Name = "lblTien6ThangDau";
            this.lblTien6ThangDau.Size = new System.Drawing.Size(55, 20);
            this.lblTien6ThangDau.TabIndex = 11;
            this.lblTien6ThangDau.Text = "0 VNĐ";
            // 
            // lblTien6ThangTitle
            // 
            this.lblTien6ThangTitle.AutoSize = true;
            this.lblTien6ThangTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTien6ThangTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTien6ThangTitle.Location = new System.Drawing.Point(615, 96);
            this.lblTien6ThangTitle.Name = "lblTien6ThangTitle";
            this.lblTien6ThangTitle.Size = new System.Drawing.Size(164, 15);
            this.lblTien6ThangTitle.TabIndex = 10;
            this.lblTien6ThangTitle.Text = "TRẢ TRƯỚC 6 THÁNG ĐẦU:";
            // 
            // lblTongTien1Thang
            // 
            this.lblTongTien1Thang.AutoSize = true;
            this.lblTongTien1Thang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien1Thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(90)))));
            this.lblTongTien1Thang.Location = new System.Drawing.Point(785, 62);
            this.lblTongTien1Thang.Name = "lblTongTien1Thang";
            this.lblTongTien1Thang.Size = new System.Drawing.Size(49, 19);
            this.lblTongTien1Thang.TabIndex = 9;
            this.lblTongTien1Thang.Text = "0 VNĐ";
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.AutoSize = true;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongTienTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.lblTongTienTitle.Location = new System.Drawing.Point(615, 65);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(117, 15);
            this.lblTongTienTitle.TabIndex = 8;
            this.lblTongTienTitle.Text = "Tiền thuê 1 tháng:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(740, 26);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(185, 24);
            this.dtpNgayBatDau.TabIndex = 7;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblNgayBatDau.Location = new System.Drawing.Point(615, 30);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(115, 15);
            this.lblNgayBatDau.TabIndex = 6;
            this.lblNgayBatDau.Text = "Ngày bắt đầu thuê:";
            // 
            // numThoiHan
            // 
            this.numThoiHan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numThoiHan.Location = new System.Drawing.Point(495, 27);
            this.numThoiHan.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numThoiHan.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numThoiHan.Name = "numThoiHan";
            this.numThoiHan.Size = new System.Drawing.Size(90, 24);
            this.numThoiHan.TabIndex = 5;
            this.numThoiHan.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numThoiHan.ValueChanged += new System.EventHandler(this.numThoiHan_ValueChanged);
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThoiHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblThoiHan.Location = new System.Drawing.Point(405, 30);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(86, 15);
            this.lblThoiHan.TabIndex = 4;
            this.lblThoiHan.Text = "Thời hạn (>=6):";
            // 
            // chkListPhong
            // 
            this.chkListPhong.CheckOnClick = true;
            this.chkListPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkListPhong.FormattingEnabled = true;
            this.chkListPhong.Location = new System.Drawing.Point(145, 65);
            this.chkListPhong.Name = "chkListPhong";
            this.chkListPhong.Size = new System.Drawing.Size(440, 140);
            this.chkListPhong.TabIndex = 3;
            this.chkListPhong.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListPhong_ItemCheck);
            // 
            // lblChonPhong
            // 
            this.lblChonPhong.AutoSize = true;
            this.lblChonPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChonPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblChonPhong.Location = new System.Drawing.Point(18, 65);
            this.lblChonPhong.Name = "lblChonPhong";
            this.lblChonPhong.Size = new System.Drawing.Size(121, 30);
            this.lblChonPhong.TabIndex = 2;
            this.lblChonPhong.Text = "Chọn văn phòng thuê:\n(Có thể chọn nhiều)";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(145, 26);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(240, 25);
            this.cboKhachHang.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblKhachHang.Location = new System.Drawing.Point(18, 30);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(95, 15);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Công ty / Khách:";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(18, 320);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersWidth = 25;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(948, 195);
            this.dgvHopDong.TabIndex = 2;
            // 
            // lblDsHopDong
            // 
            this.lblDsHopDong.AutoSize = true;
            this.lblDsHopDong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDsHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblDsHopDong.Location = new System.Drawing.Point(18, 295);
            this.lblDsHopDong.Name = "lblDsHopDong";
            this.lblDsHopDong.Size = new System.Drawing.Size(264, 19);
            this.lblDsHopDong.TabIndex = 3;
            this.lblDsHopDong.Text = "Danh Sách Hợp Đồng Thuê Trong Tòa Nhà";
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
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmHopDongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblDsHopDong);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHopDongThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Hợp Đồng Thuê Văn Phòng";
            this.Load += new System.EventHandler(this.FrmHopDongThue_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.CheckedListBox chkListPhong;
        private System.Windows.Forms.Label lblChonPhong;
        private System.Windows.Forms.NumericUpDown numThoiHan;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblTongTienTitle;
        private System.Windows.Forms.Label lblTongTien1Thang;
        private System.Windows.Forms.Label lblTien6ThangTitle;
        private System.Windows.Forms.Label lblTien6ThangDau;
        private System.Windows.Forms.Label lblTienCocTitle;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.Button btnTaoHopDong;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Label lblDsHopDong;
        private System.Windows.Forms.Button btnDong;
    }
}
