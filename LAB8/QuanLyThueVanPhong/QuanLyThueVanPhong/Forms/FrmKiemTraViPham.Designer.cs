namespace QuanLyThueVanPhong.Forms
{
    partial class FrmKiemTraViPham
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
            this.tabKiemTra = new System.Windows.Forms.TabControl();
            this.tabDinhKy = new System.Windows.Forms.TabPage();
            this.lblDsBB = new System.Windows.Forms.Label();
            this.dgvBienBanKT = new System.Windows.Forms.DataGridView();
            this.lblDsDot = new System.Windows.Forms.Label();
            this.dgvDotKT = new System.Windows.Forms.DataGridView();
            this.tabXuPhat = new System.Windows.Forms.TabPage();
            this.btnNopPhat = new System.Windows.Forms.Button();
            this.dgvViPham = new System.Windows.Forms.DataGridView();
            this.grpLapQDPhat = new System.Windows.Forms.GroupBox();
            this.btnLapBienBanVP = new System.Windows.Forms.Button();
            this.numNgayKhacPhuc = new System.Windows.Forms.NumericUpDown();
            this.lblNgayKhacPhuc = new System.Windows.Forms.Label();
            this.txtBienPhap = new System.Windows.Forms.TextBox();
            this.lblBienPhap = new System.Windows.Forms.Label();
            this.numMucPhat = new System.Windows.Forms.NumericUpDown();
            this.lblMucPhat = new System.Windows.Forms.Label();
            this.txtHanhVi = new System.Windows.Forms.TextBox();
            this.lblHanhVi = new System.Windows.Forms.Label();
            this.cboKhachVP = new System.Windows.Forms.ComboBox();
            this.lblKhachVP = new System.Windows.Forms.Label();
            this.cboPhongVP = new System.Windows.Forms.ComboBox();
            this.lblPhongVP = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.tabKiemTra.SuspendLayout();
            this.tabDinhKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotKT)).BeginInit();
            this.tabXuPhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).BeginInit();
            this.grpLapQDPhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgayKhacPhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMucPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
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
            this.lblTitle.Size = new System.Drawing.Size(735, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KIỂM TRA PHÒNG ĐỊNH KỲ 1 NĂM/LẦN && XỬ PHẠT TỰ Ý SỬA ĐỔI KẾT CẤU";
            // 
            // tabKiemTra
            // 
            this.tabKiemTra.Controls.Add(this.tabDinhKy);
            this.tabKiemTra.Controls.Add(this.tabXuPhat);
            this.tabKiemTra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabKiemTra.Location = new System.Drawing.Point(18, 65);
            this.tabKiemTra.Name = "tabKiemTra";
            this.tabKiemTra.SelectedIndex = 0;
            this.tabKiemTra.Size = new System.Drawing.Size(948, 455);
            this.tabKiemTra.TabIndex = 1;
            // 
            // tabDinhKy
            // 
            this.tabDinhKy.Controls.Add(this.lblDsBB);
            this.tabDinhKy.Controls.Add(this.dgvBienBanKT);
            this.tabDinhKy.Controls.Add(this.lblDsDot);
            this.tabDinhKy.Controls.Add(this.dgvDotKT);
            this.tabDinhKy.Location = new System.Drawing.Point(4, 26);
            this.tabDinhKy.Name = "tabDinhKy";
            this.tabDinhKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinhKy.Size = new System.Drawing.Size(940, 425);
            this.tabDinhKy.TabIndex = 0;
            this.tabDinhKy.Text = "Kiểm Tra Định Kỳ Kết Cấu 1 Năm / Lần (Lập Kế Hoạch Tu Sửa)";
            this.tabDinhKy.UseVisualStyleBackColor = true;
            // 
            // lblDsBB
            // 
            this.lblDsBB.AutoSize = true;
            this.lblDsBB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDsBB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblDsBB.Location = new System.Drawing.Point(15, 185);
            this.lblDsBB.Name = "lblDsBB";
            this.lblDsBB.Size = new System.Drawing.Size(325, 19);
            this.lblDsBB.TabIndex = 3;
            this.lblDsBB.Text = "Chi Tiết Biên Bản Kiểm Tra Hiện Trạng Từng Phòng";
            // 
            // dgvBienBanKT
            // 
            this.dgvBienBanKT.AllowUserToAddRows = false;
            this.dgvBienBanKT.AllowUserToDeleteRows = false;
            this.dgvBienBanKT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienBanKT.BackgroundColor = System.Drawing.Color.White;
            this.dgvBienBanKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienBanKT.Location = new System.Drawing.Point(15, 210);
            this.dgvBienBanKT.Name = "dgvBienBanKT";
            this.dgvBienBanKT.ReadOnly = true;
            this.dgvBienBanKT.RowHeadersWidth = 25;
            this.dgvBienBanKT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienBanKT.Size = new System.Drawing.Size(910, 200);
            this.dgvBienBanKT.TabIndex = 2;
            // 
            // lblDsDot
            // 
            this.lblDsDot.AutoSize = true;
            this.lblDsDot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDsDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblDsDot.Location = new System.Drawing.Point(15, 10);
            this.lblDsDot.Name = "lblDsDot";
            this.lblDsDot.Size = new System.Drawing.Size(262, 19);
            this.lblDsDot.TabIndex = 1;
            this.lblDsDot.Text = "Các Đợt Kiểm Tra Định Kỳ Của Cao Ốc";
            // 
            // dgvDotKT
            // 
            this.dgvDotKT.AllowUserToAddRows = false;
            this.dgvDotKT.AllowUserToDeleteRows = false;
            this.dgvDotKT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDotKT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDotKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotKT.Location = new System.Drawing.Point(15, 35);
            this.dgvDotKT.Name = "dgvDotKT";
            this.dgvDotKT.ReadOnly = true;
            this.dgvDotKT.RowHeadersWidth = 25;
            this.dgvDotKT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDotKT.Size = new System.Drawing.Size(910, 135);
            this.dgvDotKT.TabIndex = 0;
            // 
            // tabXuPhat
            // 
            this.tabXuPhat.Controls.Add(this.btnNopPhat);
            this.tabXuPhat.Controls.Add(this.dgvViPham);
            this.tabXuPhat.Controls.Add(this.grpLapQDPhat);
            this.tabXuPhat.Location = new System.Drawing.Point(4, 26);
            this.tabXuPhat.Name = "tabXuPhat";
            this.tabXuPhat.Padding = new System.Windows.Forms.Padding(3);
            this.tabXuPhat.Size = new System.Drawing.Size(940, 425);
            this.tabXuPhat.TabIndex = 1;
            this.tabXuPhat.Text = "Xử Phạt Vi Phạm Tự Ý Thay Đổi, Chỉnh Sửa Kết Cấu Văn Phòng";
            this.tabXuPhat.UseVisualStyleBackColor = true;
            // 
            // btnNopPhat
            // 
            this.btnNopPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(90)))));
            this.btnNopPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopPhat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNopPhat.ForeColor = System.Drawing.Color.White;
            this.btnNopPhat.Location = new System.Drawing.Point(15, 375);
            this.btnNopPhat.Name = "btnNopPhat";
            this.btnNopPhat.Size = new System.Drawing.Size(325, 40);
            this.btnNopPhat.TabIndex = 2;
            this.btnNopPhat.Text = "XÁC NHẬN NỘP PHẠT && KHÔI PHỤC KẾT CẤU";
            this.btnNopPhat.UseVisualStyleBackColor = false;
            this.btnNopPhat.Click += new System.EventHandler(this.btnNopPhat_Click);
            // 
            // dgvViPham
            // 
            this.dgvViPham.AllowUserToAddRows = false;
            this.dgvViPham.AllowUserToDeleteRows = false;
            this.dgvViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViPham.Location = new System.Drawing.Point(15, 175);
            this.dgvViPham.Name = "dgvViPham";
            this.dgvViPham.ReadOnly = true;
            this.dgvViPham.RowHeadersWidth = 25;
            this.dgvViPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViPham.Size = new System.Drawing.Size(910, 190);
            this.dgvViPham.TabIndex = 1;
            // 
            // grpLapQDPhat
            // 
            this.grpLapQDPhat.Controls.Add(this.btnLapBienBanVP);
            this.grpLapQDPhat.Controls.Add(this.numNgayKhacPhuc);
            this.grpLapQDPhat.Controls.Add(this.lblNgayKhacPhuc);
            this.grpLapQDPhat.Controls.Add(this.txtBienPhap);
            this.grpLapQDPhat.Controls.Add(this.lblBienPhap);
            this.grpLapQDPhat.Controls.Add(this.numMucPhat);
            this.grpLapQDPhat.Controls.Add(this.lblMucPhat);
            this.grpLapQDPhat.Controls.Add(this.txtHanhVi);
            this.grpLapQDPhat.Controls.Add(this.lblHanhVi);
            this.grpLapQDPhat.Controls.Add(this.cboKhachVP);
            this.grpLapQDPhat.Controls.Add(this.lblKhachVP);
            this.grpLapQDPhat.Controls.Add(this.cboPhongVP);
            this.grpLapQDPhat.Controls.Add(this.lblPhongVP);
            this.grpLapQDPhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLapQDPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grpLapQDPhat.Location = new System.Drawing.Point(15, 10);
            this.grpLapQDPhat.Name = "grpLapQDPhat";
            this.grpLapQDPhat.Size = new System.Drawing.Size(910, 155);
            this.grpLapQDPhat.TabIndex = 0;
            this.grpLapQDPhat.TabStop = false;
            this.grpLapQDPhat.Text = "Lập Biên Bản Xử Phạt Tự Ý Thay Đổi, Chỉnh Sửa Kết Cấu Văn Phòng";
            // 
            // btnLapBienBanVP
            // 
            this.btnLapBienBanVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnLapBienBanVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBienBanVP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLapBienBanVP.ForeColor = System.Drawing.Color.White;
            this.btnLapBienBanVP.Location = new System.Drawing.Point(545, 100);
            this.btnLapBienBanVP.Name = "btnLapBienBanVP";
            this.btnLapBienBanVP.Size = new System.Drawing.Size(350, 40);
            this.btnLapBienBanVP.TabIndex = 12;
            this.btnLapBienBanVP.Text = "BAN HÀNH QUYẾT ĐỊNH XỬ PHẠT VI PHẠM";
            this.btnLapBienBanVP.UseVisualStyleBackColor = false;
            this.btnLapBienBanVP.Click += new System.EventHandler(this.btnLapBienBanVP_Click);
            // 
            // numNgayKhacPhuc
            // 
            this.numNgayKhacPhuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numNgayKhacPhuc.Location = new System.Drawing.Point(400, 110);
            this.numNgayKhacPhuc.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numNgayKhacPhuc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNgayKhacPhuc.Name = "numNgayKhacPhuc";
            this.numNgayKhacPhuc.Size = new System.Drawing.Size(100, 23);
            this.numNgayKhacPhuc.TabIndex = 11;
            this.numNgayKhacPhuc.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNgayKhacPhuc
            // 
            this.lblNgayKhacPhuc.AutoSize = true;
            this.lblNgayKhacPhuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayKhacPhuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblNgayKhacPhuc.Location = new System.Drawing.Point(280, 114);
            this.lblNgayKhacPhuc.Name = "lblNgayKhacPhuc";
            this.lblNgayKhacPhuc.Size = new System.Drawing.Size(109, 15);
            this.lblNgayKhacPhuc.TabIndex = 10;
            this.lblNgayKhacPhuc.Text = "Thời hạn khôi phục:";
            // 
            // txtBienPhap
            // 
            this.txtBienPhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBienPhap.Location = new System.Drawing.Point(545, 62);
            this.txtBienPhap.Name = "txtBienPhap";
            this.txtBienPhap.Size = new System.Drawing.Size(350, 23);
            this.txtBienPhap.TabIndex = 9;
            this.txtBienPhap.Text = "Buộc khôi phục nguyên trạng kết cấu ban đầu";
            // 
            // lblBienPhap
            // 
            this.lblBienPhap.AutoSize = true;
            this.lblBienPhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBienPhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblBienPhap.Location = new System.Drawing.Point(475, 66);
            this.lblBienPhap.Name = "lblBienPhap";
            this.lblBienPhap.Size = new System.Drawing.Size(63, 15);
            this.lblBienPhap.TabIndex = 8;
            this.lblBienPhap.Text = "Biện pháp:";
            // 
            // numMucPhat
            // 
            this.numMucPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numMucPhat.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMucPhat.Location = new System.Drawing.Point(110, 110);
            this.numMucPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMucPhat.Name = "numMucPhat";
            this.numMucPhat.Size = new System.Drawing.Size(140, 23);
            this.numMucPhat.TabIndex = 7;
            this.numMucPhat.Value = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            // 
            // lblMucPhat
            // 
            this.lblMucPhat.AutoSize = true;
            this.lblMucPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMucPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblMucPhat.Location = new System.Drawing.Point(15, 114);
            this.lblMucPhat.Name = "lblMucPhat";
            this.lblMucPhat.Size = new System.Drawing.Size(81, 15);
            this.lblMucPhat.TabIndex = 6;
            this.lblMucPhat.Text = "Mức phạt tiền:";
            // 
            // txtHanhVi
            // 
            this.txtHanhVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHanhVi.Location = new System.Drawing.Point(110, 62);
            this.txtHanhVi.Name = "txtHanhVi";
            this.txtHanhVi.Size = new System.Drawing.Size(340, 23);
            this.txtHanhVi.TabIndex = 5;
            this.txtHanhVi.Text = "Tự ý thay đổi, chỉnh sửa kết cấu văn phòng khi chưa xin phép BQL";
            // 
            // lblHanhVi
            // 
            this.lblHanhVi.AutoSize = true;
            this.lblHanhVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHanhVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblHanhVi.Location = new System.Drawing.Point(15, 66);
            this.lblHanhVi.Name = "lblHanhVi";
            this.lblHanhVi.Size = new System.Drawing.Size(51, 15);
            this.lblHanhVi.TabIndex = 4;
            this.lblHanhVi.Text = "Hành vi:";
            // 
            // cboKhachVP
            // 
            this.cboKhachVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachVP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhachVP.FormattingEnabled = true;
            this.cboKhachVP.Location = new System.Drawing.Point(400, 24);
            this.cboKhachVP.Name = "cboKhachVP";
            this.cboKhachVP.Size = new System.Drawing.Size(495, 23);
            this.cboKhachVP.TabIndex = 3;
            // 
            // lblKhachVP
            // 
            this.lblKhachVP.AutoSize = true;
            this.lblKhachVP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblKhachVP.Location = new System.Drawing.Point(280, 28);
            this.lblKhachVP.Name = "lblKhachVP";
            this.lblKhachVP.Size = new System.Drawing.Size(107, 15);
            this.lblKhachVP.TabIndex = 2;
            this.lblKhachVP.Text = "Doanh nghiệp thuê:";
            // 
            // cboPhongVP
            // 
            this.cboPhongVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongVP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhongVP.FormattingEnabled = true;
            this.cboPhongVP.Location = new System.Drawing.Point(110, 24);
            this.cboPhongVP.Name = "cboPhongVP";
            this.cboPhongVP.Size = new System.Drawing.Size(140, 23);
            this.cboPhongVP.TabIndex = 1;
            // 
            // lblPhongVP
            // 
            this.lblPhongVP.AutoSize = true;
            this.lblPhongVP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhongVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblPhongVP.Location = new System.Drawing.Point(15, 28);
            this.lblPhongVP.Name = "lblPhongVP";
            this.lblPhongVP.Size = new System.Drawing.Size(87, 15);
            this.lblPhongVP.TabIndex = 0;
            this.lblPhongVP.Text = "Phòng vi phạm:";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnDong.Location = new System.Drawing.Point(825, 525);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 35);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKiemTraViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabKiemTra);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKiemTraViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm Tra Định Kỳ & Xử Lý Vi Phạm Kết Cấu";
            this.Load += new System.EventHandler(this.FrmKiemTraViPham_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabKiemTra.ResumeLayout(false);
            this.tabDinhKy.ResumeLayout(false);
            this.tabDinhKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotKT)).EndInit();
            this.tabXuPhat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).EndInit();
            this.grpLapQDPhat.ResumeLayout(false);
            this.grpLapQDPhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgayKhacPhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMucPhat)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabKiemTra;
        private System.Windows.Forms.TabPage tabDinhKy;
        private System.Windows.Forms.TabPage tabXuPhat;
        private System.Windows.Forms.Label lblDsDot;
        private System.Windows.Forms.DataGridView dgvDotKT;
        private System.Windows.Forms.Label lblDsBB;
        private System.Windows.Forms.DataGridView dgvBienBanKT;
        private System.Windows.Forms.GroupBox grpLapQDPhat;
        private System.Windows.Forms.ComboBox cboPhongVP;
        private System.Windows.Forms.Label lblPhongVP;
        private System.Windows.Forms.ComboBox cboKhachVP;
        private System.Windows.Forms.Label lblKhachVP;
        private System.Windows.Forms.TextBox txtHanhVi;
        private System.Windows.Forms.Label lblHanhVi;
        private System.Windows.Forms.Label lblMucPhat;
        private System.Windows.Forms.NumericUpDown numMucPhat;
        private System.Windows.Forms.TextBox txtBienPhap;
        private System.Windows.Forms.Label lblBienPhap;
        private System.Windows.Forms.NumericUpDown numNgayKhacPhuc;
        private System.Windows.Forms.Label lblNgayKhacPhuc;
        private System.Windows.Forms.Button btnLapBienBanVP;
        private System.Windows.Forms.DataGridView dgvViPham;
        private System.Windows.Forms.Button btnNopPhat;
        private System.Windows.Forms.Button btnDong;
    }
}
