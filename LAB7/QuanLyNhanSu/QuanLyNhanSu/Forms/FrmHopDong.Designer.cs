using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmHopDong {private void InitializeComponent(){LayoutForm("Hợp đồng và bảo hiểm",new[]{"HopDong","BaoHiem","NhanVien"});
Input("hd","Số hợp đồng","HD06");
Input("nv","Mã nhân viên","NV06");
Input("loai","Loại hợp đồng","DAIHAN","DAIHAN|NGANHAN");
DateInput("tu","Ngày bắt đầu",DateTime.Parse("2026-10-01"));
Input("den","Ngày kết thúc dd/MM/yyyy để trống nếu vô hạn","");
Input("yt","Mức đóng BHYT mỗi tháng","135000");
Input("xh","Mức đóng BHXH mỗi tháng","720000");
Input("ns","Nhân sự thực hiện","NV02");

Button("Ký hợp đồng và lập BH",()=>{DateTime? end=string.IsNullOrWhiteSpace(S("den"))?(DateTime?)null:DateTime.ParseExact(S("den"),"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);svc.HopDong(S("hd"),S("nv"),S("loai"),D("tu"),end,N("yt"),N("xh"),S("ns"));ShowTable();});
}}}
