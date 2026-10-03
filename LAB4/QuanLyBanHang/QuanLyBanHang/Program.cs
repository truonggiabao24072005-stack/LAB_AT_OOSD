using System;
using System.Windows.Forms;
using QuanLyBanHang.Forms;
namespace QuanLyBanHang {
 internal static class Program {
  [STAThread] static void Main(){Application.EnableVisualStyles();Application.SetCompatibleTextRenderingDefault(false);
   try{Application.Run(new FrmMain(new ShopContext()));}catch(Exception ex){MessageBox.Show("Không mở được chương trình. Kiểm tra dữ liệu sản phẩm trong Adapters/SanPhamMau.xml.\n"+ex.Message,"e-SHOPPING",MessageBoxButtons.OK,MessageBoxIcon.Error);}
  }
 }
}
