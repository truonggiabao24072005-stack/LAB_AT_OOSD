using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmXetNghiem:Form {
 public FrmXetNghiem(){InitializeComponent();}
 private readonly XetNghiemService svc=new XetNghiemService();private bool loading;
 private void FrmXetNghiem_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;txtKet.MaxLength=2000;
 FormActions.Wire(this,btnLap,()=>{svc.Lap(FormActions.Chon(cboPK),FormActions.Chon(cboLoai));Tai();FormActions.Done(this);});FormActions.Wire(this,btnLuu,()=>{svc.KetQua(FormActions.Chon(dgv,"MaCD"),txtKet.Text);Tai();FormActions.Done(this);});FormActions.Wire(this,btnTai,Reload);cboPK.SelectedIndexChanged+=(s,a)=>{if(!loading)FormActions.Run(this,Tai);};dgv.SelectionChanged+=(s,a)=>{txtKet.Text=FormActions.Cell(dgv,"KetQua");btnLuu.Enabled=FormActions.Cell(dgv,"TrangThai")=="CHO";};btnDong.Click+=(s,a)=>Close();FormActions.Run(this,()=>{FormActions.Bind(cboLoai,svc.Loai(),"MaLoaiXN");Reload();});}
 private void Reload(){loading=true;FormActions.Bind(cboPK,svc.Phieu(),"MaPK");loading=false;Tai();}
 private void Tai(){string pk=FormActions.Value(cboPK);FormActions.Table(dgv,svc.Lay(pk));var t=svc.ChiTietPhieu(pk);btnLap.Enabled=t.Rows.Count>0&&Convert.ToString(t.Rows[0]["TrangThai"])=="DANGKHAM";lblPhieu.Text=t.Rows.Count==0?"Chưa có phiếu khám.":"Bệnh nhân: "+t.Rows[0]["TenBenhNhan"]+" | "+t.Rows[0]["TrangThai"];}
}
}
