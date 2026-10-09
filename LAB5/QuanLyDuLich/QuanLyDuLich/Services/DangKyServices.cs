using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Services
{
    public sealed class ChuyenLeService
    {
        private readonly Db db; public ChuyenLeService() : this(new Db()) { } public ChuyenLeService(Db value) { db=value; }
        public DataTable LayChuyen() { return db.Query("SELECT c.*,t.TenTour,t.DonGiaKhach FROM ChuyenLe c JOIN Tour t ON t.MaTour=c.MaTour ORDER BY c.NgayDi DESC"); }
        public DataTable LayChuyenMo() { return db.Query("SELECT c.MaChuyen,c.MaChuyen+' - '+t.TenTour AS HienThi,t.DonGiaKhach FROM ChuyenLe c JOIN Tour t ON t.MaTour=c.MaTour WHERE c.TrangThai=N'Mở đăng ký' AND c.NgayDi>CAST(GETDATE() AS date) AND t.DangMoBan=1 ORDER BY c.NgayDi"); }
        public void ThemChuyen(string ma,string tour,DateTime di,string don)
        { db.Procedure("usp_TaoChuyen",Db.P("@MaChuyen",QuyDinh.Ma(ma)),Db.P("@MaTour",QuyDinh.Ma(tour)),Db.P("@NgayDi",di.Date),Db.P("@DiaDiemDon",QuyDinh.Text(don,"nơi đón",250))); }
        public void DongDangKy(string ma)
        { QuyDinh.Require(db.Execute("UPDATE ChuyenLe SET TrangThai=N'Đóng đăng ký' WHERE MaChuyen=@m AND TrangThai=N'Mở đăng ký'",Db.P("@m",QuyDinh.Ma(ma)))==1,"Không có chuyến mở đăng ký được chọn."); }
    }
    public sealed class DangKyLeService
    {
        private readonly Db db; public DangKyLeService() : this(new Db()) { } public DangKyLeService(Db value) { db=value; }
        public DataTable LayDanhSach() { return db.Query("SELECT d.*,c.NgayDi,c.NgayVe,t.TenTour FROM DangKyLe d JOIN ChuyenLe c ON c.MaChuyen=d.MaChuyen JOIN Tour t ON t.MaTour=c.MaTour ORDER BY d.NgayDangKy DESC"); }
        public void DangKy(string so,string chuyen,string diem,string ten,string phone,int n)
        {
            QuyDinh.Require(n>0 && n<12,"Khách lẻ từ 1 đến 11 người; đúng 12 người chưa được quy định.");
            db.Procedure("usp_DangKyLe",Db.P("@SoDKLe",QuyDinh.Ma(so)),Db.P("@MaChuyen",QuyDinh.Ma(chuyen)),Db.P("@MaDiemBan",QuyDinh.Ma(diem)),Db.P("@TenNguoiDangKy",QuyDinh.Text(ten,"người đăng ký",120)),Db.P("@DienThoai",QuyDinh.Text(phone,"điện thoại",20)),Db.P("@SoNguoi",n));
        }
    }
    public sealed class DangKyDoanService
    {
        private readonly Db db; public DangKyDoanService() : this(new Db()) { } public DangKyDoanService(Db value) { db=value; }
        public DataTable LayDanhSach() { return db.Query("SELECT * FROM vw_DangKyDoan ORDER BY NgayDangKy DESC"); }
        public DataTable LayThanhVien(string so) { return db.Query("SELECT STT,HoTen,NgaySinh,SoGiayTo FROM ThanhVienDoan WHERE SoDKDoan=@s ORDER BY STT",Db.P("@s",so)); }
        public void LapPhieu(DangKyDoanInput x)
        {
            QuyDinh.Require(x.SoNguoi>12,"Khách đoàn phải trên 12 người.");
            QuyDinh.Require(x.TienCoc>0,"Khách đoàn phải đặt cọc trước một khoản tiền.");
            var tv=x.ThanhVien ?? QuyDinh.BangThanhVien();
            QuyDinh.Require(!x.BaoHiem || tv.Rows.Count==x.SoNguoi,"Đoàn mua bảo hiểm phải kèm danh sách đủ "+x.SoNguoi+" người cùng đi.");
            var p=new SqlParameter("@ThanhVien",SqlDbType.Structured) {TypeName="dbo.ThanhVienDoanList",Value=tv};
            db.Procedure("usp_DangKyDoan",Db.P("@SoDKDoan",QuyDinh.Ma(x.SoDKDoan)),Db.P("@MaDoan",QuyDinh.Ma(x.MaDoan)),Db.P("@TenCoQuanDaiDien",QuyDinh.Text(x.TenDoan,"tên đoàn",180)),Db.P("@DiaChi",QuyDinh.Text(x.DiaChi,"địa chỉ",250)),Db.P("@DienThoai",QuyDinh.Text(x.DienThoai,"điện thoại",20)),Db.P("@NguoiDaiDien",QuyDinh.Text(x.DaiDien,"đại diện",120)),Db.P("@MaTour",QuyDinh.Ma(x.MaTour)),Db.P("@NgayDi",x.NgayDi.Date),Db.P("@SoNguoi",x.SoNguoi),Db.P("@DiaDiemDon",QuyDinh.Text(x.NoiDon,"nơi đón",250)),Db.P("@MuaBaoHiem",x.BaoHiem),Db.P("@TienCoc",x.TienCoc),p);
        }
        public void HuyDangKy(string so) { db.Procedure("usp_HuyDangKyDoan",Db.P("@SoDKDoan",QuyDinh.Ma(so))); }
    }
}
