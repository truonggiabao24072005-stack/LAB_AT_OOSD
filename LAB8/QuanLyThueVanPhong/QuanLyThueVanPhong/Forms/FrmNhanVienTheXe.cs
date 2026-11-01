using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Data;
using QuanLyThueVanPhong.Models;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmNhanVienTheXe : Form
    {
        private readonly CaoOcService _service;

        public FrmNhanVienTheXe()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmNhanVienTheXe_Load(object sender, EventArgs e)
        {
            LoadDanhSachCongTy();
            LoadDanhSachTangVaPhong();
            LoadDanhSachNhanVien();
            LoadDanhSachTheXe();
        }

        private void LoadDanhSachCongTy()
        {
            cboCongTy.Items.Clear();
            var ds = _service.LayDanhSachKhachHang();
            foreach (var k in ds)
            {
                cboCongTy.Items.Add($"{k.MaKH} - {k.TenCongTy}");
            }
            if (cboCongTy.Items.Count > 0) cboCongTy.SelectedIndex = 0;
        }

        private void LoadDanhSachTangVaPhong()
        {
            cboTang.Items.Clear();
            foreach (var t in _service.LayDanhSachTang())
                cboTang.Items.Add(t.MaTang);
            if (cboTang.Items.Count > 0) cboTang.SelectedIndex = 0;

            cboPhong.Items.Clear();
            foreach (var p in _service.LayDanhSachPhong())
                cboPhong.Items.Add(p.MaPhong);
            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
        }

        private void LoadDanhSachNhanVien()
        {
            var ds = _service.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = ds.Select(nv => new
            {
                Mã_NV = nv.MaNV,
                Họ_Tên = nv.HoTen,
                Công_Ty = nv.MaCongTy,
                Chức_Vụ = nv.ChucVu,
                Phòng = nv.MaPhong,
                Tầng = nv.MaTang,
                Số_Điện_Thoại = nv.SoDienThoai,
                Ngày_Báo_Cáo = nv.NgayBaoCao.ToString("dd/MM/yyyy"),
                Trạng_Thái = nv.TrangThai
            }).ToList();

            cboNhanVienTheXe.Items.Clear();
            foreach (var nv in ds)
            {
                cboNhanVienTheXe.Items.Add($"{nv.MaNV} - {nv.HoTen} ({nv.ChucVu})");
            }
            if (cboNhanVienTheXe.Items.Count > 0) cboNhanVienTheXe.SelectedIndex = 0;
        }

        private void LoadDanhSachTheXe()
        {
            var ds = DbContext.Instance.TheGiuXes.ToList();
            dgvTheXe.DataSource = ds.Select(t => new
            {
                Mã_Thẻ = t.MaThe,
                Mã_NV = t.MaNV,
                Biển_Số_Xe = t.BienSoXe,
                Loại_Xe = t.LoaiXe,
                Nhãn_Hiệu = t.NhanHieu,
                Màu_Xe = t.MauXe,
                Ngày_Cấp = t.NgayCap.ToString("dd/MM/yyyy"),
                Trạng_Thái = t.TrangThai
            }).ToList();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã NV và Họ Tên!", "Cảnh báo");
                return;
            }

            var nv = new NhanVienVanPhong
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                MaCongTy = cboCongTy.SelectedItem.ToString().Split(' ')[0],
                ChucVu = txtChucVu.Text.Trim(),
                MaPhong = cboPhong.SelectedItem.ToString(),
                MaTang = cboTang.SelectedItem.ToString(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            var res = _service.BaoCaoNhanVienMoi(nv);
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Clear();
                txtHoTen.Clear();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapTheXe_Click(object sender, EventArgs e)
        {
            if (cboNhanVienTheXe.SelectedIndex < 0) return;
            string maNV = cboNhanVienTheXe.SelectedItem.ToString().Split(' ')[0];
            string bienSo = txtBienSo.Text.Trim();
            if (string.IsNullOrWhiteSpace(bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe!", "Cảnh báo");
                return;
            }

            string loaiXe = cboLoaiXe.SelectedItem?.ToString() ?? "Xe máy";
            string nhanHieu = txtNhanHieu.Text.Trim();
            string mauXe = txtMauXe.Text.Trim();

            var res = _service.CapTheGiuXe(maNV, bienSo, loaiXe, nhanHieu, mauXe);
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Cấp Thẻ Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBienSo.Clear();
                LoadDanhSachTheXe();
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi Cấp Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
