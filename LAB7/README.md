# LAB7 Quản lý nhân sự công ty sơn Đông Á

Sinh viên: Trương Gia Bảo. MSSV: 1250080020.

## Bộ bài làm

- `1250080020_Truong_Gia_Bao_LAB7.docx`: báo cáo theo các mục và bố cục sơ đồ trong ảnh tham khảo, gồm 5 actor, 13 use case, 19 lớp phân tích, trạng thái, tuần tự, lớp thiết kế, thiết kế chức năng, Activity, CSDL và giao diện.
- `UML/SoDo_LAB7.drawio`: 30 trang sơ đồ chỉnh sửa được bằng diagrams.net. M01–M08 là bộ sơ đồ theo mẫu ảnh; các trang D, F, DB và HT bổ sung phần triển khai và phóng to nhóm lớp.
- `QuanLyNhanSu/QuanLyNhanSu.sln`: solution Visual Studio, .NET Framework 4.7.2; thư mục Forms, Services, Data và Models.
- `SQL/01_TaoCSDL.sql` và `SQL/02_DuLieuMau.sql`: 15 bảng SQL Server và dữ liệu mẫu.
- `Chay_ung_dung/QuanLyNhanSu.exe`: bản Release và cấu hình kết nối.

## Cài đặt

1. Chạy `SQL/01_TaoCSDL.sql` trong SSMS để tạo `NhanSu_LAB7`.
2. Chạy `SQL/02_DuLieuMau.sql` một lần trên CSDL trống.
3. Sửa `Data Source=.` trong `App.config` của project hoặc `QuanLyNhanSu.exe.config` của bản chạy nếu server khác. Dùng Windows Authentication.
4. Mở solution bằng Visual Studio 2022 và Build/F5, hoặc chạy bản exe.

Script tạo CSDL sẽ dừng nếu bảng đã tồn tại. Không chạy lại trên CSDL đang sử dụng. Script mẫu cũng dừng khi có dữ liệu để tránh ghi trùng.

## Tám module

Danh mục; Tuyển dụng thử việc; Hợp đồng bảo hiểm; Quyết định lương chức vụ; Kế hoạch chấm công; Phiếu phụ trội; Khen thưởng kỷ luật; Bảng lương thống kê. Các Form có file `.cs` và `.Designer.cs`; bố cục và control dùng chung nằm ở `BusinessForm.cs`.

Mã người thực hiện mẫu: NV01 giám đốc, NV02 nhân sự, NV03 kế toán, NV04 ban chấm công, NV05 trưởng sản xuất PB03. PB01 là nhân sự, PB02 kế toán, PB04 chấm công, PB05 giám đốc. Đây là kiểm tra vai trò minh họa, chưa có đăng nhập xác thực.

## Luồng chạy thử

1. Xem NV06 và QĐ tuyển dụng TD06 đã ký; ghi kết quả Đạt vào 01/10/2026.
2. Ký HD06 dài hạn bắt đầu 01/10/2026 và nhập mức đóng BHYT BHXH.
3. Lập quyết định lương cho NV06 ngày và hiệu lực 01/10/2026 rồi ký bằng NV01. Có thể lập QĐ chức vụ nếu cần.
4. Tại Kế hoạch chấm công, tạo KH03 cho PB03 tuần 05/10/2026, ngày lập 02/10/2026, người lập NV05. Thêm dòng NV05 và NV06, ca CA01, giờ phụ trội dự kiến 2. Lưu rồi ghi công từng NV.
5. Lập phiếu PT01 ngày 05/10/2026, hình thức TANGCA, 2 giờ, người lập NV04; thêm các dòng tham gia rồi lưu.
6. Tạo QĐ khen thưởng cá nhân hoặc tập thể, ký và lập phiếu bằng NV03. Để ký QĐ tuyển dụng khác, nhập số QĐ ở màn hình thưởng phạt rồi bấm Ký QĐ theo số.
7. Nhập 2026, tháng 10, giờ chuẩn 208 và NV03 để tính lương. Nếu công còn ít khiến thực lĩnh âm, bổ sung công đúng kế hoạch trước khi chốt.

## Quy tắc và giới hạn

- Mỗi giao dịch ghi nhiều bảng dùng Serializable, commit toàn bộ hoặc rollback. SQL dùng SqlParameter; bảng tra cứu được giới hạn trong danh sách cố định.
- Mỗi QĐ chọn đúng cá nhân hoặc tập thể. QĐ cần ký trước lập phiếu; một QĐ tối đa một phiếu. Phạt qua phiếu không trừ lương lần nữa. Phạt tập thể chỉ thu qua phiếu vì đề chưa quy định phân bổ.
- Phụ trội hệ số 1,5 theo đề; tổng giờ phải trong kế hoạch. Phụ cấp chức vụ lấy số tiền trên QĐ để giữ giá trị lịch sử.
- Mức đóng bảo hiểm là số tiền tháng nhập vào, không tự áp tỷ lệ pháp luật. Dữ liệu mẫu chỉ minh họa bài học.
- Tính lương xử lý nhân viên có hợp đồng hoặc thử việc trọn kỳ. Thay đổi lương chức vụ hoặc hợp đồng giữa tháng được từ chối để tách kỳ; chưa hỗ trợ tự tính theo từng đoạn hoặc thanh toán thử việc lẻ tháng.
- Mỗi kỳ được chốt một lần và khóa nguồn tháng trong luồng thường. Chưa có chức năng mở lại kỳ hoặc xóa bảng lương.
- Chưa triển khai đăng nhập, in chứng từ, kiểm toán, thay đổi phòng ban theo lịch sử, thuế và phân bổ thưởng phạt tập thể. Các trường liên hệ đầy đủ của mô hình chưa có trong giao diện prototype.
- CSDL triển khai ánh xạ 5 lớp quyết định vào bảng QuyetDinh có Loai; HopDongLaoDong thành HopDong, HoSoBaoHiem thành BaoHiem. Bảng ca là danh mục bổ sung; công được lưu theo ngày để tổng hợp tháng.

## Kiểm tra đã thực hiện

Build Release bằng MSBuild Visual Studio 2022 thành công. 35/35 kiểm tra nghiệp vụ SQL Server đạt ngày 23/10/2026, bao gồm rollback tuyển dụng và phụ trội, ký hợp đồng kèm bảo hiểm, kiểm tra thưởng phạt, công thức phụ trội, chốt lương và chống trùng. Đã mở 9 Form và kiểm tra bố cục với dữ liệu mẫu. Chưa kiểm tra tải lớn hoặc nhiều phiên đồng thời. Các chương trình kiểm tra, CSDL kiểm thử và file tạm không thuộc bộ nộp.

## Đọc sơ đồ

M01 tổng quát; M02 phân rã thử việc đến hợp đồng; M03 phân rã thưởng phạt; M04 lớp phân tích; M05 trạng thái nhân viên; M06 trạng thái QĐ; M07 tuần tự khen thưởng; M08 lớp thiết kế chi tiết. Hai sơ đồ lớp đầy đủ được đặt trên trang A3 ngang trong Word để giữ bố cục 19 lớp và đọc rõ khi phóng to. Các trang còn lại dùng khổ dọc.
