using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmPhuongTien : Form {
 private readonly DanhMucService svc = new DanhMucService();
 public FrmPhuongTien() { InitializeComponent(); }
 private void FrmPhuongTien_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnNew,()=>{txtMa.ReadOnly=false;FormActions.ClearText(this);dgv.ClearSelection();});
FormActions.Wire(this,btnAdd,()=>{svc.LuuPT(txtMa.Text,txtTen.Text,txtNote.Text,false);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnEdit,()=>{QuyDinh.Require(txtMa.ReadOnly,"Chọn một dòng để sửa.");svc.LuuPT(txtMa.Text,txtTen.Text,txtNote.Text,true);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnDelete,()=>{if(FormActions.Confirm(this,"Xóa mã "+txtMa.Text+"?")){svc.Xoa("PT",txtMa.Text);Tai();}});
FormActions.Wire(this,btnReload,()=>{Tai();});
FormActions.Wire(this,btnClose,()=>{Close();});
dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtMa.Text=FormActions.Cell(dgv,"MaPT");txtTen.Text=FormActions.Cell(dgv,"TenPT");txtNote.Text=FormActions.Cell(dgv,"GhiChu");txtMa.ReadOnly=true;};
Tai(); });
 }
 private void Tai() { FormActions.Table(dgv,svc.Lay("PT")); }
 }
}