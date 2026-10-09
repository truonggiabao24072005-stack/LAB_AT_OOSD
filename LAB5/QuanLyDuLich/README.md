# LAB5 Quản lý công ty du lịch Văn Hóa Việt

**Trương Gia Bảo — MSSV 1250080020**

Bài hiện thực từ `Bai_6_Quan_ly_cong_ty_du_lich.docx`, theo cấu trúc source và phong cách giao diện của LAB4. Project giữ .NET Framework 4.7.2, C# WinForms và ADO.NET. Form gọi Service, Service gọi Data/Db; các thao tác đăng ký, hủy, phân công, thanh toán và khảo sát dùng thủ tục SQL. Các Form có file `.cs` và `.Designer.cs` để mở trong Windows Forms Designer.

## Mở và chạy bài

1. Mở SQL Server Management Studio, kết nối server `.` bằng Windows Authentication. Trên máy đã kiểm tra, tên server đầy đủ là `LAPTOP-MTOTO8R6`.
2. Mở **SQL/01_TaoDatabase.sql**, chạy toàn bộ file. Script tạo database `QuanLyDuLich_LAB5`, 16 bảng, khóa, ràng buộc, các thủ tục và view.
3. Mở **SQL/02_DuLieuMau.sql**, chạy toàn bộ file để thêm dữ liệu mẫu.
4. Mở **QuanLyDuLich.sln** bằng Visual Studio 2022, chọn project QuanLyDuLich làm Startup Project.
5. Build Solution, nhấn F5. Màn hình khởi động là `FrmMain`.

Nếu máy dùng instance Express, sửa `Data Source=.` thành `.\SQLEXPRESS` hoặc đúng tên server đang kết nối trong SSMS tại `QuanLyDuLich/App.config`. Tên database giữ `QuanLyDuLich_LAB5`. Script không xóa database/bảng hoặc ghi đè dữ liệu mẫu đã có. Chạy lại file 01 sẽ cập nhật các thủ tục; file 02 chỉ thêm mã chưa tồn tại. Nếu database cùng tên có schema khác, dùng một database mới; không chạy để chuyển đổi schema cũ.

```xml
<add name="DuLich"
     connectionString="Data Source=.;Initial Catalog=QuanLyDuLich_LAB5;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=5"
     providerName="System.Data.SqlClient" />
```

## Các màn hình

| Form | Người sử dụng và chức năng |
| --- | --- |
| FrmMain | Mở 12 chức năng quản lý công ty du lịch |
| FrmPhuongTien | NV điều hành thêm, sửa, xóa danh mục phương tiện |
| FrmDiemThamQuan | NV điều hành quản lý tên, địa điểm, nội dung, ý nghĩa |
| FrmDiemBanVe | NV điều hành quản lý điểm bán vé và liên hệ |
| FrmHuongDanVien | NV điều hành quản lý HDV, lương cơ bản, tình trạng làm việc |
| FrmTour | Quản lý tour với 4 tab: Tour, Điểm dừng, Phương tiện từng chặng, Điểm tham quan |
| FrmChuyenLe | Tạo lịch chuyến, tính ngày về, đóng đăng ký |
| FrmDangKyLe | NV bán vé lập phiếu và xác nhận đã thu đủ tiền vé |
| FrmDangKyDoan | NV kinh doanh lập phiếu đoàn, thu cọc, nhập thành viên, hủy mất cọc |
| FrmPhanCongHDV | Phân công hoặc gỡ HDV trước khởi hành, kiểm tra lịch |
| FrmThanhToanDoan | Kế toán thu kinh phí sau tour và xem lịch sử thanh toán |
| FrmKhaoSat | NV CSKH ghi nhận gửi phiếu, nhập điểm và góp ý |
| FrmLuongThongKe | Kế toán tính lương tháng và thống kê khoảng ngày |

Màu nền, tiêu đề xanh, Segoe UI, bố trí nút và bảng có hàng xen kẽ được giữ theo LAB4. Các danh mục dùng **Nhập mới → Thêm**; chọn dòng rồi **Lưu sửa**. Danh mục đã được sử dụng không xóa được do khóa ngoại. Các vai trò trên là phân công nghiệp vụ; prototype không có module đăng nhập/phân quyền vì đề không yêu cầu.

## Chạy các luồng cốt lõi

### Tour mới và hành trình

1. Mở Tour và hành trình, Nhập tour mới; nhập `T004`, Phú Quốc, 3 ngày, 2 đêm, 5.500.000đ. Để **Đang mở bán** không chọn và nhấn Thêm tour.
2. Chọn T004 trong bảng. Ở tab Điểm dừng, thêm thứ tự 1 `TP.HCM`, 2 `Phú Quốc`, 3 `TP.HCM`. Tại điểm 2 có thể chọn khách sạn 4 sao.
3. Tab Phương tiện: gắn `PT02` cho chặng 1 và 2. Chặng k nối điểm k đến điểm k+1.
4. Tab Điểm tham quan: gắn điểm trong danh mục theo thứ tự tham quan.
5. Quay lại tab Tour, chọn **Đang mở bán**, nhấn Lưu / mở bán. Hệ thống chỉ mở khi hành trình liên tục, xuất phát/kết thúc TP.HCM và mỗi chặng có phương tiện.

Tour đã có chuyến hoặc đăng ký được giữ hành trình và số ngày để bảo toàn lịch cũ. Có thể đổi giá cho lần bán mới; phiếu đã lập giữ tiền tại thời điểm đăng ký. Muốn đổi hành trình thì tạo mã tour mới.

### Khách lẻ

Chọn CL002, DB01, số phiếu DKL003, nhập khách và 4 người. Tiền vé = 2.500.000 × 4 = **10.000.000đ**. Nhấn Đăng ký và thu vé, xác nhận nhân viên đã thu đủ. Không chọn được chuyến đã đóng hoặc đến ngày khởi hành. Giới hạn khách lẻ 1–11 người.

### Khách đoàn và hủy mất cọc

Lập DD003, mã đoàn DOAN03, T001, ngày đi trong tương lai, 15 người, cọc 10.000.000đ. Tổng dự kiến **37.500.000đ**, ngày kết thúc = ngày đi + 2. Nếu mua bảo hiểm, nhập đủ 15 dòng thành viên; ngày sinh dùng dd/MM/yyyy hoặc để trống. Cọc là khoản nhân viên xác nhận đã thu; không có kết nối thanh toán ngoài.

Chọn phiếu chưa khởi hành rồi Hủy mất cọc: trạng thái chuyển sang **Hủy - mất cọc**, giữ tiền cọc, gỡ toàn bộ phân công gắn phiếu trong cùng giao dịch. Phiếu và danh sách thành viên vẫn được lưu để đối chiếu. Không thể hủy phiếu đã khởi hành, đã hủy hoặc đã thanh toán đủ.

### Phân công HDV

Chọn HDV, loại `LE` hoặc `DOAN`, đối tượng và nhập thù lao. Mỗi chuyến lẻ chỉ có tối đa một phân công trong giai đoạn chuẩn bị; nhân viên phải bố trí đủ một HDV trước khởi hành. Một đoàn có thể nhiều HDV. Lịch giao nhau dù chỉ một ngày cũng bị từ chối. Hai nhân viên thao tác cùng lúc được kiểm tra trong giao dịch có khóa SQL. Thù lao do nhân viên nhập vì đề chưa cho biểu mức.

### Thanh toán, khảo sát, lương

- DD001 trong dữ liệu mẫu đã kết thúc 12/09/2026, tổng 50.000.000đ, cọc 10.000.000đ, còn **40.000.000đ**. Có thể thanh toán nhiều lần; lần cuối chuyển phiếu sang Đã hoàn tất thanh toán. Không thu trước hoặc đúng ngày kết thúc, không thu vượt số còn nợ và không ghi ngày ở tương lai.
- Khảo sát: chọn loại DOAN, chọn DD001, nhập KS002 và ghi nhận gửi phiếu. Chọn phiếu trong bảng, nhập điểm 1–5 và góp ý rồi Lưu phản hồi. Mỗi đăng ký có một khảo sát; ngày phản hồi phải từ ngày gửi trở đi. Việc gửi qua email/bưu điện do nhân viên thực hiện; ứng dụng lưu việc gửi và phản hồi.
- Lương tháng **09/2026** theo dữ liệu gốc: HDV01 **10.500.000đ**, HDV02 **11.500.000đ**, HDV03 **10.500.000đ**. Chỉ cộng thù lao tour đã kết thúc trong tháng. Các ngày tương lai mẫu được tính từ ngày chạy file 02 lần đầu; các lần chạy lại không tự dời lịch đã có.

## Cấu trúc nộp bài

```text
QuanLyDuLich/
├── QuanLyDuLich.sln
├── README.md
├── PHAN_TICH_LAB5.md
├── BAI_LAB5.docx
├── SQL/
│   ├── 01_TaoDatabase.sql
│   ├── 02_DuLieuMau.sql
│   └── 03_KiemTraDuLieu.sql
├── Tests/
│   ├── IntegrationTests.cs
│   ├── FormSmokeTests.cs
│   ├── RunTests.ps1
│   └── KetQuaKiemThu.txt
└── QuanLyDuLich/
    ├── App.config
    ├── Program.cs
    ├── QuanLyDuLich.csproj
    ├── Forms/
    ├── Services/
    ├── Data/
    ├── Models/
    └── Properties/
```

BAI_LAB5.docx là bản báo cáo đã chỉnh theo yêu cầu trước: giữ sơ đồ gốc, xóa code và ảnh Form, có các vị trí để tự dán hình. Nội dung kỹ thuật và hướng dẫn chạy nằm trong source, SQL, README và PHAN_TICH_LAB5.md. Bộ test tạo database riêng có tiền tố `QuanLyDuLich_LAB5_Test_`; không chạy test vào database sử dụng của bài.

## Kiểm chứng

Kết quả thực tế và ngày kiểm tra được lưu tại `Tests/KetQuaKiemThu.txt`. Có 30 kiểm thử nghiệp vụ, gồm rollback khi lập phiếu lỗi, quy tắc khách lẻ/đoàn, bảo hiểm, lịch HDV, thanh toán, khảo sát và hai kiểm thử đồng thời. `FormSmokeTests` mở 13 Form ở vị trí ngoài màn hình để kiểm tra tải dữ liệu và render giao diện. Để chạy lại: mở PowerShell tại thư mục solution và chạy `powershell -ExecutionPolicy Bypass -File Tests\RunTests.ps1`. Script mặc định xóa database kiểm thử mà chính lần chạy tạo ra khi hoàn tất; dùng `-KeepDatabase` nếu muốn xem lại trong SSMS.
