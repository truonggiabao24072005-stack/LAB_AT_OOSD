using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class AccountService {
  readonly Db db; const int Work=210000;
  public AccountService(Db d){db=d;}
  public static byte[] Hash(string password,byte[] salt,int iterations){
   using(var k=new Rfc2898DeriveBytes(password,salt,iterations,HashAlgorithmName.SHA256))
    return k.GetBytes(32);}
  public int Register(Customer x,string password){
   if(string.IsNullOrWhiteSpace(x.Name)||string.IsNullOrWhiteSpace(x.Address)||
    string.IsNullOrWhiteSpace(x.Phone)||string.IsNullOrWhiteSpace(x.Identity)||
    !Regex.IsMatch(x.Username??"","^[A-Za-z0-9_]{3,50}$")||
    x.BirthDate.Date>DateTime.Today||string.IsNullOrEmpty(password)||password.Length<8)
    throw new Exception("Thông tin đăng ký chưa hợp lệ. Nhập đủ hồ sơ, tên đăng nhập 3–50 ký tự (chữ, số hoặc _), mật khẩu tối thiểu 8 ký tự và ngày sinh không ở tương lai.");
   if(!string.IsNullOrWhiteSpace(x.Email) && !Regex.IsMatch(x.Email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
    throw new Exception("Địa chỉ email không hợp lệ.");
   var salt=new byte[16];using(var rng=RandomNumberGenerator.Create())rng.GetBytes(salt);
   using(var c=db.Open())using(var q=Db.Cmd(c,null,
    "INSERT KhachHang(HoTen,NgaySinh,GiayTo,DiaChi,DienThoai,TenDangNhap,PasswordHash,Salt,Iterations,Email) "+
    "OUTPUT INSERTED.MaKH VALUES(@n,@b,@i,@a,@p,@u,@h,@s,@w,@e)",
    Db.P("@n",x.Name),Db.P("@b",x.BirthDate.Date),Db.P("@i",x.Identity),
    Db.P("@a",x.Address),Db.P("@p",x.Phone),Db.P("@u",x.Username),
    Db.P("@h",Hash(password,salt,Work)),Db.P("@s",salt),Db.P("@w",Work),
    Db.P("@e",string.IsNullOrWhiteSpace(x.Email)?null:x.Email.Trim()))){
     try{return Convert.ToInt32(q.ExecuteScalar());}
     catch(SqlException ex){if(ex.Number==2601||ex.Number==2627)
      throw new Exception("Tên đăng nhập đã tồn tại.");throw;}}
  }
  public Customer Login(string username,string password){
   var t=db.Query("SELECT * FROM KhachHang WHERE TenDangNhap=@u",Db.P("@u",username));
   if(t.Rows.Count!=1)throw new Exception("Sai tên đăng nhập hoặc mật khẩu.");
   var r=t.Rows[0];var stored=(byte[])r["PasswordHash"];
   var input=Hash(password,(byte[])r["Salt"],Convert.ToInt32(r["Iterations"]));
   int difference=0;for(int i=0;i<stored.Length;i++)difference|=stored[i]^input[i];
   if(difference!=0)throw new Exception("Sai tên đăng nhập hoặc mật khẩu.");
   return new Customer {Id=(int)r["MaKH"],Name=(string)r["HoTen"],
    Address=(string)r["DiaChi"],Phone=(string)r["DienThoai"],
    Email=r["Email"]==DBNull.Value?null:(string)r["Email"],Username=username};
  }
 }

}
