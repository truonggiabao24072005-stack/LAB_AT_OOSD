using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Services
{
    public sealed class TourService
    {
        private readonly Db db; public TourService() : this(new Db()) {} public TourService(Db value) {db=value;}
        public DataTable LayTour() {return db.Query("SELECT * FROM Tour ORDER BY MaTour");}
        public DataTable LayTourMoBan() {return db.Query("SELECT *,MaTour+' - '+TenTour AS HienThi FROM Tour WHERE DangMoBan=1 ORDER BY MaTour");}
        public DataTable LayDiemDung(string ma) {return db.Query("SELECT * FROM TourDiemDung WHERE MaTour=@m ORDER BY ThuTu",Db.P("@m",ma));}
        public DataTable LayPhuongTien(string ma) {return db.Query("SELECT p.*,t.TenPT FROM TourPhuongTien p JOIN PhuongTien t ON t.MaPT=p.MaPT WHERE MaTour=@m ORDER BY ThuTuChang",Db.P("@m",ma));}
        public DataTable LayThamQuan(string ma) {return db.Query("SELECT p.*,t.TenDiemTQ FROM TourDiemThamQuan p JOIN DiemThamQuan t ON t.MaDiemTQ=p.MaDiemTQ WHERE MaTour=@m ORDER BY ThuTu",Db.P("@m",ma));}
        private static bool DaDung(SqlConnection c,SqlTransaction tx,string ma)
        {using(var q=Db.Command(c,tx,"SELECT CASE WHEN EXISTS(SELECT 1 FROM ChuyenLe WHERE MaTour=@m) OR EXISTS(SELECT 1 FROM DangKyDoan WHERE MaTour=@m) THEN 1 ELSE 0 END",Db.P("@m",ma)))return Convert.ToInt32(q.ExecuteScalar())==1;}
        private static void SuaHanhTrinh(SqlConnection c,SqlTransaction tx,string ma)
        {
            using(var q=Db.Command(c,tx,"SELECT DangMoBan FROM Tour WITH(UPDLOCK,HOLDLOCK) WHERE MaTour=@m",Db.P("@m",ma)))
            {var o=q.ExecuteScalar();QuyDinh.Require(o!=null,"Tour không tồn tại.");QuyDinh.Require(!Convert.ToBoolean(o),"Ngừng mở bán tour trước khi sửa hành trình.");}
            QuyDinh.Require(!DaDung(c,tx,ma),"Tour đã có chuyến hoặc đăng ký. Tạo mã tour mới để đổi hành trình.");
        }
        public void LuuTour(string ma,string ten,int ngay,int dem,decimal gia,string mota,bool mo,bool sua)
        {
            ma=QuyDinh.Ma(ma);ten=QuyDinh.Text(ten,"tên tour",180);mota=QuyDinh.TuyChon(mota,1000);
            QuyDinh.Require(ngay>0 && dem>=0 && gia>0,"Số ngày và đơn giá phải dương, số đêm không âm.");
            db.Transaction<int>((c,tx)=>{
                if(sua) {
                    using(var q=Db.Command(c,tx,"SELECT SoNgay FROM Tour WITH(UPDLOCK,HOLDLOCK) WHERE MaTour=@m",Db.P("@m",ma)))
                    {var o=q.ExecuteScalar();QuyDinh.Require(o!=null,"Không có tour được chọn.");QuyDinh.Require(!DaDung(c,tx,ma)||Convert.ToInt32(o)==ngay,"Không đổi số ngày của tour đã có chuyến hoặc phiếu.");}
                }
                else QuyDinh.Require(!mo,"Tour mới lưu ở trạng thái ngừng bán. Thêm đủ hành trình rồi mở bán.");
                if(mo) {
                    using(var q=Db.Command(c,tx,@"SELECT CASE WHEN COUNT(*)>=2 AND MIN(ThuTu)=1 AND MAX(ThuTu)=COUNT(*)
AND (SELECT TenDiemDung FROM TourDiemDung WHERE MaTour=@m AND ThuTu=1)=N'TP.HCM'
AND (SELECT TOP 1 TenDiemDung FROM TourDiemDung WHERE MaTour=@m ORDER BY ThuTu DESC)=N'TP.HCM' THEN 1 ELSE 0 END FROM TourDiemDung WHERE MaTour=@m",Db.P("@m",ma)))
                    QuyDinh.Require(Convert.ToInt32(q.ExecuteScalar())==1,"Hành trình phải liên tục từ 1, bắt đầu và kết thúc tại TP.HCM.");
                    using(var q=Db.Command(c,tx,@"SELECT COUNT(*) FROM TourDiemDung d WHERE d.MaTour=@m AND d.ThuTu<(SELECT MAX(ThuTu) FROM TourDiemDung WHERE MaTour=@m)
AND NOT EXISTS(SELECT 1 FROM TourPhuongTien p WHERE p.MaTour=@m AND p.ThuTuChang=d.ThuTu)",Db.P("@m",ma)))
                    QuyDinh.Require(Convert.ToInt32(q.ExecuteScalar())==0,"Mỗi chặng giữa hai điểm dừng cần phương tiện.");
                }
                using(var q=Db.Command(c,tx,sua?"UPDATE Tour SET TenTour=@t,SoNgay=@n,SoDem=@d,DonGiaKhach=@g,MoTa=@mt,DangMoBan=@b WHERE MaTour=@m":"INSERT Tour VALUES(@m,@t,@n,@d,@g,@mt,@b)",Db.P("@m",ma),Db.P("@t",ten),Db.P("@n",ngay),Db.P("@d",dem),Db.P("@g",gia),Db.P("@mt",mota),Db.P("@b",mo)))return q.ExecuteNonQuery();
            });
        }
        public void XoaTour(string ma)
        {
            ma=QuyDinh.Ma(ma); db.Transaction<int>((c,tx)=>{
                SuaHanhTrinh(c,tx,ma);
                using(var q=Db.Command(c,tx,"DELETE TourDiemThamQuan WHERE MaTour=@m;DELETE TourPhuongTien WHERE MaTour=@m;DELETE TourDiemDung WHERE MaTour=@m;DELETE Tour WHERE MaTour=@m;",Db.P("@m",ma)))return q.ExecuteNonQuery();
            });
        }
        public void ThemDiemDung(string ma,int stt,string ten,bool doi,bool an,bool ks,int sao,string note)
        {
            ma=QuyDinh.Ma(ma);ten=QuyDinh.Text(ten,"tên điểm dừng",180);note=QuyDinh.TuyChon(note,500);
            QuyDinh.Require(stt>0 && (!ks || sao>=2 && sao<=5),"Thứ tự phải dương, khách sạn từ 2 đến 5 sao.");
            db.Transaction<int>((c,tx)=>{SuaHanhTrinh(c,tx,ma);using(var q=Db.Command(c,tx,"INSERT TourDiemDung VALUES(@m,@s,@t,@d,@a,@k,@h,@g)",Db.P("@m",ma),Db.P("@s",stt),Db.P("@t",ten),Db.P("@d",doi),Db.P("@a",an),Db.P("@k",ks),Db.P("@h",ks?(object)sao:DBNull.Value),Db.P("@g",note)))return q.ExecuteNonQuery();});
        }
        public void GanPhuongTien(string ma,int chang,string pt,string note)
        {
            ma=QuyDinh.Ma(ma);pt=QuyDinh.Ma(pt);note=QuyDinh.TuyChon(note,300);
            db.Transaction<int>((c,tx)=>{SuaHanhTrinh(c,tx,ma);
                using(var q=Db.Command(c,tx,"SELECT COUNT(*) FROM TourDiemDung WHERE MaTour=@m AND ThuTu IN(@s,@s+1)",Db.P("@m",ma),Db.P("@s",chang)))QuyDinh.Require(Convert.ToInt32(q.ExecuteScalar())==2,"Chặng cần hai điểm dừng liên tiếp đã có.");
                using(var q=Db.Command(c,tx,"INSERT TourPhuongTien VALUES(@m,@s,@p,@g)",Db.P("@m",ma),Db.P("@s",chang),Db.P("@p",pt),Db.P("@g",note)))return q.ExecuteNonQuery();});
        }
        public void GanThamQuan(string ma,int stt,string diem)
        {ma=QuyDinh.Ma(ma);diem=QuyDinh.Ma(diem);db.Transaction<int>((c,tx)=>{SuaHanhTrinh(c,tx,ma);using(var q=Db.Command(c,tx,"INSERT TourDiemThamQuan VALUES(@m,@d,@s)",Db.P("@m",ma),Db.P("@d",diem),Db.P("@s",stt)))return q.ExecuteNonQuery();});}
        public void XoaChiTiet(string loai,string ma,int stt,string id)
        {
            QuyDinh.Require(loai=="DD"||loai=="PT"||loai=="TQ","Chi tiết không hợp lệ.");ma=QuyDinh.Ma(ma);
            db.Transaction<int>((c,tx)=>{SuaHanhTrinh(c,tx,ma);
                var sql=loai=="DD"?"DELETE TourDiemDung WHERE MaTour=@m AND ThuTu=@s":loai=="PT"?"DELETE TourPhuongTien WHERE MaTour=@m AND ThuTuChang=@s AND MaPT=@i":"DELETE TourDiemThamQuan WHERE MaTour=@m AND MaDiemTQ=@i";
                using(var q=Db.Command(c,tx,sql,Db.P("@m",ma),Db.P("@s",stt),Db.P("@i",id)))return q.ExecuteNonQuery();});
        }
    }
}
