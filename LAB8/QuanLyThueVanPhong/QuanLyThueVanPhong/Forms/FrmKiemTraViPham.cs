using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Data;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmKiemTraViPham : Form
    {
        private readonly CaoOcService _service;

        public FrmKiemTraViPham()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmKiemTraViPham_Load(object sender, EventArgs e)
        {
            LoadDanhSachDotKiemTra();
            LoadDanhSachBienBanKiemTra();
            LoadDanhSachViPham();
            LoadPhongVaKhachHang();
        }

        private void LoadDanhSachDotKiemTra()
        {
            var ds = _service.LayDanhSachDotKiemTra();
            dgvDotKT.DataSource = ds.Select(d => new
            {
                Mã_Đợt = d.MaDotKT,
                Tên_Đợt_Kiểm_Tra = d.TenDotKT,
                Năm = d.NamKiemTra,
                Ngày_Bắt_Đầu = d.NgayBatDau.ToString("dd/MM/yyyy"),
                Ngày_Kết_Thúc = d.NgayKetThuc.ToString("dd/MM/yyyy"),
                Trưởng_Đoàn = d.TruongDoan,
                Kế_Hoạch_Tu_Sửa = d.KeHoachTuSua
            }).ToList();
        }

        private void LoadDanhSachBienBanKiemTra()
        {
            var ds = _service.LayDanhSachBienBanKiemTra();
            dgvBienBanKT.DataSource = ds.Select(b => new
            {
                Mã_BB = b.MaBBKT,
                Đợt_KT = b.MaDotKT,
                Phòng = b.MaPhong,
                Ngày_KT = b.NgayKiemTra.ToString("dd/MM/yyyy"),
                Cán_Bộ = b.NguoiKiemTra,
                Tình_Trạng_Kết_Cấu = b.TinhTrangKetCau,
                Kết_Luận = b.KetLuan,
                Chi_Tiết = b.GhiChuChiTiet
            }).ToList();
        }

        private void LoadDanhSachViPham()
        {
            var ds = _service.LayDanhSachBienBanViPham();
            dgvViPham.DataSource = ds.Select(v => new
            {
                Mã_QĐ_Phạt = v.MaBBVP,
                Phòng_VP = v.MaPhong,
                Công_Ty_VP = v.MaKH,
                Ngày_Lập = v.NgayLap.ToString("dd/MM/yyyy"),
                Hành_Vi = v.HanhViViPham,
                Tiền_Phạt = $"{v.MucPhat:N0} VNĐ",
                Biện_Pháp_Khắc_Phục = v.BienPhapKhacPhuc,
                Hạn_Khắc_Phục = v.HanKhacPhuc.ToString("dd/MM/yyyy"),
                Hạn_Nộp_Phạt = v.HanNopPhat.ToString("dd/MM/yyyy"),
                Ngày_Nộp = v.NgayNopPhat?.ToString("dd/MM/yyyy") ?? "Chưa nộp",
                Trạng_Thái = v.TrangThai
            }).ToList();
        }

        private void LoadPhongVaKhachHang()
        {
            cboPhongVP.Items.Clear();
            foreach (var p in _service.LayDanhSachPhong())
                cboPhongVP.Items.Add(p.MaPhong);
            if (cboPhongVP.Items.Count > 0) cboPhongVP.SelectedIndex = 0;

            cboKhachVP.Items.Clear();
            foreach (var k in _service.LayDanhSachKhachHang())
                cboKhachVP.Items.Add($"{k.MaKH} - {k.TenCongTy}");
            if (cboKhachVP.Items.Count > 0) cboKhachVP.SelectedIndex = 0;
        }

        private void btnLapBienBanVP_Click(object sender, EventArgs e)
        {
            if (cboPhongVP.SelectedIndex < 0 || cboKhachVP.SelectedIndex < 0) return;
            string maPhong = cboPhongVP.SelectedItem.ToString();
            string maKH = cboKhachVP.SelectedItem.ToString().Split(' ')[0];

            decimal mucPhat = numMucPhat.Value;
            string hanhVi = txtHanhVi.Text.Trim();
            string bienPhap = txtBienPhap.Text.Trim();
            int soNgay = (int)numNgayKhacPhuc.Value;

            var res = _service.LapBienBanViPham(maPhong, maKH, hanhVi, mucPhat, bienPhap, soNgay);
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Lập Quyết Định Phạt Vi Phạm Kết Cấu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachViPham();
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNopPhat_Click(object sender, EventArgs e)
        {
            if (dgvViPham.CurrentRow == null) return;
            string maBBVP = dgvViPham.CurrentRow.Cells["Mã_QĐ_Phạt"].Value.ToString();
            if (_service.XacNhanNopPhat(maBBVP))
            {
                MessageBox.Show($"Xác nhận doanh nghiệp đã nộp phạt và nghiệm thu khắc phục nguyên trạng cho biên bản {maBBVP}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachViPham();
            }
            else
            {
                MessageBox.Show("Biên bản phạt này đã được xử lý hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
