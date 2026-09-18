namespace QuanLyThuVien.Forms
{
    partial class FrmDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();

            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();

            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();

            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();

            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();

            this.lblPhai = new System.Windows.Forms.Label();
            this.cboPhai = new System.Windows.Forms.ComboBox();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();

            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();

            this.lblNgayCap = new System.Windows.Forms.Label();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();

            this.lblHan = new System.Windows.Forms.Label();
            this.dtHan = new System.Windows.Forms.DateTimePicker();

            this.chkLePhi = new System.Windows.Forms.CheckBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();

            this.dgvDocGia = new System.Windows.Forms.DataGridView();

            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanThe = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1190, 45);
            this.pnlHeader.TabIndex = 0;

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblHeader.Location = new System.Drawing.Point(15, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(174, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Độc giả và thẻ thư viện";

            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(45, 68);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(90, 21);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã độc giả:";

            this.txtMa.Location = new System.Drawing.Point(155, 64);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(245, 29);
            this.txtMa.TabIndex = 2;

            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(45, 113);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(31, 21);
            this.lblHo.TabIndex = 3;
            this.lblHo.Text = "Họ:";

            this.txtHo.Location = new System.Drawing.Point(155, 109);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(245, 29);
            this.txtHo.TabIndex = 4;

            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(45, 158);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(37, 21);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên:";

            this.txtTen.Location = new System.Drawing.Point(155, 154);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(245, 29);
            this.txtTen.TabIndex = 6;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(45, 203);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 21);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh:";

            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(155, 199);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(245, 29);
            this.dtNgaySinh.TabIndex = 8;

            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(45, 248);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(43, 21);
            this.lblPhai.TabIndex = 9;
            this.lblPhai.Text = "Phái:";

            this.cboPhai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Location = new System.Drawing.Point(155, 244);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(245, 29);
            this.cboPhai.TabIndex = 10;

            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(450, 68);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(84, 21);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Điện thoại:";

            this.txtSDT.Location = new System.Drawing.Point(570, 64);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(320, 29);
            this.txtSDT.TabIndex = 12;

            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(450, 113);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(62, 21);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa chỉ:";

            this.txtDiaChi.Location = new System.Drawing.Point(570, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(320, 29);
            this.txtDiaChi.TabIndex = 14;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(450, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 21);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(570, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 29);
            this.txtEmail.TabIndex = 16;

            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(450, 203);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(65, 21);
            this.lblAnh.TabIndex = 17;
            this.lblAnh.Text = "Ảnh 3x4:";

            this.txtAnh.Location = new System.Drawing.Point(570, 199);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(320, 29);
            this.txtAnh.TabIndex = 18;

            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(450, 263);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(78, 21);
            this.lblNgayCap.TabIndex = 19;
            this.lblNgayCap.Text = "Ngày cấp:";

            this.dtNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCap.Location = new System.Drawing.Point(570, 259);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(155, 29);
            this.dtNgayCap.TabIndex = 20;

            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Location = new System.Drawing.Point(760, 262);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(151, 25);
            this.chkLePhi.TabIndex = 21;
            this.chkLePhi.Text = "Đã đóng lệ phí";
            this.chkLePhi.UseVisualStyleBackColor = true;

            this.lblHan.AutoSize = true;
            this.lblHan.Location = new System.Drawing.Point(450, 308);
            this.lblHan.Name = "lblHan";
            this.lblHan.Size = new System.Drawing.Size(103, 21);
            this.lblHan.TabIndex = 22;
            this.lblHan.Text = "Hạn sử dụng:";

            this.dtHan.CustomFormat = "dd/MM/yyyy";
            this.dtHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHan.Location = new System.Drawing.Point(570, 304);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(155, 29);
            this.dtHan.TabIndex = 23;

            this.btnThem.Location = new System.Drawing.Point(930, 64);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 38);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click +=
                new System.EventHandler(this.btnThem_Click);

            this.btnCapNhat.Location = new System.Drawing.Point(930, 112);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 38);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click +=
                new System.EventHandler(this.btnCapNhat_Click);

            this.btnCapThe.Location = new System.Drawing.Point(760, 300);
            this.btnCapThe.Name = "btnCapThe";
            this.btnCapThe.Size = new System.Drawing.Size(130, 38);
            this.btnCapThe.TabIndex = 26;
            this.btnCapThe.Text = "Cấp thẻ";
            this.btnCapThe.UseVisualStyleBackColor = true;
            this.btnCapThe.Click +=
                new System.EventHandler(this.btnCapThe_Click);

            this.btnGiaHan.Location = new System.Drawing.Point(910, 300);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(130, 38);
            this.btnGiaHan.TabIndex = 27;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click +=
                new System.EventHandler(this.btnGiaHan_Click);

            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.AllowUserToResizeRows = false;
            this.dgvDocGia.AutoGenerateColumns = false;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(220, 227, 233);

            dataGridViewCellStyle1.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            dataGridViewCellStyle1.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvDocGia.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvDocGia.ColumnHeadersHeight = 32;

            this.dgvDocGia.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvDocGia.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMa,
                    this.colHo,
                    this.colTen,
                    this.colPhai,
                    this.colSDT,
                    this.colEmail,
                    this.colHanThe
                });

            this.dgvDocGia.EnableHeadersVisualStyles = false;
            this.dgvDocGia.Location = new System.Drawing.Point(45, 380);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersVisible = false;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 36;

            this.dgvDocGia.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDocGia.Size = new System.Drawing.Size(1090, 330);
            this.dgvDocGia.TabIndex = 28;

            this.dgvDocGia.SelectionChanged +=
                new System.EventHandler(
                    this.dgvDocGia_SelectionChanged);

            this.colMa.DataPropertyName = "MaDocGia";
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.Width = 145;

            this.colHo.DataPropertyName = "Ho";
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            this.colHo.ReadOnly = true;
            this.colHo.Width = 145;

            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 145;

            this.colPhai.DataPropertyName = "Phai";
            this.colPhai.HeaderText = "Phái";
            this.colPhai.Name = "colPhai";
            this.colPhai.ReadOnly = true;
            this.colPhai.Width = 145;

            this.colSDT.DataPropertyName = "SoDienThoai";
            this.colSDT.HeaderText = "Điện thoại";
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            this.colSDT.Width = 145;

            this.colEmail.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;

            this.colHanThe.DataPropertyName = "HanSuDung";
            this.colHanThe.HeaderText = "Hạn thẻ";
            this.colHanThe.Name = "colHanThe";
            this.colHanThe.ReadOnly = true;
            this.colHanThe.Width = 150;
            this.colHanThe.DefaultCellStyle.Format = "dd/MM/yyyy";

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 21F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            this.ClientSize =
                new System.Drawing.Size(1190, 760);

            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnCapThe);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtHan);
            this.Controls.Add(this.lblHan);
            this.Controls.Add(this.chkLePhi);
            this.Controls.Add(this.dtNgayCap);
            this.Controls.Add(this.lblNgayCap);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.cboPhai);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.pnlHeader);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.Name = "FrmDocGia";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "Độc giả và thẻ";

            this.Load +=
                new System.EventHandler(this.FrmDocGia_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDocGia)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;

        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;

        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.ComboBox cboPhai;

        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;

        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;

        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.DateTimePicker dtNgayCap;

        private System.Windows.Forms.Label lblHan;
        private System.Windows.Forms.DateTimePicker dtHan;

        private System.Windows.Forms.CheckBox chkLePhi;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnGiaHan;

        private System.Windows.Forms.DataGridView dgvDocGia;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanThe;
    }
}