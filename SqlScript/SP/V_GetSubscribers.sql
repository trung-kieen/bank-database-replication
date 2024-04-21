/* 
Lay danh sach cac phan manh / chi nhanh de su dung trong form login 
SP nen duoc su dung o server chinh 
*/
use [NGANHANG]
GO
CREATE OR ALTER VIEW [dbo].[uv_GetSubcribers]
AS

SELECT  TENCN = p.description, TENSERVER = s.subscriber_server
FROM NGANHANG.dbo.sysmergepublications p,  NGANHANG.dbo.sysmergesubscriptions s
WHERE p.pubid = s.pubid AND s.subscriber_server <> @@SERVERNAME 
 AND s.subscriber_server IS  NOT NULL
 AND p.description IS  NOT NULL
 AND p.name NOT LIKE '%TRACUU' 

 -- Tao server tra cuu co ten chu TRACUU nhu NGANHANG_TRACUU
GO


/*
-- DROP VIEW [dbo].[uv_GetSubcribers] 
SELECT * FROM uv_GetSubcribers
*/
