using System;
using System.Data;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Services
{
    public sealed class DanhMucService
    {
        private readonly Db db; public DanhMucService() : this(new Db()) {} public DanhMucService(Db value) {db=value;}
        // Chi nhan ten loai trong whitelist; khong noi chuoi SQL tu du lieu nguoi dung.
        private static string[] CauHinh(string loai)
        {
            switch(loai) {
                case "PT":return new[]{"PhuongTien","MaPT"};
                case "DTQ":return new[]{"DiemThamQuan","MaDiemTQ"};
                case "DB":return new[]{"DiemBanVe","MaDiemBan"};
                case "HDV":return new[]{"HuongDanVien","MaHDV"};
                default:throw new InvalidOperationException("Loại danh mục không hợp lệ.");
            }
        }
        public DataTable Lay(string loai) {var c=CauHinh(loai);return db.Query("SELECT * FROM "+c[0]+" ORDER BY "+c[1]);}
        public void Xoa(string loai,string ma) {var c=CauHinh(loai);QuyDinh.Require(db.Execute("DELETE "+c[0]+" WHERE "+c[1]+"=@m",Db.P("@m",QuyDinh.Ma(ma)))==1,"Không có dòng được chọn.");}
        public void LuuPT(string ma,string ten,string note,bool sua)
        {db.Execute(sua?"UPDATE PhuongTien SET TenPT=@t,GhiChu=@g WHERE MaPT=@m":"INSERT PhuongTien VALUES(@m,@t,@g)",Db.P("@m",QuyDinh.Ma(ma)),Db.P("@t",QuyDinh.Text(ten,"tên phương tiện",120)),Db.P("@g",QuyDinh.TuyChon(note,300)));}
        public void LuuDTQ(string ma,string ten,string dia,string noidung,string ynghia,bool sua)
        {db.Execute(sua?"UPDATE DiemThamQuan SET TenDiemTQ=@t,DiaDiem=@d,NoiDung=@n,YNghia=@y WHERE MaDiemTQ=@m":"INSERT DiemThamQuan VALUES(@m,@t,@d,@n,@y)",Db.P("@m",QuyDinh.Ma(ma)),Db.P("@t",QuyDinh.Text(ten,"tên điểm tham quan",180)),Db.P("@d",QuyDinh.Text(dia,"địa điểm",250)),Db.P("@n",QuyDinh.TuyChon(noidung,1000)),Db.P("@y",QuyDinh.TuyChon(ynghia,1000)));}
        public void LuuDB(string ma,string ten,string dia,string phone,bool sua)
        {db.Execute(sua?"UPDATE DiemBanVe SET TenDiemBan=@t,DiaChi=@d,DienThoai=@p WHERE MaDiemBan=@m":"INSERT DiemBanVe VALUES(@m,@t,@d,@p)",Db.P("@m",QuyDinh.Ma(ma)),Db.P("@t",QuyDinh.Text(ten,"tên điểm bán",150)),Db.P("@d",QuyDinh.Text(dia,"địa chỉ",250)),Db.P("@p",QuyDinh.Text(phone,"điện thoại",20)));}
        public void LuuHDV(string ma,string ten,string phone,decimal luong,bool lam,bool sua)
        {QuyDinh.Require(luong>=0,"Lương không âm.");db.Execute(sua?"UPDATE HuongDanVien SET HoTen=@t,DienThoai=@p,LuongCoBan=@l,DangLamViec=@a WHERE MaHDV=@m":"INSERT HuongDanVien VALUES(@m,@t,@p,@l,@a)",Db.P("@m",QuyDinh.Ma(ma)),Db.P("@t",QuyDinh.Text(ten,"họ tên",120)),Db.P("@p",QuyDinh.Text(phone,"điện thoại",20)),Db.P("@l",luong),Db.P("@a",lam));}
    }
}
