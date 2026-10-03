using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
namespace QuanLyBanHang {
 // Dữ liệu này đại diện hệ thống quản lý sản phẩm bên ngoài, không nằm trong DB e-SHOPPING.
 public class MockProductAdapter : IProductAdapter {
  public List<Product> Products {get;private set;}
  public MockProductAdapter(){Reload();}
  public void Reload(){
   string file=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Adapters","SanPhamMau.xml");
   Products=XDocument.Load(file).Root.Elements("Product").Select(x=>new Product {
    Code=(string)x.Attribute("Code"), Name=(string)x.Element("Name"), Group=(string)x.Element("Group"),
    Manufacturer=(string)x.Element("Manufacturer"), Description=(string)x.Element("Description"),
    Specs=(string)x.Element("Specs"), Price=(decimal)x.Element("Price"), Available=(bool)x.Element("Available"),
    Images=x.Elements("Image").Select(a=>Path.Combine(AppDomain.CurrentDomain.BaseDirectory,(string)a)).ToList()
   }).ToList();
  }
  public List<Product> List(string group){Reload();return Products.Where(p=>group=="Tất cả"||p.Group==group).ToList();}
  public Product Get(string code){Reload();var p=Products.FirstOrDefault(x=>x.Code==code);
   if(p==null)throw new Exception("Không tìm thấy sản phẩm.");return p;}
 }
}
