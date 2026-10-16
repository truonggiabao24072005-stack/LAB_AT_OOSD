using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace QuanLyHoSoBenhAn.Forms {
 public sealed class FrmInToa:Form {
  private readonly PrintDocument document=new PrintDocument();private readonly List<string> lines=new List<string>();private int line;
  public FrmInToa(DataTable phieu,DataTable dong,string ma,string loi){
   Text="Xem và in toa thuốc";Size=new Size(1000,720);StartPosition=FormStartPosition.CenterParent;
   var r=phieu.Rows[0];lines.Add("TOA THUỐC   "+ma);lines.Add("Bệnh nhân: "+r["TenBenhNhan"]+"    Hồ sơ: "+r["MaHS"]);lines.Add("Phiếu khám: "+r["MaPK"]+"    Ngày khám: "+Convert.ToDateTime(r["NgayGio"]).ToString("dd/MM/yyyy"));lines.Add("Bác sĩ: "+r["TenBacSi"]+" / "+r["TenKhoa"]);Wrap("Chẩn đoán: "+r["ChanDoan"]);lines.Add("");
   foreach(DataRow d in dong.Rows){Wrap(d["STT"]+". "+d["TenThuoc"]+" — "+d["SoLuong"]+" "+d["DonVi"]+" / "+d["SoNgay"]+" ngày");Wrap("Liều dùng: "+d["LieuDung"]);Wrap("Cách dùng: "+d["CachDung"]);lines.Add("");}Wrap("Lời dặn: "+loi);
   document.DefaultPageSettings.Margins=new Margins(55,55,55,55);document.BeginPrint+=(s,e)=>line=0;document.PrintPage+=PrintPage;
   var preview=new PrintPreviewControl{Dock=DockStyle.Fill,Document=document,Zoom=1.0};
   var print=new Button{Text="In toa thuốc",Dock=DockStyle.Top,Height=38};print.Click+=(s,e)=>FormActions.Run(this,()=>{using(var dlg=new PrintDialog()){dlg.Document=document;if(dlg.ShowDialog(this)==DialogResult.OK)document.Print();}});Controls.Add(preview);Controls.Add(print);
  }
  private void Wrap(string text){foreach(string para in text.Replace("\r","").Split('\n')){string current="";foreach(string word in para.Split(' ')){if((current+word).Length>75){lines.Add(current);current="";}current+=word+" ";}lines.Add(current.TrimEnd());}}
  private void PrintPage(object sender,PrintPageEventArgs e){using(var font=new Font("Times New Roman",12F)){float y=e.MarginBounds.Top;while(line<lines.Count&&y+22<e.MarginBounds.Bottom){e.Graphics.DrawString(lines[line++],font,Brushes.Black,e.MarginBounds.Left,y);y+=22;}e.HasMorePages=line<lines.Count;}}
  protected override void Dispose(bool disposing){if(disposing)document.Dispose();base.Dispose(disposing);}
 }
}
