using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmKhaoSat : Form {
 private readonly KetThucService svc = new KetThucService();
 public FrmKhaoSat() { InitializeComponent(); }
 private void FrmKhaoSat_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnGui,()=>{svc.GuiKhaoSat(txtMa.Text,cboLoai.Text,FormActions.Value(cboDK),dtGui.Value);Tai();Nap();FormActions.Done(this);});
FormActions.Wire(this,btnReload,()=>{Tai();Nap();});
FormActions.Wire(this,btnClose,()=>{Close();});
FormActions.Wire(this,btnGhi,()=>{svc.GhiPhanHoi(txtChon.Text,dtPhanHoi.Value,(int)numDiem.Value,txtY.Text);Tai();FormActions.Done(this);});
txtChon.ReadOnly=true;cboLoai.Items.AddRange(new object[]{"LE","DOAN"});cboLoai.SelectedIndexChanged+=(s,e)=>FormActions.Run(this,Nap);dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtChon.Text=FormActions.Cell(dgv,"MaKhaoSat");txtY.Text=FormActions.Cell(dgv,"GopY");var diem=FormActions.Cell(dgv,"DiemDanhGia");numDiem.Value=diem==""?4:Convert.ToInt32(diem);};cboLoai.SelectedIndex=0;Tai(); });
 }
 private void Nap(){FormActions.Bind(cboDK,svc.LayDangKyChoKhaoSat(cboLoai.Text),"Ma","HienThi");}
private void Tai(){FormActions.Table(dgv,svc.LayKhaoSat());}
 }
}