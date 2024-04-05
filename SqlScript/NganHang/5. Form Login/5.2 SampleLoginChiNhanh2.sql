/*
Du lieu mau cho cac login va user trong phan manh 1
*/
USE NGANHANG
GO
EXEC SP_TaoLogin 'nh2', '123' , '002', 'NganHang'
EXEC SP_TaoLogin 'cn2', '123' , '006', 'ChiNhanh'
EXEC SP_TaoLogin 'kh2', '123' , '005', 'KhachHang'