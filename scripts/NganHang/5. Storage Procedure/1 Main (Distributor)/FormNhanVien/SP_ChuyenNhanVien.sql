USE NGANHANG
GO
CREATE OR ALTER  PROCEDURE SP_ChuyenNhanVien(
    @ma_nv AS NVARCHAR(10),
    @ma_nv_moi AS NVARCHAR(10),
	@ma_cn AS NCHAR(10)  = NULL,
	@ma_cn_moi AS NCHAR(10)

)
AS
BEGIN


SET XACT_ABORT ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE

BEGIN DISTRIBUTED TRANSACTION



    DECLARE @cmnd AS NCHAR(10)

	IF(@ma_cn IS NULL)
	BEGIN
		SELECT TOP 1 @ma_cn =  MACN FROM NGANHANG.dbo.ChiNhanh;
	END



    SELECT @cmnd = CMND
    FROM NGANHANG.dbo.NhanVien
    WHERE MANV = @ma_nv
    IF (EXISTS(SELECT MANV
    FROM LINK0.NGANHANG.dbo.NhanVien
    WHERE CMND = @cmnd AND MACN = @ma_cn_moi
	))
-- Create/Update employee in new branch
	BEGIN
        -- Just change state to not deleted
        UPDATE LINK0.NGANHANG.dbo.NhanVien
		SET TrangThaiXoa = 0 -- set this employee is not deleted
		WHERE CMND = @cmnd AND MACN = @ma_cn_moi
    END
	ELSE
	BEGIN
	--	IF(EXISTS(SELECT * FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = @ma_nv_moi))
	--	BEGIN
	--		RAISERROR('Ma nhan vien moi bi trung', 16, 1)
	--	END

        INSERT INTO LINK0.NGANHANG.dbo.NhanVien
            (MANV, HO, TEN, DIACHI, CMND, PHAI, SODT, MACN, TrangThaiXoa)
        SELECT  @ma_nv_moi, HO, TEN, DIACHI, CMND, PHAI, SODT, @ma_cn_moi,  0
        FROM NGANHANG.dbo.NhanVien
        WHERE CMND = @cmnd AND MACN = @ma_cn
    END;

    IF (EXISTS(SELECT *
        FROM NGANHANG.dbo.GD_GOIRUT
        WHERE MANV= @ma_nv)
        OR EXISTS(SELECT *
        FROM NGANHANG.dbo.GD_CHUYENTIEN
        WHERE NGANHANG.dbo.GD_CHUYENTIEN.MANV= @ma_nv)
)
	BEGIN
        UPDATE NGANHANG.dbo.NhanVien
		SET TrangThaiXoa = 1
		WHERE MANV = @ma_nv


    END
	ELSE
	BEGIN
		DELETE FROM NGANHANG.dbo.NhanVien
		WHERE MANV = @ma_nv
    END

    SELECT MANV
    FROM LINK0.NGANHANG.dbo.NhanVien
    WHERE CMND = @cmnd AND MACN = @ma_cn_moi


COMMIT TRANSACTION

END;
