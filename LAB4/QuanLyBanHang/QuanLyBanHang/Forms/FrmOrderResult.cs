using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmOrderResult : Form {
  private ShopContext shop;
  public FrmOrderResult(){InitializeComponent();}
  public FrmOrderResult(ShopContext context):this(){shop=context;}
  private bool loading;
  private void FrmOrderResult_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   dgvOrders.SelectionChanged+=(s,a)=>{if(!loading)FormActions.Run(this,LoadDetail);};
   FormActions.Wire(this,btnReload,Reload);FormActions.Wire(this,btnClose,Close);
   FormActions.Wire(this,btnReconcile,()=>{Guid id=FormActions.OrderId(dgvOrders);string state=shop.Checkout.Reconcile(id,shop.Customer.Id);
    if(state=="DA_XAC_NHAN" && shop.PendingOrder==id && shop.PendingCartSignature==shop.CartSignature()){shop.Cart.Lines.Clear();shop.PendingOrder=null;}
    shop.EmailAdapter.Fail=chkEmailFail.Checked;shop.Email.Flush(shop.Customer.Id);Reload();MessageBox.Show(this,OrderService.StateLabel(state));});
   FormActions.Wire(this,btnEmail,()=>{FormActions.Require(shop.Customer!=null,"Cần đăng nhập.");shop.EmailAdapter.Fail=chkEmailFail.Checked;shop.Email.Flush(shop.Customer.Id);Reload();MessageBox.Show(this,"Đã xử lý hàng đợi email. Xem cột Email để biết kết quả.");});
   FormActions.Wire(this,btnReadEmail,()=>{var body=new OrderService(shop.Db).EmailBody(FormActions.OrderId(dgvOrders),shop.Customer.Id);FormActions.Require(!string.IsNullOrEmpty(body),"Đơn chưa có email xác nhận (chưa thành công hoặc tài khoản không cung cấp email).");using(var f=new FrmEmailPreview(body))f.ShowDialog(this);});
   FormActions.Run(this,Reload);
  }
  private void Reload(){FormActions.Require(shop.Customer!=null,"Cần đăng nhập để xem đơn.");loading=true;try{dgvOrders.DataSource=new OrderService(shop.Db).List(shop.Customer.Id);}finally{loading=false;}LoadDetail();chkEmailFail.Checked=shop.EmailAdapter.Fail;}
  private void LoadDetail(){if(dgvOrders.CurrentRow==null){dgvLines.DataSource=null;lblInfo.Text="Chưa có đơn hàng.";btnReconcile.Enabled=false;return;}
   var orders=new OrderService(shop.Db);Guid id=FormActions.OrderId(dgvOrders);dgvLines.DataSource=orders.Detail(id,shop.Customer.Id);var info=orders.Info(id,shop.Customer.Id);lblInfo.Text=info;
   string state=orders.State(id,shop.Customer.Id);btnReconcile.Enabled=state=="CHO_DOI_SOAT"||state=="CHO_THANH_TOAN";
  }

 }
}
