using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms
{
    internal static class FormActions
    {
        public static bool IsDesign {get{return System.ComponentModel.LicenseManager.UsageMode==System.ComponentModel.LicenseUsageMode.Designtime;}}
        public static void Fit(Form f) {var b=Screen.FromControl(f).WorkingArea;f.MinimumSize=new Size(760,520);f.AutoScroll=true;f.AutoScrollMinSize=f.ClientSize;f.Size=new Size(Math.Min(f.Width,b.Width-20),Math.Min(f.Height,b.Height-20));f.Shown+=(sender,args)=>f.BeginInvoke(new Action(()=>f.AutoScrollPosition=Point.Empty));}
        public static void Run(Form f,Action a)
        {
            try{a();}
            catch(SqlException ex){if(Environment.GetEnvironmentVariable("LAB5_TEST_MODE")=="1")throw;string message=ex.Number==2627||ex.Number==2601?"Mã, thứ tự hoặc phiếu đã tồn tại; mỗi chuyến chỉ một HDV và mỗi đăng ký chỉ một khảo sát.":ex.Number==547?"Dữ liệu liên quan đang được sử dụng hoặc vi phạm ràng buộc. Kiểm tra danh mục và giá trị nhập.":ex.Number==51000?ex.Message:"Không truy cập được dữ liệu. Kiểm tra SQL Server và App.config; chạy hai file SQL trước.\n"+ex.Message;MessageBox.Show(f,message,"LAB5",MessageBoxButtons.OK,MessageBoxIcon.Warning);}
            catch(Exception ex){if(Environment.GetEnvironmentVariable("LAB5_TEST_MODE")=="1")throw;MessageBox.Show(f,ex.Message,"LAB5",MessageBoxButtons.OK,MessageBoxIcon.Warning);}
        }
        public static void Wire(Form f,Button b,Action a) {b.Click+=(s,e)=>{b.Enabled=false;try{Run(f,a);}finally{b.Enabled=true;}};}
        public static void Done(Form f) {MessageBox.Show(f,"Đã lưu thành công.","LAB5",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        public static bool Confirm(Form f,string text) {return MessageBox.Show(f,text,"Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes;}
        public static void Bind(ComboBox c,DataTable t,string value,string display) {c.DataSource=null;c.ValueMember=value;c.DisplayMember=display;c.DataSource=t;}
        public static string Value(ComboBox c) {var r=c.SelectedItem as DataRowView;return r==null?"":Convert.ToString(r[c.ValueMember]);}
        public static string Cell(DataGridView g,string name) {return g.CurrentRow==null||!g.Columns.Contains(name)?"":Convert.ToString(g.CurrentRow.Cells[name].Value);}
        public static int IntCell(DataGridView g,string name) {var s=Cell(g,name);QuyDinh.Require(s!="","Chọn một dòng dữ liệu.");return Convert.ToInt32(s);}
        public static void ClearText(Control owner) {foreach(Control c in owner.Controls){var t=c as TextBox;if(t!=null)t.Clear();else ClearText(c);}}
        private static readonly System.Collections.Generic.Dictionary<string,string> Headers=new System.Collections.Generic.Dictionary<string,string>{
 {"MaTour","Mã tour"},{"TenTour","Tên tour"},{"SoNgay","Số ngày"},{"SoDem","Số đêm"},{"DonGiaKhach","Đơn giá / khách"},{"MoTa","Mô tả"},{"DangMoBan","Mở bán"},
 {"MaPT","Mã phương tiện"},{"TenPT","Phương tiện"},{"GhiChu","Ghi chú"},{"MaDiemTQ","Mã điểm"},{"TenDiemTQ","Điểm tham quan"},{"DiaDiem","Địa điểm"},{"NoiDung","Nội dung"},{"YNghia","Ý nghĩa"},
 {"MaDiemBan","Mã điểm bán"},{"TenDiemBan","Điểm bán"},{"DiaChi","Địa chỉ"},{"DienThoai","Điện thoại"},{"MaHDV","Mã HDV"},{"HoTen","Họ tên"},{"LuongCoBan","Lương cơ bản"},{"DangLamViec","Đang làm việc"},
 {"ThuTu","Thứ tự"},{"TenDiemDung","Điểm dừng"},{"DoiPhuongTien","Đổi phương tiện"},{"CoNoiAn","Có nơi ăn"},{"CoKhachSan","Có khách sạn"},{"HangSaoKhachSan","Hạng sao"},{"ThuTuChang","Chặng"},
 {"MaChuyen","Mã chuyến"},{"NgayDi","Ngày đi"},{"NgayVe","Ngày về"},{"DiaDiemDon","Nơi đón"},{"TrangThai","Trạng thái"},{"MaDoan","Mã đoàn"},{"TenCoQuanDaiDien","Cơ quan / gia đình"},{"NguoiDaiDien","Người đại diện"},
 {"SoDKDoan","Phiếu đoàn"},{"SoDKLe","Phiếu lẻ"},{"NgayDangKy","Ngày đăng ký"},{"NgayKetThucDuKien","Ngày kết thúc"},{"SoNguoi","Số người"},{"MuaBaoHiem","Bảo hiểm"},{"TienCoc","Tiền cọc"},{"DaThanhToanCoc","Đã thu cọc"},{"TongTienDuKien","Tổng dự kiến"},
 {"DaThanhToanSauTour","Đã trả sau tour"},{"ConLai","Còn phải trả"},{"TenNguoiDangKy","Người đăng ký"},{"ThanhTien","Tiền vé"},{"DaThanhToan","Đã thu"},{"MaPC","Mã phân công"},{"LoaiDoiTuong","Loại"},{"NgayBatDau","Bắt đầu"},{"NgayKetThuc","Kết thúc"},{"ThuLaoTour","Thù lao tour"},
 {"SoTT","Mã thanh toán"},{"NgayThanhToan","Ngày thanh toán"},{"SoTien","Số tiền"},{"MaKhaoSat","Mã khảo sát"},{"LoaiKhach","Loại khách"},{"NgayGui","Ngày gửi"},{"NgayPhanHoi","Ngày phản hồi"},{"DiemDanhGia","Điểm"},{"GopY","Góp ý"},
 {"SoTour","Số tour"},{"LuongTour","Lương tour"},{"TongLuong","Tổng lương"},{"ChiTieu","Chỉ tiêu"},{"SoLuong","Số lượng"},{"NgaySinh","Ngày sinh"},{"SoGiayTo","Giấy tờ"}
 };
 public static void Table(DataGridView g,DataTable t)
        {
            g.DataSource=t;
            foreach(DataGridViewColumn c in g.Columns)
            {
                if(Headers.ContainsKey(c.Name))c.HeaderText=Headers[c.Name];
                if(c.ValueType==typeof(decimal)){c.DefaultCellStyle.Format="N0";c.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleRight;}
                if(c.ValueType==typeof(DateTime))c.DefaultCellStyle.Format="dd/MM/yyyy";
                c.MinimumWidth=85;
            }
        }
        public static void View(Form owner,string title,DataTable t)
        {
            using(var f=new Form()){f.Text=title;f.Size=new Size(850,500);f.StartPosition=FormStartPosition.CenterParent;
                var g=new DataGridView{Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};f.Controls.Add(g);Table(g,t);f.ShowDialog(owner);}
        }
    }
}
