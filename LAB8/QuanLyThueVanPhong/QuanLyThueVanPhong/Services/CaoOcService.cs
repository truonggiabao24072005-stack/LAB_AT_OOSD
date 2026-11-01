using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyThueVanPhong.Data;
using QuanLyThueVanPhong.Models;

namespace QuanLyThueVanPhong.Services
{
    public class CaoOcService
    {
        private readonly DbContext _db;

        public CaoOcService()
        {
            _db = DbContext.Instance;
        }

        // ================= 1. Quản lý Tầng & Phòng =================
        public List<Tang> LayDanhSachTang() => _db.Tangs.OrderBy(t => t.SoThuTuTang).ToList();

        public List<Phong> LayDanhSachPhong(string maTang = null, string tinhTrang = null)
        {
            var query = _db.Phongs.AsQueryable();
            if (!string.IsNullOrEmpty(maTang))
                query = query.Where(p => p.MaTang == maTang);
            if (!string.IsNullOrEmpty(tinhTrang))
                query = query.Where(p => p.TinhTrang == tinhTrang);
            return query.ToList();
        }

        public decimal TinhGiaThuePhong(double dienTich, decimal donGiaCoBan, double heSoTang)
        {
            // Giá thuê phòng được ấn định tùy theo độ cao (hệ số tầng) và diện tích sử dụng
            return (decimal)dienTich * donGiaCoBan * (decimal)heSoTang;
        }

        // ================= 2. Quản lý Khách hàng & Hợp đồng thuê =================
        public List<KhachHang> LayDanhSachKhachHang() => _db.KhachHangs.ToList();

        public List<HopDongThue> LayDanhSachHopDong() => _db.HopDongThues.ToList();

        public (bool Success, string Message, HopDongThue HopDong) TaoHopDongThue(
            string maKH, 
            List<string> dsMaPhong, 
            int thoiHanThue, 
            DateTime ngayBatDau,
            decimal tienCoc)
        {
            // Kiểm tra quy định thời gian thuê tối thiểu 6 tháng
            if (thoiHanThue < 6)
                return (false, "Quy định cao ốc: Thời gian của đợt thuê ít nhất phải từ 6 tháng trở lên!", null);

            if (dsMaPhong == null || dsMaPhong.Count == 0)
                return (false, "Vui lòng chọn ít nhất một văn phòng cần thuê!", null);

            var kh = _db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
            if (kh == null)
                return (false, "Khách hàng không tồn tại trong hệ thống!", null);

            // Kiểm tra các phòng có đang trống không
            var phongs = _db.Phongs.Where(p => dsMaPhong.Contains(p.MaPhong)).ToList();
            var phongBan = phongs.FirstOrDefault(p => p.TinhTrang != "Trống");
            if (phongBan != null)
                return (false, $"Phòng {phongBan.MaPhong} hiện không còn trống (Trạng thái: {phongBan.TinhTrang})!", null);

            string maHD = "HD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string soHD = "HĐ-HUTECH/" + DateTime.Now.Year + "-" + (_db.HopDongThues.Count + 1).ToString("D3");
            DateTime ngayKetThuc = ngayBatDau.AddMonths(thoiHanThue).AddDays(-1);

            // Tính tổng tiền thuê 1 tháng cho tất cả các phòng chọn
            decimal tongGiaThue1Thang = phongs.Sum(p => p.GiaThueThang);
            // Khách phải trả trước tiền thuê của 6 tháng đầu tiên
            decimal tongTien6ThangDau = tongGiaThue1Thang * 6;

            var hd = new HopDongThue
            {
                MaHD = maHD,
                SoHopDong = soHD,
                NgayLap = DateTime.Now,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                ThoiHanThue = thoiHanThue,
                TienCoc = tienCoc > 0 ? tienCoc : tongGiaThue1Thang * 2,
                TongTienThue6Thang = tongTien6ThangDau,
                DonGiaThueThangMoi = tongGiaThue1Thang,
                TrangThai = "Đang hiệu lực",
                MaKH = maKH
            };
            _db.HopDongThues.Add(hd);

            // Lưu chi tiết các phòng thuê
            int cthdIdx = 1;
            foreach (var p in phongs)
            {
                _db.ChiTietHopDongs.Add(new ChiTietHopDong
                {
                    MaCTHD = "CTHD_" + maHD + "_" + (cthdIdx++),
                    MaHD = maHD,
                    MaPhong = p.MaPhong,
                    DienTichThue = p.DienTich,
                    DonGiaThang = p.GiaThueThang,
                    NgayBanGiao = ngayBatDau
                });
                p.TinhTrang = "Đang thuê";
            }

            // Lập ngay hóa đơn thu tiền thuê 6 tháng đầu tiên
            var hdtt = new HoaDonTienThue
            {
                MaHDTienThue = "HDTT_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"),
                KyThanhToan = "Trả trước 6 tháng đầu tiên",
                NgayLapHoaDon = DateTime.Now,
                SoTienThue = tongTien6ThangDau,
                HanNopTien = ngayBatDau,
                NgayThanhToan = null,
                HinhThucThanhToan = "Chuyển khoản",
                TrangThai = "Chưa thanh toán",
                MaHD = maHD
            };
            _db.HoaDonTienThues.Add(hdtt);

            return (true, $"Lập hợp đồng thành công! Số HĐ: {soHD}. Tiền thuê trả trước 6 tháng đầu: {tongTien6ThangDau:N0} VNĐ.", hd);
        }

        // ================= 3. Nghiệp vụ Lập Phiếu Gia Hạn (Câu 6) =================
        public (bool Success, string Message, PhieuGiaHan Phieu) LapPhieuGiaHan(
            string maHD, 
            int soThangGiaHan, 
            List<string> dsPhongGiaHan, 
            string lyDo, 
            string nguoiLap)
        {
            var hd = _db.HopDongThues.FirstOrDefault(h => h.MaHD == maHD);
            if (hd == null)
                return (false, "Không tìm thấy thông tin hợp đồng thuê!", null);

            // Ràng buộc 1: Thời gian gia hạn <= 1/2 thời gian của đợt thuê ban đầu
            int maxThangGiaHan = hd.ThoiHanThue / 2;
            if (soThangGiaHan <= 0)
                return (false, "Số tháng xin gia hạn phải lớn hơn 0!", null);

            if (soThangGiaHan > maxThangGiaHan)
            {
                return (false, $"VI PHẠM QUY ĐỊNH GIA HẠN:\nThời gian gia hạn ({soThangGiaHan} tháng) vượt quá 1/2 thời gian thuê gốc ({hd.ThoiHanThue} tháng)!\nThời gian gia hạn tối đa cho phép là {maxThangGiaHan} tháng.", null);
            }

            // Ràng buộc 2: Việc gia hạn chỉ cho phép khi văn phòng thuê không còn nợ tiền thuê mặt bằng
            var noTienThue = _db.HoaDonTienThues
                .Where(h => h.MaHD == maHD && h.TrangThai == "Chưa thanh toán")
                .ToList();

            if (noTienThue.Any())
            {
                decimal tongNoThue = noTienThue.Sum(h => h.SoTienThue);
                return (false, $"TỪ CHỐI GIA HẠN:\nKhách hàng hiện vẫn còn nợ {tongNoThue:N0} VNĐ tiền thuê văn phòng ({noTienThue.Count} hóa đơn chưa thanh toán). Vui lòng yêu cầu thanh toán hết tiền thuê trước khi gia hạn!", null);
            }

            // Ràng buộc 3: Đã thanh toán đầy đủ các dịch vụ đã sử dụng (điện, nước, internet...)
            var noDichVu = _db.HoaDonDichVus
                .Where(d => d.MaHD == maHD && d.TrangThai == "Chưa thanh toán")
                .ToList();

            if (noDichVu.Any())
            {
                decimal tongNoDV = noDichVu.Sum(d => d.TongTien);
                return (false, $"TỪ CHỐI GIA HẠN:\nKhách hàng hiện còn nợ {tongNoDV:N0} VNĐ tiền dịch vụ sử dụng (điện, nước, internet...). Vui lòng thanh toán đầy đủ hóa đơn dịch vụ trước khi gia hạn!", null);
            }

            if (dsPhongGiaHan == null || dsPhongGiaHan.Count == 0)
                return (false, "Vui lòng chọn ít nhất một văn phòng cần tiếp tục gia hạn!", null);

            // Đủ điều kiện gia hạn -> Lập phiếu gia hạn
            string maPGH = "PGH_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string soPhieu = "PGH-HUTECH/" + DateTime.Now.Year + "-" + (_db.PhieuGiaHans.Count + 1).ToString("D3");
            DateTime ngayBatDauGH = hd.NgayKetThuc.AddDays(1);
            DateTime ngayKetThucGH = hd.NgayKetThuc.AddMonths(soThangGiaHan);

            var pgh = new PhieuGiaHan
            {
                MaPhieuGH = maPGH,
                SoPhieu = soPhieu,
                NgayLap = DateTime.Now,
                ThoiGianGiaHan = soThangGiaHan,
                NgayBatDauGH = ngayBatDauGH,
                NgayKetThucGH = ngayKetThucGH,
                LyDoGiaHan = lyDo ?? "Tiếp tục duy trì hoạt động kinh doanh",
                TrangThaiDuyet = "Đã duyệt",
                MaHD = maHD,
                NguoiLap = nguoiLap ?? "Cán bộ BQL"
            };
            _db.PhieuGiaHans.Add(pgh);

            // Chi tiết phòng gia hạn
            foreach (var maP in dsPhongGiaHan)
            {
                var phong = _db.Phongs.FirstOrDefault(p => p.MaPhong == maP);
                _db.ChiTietGiaHans.Add(new ChiTietGiaHan
                {
                    MaCTGH = "CTGH_" + maPGH + "_" + maP,
                    MaPhieuGH = maPGH,
                    MaPhong = maP,
                    GiaHanDenNgay = ngayKetThucGH,
                    DonGiaGiaHan = phong?.GiaThueThang ?? 0
                });
            }

            // Cập nhật ngày kết thúc mới cho Hợp đồng và trạng thái
            hd.NgayKetThuc = ngayKetThucGH;
            hd.TrangThai = "Đã gia hạn";

            return (true, $"DUYỆT GIA HẠN THÀNH CÔNG!\nSố phiếu: {soPhieu}\nThời gian gia hạn: {soThangGiaHan} tháng (Hạn hợp đồng mới đến: {ngayKetThucGH:dd/MM/yyyy}).", pgh);
        }

        // ================= 4. Quản lý Thu tiền thuê & Thu tiền Dịch vụ (Câu 4) =================
        public List<HoaDonTienThue> LayDanhSachHoaDonTienThue(string maHD = null)
        {
            var q = _db.HoaDonTienThues.AsQueryable();
            if (!string.IsNullOrEmpty(maHD))
                q = q.Where(h => h.MaHD == maHD);
            return q.OrderByDescending(h => h.NgayLapHoaDon).ToList();
        }

        public List<HoaDonDichVu> LayDanhSachHoaDonDichVu(string maHD = null)
        {
            var q = _db.HoaDonDichVus.AsQueryable();
            if (!string.IsNullOrEmpty(maHD))
                q = q.Where(d => d.MaHD == maHD);
            return q.OrderByDescending(d => d.Nam).ThenByDescending(d => d.Thang).ToList();
        }

        public bool ThanhToanHoaDonTienThue(string maHDTT, string hinhThuc)
        {
            var hd = _db.HoaDonTienThues.FirstOrDefault(h => h.MaHDTienThue == maHDTT);
            if (hd == null || hd.TrangThai == "Đã thanh toán") return false;
            hd.TrangThai = "Đã thanh toán";
            hd.NgayThanhToan = DateTime.Now;
            hd.HinhThucThanhToan = hinhThuc;
            return true;
        }

        public bool ThanhToanHoaDonDichVu(string maHDDV)
        {
            var hd = _db.HoaDonDichVus.FirstOrDefault(h => h.MaHDDV == maHDDV);
            if (hd == null || hd.TrangThai == "Đã thanh toán") return false;
            hd.TrangThai = "Đã thanh toán";
            hd.NgayThanhToan = DateTime.Now;
            return true;
        }

        public (bool Success, string Message) TaoHoaDonTienThueThang(string maHD, int thang, int nam)
        {
            var hd = _db.HopDongThues.FirstOrDefault(h => h.MaHD == maHD);
            if (hd == null) return (false, "Hợp đồng không tồn tại!");

            string ky = $"Tháng {thang:D2}/{nam}";
            if (_db.HoaDonTienThues.Any(x => x.MaHD == maHD && x.KyThanhToan == ky))
                return (false, $"Hóa đơn tiền thuê cho kỳ {ky} đã tồn tại!");

            var hdtt = new HoaDonTienThue
            {
                MaHDTienThue = "HDTT_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"),
                KyThanhToan = ky,
                NgayLapHoaDon = new DateTime(nam, thang, 1),
                SoTienThue = hd.DonGiaThueThangMoi,
                HanNopTien = new DateTime(nam, thang, 5), // Đầu tháng phải trả
                NgayThanhToan = null,
                HinhThucThanhToan = "Chuyển khoản",
                TrangThai = "Chưa thanh toán",
                MaHD = maHD
            };
            _db.HoaDonTienThues.Add(hdtt);
            return (true, $"Đã lập hóa đơn tiền thuê đầu tháng {thang:D2}/{nam}: {hd.DonGiaThueThangMoi:N0} VNĐ.");
        }

        public (bool Success, string Message) TaoHoaDonDichVuCuoiThang(string maHD, string maPhong, int thang, int nam, decimal tienDien, decimal tienNuoc, decimal tienNet, decimal tienKhac)
        {
            DateTime ngayCuoiThang = new DateTime(nam, thang, DateTime.DaysInMonth(nam, thang));
            var hddv = new HoaDonDichVu
            {
                MaHDDV = "HDDV_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"),
                MaHD = maHD,
                MaPhong = maPhong,
                Thang = thang,
                Nam = nam,
                TienDien = tienDien,
                TienNuoc = tienNuoc,
                TienInternet = tienNet,
                TienDichVuKhac = tienKhac,
                TongTien = tienDien + tienNuoc + tienNet + tienKhac,
                HanThanhToan = ngayCuoiThang, // Cuối tháng phải thanh toán
                NgayThanhToan = null,
                TrangThai = "Chưa thanh toán"
            };
            _db.HoaDonDichVus.Add(hddv);
            return (true, $"Đã lập hóa đơn dịch vụ cuối tháng {thang:D2}/{nam}: {hddv.TongTien:N0} VNĐ.");
        }

        // ================= 5. Quản lý Nhân sự & Thẻ giữ xe =================
        public List<NhanVienVanPhong> LayDanhSachNhanVien(string maCongTy = null)
        {
            var q = _db.NhanVienVanPhongs.AsQueryable();
            if (!string.IsNullOrEmpty(maCongTy))
                q = q.Where(nv => nv.MaCongTy == maCongTy);
            return q.ToList();
        }

        public (bool Success, string Message) BaoCaoNhanVienMoi(NhanVienVanPhong nv)
        {
            if (string.IsNullOrEmpty(nv.MaNV) || string.IsNullOrEmpty(nv.HoTen))
                return (false, "Mã nhân viên và Họ tên không được để trống!");

            if (_db.NhanVienVanPhongs.Any(x => x.MaNV == nv.MaNV))
                return (false, "Mã nhân viên này đã tồn tại trong hệ thống cao ốc!");

            nv.NgayBaoCao = DateTime.Now;
            nv.TrangThai = "Đang làm việc";
            _db.NhanVienVanPhongs.Add(nv);
            return (true, $"Tiếp nhận báo cáo nhân viên mới {nv.HoTen} ({nv.MaNV}) thành công!");
        }

        public (bool Success, string Message, TheGiuXe TheXe) CapTheGiuXe(string maNV, string bienSo, string loaiXe, string nhanHieu, string mauXe)
        {
            var nv = _db.NhanVienVanPhongs.FirstOrDefault(x => x.MaNV == maNV);
            if (nv == null)
                return (false, "Nhân viên không tồn tại trong danh sách văn phòng cao ốc!", null);

            string maThe = "THE_XE_" + (_db.TheGiuXes.Count + 1).ToString("D3");
            var the = new TheGiuXe
            {
                MaThe = maThe,
                MaNV = maNV,
                BienSoXe = bienSo,
                LoaiXe = loaiXe,
                NhanHieu = nhanHieu,
                MauXe = mauXe,
                NgayCap = DateTime.Now,
                TrangThai = "Đang hoạt động"
            };
            _db.TheGiuXes.Add(the);
            return (true, $"Cấp thẻ giữ xe {maThe} thành công cho nhân viên {nv.HoTen} (Biển số: {bienSo})!", the);
        }

        // ================= 6. Kiểm tra Định kỳ 1 năm & Xử phạt Vi phạm kết cấu =================
        public List<DotKiemTra> LayDanhSachDotKiemTra() => _db.DotKiemTras.ToList();
        public List<BienBanKiemTraPhong> LayDanhSachBienBanKiemTra() => _db.BienBanKiemTraPhongs.ToList();
        public List<BienBanViPham> LayDanhSachBienBanViPham() => _db.BienBanViPhams.ToList();

        public (bool Success, string Message) LapBienBanViPham(string maPhong, string maKH, string hanhVi, decimal mucPhat, string bienPhap, int soNgayKhacPhuc)
        {
            string maBBVP = "BBVP_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var bb = new BienBanViPham
            {
                MaBBVP = maBBVP,
                MaPhong = maPhong,
                MaKH = maKH,
                NgayLap = DateTime.Now,
                HanhViViPham = hanhVi ?? "Tự ý thay đổi, chỉnh sửa kết cấu văn phòng",
                MucPhat = mucPhat > 0 ? mucPhat : 20000000,
                BienPhapKhacPhuc = bienPhap ?? "Buộc khôi phục nguyên trạng kết cấu ban đầu theo quy định cao ốc",
                HanKhacPhuc = DateTime.Now.AddDays(soNgayKhacPhuc > 0 ? soNgayKhacPhuc : 10),
                HanNopPhat = DateTime.Now.AddDays(15),
                NgayNopPhat = null,
                TrangThai = "Chưa nộp phạt"
            };
            _db.BienBanViPhams.Add(bb);

            // Cập nhật phòng sang trạng thái Vi phạm
            var phong = _db.Phongs.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null) phong.TinhTrang = "Vi phạm";

            return (true, $"Lập biên bản vi phạm {maBBVP} thành công! Mức phạt: {bb.MucPhat:N0} VNĐ. Buộc khắc phục trước ngày {bb.HanKhacPhuc:dd/MM/yyyy}.");
        }

        public bool XacNhanNopPhat(string maBBVP)
        {
            var bb = _db.BienBanViPhams.FirstOrDefault(x => x.MaBBVP == maBBVP);
            if (bb == null || bb.TrangThai == "Đã nộp phạt") return false;
            bb.TrangThai = "Đã nộp phạt";
            bb.NgayNopPhat = DateTime.Now;

            // Nếu đã nộp phạt và khắc phục, trả lại trạng thái cho phòng
            var phong = _db.Phongs.FirstOrDefault(p => p.MaPhong == bb.MaPhong);
            if (phong != null && phong.TinhTrang == "Vi phạm")
                phong.TinhTrang = "Đang thuê";

            return true;
        }
    }
}
