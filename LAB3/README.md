# LAB3 - Hệ thống quản lý khách sạn



## Thông tin sinh viên

* Họ và tên: Trương Gia Bảo
* MSSV: 1250080020
* Tên bài: **LAB3 - Hệ thống quản lý khách sạn**

## Môi trường thực hiện

Điền phiên bản thực tế trong máy bạn:

* Hệ điều hành:
* Visual Studio: 2022
* Ngôn ngữ: C#
* Framework: NET Framework 4.7.2
* SQL Server:
* Công cụ quản trị SQL: SQL Server

## Nội dung đã thực hiện

Đánh dấu và sửa các dòng cho đúng với sản phẩm thực tế:

* \[ ] Khảo sát nghiệp vụ và phân loại lưu trữ, tra cứu, tính toán, kết xuất/thống kê.
* \[ ] Xác định Actor, Use Case, đặc tả Use Case, lớp, ID, association và multiplicity.
* \[ ] Vẽ Use Case tổng quát và phân rã; biểu đồ lớp phân tích/chi tiết; trạng thái; tuần tự; hoạt động.
* \[ ] Thiết kế CSDL SQL Server có PK, FK và ràng buộc cho phòng, tiện nghi, đặt phòng, dịch vụ, đền bù, hóa đơn, thanh toán.
* \[ ] Xây dựng WinForms theo module và kiểm thử các quy tắc trong PDF.

### Module / Form

* `FrmMain`: 
* `FrmDanhMuc`: 
* `FrmPhongTienNghi`: 
* `FrmDatPhong`: 
* `FrmDichVu`: 
* `FrmTraPhong`: 
* `FrmThongKe`: 

## Kết quả

* Kết quả build: 
* Kết quả chạy: 
* Tổng test đã thực hiện: 
* Test đạt: 
* Kết luận ngắn: 



## Lỗi gặp phải và cách khắc phục

|Lỗi thực tế|Nguyên nhân đã xác định|Cách khắc phục|Kết quả sau sửa|
|-|-|-|-|
|`\\\[Điền lỗi, hoặc ghi “Không gặp lỗi” nếu đúng]`|`\\\[Điền]`|`\\\[Điền]`|`\\\[Điền]`|

## Cấu trúc thư mục

Project WinForms được thiết kế bằng Form Designer. Mỗi Form có file `.cs` và `.Designer.cs`; các hàm xử lý/nạp dữ liệu cần thiết được đặt trong code-behind tương ứng. Project không dùng `Ui.cs`, không có thư mục `Assets` và không có thư mục `Database`. Hai script SQL được để riêng trong `SQL/`; các icon màn hình chính lấy từ `System.Drawing.SystemIcons` của Windows, không cần file ảnh rời hoặc `.resx`.

Mở solution tại `Source/QuanLyKhachSan/QuanLyKhachSan.sln`. Trước khi chạy nghiệp vụ, cấu hình `App.config` cho SQL Server rồi chạy script trong `SQL/` bằng SSMS.

Giữ source project và các Form/Services bạn đã làm. Đưa các sản phẩm LAB3 vào thư mục LAB3; không để file của LAB khác lẫn ở đây.

```text
LAB\\\_OOSD/
└── LAB3/
    ├── README.md
    ├── Source/       # Solution/project và mã nguồn C# của LAB3
    ├── SQL/          # Script .sql đã làm sạch thông tin nhạy cảm
    ├── UML/          # File nguồn draw.io/PlantUML và sơ đồ đã xuất
    ├── Report/       # Báo cáo Word đã điền thông tin và chèn ảnh thật
    ├── Evidence/     # Ảnh chụp thực tế từ máy cá nhân
    └── TestCases/    # Bảng test riêng nếu có
```

Bạn có thể giữ cấu trúc project gốc của Visual Studio bên trong `Source/`; tránh đổi/xóa file `.sln`, `.csproj`, `.Designer.cs`, `App.config` khi project đang cần chúng.

## Hướng dẫn để giảng viên kiểm tra/chạy lại

1. Mở solution tại `Source/` bằng Visual Studio 2022.
2. Kiểm tra Framework mục tiêu tại Project Properties → Application.
3. Kiểm tra `App.config` trỏ đúng SQL Server/database. Không đưa password hoặc connection string nhạy cảm lên repository.
4. Nếu CSDL chưa tồn tại, dùng script trong `SQL/` theo hướng dẫn trong file; đọc nội dung trước khi chạy và không chạy lại script có lệnh xóa/ghi đè trên database chứa dữ liệu cần giữ.
5. Build Solution; ghi lại thông báo build thực tế.
6. Chạy ứng dụng, kiểm tra lần lượt danh mục, phòng/tiện nghi, đặt/nhận phòng, dịch vụ, đền bù/hóa đơn/thanh toán, thống kê.
7. Dùng test case trong báo cáo để tái hiện các quy tắc và đối chiếu kết quả.
8. Xem `Evidence/` và các sơ đồ trong `UML/` để so sánh kết quả.

### Quy tắc trọng tâm cần kiểm tra

* Số người trong phòng không vượt sức chứa.
* Không đặt phòng có lịch chồng lấn.
* Một thiết bị không lắp ở hai phòng trong cùng một ngày.
* Dịch vụ trùng phòng/ngày/dịch vụ được cộng dồn.
* Hóa đơn gồm tiền phòng và dịch vụ theo quy định bài.
* Hỗ trợ nhiều giao dịch/phương thức thanh toán và không thu vượt tổng hóa đơn.
* Chỉ hoàn tất trả phòng khi đã thanh toán đủ (nếu được cài đặt theo luồng này).

## Bằng chứng và quyền riêng tư

Ảnh trong `Evidence/` phải do bạn tự chụp trên máy cá nhân, thể hiện đúng chương trình/CSDL bạn đã chạy. Không dùng ảnh/log của bạn học, không chụp người khác, không đưa mật khẩu, token, email cá nhân không cần thiết, connection string có thông tin đăng nhập, CCCD thật hay dữ liệu nhạy cảm. Có thể dùng dữ liệu kiểm thử giả lập và cắt phần màn hình không liên quan.

Ảnh dự kiến: Solution Explorer; database và danh sách bảng; FrmMain/module; đặt phòng; hóa đơn/thanh toán; kết quả một test đạt và một test bị từ chối. Thay danh sách này theo bằng chứng bạn thực sự có.

## Kiểm tra Git và nộp bài

Tại thư mục gốc `LAB\\\_OOSD`, chạy:

```bash
git status
git add LAB3
git commit -m "Hoan thanh LAB3 quan ly khach san"
git push
```

Sau khi push, mở repository trên GitHub, kiểm tra README và các file LAB3 tải/xem được, lịch sử commit hiện đúng. Sau đó dán URL repository `LAB\\\_OOSD` vào bài nộp tương ứng trên Google Classroom. Giữ nguyên repository sau hạn nộp; không sửa nội dung đã nộp nếu chưa được giảng viên cho phép.

## Danh mục sản phẩm theo đề

* \[ ] Báo cáo Word.
* \[ ] Workbook Use Case + Screen Design.
* \[ ] UML/draw.io.
* \[ ] Solution Visual Studio 2022 và source code.
* \[ ] Script SQL.
* \[ ] Hình giao diện chụp từ máy cá nhân.
* \[ ] Bảng test case với kết quả thực tế.
* \[ ] URL repository đã push thành công và đã dán vào Google Classroom.

