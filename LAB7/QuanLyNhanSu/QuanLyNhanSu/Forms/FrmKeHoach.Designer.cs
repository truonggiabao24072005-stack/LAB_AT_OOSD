using System;using System.Collections.Generic;using System.Windows.Forms;using QuanLyNhanSu.Models;namespace QuanLyNhanSu.Forms {public partial class FrmKeHoach {private void InitializeComponent(){LayoutForm("Kế hoạch tuần và chấm công",new[]{"KeHoachTuan","ChiTietKeHoach","BangChamCong"});
Input("kh","Mã kế hoạch","KH03");
Input("pb","Mã đơn vị","PB03");
DateInput("thu","Thứ Hai đầu tuần",DateTime.Parse("2026-10-05"));
DateInput("lap","Ngày lập kế hoạch",DateTime.Parse("2026-10-02"));
Input("truong","Trưởng đơn vị lập","NV05");
Input("nv","Nhân viên chấm công","NV05");
DateInput("ngay","Ngày chấm công",DateTime.Parse("2026-10-05"));
Input("gio","Số giờ thực tế","8");
Input("bcc","Người chấm công","NV04");
AddDetails("Mã NV","Ngày dd/MM/yyyy","Mã ca","Giờ phụ trội dự kiến");details.Rows.Add("NV05","05/10/2026","CA01","2");
Button("Lưu kế hoạch",()=>{var ds=new List<DongKeHoach>();foreach(DataGridViewRow r in details.Rows)if(!r.IsNewRow)ds.Add(new DongKeHoach{MaNV=Convert.ToString(r.Cells[0].Value),Ngay=DateTime.Parse(Convert.ToString(r.Cells[1].Value)),MaCa=Convert.ToString(r.Cells[2].Value),GioPhuTroi=Convert.ToDecimal(r.Cells[3].Value)});svc.KeHoach(S("kh"),S("pb"),D("thu"),D("lap"),S("truong"),ds);ShowTable();});
Button("Ghi công thực tế",()=>{svc.ChamCong(S("nv"),D("ngay"),N("gio"),S("bcc"));ShowTable();});
}}}
