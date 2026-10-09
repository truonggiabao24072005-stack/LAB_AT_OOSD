using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmDiemThamQuan : Form {
 private readonly DanhMucService svc = new DanhMucService();
 public FrmDiemThamQuan() { InitializeComponent(); }
 private void FrmDiemThamQuan_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnNew,()=>{txtMa.ReadOnly=false;FormActions.ClearText(this);dgv.ClearSelection();});
FormActions.Wire(this,btnAdd,()=>{svc.LuuDTQ(txtMa.Text,txtTen.Text,txtDia.Text,txtNoiDung.Text,txtYNghia.Text,false);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnEdit,()=>{QuyDinh.Require(txtMa.ReadOnly,"Chọn một dòng để sửa.");svc.LuuDTQ(txtMa.Text,txtTen.Text,txtDia.Text,txtNoiDung.Text,txtYNghia.Text,true);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnDelete,()=>{if(FormActions.Confirm(this,"Xóa mã "+txtMa.Text+"?")){svc.Xoa("DTQ",txtMa.Text);Tai();}});
FormActions.Wire(this,btnReload,()=>{Tai();});
FormActions.Wire(this,btnClose,()=>{Close();});
dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtMa.Text=FormActions.Cell(dgv,"MaDiemTQ");txtTen.Text=FormActions.Cell(dgv,"TenDiemTQ");txtDia.Text=FormActions.Cell(dgv,"DiaDiem");txtNoiDung.Text=FormActions.Cell(dgv,"NoiDung");txtYNghia.Text=FormActions.Cell(dgv,"YNghia");txtMa.ReadOnly=true;};
Tai(); });
 }
 private void Tai() { FormActions.Table(dgv,svc.Lay("DTQ")); }
 }
}