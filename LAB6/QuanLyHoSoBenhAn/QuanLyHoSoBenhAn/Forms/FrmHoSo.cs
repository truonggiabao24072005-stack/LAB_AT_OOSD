using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmHoSo:Form {
 public FrmHoSo(){InitializeComponent();}
 private readonly HoSoService svc=new HoSoService();private string anh;
 private void FrmHoSo_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;
 dtSinh.Value=new DateTime(2000,1,1);dtSinh.MaxDate=DateTime.Today;dtTu.Value=DateTime.Today;dtDen.Value=DateTime.Today.AddYears(1).AddDays(-1);numTien.Value=500000;txtPhone.MaxLength=20;txtTen.MaxLength=100;txtDiaChi.MaxLength=250;
 FormActions.Wire(this,btnTim,Tai);FormActions.Wire(this,btnMoi,()=>{txtTen.Clear();txtDiaChi.Clear();txtPhone.Clear();chkThu.Checked=false;anh=null;if(picAnh.Image!=null){picAnh.Image.Dispose();picAnh.Image=null;}txtTen.Focus();});
 FormActions.Wire(this,btnAnh,()=>{using(var d=new OpenFileDialog()){d.Filter="Ảnh|*.jpg;*.jpeg;*.png;*.bmp";if(d.ShowDialog(this)==DialogResult.OK){using(var img=Image.FromFile(d.FileName)){var old=picAnh.Image;picAnh.Image=new Bitmap(img);if(old!=null)old.Dispose();}anh=d.FileName;}}});
 FormActions.Wire(this,btnDangKy,()=>{Input.Require(chkThu.Checked,"Cần xác nhận đã thu lệ phí.");string hs=svc.DangKy(new DangKyInput{HoTen=txtTen.Text,DiaChi=txtDiaChi.Text,DienThoai=txtPhone.Text,Anh=anh,NgaySinh=dtSinh.Value,TuNgay=dtTu.Value,DenNgay=dtDen.Value,SoTien=numTien.Value});txtTim.Text=hs;Tai();chkThu.Checked=false;FormActions.Done(this,"Đã cấp hồ sơ: "+hs);});
 FormActions.Wire(this,btnLichSu,()=>FormActions.View(this,"Lịch sử khám của hồ sơ",svc.LichSu(FormActions.Chon(dgv,"MaHS"))));btnDong.Click+=(s,a)=>Close();FormActions.Run(this,Tai);}
 private void Tai(){FormActions.Table(dgv,svc.TraCuu(txtTim.Text));}
 protected override void OnFormClosed(FormClosedEventArgs e){if(picAnh.Image!=null)picAnh.Image.Dispose();base.OnFormClosed(e);}
}
}
