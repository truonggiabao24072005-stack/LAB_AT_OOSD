using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class OrderService {
  public static string StateLabel(string state){return state=="DA_XAC_NHAN"?"Đặt hàng thành công":state=="THANH_TOAN_TU_CHOI"?"Thanh toán bị từ chối. Có thể đặt lại.":state=="CHO_DOI_SOAT"?"Thanh toán chưa rõ kết quả. Vui lòng đối soát.":"Đang chờ thanh toán. Vui lòng đối soát.";}
  public string State(Guid id,int customer){var t=db.Query("SELECT TrangThai FROM DonHang WHERE MaDH=@d AND MaKH=@c",Db.P("@d",id),Db.P("@c",customer));if(t.Rows.Count!=1)throw new Exception("Không tìm thấy đơn của bạn.");return (string)t.Rows[0][0];}
  public CheckoutResult ByRequest(Guid key,int customer){var t=db.Query("SELECT d.MaDH,d.TrangThai,d.TongTien FROM DonHang d JOIN ThanhToan p ON p.MaDH=d.MaDH WHERE p.RequestKey=@k AND d.MaKH=@c",Db.P("@k",key),Db.P("@c",customer));if(t.Rows.Count==0)return null;var r=t.Rows[0];return new CheckoutResult {OrderId=(Guid)r[0],State=(string)r[1],Total=(decimal)r[2]};}
  public string EmailBody(Guid id,int customer){var t=db.Query("SELECT e.NoiDung FROM EmailOutbox e JOIN DonHang d ON d.MaDH=e.MaDH WHERE d.MaDH=@d AND d.MaKH=@c",Db.P("@d",id),Db.P("@c",customer));return t.Rows.Count==0?null:(string)t.Rows[0][0];}
  public string Info(Guid id,int customer){var t=db.Query("SELECT d.*,k.TenKV,l.TenLoai FROM DonHang d JOIN KhuVuc k ON k.MaKV=d.MaKV JOIN LoaiGiaoHang l ON l.MaLoai=d.MaLoai WHERE d.MaDH=@d AND d.MaKH=@c",Db.P("@d",id),Db.P("@c",customer));if(t.Rows.Count==0)return "";var r=t.Rows[0];return "Người mua: "+r["NguoiMua"]+" | Người nhận: "+r["TenNguoiNhan"]+" | Điện thoại: "+r["DienThoaiNhan"]+"\nĐịa chỉ: "+r["DiaChiNhan"]+" | "+r["TenKV"]+" | "+r["TenLoai"]+"\nTiền hàng: "+((decimal)r["TienHang"]).ToString("N0")+"đ | Phí giao: "+((decimal)r["PhiGiao"]).ToString("N0")+"đ | Lệ phí thẻ: "+((decimal)r["LePhiThe"]).ToString("N0")+"đ";}

  readonly Db db;public OrderService(Db d){db=d;}
  public DataTable List(int id){return db.Query("SELECT d.MaDH,d.NgayTao,d.TrangThai,d.TongTien,  CASE d.TrangThai WHEN 'DA_XAC_NHAN' THEN N'Đã xác nhận' WHEN 'THANH_TOAN_TU_CHOI' THEN N'Thanh toán bị từ chối' WHEN 'CHO_DOI_SOAT' THEN N'Chờ đối soát' ELSE N'Chờ thanh toán' END AS TenTrangThai,  CASE WHEN e.TrangThai='SENT' THEN N'Đã gửi' WHEN e.TrangThai='FAILED' THEN N'Gửi lỗi' WHEN e.TrangThai='PENDING' THEN N'Chờ gửi' ELSE N'Không có' END AS EmailStatus  FROM DonHang d LEFT JOIN EmailOutbox e ON e.MaDH=d.MaDH WHERE d.MaKH=@c ORDER BY d.NgayTao DESC",Db.P("@c",id));}
  public DataTable Detail(Guid id,int customer){return db.Query("SELECT x.MaSP,x.TenSP,x.SoLuong,x.DonGia,x.ThanhTien FROM ChiTietDonHang x "+
   "JOIN DonHang d ON d.MaDH=x.MaDH WHERE x.MaDH=@d AND d.MaKH=@c",Db.P("@d",id),Db.P("@c",customer));}
 }

}
