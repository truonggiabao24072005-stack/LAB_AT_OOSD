using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmDanhMuc:Form {
 private readonly DanhMucService svc=new DanhMucService();
 public FrmDanhMuc(){InitializeComponent();}
 private void FrmDanhMuc_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnThemPT,()=>{svc.LuuPT(txtPTMa.Text,txtPTTen.Text,txtPTNote.Text,false);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnThemDB,()=>{svc.LuuDB(txtDBMa.Text,txtDBTen.Text,txtDBDia.Text,txtDBPhone.Text,false);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnThemHDV,()=>{svc.LuuHDV(txtHDVMa.Text,txtHDVTen.Text,txtHDVPhone.Text,numLuong.Value,true,false);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnThemTQ,()=>{svc.LuuDTQ(txtTQMa.Text,txtTQTen.Text,txtTQDia.Text,txtTQNoiDung.Text,txtTQYNghia.Text,false);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnDong,()=>{Close();}); Tai(); });
 }
 private void Tai(){MauForm.Table(dgvPT,svc.Lay("PT"));MauForm.Table(dgvDB,svc.Lay("DB"));MauForm.Table(dgvHDV,svc.Lay("HDV"));MauForm.Table(dgvTQ,svc.Lay("DTQ"));}
 }
}