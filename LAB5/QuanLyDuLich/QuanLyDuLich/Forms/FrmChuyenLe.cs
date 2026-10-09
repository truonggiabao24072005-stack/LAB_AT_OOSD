using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmChuyenLe:Form {
 private readonly ChuyenLeService svc=new ChuyenLeService(); private readonly TourService tour=new TourService();
 public FrmChuyenLe(){InitializeComponent();}
 private void FrmChuyenLe_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnThem,()=>{svc.ThemChuyen(txtMa.Text,FormActions.Value(cboTour),dtDi.Value,txtDon.Text);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnDongDK,()=>{svc.DongDangKy(FormActions.Cell(dgv,"MaChuyen"));Tai();FormActions.Done(this);}); FormActions.Wire(this,btnDong,()=>{Close();}); dtDi.Value=DateTime.Today.AddDays(7);cboTour.SelectedIndexChanged+=(s,e)=>Tinh();dtDi.ValueChanged+=(s,e)=>Tinh();FormActions.Bind(cboTour,tour.LayTourMoBan(),"MaTour","HienThi");Tinh();Tai(); });
 }
 private void Tai(){MauForm.Table(dgv,svc.LayChuyen());} private void Tinh(){var r=cboTour.SelectedItem as DataRowView;lblNgayVe.Text=r==null?"-":dtDi.Value.Date.AddDays(Convert.ToInt32(r["SoNgay"])-1).ToString("dd/MM/yyyy");}
 }
}