USE NGANHANG
GO 
EXEC SP_AddSPArticle N'SP_ChuyenNhanVien'
EXEC SP_AddSPArticle N'SP_ChuyenTien'
EXEC SP_AddSPArticle N'SP_LayThongTinNhanVien'
EXEC SP_AddSPArticle N'SP_TaoLogin'
EXEC SP_AddSPArticle N'SP_TimNhanVien'
EXEC SP_AddSPArticle N'SP_ThongKeGiaoDich'
EXEC SP_AddSPArticle N'SP_ThongKeTaiKhoan'
EXEC SP_AddSPArticle N'SP_GuiRut'
EXEC SP_AddViewArticle N'uv_AccountDetails'
EXEC SP_AddViewArticle N'uv_SoDuTaiKhoan'
EXEC SP_AddViewArticle N'uv_GetSubcribers'