using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmDangKyLe:Form {
 private readonly DangKyLeService svc=new DangKyLeService(); private readonly ChuyenLeService chuyen=new ChuyenLeService();
 public FrmDangKyLe(){InitializeComponent();}
 private void FrmDangKyLe_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnDangKy,()=>{if(FormActions.Confirm(this,"Xác nhận đã thu đủ tiền vé?")){svc.DangKy(txtSo.Text,FormActions.Value(cboChuyen),FormActions.Value(cboDB),txtTen.Text,txtPhone.Text,(int)numNguoi.Value);Tai();FormActions.Done(this);}}); FormActions.Wire(this,btnDong,()=>{Close();}); cboChuyen.SelectedIndexChanged+=(s,e)=>Tinh();numNguoi.ValueChanged+=(s,e)=>Tinh();FormActions.Bind(cboChuyen,chuyen.LayChuyenMo(),"MaChuyen","HienThi");FormActions.Bind(cboDB,new DanhMucService().Lay("DB"),"MaDiemBan","TenDiemBan");Tinh();Tai(); });
 }
 private void Tai(){MauForm.Table(dgv,svc.LayDanhSach());} private void Tinh(){var r=cboChuyen.SelectedItem as DataRowView;lblTien.Text=r==null?"-":(Convert.ToDecimal(r["DonGiaKhach"])*numNguoi.Value).ToString("N0")+" đ";}
 }
}