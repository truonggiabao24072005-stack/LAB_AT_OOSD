using System;
using System.IO;
using System.Xml.Linq;
namespace QuanLyBanHang {
 public class MockPaymentAdapter : IPaymentAdapter {
  static readonly object Gate=new object();
  public static string Folder {get{return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"LAB4_eShopping","PaymentMock");}}
  public PaymentReply Pay(Guid key,decimal amount,CardInput card,string scenario){
   lock(Gate){
    Directory.CreateDirectory(Folder);string file=Path.Combine(Folder,key.ToString("N")+".xml");
    if(File.Exists(file))return Query(key);
    var reply=new PaymentReply {State=scenario=="Từ chối"?"DECLINED":"APPROVED",Reference="MOCK-"+key.ToString("N"),Token="tok_"+key.ToString("N")};
    // Chỉ ghi kết quả giả lập; không ghi số thẻ, chủ thẻ hoặc CSV.
    new XDocument(new XElement("Payment",new XElement("State",reply.State),new XElement("Reference",reply.Reference),new XElement("Token",reply.Token))).Save(file);
    return scenario=="Chờ đối soát"?new PaymentReply {State="UNKNOWN"}:reply;
   }
  }
  public PaymentReply Query(Guid key){
   lock(Gate){string file=Path.Combine(Folder,key.ToString("N")+".xml");
    if(!File.Exists(file))return new PaymentReply {State="UNKNOWN"};
    var x=XDocument.Load(file).Root;
    return new PaymentReply {State=(string)x.Element("State"),Reference=(string)x.Element("Reference"),Token=(string)x.Element("Token")};
   }
  }
 }
}
