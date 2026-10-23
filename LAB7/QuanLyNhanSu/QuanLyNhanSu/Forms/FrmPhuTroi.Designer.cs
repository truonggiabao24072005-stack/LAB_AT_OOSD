using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmPhuTroi {private void InitializeComponent(){LayoutForm("Phiếu ghi nhận giờ phụ trội",new[]{"PhieuPhuTroi","ChiTietPhuTroi"});
Input("so","Số phiếu phụ trội","PT01");
DateInput("ngay","Ngày phụ trội",DateTime.Parse("2026-10-05"));
Input("hinh","Hình thức","TANGCA","TANGCA|NGAYLE|NGAYNGHI");
Input("gio","Số giờ tối đa trên phiếu","2");
Input("bcc","Người lập thuộc ban chấm công","NV04");
AddDetails("Mã NV","Số giờ tham gia");details.Rows.Add("NV05","2");
Button("Lưu phiếu và chi tiết",()=>{var ds=new List<DongPhuTroi>();foreach(DataGridViewRow r in details.Rows)if(!r.IsNewRow)ds.Add(new DongPhuTroi{MaNV=Convert.ToString(r.Cells[0].Value),SoGio=Convert.ToDecimal(r.Cells[1].Value)});svc.PhuTroi(S("so"),D("ngay"),S("hinh"),N("gio"),S("bcc"),ds);ShowTable();});
}}}
