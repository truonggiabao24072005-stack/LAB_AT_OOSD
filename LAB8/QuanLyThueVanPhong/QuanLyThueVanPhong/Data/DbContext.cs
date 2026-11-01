using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyThueVanPhong.Models;

namespace QuanLyThueVanPhong.Data
{
    public class DbContext
    {
        private static DbContext _instance;
        public static DbContext Instance => _instance ?? (_instance = new DbContext());

        public List<CaoOc> CaoOcs { get; set; } = new List<CaoOc>();
        public List<Tang> Tangs { get; set; } = new List<Tang>();
        public List<Phong> Phongs { get; set; } = new List<Phong>();
        public List<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
        public List<HopDongThue> HopDongThues { get; set; } = new List<HopDongThue>();
        public List<ChiTietHopDong> ChiTietHopDongs { get; set; } = new List<ChiTietHopDong>();
        public List<PhieuGiaHan> PhieuGiaHans { get; set; } = new List<PhieuGiaHan>();
        public List<ChiTietGiaHan> ChiTietGiaHans { get; set; } = new List<ChiTietGiaHan>();
        public List<HoaDonTienThue> HoaDonTienThues { get; set; } = new List<HoaDonTienThue>();
        public List<DichVu> DichVus { get; set; } = new List<DichVu>();
        public List<ChiSoDichVu> ChiSoDichVus { get; set; } = new List<ChiSoDichVu>();
        public List<HoaDonDichVu> HoaDonDichVus { get; set; } = new List<HoaDonDichVu>();
        public List<NhanVienVanPhong> NhanVienVanPhongs { get; set; } = new List<NhanVienVanPhong>();
        public List<TheGiuXe> TheGiuXes { get; set; } = new List<TheGiuXe>();
        public List<DotKiemTra> DotKiemTras { get; set; } = new List<DotKiemTra>();
        public List<BienBanKiemTraPhong> BienBanKiemTraPhongs { get; set; } = new List<BienBanKiemTraPhong>();
        public List<BienBanViPham> BienBanViPhams { get; set; } = new List<BienBanViPham>();

        public DbContext()
        {
            SeedData();
        }

        private void SeedData()
        {
            // 1. Tòa Cao Ốc
            CaoOcs.Add(new CaoOc
            {
                MaCaoOc = "CO_HUTECH",
                TenCaoOc = "Tòa Cao Ốc Thương Mại HUTECH Financial Tower",
                DiaChi = "475A Điện Biên Phủ, Phường 25, Quận Bình Thạnh, TP.HCM",
                SoTang = 25,
                SoDienThoaiBQL = "028.5445.7777",
                QuyCheToaNha = "Nghiêm cấm tự ý thay đổi, chỉnh sửa kết cấu văn phòng; Thanh toán đúng hạn; Giữ gìn an ninh trật tự."
            });

            // 2. Danh mục Tầng (Độ cao & Hệ số giá)
            Tangs.Add(new Tang { MaTang = "T01", SoThuTuTang = 1, TenTang = "Tầng 1 (Tầng Trệt)", DoCao = 4.0, HeSoGiaTang = 1.0, MaCaoOc = "CO_HUTECH" });
            Tangs.Add(new Tang { MaTang = "T05", SoThuTuTang = 5, TenTang = "Tầng 5", DoCao = 20.0, HeSoGiaTang = 1.2, MaCaoOc = "CO_HUTECH" });
            Tangs.Add(new Tang { MaTang = "T10", SoThuTuTang = 10, TenTang = "Tầng 10", DoCao = 40.0, HeSoGiaTang = 1.4, MaCaoOc = "CO_HUTECH" });
            Tangs.Add(new Tang { MaTang = "T18", SoThuTuTang = 18, TenTang = "Tầng 18 (Sky Office)", DoCao = 72.0, HeSoGiaTang = 1.7, MaCaoOc = "CO_HUTECH" });

            // 3. Danh mục Văn phòng
            Phongs.Add(new Phong { MaPhong = "P101", TenPhong = "Văn phòng 101", DienTich = 60, HuongPhong = "Đông", DonGiaCoBan = 300000, GiaThueThang = 18000000, TinhTrang = "Đang thuê", KetCauBanDau = "Tường bê tông chịu lực, sàn gạch men, trần thạch cao chuẩn", MaTang = "T01" });
            Phongs.Add(new Phong { MaPhong = "P102", TenPhong = "Văn phòng 102", DienTich = 80, HuongPhong = "Nam", DonGiaCoBan = 300000, GiaThueThang = 24000000, TinhTrang = "Trống", KetCauBanDau = "Mặt bằng vách kính, sàn gạch men chuẩn", MaTang = "T01" });
            Phongs.Add(new Phong { MaPhong = "P501", TenPhong = "Văn phòng 501", DienTich = 100, HuongPhong = "Đông Nam", DonGiaCoBan = 350000, GiaThueThang = 42000000, TinhTrang = "Đang thuê", KetCauBanDau = "Khung nhôm kính cường lực, sàn gỗ công nghiệp cao cấp", MaTang = "T05" });
            Phongs.Add(new Phong { MaPhong = "P502", TenPhong = "Văn phòng 502", DienTich = 120, HuongPhong = "Đông", DonGiaCoBan = 350000, GiaThueThang = 50400000, TinhTrang = "Đang thuê", KetCauBanDau = "Mặt bằng mở, vách ngăn chống cháy", MaTang = "T05" });
            Phongs.Add(new Phong { MaPhong = "P1001", TenPhong = "Văn phòng 1001", DienTich = 150, HuongPhong = "Nam", DonGiaCoBan = 400000, GiaThueThang = 84000000, TinhTrang = "Đang thuê", KetCauBanDau = "Thiết kế hiện đại, view sông Sài Gòn", MaTang = "T10" });
            Phongs.Add(new Phong { MaPhong = "P1801", TenPhong = "Văn phòng 1801 Penthouse", DienTich = 200, HuongPhong = "Toàn cảnh", DonGiaCoBan = 500000, GiaThueThang = 170000000, TinhTrang = "Trống", KetCauBanDau = "Kết cấu kính hộp cách âm 3 lớp, sàn marble", MaTang = "T18" });

            // 4. Khách hàng (Công ty thuê)
            KhachHangs.Add(new KhachHang
            {
                MaKH = "KH01",
                TenCongTy = "Công Ty CP Công Nghệ Phần Mềm Á Châu",
                MaSoThue = "0301234567",
                NguoiDaiDien = "Nguyễn Văn Hùng",
                SoDienThoai = "0908112233",
                Email = "contact@achau-software.vn",
                DiaChiTruSo = "Tầng 5, Tòa HUTECH Tower",
                SoCMND_CCCD = "079085001234"
            });
            KhachHangs.Add(new KhachHang
            {
                MaKH = "KH02",
                TenCongTy = "Tập Đoàn Giải Pháp Số Toàn Cầu (Global Solutions)",
                MaSoThue = "0309876543",
                NguoiDaiDien = "Trần Thị Mai Phương",
                SoDienThoai = "0918445566",
                Email = "admin@globalsolutions.com",
                DiaChiTruSo = "Tầng 10, Tòa HUTECH Tower",
                SoCMND_CCCD = "079190005678"
            });

            // 5. Hợp đồng thuê (Thuê nhiều phòng, thời hạn >= 6 tháng)
            var hd1 = new HopDongThue
            {
                MaHD = "HD2026_01",
                SoHopDong = "HĐ-HUTECH/2026-001",
                NgayLap = new DateTime(2026, 1, 1),
                NgayBatDau = new DateTime(2026, 1, 15),
                NgayKetThuc = new DateTime(2027, 1, 14), // 12 tháng
                ThoiHanThue = 12,
                TienCoc = 184800000, // Cọc 2 tháng tiền thuê
                TongTienThue6Thang = 554400000, // 6 tháng của P501 + P502 = 92.400.000 * 6
                DonGiaThueThangMoi = 92400000,
                TrangThai = "Đang hiệu lực",
                MaKH = "KH01"
            };
            HopDongThues.Add(hd1);

            ChiTietHopDongs.Add(new ChiTietHopDong { MaCTHD = "CTHD01", MaHD = "HD2026_01", MaPhong = "P501", DienTichThue = 100, DonGiaThang = 42000000, NgayBanGiao = new DateTime(2026, 1, 15) });
            ChiTietHopDongs.Add(new ChiTietHopDong { MaCTHD = "CTHD02", MaHD = "HD2026_01", MaPhong = "P502", DienTichThue = 120, DonGiaThang = 50400000, NgayBanGiao = new DateTime(2026, 1, 15) });

            // 6. Hóa đơn tiền thuê (6 tháng đầu trả trước, từ tháng 7 trả đầu tháng)
            HoaDonTienThues.Add(new HoaDonTienThue
            {
                MaHDTienThue = "HDTT_001",
                KyThanhToan = "6 tháng đầu tiên (15/01/2026 - 14/07/2026)",
                NgayLapHoaDon = new DateTime(2026, 1, 1),
                SoTienThue = 554400000,
                HanNopTien = new DateTime(2026, 1, 15),
                NgayThanhToan = new DateTime(2026, 1, 10),
                HinhThucThanhToan = "Chuyển khoản Vietcombank",
                TrangThai = "Đã thanh toán",
                MaHD = "HD2026_01"
            });
            HoaDonTienThues.Add(new HoaDonTienThue
            {
                MaHDTienThue = "HDTT_002",
                KyThanhToan = "Tháng thứ 7 (15/07/2026 - 14/08/2026)",
                NgayLapHoaDon = new DateTime(2026, 7, 1),
                SoTienThue = 92400000,
                HanNopTien = new DateTime(2026, 7, 5), // Đầu tháng
                NgayThanhToan = new DateTime(2026, 7, 3),
                HinhThucThanhToan = "Chuyển khoản Vietcombank",
                TrangThai = "Đã thanh toán",
                MaHD = "HD2026_01"
            });

            // 7. Dịch vụ tòa nhà
            DichVus.Add(new DichVu { MaDV = "DV_DIEN", TenDV = "Điện tiêu thụ", DonViTinh = "kWh", DonGia = 3500, GhiChu = "Đo theo công tơ từng phòng" });
            DichVus.Add(new DichVu { MaDV = "DV_NUOC", TenDV = "Nước sinh hoạt", DonViTinh = "m³", DonGia = 20000, GhiChu = "Đo theo đồng hồ nước" });
            DichVus.Add(new DichVu { MaDV = "DV_NET", TenDV = "Internet Cáp quang Doanh nghiệp", DonViTinh = "Gói/tháng", DonGia = 800000, GhiChu = "Gói Fiber 500Mbps" });

            // 8. Hóa đơn dịch vụ (Thanh toán cuối tháng)
            HoaDonDichVus.Add(new HoaDonDichVu
            {
                MaHDDV = "HDDV_001",
                MaHD = "HD2026_01",
                MaPhong = "P501",
                Thang = 9,
                Nam = 2026,
                TienDien = 4550000,
                TienNuoc = 400000,
                TienInternet = 800000,
                TienDichVuKhac = 500000,
                TongTien = 6250000,
                HanThanhToan = new DateTime(2026, 9, 30),
                NgayThanhToan = new DateTime(2026, 9, 28),
                TrangThai = "Đã thanh toán"
            });

            // 9. Nhân viên công ty làm việc trong tòa nhà
            NhanVienVanPhongs.Add(new NhanVienVanPhong
            {
                MaNV = "NV_ACHAU_01",
                HoTen = "Trương Gia Bảo",
                MaCongTy = "KH01",
                ChucVu = "Trưởng phòng Kỹ thuật",
                MaPhong = "P501",
                MaTang = "T05",
                SoDienThoai = "0988776655",
                Email = "bao.truong@achau-software.vn",
                NgayBaoCao = new DateTime(2026, 1, 16),
                TrangThai = "Đang làm việc"
            });
            NhanVienVanPhongs.Add(new NhanVienVanPhong
            {
                MaNV = "NV_ACHAU_02",
                HoTen = "Lê Thị Thảo Trang",
                MaCongTy = "KH01",
                ChucVu = "Kế toán viên",
                MaPhong = "P502",
                MaTang = "T05",
                SoDienThoai = "0977112233",
                Email = "trang.le@achau-software.vn",
                NgayBaoCao = new DateTime(2026, 1, 16),
                TrangThai = "Đang làm việc"
            });

            // 10. Thẻ giữ xe cao ốc
            TheGiuXes.Add(new TheGiuXe
            {
                MaThe = "THE_XE_001",
                MaNV = "NV_ACHAU_01",
                BienSoXe = "59B1-888.99",
                LoaiXe = "Xe máy",
                NhanHieu = "Honda SH150i",
                MauXe = "Đen nhám",
                NgayCap = new DateTime(2026, 1, 17),
                TrangThai = "Đang hoạt động"
            });

            // 11. Đợt kiểm tra định kỳ 1 năm
            DotKiemTras.Add(new DotKiemTra
            {
                MaDotKT = "DKT_2026",
                TenDotKT = "Đợt kiểm tra định kỳ kết cấu văn phòng năm 2026",
                NamKiemTra = 2026,
                NgayBatDau = new DateTime(2026, 10, 1),
                NgayKetThuc = new DateTime(2026, 10, 15),
                TruongDoan = "Kỹ sư Trần Anh Tuấn",
                KeHoachTuSua = "Bảo trì hệ thống điều hòa trung tâm tầng 5, sơn lại hành lang tầng 10."
            });

            // 12. Biên bản kiểm tra phòng
            BienBanKiemTraPhongs.Add(new BienBanKiemTraPhong
            {
                MaBBKT = "BBKT_001",
                MaDotKT = "DKT_2026",
                MaPhong = "P501",
                NgayKiemTra = new DateTime(2026, 10, 5),
                NguoiKiemTra = "Cán bộ KS Nguyễn Hoàng",
                TinhTrangKetCau = "Nguyên vẹn đúng hồ sơ thiết kế ban đầu",
                KetLuan = "Đạt",
                GhiChuChiTiet = "Văn phòng sử dụng đúng quy chế, kết cấu đảm bảo."
            });
            BienBanKiemTraPhongs.Add(new BienBanKiemTraPhong
            {
                MaBBKT = "BBKT_002",
                MaDotKT = "DKT_2026",
                MaPhong = "P502",
                NgayKiemTra = new DateTime(2026, 10, 5),
                NguoiKiemTra = "Cán bộ KS Nguyễn Hoàng",
                TinhTrangKetCau = "Tự ý đập bỏ một phần vách chống cháy để thông cửa phụ",
                KetLuan = "Tự ý sửa đổi kết cấu",
                GhiChuChiTiet = "Phát hiện khách hàng tự ý thay đổi kết cấu mà chưa xin phép ban quản lý."
            });

            // 13. Biên bản xử phạt vi phạm
            BienBanViPhams.Add(new BienBanViPham
            {
                MaBBVP = "BBVP_2026_01",
                MaPhong = "P502",
                MaKH = "KH01",
                NgayLap = new DateTime(2026, 10, 6),
                HanhViViPham = "Tự ý thay đổi, chỉnh sửa kết cấu văn phòng mà không xin phép BQL",
                MucPhat = 20000000, // Phạt 20.000.000 VNĐ
                BienPhapKhacPhuc = "Buộc khôi phục nguyên trạng vách tường ngăn ban đầu trong 10 ngày",
                HanKhacPhuc = new DateTime(2026, 10, 16),
                HanNopPhat = new DateTime(2026, 10, 20),
                NgayNopPhat = null,
                TrangThai = "Chưa nộp phạt"
            });
        }
    }
}
