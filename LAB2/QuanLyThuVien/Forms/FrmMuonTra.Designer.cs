namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();

            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.tabTra = new System.Windows.Forms.TabPage();

            this.lblDocGiaMuon = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();

            this.lblNhanVienMuon = new System.Windows.Forms.Label();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();

            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();

            this.lblHenTra = new System.Windows.Forms.Label();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();

            this.lblSachCon = new System.Windows.Forms.Label();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();

            this.colSachConMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSachConTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSachConNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSachConSL = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnBoSach = new System.Windows.Forms.Button();

            this.lblSachChon = new System.Windows.Forms.Label();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();

            this.colSachChonMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSachChonTen = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnLapPhieu = new System.Windows.Forms.Button();

            this.lblDocGiaTra = new System.Windows.Forms.Label();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();

            this.lblNhanVienTra = new System.Windows.Forms.Label();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();

            this.lblDangMuon = new System.Windows.Forms.Label();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();

            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();

            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();

            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();

            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabMuon.SuspendLayout();
            this.tabTra.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();

            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1210, 45);
            this.pnlHeader.TabIndex = 0;

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblHeader.Location = new System.Drawing.Point(15, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(114, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Mượn - Trả sách";

            this.tabs.Controls.Add(this.tabMuon);
            this.tabs.Controls.Add(this.tabTra);
            this.tabs.Location = new System.Drawing.Point(15, 55);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1180, 690);
            this.tabs.TabIndex = 1;

            this.tabMuon.Controls.Add(this.lblDocGiaMuon);
            this.tabMuon.Controls.Add(this.cboDocGia);
            this.tabMuon.Controls.Add(this.btnKiemTra);
            this.tabMuon.Controls.Add(this.lblTrangThai);
            this.tabMuon.Controls.Add(this.lblNhanVienMuon);
            this.tabMuon.Controls.Add(this.cboNhanVienMuon);
            this.tabMuon.Controls.Add(this.lblNgayMuon);
            this.tabMuon.Controls.Add(this.dtNgayMuon);
            this.tabMuon.Controls.Add(this.lblHenTra);
            this.tabMuon.Controls.Add(this.dtHenTra);
            this.tabMuon.Controls.Add(this.lblSachCon);
            this.tabMuon.Controls.Add(this.dgvSachCon);
            this.tabMuon.Controls.Add(this.btnThemSach);
            this.tabMuon.Controls.Add(this.btnBoSach);
            this.tabMuon.Controls.Add(this.lblSachChon);
            this.tabMuon.Controls.Add(this.dgvSachChon);
            this.tabMuon.Controls.Add(this.btnLapPhieu);
            this.tabMuon.Location = new System.Drawing.Point(4, 30);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1172, 656);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;

            this.lblDocGiaMuon.AutoSize = true;
            this.lblDocGiaMuon.Location = new System.Drawing.Point(28, 28);
            this.lblDocGiaMuon.Name = "lblDocGiaMuon";
            this.lblDocGiaMuon.Size = new System.Drawing.Size(61, 21);
            this.lblDocGiaMuon.TabIndex = 0;
            this.lblDocGiaMuon.Text = "Độc giả:";

            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(105, 24);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(235, 29);
            this.cboDocGia.TabIndex = 1;

            this.btnKiemTra.Location = new System.Drawing.Point(355, 21);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(175, 34);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra điều kiện";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);

            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(550, 28);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 21);
            this.lblTrangThai.TabIndex = 3;

            this.lblNhanVienMuon.AutoSize = true;
            this.lblNhanVienMuon.Location = new System.Drawing.Point(28, 72);
            this.lblNhanVienMuon.Name = "lblNhanVienMuon";
            this.lblNhanVienMuon.Size = new System.Drawing.Size(135, 21);
            this.lblNhanVienMuon.TabIndex = 4;
            this.lblNhanVienMuon.Text = "Nhân viên lập phiếu:";

            this.cboNhanVienMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(170, 68);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(135, 29);
            this.cboNhanVienMuon.TabIndex = 5;

            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(340, 72);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(90, 21);
            this.lblNgayMuon.TabIndex = 6;
            this.lblNgayMuon.Text = "Ngày mượn:";

            this.dtNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMuon.Location = new System.Drawing.Point(440, 68);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(145, 29);
            this.dtNgayMuon.TabIndex = 7;

            this.lblHenTra.AutoSize = true;
            this.lblHenTra.Location = new System.Drawing.Point(625, 72);
            this.lblHenTra.Name = "lblHenTra";
            this.lblHenTra.Size = new System.Drawing.Size(62, 21);
            this.lblHenTra.TabIndex = 8;
            this.lblHenTra.Text = "Hẹn trả:";

            this.dtHenTra.CustomFormat = "dd/MM/yyyy";
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHenTra.Location = new System.Drawing.Point(700, 68);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(145, 29);
            this.dtHenTra.TabIndex = 9;

            this.lblSachCon.AutoSize = true;
            this.lblSachCon.Location = new System.Drawing.Point(28, 125);
            this.lblSachCon.Name = "lblSachCon";
            this.lblSachCon.Size = new System.Drawing.Size(139, 21);
            this.lblSachCon.TabIndex = 10;
            this.lblSachCon.Text = "Sách còn trong kho:";

            this.dgvSachCon.AllowUserToAddRows = false;
            this.dgvSachCon.AllowUserToDeleteRows = false;
            this.dgvSachCon.AllowUserToResizeRows = false;
            this.dgvSachCon.AutoGenerateColumns = false;
            this.dgvSachCon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(220, 227, 233);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvSachCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachCon.ColumnHeadersHeight = 32;
            this.dgvSachCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvSachCon.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colSachConMa,
                    this.colSachConTen,
                    this.colSachConNam,
                    this.colSachConSL
                });

            this.dgvSachCon.EnableHeadersVisualStyles = false;
            this.dgvSachCon.Location = new System.Drawing.Point(28, 152);
            this.dgvSachCon.MultiSelect = false;
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.RowHeadersVisible = false;
            this.dgvSachCon.RowHeadersWidth = 51;
            this.dgvSachCon.RowTemplate.Height = 34;
            this.dgvSachCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachCon.Size = new System.Drawing.Size(470, 320);
            this.dgvSachCon.TabIndex = 11;

            this.colSachConMa.DataPropertyName = "MaDauSach";
            this.colSachConMa.HeaderText = "Mã";
            this.colSachConMa.Name = "colSachConMa";
            this.colSachConMa.ReadOnly = true;
            this.colSachConMa.Width = 100;

            this.colSachConTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSachConTen.DataPropertyName = "TenSach";
            this.colSachConTen.HeaderText = "Tên sách";
            this.colSachConTen.Name = "colSachConTen";
            this.colSachConTen.ReadOnly = true;

            this.colSachConNam.DataPropertyName = "NamXuatBan";
            this.colSachConNam.HeaderText = "Năm XB";
            this.colSachConNam.Name = "colSachConNam";
            this.colSachConNam.ReadOnly = true;
            this.colSachConNam.Width = 100;

            this.colSachConSL.DataPropertyName = "SoLuongHienCo";
            this.colSachConSL.HeaderText = "Còn";
            this.colSachConSL.Name = "colSachConSL";
            this.colSachConSL.ReadOnly = true;
            this.colSachConSL.Width = 80;

            this.btnThemSach.Location = new System.Drawing.Point(520, 220);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(95, 36);
            this.btnThemSach.TabIndex = 12;
            this.btnThemSach.Text = "Thêm >>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);

            this.btnBoSach.Location = new System.Drawing.Point(520, 270);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(95, 36);
            this.btnBoSach.TabIndex = 13;
            this.btnBoSach.Text = "<< Bỏ";
            this.btnBoSach.UseVisualStyleBackColor = true;
            this.btnBoSach.Click += new System.EventHandler(this.btnBoSach_Click);

            this.lblSachChon.AutoSize = true;
            this.lblSachChon.Location = new System.Drawing.Point(640, 125);
            this.lblSachChon.Name = "lblSachChon";
            this.lblSachChon.Size = new System.Drawing.Size(170, 21);
            this.lblSachChon.TabIndex = 14;
            this.lblSachChon.Text = "Sách đã chọn (tối đa 3):";

            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.AllowUserToResizeRows = false;
            this.dgvSachChon.AutoGenerateColumns = false;
            this.dgvSachChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(220, 227, 233);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvSachChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachChon.ColumnHeadersHeight = 32;
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvSachChon.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colSachChonMa,
                    this.colSachChonTen
                });

            this.dgvSachChon.EnableHeadersVisualStyles = false;
            this.dgvSachChon.Location = new System.Drawing.Point(640, 152);
            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersVisible = false;
            this.dgvSachChon.RowHeadersWidth = 51;
            this.dgvSachChon.RowTemplate.Height = 34;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(470, 240);
            this.dgvSachChon.TabIndex = 15;

            this.colSachChonMa.DataPropertyName = "MaDauSach";
            this.colSachChonMa.HeaderText = "Mã";
            this.colSachChonMa.Name = "colSachChonMa";
            this.colSachChonMa.ReadOnly = true;
            this.colSachChonMa.Width = 180;

            this.colSachChonTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSachChonTen.DataPropertyName = "TenSach";
            this.colSachChonTen.HeaderText = "Tên sách";
            this.colSachChonTen.Name = "colSachChonTen";
            this.colSachChonTen.ReadOnly = true;

            this.btnLapPhieu.Location = new System.Drawing.Point(815, 420);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(160, 38);
            this.btnLapPhieu.TabIndex = 16;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);

            this.tabTra.Controls.Add(this.lblDocGiaTra);
            this.tabTra.Controls.Add(this.cboDocGiaTra);
            this.tabTra.Controls.Add(this.btnTaiSachMuon);
            this.tabTra.Controls.Add(this.lblNhanVienTra);
            this.tabTra.Controls.Add(this.cboNhanVienTra);
            this.tabTra.Controls.Add(this.lblDangMuon);
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.lblNgayTra);
            this.tabTra.Controls.Add(this.dtNgayTra);
            this.tabTra.Controls.Add(this.lblTinhTrang);
            this.tabTra.Controls.Add(this.cboTinhTrang);
            this.tabTra.Controls.Add(this.lblPhiPhat);
            this.tabTra.Controls.Add(this.numPhiPhat);
            this.tabTra.Controls.Add(this.btnTraSach);
            this.tabTra.Controls.Add(this.btnDong);
            this.tabTra.Location = new System.Drawing.Point(4, 30);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1172, 656);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách";
            this.tabTra.UseVisualStyleBackColor = true;

            this.lblDocGiaTra.AutoSize = true;
            this.lblDocGiaTra.Location = new System.Drawing.Point(28, 30);
            this.lblDocGiaTra.Name = "lblDocGiaTra";
            this.lblDocGiaTra.Size = new System.Drawing.Size(61, 21);
            this.lblDocGiaTra.TabIndex = 0;
            this.lblDocGiaTra.Text = "Độc giả:";

            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(105, 26);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(250, 29);
            this.cboDocGiaTra.TabIndex = 1;
            this.cboDocGiaTra.SelectedIndexChanged += new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);

            this.btnTaiSachMuon.Location = new System.Drawing.Point(375, 23);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(190, 34);
            this.btnTaiSachMuon.TabIndex = 2;
            this.btnTaiSachMuon.Text = "Tải sách đang mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            this.btnTaiSachMuon.Click += new System.EventHandler(this.btnTaiSachMuon_Click);

            this.lblNhanVienTra.AutoSize = true;
            this.lblNhanVienTra.Location = new System.Drawing.Point(640, 30);
            this.lblNhanVienTra.Name = "lblNhanVienTra";
            this.lblNhanVienTra.Size = new System.Drawing.Size(80, 21);
            this.lblNhanVienTra.TabIndex = 3;
            this.lblNhanVienTra.Text = "Nhân viên:";

            this.cboNhanVienTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(735, 26);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(220, 29);
            this.cboNhanVienTra.TabIndex = 4;

            this.lblDangMuon.AutoSize = true;
            this.lblDangMuon.Location = new System.Drawing.Point(28, 90);
            this.lblDangMuon.Name = "lblDangMuon";
            this.lblDangMuon.Size = new System.Drawing.Size(120, 21);
            this.lblDangMuon.TabIndex = 5;
            this.lblDangMuon.Text = "Sách đang mượn:";

            this.dgvDangMuon.AllowUserToAddRows = false;
            this.dgvDangMuon.AllowUserToDeleteRows = false;
            this.dgvDangMuon.AllowUserToResizeRows = false;
            this.dgvDangMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDangMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(220, 227, 233);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvDangMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDangMuon.ColumnHeadersHeight = 32;
            this.dgvDangMuon.EnableHeadersVisualStyles = false;
            this.dgvDangMuon.Location = new System.Drawing.Point(28, 120);
            this.dgvDangMuon.MultiSelect = false;
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.RowHeadersVisible = false;
            this.dgvDangMuon.RowHeadersWidth = 51;
            this.dgvDangMuon.RowTemplate.Height = 34;
            this.dgvDangMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangMuon.Size = new System.Drawing.Size(1080, 300);
            this.dgvDangMuon.TabIndex = 6;

            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(28, 470);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(69, 21);
            this.lblNgayTra.TabIndex = 7;
            this.lblNgayTra.Text = "Ngày trả:";

            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(115, 466);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(150, 29);
            this.dtNgayTra.TabIndex = 8;

            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(320, 470);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(81, 21);
            this.lblTinhTrang.TabIndex = 9;
            this.lblTinhTrang.Text = "Tình trạng:";

            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(415, 466);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(220, 29);
            this.cboTinhTrang.TabIndex = 10;

            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Location = new System.Drawing.Point(690, 470);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(63, 21);
            this.lblPhiPhat.TabIndex = 11;
            this.lblPhiPhat.Text = "Phí phạt:";

            this.numPhiPhat.Location = new System.Drawing.Point(770, 466);
            this.numPhiPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(200, 29);
            this.numPhiPhat.TabIndex = 12;
            this.numPhiPhat.ThousandsSeparator = true;

            this.btnTraSach.Location = new System.Drawing.Point(760, 535);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(180, 40);
            this.btnTraSach.TabIndex = 13;
            this.btnTraSach.Text = "Xác nhận trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);

            this.btnDong.Location = new System.Drawing.Point(960, 535);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 40);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1210, 765);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.FrmMuonTra_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.tabs.ResumeLayout(false);

            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();

            this.tabTra.ResumeLayout(false);
            this.tabTra.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.TabPage tabTra;

        private System.Windows.Forms.Label lblDocGiaMuon;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTrangThai;

        private System.Windows.Forms.Label lblNhanVienMuon;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;

        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;

        private System.Windows.Forms.Label lblHenTra;
        private System.Windows.Forms.DateTimePicker dtHenTra;

        private System.Windows.Forms.Label lblSachCon;
        private System.Windows.Forms.DataGridView dgvSachCon;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSachConMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSachConTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSachConNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSachConSL;

        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnBoSach;

        private System.Windows.Forms.Label lblSachChon;
        private System.Windows.Forms.DataGridView dgvSachChon;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSachChonMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSachChonTen;

        private System.Windows.Forms.Button btnLapPhieu;

        private System.Windows.Forms.Label lblDocGiaTra;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.Button btnTaiSachMuon;

        private System.Windows.Forms.Label lblNhanVienTra;
        private System.Windows.Forms.ComboBox cboNhanVienTra;

        private System.Windows.Forms.Label lblDangMuon;
        private System.Windows.Forms.DataGridView dgvDangMuon;

        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;

        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;

        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.NumericUpDown numPhiPhat;

        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnDong;
    }
}