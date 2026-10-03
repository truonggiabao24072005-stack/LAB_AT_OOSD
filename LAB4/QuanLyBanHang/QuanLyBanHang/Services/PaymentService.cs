using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace QuanLyBanHang {
 public class PaymentService {
  readonly IPaymentAdapter adapter;
  public PaymentService(IPaymentAdapter a){adapter=a;}
  public static void ValidateCard(CardInput x,DateTime today){
   if(x==null)throw new Exception("Chưa nhập thông tin thẻ.");
   int digits=x.Type=="AMEX"?15:16,csv=x.Type=="AMEX"?4:3;
   if(!new[]{"VISA","MASTER","DISCOVER","AMEX"}.Contains(x.Type)||
    !Regex.IsMatch(x.Number??"","^[0-9]{"+digits+"}$")||
    !Regex.IsMatch(x.SecurityValue??"","^[0-9]{"+csv+"}$")||
    string.IsNullOrWhiteSpace(x.Owner)||
    new DateTime(x.Expiry.Year,x.Expiry.Month,1).AddMonths(1).AddDays(-1)<today.Date)
    throw new Exception("Thông tin thẻ không hợp lệ. VISA/Master/Discover: 16 số, CSV 3 số; AMEX: 15 số, CSV 4 số. Thẻ phải còn hạn và có tên chủ thẻ.");
  }

  public PaymentReply Pay(Guid key,decimal amount,CardInput card,string scenario){
   ValidateCard(card,DateTime.Today);return adapter.Pay(key,amount,card,scenario);
  }
  public PaymentReply Query(Guid key){return adapter.Query(key);}
 }
}
