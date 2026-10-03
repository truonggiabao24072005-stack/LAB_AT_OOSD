using System.Collections.Generic;
namespace QuanLyBanHang {
 public class ProductService {
  readonly IProductAdapter adapter; public ProductService(IProductAdapter a){adapter=a;}
  public List<Product> List(string group){return adapter.List(group);}
  public Product Get(string code){return adapter.Get(code);}
 }
 public class CartService {
  readonly Cart cart;readonly ProductService products;
  public CartService(Cart c,ProductService p){cart=c;products=p;}
  public void Add(string code){var p=products.Get(code);var line=cart.Lines.Find(x=>x.Code==code);cart.Set(p,line==null?1:line.Quantity+1);}
  public void Update(string code,int quantity){cart.Set(products.Get(code),quantity);}
  public void Remove(string code){cart.Remove(code);}
 }
}
