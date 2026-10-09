using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmLuongThongKe:Form {
 private readonly ThongKeService svc=new ThongKeService();
 public FrmLuongThongKe(){InitializeComponent();}
 private void FrmLuongThongKe_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnLuong,()=>{MauForm.Table(dgvLuong,svc.TinhLuong((int)numThang.Value,(int)numNam.Value));}); FormActions.Wire(this,btnTK,()=>{MauForm.Table(dgvTK,svc.TongHop(dtTu.Value,dtDen.Value));}); FormActions.Wire(this,btnDong,()=>{Close();}); numThang.Value=DateTime.Today.Month;numNam.Value=DateTime.Today.Year;dtTu.Value=new DateTime(DateTime.Today.Year,1,1);dtDen.Value=DateTime.Today;MauForm.Table(dgvLuong,svc.TinhLuong((int)numThang.Value,(int)numNam.Value));MauForm.Table(dgvTK,svc.TongHop(dtTu.Value,dtDen.Value)); });
 }
 
 }
}