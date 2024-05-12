use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_ChuyenNhanVien', @source_owner = N'dbo', @source_object = N'SP_ChuyenNhanVien', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_ChuyenNhanVien', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_ChuyenNhanVien_Undo', @source_owner = N'dbo', @source_object = N'SP_ChuyenNhanVien_Undo', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_ChuyenNhanVien_Undo', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_Helper_IsExistEmployee', @source_owner = N'dbo', @source_object = N'SP_Helper_IsExistEmployee', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_Helper_IsExistEmployee', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_Helper_MaNV_ChiNhanhKhac', @source_owner = N'dbo', @source_object = N'SP_Helper_MaNV_ChiNhanhKhac', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_Helper_MaNV_ChiNhanhKhac', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_IsExistEmployee', @source_owner = N'dbo', @source_object = N'SP_IsExistEmployee', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_IsExistEmployee', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_LayThongTinNhanVien', @source_owner = N'dbo', @source_object = N'SP_LayThongTinNhanVien', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LayThongTinNhanVien', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_TaoLogin', @source_owner = N'dbo', @source_object = N'SP_TaoLogin', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_TaoLogin', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_ThongKeGiaoDich', @source_owner = N'dbo', @source_object = N'SP_ThongKeGiaoDich', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_ThongKeGiaoDich', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'SP_ThongKeTaiKhoan', @source_owner = N'dbo', @source_object = N'SP_ThongKeTaiKhoan', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_ThongKeTaiKhoan', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO

-- View
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'uv_AccountDetails', @source_owner = N'dbo', @source_object = N'uv_AccountDetails', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'uv_AccountDetails', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'uv_GetSubcribers', @source_owner = N'dbo', @source_object = N'uv_GetSubcribers', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'uv_GetSubcribers', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO
use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = N'uv_LoginByRole', @source_owner = N'dbo', @source_object = N'uv_LoginByRole', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'uv_LoginByRole', @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
GO