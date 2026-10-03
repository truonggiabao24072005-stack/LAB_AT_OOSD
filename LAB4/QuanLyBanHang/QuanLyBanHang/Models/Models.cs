using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLyBanHang {
 public class Product {
  public string Code, Name, Group, Manufacturer, Description, Specs;
  public List<string> Images = new List<string>();
  public decimal Price; public bool Available;
 }
 public class CartLine {
  public string Code {get;set;} public string Name {get;set;}
  public decimal UnitPrice {get;set;} public int Quantity {get;set;}
  public decimal Total {get {return UnitPrice*Quantity;}}
 }
 public class Cart {
  public List<CartLine> Lines = new List<CartLine>();
  public void Set(Product p,int quantity) {
   if(quantity<1 || quantity>1000) throw new Exception("Số lượng phải từ 1 đến 1000.");
   if(!p.Available) throw new Exception("Sản phẩm đã hết hàng.");
   var x=Lines.FirstOrDefault(a=>a.Code==p.Code);
   if(x==null) Lines.Add(new CartLine {Code=p.Code,Name=p.Name,
     UnitPrice=p.Price,Quantity=quantity});
   else {x.Quantity=quantity;x.UnitPrice=p.Price;}
  }
  public void Remove(string code){Lines.RemoveAll(x=>x.Code==code);}
  public decimal Subtotal {get{return Lines.Sum(x=>x.Total);}}
 }
 public class Customer {
  public int Id; public string Name, Address, Phone, Identity, Username, Email;
  public DateTime BirthDate;
 }
 public class CardInput {
  public string Type, Number, SecurityValue, Owner;
  public DateTime Expiry;
 }
 public class Quote {
  public decimal Subtotal,Shipping,CardFee;
  public decimal Total {get{return Subtotal+Shipping+CardFee;}}
 }
 public class PaymentReply {
  public string State,Reference,Token;
 }
 public class CheckoutResult {
  public Guid OrderId; public string State; public decimal Total;
 }
 public interface IProductAdapter {
  List<Product> List(string group); Product Get(string code);
 }
 public interface IPaymentAdapter {
  PaymentReply Pay(Guid key,decimal amount,CardInput card,string scenario);
  PaymentReply Query(Guid key);
 }
 public interface IEmailAdapter {
  void Send(string address,string content,Guid messageId);
 }

}
