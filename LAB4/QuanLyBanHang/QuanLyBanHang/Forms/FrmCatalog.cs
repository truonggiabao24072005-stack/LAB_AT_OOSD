using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmCatalog : Form {
  private ShopContext shop;
  public FrmCatalog(){InitializeComponent();}
  public FrmCatalog(ShopContext context):this(){shop=context;}
  private void FrmCatalog_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   FormActions.Run(this,()=>{cboGroup.Items.Add("Tất cả");cboGroup.Items.AddRange(shop.Products.List("Tất cả").Select(p=>p.Group).Distinct().Cast<object>().ToArray());cboGroup.SelectedIndex=0;Reload();});
   cboGroup.SelectedIndexChanged+=(s,a)=>FormActions.Run(this,Reload);
   FormActions.Wire(this,btnReload,Reload);FormActions.Wire(this,btnClose,Close);
   FormActions.Wire(this,btnDetail,()=>{using(var f=new FrmProductDetail(shop,Code()))f.ShowDialog(this);Reload();});
   FormActions.Wire(this,btnAdd,()=>{shop.Basket.Add(Code());MessageBox.Show(this,"Đã thêm sản phẩm vào giỏ.","Thông báo");});
   FormActions.Wire(this,btnCart,()=>{using(var f=new FrmCart(shop))f.ShowDialog(this);});
   dgvProducts.CellDoubleClick+=(s,a)=>{if(a.RowIndex>=0)btnDetail.PerformClick();};
  }
  private string Code(){FormActions.Require(dgvProducts.CurrentRow!=null,"Chọn sản phẩm.");return Convert.ToString(dgvProducts.CurrentRow.Cells["dgvProducts_MaSP"].Value);}
  private void Reload(){dgvProducts.DataSource=shop.Products.List(cboGroup.Text).Select(p=>new {MaSP=p.Code,TenSP=p.Name,Nhom=p.Group,NhaSanXuat=p.Manufacturer,Gia=p.Price,TinhTrang=p.Available?"Còn hàng":"Hết hàng"}).ToList();}

 }
}
