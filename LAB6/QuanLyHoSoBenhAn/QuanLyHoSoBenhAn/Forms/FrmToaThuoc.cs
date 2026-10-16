using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmToaThuoc:Form {
 public FrmToaThuoc(){InitializeComponent();}
 private readonly ToaThuocService svc=new ToaThuocService();private DataTable draft=Input.DongToa();private bool loading;private string maToa;
 private void FrmToaThuoc_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;numLuong.Minimum=numNgay.Minimum=1;numLuong.Maximum=100000;numNgay.Maximum=365;txtLieu.MaxLength=150;txtCach.MaxLength=250;
 FormActions.Wire(this,btnThem,()=>{Input.Require(maToa==null,"Toa đã lưu.");draft.Rows.Add(draft.Rows.Count+1,FormActions.Chon(cboThuoc),(int)numLuong.Value,Input.Text(txtLieu.Text,"liều dùng",150),Input.Text(txtCach.Text,"cách dùng",250),(int)numNgay.Value);FormActions.Table(dgv,draft);});
 FormActions.Wire(this,btnXoa,()=>{Input.Require(maToa==null&&dgv.CurrentRow!=null,"Chọn dòng thuốc nháp.");draft.Rows.RemoveAt(dgv.CurrentRow.Index);for(int i=0;i<draft.Rows.Count;i++)draft.Rows[i]["STT"]=i+1;});
 FormActions.Wire(this,btnLuu,()=>{dgv.EndEdit();maToa=svc.Lap(FormActions.Chon(cboPK),txtLoi.Text,draft);Tai();FormActions.Done(this,"Đã lưu toa: "+maToa);});FormActions.Wire(this,btnIn,InToa);FormActions.Wire(this,btnTai,()=>{if(draft.Rows.Count>0&&maToa==null&&!FormActions.Confirm(this,"Bỏ các dòng nháp để tải lại?"))return;Reload();});cboPK.SelectionChangeCommitted+=(s,a)=>{if(draft.Rows.Count>0&&maToa==null)FormActions.Done(this,"Các dòng nháp của phiếu trước đã được bỏ khi chọn phiếu khác.");FormActions.Run(this,Tai);};btnDong.Click+=(s,a)=>Close();FormActions.Run(this,()=>{FormActions.Bind(cboThuoc,svc.Thuoc(),"MaThuoc");Reload();});}
 private void Reload(){loading=true;FormActions.Bind(cboPK,svc.Phieu(),"MaPK");loading=false;Tai();}
 private void Tai(){if(loading)return;string pk=FormActions.Value(cboPK);var h=svc.Header(pk);maToa=h.Rows.Count==0?null:Convert.ToString(h.Rows[0]["MaToa"]);draft=Input.DongToa();txtLoi.Text=h.Rows.Count==0?"":Convert.ToString(h.Rows[0]["LoiDan"]);FormActions.Table(dgv,maToa==null?draft:svc.ChiTiet(pk));var p=svc.ChiTietPhieu(pk);bool edit=maToa==null&&p.Rows.Count>0&&Convert.ToString(p.Rows[0]["TrangThai"])=="DAKETLUAN";btnThem.Enabled=btnXoa.Enabled=btnLuu.Enabled=edit;txtLoi.ReadOnly=!edit;btnIn.Enabled=maToa!=null;lblPhieu.Text=p.Rows.Count==0?"Chưa có phiếu khám.":"Bệnh nhân: "+p.Rows[0]["TenBenhNhan"]+" | "+p.Rows[0]["TrangThai"]+" | "+(maToa??"Chưa lập toa");}
 private void InToa(){string pk=FormActions.Chon(cboPK);var p=svc.ChiTietPhieu(pk);var h=svc.Header(pk);Input.Require(h.Rows.Count>0,"Lưu toa trước khi in.");using(var f=new FrmInToa(p,svc.ChiTiet(pk),Convert.ToString(h.Rows[0]["MaToa"]),Convert.ToString(h.Rows[0]["LoiDan"])))f.ShowDialog(this);}
}
}
