using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanHang.Forms {
 public partial class FrmEmailPreview : Form {
  private ShopContext shop;
  public FrmEmailPreview(){InitializeComponent();}
  public FrmEmailPreview(ShopContext context):this(){shop=context;}
  private string body;
  public FrmEmailPreview(string content):this(){body=content;}
  private void FrmEmailPreview_Load(object sender,EventArgs e){if(FormActions.IsDesign)return;FormActions.Fit(this);txtBody.Text=body??"";FormActions.Wire(this,btnClose,Close);}

 }
}
