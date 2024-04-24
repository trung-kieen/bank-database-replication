-- ?? How to implement undo: 
--		- run this SP FROM other site (cost of change database connection!!!) 
--		=>  create undo pair UNDO SP for this SP
-- How to use:
-- Pass parameter same with SP_ChuyenNhanVien 
-- This will revert parameter to push new employee have move to this branch to old branch
-- SP will call in remote server 
-- Return value is id of employee in source branch
USE NGANHANG
GO 
CREATE OR ALTER PROCEDURE SP_ChuyenNhanVien_Undo(
@source_id AS NVARCHAR(10), 
@dest_id as NVARCHAR(10)
)
AS 
BEGIN 
EXEC ('EXEC NGANHANG.dbo.SP_ChuyenNhanVien ?, ?', @dest_id, @source_id) AT [LINK1];

-- recover role on database for this user 
EXEC sp_addrolemember 'NganHang', @source_id

END



/* 
For test we watch out employee in each branch and run SP to see different
SELECT * FROM NhanVien WHERE CMND = '3742578581';
SELECT * FROM LINK1.NGANHANG.dbo.NhanVien WHERE CMND = '3742578581';

*/