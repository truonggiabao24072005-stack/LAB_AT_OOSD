using System;
using System.IO;
using System.Text;
namespace QuanLyBanHang {
 public class MockEmailAdapter : IEmailAdapter {
  public bool Fail {get;set;}
  public static string Folder {get{return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"LAB4_eShopping","EmailMock");}}
  public void Send(string address,string content,Guid messageId){
   if(Fail)throw new Exception("Dịch vụ email giả lập đang lỗi.");
   Directory.CreateDirectory(Folder);
   File.WriteAllText(Path.Combine(Folder,messageId.ToString("N")+".txt"),"Đến: "+address+Environment.NewLine+content,Encoding.UTF8);
  }
 }
}
