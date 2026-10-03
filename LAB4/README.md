# LAB4 - Hệ thống cửa hàng online e-SHOPPING

## Thông tin sinh viên

* Họ và tên: Trương Gia Bảo
* MSSV: 1250080020
* Tên bài: **LAB4 - Hệ thống cửa hàng online e-SHOPPING**

## Môi trường thực hiện

* Hệ điều hành: Windows.
* Visual Studio: 2022.
* Ngôn ngữ: C#.
* Framework: .NET Framework 4.7.2.
* Cơ sở dữ liệu: SQL Server.
* Công cụ quản trị: SQL Server Management Studio (SSMS).
* Truy cập dữ liệu: ADO.NET.

## Nội dung đã thực hiện

* [x] Phân tích nghiệp vụ mua hàng và xác định phạm vi của e-SHOPPING với ba dịch vụ bên ngoài: quản lý sản phẩm, thanh toán trực tuyến và email.
* [x] Xác định tác nhân, use case tổng quát và các quan hệ; đặc tả ba use case tiêu biểu trong báo cáo.
* [x] Phân tích và thiết kế lớp, biểu đồ trạng thái, hoạt động, tuần tự và phân công xử lý theo chức năng.
* [x] Thiết kế CSDL SQL Server, xác định khóa chính, khóa ngoại và ràng buộc giữa các bảng.
* [x] Xây dựng prototype WinForms theo kiến trúc UI → Service/Adapter → Data.
* [x] Chèn ảnh các Form tương ứng vào báo cáo Word.

### Module / Form

* `FrmMain`: màn hình chính, mở các chức năng và hiển thị khách đang đăng nhập.
* `FrmCatalog`: xem danh sách sản phẩm, lọc theo nhóm, xem chi tiết và thêm vào giỏ.
* `FrmProductDetail`: xem mô tả, thông số, hình ảnh và chọn số lượng sản phẩm.
* `FrmCart`: cập nhật số lượng, xóa sản phẩm, xem tiền tạm tính và chuyển sang đặt hàng.
* `FrmRegister`: đăng ký tài khoản, kiểm tra các trường bắt buộc và tên đăng nhập.
* `FrmLogin`: xác thực tài khoản và tạo phiên khách hàng.
* `FrmCheckout`: nhập người nhận, chọn giao hàng, tính tổng và xác nhận thanh toán.
* `FrmOrderResult`: xem đơn của khách, chi tiết đơn, đối soát thanh toán và gửi lại email.
* `FrmEmailPreview`: xem nội dung email xác nhận đã được tạo.

## Kết quả

* Kết quả build: Debug và Release thành công bằng MSBuild của Visual Studio 2022.
* Kết quả chạy: đã mở các Form và chụp ảnh giao diện để đưa vào báo cáo.
* Phạm vi prototype: thực hiện luồng xem sản phẩm → giỏ hàng → đăng nhập → đặt hàng → xem kết quả đơn.
* Thanh toán và email sử dụng Adapter giả lập. Chương trình không thu tiền hoặc gửi email thật.

## Lỗi gặp phải và cách khắc phục

| Lỗi thực tế | Nguyên nhân đã xác định | Cách khắc phục | Kết quả sau sửa |
| --- | --- | --- | --- |
| Visual Studio báo không tìm thấy `SP01.png`. | Ảnh trong `Assets` có tên `SP01.jpg`, nhưng project và XML sản phẩm vẫn trỏ tới `.png`. | Đổi đường dẫn trong `QuanLyBanHang.csproj` và `Adapters/SanPhamMau.xml` sang `SP01.jpg`. | Build Debug và Release thành công; các đường dẫn ảnh sản phẩm đều tồn tại. |

## Cấu trúc thư mục

Source được giữ theo cấu trúc project Visual Studio hiện có. Mỗi Form có file `.cs` và `.Designer.cs`, có thể chỉnh bằng Windows Forms Designer. `Program.cs` mở `FrmMain`; `Form1` ban đầu không dùng làm màn hình khởi động.

```text
LAB_AT_OOSD/
└── LAB4/
    ├── README.md
    └── QuanLyBanHang/
        ├── QuanLyBanHang.sln
        ├── 1250080020_TruongGiaBao_CNPM1_LAB04.docx
        └── QuanLyBanHang/
            ├── App.config
            ├── Program.cs
            ├── QuanLyBanHang.csproj
            ├── Forms/       # Giao diện và xử lý sự kiện
            ├── Services/    # Xử lý nghiệp vụ
            ├── Adapters/    # Kết nối giả lập ba dịch vụ ngoài
            ├── Data/        # Truy vấn và giao dịch SQL
            ├── Models/      # Các lớp dữ liệu
            ├── Assets/      # Hình ảnh sản phẩm
            └── Properties/  # Cấu hình và tài nguyên project
```

Hai script `01_TaoDatabase.sql` và `02_DuLieuMau.sql` đã được chuẩn bị, hiện lưu tại `C:\Users\LAPTOP ASUS\Documents\Newproject\lab4_code_stage\SQL`. Trước khi đóng gói bài nộp, đặt hai file này vào `LAB4/SQL/`. Các file sơ đồ draw.io/XML được để cùng phần UML của bài nộp.

Form gọi Service để xử lý nghiệp vụ. Service gọi Adapter khi lấy sản phẩm, thanh toán hoặc gửi email; gọi lớp Data khi đọc và lưu SQL Server. Câu SQL được đặt trong lớp Data.

## Hướng dẫn để giảng viên kiểm tra/chạy lại

1. Mở `QuanLyBanHang/QuanLyBanHang.sln` bằng Visual Studio 2022.
2. Kiểm tra project dùng .NET Framework 4.7.2.
3. Mở hai script SQL trong SSMS, chạy `01_TaoDatabase.sql` trước, sau đó chạy `02_DuLieuMau.sql`. Database được tạo là `EShopping_LAB4`.
4. Sửa `QuanLyBanHang/QuanLyBanHang/App.config` cho đúng tên SQL Server trên máy.
5. Chọn Build Solution, rồi nhấn F5 để chạy chương trình.
6. Đăng nhập tài khoản mẫu hoặc đăng ký tài khoản mới.
7. Xem sản phẩm, thêm vào giỏ, cập nhật số lượng, đặt hàng và xem đơn trong Đơn hàng của tôi.
8. Đối chiếu giao diện với báo cáo Word và các sơ đồ UML.

### Cấu hình kết nối SQL Server

Connection string mặc định dùng Windows Authentication:

```xml
<add name="Shop"
     connectionString="Data Source=.;Initial Catalog=EShopping_LAB4;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=5"
     providerName="System.Data.SqlClient" />
```

Nếu dùng SQL Server Express, thay `Data Source=.` bằng `.\SQLEXPRESS`, hoặc dùng đúng tên server đang kết nối trong SSMS. Hai script tạo CSDL và dữ liệu mẫu không xóa database đang có; chúng không chuyển đổi schema của một database cũ khác cấu trúc.

### Tài khoản và dữ liệu mẫu

* Tên đăng nhập: `lab04_demo`.
* Mật khẩu: `Lab04demo!`.
* Thẻ VISA giả lập: `4111111111111111`, mã CSV: `123`.
* Chủ thẻ: `LAB4 DEMO`; chọn hạn sử dụng trong tương lai.

Trong Form đặt hàng, có thể chọn kết quả giả lập Thành công, Từ chối hoặc Chờ đối soát. Sản phẩm mẫu được đọc từ `Adapters/SanPhamMau.xml`; đường dẫn hình trong XML phải khớp với file trong `Assets`.

### Quy tắc trọng tâm

* Chỉ thêm sản phẩm còn hàng; số lượng phải lớn hơn 0.
* Khách phải đăng nhập trước khi xác nhận đặt hàng. Người nhận có thể khác người mua.
* Tổng thanh toán gồm tiền hàng, phí giao và lệ phí thẻ. Khi đổi lựa chọn hoặc số lượng, cần tính lại tổng.
* Giao nhanh miễn phí khi tiền hàng từ 1.000.000đ; giao trong ngày miễn phí khi tiền hàng từ 5.000.000đ.
* Giá và tình trạng sản phẩm được đọc lại trước khi xác nhận; đơn lưu giá tại thời điểm mua.
* Chỉ xác nhận đơn khi thanh toán được chấp thuận. Kết quả chưa rõ được đối soát theo mã yêu cầu cũ.
* Email lỗi không làm thay đổi đơn đã xác nhận; khách có thể thử gửi lại.

## Bằng chứng và dữ liệu minh họa

Ảnh giao diện đã được chèn vào báo cáo theo từng Form. Khi hoàn thiện bài nộp, bổ sung ảnh Solution Explorer, database và danh sách bảng nếu cần.

Dữ liệu sản phẩm, biểu phí và thông tin thanh toán dùng để minh họa bài LAB. Email giả lập được ghi thành file tại `%LOCALAPPDATA%\LAB4_eShopping\EmailMock`; kết quả thanh toán giả lập được lưu tại `%LOCALAPPDATA%\LAB4_eShopping\PaymentMock`. CSDL không lưu số thẻ đầy đủ hoặc mã CSV.

## Kiểm tra Git và nộp bài

Nếu nộp qua repository, chạy tại thư mục gốc `LAB_AT_OOSD`:

```bash
git status
git add LAB4
git commit -m "Hoan thanh LAB4 e-SHOPPING"
git push
```

Sau khi push, kiểm tra các file LAB4 trên repository rồi nộp URL theo yêu cầu của giảng viên. Báo cáo Word, source, SQL và sơ đồ cần được đặt đầy đủ trong thư mục bài nộp.

## Danh mục sản phẩm nộp bài

* [x] Báo cáo Word đã có ảnh các Form.
* [x] Solution Visual Studio 2022 và source code C# WinForms.
* [ ] Đặt hai script SQL đã chuẩn bị vào `LAB4/SQL/`.
* [ ] Đưa file UML/draw.io/XML đã làm vào thư mục bài nộp.
* [ ] Kiểm tra và nộp URL repository nếu giảng viên yêu cầu.
