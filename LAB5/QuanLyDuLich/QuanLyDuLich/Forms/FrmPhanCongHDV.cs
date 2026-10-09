using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmPhanCongHDV:Form {
 private readonly PhanCongService svc=new PhanCongService();
 public FrmPhanCongHDV(){InitializeComponent();}
 private void FrmPhanCongHDV_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnPhanCong,()=>{svc.PhanCong(txtMa.Text,FormActions.Value(cboHDV),cboLoai.Text,FormActions.Value(cboDT),numThuLao.Value);Tai();NapDT();FormActions.Done(this);}); FormActions.Wire(this,btnDong,()=>{Close();}); cboLoai.Items.AddRange(new object[]{"LE","DOAN"});cboLoai.SelectedIndexChanged+=(s,e)=>FormActions.Run(this,NapDT);FormActions.Bind(cboHDV,svc.LayHDV(),"MaHDV","HienThi");cboLoai.SelectedIndex=0;Tai(); });
 }
 private void Tai(){MauForm.Table(dgv,svc.LayDanhSach());} private void NapDT(){FormActions.Bind(cboDT,svc.LayDoiTuong(cboLoai.Text),"Ma","HienThi");}
 }
}