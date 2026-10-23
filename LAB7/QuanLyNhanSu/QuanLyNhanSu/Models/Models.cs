using System; using System.Collections.Generic;
namespace QuanLyNhanSu.Models {
 public class NhanVien {public string MaNV{get;set;} public string HoTen{get;set;} public DateTime NgaySinh{get;set;} public string MaPB{get;set;} public string TrangThai{get;set;} }
 public class DongKeHoach {public string MaNV; public DateTime Ngay; public string MaCa; public decimal GioPhuTroi;}
 public class DongPhuTroi {public string MaNV; public decimal SoGio;}
 public abstract class QuyetDinh {public string SoQD; public DateTime NgayQD,HieuLuc; public string MaNV,MaPB,NoiDung,NguoiKy; public DateTime? NgayKy;}
 public class QuyetDinhTuyenDung:QuyetDinh {public DateTime DenNgay; public decimal LuongThuViec;}
 public class QuyetDinhLuong:QuyetDinh {public decimal LuongCoBan,PhuCapLuong,PhuCapDocHai;}
 public class QuyetDinhChucVu:QuyetDinh {public string MaCV; public decimal PhuCap;}
 public class QuyetDinhKhenThuong:QuyetDinh {public decimal SoTien;}
 public class QuyetDinhKyLuat:QuyetDinh {public decimal SoTien; public string CachXuLy;}
}
