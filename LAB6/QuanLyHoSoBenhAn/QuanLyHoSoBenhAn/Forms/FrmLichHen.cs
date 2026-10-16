using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
using QuanLyHoSoBenhAn.Models;
namespace QuanLyHoSoBenhAn.Forms {
 public partial class FrmLichHen:Form {
 public FrmLichHen(){InitializeComponent();}
 private readonly LichHenService svc=new LichHenService();
 private void FrmLichHen_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;dtTu.Value=DateTime.Today.AddDays(1).AddHours(8);dtDen.Value=dtTu.Value.AddMinutes(30);
 FormActions.Wire(this,btnKiemTra,Tai);FormActions.Wire(this,btnDat,()=>{string ma=svc.Dat(FormActions.Chon(cboHS),FormActions.Chon(cboBS),dtTu.Value,dtDen.Value);Tai();FormActions.Done(this,"Đã đặt hẹn: "+ma);});FormActions.Wire(this,btnHuy,()=>{string ma=FormActions.Chon(dgv,"MaHen");if(FormActions.Confirm(this,"Hủy hẹn đang chọn?")){svc.Huy(ma);Tai();}});btnDong.Click+=(s,a)=>Close();FormActions.Run(this,()=>{FormActions.Bind(cboHS,svc.HoSo());FormActions.Bind(cboBS,svc.BacSi(),"MaBS");Tai();});}
 private void Tai(){FormActions.Table(dgv,svc.Lay(FormActions.Value(cboBS),dtTu.Value));var q=svc.QuyenLoi(FormActions.Value(cboHS),dtTu.Value).Rows[0];lblQuyen.Text="Lệ phí: "+q["LePhi"]+". Lượt định kỳ đã hoàn tất trong quý: "+q["LuotDaDung"]+" / 1.";}
}
}
