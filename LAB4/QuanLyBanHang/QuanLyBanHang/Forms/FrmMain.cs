using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmMain : Form {
  private ShopContext shop;
  public FrmMain(){InitializeComponent();}
  public FrmMain(ShopContext context):this(){shop=context;}
  private void FrmMain_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   btnCatalog.Image=SystemIcons.Application.ToBitmap();btnCart.Image=SystemIcons.Information.ToBitmap();btnOrders.Image=SystemIcons.Shield.ToBitmap();
   btnLogin.Image=SystemIcons.Question.ToBitmap();btnRegister.Image=SystemIcons.WinLogo.ToBitmap();btnLogout.Image=SystemIcons.Warning.ToBitmap();btnExit.Image=SystemIcons.Error.ToBitmap();
   FormActions.Wire(this,btnCatalog,()=>Open(new FrmCatalog(shop)));
   FormActions.Wire(this,btnCart,()=>Open(new FrmCart(shop)));
   FormActions.Wire(this,btnOrders,()=>{if(FormActions.Login(this,shop))Open(new FrmOrderResult(shop));RefreshUser();});
   FormActions.Wire(this,btnLogin,()=>Open(new FrmLogin(shop)));
   FormActions.Wire(this,btnRegister,()=>Open(new FrmRegister(shop)));
   FormActions.Wire(this,btnLogout,()=>{if(MessageBox.Show(this,"Đăng xuất và xóa giỏ hàng hiện tại?","Xác nhận",MessageBoxButtons.YesNo)==DialogResult.Yes){shop.Customer=null;shop.Cart.Lines.Clear();shop.PendingOrder=null;RefreshUser();}});
   FormActions.Wire(this,btnExit,()=>Close());RefreshUser();
  }
  private void Open(Form f){using(f)f.ShowDialog(this);RefreshUser();}
  private void RefreshUser(){lblUser.Text=shop.Customer==null?"Chưa đăng nhập":"Khách hàng: "+shop.Customer.Name;btnLogin.Enabled=shop.Customer==null;btnLogout.Enabled=shop.Customer!=null;}

 }
}
