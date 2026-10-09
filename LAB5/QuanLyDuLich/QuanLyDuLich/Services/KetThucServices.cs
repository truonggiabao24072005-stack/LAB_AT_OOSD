using System;
using System.Data;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Services
{
    public sealed class PhanCongService
    {
        private readonly Db db; public PhanCongService() : this(new Db()) {} public PhanCongService(Db value) {db=value;}
        public DataTable LayHDV() {return db.Query("SELECT MaHDV,MaHDV+' - '+HoTen AS HienThi FROM HuongDanVien WHERE DangLamViec=1 ORDER BY MaHDV");}
        public DataTable LayDanhSach() {return db.Query("SELECT p.*,h.HoTen FROM PhanCongHDV p JOIN HuongDanVien h ON h.MaHDV=p.MaHDV ORDER BY NgayBatDau DESC");}
        public DataTable LayDoiTuong(string loai)
        {return loai=="LE"?db.Query("SELECT c.MaChuyen AS Ma,c.MaChuyen+' - '+t.TenTour AS HienThi FROM ChuyenLe c JOIN Tour t ON t.MaTour=c.MaTour WHERE c.NgayDi>CAST(GETDATE() AS date) AND NOT EXISTS(SELECT 1 FROM PhanCongHDV p WHERE p.MaChuyen=c.MaChuyen)"):
         db.Query("SELECT SoDKDoan AS Ma,SoDKDoan+' - '+TenCoQuanDaiDien AS HienThi FROM vw_DangKyDoan WHERE TrangThai=N'Đã đăng ký' AND NgayDi>CAST(GETDATE() AS date)");}
        public void PhanCong(string ma,string hdv,string loai,string doiTuong,decimal thuLao)
        {db.Procedure("usp_PhanCongHDV",Db.P("@MaPC",QuyDinh.Ma(ma)),Db.P("@MaHDV",QuyDinh.Ma(hdv)),Db.P("@Loai",loai),Db.P("@MaDoiTuong",QuyDinh.Ma(doiTuong)),Db.P("@ThuLao",thuLao));}
        public void GoPhanCong(string ma)
        {QuyDinh.Require(db.Execute("DELETE PhanCongHDV WHERE MaPC=@m AND NgayBatDau>CAST(GETDATE() AS date)",Db.P("@m",QuyDinh.Ma(ma)))==1,"Chỉ gỡ phân công chưa khởi hành.");}
    }
    public sealed class KetThucService
    {
        private readonly Db db; public KetThucService() : this(new Db()) {} public KetThucService(Db value) {db=value;}
        public DataTable DoanCanThanhToan() {return db.Query("SELECT SoDKDoan,TenCoQuanDaiDien,NgayKetThucDuKien,TongTienDuKien,TienCoc,DaThanhToanSauTour,ConLai FROM vw_DangKyDoan WHERE TrangThai=N'Đã đăng ký' AND NgayKetThucDuKien<CAST(GETDATE() AS date) AND ConLai>0");}
        public DataTable LayThanhToan() {return db.Query("SELECT * FROM ThanhToanDoan ORDER BY NgayThanhToan DESC");}
        public void ThanhToanDoan(string ma,string so,DateTime ngay,decimal tien,string note)
        {db.Procedure("usp_ThanhToanDoan",Db.P("@SoTT",QuyDinh.Ma(ma)),Db.P("@SoDKDoan",QuyDinh.Ma(so)),Db.P("@NgayThanhToan",ngay.Date),Db.P("@SoTien",tien),Db.P("@GhiChu",QuyDinh.TuyChon(note,300)));}
        public DataTable LayDangKyChoKhaoSat(string loai)
        {return loai=="LE"?db.Query("SELECT d.SoDKLe AS Ma,d.SoDKLe+' - '+d.TenNguoiDangKy AS HienThi FROM DangKyLe d JOIN ChuyenLe c ON c.MaChuyen=d.MaChuyen WHERE c.NgayVe<CAST(GETDATE() AS date) AND NOT EXISTS(SELECT 1 FROM KhaoSat k WHERE k.SoDKLe=d.SoDKLe)"):
         db.Query("SELECT SoDKDoan AS Ma,SoDKDoan+' - '+TenCoQuanDaiDien AS HienThi FROM vw_DangKyDoan WHERE TrangThai<>N'Hủy - mất cọc' AND NgayKetThucDuKien<CAST(GETDATE() AS date) AND NOT EXISTS(SELECT 1 FROM KhaoSat k WHERE k.SoDKDoan=vw_DangKyDoan.SoDKDoan)");}
        public DataTable LayKhaoSat() {return db.Query("SELECT * FROM KhaoSat ORDER BY NgayGui DESC");}
        public void GuiKhaoSat(string ma,string loai,string so,DateTime ngay)
        {db.Procedure("usp_GuiKhaoSat",Db.P("@MaKhaoSat",QuyDinh.Ma(ma)),Db.P("@Loai",loai),Db.P("@SoDangKy",QuyDinh.Ma(so)),Db.P("@NgayGui",ngay.Date));}
        public void GhiPhanHoi(string ma,DateTime ngay,int diem,string y)
        {db.Procedure("usp_GhiPhanHoi",Db.P("@MaKhaoSat",QuyDinh.Ma(ma)),Db.P("@NgayPhanHoi",ngay.Date),Db.P("@Diem",diem),Db.P("@GopY",QuyDinh.TuyChon(y,1500)));}
    }
    public sealed class ThongKeService
    {
        private readonly Db db; public ThongKeService() : this(new Db()) {} public ThongKeService(Db value) {db=value;}
        public DataTable TinhLuong(int thang,int nam) {return db.Procedure("usp_LuongHDV",Db.P("@Thang",thang),Db.P("@Nam",nam));}
        public DataTable TongHop(DateTime tu,DateTime den)
        {
            QuyDinh.Require(tu.Date<=den.Date,"Ngày từ không được sau ngày đến.");
            return db.Query(@"SELECT N'Đăng ký lẻ' AS ChiTieu,COUNT(*) AS SoLuong,ISNULL(SUM(ThanhTien),0) AS SoTien FROM DangKyLe WHERE NgayDangKy>=@tu AND NgayDangKy<DATEADD(day,1,@den)
UNION ALL SELECT N'Đoàn đang hiệu lực',COUNT(*),ISNULL(SUM(TongTienDuKien),0) FROM DangKyDoan WHERE TrangThai<>N'Hủy - mất cọc' AND NgayDangKy>=@tu AND NgayDangKy<DATEADD(day,1,@den)
UNION ALL SELECT N'Tiền cọc thực thu (gồm cọc mất)',COUNT(*),ISNULL(SUM(TienCoc),0) FROM DangKyDoan WHERE NgayDangKy>=@tu AND NgayDangKy<DATEADD(day,1,@den)
UNION ALL SELECT N'Thanh toán sau tour',COUNT(*),ISNULL(SUM(SoTien),0) FROM ThanhToanDoan WHERE NgayThanhToan>=@tu AND NgayThanhToan<DATEADD(day,1,@den)
UNION ALL SELECT N'Phiếu khảo sát đã gửi',COUNT(*),0 FROM KhaoSat WHERE NgayGui>=@tu AND NgayGui<DATEADD(day,1,@den)",Db.P("@tu",tu.Date),Db.P("@den",den.Date));
        }
    }
}
