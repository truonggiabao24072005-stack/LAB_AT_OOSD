using System;
using System.Linq;
namespace QuanLyBanHang {
 public class ShopContext {
  public readonly Db Db=new Db();public readonly Cart Cart=new Cart();
  public readonly MockProductAdapter ProductAdapter=new MockProductAdapter();
  public readonly MockPaymentAdapter PaymentAdapter=new MockPaymentAdapter();
  public readonly MockEmailAdapter EmailAdapter=new MockEmailAdapter();
  public Customer Customer;
  public Guid? PendingOrder;public string PendingCartSignature;
  public string CartSignature(){return string.Join("|",Cart.Lines.OrderBy(x=>x.Code).Select(x=>x.Code+":"+x.Quantity+":"+x.UnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture)));}
  public ProductService Products {get{return new ProductService(ProductAdapter);}}
  public CartService Basket {get{return new CartService(Cart,Products);}}
  public CheckoutService Checkout {get{return new CheckoutService(Db,ProductAdapter,PaymentAdapter);}}
  public EmailService Email {get{return new EmailService(Db,EmailAdapter);}}
 }
}
