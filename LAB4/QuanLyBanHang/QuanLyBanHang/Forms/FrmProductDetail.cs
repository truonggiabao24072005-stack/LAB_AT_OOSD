using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmProductDetail : Form {
  private ShopContext shop;
  public FrmProductDetail(){InitializeComponent();}
  public FrmProductDetail(ShopContext context):this(){shop=context;}
  private string productCode;private Product product;private int imageIndex;
  public FrmProductDetail(ShopContext context,string code):this(context){productCode=code;}
  private void FrmProductDetail_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   FormActions.Run(this,()=>{product=shop.Products.Get(productCode??"SP01");lblName.Text=product.Name;lblInfo.Text="Mã SP: "+product.Code+" | Nhóm: "+product.Group+"\nNhà sản xuất: "+product.Manufacturer+"\nGiá: "+product.Price.ToString("N0")+"đ | "+(product.Available?"Còn hàng":"Hết hàng");txtDescription.Text=product.Description;txtSpecs.Text=product.Specs;btnAdd.Enabled=product.Available;ShowImage();});
   FormActions.Wire(this,btnPrev,()=>{imageIndex--;ShowImage();});FormActions.Wire(this,btnNext,()=>{imageIndex++;ShowImage();});
   FormActions.Wire(this,btnAdd,()=>{var old=shop.Cart.Lines.Find(x=>x.Code==product.Code);shop.Basket.Update(product.Code,(old==null?0:old.Quantity)+(int)numQuantity.Value);MessageBox.Show(this,"Đã thêm vào giỏ.");});
   FormActions.Wire(this,btnClose,Close);FormClosed+=(s,a)=>{if(picProduct.Image!=null)picProduct.Image.Dispose();};
  }
  private void ShowImage(){
   if(picProduct.Image!=null){picProduct.Image.Dispose();picProduct.Image=null;}
   if(product.Images.Count==0)return;imageIndex=(imageIndex+product.Images.Count)%product.Images.Count;
   if(File.Exists(product.Images[imageIndex]))using(var im=Image.FromFile(product.Images[imageIndex]))picProduct.Image=new Bitmap(im);
   btnPrev.Enabled=btnNext.Enabled=product.Images.Count>1;
  }

 }
}
