using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmKetThucKhaoSat:Form {
 private readonly KetThucService svc=new KetThucService();
 public FrmKetThucKhaoSat(){InitializeComponent();}
 private void FrmKetThucKhaoSat_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnThanhToan,()=>{svc.ThanhToanDoan(txtSoTT.Text,txtSoDK.Text,dtTT.Value,numTien.Value,txtNote.Text);TaiThanhToan();FormActions.Done(this);}); FormActions.Wire(this,btnGui,()=>{svc.GuiKhaoSat(txtMaKS.Text,cboLoai.Text,FormActions.Value(cboDK),dtGui.Value);TaiKhaoSat();NapDK();FormActions.Done(this);}); FormActions.Wire(this,btnGhiPH,()=>{svc.GhiPhanHoi(txtKSChon.Text,dtPH.Value,(int)numDiem.Value,txtGopY.Text);TaiKhaoSat();FormActions.Done(this);}); FormActions.Wire(this,btnDong,()=>{Close();}); txtSoDK.ReadOnly=true;txtKSChon.ReadOnly=true;dgvDoan.SelectionChanged+=(s,e)=>{if(dgvDoan.CurrentRow==null)return;txtSoDK.Text=FormActions.Cell(dgvDoan,"SoDKDoan");numTien.Value=Math.Max(0,Math.Min(numTien.Maximum,Convert.ToDecimal(FormActions.Cell(dgvDoan,"ConLai"))));};cboLoai.Items.AddRange(new object[]{"LE","DOAN"});cboLoai.SelectedIndexChanged+=(s,e)=>FormActions.Run(this,NapDK);dgvKS.SelectionChanged+=(s,e)=>{if(dgvKS.CurrentRow==null)return;txtKSChon.Text=FormActions.Cell(dgvKS,"MaKhaoSat");txtGopY.Text=FormActions.Cell(dgvKS,"GopY");var diem=FormActions.Cell(dgvKS,"DiemDanhGia");numDiem.Value=diem==""?4:Convert.ToInt32(diem);};cboLoai.SelectedIndex=0;TaiThanhToan();TaiKhaoSat(); });
 }
 private void TaiThanhToan(){MauForm.Table(dgvDoan,svc.DoanCanThanhToan());if(dgvDoan.Rows.Count==0){txtSoDK.Clear();numTien.Value=0;}} private void TaiKhaoSat(){MauForm.Table(dgvKS,svc.LayKhaoSat());} private void NapDK(){FormActions.Bind(cboDK,svc.LayDangKyChoKhaoSat(cboLoai.Text),"Ma","HienThi");}
 }
}