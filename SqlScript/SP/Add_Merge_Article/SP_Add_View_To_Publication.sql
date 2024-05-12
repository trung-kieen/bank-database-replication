USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[View_AddToPublication]    Script Date: 5/9/2024 12:46:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR  ALTER   PROCEDURE [dbo].[View_AddToPublication](
	@view_name AS NVARCHAR(100)
)
AS
BEGIN
exec sp_addmergearticle @publication = N'NGANHANG_BENTHANH', @article = @view_name, @source_owner = N'dbo', @source_object = @view_name, @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = @view_name, @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
exec sp_addmergearticle @publication = N'NGANHANG_TANDINH', @article = @view_name, @source_owner = N'dbo', @source_object = @view_name, @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = @view_name, @force_reinit_subscription = 1
,@force_invalidate_snapshot = 1
END;

GO


