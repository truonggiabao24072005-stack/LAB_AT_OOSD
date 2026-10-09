using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;
using QuanLyDuLich.Models;
namespace QuanLyDuLich.Forms {
 public partial class FrmThanhToanDoan : Form {
 private readonly KetThucService svc = new KetThucService();
 public FrmThanhToanDoan() { InitializeComponent(); }
 private void FrmThanhToanDoan_Load(object sender,EventArgs args) {
  if(FormActions.IsDesign)return; FormActions.Fit(this);
  FormActions.Run(this,()=>{ FormActions.Wire(this,btnPay,()=>{svc.ThanhToanDoan(txtMa.Text,txtSo.Text,dtNgay.Value,numTien.Value,txtNote.Text);Tai();FormActions.Done(this);});
FormActions.Wire(this,btnReload,()=>{Tai();});
FormActions.Wire(this,btnClose,()=>{Close();});
txtSo.ReadOnly=true;dgv.SelectionChanged+=(s,e)=>{if(dgv.CurrentRow==null)return;txtSo.Text=FormActions.Cell(dgv,"SoDKDoan");numTien.Value=Math.Max(0,Math.Min(numTien.Maximum,Convert.ToDecimal(FormActions.Cell(dgv,"ConLai"))));};Tai(); });
 }
 private void Tai(){FormActions.Table(dgv,svc.DoanCanThanhToan());FormActions.Table(dgvTT,svc.LayThanhToan());if(dgv.Rows.Count==0){txtSo.Clear();numTien.Value=0;}}
 }
}