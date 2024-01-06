﻿use QL_NHAKHOA
go

CREATE OR ALTER PROC SP_NV_LAPHOADON
	@ID_NV VARCHAR(255),
	@ID_BA VARCHAR(255)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
    BEGIN TRAN;

    DECLARE @TONGTIEN MONEY
    DECLARE @TONGTIENTHUOC MONEY
    DECLARE @TONGTIENDV MONEY

    SELECT @TONGTIENTHUOC = SUM(THANHTIEN_THUOC)
    FROM V_DANHMUC_THUOCSD 
    WHERE @ID_BA = ID_BA

    SELECT @TONGTIENDV = THANHTIEN
    FROM V_DICHVU_SD
    WHERE ID_BA = @ID_BA

    SET @TONGTIEN = @TONGTIENTHUOC + @TONGTIENDV

    DECLARE @ID_HOADON VARCHAR(255);
    SET @ID_HOADON = 'HD' + REPLACE(CONVERT(VARCHAR, GETDATE(), 112), '-', '') + RIGHT('0000' + CAST((SELECT COUNT(*) + 1 FROM HOA_DON) AS VARCHAR), 4);

    BEGIN TRY
        INSERT INTO V_HOADON_NHANVIEN (ID_HOADON, ID_NV, ID_BA, TONGTIEN, TONGTIENTHUOC, TONGTIENDV)
        VALUES (@ID_HOADON, @ID_NV, @ID_BA, @TONGTIEN, @TONGTIENTHUOC, @TONGTIENDV);

		UPDATE DICHVU_SD
        SET ID_HOADON = @ID_HOADON
        WHERE ID_BA = @ID_BA;

		waitfor delay '00:00:10'

        SELECT 
            THUOC.TENTHUOC, 
            THUOC_SD.SOLUONG, 
            THUOC.GIATIEN, 
            THUOC_SD.SOLUONG * THUOC.GIATIEN AS THANHTIEN 
        FROM 
            THUOC_SD
        JOIN 
            THUOC ON THUOC_SD.ID_THUOC = THUOC.ID_THUOC
        WHERE 
            THUOC_SD.ID_BA = @ID_BA;

        COMMIT TRAN;
        PRINT 'Hoá đơn đã được tạo thành công!';
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        PRINT 'Đã xảy ra lỗi trong quá trình xử lý hoá đơn.';
    END CATCH
END
GO

CREATE OR ALTER PROC SP_NS_THEM_THUOC_SD
	@ID_BA VARCHAR(255),
	@ID_THUOC VARCHAR(255),
	@SOLUONG INT
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	IF (LEN(ISNULL(@ID_THUOC, '')) = 0)
		BEGIN
			SET @ID_THUOC = (SELECT ID_THUOC FROM THUOC_SD WHERE ID_BA = @ID_BA)
		END

	IF (LEN(ISNULL(@SOLUONG, '')) = 0)
		BEGIN
			SET @SOLUONG = (SELECT SOLUONG FROM THUOC_SD WHERE ID_BA = @ID_BA)
		END

	INSERT INTO V_KEDONTHUOC(
											ID_BA,
											ID_THUOC,
											SOLUONG)

	VALUES									(@ID_BA,
											@ID_THUOC,
											@SOLUONG)

	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể thêm. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN
GO