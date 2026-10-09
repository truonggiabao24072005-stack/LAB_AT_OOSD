using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmDiemBanVe : Form {
 private readonly DanhMucService svc = new DanhMucService();
 public FrmDiemBanVe() { InitializeComponent(); }
 private void FrmDiemBanVe_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnNew,()=>{txtMa.ReadOnly=false;FormActions.ClearText(this);dgv.ClearSelection();});
FormActions.Wire(this,btnAdd,()=>{svc.LuuDB(txtMa.Text,txtTen.Text,txtDia.Text,txtPhone.Text,false);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnEdit,()=>{QuyDinh.Require(txtMa.ReadOnly,"Chọn một dòng để sửa.");svc.LuuDB(txtMa.Text,txtTen.Text,txtDia.Text,txtPhone.Text,true);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnDelete,()=>{if(FormActions.Confirm(this,"Xóa mã "+txtMa.Text+"?")){svc.Xoa("DB",txtMa.Text);Tai();}});
FormActions.Wire(this,btnReload,()=>{Tai();});
FormActions.Wire(this,btnClose,()=>{Close();});
dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtMa.Text=FormActions.Cell(dgv,"MaDiemBan");txtTen.Text=FormActions.Cell(dgv,"TenDiemBan");txtDia.Text=FormActions.Cell(dgv,"DiaChi");txtPhone.Text=FormActions.Cell(dgv,"DienThoai");txtMa.ReadOnly=true;};
Tai(); });
 }
 private void Tai() { FormActions.Table(dgv,svc.Lay("DB")); }
 }
}