using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmMain:Form {
 public FrmMain(){InitializeComponent();}
 private void FrmMain_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;lblTitle.Font=new Font("Segoe UI",14F,FontStyle.Bold);lblTitle.ForeColor=Color.FromArgb(0,64,112);lblTitle.TextAlign=ContentAlignment.MiddleCenter;
 FormActions.Wire(this,btnHoSo,()=>{using(var f=new FrmHoSo())f.ShowDialog(this);});
 FormActions.Wire(this,btnLePhi,()=>{using(var f=new FrmLePhi())f.ShowDialog(this);});
 FormActions.Wire(this,btnLichHen,()=>{using(var f=new FrmLichHen())f.ShowDialog(this);});
 FormActions.Wire(this,btnKhamBenh,()=>{using(var f=new FrmKhamBenh())f.ShowDialog(this);});
 FormActions.Wire(this,btnXetNghiem,()=>{using(var f=new FrmXetNghiem())f.ShowDialog(this);});
 FormActions.Wire(this,btnToaThuoc,()=>{using(var f=new FrmToaThuoc())f.ShowDialog(this);});
 FormActions.Wire(this,btnThanhToan,()=>{using(var f=new FrmThanhToan())f.ShowDialog(this);});
 btnThoat.Click+=(s,a)=>Close();}
}
}
