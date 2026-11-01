namespace QuanLyThueVanPhong.Forms
{
    partial class FrmGiaHan
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
            this.btnXacNhanGiaHan = new System.Windows.Forms.Button();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.chkListPhongGiaHan = new System.Windows.Forms.CheckedListBox();
            this.lblPhongGiaHan = new System.Windows.Forms.Label();
            this.lblTrangThaiNoDV = new System.Windows.Forms.Label();
            this.lblNoDVTitle = new System.Windows.Forms.Label();
            this.lblTrangThaiNoThue = new System.Windows.Forms.Label();
            this.lblNoThueTitle = new System.Windows.Forms.Label();
            this.numThangGiaHan = new System.Windows.Forms.NumericUpDown();
            this.lblThangGiaHan = new System.Windows.Forms.Label();
            this.lblMaxGiaHan = new System.Windows.Forms.Label();
            this.lblMaxTitle = new System.Windows.Forms.Label();
            this.lblNgayHetHanHienTai = new System.Windows.Forms.Label();
            this.lblNgayHetHanTitle = new System.Windows.Forms.Label();
            this.lblThoiHanGoc = new System.Windows.Forms.Label();
            this.lblThoiHanGocTitle = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.dgvPhieuGiaHan = new System.Windows.Forms.DataGridView();
            this.lblDsPhieu = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangGiaHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(121)))), ((int)(((byte)(31)))));
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
            this.lblTitle.Text = "LẬP PHIẾU GIA HẠN THUÊ VĂN PHÒNG (KIỂM TRA ĐIỀU KIỆN SẠCH NỢ - CÂU 6)";
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.btnXacNhanGiaHan);
            this.grpNhapLieu.Controls.Add(this.txtLyDo);
            this.grpNhapLieu.Controls.Add(this.lblLyDo);
            this.grpNhapLieu.Controls.Add(this.chkListPhongGiaHan);
            this.grpNhapLieu.Controls.Add(this.lblPhongGiaHan);
            this.grpNhapLieu.Controls.Add(this.lblTrangThaiNoDV);
            this.grpNhapLieu.Controls.Add(this.lblNoDVTitle);
            this.grpNhapLieu.Controls.Add(this.lblTrangThaiNoThue);
            this.grpNhapLieu.Controls.Add(this.lblNoThueTitle);
            this.grpNhapLieu.Controls.Add(this.numThangGiaHan);
            this.grpNhapLieu.Controls.Add(this.lblThangGiaHan);
            this.grpNhapLieu.Controls.Add(this.lblMaxGiaHan);
            this.grpNhapLieu.Controls.Add(this.lblMaxTitle);
            this.grpNhapLieu.Controls.Add(this.lblNgayHetHanHienTai);
            this.grpNhapLieu.Controls.Add(this.lblNgayHetHanTitle);
            this.grpNhapLieu.Controls.Add(this.lblThoiHanGoc);
            this.grpNhapLieu.Controls.Add(this.lblThoiHanGocTitle);
            this.grpNhapLieu.Controls.Add(this.cboHopDong);
            this.grpNhapLieu.Controls.Add(this.lblHopDong);
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNhapLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpNhapLieu.Location = new System.Drawing.Point(18, 65);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(948, 235);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thẩm Định Điều Kiện Gia Hạn Thuê Văn Phòng";
            // 
            // btnXacNhanGiaHan
            // 
            this.btnXacNhanGiaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(121)))), ((int)(((byte)(31)))));
            this.btnXacNhanGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanGiaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanGiaHan.Location = new System.Drawing.Point(620, 175);
            this.btnXacNhanGiaHan.Name = "btnXacNhanGiaHan";
            this.btnXacNhanGiaHan.Size = new System.Drawing.Size(305, 45);
            this.btnXacNhanGiaHan.TabIndex = 18;
            this.btnXacNhanGiaHan.Text = "THẨM ĐỊNH && LẬP PHIẾU GIA HẠN";
            this.btnXacNhanGiaHan.UseVisualStyleBackColor = false;
            this.btnXacNhanGiaHan.Click += new System.EventHandler(this.btnXacNhanGiaHan_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLyDo.Location = new System.Drawing.Point(620, 138);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(305, 24);
            this.txtLyDo.TabIndex = 17;
            this.txtLyDo.Text = "Mở rộng kinh doanh";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLyDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblLyDo.Location = new System.Drawing.Point(525, 142);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(84, 15);
            this.lblLyDo.TabIndex = 16;
            this.lblLyDo.Text = "Lý do gia hạn:";
            // 
            // chkListPhongGiaHan
            // 
            this.chkListPhongGiaHan.CheckOnClick = true;
            this.chkListPhongGiaHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkListPhongGiaHan.FormattingEnabled = true;
            this.chkListPhongGiaHan.Location = new System.Drawing.Point(620, 25);
            this.chkListPhongGiaHan.Name = "chkListPhongGiaHan";
            this.chkListPhongGiaHan.Size = new System.Drawing.Size(305, 94);
            this.chkListPhongGiaHan.TabIndex = 15;
            // 
            // lblPhongGiaHan
            // 
            this.lblPhongGiaHan.AutoSize = true;
            this.lblPhongGiaHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhongGiaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblPhongGiaHan.Location = new System.Drawing.Point(525, 30);
            this.lblPhongGiaHan.Name = "lblPhongGiaHan";
            this.lblPhongGiaHan.Size = new System.Drawing.Size(89, 30);
            this.lblPhongGiaHan.TabIndex = 14;
            this.lblPhongGiaHan.Text = "Phòng gia hạn:\n(Chọn phòng)";
            // 
            // lblTrangThaiNoDV
            // 
            this.lblTrangThaiNoDV.AutoSize = true;
            this.lblTrangThaiNoDV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiNoDV.Location = new System.Drawing.Point(170, 195);
            this.lblTrangThaiNoDV.Name = "lblTrangThaiNoDV";
            this.lblTrangThaiNoDV.Size = new System.Drawing.Size(69, 17);
            this.lblTrangThaiNoDV.TabIndex = 13;
            this.lblTrangThaiNoDV.Text = "Kiểm tra...";
            // 
            // lblNoDVTitle
            // 
            this.lblNoDVTitle.AutoSize = true;
            this.lblNoDVTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoDVTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblNoDVTitle.Location = new System.Drawing.Point(20, 196);
            this.lblNoDVTitle.Name = "lblNoDVTitle";
            this.lblNoDVTitle.Size = new System.Drawing.Size(127, 15);
            this.lblNoDVTitle.TabIndex = 12;
            this.lblNoDVTitle.Text = "Công nợ dịch vụ (điện/nước):";
            // 
            // lblTrangThaiNoThue
            // 
            this.lblTrangThaiNoThue.AutoSize = true;
            this.lblTrangThaiNoThue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiNoThue.Location = new System.Drawing.Point(170, 165);
            this.lblTrangThaiNoThue.Name = "lblTrangThaiNoThue";
            this.lblTrangThaiNoThue.Size = new System.Drawing.Size(69, 17);
            this.lblTrangThaiNoThue.TabIndex = 11;
            this.lblTrangThaiNoThue.Text = "Kiểm tra...";
            // 
            // lblNoThueTitle
            // 
            this.lblNoThueTitle.AutoSize = true;
            this.lblNoThueTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoThueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblNoThueTitle.Location = new System.Drawing.Point(20, 166);
            this.lblNoThueTitle.Name = "lblNoThueTitle";
            this.lblNoThueTitle.Size = new System.Drawing.Size(134, 15);
            this.lblNoThueTitle.TabIndex = 10;
            this.lblNoThueTitle.Text = "Công nợ tiền thuê phòng:";
            // 
            // numThangGiaHan
            // 
            this.numThangGiaHan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numThangGiaHan.Location = new System.Drawing.Point(170, 125);
            this.numThangGiaHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThangGiaHan.Name = "numThangGiaHan";
            this.numThangGiaHan.Size = new System.Drawing.Size(100, 24);
            this.numThangGiaHan.TabIndex = 9;
            this.numThangGiaHan.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblThangGiaHan
            // 
            this.lblThangGiaHan.AutoSize = true;
            this.lblThangGiaHan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThangGiaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(121)))), ((int)(((byte)(31)))));
            this.lblThangGiaHan.Location = new System.Drawing.Point(20, 128);
            this.lblThangGiaHan.Name = "lblThangGiaHan";
            this.lblThangGiaHan.Size = new System.Drawing.Size(127, 15);
            this.lblThangGiaHan.TabIndex = 8;
            this.lblThangGiaHan.Text = "Số tháng xin gia hạn:";
            // 
            // lblMaxGiaHan
            // 
            this.lblMaxGiaHan.AutoSize = true;
            this.lblMaxGiaHan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaxGiaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMaxGiaHan.Location = new System.Drawing.Point(170, 95);
            this.lblMaxGiaHan.Name = "lblMaxGiaHan";
            this.lblMaxGiaHan.Size = new System.Drawing.Size(53, 17);
            this.lblMaxGiaHan.TabIndex = 7;
            this.lblMaxGiaHan.Text = "0 tháng";
            // 
            // lblMaxTitle
            // 
            this.lblMaxTitle.AutoSize = true;
            this.lblMaxTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblMaxTitle.Location = new System.Drawing.Point(20, 96);
            this.lblMaxTitle.Name = "lblMaxTitle";
            this.lblMaxTitle.Size = new System.Drawing.Size(147, 15);
            this.lblMaxTitle.TabIndex = 6;
            this.lblMaxTitle.Text = "Thời gian gia hạn tối đa:";
            // 
            // lblNgayHetHanHienTai
            // 
            this.lblNgayHetHanHienTai.AutoSize = true;
            this.lblNgayHetHanHienTai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayHetHanHienTai.Location = new System.Drawing.Point(380, 65);
            this.lblNgayHetHanHienTai.Name = "lblNgayHetHanHienTai";
            this.lblNgayHetHanHienTai.Size = new System.Drawing.Size(68, 17);
            this.lblNgayHetHanHienTai.TabIndex = 5;
            this.lblNgayHetHanHienTai.Text = "01/01/2026";
            // 
            // lblNgayHetHanTitle
            // 
            this.lblNgayHetHanTitle.AutoSize = true;
            this.lblNgayHetHanTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayHetHanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblNgayHetHanTitle.Location = new System.Drawing.Point(265, 66);
            this.lblNgayHetHanTitle.Name = "lblNgayHetHanTitle";
            this.lblNgayHetHanTitle.Size = new System.Drawing.Size(110, 15);
            this.lblNgayHetHanTitle.TabIndex = 4;
            this.lblNgayHetHanTitle.Text = "Hết hạn HĐ hiện tại:";
            // 
            // lblThoiHanGoc
            // 
            this.lblThoiHanGoc.AutoSize = true;
            this.lblThoiHanGoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThoiHanGoc.Location = new System.Drawing.Point(170, 65);
            this.lblThoiHanGoc.Name = "lblThoiHanGoc";
            this.lblThoiHanGoc.Size = new System.Drawing.Size(53, 17);
            this.lblThoiHanGoc.TabIndex = 3;
            this.lblThoiHanGoc.Text = "0 tháng";
            // 
            // lblThoiHanGocTitle
            // 
            this.lblThoiHanGocTitle.AutoSize = true;
            this.lblThoiHanGocTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThoiHanGocTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblThoiHanGocTitle.Location = new System.Drawing.Point(20, 66);
            this.lblThoiHanGocTitle.Name = "lblThoiHanGocTitle";
            this.lblThoiHanGocTitle.Size = new System.Drawing.Size(111, 15);
            this.lblThoiHanGocTitle.TabIndex = 2;
            this.lblThoiHanGocTitle.Text = "Thời hạn thuê gốc:";
            // 
            // cboHopDong
            // 
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHopDong.FormattingEnabled = true;
            this.cboHopDong.Location = new System.Drawing.Point(170, 26);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(320, 25);
            this.cboHopDong.TabIndex = 1;
            this.cboHopDong.SelectedIndexChanged += new System.EventHandler(this.cboHopDong_SelectedIndexChanged);
            // 
            // lblHopDong
            // 
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblHopDong.Location = new System.Drawing.Point(20, 30);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.Size = new System.Drawing.Size(126, 15);
            this.lblHopDong.TabIndex = 0;
            this.lblHopDong.Text = "Chọn hợp đồng thuê:";
            // 
            // dgvPhieuGiaHan
            // 
            this.dgvPhieuGiaHan.AllowUserToAddRows = false;
            this.dgvPhieuGiaHan.AllowUserToDeleteRows = false;
            this.dgvPhieuGiaHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuGiaHan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuGiaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGiaHan.Location = new System.Drawing.Point(18, 335);
            this.dgvPhieuGiaHan.Name = "dgvPhieuGiaHan";
            this.dgvPhieuGiaHan.ReadOnly = true;
            this.dgvPhieuGiaHan.RowHeadersWidth = 25;
            this.dgvPhieuGiaHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuGiaHan.Size = new System.Drawing.Size(948, 180);
            this.dgvPhieuGiaHan.TabIndex = 2;
            // 
            // lblDsPhieu
            // 
            this.lblDsPhieu.AutoSize = true;
            this.lblDsPhieu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDsPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblDsPhieu.Location = new System.Drawing.Point(18, 310);
            this.lblDsPhieu.Name = "lblDsPhieu";
            this.lblDsPhieu.Size = new System.Drawing.Size(256, 19);
            this.lblDsPhieu.TabIndex = 3;
            this.lblDsPhieu.Text = "Danh Sách Phiếu Gia Hạn Đã Phát Hành";
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
            // FrmGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblDsPhieu);
            this.Controls.Add(this.dgvPhieuGiaHan);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiaHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Phiếu Gia Hạn Hợp Đồng";
            this.Load += new System.EventHandler(this.FrmGiaHan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangGiaHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.Label lblThoiHanGocTitle;
        private System.Windows.Forms.Label lblThoiHanGoc;
        private System.Windows.Forms.Label lblNgayHetHanTitle;
        private System.Windows.Forms.Label lblNgayHetHanHienTai;
        private System.Windows.Forms.Label lblMaxTitle;
        private System.Windows.Forms.Label lblMaxGiaHan;
        private System.Windows.Forms.Label lblThangGiaHan;
        private System.Windows.Forms.NumericUpDown numThangGiaHan;
        private System.Windows.Forms.Label lblNoThueTitle;
        private System.Windows.Forms.Label lblTrangThaiNoThue;
        private System.Windows.Forms.Label lblNoDVTitle;
        private System.Windows.Forms.Label lblTrangThaiNoDV;
        private System.Windows.Forms.Label lblPhongGiaHan;
        private System.Windows.Forms.CheckedListBox chkListPhongGiaHan;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnXacNhanGiaHan;
        private System.Windows.Forms.DataGridView dgvPhieuGiaHan;
        private System.Windows.Forms.Label lblDsPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}
