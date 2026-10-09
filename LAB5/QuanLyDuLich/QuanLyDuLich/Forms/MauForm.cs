using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyDuLich.Forms
{
    internal static class MauForm
    {
        public static void Table(DataGridView grid,DataTable table)
        {
            table=table.Copy();
            if(table.Columns.Contains("MaPC")){
                table.Columns.Add("DoiTuong",typeof(string));
                foreach(DataRow r in table.Rows)r["DoiTuong"]=r.IsNull("MaChuyen")?r["SoDKDoan"]:r["MaChuyen"];
            }
            if(table.Columns.Contains("MaKhaoSat")){
                table.Columns.Add("SoDangKy",typeof(string));
                foreach(DataRow r in table.Rows)r["SoDangKy"]=r.IsNull("SoDKLe")?r["SoDKDoan"]:r["SoDKLe"];
            }
            string[] wanted=null;
            if(table.Columns.Contains("MaPC"))wanted=new[]{"MaPC","MaHDV","HoTen","LoaiDoiTuong","DoiTuong","NgayBatDau","NgayKetThuc","ThuLaoTour"};
            else if(table.Columns.Contains("MaKhaoSat"))wanted=new[]{"MaKhaoSat","LoaiKhach","SoDangKy","NgayGui","NgayPhanHoi","DiemDanhGia","GopY"};
            else if(table.Columns.Contains("SoDKLe"))wanted=new[]{"SoDKLe","MaChuyen","TenTour","NgayDi","MaDiemBan","TenNguoiDangKy","SoNguoi","ThanhTien","TrangThai"};
            else if(table.Columns.Contains("SoDKDoan") && table.Columns.Contains("SoNguoi"))wanted=new[]{"SoDKDoan","TenCoQuanDaiDien","TenTour","NgayDi","NgayKetThucDuKien","SoNguoi","MuaBaoHiem","TienCoc","TongTienDuKien","TrangThai"};
            else if(table.Columns.Contains("MaChuyen"))wanted=new[]{"MaChuyen","MaTour","TenTour","NgayDi","NgayVe","DiaDiemDon","TrangThai"};
            else if(table.Columns.Contains("ThuTuChang"))wanted=new[]{"ThuTuChang","TenPT","MaPT","GhiChu"};
            else if(table.Columns.Contains("TenDiemDung"))wanted=new[]{"ThuTu","TenDiemDung","DoiPhuongTien","CoNoiAn","CoKhachSan","HangSaoKhachSan","GhiChu"};
            else if(table.Columns.Contains("ThuTu") && table.Columns.Contains("MaDiemTQ"))wanted=new[]{"ThuTu","MaDiemTQ","TenDiemTQ"};
            if(wanted!=null)table=table.DefaultView.ToTable(false,wanted);
            grid.DataSource=table;
            foreach(DataGridViewColumn c in grid.Columns)
            {
                c.HeaderText=c.Name;c.MinimumWidth=65;
                if(c.ValueType==typeof(DateTime))c.DefaultCellStyle.Format="dd/MM/yyyy";
                if(c.ValueType==typeof(decimal))c.DefaultCellStyle.Format="0.##";
            }
        }
    }
}
