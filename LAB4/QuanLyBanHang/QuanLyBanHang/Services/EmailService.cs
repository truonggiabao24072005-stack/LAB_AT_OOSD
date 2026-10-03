using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class EmailService {
  readonly Db db;readonly IEmailAdapter adapter;
  public EmailService(Db d,IEmailAdapter a){db=d;adapter=a;}
  public void Flush(int customerId){
   var t=db.Query("SELECT e.* FROM EmailOutbox e JOIN DonHang d ON d.MaDH=e.MaDH WHERE e.TrangThai<>'SENT' AND d.MaKH=@c",Db.P("@c",customerId));
   foreach(DataRow r in t.Rows){
    try{adapter.Send((string)r["DiaChi"],(string)r["NoiDung"],(Guid)r["MaDH"]);
     db.Execute("UPDATE EmailOutbox SET TrangThai='SENT',SoLanThu=SoLanThu+1,LoiGanNhat=NULL WHERE MaEmail=@id",Db.P("@id",r["MaEmail"]));}
    catch{db.Execute("UPDATE EmailOutbox SET TrangThai='FAILED',SoLanThu=SoLanThu+1,LoiGanNhat=N'Gửi email giả lập thất bại' WHERE MaEmail=@id",Db.P("@id",r["MaEmail"]));}
   }
  }
 }

}
