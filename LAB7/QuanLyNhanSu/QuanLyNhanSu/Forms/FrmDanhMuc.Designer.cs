using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmDanhMuc {private void InitializeComponent(){LayoutForm("Danh mục tổ chức",new[]{"PhongBan","ChucVu","CaLamViec","NhanVien"});
Input("loai","Loại danh mục","PhongBan","PhongBan|ChucVu|CaLamViec");
Input("ma","Mã danh mục","");
Input("ten","Tên danh mục","");
Input("so","Phụ cấp chức vụ hoặc số giờ ca","0");

Button("Thêm mới",()=>{svc.DanhMuc(S("loai"),S("ma"),S("ten"),N("so"));ShowTable();});
}}}
