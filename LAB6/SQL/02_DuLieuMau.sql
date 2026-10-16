-- Du lieu gia lap de thuc hanh; khong phai huong dan dieu tri.
USE HoSoBenhAn_LAB6;
GO
SET XACT_ABORT ON;
SET ANSI_NULLS ON; SET ANSI_PADDING ON; SET ANSI_WARNINGS ON; SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON; SET QUOTED_IDENTIFIER ON; SET NUMERIC_ROUNDABORT OFF;
BEGIN TRAN;
IF NOT EXISTS(SELECT 1 FROM dbo.Khoa WHERE MaKhoa='K01') INSERT dbo.Khoa VALUES('K01',N'Nội tổng quát');
IF NOT EXISTS(SELECT 1 FROM dbo.Khoa WHERE MaKhoa='K02') INSERT dbo.Khoa VALUES('K02',N'Tim mạch');
IF NOT EXISTS(SELECT 1 FROM dbo.BacSi WHERE MaBS='BS001') INSERT dbo.BacSi VALUES('BS001','K01',N'Nguyễn Minh An',N'Nội tổng quát');
IF NOT EXISTS(SELECT 1 FROM dbo.BacSi WHERE MaBS='BS002') INSERT dbo.BacSi VALUES('BS002','K02',N'Trần Ngọc Hà',N'Tim mạch');
IF NOT EXISTS(SELECT 1 FROM dbo.LoaiXetNghiem WHERE MaLoaiXN='XN01') INSERT dbo.LoaiXetNghiem VALUES('XN01',N'Đường huyết',N'mmol/L',N'Giá trị do nhân viên xét nghiệm ghi nhận');
IF NOT EXISTS(SELECT 1 FROM dbo.LoaiXetNghiem WHERE MaLoaiXN='XN02') INSERT dbo.LoaiXetNghiem VALUES('XN02',N'Công thức máu',NULL,N'Nhập nội dung kết quả theo phiếu');
IF NOT EXISTS(SELECT 1 FROM dbo.Thuoc WHERE MaThuoc='T001') INSERT dbo.Thuoc VALUES('T001',N'Thuốc mẫu A',N'viên',N'Chỉ dùng minh họa thao tác',1);
IF NOT EXISTS(SELECT 1 FROM dbo.Thuoc WHERE MaThuoc='T002') INSERT dbo.Thuoc VALUES('T002',N'Thuốc mẫu B',N'gói',N'Chỉ dùng minh họa thao tác',1);
IF NOT EXISTS(SELECT 1 FROM dbo.Thuoc WHERE MaThuoc='T003') INSERT dbo.Thuoc VALUES('T003',N'Thuốc mẫu đã ngừng dùng',N'viên',NULL,0);
COMMIT;
GO
IF NOT EXISTS(SELECT 1 FROM dbo.BenhNhan WHERE MaBN='BN001')
BEGIN
 DECLARE @tu date=DATEFROMPARTS(YEAR(GETDATE()),1,1),@den date=DATEFROMPARTS(YEAR(GETDATE()),12,31);
 EXEC dbo.usp_DangKy 'BN001','DK001','HS001','LP001',N'Lê Hoàng Nam',N'Quận 7, TP. Hồ Chí Minh','2001-05-12','0900000001',NULL,@tu,@den,500000;
END;
IF NOT EXISTS(SELECT 1 FROM dbo.BenhNhan WHERE MaBN='BN002')
BEGIN
 DECLARE @tu2 date=DATEFROMPARTS(YEAR(GETDATE()),1,1),@den2 date=DATEFROMPARTS(YEAR(GETDATE()),12,31);
 EXEC dbo.usp_DangKy 'BN002','DK002','HS002','LP002',N'Phạm Thu Mai',N'Thành phố Thủ Đức, TP. Hồ Chí Minh','2003-09-20','0900000002',NULL,@tu2,@den2,500000;
END;
GO
-- Ba phieu gia lap cho cac trang thai: da hoan tat, dang kham, da ket luan.
IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK='PK001')
BEGIN
 DECLARE @ngay datetime2(0)=DATEADD(MINUTE,-60,SYSDATETIME());
 EXEC dbo.usp_TaoPhieuKham @MaPK='PK001',@MaHS='HS001',@MaBS='BS001',@NgayGio=@ngay,@LoaiKham='THUONG',@TrieuChung=N'Thông tin triệu chứng mẫu',@TienKham=100000,@MaTT='TT001';
 EXEC dbo.usp_LapChiDinh 'CD001','PK001','XN01';
 EXEC dbo.usp_GhiKetQua 'CD001',N'Kết quả minh họa đã được ghi nhận';
 EXEC dbo.usp_GhiNhanKham @MaPK='PK001',@TrieuChung=N'Thông tin triệu chứng mẫu',@NhietDo=37,@HuyetAp=N'Chỉ số mẫu',@ChanDoan=N'Chẩn đoán giả lập phục vụ bài lab',@KetLuan=N'Đã ghi nhận kết quả trong bài thực hành',@XacNhan=1;
 DECLARE @dong dbo.DongToaList;
 INSERT @dong VALUES(1,'T001',10,N'Liều dùng mẫu',N'Cách dùng mẫu',5),(2,'T002',5,N'Liều dùng mẫu',N'Cách dùng mẫu',5);
 EXEC dbo.usp_LapToa @MaToa='TO001',@MaPK='PK001',@LoiDan=N'Dữ liệu giả lập, chỉ dùng thử chức năng phần mềm.',@DongToa=@dong;
 EXEC dbo.usp_ThemKhoanThu 'TT002','PK001',N'Khoản xét nghiệm minh họa',50000;
 EXEC dbo.usp_ThanhToan 'TT001';
 EXEC dbo.usp_ThanhToan 'TT002';
 EXEC dbo.usp_HoanTat 'PK001';
END;
GO
IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK='PK002')
BEGIN
 DECLARE @ngay2 datetime2(0)=DATEADD(MINUTE,-30,SYSDATETIME());
 EXEC dbo.usp_TaoPhieuKham @MaPK='PK002',@MaHS='HS002',@MaBS='BS002',@NgayGio=@ngay2,@LoaiKham='THUONG',@TrieuChung=N'Đang ghi nhận thông tin khám',@TienKham=100000,@MaTT='TT003';
 EXEC dbo.usp_LapChiDinh 'CD002','PK002','XN02';
END;
GO
IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK='PK003')
BEGIN
 DECLARE @ngay3 datetime2(0)=DATEADD(MINUTE,-10,SYSDATETIME());
 EXEC dbo.usp_TaoPhieuKham @MaPK='PK003',@MaHS='HS001',@MaBS='BS001',@NgayGio=@ngay3,@LoaiKham='THUONG',@TrieuChung=N'Thông tin khám mới trong bài thực hành',@TienKham=100000,@MaTT='TT004';
 EXEC dbo.usp_GhiNhanKham @MaPK='PK003',@TrieuChung=N'Thông tin khám mới trong bài thực hành',@ChanDoan=N'Chẩn đoán giả lập',@KetLuan=N'Đã kết luận, có thể lập toa',@XacNhan=1;
END;
GO
IF NOT EXISTS(SELECT 1 FROM dbo.LichHen WHERE MaHen='LH001')
BEGIN
 DECLARE @batdau datetime2(0)=DATEADD(HOUR,8,CAST(DATEADD(DAY,1,CAST(GETDATE() AS date)) AS datetime2(0))),@ketthuc datetime2(0);
 SET @ketthuc=DATEADD(MINUTE,30,@batdau);
 EXEC dbo.usp_DatHen 'LH001','HS001','BS001',@batdau,@ketthuc;
END;
GO
