-- change branch nhan vien 
-- create new employee in new branch first then delete current branch then

-- creation new employee
--		if this branch have employee just change it state to not delete
--			we can't not create duplicate new employee because CMND is unque
--		else this branch will copy data employee to new branch with a custom id
--			so if employee already have id we don't need provide new employee id 
--		delete old employee if this id have to corelation with other table as foreign key => soft delete 
--			else hard delete 

--		delete login user of this employee
-- ??? When undo how we recover login of this user in this branch
-- => NOT DELETE login for user but block login from deleted user 
-- ??? Create new then delete old one => not need to 

-- ?? How to implement undo: 
--		- run this SP FROM other site (cost of change database connection) 
--		- create undo pair UNDO SP for this SP 
-- OTHER solution: To avoid cost check employee id exist  as foreign key we just soft delete for all case instead
-- Return value is new employee id 
USE NGANHANG 
GO
CREATE OR ALTER  PROCEDURE SP_ChuyenNhanVien(
    @ma_nv AS NVARCHAR(10),
    @ma_nv_moi AS NVARCHAR(10)
)
AS
BEGIN

SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
-- Code 
      

    DECLARE @cmnd AS NCHAR(10),
	@ma_cn AS NCHAR(10)
	
	SELECT TOP 1 @ma_cn =  MACN FROM LINK1.NGANHANG.dbo.ChiNhanh;

    SELECT @cmnd = CMND
    FROM NGANHANG.dbo.NhanVien
    WHERE MANV = @ma_nv
    -- If this employee exist in other branch with same personal id
    IF (EXISTS(SELECT MANV
    FROM LINK1.NGANHANG.dbo.NhanVien
    WHERE CMND = @cmnd
	))

-- Create/Update employee in new branch
	BEGIN
        -- Just change state to not deleted 
        UPDATE LINK1.NGANHANG.dbo.NhanVien
		SET TrangThaiXoa = 0 -- set this employee is not deleted
		WHERE CMND = @cmnd
    END
	ELSE
	BEGIN
        -- Make sure new employe id is not exist before 
		IF(EXISTS(SELECT * FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = @ma_nv_moi))
		BEGIN
			RAISERROR('Ma nhan vien moi bi trung', 16, 1)
		END 

        -- Create new one with same information with existed data  
        INSERT INTO LINK1.NGANHANG.dbo.NhanVien
            (MANV, HO, TEN, DIACHI, CMND, PHAI, SODT, MACN, TrangThaiXoa)
        SELECT  @ma_nv_moi, HO, TEN, DIACHI, CMND, PHAI, SODT, @ma_cn,  0
        FROM NGANHANG.dbo.NhanVien
        WHERE CMND = @cmnd
    END;

    -- Delete old employee in old branch

    -- Check if exist as foreign key  
    IF (EXISTS(SELECT *
        FROM NGANHANG.dbo.GD_GOIRUT
        WHERE MANV= @ma_nv)
        OR EXISTS(SELECT *
        FROM NGANHANG.dbo.GD_CHUYENTIEN
        WHERE NGANHANG.dbo.GD_CHUYENTIEN.MANV= @ma_nv)
)
BEGIN
        -- Soft delete 
        UPDATE NGANHANG.dbo.NhanVien
		SET TrangThaiXoa = 1 -- set this employee is deleted
		WHERE MANV = @ma_nv
    END
ELSE
BEGIN
        -- Hard delete
    DELETE FROM NGANHANG.dbo.NhanVien
	WHERE MANV = @ma_nv
    END

    -- Return new employee id as result 
    SELECT MANV
    FROM LINK1.NGANHANG.dbo.NhanVien
    WHERE CMND = @cmnd
COMMIT TRANSACTION

END;
	



