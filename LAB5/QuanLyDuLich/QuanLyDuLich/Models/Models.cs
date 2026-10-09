using System;
using System.Data;
using System.Globalization;
namespace QuanLyDuLich.Models
{
    public sealed class DangKyDoanInput
    {
        public string SoDKDoan, MaDoan, TenDoan, DiaChi, DienThoai, DaiDien, MaTour, NoiDon;
        public DateTime NgayDi;
        public int SoNguoi;
        public bool BaoHiem;
        public decimal TienCoc;
        public DataTable ThanhVien;
    }
    public static class QuyDinh
    {
        public static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
        public static string Text(string value, string label, int max)
        { value = (value ?? "").Trim(); Require(value.Length > 0, "Nhập " + label + "."); Require(value.Length <= max, label + " tối đa " + max + " ký tự."); return value; }
        public static string Ma(string value)
        {
            value = Text(value, "mã / số phiếu", 20).ToUpperInvariant();
            foreach (char c in value) Require(c >= 'A' && c <= 'Z' || c >= '0' && c <= '9' || c == '_' || c == '-', "Mã chỉ dùng chữ A-Z, số, dấu _ hoặc -.");
            return value;
        }
        public static string TuyChon(string value, int max)
        { value = (value ?? "").Trim(); Require(value.Length <= max, "Nội dung tối đa " + max + " ký tự."); return value; }
        public static DataTable BangThanhVien()
        {
            var t = new DataTable(); t.Columns.Add("STT", typeof(int)); t.Columns.Add("HoTen", typeof(string));
            t.Columns.Add("NgaySinh", typeof(DateTime)); t.Columns.Add("SoGiayTo", typeof(string)); return t;
        }
        public static DateTime? NgaySinh(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            DateTime d; Require(DateTime.TryParseExact(value.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d), "Ngày sinh nhập dạng dd/MM/yyyy.");
            Require(d <= DateTime.Today, "Ngày sinh không ở tương lai."); return d;
        }
    }
}
