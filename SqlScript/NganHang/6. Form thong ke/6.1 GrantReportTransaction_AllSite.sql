-- Run in all subscriber site
USE NGANHANG
GO
GRANT EXECUTE ON [SP_ThongKeGiaoDich] TO NganHang
GRANT EXECUTE ON [SP_ThongKeGiaoDich] TO KhachHang
USE [NGANHANG]
GO
GRANT EXECUTE ON [SP_ThongKeKhachHang] TO NganHang
GRANT EXECUTE ON [SP_ThongKeKhachHang_SongSong] TO NganHang
