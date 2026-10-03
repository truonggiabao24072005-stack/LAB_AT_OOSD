using System.Data;
namespace QuanLyBanHang {
 public class LookupService {
  readonly Db db;public LookupService(Db d){db=d;}
  public DataTable Regions(){return db.Query("SELECT MaKV,TenKV FROM KhuVuc ORDER BY MaKV DESC");}
  public DataTable Shipping(){return db.Query("SELECT MaLoai,TenLoai + N' ('+ThoiGianDuKien+N')' AS TenLoai FROM LoaiGiaoHang ORDER BY CASE MaLoai WHEN 'THUONG' THEN 1 WHEN 'NHANH' THEN 2 ELSE 3 END");}
  public DataTable Cards(){return db.Query("SELECT MaThe,TenThe FROM LoaiThe ORDER BY CASE MaThe WHEN 'VISA' THEN 1 WHEN 'MASTER' THEN 2 WHEN 'DISCOVER' THEN 3 ELSE 4 END");}
 }
}
