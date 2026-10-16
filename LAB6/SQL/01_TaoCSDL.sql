-- LAB6 - Quan ly ho so benh an. SQL Server 2016 tro len.
-- Chay bang SSMS hoac sqlcmd. Khong xoa hay ghi de CSDL da co.
USE master;
GO
IF DB_ID(N'HoSoBenhAn_LAB6') IS NULL CREATE DATABASE HoSoBenhAn_LAB6;
GO
USE HoSoBenhAn_LAB6;
GO
IF OBJECT_ID(N'dbo.BenhNhan',N'U') IS NOT NULL
    THROW 51000, N'CSDL đã có bảng bệnh án. Dừng để giữ dữ liệu hiện có.', 1;
GO
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET NUMERIC_ROUNDABORT OFF;
SET XACT_ABORT ON;
GO
BEGIN TRAN;
CREATE TABLE dbo.BenhNhan(
 MaBN varchar(20) NOT NULL PRIMARY KEY, HoTen nvarchar(100) NOT NULL,
 DiaChi nvarchar(250) NOT NULL, NgaySinh date NOT NULL, DienThoai varchar(20) NOT NULL, Anh nvarchar(500) NULL,
 CHECK(LEN(LTRIM(RTRIM(HoTen)))>0), CHECK(LEN(LTRIM(RTRIM(DiaChi)))>0), CHECK(LEN(DienThoai)>0));
CREATE TABLE dbo.PhieuDangKy(
 MaDK varchar(20) NOT NULL PRIMARY KEY, MaBN varchar(20) NOT NULL UNIQUE REFERENCES dbo.BenhNhan(MaBN),
 NgayDangKy datetime2(0) NOT NULL DEFAULT SYSDATETIME(), UNIQUE(MaDK,MaBN));
CREATE TABLE dbo.HoSoBenhAn(
 MaHS varchar(20) NOT NULL PRIMARY KEY, MaBN varchar(20) NOT NULL UNIQUE REFERENCES dbo.BenhNhan(MaBN),
 MaDK varchar(20) NOT NULL UNIQUE, NgayLap datetime2(0) NOT NULL DEFAULT SYSDATETIME(),
 UNIQUE(MaHS,MaBN), FOREIGN KEY(MaDK,MaBN) REFERENCES dbo.PhieuDangKy(MaDK,MaBN));
CREATE TABLE dbo.LanDongLePhi(
 MaLP varchar(20) NOT NULL PRIMARY KEY, MaBN varchar(20) NOT NULL REFERENCES dbo.BenhNhan(MaBN),
 MaHS varchar(20) NULL, NgayThu datetime2(0) NOT NULL DEFAULT SYSDATETIME(), TuNgay date NOT NULL, DenNgay date NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0), CHECK(TuNgay<=DenNgay),
 FOREIGN KEY(MaHS,MaBN) REFERENCES dbo.HoSoBenhAn(MaHS,MaBN));
CREATE INDEX IX_LePhi_HoSo ON dbo.LanDongLePhi(MaHS,TuNgay,DenNgay);
CREATE TABLE dbo.Khoa(MaKhoa varchar(20) NOT NULL PRIMARY KEY, TenKhoa nvarchar(100) NOT NULL UNIQUE);
CREATE TABLE dbo.BacSi(MaBS varchar(20) NOT NULL PRIMARY KEY, MaKhoa varchar(20) NOT NULL REFERENCES dbo.Khoa(MaKhoa),
 HoTen nvarchar(100) NOT NULL, ChuyenMon nvarchar(100) NOT NULL, UNIQUE(MaBS,MaKhoa));
CREATE TABLE dbo.LichHen(MaHen varchar(20) NOT NULL PRIMARY KEY, MaHS varchar(20) NOT NULL REFERENCES dbo.HoSoBenhAn(MaHS),
 MaBS varchar(20) NOT NULL REFERENCES dbo.BacSi(MaBS), BatDau datetime2(0) NOT NULL, KetThuc datetime2(0) NOT NULL,
 TrangThai varchar(20) NOT NULL DEFAULT 'DAHEN' CHECK(TrangThai IN('DAHEN','DATIEPNHAN','DAHUY')),
 CHECK(BatDau<KetThuc), UNIQUE(MaHen,MaHS,MaBS));
CREATE INDEX IX_Hen_BacSi ON dbo.LichHen(MaBS,BatDau,KetThuc);
CREATE TABLE dbo.PhieuKham(MaPK varchar(20) NOT NULL PRIMARY KEY, MaHS varchar(20) NOT NULL REFERENCES dbo.HoSoBenhAn(MaHS),
 MaBS varchar(20) NOT NULL, MaKhoa varchar(20) NOT NULL REFERENCES dbo.Khoa(MaKhoa), MaHen varchar(20) NULL,
 NgayGio datetime2(0) NOT NULL, LoaiKham varchar(10) NOT NULL CHECK(LoaiKham IN('THUONG','DINHKY')),
 TrieuChung nvarchar(1000) NOT NULL, NhietDo decimal(4,1) NULL CHECK(NhietDo BETWEEN 30 AND 45), HuyetAp nvarchar(30) NULL,
 ChanDoan nvarchar(1000) NULL, KetLuan nvarchar(1000) NULL,
 TrangThai varchar(20) NOT NULL DEFAULT 'DANGKHAM' CHECK(TrangThai IN('DANGKHAM','DAKETLUAN','HOANTAT')),
 Nam AS YEAR(NgayGio) PERSISTED, Quy AS DATEPART(QUARTER,NgayGio) PERSISTED,
 FOREIGN KEY(MaBS,MaKhoa) REFERENCES dbo.BacSi(MaBS,MaKhoa),
 FOREIGN KEY(MaHen,MaHS,MaBS) REFERENCES dbo.LichHen(MaHen,MaHS,MaBS),
 CHECK(TrangThai='DANGKHAM' OR (LEN(LTRIM(RTRIM(ChanDoan)))>0 AND LEN(LTRIM(RTRIM(KetLuan)))>0 AND ChanDoan IS NOT NULL AND KetLuan IS NOT NULL)));
CREATE UNIQUE INDEX UX_PhieuKham_Hen ON dbo.PhieuKham(MaHen) WHERE MaHen IS NOT NULL;
CREATE UNIQUE INDEX UX_DinhKy_Quy ON dbo.PhieuKham(MaHS,Nam,Quy) WHERE LoaiKham='DINHKY' AND TrangThai='HOANTAT';
CREATE INDEX IX_Phieu_HoSo ON dbo.PhieuKham(MaHS,NgayGio);
CREATE TABLE dbo.LoaiXetNghiem(MaLoaiXN varchar(20) NOT NULL PRIMARY KEY, TenXN nvarchar(100) NOT NULL, DonVi nvarchar(30) NULL, MoTa nvarchar(500) NULL);
CREATE TABLE dbo.ChiDinhXetNghiem(MaCD varchar(20) NOT NULL PRIMARY KEY, MaPK varchar(20) NOT NULL REFERENCES dbo.PhieuKham(MaPK),
 MaLoaiXN varchar(20) NOT NULL REFERENCES dbo.LoaiXetNghiem(MaLoaiXN), NgayChiDinh datetime2(0) NOT NULL DEFAULT SYSDATETIME(),
 NgayKetQua datetime2(0) NULL, KetQua nvarchar(2000) NULL, TrangThai varchar(20) NOT NULL DEFAULT 'CHO' CHECK(TrangThai IN('CHO','CO_KET_QUA')),
 CHECK((TrangThai='CHO' AND NgayKetQua IS NULL AND KetQua IS NULL) OR (TrangThai='CO_KET_QUA' AND NgayKetQua>=NgayChiDinh AND LEN(LTRIM(RTRIM(KetQua)))>0 AND KetQua IS NOT NULL)));
CREATE TABLE dbo.Thuoc(MaThuoc varchar(20) NOT NULL PRIMARY KEY, TenThuoc nvarchar(100) NOT NULL, DonVi nvarchar(30) NOT NULL,
 HoatChat nvarchar(150) NULL, DangSuDung bit NOT NULL DEFAULT 1);
CREATE TABLE dbo.ToaThuoc(MaToa varchar(20) NOT NULL PRIMARY KEY, MaPK varchar(20) NOT NULL UNIQUE REFERENCES dbo.PhieuKham(MaPK),
 NgayLap datetime2(0) NOT NULL DEFAULT SYSDATETIME(), LoiDan nvarchar(1000) NULL);
CREATE TABLE dbo.ChiTietToaThuoc(MaToa varchar(20) NOT NULL REFERENCES dbo.ToaThuoc(MaToa), STT int NOT NULL CHECK(STT>0),
 MaThuoc varchar(20) NOT NULL REFERENCES dbo.Thuoc(MaThuoc), SoLuong int NOT NULL CHECK(SoLuong>0),
 LieuDung nvarchar(150) NOT NULL CHECK(LEN(LTRIM(RTRIM(LieuDung)))>0), CachDung nvarchar(250) NOT NULL CHECK(LEN(LTRIM(RTRIM(CachDung)))>0),
 SoNgay int NOT NULL CHECK(SoNgay>0), PRIMARY KEY(MaToa,STT));
CREATE TABLE dbo.ThanhToan(MaTT varchar(20) NOT NULL PRIMARY KEY, MaPK varchar(20) NOT NULL REFERENCES dbo.PhieuKham(MaPK),
 NoiDung nvarchar(150) NOT NULL CHECK(LEN(LTRIM(RTRIM(NoiDung)))>0), SoTien decimal(18,2) NOT NULL, NgayThu datetime2(0) NULL,
 TrangThai varchar(20) NOT NULL CHECK(TrangThai IN('CHUATHU','DATHU','MIENPHI')),
 CHECK((TrangThai='CHUATHU' AND SoTien>0 AND NgayThu IS NULL) OR (TrangThai='DATHU' AND SoTien>0 AND NgayThu IS NOT NULL) OR (TrangThai='MIENPHI' AND SoTien=0 AND NgayThu IS NULL)));
COMMIT;
GO
CREATE TYPE dbo.DongToaList AS TABLE(STT int PRIMARY KEY, MaThuoc varchar(20), SoLuong int, LieuDung nvarchar(150), CachDung nvarchar(250), SoNgay int);
GO
-- Tat ca giao dich sua nghiep vu khoa theo ho so; dat hen khoa them theo bac si.
CREATE PROCEDURE dbo.usp_DangKy
 @MaBN varchar(20), @MaDK varchar(20), @MaHS varchar(20), @MaLP varchar(20), @HoTen nvarchar(100),
 @DiaChi nvarchar(250), @NgaySinh date, @DienThoai varchar(20), @Anh nvarchar(500)=NULL,
 @TuNgay date=NULL, @DenNgay date=NULL, @SoTien decimal(18,2)=NULL
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF NULLIF(LTRIM(RTRIM(@HoTen)),N'') IS NULL OR NULLIF(LTRIM(RTRIM(@DiaChi)),N'') IS NULL OR NULLIF(@DienThoai,'') IS NULL OR @NgaySinh IS NULL OR @NgaySinh>CAST(GETDATE() AS date)
  THROW 51001,N'Kiểm tra họ tên, địa chỉ, ngày sinh và điện thoại.',1;
 IF @TuNgay IS NULL OR @DenNgay IS NULL OR @TuNgay>@DenNgay OR ISNULL(@SoTien,0)<=0
  THROW 51002,N'Thời hạn và số tiền lệ phí không hợp lệ.',1;
 BEGIN TRY
  BEGIN TRAN;
  INSERT dbo.BenhNhan VALUES(@MaBN,@HoTen,@DiaChi,@NgaySinh,@DienThoai,NULLIF(@Anh,N''));
  INSERT dbo.PhieuDangKy(MaDK,MaBN) VALUES(@MaDK,@MaBN);
  INSERT dbo.LanDongLePhi(MaLP,MaBN,TuNgay,DenNgay,SoTien) VALUES(@MaLP,@MaBN,@TuNgay,@DenNgay,@SoTien);
  INSERT dbo.HoSoBenhAn(MaHS,MaBN,MaDK) VALUES(@MaHS,@MaBN,@MaDK);
  UPDATE dbo.LanDongLePhi SET MaHS=@MaHS WHERE MaLP=@MaLP;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_ThuLePhi @MaLP varchar(20),@MaHS varchar(20),@TuNgay date,@DenNgay date,@SoTien decimal(18,2)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF @TuNgay>@DenNgay OR ISNULL(@SoTien,0)<=0 THROW 51002,N'Lệ phí không hợp lệ.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @r int,@key nvarchar(255)=N'HS:'+@MaHS,@bn varchar(20);
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý, vui lòng thử lại.',1;
  SELECT @bn=MaBN FROM dbo.HoSoBenhAn WHERE MaHS=@MaHS;
  IF @bn IS NULL THROW 51004,N'Không tìm thấy hồ sơ.',1;
  IF EXISTS(SELECT 1 FROM dbo.LanDongLePhi WHERE MaHS=@MaHS AND TuNgay<=@DenNgay AND DenNgay>=@TuNgay)
   THROW 51005,N'Thời hạn lệ phí bị chồng với lần đóng trước.',1;
  INSERT dbo.LanDongLePhi(MaLP,MaBN,MaHS,TuNgay,DenNgay,SoTien) VALUES(@MaLP,@bn,@MaHS,@TuNgay,@DenNgay,@SoTien);
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_DatHen @MaHen varchar(20),@MaHS varchar(20),@MaBS varchar(20),@BatDau datetime2(0),@KetThuc datetime2(0)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF @BatDau>=@KetThuc OR CAST(@BatDau AS date)<>CAST(@KetThuc AS date) OR @BatDau<SYSDATETIME()
  THROW 51006,N'Chọn khoảng giờ tương lai trong cùng một ngày.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @r int,@key nvarchar(255)=N'HS:'+@MaHS;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  SET @key=N'BS:'+@MaBS;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Lịch bác sĩ đang được xử lý.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.LanDongLePhi WHERE MaHS=@MaHS AND CAST(@BatDau AS date) BETWEEN TuNgay AND DenNgay)
   THROW 51007,N'Lệ phí chưa có hiệu lực tại ngày hẹn.',1;
  IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaHS=@MaHS AND LoaiKham='DINHKY' AND TrangThai='HOANTAT' AND Nam=YEAR(@BatDau) AND Quy=DATEPART(QUARTER,@BatDau))
   THROW 51008,N'Đã sử dụng lượt khám định kỳ trong quý.',1;
  IF EXISTS(SELECT 1 FROM dbo.LichHen WHERE MaBS=@MaBS AND TrangThai<>'DAHUY' AND BatDau<@KetThuc AND KetThuc>@BatDau)
   THROW 51009,N'Khoảng giờ bị trùng lịch bác sĩ.',1;
  IF EXISTS(SELECT 1 FROM dbo.LichHen WHERE MaHS=@MaHS AND TrangThai='DAHEN' AND BatDau<@KetThuc AND KetThuc>@BatDau)
   THROW 51009,N'Bệnh nhân đã có hẹn trong khoảng giờ này.',1;
  INSERT dbo.LichHen(MaHen,MaHS,MaBS,BatDau,KetThuc) VALUES(@MaHen,@MaHS,@MaBS,@BatDau,@KetThuc);
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_HuyHen @MaHen varchar(20)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@bs varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=MaHS,@bs=MaBS FROM dbo.LichHen WHERE MaHen=@MaHen;
  IF @hs IS NULL THROW 51010,N'Không tìm thấy lịch hẹn.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  SET @key=N'BS:'+@bs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Lịch bác sĩ đang được xử lý.',1;
  UPDATE dbo.LichHen SET TrangThai='DAHUY' WHERE MaHen=@MaHen AND TrangThai='DAHEN';
  IF @@ROWCOUNT<>1 THROW 51010,N'Chỉ hủy được hẹn chưa tiếp nhận.',1;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_TaoPhieuKham @MaPK varchar(20),@MaHS varchar(20),@MaBS varchar(20),@MaHen varchar(20)=NULL,
 @NgayGio datetime2(0)=NULL,@LoaiKham varchar(10)='THUONG',@TrieuChung nvarchar(1000)=N'',@TienKham decimal(18,2)=100000,@MaTT varchar(20)=NULL
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF @NgayGio IS NULL SET @NgayGio=SYSDATETIME();
 IF @LoaiKham NOT IN('THUONG','DINHKY') OR @NgayGio>SYSDATETIME() THROW 51011,N'Loại khám hoặc thời điểm không hợp lệ.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @r int,@key nvarchar(255)=N'HS:'+@MaHS,@khoa varchar(20);
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  SELECT @khoa=MaKhoa FROM dbo.BacSi WHERE MaBS=@MaBS;
  IF @khoa IS NULL THROW 51012,N'Bác sĩ không tồn tại.',1;
  IF @LoaiKham='DINHKY'
  BEGIN
   IF NOT EXISTS(SELECT 1 FROM dbo.LanDongLePhi WHERE MaHS=@MaHS AND CAST(@NgayGio AS date) BETWEEN TuNgay AND DenNgay)
    THROW 51007,N'Lệ phí chưa có hiệu lực tại ngày khám.',1;
   IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaHS=@MaHS AND LoaiKham='DINHKY' AND TrangThai='HOANTAT' AND Nam=YEAR(@NgayGio) AND Quy=DATEPART(QUARTER,@NgayGio))
    THROW 51008,N'Đã sử dụng lượt định kỳ trong quý.',1;
  END;
  IF @MaHen IS NOT NULL
  BEGIN
   IF @LoaiKham<>'DINHKY' OR NOT EXISTS(SELECT 1 FROM dbo.LichHen WHERE MaHen=@MaHen AND MaHS=@MaHS AND MaBS=@MaBS AND TrangThai='DAHEN' AND CAST(BatDau AS date)=CAST(@NgayGio AS date))
    THROW 51013,N'Hẹn không đúng hồ sơ, bác sĩ, ngày hoặc đã được tiếp nhận.',1;
   UPDATE dbo.LichHen SET TrangThai='DATIEPNHAN' WHERE MaHen=@MaHen;
  END;
  IF @LoaiKham='THUONG' AND ISNULL(@TienKham,0)<=0 THROW 51014,N'Phí khám thường phải lớn hơn 0.',1;
  INSERT dbo.PhieuKham(MaPK,MaHS,MaBS,MaKhoa,MaHen,NgayGio,LoaiKham,TrieuChung) VALUES(@MaPK,@MaHS,@MaBS,@khoa,@MaHen,@NgayGio,@LoaiKham,@TrieuChung);
  INSERT dbo.ThanhToan(MaTT,MaPK,NoiDung,SoTien,TrangThai) VALUES(@MaTT,@MaPK,N'Phí khám',CASE WHEN @LoaiKham='DINHKY' THEN 0 ELSE @TienKham END,CASE WHEN @LoaiKham='DINHKY' THEN 'MIENPHI' ELSE 'CHUATHU' END);
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_GhiNhanKham @MaPK varchar(20),@TrieuChung nvarchar(1000),@NhietDo decimal(4,1)=NULL,@HuyetAp nvarchar(30)=NULL,
 @ChanDoan nvarchar(1000)=NULL,@KetLuan nvarchar(1000)=NULL,@XacNhan bit=0
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=MaHS FROM dbo.PhieuKham WHERE MaPK=@MaPK;
  IF @hs IS NULL THROW 51015,N'Không tìm thấy phiếu khám.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@MaPK AND TrangThai='HOANTAT') OR EXISTS(SELECT 1 FROM dbo.ToaThuoc WHERE MaPK=@MaPK)
   THROW 51016,N'Phiếu đã hoàn tất hoặc có toa, không được sửa nội dung khám.',1;
  IF @XacNhan=1 AND (NULLIF(LTRIM(RTRIM(@ChanDoan)),N'') IS NULL OR NULLIF(LTRIM(RTRIM(@KetLuan)),N'') IS NULL)
   THROW 51017,N'Nhập chẩn đoán và kết luận.',1;
  IF @XacNhan=1 AND EXISTS(SELECT 1 FROM dbo.ChiDinhXetNghiem WHERE MaPK=@MaPK AND TrangThai='CHO')
   THROW 51018,N'Còn xét nghiệm chưa có kết quả.',1;
  UPDATE dbo.PhieuKham SET TrieuChung=@TrieuChung,NhietDo=@NhietDo,HuyetAp=@HuyetAp,ChanDoan=@ChanDoan,KetLuan=@KetLuan,TrangThai=CASE WHEN @XacNhan=1 THEN 'DAKETLUAN' ELSE 'DANGKHAM' END WHERE MaPK=@MaPK;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_LapChiDinh @MaCD varchar(20),@MaPK varchar(20),@MaLoaiXN varchar(20)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=MaHS FROM dbo.PhieuKham WHERE MaPK=@MaPK;
  IF @hs IS NULL THROW 51015,N'Không tìm thấy phiếu khám.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@MaPK AND TrangThai='DANGKHAM') THROW 51019,N'Chỉ lập chỉ định khi phiếu đang khám.',1;
  INSERT dbo.ChiDinhXetNghiem(MaCD,MaPK,MaLoaiXN) VALUES(@MaCD,@MaPK,@MaLoaiXN);
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_GhiKetQua @MaCD varchar(20),@KetQua nvarchar(2000)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF NULLIF(LTRIM(RTRIM(@KetQua)),N'') IS NULL THROW 51020,N'Kết quả không được rỗng.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@pk varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=p.MaHS,@pk=p.MaPK FROM dbo.ChiDinhXetNghiem c JOIN dbo.PhieuKham p ON p.MaPK=c.MaPK WHERE c.MaCD=@MaCD;
  IF @hs IS NULL THROW 51021,N'Không tìm thấy chỉ định.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@pk AND TrangThai='DANGKHAM') THROW 51022,N'Phiếu đã kết luận hoặc hoàn tất.',1;
  UPDATE dbo.ChiDinhXetNghiem SET KetQua=@KetQua,NgayKetQua=SYSDATETIME(),TrangThai='CO_KET_QUA' WHERE MaCD=@MaCD AND TrangThai='CHO';
  IF @@ROWCOUNT<>1 THROW 51023,N'Chỉ định đã có kết quả, không ghi đè.',1;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_LapToa @MaToa varchar(20),@MaPK varchar(20),@LoiDan nvarchar(1000)=NULL,@DongToa dbo.DongToaList READONLY
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF NOT EXISTS(SELECT 1 FROM @DongToa) THROW 51024,N'Toa cần ít nhất một dòng thuốc.',1;
 IF EXISTS(SELECT 1 FROM @DongToa WHERE STT<=0 OR ISNULL(SoLuong,0)<=0 OR ISNULL(SoNgay,0)<=0 OR NULLIF(LTRIM(RTRIM(LieuDung)),N'') IS NULL OR NULLIF(LTRIM(RTRIM(CachDung)),N'') IS NULL)
  THROW 51025,N'Dòng thuốc không hợp lệ.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=MaHS FROM dbo.PhieuKham WHERE MaPK=@MaPK;
  IF @hs IS NULL THROW 51015,N'Không tìm thấy phiếu khám.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@MaPK AND TrangThai='DAKETLUAN') THROW 51026,N'Phiếu phải được kết luận và chưa hoàn tất.',1;
  IF EXISTS(SELECT 1 FROM dbo.ToaThuoc WHERE MaPK=@MaPK) THROW 51027,N'Phiếu đã có toa thuốc.',1;
  IF EXISTS(SELECT 1 FROM @DongToa d LEFT JOIN dbo.Thuoc t ON t.MaThuoc=d.MaThuoc WHERE t.MaThuoc IS NULL OR t.DangSuDung=0)
   THROW 51028,N'Thuốc không tồn tại hoặc đã ngừng sử dụng.',1;
  INSERT dbo.ToaThuoc(MaToa,MaPK,LoiDan) VALUES(@MaToa,@MaPK,@LoiDan);
  INSERT dbo.ChiTietToaThuoc SELECT @MaToa,STT,MaThuoc,SoLuong,LieuDung,CachDung,SoNgay FROM @DongToa;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_ThemKhoanThu @MaTT varchar(20),@MaPK varchar(20),@NoiDung nvarchar(150),@SoTien decimal(18,2)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 IF ISNULL(@SoTien,0)<=0 OR NULLIF(LTRIM(RTRIM(@NoiDung)),N'') IS NULL THROW 51029,N'Nhập nội dung và số tiền dương.',1;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=MaHS FROM dbo.PhieuKham WHERE MaPK=@MaPK;
  IF @hs IS NULL THROW 51015,N'Không tìm thấy phiếu khám.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@MaPK AND TrangThai='HOANTAT') THROW 51030,N'Phiếu đã hoàn tất.',1;
  INSERT dbo.ThanhToan(MaTT,MaPK,NoiDung,SoTien,TrangThai) VALUES(@MaTT,@MaPK,@NoiDung,@SoTien,'CHUATHU');
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_ThanhToan @MaTT varchar(20)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@pk varchar(20),@r int,@key nvarchar(255);
  SELECT @hs=p.MaHS,@pk=p.MaPK FROM dbo.ThanhToan t JOIN dbo.PhieuKham p ON p.MaPK=t.MaPK WHERE t.MaTT=@MaTT;
  IF @hs IS NULL THROW 51031,N'Không tìm thấy khoản thu.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@pk AND TrangThai='HOANTAT') THROW 51030,N'Phiếu đã hoàn tất.',1;
  UPDATE dbo.ThanhToan SET TrangThai='DATHU',NgayThu=SYSDATETIME() WHERE MaTT=@MaTT AND TrangThai='CHUATHU';
  IF @@ROWCOUNT<>1 THROW 51032,N'Khoản này đã thu hoặc được miễn phí.',1;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
CREATE PROCEDURE dbo.usp_HoanTat @MaPK varchar(20)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  DECLARE @hs varchar(20),@r int,@key nvarchar(255),@ngay date,@loai varchar(10);
  SELECT @hs=MaHS,@ngay=CAST(NgayGio AS date),@loai=LoaiKham FROM dbo.PhieuKham WHERE MaPK=@MaPK;
  IF @hs IS NULL THROW 51015,N'Không tìm thấy phiếu khám.',1;
  SET @key=N'HS:'+@hs;
  EXEC @r=sys.sp_getapplock @Resource=@key,@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=5000;
  IF @r<0 THROW 51003,N'Hồ sơ đang được xử lý.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaPK=@MaPK AND TrangThai='DAKETLUAN') THROW 51033,N'Phiếu chưa kết luận hoặc đã hoàn tất.',1;
  IF EXISTS(SELECT 1 FROM dbo.ChiDinhXetNghiem WHERE MaPK=@MaPK AND TrangThai='CHO') THROW 51018,N'Còn xét nghiệm chưa có kết quả.',1;
  IF NOT EXISTS(SELECT 1 FROM dbo.ThanhToan WHERE MaPK=@MaPK) OR EXISTS(SELECT 1 FROM dbo.ThanhToan WHERE MaPK=@MaPK AND TrangThai='CHUATHU')
   THROW 51034,N'Chưa xử lý đủ các khoản viện phí.',1;
  IF @loai='DINHKY'
  BEGIN
   IF NOT EXISTS(SELECT 1 FROM dbo.LanDongLePhi WHERE MaHS=@hs AND @ngay BETWEEN TuNgay AND DenNgay) THROW 51007,N'Lệ phí không có hiệu lực tại ngày khám.',1;
   IF EXISTS(SELECT 1 FROM dbo.PhieuKham WHERE MaHS=@hs AND MaPK<>@MaPK AND LoaiKham='DINHKY' AND TrangThai='HOANTAT' AND Nam=YEAR(@ngay) AND Quy=DATEPART(QUARTER,@ngay))
    THROW 51008,N'Đã hoàn tất lượt định kỳ khác trong quý.',1;
  END;
  UPDATE dbo.PhieuKham SET TrangThai='HOANTAT' WHERE MaPK=@MaPK;
  COMMIT;
 END TRY BEGIN CATCH IF @@TRANCOUNT>0 ROLLBACK; THROW; END CATCH
END;
GO
