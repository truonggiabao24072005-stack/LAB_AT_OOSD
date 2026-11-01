using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        private readonly CaoOcService _service;

        public FrmMain()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CapNhatDashboard();
        }

        public void CapNhatDashboard()
        {
            var dsTang = _service.LayDanhSachTang();
            var dsPhong = _service.LayDanhSachPhong();
            var dsKhach = _service.LayDanhSachKhachHang();
            var dsHopDong = _service.LayDanhSachHopDong();
            var dsHDTT = _service.LayDanhSachHoaDonTienThue();
            var dsHDDV = _service.LayDanhSachHoaDonDichVu();

            lblTongTang.Text = dsTang.Count.ToString();
            lblTongPhong.Text = dsPhong.Count.ToString();
            lblPhongDangThue.Text = dsPhong.Count(p => p.TinhTrang == "Đang thuê").ToString();
            lblPhongTrong.Text = dsPhong.Count(p => p.TinhTrang == "Trống").ToString();
            lblPhongViPham.Text = dsPhong.Count(p => p.TinhTrang == "Vi phạm").ToString();
            lblTongKhachHang.Text = dsKhach.Count.ToString();
            lblTongHopDong.Text = dsHopDong.Count.ToString();

            decimal tongThuTienThue = dsHDTT.Where(h => h.TrangThai == "Đã thanh toán").Sum(h => h.SoTienThue);
            decimal tongThuDichVu = dsHDDV.Where(d => d.TrangThai == "Đã thanh toán").Sum(d => d.TongTien);
            lblTongDoanhThu.Text = $"{tongThuTienThue + tongThuDichVu:N0} VNĐ";
        }

        private void btnPhongTang_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPhongTang())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnHopDongThue_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmHopDongThue())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmGiaHan())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmThanhToan())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnNhanVienTheXe_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNhanVienTheXe())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnKiemTraViPham_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmKiemTraViPham())
            {
                frm.ShowDialog();
                CapNhatDashboard();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
