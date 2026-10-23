# LAB6 - Hệ thống quản lý hồ sơ bệnh án

## Thông tin sinh viên

* Họ và tên: Trương Gia Bảo.
* MSSV: 1250080020.
* Tên bài: **LAB6 - Hệ thống quản lý hồ sơ bệnh án**.

Bài thực hiện các nghiệp vụ đăng ký bệnh nhân, thu lệ phí năm, cấp hồ sơ, khám bệnh, xét nghiệm, lập toa thuốc, đặt lịch định kỳ và hoàn tất điều trị sau thanh toán. Cấu trúc source và cách bố trí giao diện được làm theo LAB5, sử dụng C# WinForms và ADO.NET.

## Môi trường thực hiện

* Hệ điều hành: Windows.
* Visual Studio: 2022.
* Ngôn ngữ: C#.
* Framework: .NET Framework 4.7.2.
* Cơ sở dữ liệu: SQL Server 2022 Express.
* Công cụ quản trị: SQL Server Management Studio (SSMS).
* Kết nối dữ liệu: ADO.NET, `System.Data.SqlClient`.

## Nội dung đã thực hiện

* [x] Phân tích nghiệp vụ từ đăng ký bệnh nhân đến hoàn tất điều trị.
* [x] Xác định Actor, Use Case, lớp, ID, association và multiplicity; đặc tả các Use Case trọng tâm.
* [x] Trình bày sơ đồ lớp, Use Case tổng quát và phân rã, Activity, Sequence cùng các sơ đồ phân tích và thiết kế trong báo cáo.
* [x] Thiết kế CSDL gồm 14 bảng, khóa chính, khóa ngoại, UNIQUE, CHECK và các giao dịch nhiều bảng.
* [x] Xây dựng WinForms theo module, kết nối SQL Server và xử lý nghiệp vụ bằng Service, thủ tục SQL.
* [x] Kiểm tra các quy tắc đăng ký, lệ phí, lịch sử khám, xét nghiệm, toa thuốc, lịch định kỳ và thanh toán.

### Module / Form

| Form | Người sử dụng và chức năng |
| --- | --- |
| `FrmMain` | Màn hình chính, mở bảy module nghiệp vụ. |
| `FrmHoSo` | Nhân viên tiếp nhận đăng ký bệnh nhân, xác nhận lệ phí lần đầu, cấp hồ sơ, tra cứu và xem lịch sử. |
| `FrmLePhi` | Nhân viên thu phí ghi nhận lệ phí năm, kiểm tra thời hạn và xem các lần đóng phí. |
| `FrmLichHen` | Nhân viên tiếp nhận đặt, tra cứu, hủy lịch định kỳ; kiểm tra hiệu lực phí, quyền lợi quý và lịch bác sĩ. |
| `FrmKhamBenh` | Bác sĩ tạo phiếu, xem lịch sử, nhập triệu chứng, chỉ số, chẩn đoán và xác nhận kết luận. |
| `FrmXetNghiem` | Bác sĩ lập chỉ định; nhân viên xét nghiệm nhập kết quả theo chỉ định của đúng phiếu khám. |
| `FrmToaThuoc` | Bác sĩ thêm, xóa dòng nháp, lưu toa và xem toa đã lập. |
| `FrmThanhToan` | Nhân viên thu phí ghi nhận các khoản thu; nhân viên tiếp nhận kiểm tra điều kiện để hoàn tất phiếu. |
| `FrmInToa` | Màn hình phụ để xem trước và in toa đã lưu, được mở từ `FrmToaThuoc`. |

Các vai trò trên là phân công nghiệp vụ. Bài không bổ sung module đăng nhập, quản lý kho thuốc, bảo hiểm, giường bệnh hoặc tính lương ngoài phạm vi đề.

## Cấu trúc thư mục

```text
LAB6/
├── README.md
├── 1250080020_Truong_Gia_Bao_LAB6.docx
└── QuanLyHoSoBenhAn/
    ├── QuanLyHoSoBenhAn.sln
    └── QuanLyHoSoBenhAn/
        ├── QuanLyHoSoBenhAn.csproj
        ├── App.config
        ├── Program.cs
        ├── Forms/
        ├── Services/
        ├── Data/
        ├── Models/
        └── Properties/
```

Mỗi form nghiệp vụ có file `.cs` và `.Designer.cs` để mở bằng Windows Forms Designer. `FrmInToa` tạo màn hình xem và in bằng code. `Forms` xử lý giao diện, `Services` xử lý nghiệp vụ và truy vấn, `Data/Db.cs` thực thi lệnh có tham số, còn `Models` chứa dữ liệu đầu vào và các kiểm tra dùng chung. Những thao tác ghi nhiều bảng được thực hiện trong transaction ở SQL Server.

## Hướng dẫn mở và chạy bài

1. Mở SSMS, kết nối server `.` bằng Windows Authentication. Tên máy chủ đã kiểm tra là `LAPTOP-MTOTO8R6`.
2. Trong **Databases**, bấm **Refresh** và kiểm tra có `HoSoBenhAn_LAB6`. Trên máy thực hành, CSDL đã được tạo sẵn.
3. Mở `QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln` bằng Visual Studio 2022.
4. Kiểm tra máy đã cài thành phần **.NET desktop development** và bộ phát triển .NET Framework 4.7.2.
5. Mở `QuanLyHoSoBenhAn/QuanLyHoSoBenhAn/App.config`, sửa tên SQL Server nếu cần.
6. Chọn project `QuanLyHoSoBenhAn` làm **Startup Project**, chọn **Build Solution**, sau đó nhấn **F5**.
7. Màn hình khởi động là `FrmMain`. Chọn từng module để thực hiện nghiệp vụ và đối chiếu với báo cáo Word.

### Cấu hình kết nối SQL Server

```xml
<add name="BenhAn"
     connectionString="Data Source=.;Initial Catalog=HoSoBenhAn_LAB6;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=5"
     providerName="System.Data.SqlClient" />
```

Nếu dùng instance Express, thay `Data Source=.` bằng `.\SQLEXPRESS` hoặc đúng tên server đang kết nối trong SSMS. Giữ tên database `HoSoBenhAn_LAB6`, hoặc sửa `Initial Catalog` cho đúng tên CSDL đã được khôi phục trên máy đó. Sau khi sửa `App.config`, build lại chương trình.

### CSDL khi chuyển sang máy khác

Kiểm tra ngày **23/10/2026** trên máy thực hành: `HoSoBenhAn_LAB6` có trạng thái **ONLINE**, gồm **14 bảng** và **12 thủ tục**. CSDL đang lưu trên SQL Server của máy, không nằm bên trong file solution.

Bộ file LAB6 hiện tại chưa có thư mục script `SQL`. Khi chuyển hoặc nộp bài để chạy trên máy khác, cần bổ sung bản xuất CSDL. Trong SSMS, bấm phải `HoSoBenhAn_LAB6` → **Tasks → Generate Scripts**, chọn toàn bộ đối tượng. Tại **Advanced**, đặt **Types of data to script = Schema and data**, bật xuất index, khóa chính, khóa ngoại, UNIQUE và CHECK; giữ đầy đủ các thủ tục cùng kiểu bảng `dbo.DongToaList`. Lưu script vào `LAB6/SQL/` rồi chạy trên SQL Server đích trước khi mở ứng dụng.

## Dữ liệu mẫu và các luồng kiểm tra

Các mã mẫu đã kiểm tra trên máy gồm hai hồ sơ `HS001`, `HS002`, bác sĩ `BS001`, `BS002`, thuốc `T001`, `T002`, `T003` và loại xét nghiệm `XN01`, `XN02`. Thuốc, chỉ số và số tiền chỉ dùng minh họa thao tác bài lab.

| Phiếu | Hồ sơ | Trạng thái đã kiểm tra | Cách sử dụng |
| --- | --- | --- | --- |
| `PK001` | `HS001` | `HOANTAT` | Xem lịch sử, kết quả xét nghiệm và toa đã lưu; kiểm tra khóa thao tác sau hoàn tất. |
| `PK002` | `HS002` | `DANGKHAM` | Nhập kết quả xét nghiệm đang chờ rồi quay lại xác nhận kết luận. |
| `PK003` | `HS001` | `DAKETLUAN` | Thực hành lập toa, xác nhận thu phí và hoàn tất. |

Các trạng thái có thể thay đổi sau khi thực hành. Nếu phiếu mẫu đã hoàn tất hoặc đã có toa, tạo phiếu mới để thử lại luồng tương ứng.

### Đăng ký và lệ phí năm

1. Mở **Đăng ký và tra cứu hồ sơ**, tra cứu trước để tránh lập lại hồ sơ của cùng bệnh nhân.
2. Nhập họ tên, ngày sinh, địa chỉ, điện thoại và chọn ảnh nếu có.
3. Nhập thời hạn, số tiền lệ phí; đánh dấu đã xác nhận thu phí rồi bấm **Đăng ký và cấp hồ sơ**.
4. Ghi nhận mã hồ sơ được cấp để sử dụng cho các lần khám sau.
5. Khi gia hạn, mở **Lệ phí năm**, chọn hồ sơ và nhập thời hạn không chồng với lần đóng trước.

Mã được chương trình sinh tự động. Điện thoại dùng để tra cứu, không phải định danh duy nhất của bệnh nhân. Đăng ký, lệ phí và cấp hồ sơ phải thành công cùng nhau trong một giao dịch.

### Khám, xét nghiệm và toa thuốc

1. Mở **Khám bệnh và lịch sử**, chọn hồ sơ, bác sĩ, loại khám và tạo phiếu.
2. Nhập triệu chứng, nhiệt độ nếu có, huyết áp và chẩn đoán. Có thể lưu nháp trước khi xác nhận kết luận.
3. Nếu cần xét nghiệm, mở module **Chỉ định và kết quả xét nghiệm**, chọn đúng phiếu và lập chỉ định. Chọn chỉ định trong bảng để nhập kết quả.
4. Quay lại phiếu khám và xác nhận kết luận khi đã có đủ kết quả.
5. Mở **Lập toa thuốc**, chọn đúng phiếu đã kết luận, chọn thuốc còn sử dụng và nhập các dòng thuốc.
6. Bấm **Lưu toa**. Chỉ sau khi lưu thành công mới có thể xem và in toa.

Một phiếu có tối đa một toa. Toa phải có ít nhất một dòng hợp lệ; toa và toàn bộ chi tiết được lưu trong cùng transaction. Khám không cần thuốc được phép không lập toa.

### Lịch định kỳ và hoàn tất điều trị

* Chọn hồ sơ, bác sĩ và khoảng giờ tương lai trong **Lịch khám định kỳ**. Bấm **Kiểm tra lịch** trước khi đặt hẹn; khi lưu, SQL Server kiểm tra lại quyền lợi và lịch trùng.
* Quyền lợi được triển khai theo giả định trong báo cáo: tối đa một lượt định kỳ đã hoàn tất mỗi quý dương lịch khi lệ phí còn hiệu lực. Đặt hẹn chưa tiêu thụ lượt khám; phần khám định kỳ được miễn, dịch vụ phát sinh vẫn phải thu riêng.
* Khi tiếp nhận lịch hẹn, chọn đúng hồ sơ, bác sĩ và ngày trên màn hình khám, tải lịch hẹn rồi chọn hẹn cần tiếp nhận.
* Trong **Thanh toán và hoàn tất**, kiểm tra từng khoản phải thu và xác nhận thu dòng đang chọn. Chỉ bấm **Hoàn tất đợt điều trị** sau khi đã có kết luận, đủ kết quả xét nghiệm và xử lý hết các khoản thu.
* Phiếu đã `HOANTAT` được giữ trong lịch sử và khóa các thao tác sửa theo luồng thông thường.

## Kết quả kiểm tra

* Ngày 16/10/2026: build Release thành công bằng MSBuild của Visual Studio 2022.
* Đã chạy **40/40 ca kiểm tra service với SQL Server đạt**, bao gồm rollback đăng ký, lệ phí chồng thời hạn, liên kết phiếu, kết quả xét nghiệm, toa thuốc, thanh toán và quyền lợi định kỳ theo quý.
* Đã kiểm tra mở màn hình chính cùng bảy module, tải dữ liệu, thêm dòng toa nháp và trạng thái nút trước/sau khi lưu hoặc hoàn tất.
* Ngày 23/10/2026: kiểm tra lại tên máy chủ, trạng thái CSDL, số bảng, số thủ tục và trạng thái ba phiếu mẫu. Không chạy lại toàn bộ bộ kiểm thử trong lần bổ sung README.
* Chưa kiểm tra in ra máy in thực, tải lớn hoặc nhiều người thao tác đồng thời. Các kết quả chức năng đã nêu là kiểm tra tuần tự.

Các file chạy kiểm thử, bản build tạm và CSDL thử riêng đã được dọn sau lần kiểm tra trước. Bộ bài giữ mã nguồn để mở và build trong Visual Studio.

## Lỗi đã gặp và cách xử lý

| Hiện tượng | Nguyên nhân | Cách xử lý |
| --- | --- | --- |
| `Msg 51000`, `Msg 2714`, `Msg 219` khi chạy lại script khởi tạo trước đây. | CSDL đã có bảng, kiểu `dbo.DongToaList` và các thủ tục. SSMS vẫn chạy các batch sau `GO`, nên tiếp tục báo trùng đối tượng. | Trên máy đã có đủ CSDL, bỏ qua bước khởi tạo và chạy ứng dụng. Không xóa dữ liệu để xử lý lỗi trùng đối tượng. |
| Chương trình không kết nối được SQL Server. | Sai instance, dịch vụ SQL Server chưa chạy hoặc Windows hiện tại chưa có quyền truy cập CSDL. | Kết nối thử bằng SSMS, đối chiếu tên server với `App.config`, kiểm tra dịch vụ và quyền truy cập, sau đó build lại. |
| Không kết luận được phiếu, không lập được toa hoặc chưa hoàn tất được. | Chưa đủ kết quả xét nghiệm, phiếu chưa kết luận, đã có toa hoặc còn khoản chưa thu. | Thực hiện các bước còn thiếu theo thông báo; kiểm tra đúng mã phiếu đang chọn. |

## Kiểm tra và nộp bài

1. Mở báo cáo Word, đối chiếu các sơ đồ và giao diện với chương trình.
2. Kiểm tra solution mở được, cấu hình kết nối đúng và build thành công.
3. Bổ sung script xuất CSDL vào `SQL/` nếu nộp để chạy trên máy khác.
4. Giữ README, báo cáo Word và mã nguồn trong cùng thư mục LAB6.
5. Nếu giảng viên yêu cầu nộp qua repository, chạy tại thư mục gốc `LAB_AT_OOSD`:

```bash
git status
git add LAB6
git commit -m "Hoan thanh LAB6 quan ly ho so benh an"
git push
```

Sau khi push, kiểm tra các file LAB6 trên repository rồi nộp URL theo yêu cầu của giảng viên.
