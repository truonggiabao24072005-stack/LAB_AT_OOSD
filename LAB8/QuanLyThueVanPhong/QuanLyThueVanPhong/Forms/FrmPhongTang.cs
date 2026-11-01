using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmPhongTang : Form
    {
        private readonly CaoOcService _service;

        public FrmPhongTang()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmPhongTang_Load(object sender, EventArgs e)
        {
            LoadDanhSachTang();
            LoadDanhSachPhong();
        }

        private void LoadDanhSachTang()
        {
            cboTang.Items.Clear();
            cboTang.Items.Add("-- Tất cả các tầng --");
            var dsTang = _service.LayDanhSachTang();
            foreach (var t in dsTang)
            {
                cboTang.Items.Add($"{t.MaTang} - {t.TenTang} (Cao: {t.DoCao}m, Hệ số: {t.HeSoGiaTang})");
            }
            cboTang.SelectedIndex = 0;
        }

        private void LoadDanhSachPhong()
        {
            string maTang = null;
            if (cboTang.SelectedIndex > 0)
            {
                maTang = cboTang.SelectedItem.ToString().Split(' ')[0];
            }

            string tinhTrang = null;
            if (cboTinhTrang.SelectedIndex > 0)
            {
                tinhTrang = cboTinhTrang.SelectedItem.ToString();
            }

            var phongs = _service.LayDanhSachPhong(maTang, tinhTrang);
            dgvPhong.DataSource = phongs.Select(p => new
            {
                Mã_Phòng = p.MaPhong,
                Tên_Phòng = p.TenPhong,
                Mã_Tầng = p.MaTang,
                Diện_Tích_m2 = p.DienTich,
                Hướng_Phòng = p.HuongPhong,
                Đơn_Giá_Gốc = $"{p.DonGiaCoBan:N0}",
                Giá_Thuê_Tháng = $"{p.GiaThueThang:N0} VNĐ",
                Tình_Trạng = p.TinhTrang,
                Kết_Cấu_Gốc = p.KetCauBanDau
            }).ToList();
        }

        private void cboTang_SelectedIndexChanged(object sender, EventArgs e) => LoadDanhSachPhong();
        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e) => LoadDanhSachPhong();

        private void btnTinhGia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDienTichMoi.Text, out double dt) && cboTangMoi.SelectedIndex >= 0)
            {
                var dsTang = _service.LayDanhSachTang();
                var tang = dsTang[cboTangMoi.SelectedIndex];
                decimal donGiaCoBan = 300000;
                decimal giaThue = _service.TinhGiaThuePhong(dt, donGiaCoBan, tang.HeSoGiaTang);
                lblKetQuaTinh.Text = $"{giaThue:N0} VNĐ/tháng (Hệ số tầng {tang.TenTang}: {tang.HeSoGiaTang})";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập diện tích hợp lệ và chọn tầng cần tính!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
