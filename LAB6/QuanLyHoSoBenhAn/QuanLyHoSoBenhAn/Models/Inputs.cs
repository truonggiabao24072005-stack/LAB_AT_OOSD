using System;
using System.Data;
namespace QuanLyHoSoBenhAn.Models {
 public static class Input {
  public static string Id(string prefix){return prefix+Guid.NewGuid().ToString("N").Substring(0,20-prefix.Length).ToUpperInvariant();}
  public static void Require(bool ok,string message){if(!ok)throw new ArgumentException(message);}
  public static string Text(string value,string name,int max){value=(value??"").Trim();Require(value.Length>0&&value.Length<=max,"Kiểm tra "+name+" (1–"+max+" ký tự).");return value;}
  public static string Optional(string value){return string.IsNullOrWhiteSpace(value)?null:value.Trim();}
  public static DataTable DongToa(){var t=new DataTable();t.Columns.Add("STT",typeof(int));t.Columns.Add("MaThuoc",typeof(string));t.Columns.Add("SoLuong",typeof(int));t.Columns.Add("LieuDung",typeof(string));t.Columns.Add("CachDung",typeof(string));t.Columns.Add("SoNgay",typeof(int));return t;}
 }
 public sealed class DangKyInput {
  public string HoTen,DiaChi,DienThoai,Anh;public DateTime NgaySinh,TuNgay,DenNgay;public decimal SoTien;
 }
}
