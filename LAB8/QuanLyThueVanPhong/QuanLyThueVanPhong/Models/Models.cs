using System;
using System.Collections.Generic;

namespace QuanLyThueVanPhong.Models
{
    public class CaoOc
    {
        public string MaCaoOc { get; set; }
        public string TenCaoOc { get; set; }
        public string DiaChi { get; set; }
        public int SoTang { get; set; }
        public string SoDienThoaiBQL { get; set; }
        public string QuyCheToaNha { get; set; }
    }

    public class Tang
    {
        public string MaTang { get; set; }
        public int SoThuTuTang { get; set; }
        public string TenTang { get; set; }
        public double DoCao { get; set; }
        public double HeSoGiaTang { get; set; }
        public string MaCaoOc { get; set; }
    }

    public class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public double DienTich { get; set; }
        public string HuongPhong { get; set; }
        public decimal DonGiaCoBan { get; set; }
        public decimal GiaThueThang { get; set; }
        public string TinhTrang { get; set; } // Trống, Đang thuê, Chờ tu sửa, Vi phạm
        public string KetCauBanDau { get; set; }
        public string MaTang { get; set; }
    }

    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenCongTy { get; set; }
        public string MaSoThue { get; set; }
        public string NguoiDaiDien { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChiTruSo { get; set; }
        public string SoCMND_CCCD { get; set; }
    }

    public class HopDongThue
    {
        public string MaHD { get; set; }
        public string SoHopDong { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int ThoiHanThue { get; set; } // Số tháng, >= 6 tháng
        public decimal TienCoc { get; set; }
        public decimal TongTienThue6Thang { get; set; }
        public decimal DonGiaThueThangMoi { get; set; }
        public string TrangThai { get; set; } // Đang hiệu lực, Đã gia hạn, Hết hạn, Đã thanh lý
        public string MaKH { get; set; }
    }

    public class ChiTietHopDong
    {
        public string MaCTHD { get; set; }
        public string MaHD { get; set; }
        public string MaPhong { get; set; }
        public double DienTichThue { get; set; }
        public decimal DonGiaThang { get; set; }
        public DateTime NgayBanGiao { get; set; }
    }

    public class PhieuGiaHan
    {
        public string MaPhieuGH { get; set; }
        public string SoPhieu { get; set; }
        public DateTime NgayLap { get; set; }
        public int ThoiGianGiaHan { get; set; } // <= 1/2 Thời gian thuê gốc
        public DateTime NgayBatDauGH { get; set; }
        public DateTime NgayKetThucGH { get; set; }
        public string LyDoGiaHan { get; set; }
        public string TrangThaiDuyet { get; set; } // Chờ duyệt, Đã duyệt, Bị từ chối
        public string MaHD { get; set; }
        public string NguoiLap { get; set; }
    }

    public class ChiTietGiaHan
    {
        public string MaCTGH { get; set; }
        public string MaPhieuGH { get; set; }
        public string MaPhong { get; set; }
        public DateTime GiaHanDenNgay { get; set; }
        public decimal DonGiaGiaHan { get; set; }
    }

    public class HoaDonTienThue
    {
        public string MaHDTienThue { get; set; }
        public string KyThanhToan { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public decimal SoTienThue { get; set; }
        public DateTime HanNopTien { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string TrangThai { get; set; } // Chưa thanh toán, Đã thanh toán
        public string MaHD { get; set; }
    }

    public class DichVu
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public string GhiChu { get; set; }
    }

    public class ChiSoDichVu
    {
        public string MaChiSo { get; set; }
        public string MaPhong { get; set; }
        public string MaDV { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public double ChiSoDau { get; set; }
        public double ChiSoCuoi { get; set; }
        public double SoLuongTieuThu { get; set; }
        public DateTime NgayChotChiSo { get; set; }
    }

    public class HoaDonDichVu
    {
        public string MaHDDV { get; set; }
        public string MaHD { get; set; }
        public string MaPhong { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal TienDien { get; set; }
        public decimal TienNuoc { get; set; }
        public decimal TienInternet { get; set; }
        public decimal TienDichVuKhac { get; set; }
        public decimal TongTien { get; set; }
        public DateTime HanThanhToan { get; set; } // Cuối tháng
        public DateTime? NgayThanhToan { get; set; }
        public string TrangThai { get; set; } // Chưa thanh toán, Đã thanh toán
    }

    public class NhanVienVanPhong
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string MaCongTy { get; set; }
        public string ChucVu { get; set; }
        public string MaPhong { get; set; }
        public string MaTang { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgayBaoCao { get; set; }
        public string TrangThai { get; set; } // Đang làm việc, Đã nghỉ
    }

    public class TheGiuXe
    {
        public string MaThe { get; set; }
        public string MaNV { get; set; }
        public string BienSoXe { get; set; }
        public string LoaiXe { get; set; } // Xe máy, Ô tô, Xe đạp điện
        public string NhanHieu { get; set; }
        public string MauXe { get; set; }
        public DateTime NgayCap { get; set; }
        public string TrangThai { get; set; } // Đang hoạt động, Đã khóa, Đã thu hồi
    }

    public class DotKiemTra
    {
        public string MaDotKT { get; set; }
        public string TenDotKT { get; set; }
        public int NamKiemTra { get; set; } // 1 năm/lần
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TruongDoan { get; set; }
        public string KeHoachTuSua { get; set; }
    }

    public class BienBanKiemTraPhong
    {
        public string MaBBKT { get; set; }
        public string MaDotKT { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public string NguoiKiemTra { get; set; }
        public string TinhTrangKetCau { get; set; }
        public string KetLuan { get; set; } // Đạt, Cần tu sửa, Tự ý sửa đổi kết cấu
        public string GhiChuChiTiet { get; set; }
    }

    public class BienBanViPham
    {
        public string MaBBVP { get; set; }
        public string MaPhong { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public string HanhViViPham { get; set; } // Tự ý thay đổi, chỉnh sửa kết cấu văn phòng
        public decimal MucPhat { get; set; }
        public string BienPhapKhacPhuc { get; set; } // Khôi phục kết cấu ban đầu
        public DateTime HanKhacPhuc { get; set; }
        public DateTime HanNopPhat { get; set; }
        public DateTime? NgayNopPhat { get; set; }
        public string TrangThai { get; set; } // Chưa nộp phạt, Đã nộp phạt
    }
}
