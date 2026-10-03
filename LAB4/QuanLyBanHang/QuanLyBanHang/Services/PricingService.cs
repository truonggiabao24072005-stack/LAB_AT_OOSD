using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class PricingService {
  readonly Db db; public PricingService(Db d){db=d;}
  public static decimal Shipping(decimal subtotal,string kind,decimal baseFee){
   if(kind=="NHANH" && subtotal>=1000000m)return 0;
   if(kind=="TRONGNGAY" && subtotal>=5000000m)return 0;
   return baseFee;
  }
  public Quote Calculate(decimal subtotal,string region,string kind,string card){
   var t=db.Query("SELECT p.Phi,l.LePhi FROM PhiGiaoHang p CROSS JOIN LoaiThe l "+
    "WHERE p.MaKV=@r AND p.MaLoai=@k AND l.MaThe=@c",Db.P("@r",region),Db.P("@k",kind),Db.P("@c",card));
   if(t.Rows.Count!=1)throw new Exception("Chưa có biểu phí cho lựa chọn này.");
   return new Quote {Subtotal=subtotal,Shipping=Shipping(subtotal,kind,(decimal)t.Rows[0]["Phi"]),
    CardFee=(decimal)t.Rows[0]["LePhi"]};
  }
 }

}
