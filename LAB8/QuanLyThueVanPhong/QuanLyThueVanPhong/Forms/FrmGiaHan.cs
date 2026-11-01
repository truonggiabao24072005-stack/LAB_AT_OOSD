using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Data;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmGiaHan : Form
    {
        private readonly CaoOcService _service;

        public FrmGiaHan()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmGiaHan_Load(object sender, EventArgs e)
        {
            LoadDanhSachHopDong();
            LoadDanhSachPhieuGiaHan();
        }

        private void LoadDanhSachHopDong()
        {
            cboHopDong.Items.Clear();
            var dsHD = _service.LayDanhSachHopDong();
            foreach (var h in dsHD)
            {
                cboHopDong.Items.Add($"{h.MaHD} - {h.SoHopDong} ({h.MaKH}, Thời hạn gốc: {h.ThoiHanThue} tháng)");
            }
            if (cboHopDong.Items.Count > 0) cboHopDong.SelectedIndex = 0;
        }

        private void LoadDanhSachPhieuGiaHan()
        {
            var dsPGH = DbContext.Instance.PhieuGiaHans.ToList();
            dgvPhieuGiaHan.DataSource = dsPGH.Select(p => new
            {
                Mã_Phiếu = p.MaPhieuGH,
                Số_Phiếu = p.SoPhieu,
                Mã_Hợp_Đồng = p.MaHD,
                Số_Tháng_Gia_Hạn = p.ThoiGianGiaHan,
                Ngày_Bắt_Đầu_GH = p.NgayBatDauGH.ToString("dd/MM/yyyy"),
                Ngày_Hết_Hạn_Mới = p.NgayKetThucGH.ToString("dd/MM/yyyy"),
                Trạng_Thái = p.TrangThaiDuyet,
                Người_Lập = p.NguoiLap
            }).ToList();
        }

        private void cboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHopDong.SelectedIndex < 0) return;
            string maHD = cboHopDong.SelectedItem.ToString().Split(' ')[0];
            var hd = DbContext.Instance.HopDongThues.FirstOrDefault(h => h.MaHD == maHD);
            if (hd == null) return;

            int maxThang = hd.ThoiHanThue / 2;
            lblThoiHanGoc.Text = $"{hd.ThoiHanThue} tháng";
            lblMaxGiaHan.Text = $"{maxThang} tháng (<= 1/2 HĐ gốc)";
            lblNgayHetHanHienTai.Text = hd.NgayKetThuc.ToString("dd/MM/yyyy");
            numThangGiaHan.Maximum = 60;
            numThangGiaHan.Value = Math.Min(maxThang, 3);

            // Kiểm tra công nợ tiền thuê
            var noThue = DbContext.Instance.HoaDonTienThues
                .Where(h => h.MaHD == maHD && h.TrangThai == "Chưa thanh toán").ToList();
            decimal tongNoThue = noThue.Sum(h => h.SoTienThue);

            // Kiểm tra công nợ dịch vụ
            var noDV = DbContext.Instance.HoaDonDichVus
                .Where(d => d.MaHD == maHD && d.TrangThai == "Chưa thanh toán").ToList();
            decimal tongNoDV = noDV.Sum(d => d.TongTien);

            if (tongNoThue == 0)
            {
                lblTrangThaiNoThue.Text = "SẠCH NỢ (Đã thanh toán đủ)";
                lblTrangThaiNoThue.ForeColor = Color.FromArgb(47, 133, 90);
            }
            else
            {
                lblTrangThaiNoThue.Text = $"CÒN NỢ: {tongNoThue:N0} VNĐ ({noThue.Count} hóa đơn)";
                lblTrangThaiNoThue.ForeColor = Color.FromArgb(229, 62, 62);
            }

            if (tongNoDV == 0)
            {
                lblTrangThaiNoDV.Text = "SẠCH NỢ (Đã thanh toán đủ)";
                lblTrangThaiNoDV.ForeColor = Color.FromArgb(47, 133, 90);
            }
            else
            {
                lblTrangThaiNoDV.Text = $"CÒN NỢ: {tongNoDV:N0} VNĐ ({noDV.Count} hóa đơn)";
                lblTrangThaiNoDV.ForeColor = Color.FromArgb(229, 62, 62);
            }

            // Load các phòng thuộc hợp đồng này
            chkListPhongGiaHan.Items.Clear();
            var cthdList = DbContext.Instance.ChiTietHopDongs.Where(c => c.MaHD == maHD).ToList();
            foreach (var c in cthdList)
            {
                chkListPhongGiaHan.Items.Add(c.MaPhong, true);
            }
        }

        private void btnXacNhanGiaHan_Click(object sender, EventArgs e)
        {
            if (cboHopDong.SelectedIndex < 0) return;
            string maHD = cboHopDong.SelectedItem.ToString().Split(' ')[0];
            int soThang = (int)numThangGiaHan.Value;

            var dsPhong = new List<string>();
            for (int i = 0; i < chkListPhongGiaHan.Items.Count; i++)
            {
                if (chkListPhongGiaHan.GetItemChecked(i))
                    dsPhong.Add(chkListPhongGiaHan.Items[i].ToString());
            }

            string lyDo = txtLyDo.Text.Trim();
            string nguoiLap = "Trương Gia Bảo (BQL)";

            var res = _service.LapPhieuGiaHan(maHD, soThang, dsPhong, lyDo, nguoiLap);

            if (res.Success)
            {
                MessageBox.Show(res.Message, "Thẩm Định Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhieuGiaHan();
                cboHopDong_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show(res.Message, "Từ Chối Gia Hạn Theo Quy Định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
