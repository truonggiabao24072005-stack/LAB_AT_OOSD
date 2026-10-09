using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmHuongDanVien : Form {
 private readonly DanhMucService svc = new DanhMucService();
 public FrmHuongDanVien() { InitializeComponent(); }
 private void FrmHuongDanVien_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnNew,()=>{txtMa.ReadOnly=false;FormActions.ClearText(this);dgv.ClearSelection();});
FormActions.Wire(this,btnAdd,()=>{svc.LuuHDV(txtMa.Text,txtTen.Text,txtPhone.Text,numLuong.Value,chkLam.Checked,false);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnEdit,()=>{QuyDinh.Require(txtMa.ReadOnly,"Chọn một dòng để sửa.");svc.LuuHDV(txtMa.Text,txtTen.Text,txtPhone.Text,numLuong.Value,chkLam.Checked,true);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnDelete,()=>{if(FormActions.Confirm(this,"Xóa mã "+txtMa.Text+"?")){svc.Xoa("HDV",txtMa.Text);Tai();}});
FormActions.Wire(this,btnReload,()=>{Tai();});
FormActions.Wire(this,btnClose,()=>{Close();});
dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtMa.Text=FormActions.Cell(dgv,"MaHDV");txtTen.Text=FormActions.Cell(dgv,"HoTen");txtPhone.Text=FormActions.Cell(dgv,"DienThoai");numLuong.Value=Convert.ToDecimal(FormActions.Cell(dgv,"LuongCoBan"));chkLam.Checked=Convert.ToBoolean(FormActions.Cell(dgv,"DangLamViec"));txtMa.ReadOnly=true;};
Tai(); });
 }
 private void Tai() { FormActions.Table(dgv,svc.Lay("HDV")); }
 }
}