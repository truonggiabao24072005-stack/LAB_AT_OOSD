using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmKhamBenh:Form {
 public FrmKhamBenh(){InitializeComponent();}
 private readonly KhamBenhService svc=new KhamBenhService();private readonly LichHenService hen=new LichHenService();private bool loading;
 private void FrmKhamBenh_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;numTien.Value=100000;numNhiet.Minimum=30;numNhiet.Maximum=45;numNhiet.DecimalPlaces=1;numNhiet.Increment=0.1M;numNhiet.Value=37;txtAp.MaxLength=30;dtNgay.Value=DateTime.Now.AddSeconds(-2);cboLoai.Items.AddRange(new object[]{"Khám thường","Khám định kỳ"});cboLoai.SelectedIndex=0;
 FormActions.Wire(this,btnHen,TaiHen);FormActions.Wire(this,btnTai,Tai);FormActions.Wire(this,btnTao,()=>{string pk=svc.Tao(FormActions.Chon(cboHS),FormActions.Chon(cboBS),FormActions.Value(cboHen),cboLoai.SelectedIndex==1?"DINHKY":"THUONG",dtNgay.Value,txtTrieu.Text,numTien.Value);Tai();foreach(DataGridViewRow r in dgv.Rows)if(Convert.ToString(r.Cells["MaPK"].Value)==pk){dgv.CurrentCell=r.Cells[0];break;}FormActions.Done(this,"Đã tạo phiếu: "+pk);});
 FormActions.Wire(this,btnNhap,()=>Ghi(false));FormActions.Wire(this,btnKet,()=>Ghi(true));FormActions.Wire(this,btnXN,()=>FormActions.View(this,"Kết quả xét nghiệm",new XetNghiemService().Lay(FormActions.Chon(dgv,"MaPK"))));FormActions.Wire(this,btnToa,()=>FormActions.View(this,"Toa đã lưu",new ToaThuocService().ChiTiet(FormActions.Chon(dgv,"MaPK"))));
 cboHS.SelectedIndexChanged+=(s,a)=>{if(!loading)FormActions.Run(this,Tai);};dgv.SelectionChanged+=(s,a)=>{if(!loading)FormActions.Run(this,ChonPhieu);};cboLoai.SelectedIndexChanged+=(s,a)=>{numTien.Enabled=cboLoai.SelectedIndex==0;};btnDong.Click+=(s,a)=>Close();FormActions.Run(this,()=>{loading=true;FormActions.Bind(cboHS,svc.HoSo());FormActions.Bind(cboBS,svc.BacSi(),"MaBS");loading=false;Tai();});}
 private void TaiHen(){FormActions.Bind(cboHen,hen.HenCho(FormActions.Value(cboHS),FormActions.Value(cboBS),dtNgay.Value),"MaHen");}
 private void Tai(){loading=true;try{FormActions.Table(dgv,svc.LichSu(FormActions.Value(cboHS)));TaiHen();}finally{loading=false;}ChonPhieu();}
 private void ChonPhieu(){string pk=FormActions.Cell(dgv,"MaPK");var t=svc.ChiTietPhieu(pk);bool editable=false;if(t.Rows.Count>0){var r=t.Rows[0];txtTrieu.Text=Convert.ToString(r["TrieuChung"]);txtChan.Text=Convert.ToString(r["ChanDoan"]);txtKet.Text=Convert.ToString(r["KetLuan"]);txtAp.Text=Convert.ToString(r["HuyetAp"]);chkNhiet.Checked=!r.IsNull("NhietDo");if(chkNhiet.Checked)numNhiet.Value=Convert.ToDecimal(r["NhietDo"]);editable=Convert.ToString(r["TrangThai"])!="HOANTAT"&&new ToaThuocService().Header(pk).Rows.Count==0;lblPhieu.Text="Phiếu: "+pk+" | "+r["TrangThai"]+" | "+r["TenBacSi"]+" | "+r["TenKhoa"];}else{txtTrieu.Clear();txtChan.Clear();txtKet.Clear();txtAp.Clear();lblPhieu.Text="Chưa có phiếu khám trong hồ sơ.";}btnNhap.Enabled=btnKet.Enabled=editable;}
 private void Ghi(bool xac){svc.Ghi(FormActions.Chon(dgv,"MaPK"),txtTrieu.Text,chkNhiet.Checked?(decimal?)numNhiet.Value:null,txtAp.Text,txtChan.Text,txtKet.Text,xac);Tai();FormActions.Done(this);}
}
}
