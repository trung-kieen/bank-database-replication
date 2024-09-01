-- Run in all subscriber site
USE [NGANHANG]
GO
GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO NganHang

GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO ChiNhanh

GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO KhachHang


GRANT EXECUTE ON [SP_ThongKeGiaoDich] TO NganHang
GRANT EXECUTE ON [SP_ThongKeGiaoDich] TO KhachHang

GRANT EXECUTE ON [SP_DSTaiKhoan_ThongKeGD] TO NganHang
GRANT EXECUTE ON [SP_DSTaiKhoan_ThongKeGD] TO KhachHang

USE [NGANHANG]
GO
GRANT EXECUTE ON [SP_ThongKeKhachHang] TO NganHang
GRANT EXECUTE ON [SP_ThongKeKhachHang_SongSong] TO NganHang

GRANT EXECUTE ON [SP_ThongKeTaiKhoan] TO NganHang
GRANT EXECUTE ON [SP_ThongTinTaiKhoan] TO NganHang
GRANT EXECUTE ON [SP_LayThongTinLogin] TO NganHang
GRANT EXECUTE ON [SP_TaoLogin] TO NganHang

GRANT EXECUTE ON [SP_ThongTinTaiKhoan] TO KhachHang
