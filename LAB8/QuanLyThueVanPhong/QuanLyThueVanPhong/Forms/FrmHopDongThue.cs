using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyThueVanPhong.Services;

namespace QuanLyThueVanPhong.Forms
{
    public partial class FrmHopDongThue : Form
    {
        private readonly CaoOcService _service;

        public FrmHopDongThue()
        {
            InitializeComponent();
            FormAppearance.Apply(this);
            _service = new CaoOcService();
        }

        private void FrmHopDongThue_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadPhongTrong();
            LoadDanhSachHopDong();
            numThoiHan.Value = 12; // Mặc định 12 tháng (quy định >= 6)
            dtpNgayBatDau.Value = DateTime.Now.Date.AddDays(7);
        }

        private void LoadKhachHang()
        {
            cboKhachHang.Items.Clear();
            var dsKhach = _service.LayDanhSachKhachHang();
            foreach (var kh in dsKhach)
            {
                cboKhachHang.Items.Add($"{kh.MaKH} - {kh.TenCongTy} (MST: {kh.MaSoThue})");
            }
            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
        }

        private void LoadPhongTrong()
        {
            chkListPhong.Items.Clear();
            var dsPhongTrong = _service.LayDanhSachPhong(null, "Trống");
            foreach (var p in dsPhongTrong)
            {
                chkListPhong.Items.Add($"{p.MaPhong} - {p.TenPhong} ({p.DienTich}m², Giá: {p.GiaThueThang:N0} VNĐ/tháng)");
            }
            CapNhatTongTien();
        }

        private void LoadDanhSachHopDong()
        {
            var dsHD = _service.LayDanhSachHopDong();
            dgvHopDong.DataSource = dsHD.Select(h => new
            {
                Mã_HĐ = h.MaHD,
                Số_Hợp_Đồng = h.SoHopDong,
                Khách_Hàng = h.MaKH,
                Thời_Hạn_Tháng = h.ThoiHanThue,
                Ngày_Bắt_Đầu = h.NgayBatDau.ToString("dd/MM/yyyy"),
                Ngày_Kết_Thúc = h.NgayKetThuc.ToString("dd/MM/yyyy"),
                Tiền_Cọc = $"{h.TienCoc:N0} VNĐ",
                Tiền_Thuê_6_Tháng_Đầu = $"{h.TongTienThue6Thang:N0} VNĐ",
                Tiền_Thuê_1_Tháng = $"{h.DonGiaThueThangMoi:N0} VNĐ",
                Trạng_Thái = h.TrangThai
            }).ToList();
        }

        private void chkListPhong_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate { CapNhatTongTien(); });
        }

        private void numThoiHan_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            var dsMaPhong = LayDanhSachPhongDaChon();
            var allPhongs = _service.LayDanhSachPhong();
            var selectedPhongs = allPhongs.Where(p => dsMaPhong.Contains(p.MaPhong)).ToList();

            decimal tong1Thang = selectedPhongs.Sum(p => p.GiaThueThang);
            decimal tien6Thang = tong1Thang * 6;
            decimal tienCoc = tong1Thang * 2;

            lblTongTien1Thang.Text = $"{tong1Thang:N0} VNĐ";
            lblTien6ThangDau.Text = $"{tien6Thang:N0} VNĐ";
            lblTienCoc.Text = $"{tienCoc:N0} VNĐ";
        }

        private List<string> LayDanhSachPhongDaChon()
        {
            var list = new List<string>();
            for (int i = 0; i < chkListPhong.Items.Count; i++)
            {
                if (chkListPhong.GetItemChecked(i))
                {
                    string maP = chkListPhong.Items[i].ToString().Split(' ')[0];
                    list.Add(maP);
                }
            }
            return list;
        }

        private void btnTaoHopDong_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng/doanh nghiệp thuê!", "Cảnh báo");
                return;
            }

            string maKH = cboKhachHang.SelectedItem.ToString().Split(' ')[0];
            var dsPhong = LayDanhSachPhongDaChon();

            if (dsPhong.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất một văn phòng cần thuê!", "Cảnh báo");
                return;
            }

            int thoiHan = (int)numThoiHan.Value;
            if (thoiHan < 6)
            {
                MessageBox.Show("Quy định cao ốc: Thời hạn thuê tối thiểu phải từ 6 tháng trở lên!", "Cảnh báo vi phạm");
                return;
            }

            DateTime ngayBD = dtpNgayBatDau.Value.Date;
            var res = _service.TaoHopDongThue(maKH, dsPhong, thoiHan, ngayBD, 0);

            if (res.Success)
            {
                MessageBox.Show(res.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhongTrong();
                LoadDanhSachHopDong();
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi lập hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
