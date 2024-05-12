USE NGANHANG
GO 
EXEC SP_AddToPublication N'SP_ChuyenNhanVien'
EXEC SP_AddToPublication N'SP_LayThongTinNhanVien'
EXEC SP_AddToPublication N'SP_TaoLogin'
EXEC SP_AddToPublication N'SP_ThongKeGiaoDich'
EXEC SP_AddToPublication N'SP_ThongKeTaiKhoan'
EXEC SP_AddToPublication N'SP_GuiRut'
EXEC View_AddToPublication N'uv_AccountDetails'