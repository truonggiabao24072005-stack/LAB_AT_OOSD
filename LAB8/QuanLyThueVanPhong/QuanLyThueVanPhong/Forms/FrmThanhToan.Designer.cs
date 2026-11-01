namespace QuanLyThueVanPhong.Forms
{
    partial class FrmThanhToan
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
            this.tabThanhToan = new System.Windows.Forms.TabControl();
            this.tabTienThue = new System.Windows.Forms.TabPage();
            this.grpTaoHDThue = new System.Windows.Forms.GroupBox();
            this.btnTaoHoaDonThangMoi = new System.Windows.Forms.Button();
            this.txtNamThue = new System.Windows.Forms.TextBox();
            this.lblNamThue = new System.Windows.Forms.Label();
            this.cboThangThue = new System.Windows.Forms.ComboBox();
            this.lblThangThue = new System.Windows.Forms.Label();
            this.cboHopDongThue = new System.Windows.Forms.ComboBox();
            this.lblHDThue = new System.Windows.Forms.Label();
            this.btnXacNhanTienThue = new System.Windows.Forms.Button();
            this.dgvTienThue = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.grpTaoHDDV = new System.Windows.Forms.GroupBox();
            this.btnTaoHoaDonDV = new System.Windows.Forms.Button();
            this.numTienNet = new System.Windows.Forms.NumericUpDown();
            this.lblTienNet = new System.Windows.Forms.Label();
            this.numTienNuoc = new System.Windows.Forms.NumericUpDown();
            this.lblTienNuoc = new System.Windows.Forms.Label();
            this.numTienDien = new System.Windows.Forms.NumericUpDown();
            this.lblTienDien = new System.Windows.Forms.Label();
            this.txtPhongDV = new System.Windows.Forms.TextBox();
            this.lblPhongDV = new System.Windows.Forms.Label();
            this.txtNamDV = new System.Windows.Forms.TextBox();
            this.lblNamDV = new System.Windows.Forms.Label();
            this.cboThangDV = new System.Windows.Forms.ComboBox();
            this.lblThangDV = new System.Windows.Forms.Label();
            this.cboHopDongDV = new System.Windows.Forms.ComboBox();
            this.lblHDDV = new System.Windows.Forms.Label();
            this.btnXacNhanDichVu = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.tabThanhToan.SuspendLayout();
            this.tabTienThue.SuspendLayout();
            this.grpTaoHDThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienThue)).BeginInit();
            this.tabDichVu.SuspendLayout();
            this.grpTaoHDDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
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
            this.lblTitle.Text = "QUẢN LÝ THU TIỀN THUÊ VĂN PHÒNG && HÓA ĐƠN DỊCH VỤ CUỐI THÁNG (CÂU 4)";
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Controls.Add(this.tabTienThue);
            this.tabThanhToan.Controls.Add(this.tabDichVu);
            this.tabThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabThanhToan.Location = new System.Drawing.Point(18, 65);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.SelectedIndex = 0;
            this.tabThanhToan.Size = new System.Drawing.Size(948, 455);
            this.tabThanhToan.TabIndex = 1;
            // 
            // tabTienThue
            // 
            this.tabTienThue.Controls.Add(this.grpTaoHDThue);
            this.tabTienThue.Controls.Add(this.btnXacNhanTienThue);
            this.tabTienThue.Controls.Add(this.dgvTienThue);
            this.tabTienThue.Location = new System.Drawing.Point(4, 26);
            this.tabTienThue.Name = "tabTienThue";
            this.tabTienThue.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienThue.Size = new System.Drawing.Size(940, 425);
            this.tabTienThue.TabIndex = 0;
            this.tabTienThue.Text = "Hóa Đơn Tiền Thuê Mặt Bằng (Trả trước 6 tháng đầu; Đầu tháng từ tháng 7)";
            this.tabTienThue.UseVisualStyleBackColor = true;
            // 
            // grpTaoHDThue
            // 
            this.grpTaoHDThue.Controls.Add(this.btnTaoHoaDonThangMoi);
            this.grpTaoHDThue.Controls.Add(this.txtNamThue);
            this.grpTaoHDThue.Controls.Add(this.lblNamThue);
            this.grpTaoHDThue.Controls.Add(this.cboThangThue);
            this.grpTaoHDThue.Controls.Add(this.lblThangThue);
            this.grpTaoHDThue.Controls.Add(this.cboHopDongThue);
            this.grpTaoHDThue.Controls.Add(this.lblHDThue);
            this.grpTaoHDThue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTaoHDThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpTaoHDThue.Location = new System.Drawing.Point(15, 10);
            this.grpTaoHDThue.Name = "grpTaoHDThue";
            this.grpTaoHDThue.Size = new System.Drawing.Size(910, 65);
            this.grpTaoHDThue.TabIndex = 2;
            this.grpTaoHDThue.TabStop = false;
            this.grpTaoHDThue.Text = "Lập Hóa Đơn Thu Tiền Thuê Vào Đầu Tháng (Áp dụng từ tháng thứ 7 trở đi)";
            // 
            // btnTaoHoaDonThangMoi
            // 
            this.btnTaoHoaDonThangMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnTaoHoaDonThangMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoaDonThangMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoHoaDonThangMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoaDonThangMoi.Location = new System.Drawing.Point(700, 22);
            this.btnTaoHoaDonThangMoi.Name = "btnTaoHoaDonThangMoi";
            this.btnTaoHoaDonThangMoi.Size = new System.Drawing.Size(195, 30);
            this.btnTaoHoaDonThangMoi.TabIndex = 6;
            this.btnTaoHoaDonThangMoi.Text = "Xuất Hóa Đơn Đầu Tháng";
            this.btnTaoHoaDonThangMoi.UseVisualStyleBackColor = false;
            this.btnTaoHoaDonThangMoi.Click += new System.EventHandler(this.btnTaoHoaDonThangMoi_Click);
            // 
            // txtNamThue
            // 
            this.txtNamThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamThue.Location = new System.Drawing.Point(610, 26);
            this.txtNamThue.Name = "txtNamThue";
            this.txtNamThue.Size = new System.Drawing.Size(70, 23);
            this.txtNamThue.TabIndex = 5;
            // 
            // lblNamThue
            // 
            this.lblNamThue.AutoSize = true;
            this.lblNamThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamThue.Location = new System.Drawing.Point(570, 30);
            this.lblNamThue.Name = "lblNamThue";
            this.lblNamThue.Size = new System.Drawing.Size(36, 15);
            this.lblNamThue.TabIndex = 4;
            this.lblNamThue.Text = "Năm:";
            // 
            // cboThangThue
            // 
            this.cboThangThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThangThue.FormattingEnabled = true;
            this.cboThangThue.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cboThangThue.Location = new System.Drawing.Point(460, 26);
            this.cboThangThue.Name = "cboThangThue";
            this.cboThangThue.Size = new System.Drawing.Size(100, 23);
            this.cboThangThue.TabIndex = 3;
            // 
            // lblThangThue
            // 
            this.lblThangThue.AutoSize = true;
            this.lblThangThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThangThue.Location = new System.Drawing.Point(410, 30);
            this.lblThangThue.Name = "lblThangThue";
            this.lblThangThue.Size = new System.Drawing.Size(43, 15);
            this.lblThangThue.TabIndex = 2;
            this.lblThangThue.Text = "Tháng:";
            // 
            // cboHopDongThue
            // 
            this.cboHopDongThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDongThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHopDongThue.FormattingEnabled = true;
            this.cboHopDongThue.Location = new System.Drawing.Point(95, 26);
            this.cboHopDongThue.Name = "cboHopDongThue";
            this.cboHopDongThue.Size = new System.Drawing.Size(300, 23);
            this.cboHopDongThue.TabIndex = 1;
            // 
            // lblHDThue
            // 
            this.lblHDThue.AutoSize = true;
            this.lblHDThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHDThue.Location = new System.Drawing.Point(15, 30);
            this.lblHDThue.Name = "lblHDThue";
            this.lblHDThue.Size = new System.Drawing.Size(64, 15);
            this.lblHDThue.TabIndex = 0;
            this.lblHDThue.Text = "Hợp đồng:";
            // 
            // btnXacNhanTienThue
            // 
            this.btnXacNhanTienThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.btnXacNhanTienThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanTienThue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanTienThue.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanTienThue.Location = new System.Drawing.Point(15, 375);
            this.btnXacNhanTienThue.Name = "btnXacNhanTienThue";
            this.btnXacNhanTienThue.Size = new System.Drawing.Size(260, 40);
            this.btnXacNhanTienThue.TabIndex = 1;
            this.btnXacNhanTienThue.Text = "XÁC NHẬN KHÁCH ĐÃ NỘP TIỀN";
            this.btnXacNhanTienThue.UseVisualStyleBackColor = false;
            this.btnXacNhanTienThue.Click += new System.EventHandler(this.btnXacNhanTienThue_Click);
            // 
            // dgvTienThue
            // 
            this.dgvTienThue.AllowUserToAddRows = false;
            this.dgvTienThue.AllowUserToDeleteRows = false;
            this.dgvTienThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienThue.BackgroundColor = System.Drawing.Color.White;
            this.dgvTienThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienThue.Location = new System.Drawing.Point(15, 85);
            this.dgvTienThue.Name = "dgvTienThue";
            this.dgvTienThue.ReadOnly = true;
            this.dgvTienThue.RowHeadersWidth = 25;
            this.dgvTienThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTienThue.Size = new System.Drawing.Size(910, 280);
            this.dgvTienThue.TabIndex = 0;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.grpTaoHDDV);
            this.tabDichVu.Controls.Add(this.btnXacNhanDichVu);
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Location = new System.Drawing.Point(4, 26);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(940, 425);
            this.tabDichVu.TabIndex = 1;
            this.tabDichVu.Text = "Hóa Đơn Dịch Vụ (Điện, Nước, Internet thanh toán vào CUỐI THÁNG)";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // grpTaoHDDV
            // 
            this.grpTaoHDDV.Controls.Add(this.btnTaoHoaDonDV);
            this.grpTaoHDDV.Controls.Add(this.numTienNet);
            this.grpTaoHDDV.Controls.Add(this.lblTienNet);
            this.grpTaoHDDV.Controls.Add(this.numTienNuoc);
            this.grpTaoHDDV.Controls.Add(this.lblTienNuoc);
            this.grpTaoHDDV.Controls.Add(this.numTienDien);
            this.grpTaoHDDV.Controls.Add(this.lblTienDien);
            this.grpTaoHDDV.Controls.Add(this.txtPhongDV);
            this.grpTaoHDDV.Controls.Add(this.lblPhongDV);
            this.grpTaoHDDV.Controls.Add(this.txtNamDV);
            this.grpTaoHDDV.Controls.Add(this.lblNamDV);
            this.grpTaoHDDV.Controls.Add(this.cboThangDV);
            this.grpTaoHDDV.Controls.Add(this.lblThangDV);
            this.grpTaoHDDV.Controls.Add(this.cboHopDongDV);
            this.grpTaoHDDV.Controls.Add(this.lblHDDV);
            this.grpTaoHDDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTaoHDDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpTaoHDDV.Location = new System.Drawing.Point(15, 10);
            this.grpTaoHDDV.Name = "grpTaoHDDV";
            this.grpTaoHDDV.Size = new System.Drawing.Size(910, 100);
            this.grpTaoHDDV.TabIndex = 3;
            this.grpTaoHDDV.TabStop = false;
            this.grpTaoHDDV.Text = "Chốt Chỉ Số && Lập Hóa Đơn Dịch Vụ Vào Cuối Mỗi Tháng";
            // 
            // btnTaoHoaDonDV
            // 
            this.btnTaoHoaDonDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnTaoHoaDonDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoaDonDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoHoaDonDV.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoaDonDV.Location = new System.Drawing.Point(700, 58);
            this.btnTaoHoaDonDV.Name = "btnTaoHoaDonDV";
            this.btnTaoHoaDonDV.Size = new System.Drawing.Size(195, 32);
            this.btnTaoHoaDonDV.TabIndex = 14;
            this.btnTaoHoaDonDV.Text = "Lập Hóa Đơn Cuối Tháng";
            this.btnTaoHoaDonDV.UseVisualStyleBackColor = false;
            this.btnTaoHoaDonDV.Click += new System.EventHandler(this.btnTaoHoaDonDV_Click);
            // 
            // numTienNet
            // 
            this.numTienNet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTienNet.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTienNet.Location = new System.Drawing.Point(545, 63);
            this.numTienNet.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numTienNet.Name = "numTienNet";
            this.numTienNet.Size = new System.Drawing.Size(130, 23);
            this.numTienNet.TabIndex = 13;
            this.numTienNet.Value = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            // 
            // lblTienNet
            // 
            this.lblTienNet.AutoSize = true;
            this.lblTienNet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienNet.Location = new System.Drawing.Point(465, 66);
            this.lblTienNet.Name = "lblTienNet";
            this.lblTienNet.Size = new System.Drawing.Size(78, 15);
            this.lblTienNet.TabIndex = 12;
            this.lblTienNet.Text = "Tiền Internet:";
            // 
            // numTienNuoc
            // 
            this.numTienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTienNuoc.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numTienNuoc.Location = new System.Drawing.Point(325, 63);
            this.numTienNuoc.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numTienNuoc.Name = "numTienNuoc";
            this.numTienNuoc.Size = new System.Drawing.Size(125, 23);
            this.numTienNuoc.TabIndex = 11;
            this.numTienNuoc.Value = new decimal(new int[] {
            450000,
            0,
            0,
            0});
            // 
            // lblTienNuoc
            // 
            this.lblTienNuoc.AutoSize = true;
            this.lblTienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienNuoc.Location = new System.Drawing.Point(255, 66);
            this.lblTienNuoc.Name = "lblTienNuoc";
            this.lblTienNuoc.Size = new System.Drawing.Size(64, 15);
            this.lblTienNuoc.TabIndex = 10;
            this.lblTienNuoc.Text = "Tiền Nước:";
            // 
            // numTienDien
            // 
            this.numTienDien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTienDien.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTienDien.Location = new System.Drawing.Point(95, 63);
            this.numTienDien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTienDien.Name = "numTienDien";
            this.numTienDien.Size = new System.Drawing.Size(140, 23);
            this.numTienDien.TabIndex = 9;
            this.numTienDien.Value = new decimal(new int[] {
            4500000,
            0,
            0,
            0});
            // 
            // lblTienDien
            // 
            this.lblTienDien.AutoSize = true;
            this.lblTienDien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienDien.Location = new System.Drawing.Point(15, 66);
            this.lblTienDien.Name = "lblTienDien";
            this.lblTienDien.Size = new System.Drawing.Size(59, 15);
            this.lblTienDien.TabIndex = 8;
            this.lblTienDien.Text = "Tiền Điện:";
            // 
            // txtPhongDV
            // 
            this.txtPhongDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhongDV.Location = new System.Drawing.Point(745, 23);
            this.txtPhongDV.Name = "txtPhongDV";
            this.txtPhongDV.Size = new System.Drawing.Size(85, 23);
            this.txtPhongDV.TabIndex = 7;
            this.txtPhongDV.Text = "P501";
            // 
            // lblPhongDV
            // 
            this.lblPhongDV.AutoSize = true;
            this.lblPhongDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhongDV.Location = new System.Drawing.Point(695, 27);
            this.lblPhongDV.Name = "lblPhongDV";
            this.lblPhongDV.Size = new System.Drawing.Size(44, 15);
            this.lblPhongDV.TabIndex = 6;
            this.lblPhongDV.Text = "Phòng:";
            // 
            // txtNamDV
            // 
            this.txtNamDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamDV.Location = new System.Drawing.Point(605, 23);
            this.txtNamDV.Name = "txtNamDV";
            this.txtNamDV.Size = new System.Drawing.Size(70, 23);
            this.txtNamDV.TabIndex = 5;
            // 
            // lblNamDV
            // 
            this.lblNamDV.AutoSize = true;
            this.lblNamDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamDV.Location = new System.Drawing.Point(565, 27);
            this.lblNamDV.Name = "lblNamDV";
            this.lblNamDV.Size = new System.Drawing.Size(36, 15);
            this.lblNamDV.TabIndex = 4;
            this.lblNamDV.Text = "Năm:";
            // 
            // cboThangDV
            // 
            this.cboThangDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThangDV.FormattingEnabled = true;
            this.cboThangDV.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cboThangDV.Location = new System.Drawing.Point(455, 23);
            this.cboThangDV.Name = "cboThangDV";
            this.cboThangDV.Size = new System.Drawing.Size(95, 23);
            this.cboThangDV.TabIndex = 3;
            // 
            // lblThangDV
            // 
            this.lblThangDV.AutoSize = true;
            this.lblThangDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThangDV.Location = new System.Drawing.Point(405, 27);
            this.lblThangDV.Name = "lblThangDV";
            this.lblThangDV.Size = new System.Drawing.Size(43, 15);
            this.lblThangDV.TabIndex = 2;
            this.lblThangDV.Text = "Tháng:";
            // 
            // cboHopDongDV
            // 
            this.cboHopDongDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDongDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHopDongDV.FormattingEnabled = true;
            this.cboHopDongDV.Location = new System.Drawing.Point(95, 23);
            this.cboHopDongDV.Name = "cboHopDongDV";
            this.cboHopDongDV.Size = new System.Drawing.Size(295, 23);
            this.cboHopDongDV.TabIndex = 1;
            // 
            // lblHDDV
            // 
            this.lblHDDV.AutoSize = true;
            this.lblHDDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHDDV.Location = new System.Drawing.Point(15, 27);
            this.lblHDDV.Name = "lblHDDV";
            this.lblHDDV.Size = new System.Drawing.Size(64, 15);
            this.lblHDDV.TabIndex = 0;
            this.lblHDDV.Text = "Hợp đồng:";
            // 
            // btnXacNhanDichVu
            // 
            this.btnXacNhanDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.btnXacNhanDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanDichVu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDichVu.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDichVu.Location = new System.Drawing.Point(15, 375);
            this.btnXacNhanDichVu.Name = "btnXacNhanDichVu";
            this.btnXacNhanDichVu.Size = new System.Drawing.Size(260, 40);
            this.btnXacNhanDichVu.TabIndex = 2;
            this.btnXacNhanDichVu.Text = "XÁC NHẬN ĐÃ NỘP TIỀN DỊCH VỤ";
            this.btnXacNhanDichVu.UseVisualStyleBackColor = false;
            this.btnXacNhanDichVu.Click += new System.EventHandler(this.btnXacNhanDichVu_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(15, 120);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersWidth = 25;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(910, 245);
            this.dgvDichVu.TabIndex = 1;
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
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabThanhToan);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Thu Tiền Thuê & Hóa Đơn Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabThanhToan.ResumeLayout(false);
            this.tabTienThue.ResumeLayout(false);
            this.grpTaoHDThue.ResumeLayout(false);
            this.grpTaoHDThue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienThue)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            this.grpTaoHDDV.ResumeLayout(false);
            this.grpTaoHDDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabThanhToan;
        private System.Windows.Forms.TabPage tabTienThue;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.DataGridView dgvTienThue;
        private System.Windows.Forms.Button btnXacNhanTienThue;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnXacNhanDichVu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpTaoHDThue;
        private System.Windows.Forms.ComboBox cboHopDongThue;
        private System.Windows.Forms.Label lblHDThue;
        private System.Windows.Forms.ComboBox cboThangThue;
        private System.Windows.Forms.Label lblThangThue;
        private System.Windows.Forms.TextBox txtNamThue;
        private System.Windows.Forms.Label lblNamThue;
        private System.Windows.Forms.Button btnTaoHoaDonThangMoi;
        private System.Windows.Forms.GroupBox grpTaoHDDV;
        private System.Windows.Forms.Button btnTaoHoaDonDV;
        private System.Windows.Forms.NumericUpDown numTienNet;
        private System.Windows.Forms.Label lblTienNet;
        private System.Windows.Forms.NumericUpDown numTienNuoc;
        private System.Windows.Forms.Label lblTienNuoc;
        private System.Windows.Forms.NumericUpDown numTienDien;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.TextBox txtPhongDV;
        private System.Windows.Forms.Label lblPhongDV;
        private System.Windows.Forms.TextBox txtNamDV;
        private System.Windows.Forms.Label lblNamDV;
        private System.Windows.Forms.ComboBox cboThangDV;
        private System.Windows.Forms.Label lblThangDV;
        private System.Windows.Forms.ComboBox cboHopDongDV;
        private System.Windows.Forms.Label lblHDDV;
    }
}
