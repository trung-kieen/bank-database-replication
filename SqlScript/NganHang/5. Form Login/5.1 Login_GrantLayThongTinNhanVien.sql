-- NOTE: Require create SP [SP_LayThongTinNhanVien] 
-- SP must create on main site and push to all subscriber site https://youtu.be/C-6vRRZg3P0?si=k0j3qYI3Us87jmaK
-- 
USE [NGANHANG]
GO
GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO NganHang

GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO ChiNhanh

GRANT EXECUTE ON [SP_LayThongTinNhanVien] TO KhachHang
