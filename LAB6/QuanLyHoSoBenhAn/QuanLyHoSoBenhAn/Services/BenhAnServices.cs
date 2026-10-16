using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Services {
 public class ServiceBase {
  protected readonly Db db;
  public ServiceBase():this(new Db()){} public ServiceBase(Db value){db=value;}
  public DataTable HoSo(){return db.Query("SELECT h.MaHS,h.MaHS+' - '+b.HoTen AS HienThi FROM HoSoBenhAn h JOIN BenhNhan b ON b.MaBN=h.MaBN ORDER BY h.MaHS");}
  public DataTable BacSi(){return db.Query("SELECT b.MaBS,b.MaBS+' - '+b.HoTen+' / '+k.TenKhoa AS HienThi FROM BacSi b JOIN Khoa k ON k.MaKhoa=b.MaKhoa ORDER BY b.MaBS");}
  public DataTable Phieu(){return db.Query("SELECT p.MaPK,p.MaPK+' - '+b.HoTen+' / '+p.TrangThai AS HienThi FROM PhieuKham p JOIN HoSoBenhAn h ON h.MaHS=p.MaHS JOIN BenhNhan b ON b.MaBN=h.MaBN ORDER BY p.NgayGio DESC");}
  public DataTable LichSu(string hs){return db.Query("SELECT p.MaPK,p.NgayGio,p.LoaiKham,b.HoTen AS BacSi,k.TenKhoa,p.TrieuChung,p.ChanDoan,p.KetLuan,p.TrangThai FROM PhieuKham p JOIN BacSi b ON b.MaBS=p.MaBS JOIN Khoa k ON k.MaKhoa=p.MaKhoa WHERE p.MaHS=@hs ORDER BY p.NgayGio DESC",Db.P("@hs",hs));}
  public DataTable ChiTietPhieu(string pk){return db.Query("SELECT p.*,b.HoTen AS TenBenhNhan,b.NgaySinh,bs.HoTen AS TenBacSi,k.TenKhoa FROM PhieuKham p JOIN HoSoBenhAn h ON h.MaHS=p.MaHS JOIN BenhNhan b ON b.MaBN=h.MaBN JOIN BacSi bs ON bs.MaBS=p.MaBS JOIN Khoa k ON k.MaKhoa=p.MaKhoa WHERE MaPK=@pk",Db.P("@pk",pk));}
 }
 public sealed class HoSoService:ServiceBase {
  public HoSoService(){}public HoSoService(Db d):base(d){}
  public DataTable TraCuu(string key){return db.Query("SELECT h.MaHS,b.MaBN,b.HoTen,b.NgaySinh,b.DienThoai,b.DiaChi,b.Anh,h.NgayLap FROM HoSoBenhAn h JOIN BenhNhan b ON b.MaBN=h.MaBN WHERE @k='' OR h.MaHS=@k OR b.MaBN=@k OR CHARINDEX(@k,b.HoTen)>0 OR CHARINDEX(@k,b.DienThoai)>0 ORDER BY h.NgayLap DESC",Db.P("@k",(key??"").Trim()));}
  public string DangKy(DangKyInput x){
   Input.Require(x.NgaySinh.Date<=DateTime.Today,"Ngày sinh không được ở tương lai.");Input.Require(x.TuNgay.Date<=x.DenNgay.Date&&x.SoTien>0,"Kiểm tra thời hạn và số tiền lệ phí.");
   string hs=Input.Id("HS");
   db.Procedure("usp_DangKy",Db.P("@MaBN",Input.Id("BN")),Db.P("@MaDK",Input.Id("DK")),Db.P("@MaHS",hs),Db.P("@MaLP",Input.Id("LP")),Db.P("@HoTen",Input.Text(x.HoTen,"họ tên",100)),Db.P("@DiaChi",Input.Text(x.DiaChi,"địa chỉ",250)),Db.P("@NgaySinh",x.NgaySinh.Date),Db.P("@DienThoai",Input.Text(x.DienThoai,"điện thoại",20)),Db.P("@Anh",Input.Optional(x.Anh)),Db.P("@TuNgay",x.TuNgay.Date),Db.P("@DenNgay",x.DenNgay.Date),Db.P("@SoTien",x.SoTien));return hs;
  }
 }
 public sealed class LePhiService:ServiceBase {
  public LePhiService(){}public LePhiService(Db d):base(d){}
  public DataTable Lay(string hs){return db.Query("SELECT MaLP,NgayThu,TuNgay,DenNgay,SoTien FROM LanDongLePhi WHERE MaHS=@hs ORDER BY TuNgay DESC",Db.P("@hs",hs));}
  public void Thu(string hs,DateTime tu,DateTime den,decimal tien){Input.Require(tu.Date<=den.Date&&tien>0,"Kiểm tra thời hạn và số tiền.");db.Procedure("usp_ThuLePhi",Db.P("@MaLP",Input.Id("LP")),Db.P("@MaHS",hs),Db.P("@TuNgay",tu.Date),Db.P("@DenNgay",den.Date),Db.P("@SoTien",tien));}
 }
 public sealed class LichHenService:ServiceBase {
  public LichHenService(){}public LichHenService(Db d):base(d){}
  public DataTable Lay(string bs,DateTime ngay){return db.Query("SELECT l.MaHen,l.MaHS,b.HoTen,l.BatDau,l.KetThuc,l.TrangThai FROM LichHen l JOIN HoSoBenhAn h ON h.MaHS=l.MaHS JOIN BenhNhan b ON b.MaBN=h.MaBN WHERE l.MaBS=@bs AND CAST(l.BatDau AS date)=@ngay ORDER BY l.BatDau",Db.P("@bs",bs),Db.P("@ngay",ngay.Date));}
  public DataTable QuyenLoi(string hs,DateTime ngay){return db.Query("SELECT CASE WHEN EXISTS(SELECT 1 FROM LanDongLePhi WHERE MaHS=@hs AND @ngay BETWEEN TuNgay AND DenNgay) THEN N'Còn hiệu lực' ELSE N'Chưa có hiệu lực' END AS LePhi, (SELECT COUNT(*) FROM PhieuKham WHERE MaHS=@hs AND LoaiKham='DINHKY' AND TrangThai='HOANTAT' AND Nam=YEAR(@ngay) AND Quy=DATEPART(QUARTER,@ngay)) AS LuotDaDung",Db.P("@hs",hs),Db.P("@ngay",ngay.Date));}
  public string Dat(string hs,string bs,DateTime tu,DateTime den){Input.Require(tu<den,"Giờ kết thúc phải sau giờ bắt đầu.");string ma=Input.Id("LH");db.Procedure("usp_DatHen",Db.P("@MaHen",ma),Db.P("@MaHS",hs),Db.P("@MaBS",bs),Db.P("@BatDau",tu),Db.P("@KetThuc",den));return ma;}
  public void Huy(string ma){db.Procedure("usp_HuyHen",Db.P("@MaHen",ma));}
  public DataTable HenCho(string hs,string bs,DateTime ngay){var t=db.Query("SELECT MaHen,MaHen+' / '+CONVERT(varchar(5),BatDau,108) AS HienThi FROM LichHen WHERE MaHS=@hs AND MaBS=@bs AND TrangThai='DAHEN' AND CAST(BatDau AS date)=@ngay ORDER BY BatDau",Db.P("@hs",hs),Db.P("@bs",bs),Db.P("@ngay",ngay.Date));var r=t.NewRow();r["MaHen"]="";r["HienThi"]="Không dùng lịch hẹn";t.Rows.InsertAt(r,0);return t;}
 }
 public sealed class KhamBenhService:ServiceBase {
  public KhamBenhService(){}public KhamBenhService(Db d):base(d){}
  public string Tao(string hs,string bs,string hen,string loai,DateTime ngay,string trieu,decimal tien){string pk=Input.Id("PK");db.Procedure("usp_TaoPhieuKham",Db.P("@MaPK",pk),Db.P("@MaHS",hs),Db.P("@MaBS",bs),Db.P("@MaHen",Input.Optional(hen)),Db.P("@NgayGio",ngay),Db.P("@LoaiKham",loai),Db.P("@TrieuChung",trieu.Trim()),Db.P("@TienKham",tien),Db.P("@MaTT",Input.Id("TT")));return pk;}
  public void Ghi(string pk,string trieu,decimal? nhiet,string ap,string chan,string ket,bool xacNhan){db.Procedure("usp_GhiNhanKham",Db.P("@MaPK",pk),Db.P("@TrieuChung",trieu.Trim()),Db.P("@NhietDo",nhiet),Db.P("@HuyetAp",Input.Optional(ap)),Db.P("@ChanDoan",Input.Optional(chan)),Db.P("@KetLuan",Input.Optional(ket)),Db.P("@XacNhan",xacNhan));}
 }
 public sealed class XetNghiemService:ServiceBase {
  public XetNghiemService(){}public XetNghiemService(Db d):base(d){}
  public DataTable Loai(){return db.Query("SELECT MaLoaiXN,MaLoaiXN+' - '+TenXN AS HienThi FROM LoaiXetNghiem ORDER BY MaLoaiXN");}
  public DataTable Lay(string pk){return db.Query("SELECT c.MaCD,c.MaPK,x.TenXN,c.NgayChiDinh,c.KetQua,x.DonVi,c.NgayKetQua,c.TrangThai FROM ChiDinhXetNghiem c JOIN LoaiXetNghiem x ON x.MaLoaiXN=c.MaLoaiXN WHERE MaPK=@pk ORDER BY c.NgayChiDinh",Db.P("@pk",pk));}
  public void Lap(string pk,string loai){db.Procedure("usp_LapChiDinh",Db.P("@MaCD",Input.Id("CD")),Db.P("@MaPK",pk),Db.P("@MaLoaiXN",loai));}
  public void KetQua(string cd,string text){db.Procedure("usp_GhiKetQua",Db.P("@MaCD",cd),Db.P("@KetQua",Input.Text(text,"kết quả",2000)));}
 }
 public sealed class ToaThuocService:ServiceBase {
  public ToaThuocService(){}public ToaThuocService(Db d):base(d){}
  public DataTable Thuoc(){return db.Query("SELECT MaThuoc,MaThuoc+' - '+TenThuoc+' ('+DonVi+')' AS HienThi FROM Thuoc WHERE DangSuDung=1 ORDER BY MaThuoc");}
  public DataTable Header(string pk){return db.Query("SELECT MaToa,NgayLap,LoiDan FROM ToaThuoc WHERE MaPK=@pk",Db.P("@pk",pk));}
  public DataTable ChiTiet(string pk){return db.Query("SELECT d.STT,d.MaThuoc,t.TenThuoc,t.DonVi,d.SoLuong,d.LieuDung,d.CachDung,d.SoNgay FROM ToaThuoc h JOIN ChiTietToaThuoc d ON d.MaToa=h.MaToa JOIN Thuoc t ON t.MaThuoc=d.MaThuoc WHERE h.MaPK=@pk ORDER BY d.STT",Db.P("@pk",pk));}
  public string Lap(string pk,string loi,DataTable dong){Input.Require(dong.Rows.Count>0,"Thêm ít nhất một dòng thuốc.");var p=new SqlParameter("@DongToa",SqlDbType.Structured){TypeName="dbo.DongToaList",Value=dong};string ma=Input.Id("TO");db.Procedure("usp_LapToa",Db.P("@MaToa",ma),Db.P("@MaPK",pk),Db.P("@LoiDan",Input.Optional(loi)),p);return ma;}
 }
 public sealed class ThanhToanService:ServiceBase {
  public ThanhToanService(){}public ThanhToanService(Db d):base(d){}
  public DataTable Lay(string pk){return db.Query("SELECT MaTT,NoiDung,SoTien,TrangThai,NgayThu FROM ThanhToan WHERE MaPK=@pk ORDER BY MaTT",Db.P("@pk",pk));}
  public void Them(string pk,string noi,decimal tien){Input.Require(tien>0,"Số tiền phải lớn hơn 0.");db.Procedure("usp_ThemKhoanThu",Db.P("@MaTT",Input.Id("TT")),Db.P("@MaPK",pk),Db.P("@NoiDung",Input.Text(noi,"nội dung khoản thu",150)),Db.P("@SoTien",tien));}
  public void Thu(string ma){db.Procedure("usp_ThanhToan",Db.P("@MaTT",ma));}
  public void HoanTat(string pk){db.Procedure("usp_HoanTat",Db.P("@MaPK",pk));}
 }
}
