using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmRegister : Form {
  private ShopContext shop;
  public FrmRegister(){InitializeComponent();}
  public FrmRegister(ShopContext context):this(){shop=context;}
  private void FrmRegister_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();dtBirth.MaxDate=DateTime.Today;dtBirth.Value=new DateTime(2000,1,1);
   FormActions.Wire(this,btnRegister,()=>{FormActions.Require(txtPassword.Text==txtConfirm.Text,"Mật khẩu nhập lại chưa khớp.");
    var x=new Customer {Name=txtName.Text.Trim(),Identity=txtIdentity.Text.Trim(),Address=txtAddress.Text.Trim(),Phone=txtPhone.Text.Trim(),Username=txtUsername.Text.Trim(),Email=txtEmail.Text.Trim(),BirthDate=dtBirth.Value};
    new AccountService(shop.Db).Register(x,txtPassword.Text);txtPassword.Clear();txtConfirm.Clear();MessageBox.Show(this,"Đăng ký thành công. Bạn có thể đăng nhập bằng tài khoản mới.","Thông báo");DialogResult=DialogResult.OK;Close();});
   FormActions.Wire(this,btnClose,Close);
  }

 }
}
