using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmThanhToan : Form
    {
        private readonly CaoOcService _service;

        public FrmThanhToan()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDonTienThue();
            LoadDanhSachHoaDonDichVu();
            LoadHopDongChoTaoHoaDon();
        }

        private void LoadHopDongChoTaoHoaDon()
        {
            cboHopDongThue.Items.Clear();
            cboHopDongDV.Items.Clear();
            var dsHD = _service.LayDanhSachHopDong();
            foreach (var h in dsHD)
            {
                string text = $"{h.MaHD} - {h.SoHopDong} ({h.MaKH})";
                cboHopDongThue.Items.Add(text);
                cboHopDongDV.Items.Add(text);
            }
            if (cboHopDongThue.Items.Count > 0) cboHopDongThue.SelectedIndex = 0;
            if (cboHopDongDV.Items.Count > 0) cboHopDongDV.SelectedIndex = 0;

            cboThangThue.SelectedIndex = DateTime.Now.Month - 1;
            cboThangDV.SelectedIndex = DateTime.Now.Month - 1;
            txtNamThue.Text = DateTime.Now.Year.ToString();
            txtNamDV.Text = DateTime.Now.Year.ToString();
        }

        private void LoadDanhSachHoaDonTienThue()
        {
            var ds = _service.LayDanhSachHoaDonTienThue();
            dgvTienThue.DataSource = ds.Select(h => new
            {
                Mã_HĐ_Thuê = h.MaHDTienThue,
                Mã_Hợp_Đồng = h.MaHD,
                Kỳ_Thanh_Toán = h.KyThanhToan,
                Số_Tiền = $"{h.SoTienThue:N0} VNĐ",
                Hạn_Nộp = h.HanNopTien.ToString("dd/MM/yyyy"),
                Ngày_Nộp = h.NgayThanhToan?.ToString("dd/MM/yyyy") ?? "Chưa nộp",
                Hình_Thức = h.HinhThucThanhToan ?? "-",
                Trạng_Thái = h.TrangThai
            }).ToList();
        }

        private void LoadDanhSachHoaDonDichVu()
        {
            var ds = _service.LayDanhSachHoaDonDichVu();
            dgvDichVu.DataSource = ds.Select(d => new
            {
                Mã_HĐ_Dịch_Vụ = d.MaHDDV,
                Mã_Hợp_Đồng = d.MaHD,
                Phòng = d.MaPhong,
                Kỳ = $"{d.Thang:D2}/{d.Nam}",
                Tiền_Điện = $"{d.TienDien:N0}",
                Tiền_Nước = $"{d.TienNuoc:N0}",
                Tiền_Internet = $"{d.TienInternet:N0}",
                Tổng_Tiền_DV = $"{d.TongTien:N0} VNĐ",
                Hạn_Nộp = d.HanThanhToan.ToString("dd/MM/yyyy"),
                Ngày_Nộp = d.NgayThanhToan?.ToString("dd/MM/yyyy") ?? "Chưa nộp",
                Trạng_Thái = d.TrangThai
            }).ToList();
        }

        private void btnXacNhanTienThue_Click(object sender, EventArgs e)
        {
            if (dgvTienThue.CurrentRow == null) return;
            string maHDTT = dgvTienThue.CurrentRow.Cells["Mã_HĐ_Thuê"].Value.ToString();
            if (_service.ThanhToanHoaDonTienThue(maHDTT, "Chuyển khoản Vietcombank"))
            {
                MessageBox.Show($"Xác nhận đã thu đủ tiền thuê cho hóa đơn {maHDTT}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoaDonTienThue();
            }
            else
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán từ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoHoaDonThangMoi_Click(object sender, EventArgs e)
        {
            if (cboHopDongThue.SelectedIndex < 0) return;
            string maHD = cboHopDongThue.SelectedItem.ToString().Split(' ')[0];
            int thang = cboThangThue.SelectedIndex + 1;
            int nam = int.Parse(txtNamThue.Text);

            var res = _service.TaoHoaDonTienThueThang(maHD, thang, nam);
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Lập Hóa Đơn Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoaDonTienThue();
            }
            else
            {
                MessageBox.Show(res.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXacNhanDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null) return;
            string maHDDV = dgvDichVu.CurrentRow.Cells["Mã_HĐ_Dịch_Vụ"].Value.ToString();
            if (_service.ThanhToanHoaDonDichVu(maHDDV))
            {
                MessageBox.Show($"Xác nhận đã thanh toán hóa đơn dịch vụ {maHDDV}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoaDonDichVu();
            }
            else
            {
                MessageBox.Show("Hóa đơn dịch vụ này đã được thanh toán từ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoHoaDonDV_Click(object sender, EventArgs e)
        {
            if (cboHopDongDV.SelectedIndex < 0) return;
            string maHD = cboHopDongDV.SelectedItem.ToString().Split(' ')[0];
            int thang = cboThangDV.SelectedIndex + 1;
            int nam = int.Parse(txtNamDV.Text);

            decimal tienDien = numTienDien.Value;
            decimal tienNuoc = numTienNuoc.Value;
            decimal tienNet = numTienNet.Value;
            string maPhong = txtPhongDV.Text.Trim();

            var res = _service.TaoHoaDonDichVuCuoiThang(maHD, maPhong, thang, nam, tienDien, tienNuoc, tienNet, 0);
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Lập Hóa Đơn Dịch Vụ Cuối Tháng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoaDonDichVu();
            }
            else
            {
                MessageBox.Show(res.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
