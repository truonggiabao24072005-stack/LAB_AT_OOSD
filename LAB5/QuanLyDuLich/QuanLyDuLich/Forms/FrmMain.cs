using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmMain:Form {
 
 public FrmMain(){InitializeComponent();}
 private void FrmMain_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnFrmDanhMuc,()=>{using(var form=new FrmDanhMuc())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmTour,()=>{using(var form=new FrmTour())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmChuyenLe,()=>{using(var form=new FrmChuyenLe())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmDangKyLe,()=>{using(var form=new FrmDangKyLe())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmDangKyDoan,()=>{using(var form=new FrmDangKyDoan())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmPhanCongHDV,()=>{using(var form=new FrmPhanCongHDV())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmKetThucKhaoSat,()=>{using(var form=new FrmKetThucKhaoSat())form.ShowDialog(this);}); FormActions.Wire(this,btnFrmLuongThongKe,()=>{using(var form=new FrmLuongThongKe())form.ShowDialog(this);}); FormActions.Wire(this,btnThoat,()=>{Close();}); });
 }
 
 }
}
