using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmThuongPhat {private void InitializeComponent(){LayoutForm("Khen thưởng kỷ luật và chứng từ",new[]{"QuyetDinh","PhieuChi","PhieuThu"});
Input("q","Số quyết định","KT01");
Input("loai","Loại quyết định","KHENTHUONG","KHENTHUONG|KYLUAT|TUYENDUNG");
DateInput("ngay","Ngày quyết định",DateTime.Parse("2026-10-01"));
Input("nv","Mã NV cá nhân để trống nếu tập thể","NV05");
Input("pb","Mã PB tập thể để trống nếu cá nhân","");
Input("tien","Số tiền quyết định","500000");
Input("nd","Nội dung","");
Input("cach","Cách xử lý","PHIEU","PHIEU|TRULUONG");
Input("ns","Nhân sự lập","NV02");
Input("gd","Giám đốc ký","NV01");
DateInput("ky","Ngày ký",DateTime.Parse("2026-10-01"));
Input("so","Số phiếu thu hoặc chi","PC01");
DateInput("phieu","Ngày lập phiếu",DateTime.Parse("2026-10-02"));
Input("kt","Kế toán lập phiếu","NV03");

Button("Lập QĐ thưởng phạt",()=>{svc.LapQD(S("q"),S("loai"),D("ngay"),D("ngay"),S("nv"),S("pb"),null,N("tien"),0,0,S("nd"),S("cach"),S("ns"));ShowTable();});
Button("Ký QĐ theo số",()=>{svc.KyQD(S("q"),S("gd"),D("ky"));ShowTable();});
Button("Lập phiếu theo QĐ",()=>{svc.LapPhieu(S("so"),S("q"),D("phieu"),S("kt"));ShowTable();});
}}}
