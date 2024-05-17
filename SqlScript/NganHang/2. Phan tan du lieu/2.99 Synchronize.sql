-- Run on main server
USE NGANHANG
GO
EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_TANDINH'
--     ,  @publisher =  N'TM\NGANHANG' 

EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_BENTHANH'

EXEC sp_startpublication_snapshot
     @publication =  N'NGANHANG_TRACUU'

-- EXEC sp_startpushsubscription_agent @publication = N'NGANHANG_TANDINH', @subscriber = N'TM\NGANHANG2'
--, @subscriber_db = N'NGANHANG'
--, @publisher = N'TM\NGANHANG'