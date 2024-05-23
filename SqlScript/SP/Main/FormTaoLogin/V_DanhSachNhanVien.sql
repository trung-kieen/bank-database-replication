USE NGANHANG
GO
CREATE OR ALTER VIEW uv_DanhSachNhanVien
AS 
SELECT DisplayMember =  + HO + ' ' + TEN + ' - ' + MANV
, ValueMember = MANV
FROM NGANHANG.dbo.NhanVien

			