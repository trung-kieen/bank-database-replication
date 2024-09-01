-- Run on main server
USE NGANHANG
GO
CREATE OR ALTER PROCEDURE SP_SynchronizeArticle
AS 
BEGIN 
EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_TANDINH'
--     ,  @publisher =  N'TM\NGANHANG' 
WAITFOR DELAY '0:0:4'
EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_BENTHANH'
WAITFOR DELAY '0:0:4'

EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_TRACUU'
END
-- EXEC sp_startpushsubscription_agent @publication = N'NGANHANG_TANDINH', @subscriber = N'TM\NGANHANG2'
--, @subscriber_db = N'NGANHANG'
--, @publisher = N'TM\NGANHANG'