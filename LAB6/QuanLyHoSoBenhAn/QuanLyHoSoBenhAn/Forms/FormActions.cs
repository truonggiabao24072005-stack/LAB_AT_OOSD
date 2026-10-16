using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyHoSoBenhAn.Forms {
 internal static class FormActions {
  public static bool IsDesign {get{return LicenseManager.UsageMode==LicenseUsageMode.Designtime;}}
  public static void Run(Form f,Action action){try{f.UseWaitCursor=true;action();}catch(SqlException ex){string text=ex.Number>=51000?ex.Message:(ex.Number==2601||ex.Number==2627?"Mã hoặc chứng từ đã tồn tại.":ex.Number==547?"Dữ liệu liên kết hoặc giá trị không hợp lệ.":"Không xử lý được dữ liệu. Kiểm tra SQL Server, chạy hai script trong thư mục SQL và kiểm tra App.config.\n"+ex.Message);MessageBox.Show(f,text,"LAB6",MessageBoxButtons.OK,MessageBoxIcon.Warning);}catch(Exception ex){MessageBox.Show(f,ex.Message,"LAB6",MessageBoxButtons.OK,MessageBoxIcon.Warning);}finally{f.UseWaitCursor=false;}}
  public static void Wire(Form f,Button b,Action a){b.Click+=(s,e)=>Run(f,a);}
  public static void Bind(ComboBox c,DataTable t,string value="MaHS"){string old=Value(c);c.DataSource=null;c.ValueMember=value;c.DisplayMember="HienThi";c.DataSource=t;foreach(DataRow r in t.Rows)if(Convert.ToString(r[value])==old){c.SelectedValue=old;break;}}
  public static string Value(ComboBox c){var r=c.SelectedItem as DataRowView;return r==null?"":Convert.ToString(r[c.ValueMember]);}
  public static string Cell(DataGridView g,string col){return g.CurrentRow==null||!g.Columns.Contains(col)?"":Convert.ToString(g.CurrentRow.Cells[col].Value);}
  public static string Chon(ComboBox c){string v=Value(c);if(v=="")throw new ArgumentException("Chọn một dòng trong danh sách.");return v;}
  public static string Chon(DataGridView g,string col){string v=Cell(g,col);if(v=="")throw new ArgumentException("Chọn một dòng dữ liệu.");return v;}
  public static bool Confirm(Form f,string text){return MessageBox.Show(f,text,"Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes;}
  public static void Done(Form f,string text="Đã lưu thành công."){MessageBox.Show(f,text,"LAB6",MessageBoxButtons.OK,MessageBoxIcon.Information);}
  static readonly Dictionary<string,string> headers=new Dictionary<string,string>{{"MaHS","Mã hồ sơ"},{"MaBN","Mã bệnh nhân"},{"HoTen","Họ tên"},{"NgaySinh","Ngày sinh"},{"DienThoai","Điện thoại"},{"DiaChi","Địa chỉ"},{"NgayLap","Ngày lập"},{"MaPK","Phiếu khám"},{"NgayGio","Ngày giờ"},{"LoaiKham","Loại khám"},{"BacSi","Bác sĩ"},{"TenKhoa","Khoa"},{"TrieuChung","Triệu chứng"},{"ChanDoan","Chẩn đoán"},{"KetLuan","Kết luận"},{"TrangThai","Trạng thái"},{"MaLP","Mã lệ phí"},{"NgayThu","Ngày thu"},{"TuNgay","Từ ngày"},{"DenNgay","Đến ngày"},{"SoTien","Số tiền"},{"MaHen","Mã hẹn"},{"BatDau","Bắt đầu"},{"KetThuc","Kết thúc"},{"MaCD","Mã chỉ định"},{"TenXN","Xét nghiệm"},{"NgayChiDinh","Ngày chỉ định"},{"KetQua","Kết quả"},{"DonVi","Đơn vị"},{"NgayKetQua","Ngày kết quả"},{"MaThuoc","Mã thuốc"},{"TenThuoc","Tên thuốc"},{"SoLuong","Số lượng"},{"LieuDung","Liều dùng"},{"CachDung","Cách dùng"},{"SoNgay","Số ngày"},{"MaTT","Mã khoản thu"},{"NoiDung","Nội dung"}};
  public static void Table(DataGridView g,DataTable t){g.DataSource=t;foreach(DataGridViewColumn c in g.Columns){if(headers.ContainsKey(c.Name))c.HeaderText=headers[c.Name];c.MinimumWidth=90;if(c.ValueType==typeof(DateTime))c.DefaultCellStyle.Format="dd/MM/yyyy HH:mm";if(c.Name=="NgaySinh"||c.Name=="TuNgay"||c.Name=="DenNgay")c.DefaultCellStyle.Format="dd/MM/yyyy";if(c.ValueType==typeof(decimal)){c.DefaultCellStyle.Format="N0";c.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleRight;}}if(g.Columns.Contains("Anh"))g.Columns["Anh"].Visible=false;}
  public static void View(Form owner,string title,DataTable t){using(var f=new Form()){f.Text=title;f.Size=new Size(1100,540);f.Font=new Font("Segoe UI",9F);f.StartPosition=FormStartPosition.CenterParent;var g=new DataGridView{Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells};f.Controls.Add(g);Table(g,t);f.ShowDialog(owner);}}
 }
}
