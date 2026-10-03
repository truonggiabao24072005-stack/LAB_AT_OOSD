using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmLogin : Form {
  private ShopContext shop;
  public FrmLogin(){InitializeComponent();}
  public FrmLogin(ShopContext context):this(){shop=context;}
  private void FrmLogin_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();AcceptButton=btnLogin;CancelButton=btnClose;
   FormActions.Wire(this,btnLogin,()=>{var customer=new AccountService(shop.Db).Login(txtUsername.Text.Trim(),txtPassword.Text);shop.Customer=customer;txtPassword.Clear();DialogResult=DialogResult.OK;Close();});
   FormActions.Wire(this,btnRegister,()=>{using(var f=new FrmRegister(shop))f.ShowDialog(this);});FormActions.Wire(this,btnClose,Close);
  }

 }
}
