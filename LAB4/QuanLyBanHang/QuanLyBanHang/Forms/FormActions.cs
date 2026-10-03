using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyBanHang.Forms {
 internal static class FormActions {
  public static bool IsDesign {get{return System.ComponentModel.LicenseManager.UsageMode==System.ComponentModel.LicenseUsageMode.Designtime;}}
  public static void Fit(Form form){var b=Screen.FromControl(form).WorkingArea;form.AutoScroll=true;form.AutoScrollMinSize=form.ClientSize;form.Size=new System.Drawing.Size(Math.Min(form.Width,b.Width-20),Math.Min(form.Height,b.Height-20));}
  public static void Run(Form f,Action a){try{a();}catch(System.Data.SqlClient.SqlException ex){MessageBox.Show(f,"Không truy cập được dữ liệu. Kiểm tra SQL Server, chạy hai file SQL và sửa App.config.\n"+ex.Message,"e-SHOPPING",MessageBoxButtons.OK,MessageBoxIcon.Warning);}catch(Exception ex){MessageBox.Show(f,ex.Message,"e-SHOPPING",MessageBoxButtons.OK,MessageBoxIcon.Warning);}}
  public static void Wire(Form f,Button b,Action a){b.Click+=(s,e)=>Run(f,a);}
  public static void Bind(ComboBox c,DataTable t,string value,string display){c.DataSource=null;c.ValueMember=value;c.DisplayMember=display;c.DataSource=t;}
  public static string Value(ComboBox c){var r=c.SelectedItem as DataRowView;return r==null?"":Convert.ToString(r[c.ValueMember]);}
  public static void Require(bool condition,string message){if(!condition)throw new InvalidOperationException(message);}
  public static Guid OrderId(DataGridView g){Require(g.CurrentRow!=null,"Chọn một đơn hàng.");return (Guid)((DataRowView)g.CurrentRow.DataBoundItem)["MaDH"];}
  public static bool Login(Form owner,ShopContext s){if(s.Customer==null)using(var f=new FrmLogin(s))f.ShowDialog(owner);return s.Customer!=null;}
 }
}
