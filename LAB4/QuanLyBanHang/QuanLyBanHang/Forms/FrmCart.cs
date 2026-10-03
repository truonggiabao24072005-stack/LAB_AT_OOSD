using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmCart : Form {
  private ShopContext shop;
  public FrmCart(){InitializeComponent();}
  public FrmCart(ShopContext context):this(){shop=context;}
  private void FrmCart_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   dgvCart.SelectionChanged+=(s,a)=>{var x=dgvCart.CurrentRow==null?null:dgvCart.CurrentRow.DataBoundItem as CartLine;if(x!=null)numQuantity.Value=x.Quantity;};
   FormActions.Wire(this,btnUpdate,()=>{shop.Basket.Update(Code(),(int)numQuantity.Value);Reload();});
   FormActions.Wire(this,btnRemove,()=>{shop.Basket.Remove(Code());Reload();});
   FormActions.Wire(this,btnCheckout,()=>{FormActions.Require(shop.Cart.Lines.Count>0,"Giỏ hàng đang trống.");if(FormActions.Login(this,shop)){using(var f=new FrmCheckout(shop))f.ShowDialog(this);}Reload();});
   FormActions.Wire(this,btnClose,Close);Reload();
  }
  private string Code(){FormActions.Require(dgvCart.CurrentRow!=null,"Chọn một dòng trong giỏ.");return ((CartLine)dgvCart.CurrentRow.DataBoundItem).Code;}
  private void Reload(){dgvCart.DataSource=null;dgvCart.DataSource=shop.Cart.Lines.ToList();lblTotal.Text="Tiền hàng tạm tính: "+shop.Cart.Subtotal.ToString("N0")+"đ";btnCheckout.Enabled=shop.Cart.Lines.Count>0;}

 }
}
