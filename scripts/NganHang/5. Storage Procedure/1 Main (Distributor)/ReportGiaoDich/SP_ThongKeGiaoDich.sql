	USE NGANHANG
	GO
	CREATE OR ALTER PROCEDURE SP_ThongKeGiaoDich(
		@sotk AS NCHAR(9) = '417712760'
		-- param can set default value 
		,@tungay AS DATETIME  = '2020-04-23'
		,@denngay AS DATETIME = '2024-04-23'
	)
	AS
	BEGIN

	SET NOCOUNT ON

	--SET @denngay = GETDATE();



CREATE TABLE ##gd (
    SODU_TRUOC MONEY
    , NGAYGD DATETIME
	, SOTIEN MONEY
	, LOAIGD NVARCHAR(10)
	, SODU_SAU MONEY
);




	
		INSERT INTO ##gd
		SELECT SODU_TRUOC = 0,  NGAYGD, SOTIEN, LOAIGD = (
	case
		WHEN SOTK_CHUYEN= @sotk THEN 'CT'
		WHEN SOTK_NHAN= @sotk THEN 'NT'
		ELSE '??'
	END), SODU_SAU = 0
		
		-- Tài khoản có thể nhận tiền từ tài khoản ở chi nhánh khách gửi tiền tới nên phải lấy từ site chủ
		FROM LINK0.NGANHANG.dbo.GD_CHUYENTIEN
		WHERE (SOTK_CHUYEN = @sotk OR SOTK_NHAN = @sotk)
			-- Vì cần tính số dư lùi từ hiện tại nên chỉ lọc bỏ các record trước ngày được xét 
			AND NGAYGD >= @tungay;


		
		INSERT INTO ##gd
		SELECT SODU_TRUOC = 0,  NGAYGD, SOTIEN, LOAIGD, SODU_SAU = 0
		-- Cho phép tài khoản của chi nhánh này thực hiện gửi rút tiền ở chi nhánh khác => tra cứu về site chủ
		FROM LINK0.NGANHANG.dbo.GD_GOIRUT
		WHERE SOTK = @sotk
			-- Vì cần tính số dư lùi từ hiện tại nên chỉ lọc bỏ các record trước ngày được xét 
			AND NGAYGD >= @tungay;




		DECLARE @sodu_truoc AS MONEY;
		DECLARE @sodu_sau AS MONEY;

		SELECT @sodu_sau = SODU
		FROM NGANHANG.dbo.TaiKhoan
		WHERE SOTK = @sotk;

		DECLARE @ngaygd DATETIME, @sotien MONEY, @loaigd NVARCHAR(10);

		DECLARE db_cursor CURSOR FOR 
	SELECT NGAYGD, SOTIEN, LOAIGD
		FROM ##gd
		ORDER BY NGAYGD  DESC
		OPEN db_cursor
		FETCH NEXT FROM db_cursor INTO @ngaygd, @sotien, @loaigd

		WHILE @@FETCH_STATUS = 0
	BEGIN
			-- add instructions to be executed for every row
			SET @sodu_truoc = (
		CASE @loaigd
		WHEN 'GT' THEN @sodu_sau - @sotien
		WHEN 'NT' THEN @sodu_sau - @sotien
		WHEN 'RT' THEN @sodu_sau + @sotien
		WHEN 'CT' THEN @sodu_sau + @sotien
		ELSE @sodu_sau
		END)
			UPDATE ##gd 

		SET SODU_TRUOC = @sodu_truoc , SODU_SAU = @sodu_sau
		-- Use indentity insert in temporary table require to set insert indentity on !!!
		WHERE NGAYGD = @ngaygd AND LOAIGD = @loaigd
			FETCH NEXT FROM db_cursor INTO @ngaygd, @sotien, @loaigd
			SET @sodu_sau = @sodu_truoc
		END

		CLOSE db_cursor
		DEALLOCATE db_cursor
		SELECT SODU_TRUOC, NGAYGD, SOTIEN, LOAIGD, SODU_SAU
		FROM ##gd
		WHERE NGAYGD <= @denngay AND NGAYGD >= @tungay
		ORDER BY NGAYGD ASC;
	    DROP TABLE ##gd;
	END;

	GO 
	
-- EXEC SP_ThongKeGiaoDich '417712760', '2020-04-23 08:52:50.757', '2024-04-23 08:52:50.757' ;
