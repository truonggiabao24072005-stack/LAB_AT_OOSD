using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmTour:Form {
 private readonly TourService svc=new TourService(); private readonly DanhMucService dm=new DanhMucService();
 public FrmTour(){InitializeComponent();}
 private void FrmTour_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnThemTour,()=>{svc.LuuTour(txtMa.Text,txtTen.Text,(int)numNgay.Value,(int)numDem.Value,numGia.Value,txtMoTa.Text,false,false);Tai();FormActions.Done(this);}); FormActions.Wire(this,btnThemDD,()=>{svc.ThemDiemDung(MaTour(),(int)numDD.Value,txtDD.Text,chkDoi.Checked,chkAn.Checked,chkKS.Checked,(int)numSao.Value,txtDDNote.Text);ChiTiet();FormActions.Done(this);}); FormActions.Wire(this,btnGanPT,()=>{svc.GanPhuongTien(MaTour(),(int)numChang.Value,FormActions.Value(cboPT),txtPTNote.Text);ChiTiet();FormActions.Done(this);}); FormActions.Wire(this,btnGanTQ,()=>{svc.GanThamQuan(MaTour(),(int)numTQ.Value,FormActions.Value(cboTQ));ChiTiet();FormActions.Done(this);}); FormActions.Wire(this,btnDong,()=>{Close();}); FormActions.Bind(cboPT,dm.Lay("PT"),"MaPT","TenPT");FormActions.Bind(cboTQ,dm.Lay("DTQ"),"MaDiemTQ","TenDiemTQ");cboTour.SelectedIndexChanged+=(s,e)=>FormActions.Run(this,ChiTiet);chkKS.CheckedChanged+=(s,e)=>numSao.Enabled=chkKS.Checked;numSao.Enabled=false; var menu=new ContextMenuStrip();menu.Items.Add("Mở bán / ngừng bán",null,(s,e)=>FormActions.Run(this,()=>{var r=dgvTour.CurrentRow==null?null:dgvTour.CurrentRow.DataBoundItem as DataRowView;QuyDinh.Require(r!=null,"Chọn tour.");svc.LuuTour(Convert.ToString(r["MaTour"]),Convert.ToString(r["TenTour"]),Convert.ToInt32(r["SoNgay"]),Convert.ToInt32(r["SoDem"]),Convert.ToDecimal(r["DonGiaKhach"]),Convert.ToString(r["MoTa"]),!Convert.ToBoolean(r["DangMoBan"]),true);Tai();}));dgvTour.ContextMenuStrip=menu;Tai(); });
 }
 private string MaTour(){return FormActions.Value(cboTour);} private void Tai(){var t=svc.LayTour();MauForm.Table(dgvTour,t);FormActions.Bind(cboTour,t.Copy(),"MaTour","TenTour");ChiTiet();} private void ChiTiet(){MauForm.Table(dgvDD,svc.LayDiemDung(MaTour()));MauForm.Table(dgvPT,svc.LayPhuongTien(MaTour()));MauForm.Table(dgvTQ,svc.LayThamQuan(MaTour()));}
 }
}