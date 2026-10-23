using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmQuyetDinh {private void InitializeComponent(){LayoutForm("Quyết định lương và chức vụ",new[]{"QuyetDinh","ChucVu"});
Input("q","Số quyết định","QD07");
Input("loai","Loại quyết định","LUONG","LUONG|CHUCVU");
DateInput("ngay","Ngày quyết định",DateTime.Parse("2026-10-01"));
DateInput("hl","Ngày hiệu lực",DateTime.Parse("2026-10-01"));
Input("nv","Mã nhân viên","NV06");
Input("cv","Mã chức vụ nếu bổ nhiệm","CV03");
Input("tien","Lương cơ bản hoặc phụ cấp chức vụ","9000000");
Input("pc","Phụ cấp lương","0");
Input("dh","Phụ cấp độc hại","0");
Input("nd","Nội dung quyết định","");
Input("ns","Nhân sự thực hiện","NV02");
Input("gd","Giám đốc ký","NV01");
DateInput("ky","Ngày ký",DateTime.Parse("2026-10-01"));

Button("Lập quyết định",()=>{svc.LapQD(S("q"),S("loai"),D("ngay"),D("hl"),S("nv"),"",S("cv"),N("tien"),N("pc"),N("dh"),S("nd"),"PHIEU",S("ns"));ShowTable();});
Button("Ký quyết định",()=>{svc.KyQD(S("q"),S("gd"),D("ky"));ShowTable();});
}}}
