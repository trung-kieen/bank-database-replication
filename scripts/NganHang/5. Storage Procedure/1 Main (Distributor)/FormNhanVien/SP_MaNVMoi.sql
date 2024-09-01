USE NGANHANG 
GO 
CREATE OR ALTER PROCEDURE SP_MaNVMoi

AS
BEGIN
	DECLARE @NextId varchar(50), @IdCount int, @Prefix varchar(25), @NumberOfSuffixDigits tinyint
	Set @Prefix = 'NV'
	Set @NumberOfSuffixDigits = 8

	SELECT @IdCount = count(*) FROM LINK0.NGANHANG.dbo.NhanVien 
	SET @NextId = @Prefix + REPLICATE('0', @NumberOfSuffixDigits - LEN(@IdCount + 1)) + CAST (@IdCount + 1 AS varchar)
	
	WHILE  EXISTS (SELECT MANV FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = @NextId)
	BEGIN 
	SET @IdCount = @IdCount + 1
	SET @NextId = @Prefix + REPLICATE('0', @NumberOfSuffixDigits - LEN(@IdCount + 1)) + CAST (@IdCount + 1 AS varchar)
	END 

	SELECT @NextId
END;

GO 
EXEC SP_MaNVMoi