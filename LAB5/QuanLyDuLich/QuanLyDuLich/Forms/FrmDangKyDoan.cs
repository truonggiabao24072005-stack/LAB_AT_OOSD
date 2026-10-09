using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmDangKyDoan:Form {
 private readonly DangKyDoanService svc=new DangKyDoanService(); private readonly TourService tour=new TourService();
 public FrmDangKyDoan(){InitializeComponent();}
 private void FrmDangKyDoan_Load(object sender,EventArgs args){
  if(FormActions.IsDesign)return;FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnDangKy,()=>{Lap();Tai();FormActions.Done(this);}); FormActions.Wire(this,btnHuy,()=>{var so=FormActions.Cell(dgv,"SoDKDoan");if(FormActions.Confirm(this,"Hủy phiếu "+so+" và giữ tiền cọc?")){svc.HuyDangKy(so);Tai();}}); FormActions.Wire(this,btnDong,()=>{Close();}); dtDi.Value=DateTime.Today.AddDays(14);dgvTV.Columns.Add("HoTen","HoTen");dgvTV.Columns.Add("NgaySinh","NgaySinh (dd/MM/yyyy)");dgvTV.Columns.Add("SoGiayTo","SoGiayTo");cboTour.SelectedIndexChanged+=(s,e)=>Tinh();numNguoi.ValueChanged+=(s,e)=>Tinh();dtDi.ValueChanged+=(s,e)=>Tinh();FormActions.Bind(cboTour,tour.LayTourMoBan(),"MaTour","HienThi");Tinh();Tai(); });
 }
 private void Tai(){MauForm.Table(dgv,svc.LayDanhSach());} private void Tinh(){var r=cboTour.SelectedItem as DataRowView;lblTong.Text=r==null?"-":(Convert.ToDecimal(r["DonGiaKhach"])*numNguoi.Value).ToString("N0")+" đ";lblKetThuc.Text=r==null?"-":dtDi.Value.Date.AddDays(Convert.ToInt32(r["SoNgay"])-1).ToString("dd/MM/yyyy");} private void Lap(){dgvTV.EndEdit();var t=QuyDinh.BangThanhVien();int stt=0;foreach(DataGridViewRow row in dgvTV.Rows){if(row.IsNewRow)continue;var ten=QuyDinh.Text(Convert.ToString(row.Cells["HoTen"].Value),"họ tên thành viên",120);var sinh=QuyDinh.NgaySinh(Convert.ToString(row.Cells["NgaySinh"].Value));t.Rows.Add(++stt,ten,sinh.HasValue?(object)sinh.Value:DBNull.Value,QuyDinh.TuyChon(Convert.ToString(row.Cells["SoGiayTo"].Value),40));}svc.LapPhieu(new DangKyDoanInput{SoDKDoan=txtSo.Text,MaDoan=txtMaDoan.Text,TenDoan=txtTen.Text,DiaChi=txtDia.Text,DienThoai=txtPhone.Text,DaiDien=txtDaiDien.Text,MaTour=FormActions.Value(cboTour),NgayDi=dtDi.Value,SoNguoi=(int)numNguoi.Value,NoiDon=txtDon.Text,BaoHiem=chkBH.Checked,TienCoc=numCoc.Value,ThanhVien=t});dgvTV.Rows.Clear();}
 }
}