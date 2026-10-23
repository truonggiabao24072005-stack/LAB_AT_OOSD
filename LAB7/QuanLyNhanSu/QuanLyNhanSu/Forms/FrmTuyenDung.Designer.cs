using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmTuyenDung {private void InitializeComponent(){LayoutForm("Tuyển dụng và thử việc",new[]{"NhanVien","QuyetDinh"});
Input("nv","Mã nhân viên","NV07");
Input("ten","Họ tên","");
DateInput("sinh","Ngày sinh",DateTime.Parse("2000-01-01"));
Input("pb","Phòng ban nhận thử việc","PB03");
Input("qd","Số quyết định tuyển dụng","TD07");
DateInput("tu","Bắt đầu thử việc",DateTime.Parse("2026-10-01"));
DateInput("den","Kết thúc thử việc",DateTime.Parse("2026-11-30"));
Input("luong","Lương thử việc","6000000");
Input("nd","Điều khoản hai bên","");
Input("ns","Nhân sự thực hiện","NV02");
Input("kq","Kết quả thử việc","DAT","DAT|KHONGDAT");
DateInput("ngay","Ngày ghi kết quả",DateTime.Parse("2026-12-01"));

Button("Tiếp nhận và lập QĐ",()=>{svc.TuyenDung(S("nv"),S("ten"),D("sinh"),S("pb"),S("qd"),D("tu"),D("den"),N("luong"),S("nd"),S("ns"));ShowTable();});
Button("Ghi kết quả",()=>{svc.KetQua(S("nv"),S("kq")=="DAT",D("ngay"),S("ns"));ShowTable();});
}}}
