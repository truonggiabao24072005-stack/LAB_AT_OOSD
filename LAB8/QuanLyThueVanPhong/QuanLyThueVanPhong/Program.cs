using System;
using System.Globalization;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using QuanLyThueVanPhong.Forms;

namespace QuanLyThueVanPhong
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("vi-VN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}

namespace QuanLyThueVanPhong
{
    // Shared presentation rules, following the BusinessForm style used in LAB7.
    internal static class FormAppearance
    {
        private static readonly Color Heading = Color.FromArgb(25, 66, 105);
        internal static void Apply(Form form)
        {
            form.SuspendLayout();
            Size original = form.ClientSize;
            form.AutoScaleMode = AutoScaleMode.Dpi;
            form.AutoScaleDimensions = new SizeF(96F, 96F);
            form.Font = new Font("Segoe UI", 10F);
            form.BackColor = Color.FromArgb(244, 246, 249);
            float sx = 1120F / original.Width, sy = 740F / original.Height;
            ResizeAndStyle(form, sx, sy);
            form.ClientSize = new Size(1120, 740);
            form.MinimumSize = form.Size;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.MaximizeBox = true;
            var titles = new Dictionary<string, string> {
                {"FrmMain", "Quản lý cho thuê văn phòng"},
                {"FrmPhongTang", "Tầng, phòng và giá thuê"},
                {"FrmHopDongThue", "Lập hợp đồng thuê văn phòng"},
                {"FrmGiaHan", "Gia hạn hợp đồng thuê"},
                {"FrmThanhToan", "Thu tiền thuê và dịch vụ"},
                {"FrmNhanVienTheXe", "Nhân viên văn phòng và thẻ xe"},
                {"FrmKiemTraViPham", "Kiểm tra phòng và xử lý vi phạm"}
            };
            string title;
            if (titles.TryGetValue(form.GetType().Name, out title)) {
                form.Text = title;
                var header = Find(form, "lblTitle") as Label;
                if (header != null) {
                    header.Text = title;
                    header.AutoSize = false;
                    header.Dock = DockStyle.Fill;
                    header.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
                    header.ForeColor = Heading;
                    header.Padding = new Padding(18, 8, 12, 0);
                    header.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            SetText(form, "btnTaoHopDong", "Lập hợp đồng và thu 6 tháng đầu");
            SetText(form, "btnXacNhanGiaHan", "Kiểm tra và lập phiếu gia hạn");
            SetText(form, "btnThemNV", "Tiếp nhận nhân viên");
            SetText(form, "btnCapTheXe", "Cấp thẻ giữ xe");
            SetText(form, "btnLapBienBanVP", "Lập biên bản xử phạt");
            SetText(form, "btnNopPhat", "Xác nhận nộp phạt và khắc phục");
            SetText(form, "btnXacNhanTienThue", "Xác nhận thu tiền thuê");
            SetText(form, "btnXacNhanDichVu", "Xác nhận thu tiền dịch vụ");
            SetText(form, "btnTaoHoaDonThangMoi", "Lập hóa đơn tiền thuê");
            SetText(form, "btnTaoHoaDonDV", "Lập hóa đơn dịch vụ");
            SetText(form, "tabTienThue", "Tiền thuê văn phòng");
            SetText(form, "tabDichVu", "Dịch vụ cuối tháng");
            SetText(form, "tabDinhKy", "Kiểm tra định kỳ");
            SetText(form, "tabXuPhat", "Xử lý vi phạm");
            SetText(form, "grpMenu", "Chức năng quản lý");
            SetText(form, "lblFooter", "Quản lý cho thuê văn phòng • LAB8");
            if (form.GetType().Name == "FrmMain") {
                SetText(form, "lblSubTitle", "Mặt bằng • Hợp đồng • Công nợ • Nhân viên • Kiểm tra phòng");
                var subtitle = Find(form, "lblSubTitle");
                if (subtitle != null) subtitle.BringToFront();
                var header = Find(form, "lblTitle");
                if (header != null) { header.Dock = DockStyle.None; header.SetBounds(18, 8, 1060, 48); header.Padding = Padding.Empty; }
                var menu = Find(form, "grpMenu");
                string[] names = {"btnPhongTang", "btnHopDongThue", "btnGiaHan", "btnThanhToan", "btnNhanVienTheXe", "btnKiemTraViPham"};
                string[] labels = {"Tầng, phòng và giá thuê", "Lập hợp đồng thuê", "Gia hạn hợp đồng", "Thu tiền thuê và dịch vụ", "Nhân viên và thẻ xe", "Kiểm tra và xử lý vi phạm"};
                if (menu != null) {
                    for (int i = 0; i < names.Length; i++) {
                        var button = Find(form, names[i]);
                        if (button == null) continue;
                        button.Text = labels[i];
                        button.Font = new Font("Segoe UI", 12F);
                        button.SetBounds(20 + (i % 2) * 520, 30 + (i / 2) * 86, 498, 68);
                    }
                    var exit = Find(form, "btnThoat");
                    if (exit != null) exit.SetBounds((menu.Width - 200) / 2, 292, 200, 36);
                }
            }
            form.ResumeLayout(true);
        }
        private static void ResizeAndStyle(Control parent, float sx, float sy)
        {
            foreach (Control c in parent.Controls) {
                Rectangle b = c.Bounds;
                ResizeAndStyle(c, sx, sy);
                c.Font = new Font("Segoe UI", 10F, c.Font.Style);
                if (c is Label) {
                    var label = (Label)c;
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                }
                if (!(c is TabPage)) c.SetBounds((int)(b.X * sx), (int)(b.Y * sy), (int)(b.Width * sx), Math.Max((int)(b.Height * sy), c is Label ? 24 : 0));
                if (c is Panel && (c.Name == "pnlTop" || c.Name == "pnlHeader")) c.BackColor = Color.FromArgb(244, 246, 249);
                if (c is GroupBox) { c.ForeColor = Heading; c.BackColor = Color.White; }
                else if (c is TextBoxBase || c is ComboBox || c is ListControl || c is TabPage) { c.ForeColor = Color.FromArgb(35, 43, 52); c.BackColor = Color.White; }
                else if (c is Button) {
                    var button = (Button)c;
                    button.BackColor = Color.White;
                    button.ForeColor = Heading;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 214);
                    button.UseVisualStyleBackColor = false;
                    button.Padding = new Padding(6, 0, 6, 0);
                }
                var list = c as CheckedListBox;
                if (list != null) { list.HorizontalScrollbar = true; list.IntegralHeight = false; }
                var grid = c as DataGridView;
                if (grid != null) {
                    grid.Font = new Font("Segoe UI", 10F);
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    grid.RowHeadersVisible = false;
                    grid.BackgroundColor = Color.White;
                    grid.BorderStyle = BorderStyle.FixedSingle;
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 238, 245);
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Heading;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    grid.RowTemplate.Height = 32;
                    grid.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);
                    grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 232, 246);
                    grid.DefaultCellStyle.SelectionForeColor = Color.Black;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
                    grid.DataBindingComplete += (s, e) => {
                        foreach (DataGridViewColumn column in grid.Columns) column.HeaderText = column.HeaderText.Replace('_', ' ');
                    };
                }
                if (c.Parent is Form) {
                    if (c is DataGridView && c.Width < 800) c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | (c.Left < 500 ? AnchorStyles.Left : AnchorStyles.Right);
                    else if (c is DataGridView || c is TabControl) c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    else if (c.Name == "grpTinhGia") c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    else if (c is GroupBox && c.Width < 800 && c.Left > 500) c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    else if (c is GroupBox && c.Width > 800) c.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    else if (c is Button && c.Name == "btnDong") c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                }
            }
        }
        private static Control Find(Control parent, string name)
        {
            var result = parent.Controls.Find(name, true);
            return result.Length == 0 ? null : result[0];
        }
        private static void SetText(Form form, string name, string text)
        {
            var control = Find(form, name);
            if (control != null) control.Text = text;
        }
    }
}

