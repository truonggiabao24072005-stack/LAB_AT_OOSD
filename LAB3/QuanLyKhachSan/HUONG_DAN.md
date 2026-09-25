# QUẢN LÝ KHÁCH SẠN — BẢN CÓ WINDOWS FORMS DESIGNER

## 1. Bản này có gì?

Bản này thay giao diện tạo động của gói trước bằng **7 Windows Form chuẩn**, mỗi Form có:

- `FrmTen.cs`: xử lý sự kiện và gọi Service.
- `FrmTen.Designer.cs`: khai báo control, bố cục, màu, cột bảng, InitializeComponent.
- `FrmTen.resx`: tài nguyên của Form.

Các Form kế thừa trực tiếp System.Windows.Forms.Form. Constructor chỉ gọi InitializeComponent; không truy vấn database khi dựng Form. Truy vấn được thực hiện trong sự kiện Load khi chạy ứng dụng. Các nút được nối xử lý trong phương thức FrmTen_Load qua UI.Wire.

Dựng theo ảnh PDF trang 34–38: màu nền xám sáng, tiêu đề xanh đậm, bảng trắng và tiêu đề cột xanh nhạt; màn hình chính 3 cột × 2 hàng và nút Thoát ở giữa; đặt phòng 2 bảng cạnh nhau; trả phòng 3 bảng trên và hóa đơn phía dưới. Icon chính được vẽ lại theo loại biểu tượng trong mẫu. Thanh tiêu đề, đường viền, font và màu nút thực tế tùy phiên bản Windows/DPI; không hứa giống từng pixel.

Ảnh PDF là minh họa, thiếu một số trường cần chạy nghiệp vụ. Bản này bổ sung nhân viên, ngày nhận/trả, số người, nút thêm/bỏ phòng và tab lịch sử; không giấu dữ liệu cần nhập để ép giống ảnh.

## 2. Mở và xem Design ngay

1. Giải nén `QuanLyKhachSan_WinForms_SQL.zip` vào thư mục **mới**, ví dụ `D:\LAB_KhachSan_Designer`. Không giải nén chồng lên thư mục đang sửa.
2. Mở thư mục `QuanLyKhachSan` → nhấp đúp `QuanLyKhachSan.sln`.
3. Nếu cần, cài workload **.NET desktop development** và .NET Framework **4.7.2 targeting pack** trong Visual Studio Installer.
4. Trong Solution Explorer mở thư mục Forms.
5. Nhấp phải **FrmMain.cs** → **View Designer** hoặc chọn file rồi nhấn **Shift+F7**.
6. Chọn một nút → nhấn **F4** để mở Properties. Bạn có thể đổi Text, Font, Size, Location hoặc kéo thả vị trí.
7. Để xem code xử lý chọn FrmMain.cs → F7. Để xem code giao diện mở mũi tên bên cạnh FrmMain.cs → FrmMain.Designer.cs.
8. Làm tương tự với 6 Form còn lại.

**Không cần tạo/chạy database để xem Designer.** Khi chạy F5 và mở module có dữ liệu mới cần kết nối SQL Server.

Nếu chỉ mở một file .cs riêng bằng File → Open → File, Visual Studio có thể không hiểu cấu trúc project; hãy mở file .sln.

## 3. Bố cục từng Form đối chiếu PDF

| Form | Trang PDF | Bố cục thực hiện |
|---|---|---|
| FrmMain | 34 | Tiêu đề xanh đậm; 6 nút 3 cột × 2 hàng với icon; Thoát giữa phía dưới |
| FrmDanhMuc | 34 | 5 tab; vùng nhập trên, Thêm bên phải, bảng lớn phía dưới |
| FrmPhongTienNghi | 35 | 3 tab Phòng/Tiện nghi/Lịch sử; bảng ở trên và vùng lập phiếu lắp đặt phía dưới |
| FrmDatPhong | 35 | 3 tab; tab Đặt phòng có phòng có sẵn bên trái, phòng chọn bên phải, phiếu đặt dưới cùng |
| FrmDichVu | 36 | Phiếu/phòng/dịch vụ và ngày/số lượng ở trên; nút Ghi nhận; bảng lịch sử phía dưới |
| FrmTraPhong | 37 | Phòng/tiện nghi/đền bù thành 3 bảng; vùng đền bù; hóa đơn; thanh toán/trả phòng dưới cùng |
| FrmThongKe | 38 | Chọn khoảng ngày trên; số liệu chữ xanh 2 cột; bảng dịch vụ dưới |

Tab Lịch sử của FrmTraPhong bổ sung để xem các lần thanh toán và các phiếu đền bù đã lưu. Số liệu ví dụ trong ảnh PDF không được điền cứng vào chương trình; lúc chạy sẽ lấy dữ liệu thật từ database.

## 4. Database và kết nối

Bản Designer giữ schema SQL của gói trước: **18 bảng**. Nếu đã chạy thành công `01_CreateDatabase.sql` của gói trước, không cần tạo lại database.

Nếu chưa có database:

1. Mở SSMS, kết nối đúng SQL Server của bạn.
2. Mở `Database/01_CreateDatabase.sql`.
3. Chọn **Query → SQLCMD Mode** vì script có `:ON ERROR EXIT`.
4. Nhấn Execute/F5. Script không DROP bảng; gặp database có cấu trúc cũ sẽ dừng để tránh xóa dữ liệu.
5. Nhấp phải Databases → Refresh → mở QuanLyKhachSan → Tables.

Mở App.config ở gốc project. Mặc định:

```xml
<add name="QuanLyKhachSanDB"
     connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

Nếu chạy SQL ở `.\SQLEXPRESS` thì đổi `Data Source` thành `.\SQLEXPRESS`. Nếu server có tên khác, nhập đúng tên server trong SSMS. Giữ tên connection string `QuanLyKhachSanDB`.

Chọn **Build → Build Solution** (Ctrl+Shift+B), sau đó F5.

## 5. Nếu muốn tự tạo thư mục và dán code

Cách mở solution ở mục 2 là ít lỗi nhất. Nếu cần tự làm từng file để học:

1. Tạo project **Windows Forms App (.NET Framework)**, tên **QuanLyKhachSan**, Framework **4.7.2**.
2. Xóa Form1 của project mới tạo.
3. Nhấp phải project → Add → New Folder, tạo **Data**, **Services**, **Forms**, **Database**, **Assets**.
4. Với file Data và Services: nhấp phải thư mục → Add → Class → nhập đúng tên → Ctrl+A thay toàn bộ bằng code file cùng tên trong gói.
5. Trong Forms, thêm **Ui.cs** bằng Add → Class và dán toàn bộ code Ui.cs.
6. Với từng FrmMain, FrmDanhMuc...: nhấp phải Forms → Add → **Windows Form** → nhập tên, ví dụ `FrmMain.cs`.
7. Chọn FrmMain.cs → F7 → Ctrl+A → dán toàn bộ `Forms/FrmMain.cs` từ gói.
8. Mở mũi tên bên cạnh FrmMain.cs → FrmMain.Designer.cs → Ctrl+A → dán toàn bộ `Forms/FrmMain.Designer.cs` từ gói.
9. Thay **FrmMain.resx** bằng file từ gói để có icon. Có thể đóng tab Designer rồi dùng File Explorer chép file resx vào Forms. Chọn ghi đè đúng file của project mới.
10. Chép tất cả file trong **Assets** từ gói vào thư mục Assets của project. Không đổi tên vì FrmMain.resx tham chiếu các ảnh này bằng đường dẫn tương đối.
11. Làm tương tự 6 Form còn lại. Các resx còn lại không có ảnh riêng, nhưng có thể chép đồng bộ từ gói.
12. Thay Program.cs và App.config bằng file trong gói.
13. References → Add Reference → Assemblies → Framework → chọn System.Configuration. Bảo đảm có System.Data, System.Drawing và System.Windows.Forms.
14. Build Solution → mở View Designer → F5.

**Khác bản cũ:** Bản này phải tạo các Frm bằng **Windows Form**, có Designer. Không chép Ui.cs hoặc các Frm từ ZIP cũ vào bản mới; lớp ModuleForm và giao diện tạo động cũ không còn dùng.

| Thư mục | File |
|---|---|
| Data | Db.cs |
| Services | DanhMucService.cs, PhongTienNghiService.cs, DatPhongService.cs, DichVuService.cs, TraPhongService.cs, ThongKeService.cs |
| Forms | Ui.cs và 7 nhóm Frm*.cs / Frm*.Designer.cs / Frm*.resx |
| Assets | 7 icon PNG và SVG gốc để tham khảo/chỉnh sửa |
| Database | 01_CreateDatabase.sql, 02_CreateTestDatabase.sql |
| Tests | IntegrationTests.csproj, IntegrationTests.cs, App.config |
| Gốc | QuanLyKhachSan.sln, QuanLyKhachSan.csproj, Program.cs, App.config |

Không thêm Tests/IntegrationTests.cs vào project WinForms: đây là chương trình console kiểm thử có Main riêng.

## 6. Chạy từng màn hình

### Danh mục

- Các tab Khu vực, Nhân viên, Loại tiện nghi, Dịch vụ, Quy định đền bù có ô nhập, Thêm, Tải lại và bảng.
- Database đã có A/B, NV01–NV03, TV/TL/DT, DV01–DV03. Không thêm lại cùng mã.
- Đơn giá dịch vụ và mức đền bù lấy từ bảng danh mục. Mức mẫu không phải quy định chính thức của khách sạn.

### Phòng - Tiện nghi

- Tab Phòng: số phòng, khu vực, sức chứa, giá/ngày → Thêm phòng.
- Tab Tiện nghi: mã thiết bị, loại, số thứ tự, tình trạng → Thêm tiện nghi.
- Vùng lắp đặt phía dưới: chọn TV01, A101, hôm nay, Tốt, NV02 → Lập phiếu.
- TV01 lắp tiếp A102 cùng ngày sẽ bị UNIQUE từ chối. Xem phiếu ở tab Lịch sử.

### Đặt / Nhận phòng

1. Tab Khách hàng: thêm KH01, Nguyễn Văn A, CCCD giả lập 000000000001, quốc tịch Việt Nam.
2. Tab Đặt phòng → Tải khách / phòng → chọn khách, lễ tân, kênh; ngày nhận hôm nay, ngày trả ngày mai; cọc 0.
3. Chọn A101 ở bảng trái, số người 1 → **Thêm phòng →**. Phòng xuất hiện ở bảng phải.
4. Có thể chọn thêm phòng khác; kiểm tra riêng số người từng phòng. Đổi số phiếu thành DP01 nếu muốn dễ nhớ → Lập phiếu đặt.
5. Phiếu xuất hiện ở bảng dưới. Tab Nhận phòng / Người lưu trú → Tải lại phiếu → chọn DP01 và A101.
6. Nhập họ tên, CCCD, quốc tịch → Thêm người lưu trú. Đủ số người của tất cả phòng → Nhận phòng.
7. Phiếu chuyển Đang ở. No-show chỉ dùng cho phiếu Đã đặt.

### Sử dụng dịch vụ

1. Chọn `DP01 / A101`, dịch vụ Ăn sáng, hôm nay, số lượng 1 và nhân viên → Ghi nhận.
2. Ghi tiếp cùng phiếu/phòng/DV/ngày, số lượng 2.
3. Bảng chỉ có một dòng Ăn sáng, số lượng 3, đơn giá 120000, thành tiền 360000.

### Trả phòng - Thanh toán

1. Chọn DP01 và nhân viên, click A101 trong bảng trái.
2. Bảng giữa nạp thiết bị hiện ở phòng. Nếu có thiệt hại: chọn TV01, mức Hư hỏng nhẹ; số tiền tự nạp 500000.
3. Thêm đền bù → bảng phải xuất hiện dòng → Lập phiếu đền bù. Nếu không có thiệt hại thì bỏ qua.
4. Số hóa đơn HD01, số ngày 1 → Lập hóa đơn. Tổng A101 một ngày + 3 ăn sáng = 960000.
5. Tiền đền bù ở phiếu riêng, không cộng vào hóa đơn phòng + DV.
6. Tiền mặt 300000 → Thanh toán → còn 660000.
7. Chuyển khoản 660000 → Thanh toán → còn 0, Đã thanh toán.
8. Xem từng giao dịch ở tab Lịch sử. Hoàn tất trả phòng → phiếu Đã trả và rời danh sách Đang ở.

### Thống kê

Chọn khoảng ngày → Thống kê. Hiển thị số phiếu đặt, số hóa đơn, doanh thu hóa đơn, tổng phiếu đền bù, thực thu hóa đơn và bảng dịch vụ. Đang ở là số hiện tại; thực thu chỉ tính giao dịch ThanhToan, chưa bao gồm cọc hoặc thu đền bù.

## 7. Quy tắc nghiệp vụ và giới hạn

- PK/FK/CHECK/UNIQUE theo schema PDF. UNIQUE thiết bị/ngày và loại/số thứ tự, phiếu/phòng/ngày dùng DV, một hóa đơn/phiếu.
- Sức chứa, lịch trùng và số tiền thanh toán được kiểm tra trong Service với transaction. Tất cả thao tác ghi trong ứng dụng dùng khóa SQL chung để tránh hai giao dịch ứng dụng cùng vượt kiểm tra.
- Lịch trùng theo code mẫu PDF dùng dấu <= và >=: ngày nhận mới bằng ngày trả cũ vẫn trùng.
- Hóa đơn = tiền phòng + dịch vụ, số ngày nhân viên xác nhận. Đền bù riêng. Tiền cọc chỉ lưu, chưa tự khấu trừ/hoàn cọc. Demo dùng cọc 0.
- Danh mục có thêm/xem theo code mẫu PDF; chưa có sửa/xóa, đăng nhập, phân quyền hoặc in hóa đơn.
- Bổ sung so với mẫu: nhận phòng trong khoảng ngày đặt và đủ người lưu trú; chặn DV sau chốt hóa đơn; DV từ ngày nhận thực tế đến hôm nay; không lắp thiết bị ngày tương lai; không đền bù trùng thiết bị cùng lượt.
- Người chạy SQL trực tiếp có thể bỏ qua quy tắc Service; bản LAB chưa dùng stored procedure/quyền SQL để bắt mọi đường ghi đi qua Service.
- Form dùng bố cục cố định theo ảnh. Khi màn hình nhỏ hơn Form, chương trình thu cửa sổ theo vùng làm việc và bật thanh cuộn để vẫn tới được mọi control. Windows tự scale theo font/DPI; cần kiểm tra hiển thị tại độ phân giải máy bạn.

## 8. Kiểm thử

Tất cả dòng dưới là **kết quả kỳ vọng**, không phải khẳng định đã chạy thực tế.

| TC | Thao tác | Kỳ vọng |
|---|---|---|
| D01 | Ngắt kết nối SQL, mở FrmMain.cs bằng View Designer | Hiện đầy đủ control, không gọi SQL |
| D02 | Lần lượt mở Design 7 Form | Có bố cục, tab, bảng, nút; chọn được từng control |
| D03 | Đổi Text một nút bằng Properties, lưu, build | Designer lưu và chương trình dùng giá trị mới |
| B01 | A101 tối đa 2, đặt 3 người | Từ chối, không lưu đầu phiếu lỗi |
| B02 | Đặt A101 một người, ngày hợp lệ | Thành công |
| B03 | Đặt A101 khoảng ngày trùng / chạm ngày phiếu cũ | Từ chối |
| B04 | Phiếu hai phòng, phòng thứ hai bị trùng | Toàn phiếu bị từ chối |
| B05 | TV01 lắp 2 phòng trong cùng ngày | Phiếu thứ hai bị từ chối |
| B06 | Nhập quá số người đăng ký | Từ chối |
| B07 | Cùng DV cùng phòng cùng ngày ghi 1 rồi 2 | Một dòng SL=3 |
| B08 | Phiếu chưa Đang ở hoặc đã chốt hóa đơn, ghi DV | Từ chối |
| B09 | Đền bù TV hư nhẹ | Phiếu đền bù 500000 theo mẫu |
| B10 | A101 1 ngày + 3 ăn sáng | Hóa đơn 960000 |
| B11 | Lập hóa đơn lần hai cho cùng phiếu | Từ chối |
| B12 | Thanh toán 300000 | Còn 660000, chưa đủ |
| B13 | Thanh toán tiếp 660001 | Từ chối, không lưu giao dịch |
| B14 | Thanh toán tiếp 660000 bằng cách khác | Đủ, còn 0 |
| B15 | Trả phòng khi chưa đủ / đã đủ tiền | Từ chối / thành công tương ứng |
| B16 | Hai cửa sổ cùng đặt một phòng | Chỉ một phiếu thành công |
| B17 | Thống kê từ ngày > đến ngày | Từ chối |

Kiểm thử tự động:

1. SSMS → mở `Database/02_CreateTestDatabase.sql`, SQLCMD Mode, Execute để tạo **QuanLyKhachSan_Test**.
2. Sửa Data Source trong `Tests/App.config` đúng server, giữ tên database Test.
3. Mở `Tests/IntegrationTests.csproj` trong Visual Studio → Build → Ctrl+F5.
4. Kiểm tra các dòng PASS và tổng PASS; nếu có FAIL đọc lỗi đầu tiên.
5. Dữ liệu thử có prefix riêng và được giữ trong database Test; không ảnh hưởng database bài chính.

## 9. Lỗi thường gặp

- **Không thấy View Designer:** mở đúng .sln; chọn Frm*.cs, không chọn Designer.cs/Ui.cs. Project đã có SubType=Form và DependentUpon. Nếu tự tạo, dùng Add → Windows Form.
- **Designer báo không tìm thấy icon:** kiểm tra Assets có 7 PNG và FrmMain.resx đúng file trong gói. Không chỉ sao chép riêng FrmMain.cs.
- **Lỗi InitializeComponent/trùng khai báo:** không trộn file Designer cũ với file mới. Hai phần phải cùng namespace QuanLyKhachSan.Forms và cùng partial class.
- **Designer lỗi khi project chưa build:** đóng Designer, Build → Rebuild Solution, sửa lỗi đầu tiên rồi mở lại.
- **ConfigurationManager không tồn tại:** thêm reference System.Configuration.
- **App không tìm thấy database:** đối chiếu server SSMS với Data Source trong App.config.
- **Nút Click không có tên handler trong Properties:** bản này nối xử lý tại FrmTen_Load bằng UI.Wire; tìm tên nút trong file FrmTen.cs để sửa logic. Giao diện vẫn chỉnh bằng Designer bình thường.

## 10. Tình trạng kiểm tra

Đã đối chiếu ảnh PDF trang 34–38, phân tích cú pháp C#, kiểm tra project/resource và tên control, kiểm tra 7 constructor không gọi SQL, kiểm tra tọa độ control không chồng lấn/ra ngoài vùng chứa.

Môi trường tạo file không có Windows/Visual Studio/SQL Server. **Chưa kiểm chứng build, mở Designer thực tế, chạy giao diện hoặc chạy integration tests.** Cần thực hiện mục 2, 4 và 8 trên máy Windows trước khi nộp. Kiểm tra tĩnh không thay thế các bước này.
