# LAB8 - QUẢN LÝ CHO THUÊ VĂN PHÒNG Ở CAO ỐC

Thực hiện theo đề bài **BÀI 4: QUẢN LÝ CHO THUÊ VĂN PHÒNG Ở CAO ỐC** (Đại Học Công Nghệ TP.HCM - HUTECH).

## Thông tin sinh viên

* **Họ và tên:** Trương Gia Bảo
* **MSSV:** 1250080020
* **Lớp:** CNPM1 (12_ĐH_CNPM1)
* **Môn học:** Phân tích thiết kế hướng đối tượng (OOSD)
* **Ngày thực hiện:** 30/10/2026

---

## Môi trường thực hiện

* **Hệ điều hành:** Windows 10/11.
* **Công cụ mô hình hóa UML:** StarUML (.mdj), diagrams.net (.drawio) và sơ đồ vector độ phân giải cao (300 DPI).
* **Công cụ phát triển:** Visual Studio 2022 (Community / Professional).
* **Ngôn ngữ lập trình:** C# (.NET Framework 4.7.2).
* **Kiến trúc ứng dụng:** 3-Tier Architecture (Presentation Layer `Forms` → Business Logic Layer `Services` → Data Layer `Data` & `Models`).
* **Trình biên dịch:** MSBuild 17.14 (Build sạch 100% không cảnh báo, không lỗi).

---

## Danh mục tài liệu và sản phẩm nộp bài trong thư mục LAB8

```text
c:\LAB_AT_OOSD\LAB8\
├── 1250080020_Truong_Gia_Bao_LAB8.docx    # Báo cáo Word hoàn chỉnh giải trọn vẹn 6 câu hỏi, chèn đầy đủ sơ đồ
├── README.md                              # Hướng dẫn chi tiết, tài liệu tổng kết hệ thống
├── UML/                                   # Sơ đồ thiết kế chuẩn StarUML & draw.io
│   ├── StarUML_LAB8.mdj                   # File dự án StarUML theo yêu cầu đề bài
│   ├── SoDo_LAB8.drawio                   # File sơ đồ đa trang chỉnh sửa được trên diagrams.net
│   └── Hinhanh/                           # Bộ ảnh sơ đồ sắc nét chuẩn chèn báo cáo
│       ├── Cau1_ClassStructure.png        # Kiến trúc tổng quan các Class phân tích & định danh ID
│       ├── Cau2_ClassDiagram.png          # Biểu đồ Class Diagram đầy đủ Multiplicity, Composition, Association
│       ├── Cau3_UseCaseTongQuat.png       # Biểu đồ Use Case Diagram tổng quát toàn hệ thống cao ốc
│       ├── Cau4_UseCasePhanRa.png         # Biểu đồ Use Case Diagram phân rã chi tiết quy trình thuê & thanh toán
│       ├── Cau5_ActivityDiagram.png       # Biểu đồ Activity Diagram 4 làn bơi (Swimlanes) cho Câu 4
│       ├── Cau6_SequenceGiaHan.png        # Biểu đồ Sequence Diagram cho nghiệp vụ Lập phiếu gia hạn
│       └── ERD_Database.png               # Sơ đồ Cơ sở dữ liệu quan hệ (Physical ERD) 13 bảng
└── QuanLyThueVanPhong/                    # Solution C# WinForms Visual Studio 2022
    ├── QuanLyThueVanPhong.sln             # Solution quản lý
    └── QuanLyThueVanPhong/
        ├── App.config                     # Cấu hình chuỗi kết nối
        ├── Program.cs                     # Điểm khởi chạy ứng dụng
        ├── QuanLyThueVanPhong.csproj      # File dự án C#
        ├── Properties/                    # Thông tin Assembly
        ├── Models/
        │   └── Models.cs                  # 17 lớp thực thể định danh đầy đủ thuộc tính
        ├── Data/
        │   └── DbContext.cs               # Quản lý kho dữ liệu và nạp dữ liệu mẫu thực tế
        ├── Services/
        │   └── CaoOcService.cs            # Tầng xử lý nghiệp vụ, kiểm tra ràng buộc logic
        └── Forms/
            ├── FrmMain.cs / Designer      # Bảng điều khiển trung tâm (Dashboard cao ốc)
            ├── FrmPhongTang.cs / Designer # Quản lý tầng, phòng, tra cứu giá theo độ cao & diện tích
            ├── FrmHopDongThue.cs / Designer # Lập hợp đồng thuê (nhiều phòng, >= 6 tháng, trả trước 6 tháng đầu)
            ├── FrmGiaHan.cs / Designer    # Lập phiếu gia hạn (kiểm tra <= 1/2 HĐ gốc & sạch nợ tiền thuê, dịch vụ)
            ├── FrmThanhToan.cs / Designer # Thu tiền thuê (đầu tháng từ tháng 7) & dịch vụ cuối tháng
            ├── FrmNhanVienTheXe.cs / Designer # Báo cáo nhân viên công ty & cấp phát thẻ giữ xe
            └── FrmKiemTraViPham.cs / Designer # Kiểm tra định kỳ 1 năm & xử phạt tự ý sửa kết cấu
```

> **Ghi chú chuẩn hóa:** Bộ nộp bài tuân thủ nghiêm ngặt yêu cầu *"ko thêm các file phụ hoặc file test"*, không chứa các thư mục rác, file tạm hay mã kiểm thử ngoài lề.

---

## Tóm tắt giải quyết 6 câu hỏi theo đề bài PDF

### Câu 1: Xác định các Class, thuộc tính (có mã định danh ID) và phương thức
Hệ thống gồm 17 lớp phân tích phân thành 5 phân hệ:
1. **Phân hệ Cơ sở vật chất & Phòng:**
   * `CaoOc`: Quản lý thông tin tòa nhà, địa chỉ, số tầng, quy chế hoạt động (`CAOOC_01` → `CAOOC_06`).
   * `Tang`: Tầng lầu, độ cao (m), hệ số định giá theo tầng (`TANG_01` → `TANG_06`).
   * `Phong`: Văn phòng, diện tích sử dụng, hướng phòng, đơn giá cơ bản, giá thuê tháng tính theo độ cao & diện tích, tình trạng phòng, hồ sơ kết cấu gốc (`PHONG_01` → `PHONG_09`).
2. **Phân hệ Khách hàng & Hợp đồng thuê:**
   * `KhachHang`: Thông tin doanh nghiệp thuê, người đại diện, MST, liên hệ (`KH_01` → `KH_08`).
   * `HopDongThue`: Hợp đồng thuê văn phòng (cho phép thuê cùng lúc nhiều phòng, thời hạn tối thiểu 6 tháng, tiền đặt cọc, tiền thuê trả trước 6 tháng đầu) (`HD_01` → `HD_11`).
   * `ChiTietHopDong`: Danh sách các văn phòng thuê trong hợp đồng (`CTHD_01` → `CTHD_06`).
   * `PhieuGiaHan`: Phiếu gia hạn đợt thuê (thời gian gia hạn khống chế <= 1/2 thời gian thuê gốc) (`PGH_01` → `PGH_10`).
   * `ChiTietGiaHan`: Danh sách các phòng xin gia hạn (`CTGH_01` → `CTGH_05`).
3. **Phân hệ Tài chính & Dịch vụ:**
   * `HoaDonTienThue`: Thu trước 6 tháng đầu; từ tháng thứ 7 thu vào đầu mỗi tháng (`HDTT_01` → `HDTT_09`).
   * `DichVu`: Danh mục điện, nước sinh hoạt, cáp internet... (`DV_01` → `DV_05`).
   * `ChiSoDichVu`: Chỉ số công tơ điện, đồng hồ nước đầu kỳ và cuối kỳ (`CSDV_01` → `CSDV_09`).
   * `HoaDonDichVu`: Hóa đơn chi phí dịch vụ thanh toán vào cuối mỗi tháng (`HDDV_01` → `HDDV_13`).
4. **Phân hệ Nhân sự công ty & Xe cộ:**
   * `NhanVienVanPhong`: Quản lý hồ sơ nhân viên công ty làm việc trong tòa nhà: mã số, hình ảnh, công ty, chức vụ, phòng, tầng (`NV_01` → `NV_11`).
   * `TheGiuXe`: Thẻ gửi xe do cao ốc cấp: mã thẻ, người gửi, biển số, loại xe, nhãn hiệu, màu xe (`TGX_01` → `TGX_08`).
5. **Phân hệ Kiểm tra & Xử phạt:**
   * `DotKiemTra`: Đợt kiểm tra phòng định kỳ 1 năm/lần để lập kế hoạch tu sửa kịp thời (`DKT_01` → `DKT_07`).
   * `BienBanKiemTraPhong`: Ghi nhận hiện trạng, phát hiện tự ý sửa đổi kết cấu (`BBKT_01` → `BBKT_08`).
   * `BienBanViPham`: Quyết định xử phạt khi văn phòng tự ý thay đổi, chỉnh sửa kết cấu theo quy định cao ốc (`BBVP_01` → `BBVP_11`).

### Câu 2: Mối liên kết giữa các Class & Biểu đồ Class Diagram
* Quan hệ **Hợp thành (Composition)**: `CaoOc ── (1..*) Tang`, `Tang ── (1..*) Phong`, `ChiTietHopDong (1..*) ── HopDongThue`, `HopDongThue ── PhieuGiaHan`, `PhieuGiaHan ── ChiTietGiaHan`, `HopDongThue ── HoaDonTienThue`, `HopDongThue ── HoaDonDichVu`, `DotKiemTra ── BienBanKiemTraPhong`.
* Quan hệ **Kết tập (Aggregation)**: `NhanVienVanPhong (1) ── (0..1) TheGiuXe`.
* Quan hệ **Kết hợp (Association)**: `KhachHang (1) ── (*) HopDongThue`, `Phong (1) ── (*) ChiSoDichVu`, `KhachHang (1) ── (*) NhanVienVanPhong`, `Phong (1) ── (*) NhanVienVanPhong`, `Phong (1) ── (*) BienBanViPham`.

### Câu 3: Tác nhân (Actor) & Use Case tổng quát
* **4 Actor:** Khách hàng (Doanh nghiệp thuê), Nhân viên công ty (Làm việc tại văn phòng), Bộ phận Quản lý Cao ốc (BQL), Bộ phận Kế toán / Thu ngân.
* **13 Use Case tổng quát:** Quản lý tầng & phòng; Tra cứu vị trí, diện tích & bảng giá; Lập hợp đồng thuê; Lập phiếu gia hạn; Thu tiền thuê 6 tháng đầu; Thu tiền thuê đầu tháng (từ tháng 7); Ghi nhận chỉ số dịch vụ; Thu hóa đơn dịch vụ cuối tháng; Báo cáo nhân viên mới; Cấp thẻ giữ xe; Quản lý gửi xe; Kiểm tra phòng định kỳ 1 năm; Lập biên bản xử phạt vi phạm kết cấu.

### Câu 4: Use Case Diagram phân rã chi tiết hoạt động thuê & thanh toán
Phân rã luồng nghiệp vụ liên tục:
1. Ký hợp đồng thuê các văn phòng (thuê nhiều phòng, thời hạn >= 6 tháng).
2. Lập và thanh toán trước 100% tiền thuê của 6 tháng đầu tiên.
3. Bàn giao mặt bằng văn phòng đưa vào hoạt động.
4. Chu trình hàng tháng trong 6 tháng đầu: Ghi nhận chỉ số dịch vụ và thanh toán hóa đơn dịch vụ vào cuối mỗi tháng.
5. Từ tháng thứ 7 trở đi:
   * **Đầu mỗi tháng:** Lập hóa đơn và thanh toán tiền thuê văn phòng hàng tháng.
   * **Cuối mỗi tháng:** Chốt chỉ số tiêu thụ và thanh toán hóa đơn dịch vụ (điện, nước, internet...).

### Câu 5: Activity Diagram cho Câu 4
Mô tả rõ nét luồng hoạt động song song và tuần tự qua 4 làn bơi (Swimlanes):
* **Khách hàng** (Ký hợp đồng → Trả tiền 6 tháng đầu → Nhận phòng → Trả tiền thuê đầu tháng từ tháng 7 → Trả tiền dịch vụ cuối tháng).
* **Bộ phận Quản lý Cao ốc** (Soạn thảo hợp đồng → Bàn giao văn phòng → Nghiệm thu hoàn trả mặt bằng khi hết hạn).
* **Bộ phận Kế toán / Thu ngân** (Xuất hóa đơn 6 tháng đầu → Xác nhận thu tiền → Xuất hóa đơn tiền thuê đầu tháng từ tháng 7 → Xuất hóa đơn dịch vụ cuối tháng → Xác nhận thu tiền).
* **Hệ thống phần mềm** (Tự động tính tiền thuê theo diện tích & độ cao → Ghi nhận chỉ số điện/nước/net → Cảnh báo hạn thanh toán).

### Câu 6: Sequence Diagram cho nghiệp vụ “Lập phiếu gia hạn”
Hiện thực hóa các thông điệp tuần tự và khung điều kiện **Alt**:
* **Điều kiện 1:** Số tháng gia hạn `<= ThoiHanThueGoc / 2`.
* **Điều kiện 2:** Không còn nợ tiền thuê mặt bằng (`HoaDonTienThue.KiemTraConNo() == false`).
* **Điều kiện 3:** Đã thanh toán đầy đủ các dịch vụ đã sử dụng (`HoaDonDichVu.KiemTraConNo() == false`).
* **Kết quả:**
  * Nhánh hợp lệ: Tạo phiếu gia hạn mới, lưu danh sách phòng gia hạn, cập nhật ngày kết thúc mới cho Hợp đồng và in phiếu bàn giao.
  * Nhánh từ chối: Báo lỗi chi tiết lý do và yêu cầu hoàn tất nghĩa vụ tài chính trước khi nộp lại yêu cầu gia hạn.

---

## Hướng dẫn cài đặt và chạy thử ứng dụng

1. **Yêu cầu hệ thống:** Máy tính cài đặt Windows 10/11, Visual Studio 2022 và .NET Framework 4.7.2.
2. **Mở Solution:** Mở file `QuanLyThueVanPhong/QuanLyThueVanPhong.sln` bằng Visual Studio 2022.
3. **Build chương trình:** Chọn menu `Build` → `Build Solution` (hoặc phím tắt `Ctrl + Shift + B`).
4. **Chạy ứng dụng:** Nhấn `F5` để khởi chạy màn hình chính `FrmMain`.
5. **Kịch bản kiểm tra chức năng trực tiếp trên giao diện:**
   * **Mặt bằng & Giá phòng:** Vào chức năng 1, chọn các tầng lầu khác nhau để quan sát hệ số giá tầng cao (tầng 1 hệ số 1.0; tầng 18 hệ số 1.7). Thử nhập diện tích và bấm *Tính Giá Thuê* để xem công thức tính theo độ cao.
   * **Lập hợp đồng thuê:** Vào chức năng 2, chọn công ty, tích chọn nhiều phòng trống cùng lúc (ví dụ P102 và P1801), chọn thời hạn (thử nhập < 6 sẽ bị cảnh báo), hệ thống tự tính tổng tiền trả trước 6 tháng đầu và tạo hợp đồng.
   * **Lập phiếu gia hạn (Câu 6):** Vào chức năng 3, chọn hợp đồng `HD2026_01`. Xem đèn báo công nợ tiền thuê và công nợ dịch vụ. Thử nhập số tháng gia hạn vượt quá 1/2 thời hạn gốc (ví dụ hợp đồng 12 tháng nhưng nhập gia hạn 7 tháng) -> Hệ thống từ chối ngay lập tức theo quy định.
   * **Quản lý thu tiền (Câu 4):** Vào chức năng 4, xem danh sách hóa đơn 6 tháng đầu, thử bấm *Xuất Hóa Đơn Đầu Tháng* cho tháng thứ 7 trở đi và xác nhận thanh toán. Chuyển sang tab Dịch Vụ để chốt số điện, nước, internet cuối tháng và xác nhận thu tiền.
   * **Nhân viên & Thẻ xe:** Vào chức năng 5, báo cáo nhân viên mới cho công ty (mã, họ tên, chức vụ, phòng, tầng) và thực hiện cấp thẻ giữ xe cao ốc (biển số, loại xe, màu xe).
   * **Kiểm tra định kỳ & Xử phạt:** Vào chức năng 6, xem kế hoạch kiểm tra phòng định kỳ 1 năm để tu sửa. Xem trường hợp văn phòng tự ý đập phá, sửa đổi kết cấu trái phép và thực hiện ban hành Quyết định xử phạt 20.000.000 VNĐ, buộc khôi phục nguyên trạng.
