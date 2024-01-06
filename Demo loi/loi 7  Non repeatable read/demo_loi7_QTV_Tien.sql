USE QL_NHAKHOA
GO

--=========================CẬP NHẬT THÔNG TIN THUỐC=======================================

CREATE OR ALTER VIEW V_XEM_THEM_SUA_XOA_TTTHUOC
AS
	SELECT*
	FROM THUOC
GO

--Xem, thêm, sửa, xóa số lượng tồn kho

CREATE OR ALTER VIEW V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
AS
	SELECT*
	FROM SO_LUONG_TON_KHO
GO

GRANT SELECT, INSERT, UPDATE, DELETE ON V_XEM_THEM_SUA_XOA_TTTHUOC TO QUAN_TRI_VIEN	  
GRANT SELECT, INSERT, UPDATE, DELETE ON V_XEM_THEM_SUA_XOA_SOLUONGTONKHO TO QUAN_TRI_VIEN
GO

CREATE OR ALTER PROC sp_CAPNHAT_TT_THUOC
	@ID_THUOC VARCHAR(255),
	@tenthuoc NVARCHAR(30) = NULL,
	@chidinh NVARCHAR(100) = NULL,
	@ngayhethan DATE = NULL,
	@giatien MONEY = NULL,
	@soluong int = NULL
AS
BEGIN TRAN
	IF (LEN(ISNULL(@tenthuoc, '')) = 0)
		BEGIN
			SET @tenthuoc = (SELECT TENTHUOC FROM THUOC WHERE ID_THUOC = @ID_THUOC)
		END


	IF (LEN(ISNULL(@chidinh, '')) = 0)
		BEGIN
			SET @chidinh = (SELECT CHIDINH FROM THUOC WHERE ID_THUOC = @ID_THUOC)
		END


	IF (LEN(ISNULL(@ngayhethan, '')) = 0)
		BEGIN
			SET @ngayhethan = (SELECT NGAYHETHAN FROM THUOC WHERE ID_THUOC = @ID_THUOC)
		END


	IF (LEN(ISNULL(@giatien, '')) = 0)
		BEGIN
			SET @giatien = (SELECT GIATIEN FROM THUOC WHERE ID_THUOC = @ID_THUOC)
		END


	IF (LEN(ISNULL(@soluong, '')) = 0)
		BEGIN
			SET @soluong = (SELECT SOLUONG FROM SO_LUONG_TON_KHO WHERE ID_THUOC = @ID_THUOC)
		END


	DECLARE @id_qtv VARCHAR(255)
	SET @id_qtv = CURRENT_USER


	UPDATE V_XEM_THEM_SUA_XOA_TTTHUOC
	SET TENTHUOC = @tenthuoc,
		CHIDINH = @chidinh,
		NGAYHETHAN = @ngayhethan,
		GIATIEN = @giatien
		--ID_QTV = @id_qtv
	WHERE ID_THUOC = @ID_THUOC

	--waitfor delay '00:00:10'

	UPDATE V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
	SET ID_THUOC = @ID_THUOC,
		SOLUONG = @soluong
	WHERE ID_THUOC = @ID_THUOC
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
	
COMMIT TRAN
GO

--sp_cập nhật thông tin thuốc Quản trị viên

declare @idthuoc VARCHAR(255),
		@tenthuoc NVARCHAR(30) = NULL,
		@chidinh NVARCHAR(100) = NULL,
		@ngayhethan DATE,
		@giatien money = NULL,
		@soluong int

set @idthuoc = (select top 1 ID_THUOC from THUOC where TENTHUOC = N'Lisinopril')
set @soluong = 1
set @giatien = 100
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
exec sp_CAPNHAT_TT_THUOC @idthuoc, 
						 @tenthuoc, 
						 @chidinh,
						 @ngayhethan, 
						 @giatien,
						 @soluong
GO

SELECT * 
FROM V_XEM_THEM_SUA_XOA_TTTHUOC
WHERE TENTHUOC = N'Lisinopril'