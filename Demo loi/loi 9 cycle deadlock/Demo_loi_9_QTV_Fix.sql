﻿use QL_NHAKHOA
go
--drop proc sp_CAPNHAT_TT_THUOC
drop proc sp_CAPNHAT_TT_THUOC_THONGTIN_SOLUONG
drop proc sp_CAPNHAT_TT_THUOC_SOLUONG_THONGTIN
go
CREATE OR ALTER PROC sp_CAPNHAT_TT_THUOC_THONGTIN_SOLUONG
	@ID_THUOC VARCHAR(255),
	@tenthuoc NVARCHAR(30) = NULL,
	@chidinh NVARCHAR(100) = NULL,
	@ngayhethan DATE = NULL,
	@giatien MONEY = NULL,
	@soluong int = NULL
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
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


	UPDATE V_XEM_THEM_SUA_XOA_TTTHUOC WITH (XLOCK)
	SET TENTHUOC = @tenthuoc,
		CHIDINH = @chidinh,
		NGAYHETHAN = @ngayhethan,
		GIATIEN = @giatien,
		ID_QTV = @id_qtv
	WHERE ID_THUOC = @ID_THUOC

	waitfor delay '00:00:10'

	UPDATE V_XEM_THEM_SUA_XOA_SOLUONGTONKHO WITH (XLOCK)
	SET SOLUONG = @soluong
	WHERE ID_THUOC = @ID_THUOC
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
	
COMMIT TRAN
GO

GRANT EXECUTE ON OBJECT::sp_CAPNHAT_TT_THUOC_THONGTIN_SOLUONG
    TO QUAN_TRI_VIEN;  
GO

CREATE OR ALTER PROC sp_CAPNHAT_TT_THUOC_SOLUONG_THONGTIN
	@ID_THUOC VARCHAR(255),
	@tenthuoc NVARCHAR(30) = NULL,
	@chidinh NVARCHAR(100) = NULL,
	@ngayhethan DATE = NULL,
	@giatien MONEY = NULL,
	@soluong int = NULL
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
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

	UPDATE V_XEM_THEM_SUA_XOA_SOLUONGTONKHO WITH (XLOCK)
	SET SOLUONG = @soluong
	WHERE ID_THUOC = @ID_THUOC
	
	waitfor delay '00:00:10'

	UPDATE V_XEM_THEM_SUA_XOA_TTTHUOC WITH (XLOCK)
	SET TENTHUOC = @tenthuoc,
		CHIDINH = @chidinh,
		NGAYHETHAN = @ngayhethan,
		GIATIEN = @giatien,
		ID_QTV = @id_qtv
	WHERE ID_THUOC = @ID_THUOC
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
	
COMMIT TRAN
GO

GRANT EXECUTE ON OBJECT::sp_CAPNHAT_TT_THUOC_SOLUONG_THONGTIN
    TO QUAN_TRI_VIEN;  
GO
