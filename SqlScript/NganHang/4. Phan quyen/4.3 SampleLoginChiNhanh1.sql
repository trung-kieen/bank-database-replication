/*
Du lieu mau cho cac login va user trong phan manh 1
*/
USE NGANHANG
GO

EXEC SP_TaoLogin 'nh1', '123' , '001', 'NganHang'
EXEC SP_TaoLogin 'cn1', '123' , '004', 'ChiNhanh'
EXEC SP_TaoLogin 'kh1', '123' , '009', 'KhachHang'
