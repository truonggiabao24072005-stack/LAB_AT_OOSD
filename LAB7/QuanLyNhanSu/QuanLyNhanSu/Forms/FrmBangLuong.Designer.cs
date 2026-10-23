using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmBangLuong {private void InitializeComponent(){LayoutForm("Bảng lương và thống kê",new[]{"BangLuong","BangChamCong","QuyetDinh"});
Input("nam","Năm","2026");
Input("thang","Tháng","10");
Input("gio","Giờ chuẩn tháng","208");
Input("kt","Kế toán thực hiện","NV03");

Button("Tính lương toàn tháng",()=>{grid.DataSource=svc.TinhLuong((int)N("nam"),(int)N("thang"),N("gio"),S("kt"));});
Button("Thống kê theo phòng",()=>{grid.DataSource=svc.ThongKe((int)N("nam"),(int)N("thang"));});
}}}
