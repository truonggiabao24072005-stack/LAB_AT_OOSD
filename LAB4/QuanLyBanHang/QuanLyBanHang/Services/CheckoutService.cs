using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class CheckoutService {
  readonly Db db; readonly IProductAdapter products; readonly PaymentService payment;
  readonly PricingService pricing;
  public CheckoutService(Db d,IProductAdapter p,IPaymentAdapter a){db=d;products=p;payment=new PaymentService(a);pricing=new PricingService(d);}
  public static void ValidateCard(CardInput x,DateTime today){PaymentService.ValidateCard(x,today);}
  public Quote Preview(Cart cart,string region,string kind,string card){
   if(cart.Lines.Count==0)throw new Exception("Giỏ hàng đang trống.");
   decimal total=0;
   foreach(var x in cart.Lines){var p=products.Get(x.Code);
    if(p.Price<0)throw new Exception("Giá sản phẩm không hợp lệ.");
    if(!p.Available)throw new Exception("Sản phẩm đã hết hàng: "+p.Name);
    if(x.Quantity<1||x.Quantity>1000)throw new Exception("Số lượng không hợp lệ.");
    x.Name=p.Name;x.UnitPrice=p.Price;total+=x.Total;}
   if(total<=0)throw new Exception("Tổng tiền hàng phải lớn hơn 0.");
   return pricing.Calculate(total,region,kind,card);
  }

  static readonly object SubmitGate=new object();
  public CheckoutResult Submit(Customer customer,Cart cart,string name,string address,string phone,string region,string kind,CardInput card,Guid key,decimal acceptedTotal,string scenario){
   lock(SubmitGate){return SubmitCore(customer,cart,name,address,phone,region,kind,card,key,acceptedTotal,scenario);}
  }
  private CheckoutResult SubmitCore(Customer customer,Cart cart,string name,string address,
    string phone,string region,string kind,CardInput card,Guid key,
    decimal acceptedTotal,string scenario){
   if(customer==null)throw new Exception("Cần đăng nhập trước khi đặt hàng.");
   var existing=db.Query("SELECT d.MaDH,d.MaKH,d.TrangThai,d.TongTien FROM DonHang d "+
    "JOIN ThanhToan t ON t.MaDH=d.MaDH WHERE t.RequestKey=@k",Db.P("@k",key));
   if(existing.Rows.Count>0){var e=existing.Rows[0];
    if((int)e["MaKH"]!=customer.Id)throw new Exception("Yêu cầu không thuộc khách hàng hiện tại.");
    return new CheckoutResult {OrderId=(Guid)e["MaDH"],State=(string)e["TrangThai"],Total=(decimal)e["TongTien"]};}
   if(string.IsNullOrWhiteSpace(name)||string.IsNullOrWhiteSpace(address)||string.IsNullOrWhiteSpace(phone))
    throw new Exception("Vui lòng nhập đủ tên, địa chỉ và điện thoại người nhận.");
   ValidateCard(card,DateTime.Today);
   var quote=Preview(cart,region,kind,card.Type);
   if(quote.Total!=acceptedTotal)throw new Exception("Giá đã thay đổi. Vui lòng tính lại và xác nhận tổng mới.");
   var profile=db.Query("SELECT HoTen,Email FROM KhachHang WHERE MaKH=@c",Db.P("@c",customer.Id));
   if(profile.Rows.Count!=1)throw new Exception("Tài khoản không còn tồn tại.");
   customer.Name=(string)profile.Rows[0]["HoTen"];customer.Email=profile.Rows[0]["Email"]==DBNull.Value?null:(string)profile.Rows[0]["Email"];
   Guid id=Guid.NewGuid();
   using(var c=db.Open())using(var tx=c.BeginTransaction()){
    try{
     using(var lk=Db.Cmd(c,tx,"DECLARE @r int; EXEC @r=sys.sp_getapplock @Resource=@resource,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000; IF @r<0 THROW 50001,N'Hệ thống đang bận, vui lòng thử lại.',1;",Db.P("@resource","eShop.Customer."+customer.Id)))lk.ExecuteNonQuery();
     using(var check=Db.Cmd(c,tx,"SELECT d.MaDH,d.TrangThai,d.TongTien FROM DonHang d JOIN ThanhToan p ON p.MaDH=d.MaDH WHERE p.RequestKey=@k AND d.MaKH=@c",Db.P("@k",key),Db.P("@c",customer.Id))) {
      CheckoutResult saved=null;
      using(var rd=check.ExecuteReader())if(rd.Read())saved=new CheckoutResult {OrderId=(Guid)rd[0],State=(string)rd[1],Total=(decimal)rd[2]};
      if(saved!=null){tx.Commit();return saved;}
     }
     using(var check=Db.Cmd(c,tx,"SELECT COUNT(*) FROM DonHang WHERE MaKH=@c AND TrangThai IN ('CHO_THANH_TOAN','CHO_DOI_SOAT')",Db.P("@c",customer.Id)))
      if(Convert.ToInt32(check.ExecuteScalar())>0)throw new Exception("Bạn có đơn chưa rõ kết quả thanh toán. Mở Đơn hàng của tôi và đối soát trước khi đặt đơn mới.");
     using(var q=Db.Cmd(c,tx,"INSERT DonHang(MaDH,MaKH,NguoiMua,EmailXacNhan,TenNguoiNhan,DiaChiNhan,DienThoaiNhan,MaKV,MaLoai,TienHang,PhiGiao,LePhiThe,TrangThai) "+
      "VALUES(@d,@c,@b,@e,@n,@a,@p,@r,@k,@s,@f,@l,'CHO_THANH_TOAN')",
      Db.P("@d",id),Db.P("@c",customer.Id),Db.P("@b",customer.Name),Db.P("@e",customer.Email),
      Db.P("@n",name),Db.P("@a",address),Db.P("@p",phone),Db.P("@r",region),Db.P("@k",kind),
      Db.P("@s",quote.Subtotal),Db.P("@f",quote.Shipping),Db.P("@l",quote.CardFee)))q.ExecuteNonQuery();
     foreach(var x in cart.Lines)using(var q=Db.Cmd(c,tx,
      "INSERT ChiTietDonHang(MaDH,MaSP,TenSP,SoLuong,DonGia) VALUES(@d,@p,@n,@s,@g)",Db.P("@d",id),Db.P("@p",x.Code),
      Db.P("@n",x.Name),Db.P("@s",x.Quantity),Db.P("@g",x.UnitPrice)))q.ExecuteNonQuery();
     using(var q=Db.Cmd(c,tx,"INSERT ThanhToan(MaDH,RequestKey,MaThe,Last4,TrangThai) VALUES(@d,@k,@t,@l,'PENDING')",
      Db.P("@d",id),Db.P("@k",key),Db.P("@t",card.Type),Db.P("@l",card.Number.Substring(card.Number.Length-4))))q.ExecuteNonQuery();
     tx.Commit();
    }catch{tx.Rollback();throw;}
   }
   PaymentReply reply;
   try{reply=payment.Pay(key,quote.Total,card,scenario);}
   catch{reply=new PaymentReply {State="UNKNOWN"};}
   string state=Finalize(id,reply);
   if(state=="DA_XAC_NHAN")cart.Lines.Clear();
   return new CheckoutResult {OrderId=id,State=state,Total=quote.Total};
  }
  public string Reconcile(Guid id,int customerId){
   var t=db.Query("SELECT t.RequestKey FROM ThanhToan t JOIN DonHang d ON d.MaDH=t.MaDH "+
    "WHERE d.MaDH=@d AND d.MaKH=@c AND d.TrangThai IN ('CHO_DOI_SOAT','CHO_THANH_TOAN')",Db.P("@d",id),Db.P("@c",customerId));
   if(t.Rows.Count!=1)throw new Exception("Đơn không ở trạng thái chờ đối soát.");
   return Finalize(id,payment.Query((Guid)t.Rows[0][0]));
  }
  string Finalize(Guid id,PaymentReply reply){
   var state=reply.State=="APPROVED"?"DA_XAC_NHAN":reply.State=="DECLINED"?"THANH_TOAN_TU_CHOI":"CHO_DOI_SOAT";
   using(var c=db.Open())using(var tx=c.BeginTransaction()){
    try{
     using(var q=Db.Cmd(c,tx,"UPDATE DonHang SET TrangThai=@s,NgayXacNhan=CASE WHEN @s='DA_XAC_NHAN' THEN SYSDATETIME() ELSE NULL END "+
      "WHERE MaDH=@d AND TrangThai IN ('CHO_THANH_TOAN','CHO_DOI_SOAT')",Db.P("@s",state),Db.P("@d",id))){
      if(q.ExecuteNonQuery()==0){tx.Rollback();return (string)db.Query("SELECT TrangThai FROM DonHang WHERE MaDH=@d",Db.P("@d",id)).Rows[0][0];}}
     using(var q=Db.Cmd(c,tx,"UPDATE ThanhToan SET TrangThai=@s,ProviderRef=@r,PaymentToken=@t WHERE MaDH=@d",
      Db.P("@s",reply.State),Db.P("@r",reply.Reference),Db.P("@t",reply.Token),Db.P("@d",id)))q.ExecuteNonQuery();
     if(state=="DA_XAC_NHAN"){
      var message=new StringBuilder();
      using(var q=Db.Cmd(c,tx,"SELECT * FROM DonHang WHERE MaDH=@d",Db.P("@d",id)))using(var rd=q.ExecuteReader()){
       rd.Read();message.AppendLine("Xác nhận đơn hàng "+id);
       message.AppendLine("Người mua: "+rd["NguoiMua"]+"; Người nhận: "+rd["TenNguoiNhan"]);
       message.AppendLine("Địa chỉ: "+rd["DiaChiNhan"]+"; Điện thoại: "+rd["DienThoaiNhan"]);
       message.AppendLine("Giao hàng: "+rd["MaLoai"]+"; Khu vực: "+rd["MaKV"]);
       message.AppendLine("Tiền hàng: "+rd["TienHang"]+"; Phí giao: "+rd["PhiGiao"]+"; Lệ phí thẻ: "+rd["LePhiThe"]);
       message.AppendLine("Tổng tiền: "+rd["TongTien"]+"; Thời điểm: "+rd["NgayXacNhan"]);}
      using(var q=Db.Cmd(c,tx,"SELECT TenSP,SoLuong,DonGia FROM ChiTietDonHang WHERE MaDH=@d",Db.P("@d",id)))
       using(var rd=q.ExecuteReader())while(rd.Read())message.AppendLine(rd[0]+" x "+rd[1]+"; Đơn giá "+rd[2]);
      using(var q=Db.Cmd(c,tx,"INSERT EmailOutbox(MaDH,DiaChi,NoiDung) SELECT MaDH,EmailXacNhan,@m FROM DonHang "+
       "WHERE MaDH=@d AND EmailXacNhan IS NOT NULL",Db.P("@d",id),Db.P("@m",message.ToString())))q.ExecuteNonQuery();
     }
     tx.Commit();return state;
    }catch{tx.Rollback();throw;}
   }
  }
 }

}
