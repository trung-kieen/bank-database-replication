USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_AddToPublication]    Script Date: 5/9/2024 12:45:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER   PROCEDURE [dbo].[SP_AddToPublication](
	@sp_name AS NVARCHAR(100)
)
AS
BEGIN
exec sp_addmergearticle @publication = N'NGANHANG_BENTHANH', @article = @sp_name, @source_owner = N'dbo', @source_object = @sp_name, @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = @sp_name, @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = @sp_name, @source_owner = N'dbo', @source_object = @sp_name, @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = @sp_name, @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
END;
GO


