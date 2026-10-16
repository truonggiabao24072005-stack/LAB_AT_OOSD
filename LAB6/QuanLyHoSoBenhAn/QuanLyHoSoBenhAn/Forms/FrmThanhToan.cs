using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmThanhToan:Form {
 public FrmThanhToan(){InitializeComponent();}
 private readonly ThanhToanService svc=new ThanhToanService();private bool loading;
 private void FrmThanhToan_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;txtNoi.MaxLength=150;numTien.Value=100000;
 FormActions.Wire(this,btnThem,()=>{svc.Them(FormActions.Chon(cboPK),txtNoi.Text,numTien.Value);Tai();FormActions.Done(this);});FormActions.Wire(this,btnThu,()=>{string ma=FormActions.Chon(dgv,"MaTT");if(FormActions.Confirm(this,"Xác nhận đã thu đủ khoản tiền đang chọn?")){svc.Thu(ma);Tai();FormActions.Done(this);}});FormActions.Wire(this,btnHoanTat,()=>{if(FormActions.Confirm(this,"Xác nhận hoàn tất và khóa nội dung phiếu khám?")){svc.HoanTat(FormActions.Chon(cboPK));Tai();FormActions.Done(this);}});FormActions.Wire(this,btnTai,Reload);cboPK.SelectedIndexChanged+=(s,a)=>{if(!loading)FormActions.Run(this,Tai);};dgv.SelectionChanged+=(s,a)=>{btnThu.Enabled=FormActions.Cell(dgv,"TrangThai")=="CHUATHU";};btnDong.Click+=(s,a)=>Close();FormActions.Run(this,Reload);}
 private void Reload(){loading=true;FormActions.Bind(cboPK,svc.Phieu(),"MaPK");loading=false;Tai();}
 private void Tai(){string pk=FormActions.Value(cboPK);var t=svc.Lay(pk);FormActions.Table(dgv,t);decimal tong=0,thu=0,no=0;foreach(DataRow r in t.Rows){decimal v=Convert.ToDecimal(r["SoTien"]);tong+=v;if(Convert.ToString(r["TrangThai"])=="DATHU")thu+=v;if(Convert.ToString(r["TrangThai"])=="CHUATHU")no+=v;}lblTong.Text="Tổng: "+tong.ToString("N0")+" đ     Đã thu: "+thu.ToString("N0")+" đ     Còn phải thu: "+no.ToString("N0")+" đ";var p=svc.ChiTietPhieu(pk);bool open=p.Rows.Count>0&&Convert.ToString(p.Rows[0]["TrangThai"])!="HOANTAT";btnThem.Enabled=open;btnHoanTat.Enabled=open;btnThu.Enabled=open&&FormActions.Cell(dgv,"TrangThai")=="CHUATHU";lblPhieu.Text=p.Rows.Count==0?"Chưa có phiếu khám.":"Bệnh nhân: "+p.Rows[0]["TenBenhNhan"]+" | "+p.Rows[0]["TrangThai"];}
}
}
