using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmCheckout : Form {
  private ShopContext shop;
  public FrmCheckout(){InitializeComponent();}
  public FrmCheckout(ShopContext context):this(){shop=context;}
  private Guid request=Guid.NewGuid();private Quote quote;private bool loading,submitted;private CheckoutResult last;
  private void FrmCheckout_Load(object sender,EventArgs e){
   if(FormActions.IsDesign)return;FormActions.Fit(this);if(shop==null)shop=new ShopContext();
   btnSubmit.Enabled=false;btnNew.Enabled=false;
   FormActions.Run(this,()=>{FormActions.Require(shop.Customer!=null,"Cần đăng nhập.");FormActions.Require(shop.Cart.Lines.Count>0,"Giỏ hàng đang trống.");
    loading=true;var lookups=new LookupService(shop.Db);FormActions.Bind(cboRegion,lookups.Regions(),"MaKV","TenKV");FormActions.Bind(cboShipping,lookups.Shipping(),"MaLoai","TenLoai");FormActions.Bind(cboCard,lookups.Cards(),"MaThe","TenThe");
    cboScenario.Items.AddRange(new object[]{"Thành công","Từ chối","Chờ đối soát"});cboScenario.SelectedIndex=0;dtExpiry.Value=DateTime.Today.AddYears(1);
    txtName.Text=shop.Customer.Name;txtAddress.Text=shop.Customer.Address;txtPhone.Text=shop.Customer.Phone;loading=false;
   });
   cboRegion.SelectedIndexChanged+=(s,a)=>InvalidateQuote();cboShipping.SelectedIndexChanged+=(s,a)=>InvalidateQuote();cboCard.SelectedIndexChanged+=(s,a)=>InvalidateQuote();
   FormActions.Wire(this,btnCalculate,Calculate);FormActions.Wire(this,btnSubmit,Submit);
   FormActions.Wire(this,btnOrders,()=>{using(var f=new FrmOrderResult(shop))f.ShowDialog(this);if(last!=null && new OrderService(shop.Db).State(last.OrderId,shop.Customer.Id)=="DA_XAC_NHAN")Close();});
   FormActions.Wire(this,btnNew,()=>{FormActions.Require(last!=null && last.State=="THANH_TOAN_TU_CHOI","Chỉ đặt lại sau khi đơn cũ đã bị từ chối.");request=Guid.NewGuid();submitted=false;last=null;btnCalculate.Enabled=true;btnNew.Enabled=false;SetInputs(true);InvalidateQuote();});
   FormActions.Wire(this,btnClose,Close);
  }
  private void SetInputs(bool enabled){foreach(Control c in new Control[]{txtName,txtAddress,txtPhone,cboRegion,cboShipping,cboCard,txtNumber,txtOwner,txtCsv,dtExpiry,cboScenario,chkEmailFail})c.Enabled=enabled;}
  private void InvalidateQuote(){if(loading||submitted)return;quote=null;btnSubmit.Enabled=false;lblTotal.Text="Lựa chọn đã thay đổi. Bấm Tính tổng trước khi xác nhận.";}
  private void Calculate(){FormActions.Require(!submitted,"Yêu cầu đã gửi. Xem đơn để đối soát kết quả.");quote=shop.Checkout.Preview(shop.Cart,FormActions.Value(cboRegion),FormActions.Value(cboShipping),FormActions.Value(cboCard));lblTotal.Text="Tiền hàng: "+quote.Subtotal.ToString("N0")+"đ  |  Phí giao: "+quote.Shipping.ToString("N0")+"đ  |  Lệ phí thẻ: "+quote.CardFee.ToString("N0")+"đ\nTổng thanh toán: "+quote.Total.ToString("N0")+"đ";btnSubmit.Enabled=true;}
  private void Submit(){
   FormActions.Require(quote!=null && !submitted,"Hãy tính tổng và xem lại trước khi xác nhận.");
   btnSubmit.Enabled=false;btnCalculate.Enabled=false;UseWaitCursor=true;
   var card=new CardInput {Type=FormActions.Value(cboCard),Number=txtNumber.Text.Trim(),SecurityValue=txtCsv.Text.Trim(),Owner=txtOwner.Text.Trim(),Expiry=dtExpiry.Value};
   string signature=shop.CartSignature();
   try {
    shop.EmailAdapter.Fail=chkEmailFail.Checked;
    last=shop.Checkout.Submit(shop.Customer,shop.Cart,txtName.Text.Trim(),txtAddress.Text.Trim(),txtPhone.Text.Trim(),FormActions.Value(cboRegion),FormActions.Value(cboShipping),card,request,quote.Total,cboScenario.Text);
    submitted=true;SetInputs(false);shop.PendingOrder=last.OrderId;shop.PendingCartSignature=signature;
    string message="Mã đơn: "+last.OrderId+"\nTổng tiền: "+last.Total.ToString("N0")+"đ\n"+OrderService.StateLabel(last.State);
    // Lỗi email không làm mất kết quả đặt hàng.
    try {shop.Email.Flush(shop.Customer.Id);}catch {message+="\nEmail chưa xử lý xong. Có thể thử lại ở màn hình đơn hàng.";}
    lblTotal.Text=OrderService.StateLabel(last.State);btnNew.Enabled=last.State=="THANH_TOAN_TU_CHOI";
    MessageBox.Show(this,message,"Kết quả đặt hàng");
    if(last.State=="DA_XAC_NHAN"){using(var f=new FrmOrderResult(shop))f.ShowDialog(this);Close();}
   } catch {
    // Nếu đã lưu yêu cầu nhưng mất kết quả, khóa gửi lại; dùng truy vấn kết quả cũ.
    CheckoutResult saved=null;
    try {saved=new OrderService(shop.Db).ByRequest(request,shop.Customer.Id);}catch {submitted=true;SetInputs(false);lblTotal.Text="Kết nối bị gián đoạn. Kiểm tra Đơn hàng của tôi trước khi thử đặt lại.";}
    if(saved!=null){last=saved;submitted=true;shop.PendingOrder=saved.OrderId;shop.PendingCartSignature=signature;SetInputs(false);lblTotal.Text="Đã lưu yêu cầu. Mở Xem đơn / Đối soát để kiểm tra; không tạo yêu cầu mới.";btnNew.Enabled=saved.State=="THANH_TOAN_TU_CHOI";}
    else if(!submitted) {quote=null;lblTotal.Text="Chưa gửi yêu cầu. Kiểm tra thông tin và tính tổng lại.";}
    throw;
   } finally {txtNumber.Clear();txtCsv.Clear();card.Number=null;card.SecurityValue=null;UseWaitCursor=false;btnCalculate.Enabled=!submitted;btnSubmit.Enabled=false;}
  }

 }
}
