namespace QuanLyThueVanPhong.Forms
{
    partial class FrmPhongTang
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.grpTinhGia = new System.Windows.Forms.GroupBox();
            this.lblKetQuaTinh = new System.Windows.Forms.Label();
            this.lblKetQuaTitle = new System.Windows.Forms.Label();
            this.btnTinhGia = new System.Windows.Forms.Button();
            this.cboTangMoi = new System.Windows.Forms.ComboBox();
            this.lblTangMoi = new System.Windows.Forms.Label();
            this.txtDienTichMoi = new System.Windows.Forms.TextBox();
            this.lblDienTichMoi = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grpTinhGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(635, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ MẶT BẰNG, TẦNG && ĐỊNH GIÁ CHO THUÊ THEO ĐỘ CAO, DIỆN TÍCH";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboTinhTrang);
            this.grpFilter.Controls.Add(this.lblTinhTrang);
            this.grpFilter.Controls.Add(this.cboTang);
            this.grpFilter.Controls.Add(this.lblTang);
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpFilter.Location = new System.Drawing.Point(18, 65);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(928, 65);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Bộ Lọc & Tra Cứu Văn Phòng";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "-- Tất cả tình trạng --",
            "Trống",
            "Đang thuê",
            "Chờ tu sửa",
            "Vi phạm"});
            this.cboTinhTrang.Location = new System.Drawing.Point(620, 24);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(220, 25);
            this.cboTinhTrang.TabIndex = 3;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboTinhTrang_SelectedIndexChanged);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblTinhTrang.Location = new System.Drawing.Point(545, 29);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(64, 15);
            this.lblTinhTrang.TabIndex = 2;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // cboTang
            // 
            this.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(120, 24);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(350, 25);
            this.cboTang.TabIndex = 1;
            this.cboTang.SelectedIndexChanged += new System.EventHandler(this.cboTang_SelectedIndexChanged);
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblTang.Location = new System.Drawing.Point(20, 29);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(89, 15);
            this.lblTang.TabIndex = 0;
            this.lblTang.Text = "Chọn tầng lầu:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(18, 140);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 25;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(928, 260);
            this.dgvPhong.TabIndex = 2;
            // 
            // grpTinhGia
            // 
            this.grpTinhGia.Controls.Add(this.lblKetQuaTinh);
            this.grpTinhGia.Controls.Add(this.lblKetQuaTitle);
            this.grpTinhGia.Controls.Add(this.btnTinhGia);
            this.grpTinhGia.Controls.Add(this.cboTangMoi);
            this.grpTinhGia.Controls.Add(this.lblTangMoi);
            this.grpTinhGia.Controls.Add(this.txtDienTichMoi);
            this.grpTinhGia.Controls.Add(this.lblDienTichMoi);
            this.grpTinhGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTinhGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpTinhGia.Location = new System.Drawing.Point(18, 410);
            this.grpTinhGia.Name = "grpTinhGia";
            this.grpTinhGia.Size = new System.Drawing.Size(760, 100);
            this.grpTinhGia.TabIndex = 3;
            this.grpTinhGia.TabStop = false;
            this.grpTinhGia.Text = "Công Cụ Tính Nhanh Giá Thuê (Diện tích * Đơn giá sàn * Hệ số tầng cao)";
            // 
            // lblKetQuaTinh
            // 
            this.lblKetQuaTinh.AutoSize = true;
            this.lblKetQuaTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(90)))));
            this.lblKetQuaTinh.Location = new System.Drawing.Point(180, 65);
            this.lblKetQuaTinh.Name = "lblKetQuaTinh";
            this.lblKetQuaTinh.Size = new System.Drawing.Size(55, 20);
            this.lblKetQuaTinh.TabIndex = 6;
            this.lblKetQuaTinh.Text = "0 VNĐ";
            // 
            // lblKetQuaTitle
            // 
            this.lblKetQuaTitle.AutoSize = true;
            this.lblKetQuaTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKetQuaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblKetQuaTitle.Location = new System.Drawing.Point(20, 68);
            this.lblKetQuaTitle.Name = "lblKetQuaTitle";
            this.lblKetQuaTitle.Size = new System.Drawing.Size(155, 15);
            this.lblKetQuaTitle.TabIndex = 5;
            this.lblKetQuaTitle.Text = "Giá thuê dự kiến mỗi tháng:";
            // 
            // btnTinhGia
            // 
            this.btnTinhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.btnTinhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTinhGia.ForeColor = System.Drawing.Color.White;
            this.btnTinhGia.Location = new System.Drawing.Point(580, 24);
            this.btnTinhGia.Name = "btnTinhGia";
            this.btnTinhGia.Size = new System.Drawing.Size(150, 32);
            this.btnTinhGia.TabIndex = 4;
            this.btnTinhGia.Text = "Tính Giá Thuê";
            this.btnTinhGia.UseVisualStyleBackColor = false;
            this.btnTinhGia.Click += new System.EventHandler(this.btnTinhGia_Click);
            // 
            // cboTangMoi
            // 
            this.cboTangMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTangMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTangMoi.FormattingEnabled = true;
            this.cboTangMoi.Items.AddRange(new object[] {
            "Tầng 1 (Độ cao 4m - Hệ số 1.0)",
            "Tầng 5 (Độ cao 20m - Hệ số 1.2)",
            "Tầng 10 (Độ cao 40m - Hệ số 1.4)",
            "Tầng 18 Sky (Độ cao 72m - Hệ số 1.7)"});
            this.cboTangMoi.Location = new System.Drawing.Point(340, 28);
            this.cboTangMoi.Name = "cboTangMoi";
            this.cboTangMoi.Size = new System.Drawing.Size(210, 25);
            this.cboTangMoi.TabIndex = 3;
            // 
            // lblTangMoi
            // 
            this.lblTangMoi.AutoSize = true;
            this.lblTangMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTangMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblTangMoi.Location = new System.Drawing.Point(270, 32);
            this.lblTangMoi.Name = "lblTangMoi";
            this.lblTangMoi.Size = new System.Drawing.Size(65, 15);
            this.lblTangMoi.TabIndex = 2;
            this.lblTangMoi.Text = "Chọn tầng:";
            // 
            // txtDienTichMoi
            // 
            this.txtDienTichMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienTichMoi.Location = new System.Drawing.Point(120, 28);
            this.txtDienTichMoi.Name = "txtDienTichMoi";
            this.txtDienTichMoi.Size = new System.Drawing.Size(120, 24);
            this.txtDienTichMoi.TabIndex = 1;
            this.txtDienTichMoi.Text = "100";
            // 
            // lblDienTichMoi
            // 
            this.lblDienTichMoi.AutoSize = true;
            this.lblDienTichMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDienTichMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblDienTichMoi.Location = new System.Drawing.Point(20, 32);
            this.lblDienTichMoi.Name = "lblDienTichMoi";
            this.lblDienTichMoi.Size = new System.Drawing.Size(89, 15);
            this.lblDienTichMoi.TabIndex = 0;
            this.lblDienTichMoi.Text = "Diện tích (m2):";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnDong.Location = new System.Drawing.Point(795, 435);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 50);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhongTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(964, 525);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpTinhGia);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhongTang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Tầng & Văn Phòng Cho Thuê";
            this.Load += new System.EventHandler(this.FrmPhongTang_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grpTinhGia.ResumeLayout(false);
            this.grpTinhGia.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox grpTinhGia;
        private System.Windows.Forms.TextBox txtDienTichMoi;
        private System.Windows.Forms.Label lblDienTichMoi;
        private System.Windows.Forms.ComboBox cboTangMoi;
        private System.Windows.Forms.Label lblTangMoi;
        private System.Windows.Forms.Button btnTinhGia;
        private System.Windows.Forms.Label lblKetQuaTitle;
        private System.Windows.Forms.Label lblKetQuaTinh;
        private System.Windows.Forms.Button btnDong;
    }
}
