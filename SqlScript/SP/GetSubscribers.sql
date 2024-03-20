use [NGANHANG]
GO
CREATE VIEW [dbo].[uv_GetSubcribers]
AS

SELECT DISTINCT TENCN = p.description, TENSERVER = s.subscriber_server
FROM NGANHANG.dbo.sysmergepublications p,  NGANHANG.dbo.sysmergesubscriptions s
WHERE p.pubid = s.pubid AND s.subscriber_server <> @@SERVERNAME 
 AND p.name NOT LIKE '%TRACUU'
 -- Tao server tra cuu co ten chu TRACUU nhu NGANHANG_TRACUU
GO

-- SELECT * FROM uv_GetSubcribers
-- DROP VIEW [dbo].[uv_GetSubcribers]

SELECT * FROM uv_GetSubcribers

-- SELECT * FROM sysmergepublications