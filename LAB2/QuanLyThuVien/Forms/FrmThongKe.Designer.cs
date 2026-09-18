namespace QuanLyThuVien.Forms
{
    partial class FrmThongKe
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

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();

            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();

            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();

            this.btnThongKe = new System.Windows.Forms.Button();

            this.lblMuon = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblPhiPhat = new System.Windows.Forms.Label();

            this.lblChiTiet = new System.Windows.Forms.Label();

            this.dgvPhat = new System.Windows.Forms.DataGridView();

            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 45);
            this.pnlHeader.TabIndex = 0;

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblHeader.Location = new System.Drawing.Point(15, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(131, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thống kê thư viện";

            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(40, 78);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(65, 21);
            this.lblTu.TabIndex = 1;
            this.lblTu.Text = "Từ ngày:";

            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Location = new System.Drawing.Point(125, 74);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(145, 29);
            this.dtTu.TabIndex = 2;

            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(315, 78);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(75, 21);
            this.lblDen.TabIndex = 3;
            this.lblDen.Text = "Đến ngày:";

            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Location = new System.Drawing.Point(405, 74);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(145, 29);
            this.dtDen.TabIndex = 4;

            this.btnThongKe.Location = new System.Drawing.Point(590, 71);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(125, 34);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            this.lblMuon.AutoSize = true;
            this.lblMuon.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblMuon.Location = new System.Drawing.Point(50, 135);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(166, 25);
            this.lblMuon.TabIndex = 6;
            this.lblMuon.Text = "Lượt sách mượn: 0";

            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblQuaHan.Location = new System.Drawing.Point(460, 135);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(137, 25);
            this.lblQuaHan.TabIndex = 7;
            this.lblQuaHan.Text = "Sách quá hạn: 0";

            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblMat.Location = new System.Drawing.Point(50, 180);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(102, 25);
            this.lblMat.TabIndex = 8;
            this.lblMat.Text = "Sách mất: 0";

            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblHuHong.Location = new System.Drawing.Point(460, 180);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(143, 25);
            this.lblHuHong.TabIndex = 9;
            this.lblHuHong.Text = "Sách hư hỏng: 0";

            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblPhiPhat.Location = new System.Drawing.Point(50, 225);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(216, 32);
            this.lblPhiPhat.TabIndex = 10;
            this.lblPhiPhat.Text = "Tổng phí phạt: 0 đ";

            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lblChiTiet.Location = new System.Drawing.Point(45, 295);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(152, 21);
            this.lblChiTiet.TabIndex = 11;
            this.lblChiTiet.Text = "Chi tiết phiếu phạt:";

            this.dgvPhat.AllowUserToAddRows = false;
            this.dgvPhat.AllowUserToDeleteRows = false;
            this.dgvPhat.AllowUserToResizeRows = false;
            this.dgvPhat.AutoGenerateColumns = false;
            this.dgvPhat.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPhat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(220, 227, 233);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhat.ColumnHeadersHeight = 34;
            this.dgvPhat.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvPhat.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMaPhieu,
                    this.colNgay,
                    this.colDocGia,
                    this.colMaSach,
                    this.colLyDo,
                    this.colPhiPhat
                });

            this.dgvPhat.EnableHeadersVisualStyles = false;
            this.dgvPhat.Location = new System.Drawing.Point(45, 325);
            this.dgvPhat.MultiSelect = false;
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.ReadOnly = true;
            this.dgvPhat.RowHeadersVisible = false;
            this.dgvPhat.RowHeadersWidth = 51;
            this.dgvPhat.RowTemplate.Height = 36;
            this.dgvPhat.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvPhat.Size = new System.Drawing.Size(980, 300);
            this.dgvPhat.TabIndex = 12;

            this.colMaPhieu.DataPropertyName = "MaPhieuPhat";
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            this.colMaPhieu.Width = 160;

            this.colNgay.DataPropertyName = "NgayPhat";
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;
            this.colNgay.Width = 150;

            this.colNgay.DefaultCellStyle.Format = "dd/MM/yyyy";

            this.colDocGia.DataPropertyName = "MaDocGia";
            this.colDocGia.HeaderText = "Độc giả";
            this.colDocGia.Name = "colDocGia";
            this.colDocGia.ReadOnly = true;
            this.colDocGia.Width = 160;

            this.colMaSach.DataPropertyName = "MaDauSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Width = 160;

            this.colLyDo.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLyDo.DataPropertyName = "LyDo";
            this.colLyDo.HeaderText = "Lý do";
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.ReadOnly = true;

            this.colPhiPhat.DataPropertyName = "PhiPhat";
            this.colPhiPhat.HeaderText = "Phí phạt";
            this.colPhiPhat.Name = "colPhiPhat";
            this.colPhiPhat.ReadOnly = true;
            this.colPhiPhat.Width = 160;

            this.colPhiPhat.DefaultCellStyle.Format = "N0";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.ClientSize = new System.Drawing.Size(1070, 670);

            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblPhiPhat);
            this.Controls.Add(this.lblHuHong);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblQuaHan);
            this.Controls.Add(this.lblMuon);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.pnlHeader);

            this.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "Thống kê";

            this.Load +=
                new System.EventHandler(this.FrmThongKe_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;

        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;

        private System.Windows.Forms.Button btnThongKe;

        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;

        private System.Windows.Forms.Label lblChiTiet;

        private System.Windows.Forms.DataGridView dgvPhat;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiPhat;
    }
}