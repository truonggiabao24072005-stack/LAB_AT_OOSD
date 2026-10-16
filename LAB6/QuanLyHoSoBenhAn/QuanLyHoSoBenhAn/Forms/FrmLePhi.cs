using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmLePhi:Form {
 public FrmLePhi(){InitializeComponent();}
 private readonly LePhiService svc=new LePhiService();
 private void FrmLePhi_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;dtTu.Value=DateTime.Today;dtDen.Value=DateTime.Today.AddYears(1).AddDays(-1);numTien.Value=500000;
 FormActions.Wire(this,btnTai,Tai);FormActions.Wire(this,btnThu,()=>{string hs=FormActions.Chon(cboHS);if(FormActions.Confirm(this,"Xác nhận đã thu số tiền lệ phí này?")){svc.Thu(hs,dtTu.Value,dtDen.Value,numTien.Value);Tai();FormActions.Done(this);}});cboHS.SelectedIndexChanged+=(s,a)=>FormActions.Run(this,Tai);btnDong.Click+=(s,a)=>Close();FormActions.Run(this,()=>{FormActions.Bind(cboHS,svc.HoSo());Tai();});}
 private void Tai(){FormActions.Table(dgv,svc.Lay(FormActions.Value(cboHS)));}
}
}
