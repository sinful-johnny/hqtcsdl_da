﻿USE QL_NHAKHOA
GO

--Trans 1
--=========================XEM THÔNG TIN 1 LOẠI THUỐC SỬ DỤNG=======================================
CREATE OR ALTER PROC sp_XEM_1TT_THUOC
	@idthuoc VARCHAR(255)
AS SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	begin tran
		SELECT TTTHUOC.*, SL.SOLUONG AS N'Số lượng thuốc tồn kho'
		FROM V_XEM_THEM_SUA_XOA_TTTHUOC TTTHUOC LEFT JOIN V_XEM_THEM_SUA_XOA_SOLUONGTONKHO SL
		ON SL.ID_THUOC = TTTHUOC.ID_THUOC
		WHERE TTTHUOC.ID_THUOC = @idthuoc

		waitfor delay '00:00:10'

		SELECT TTTHUOC.*, SL.SOLUONG AS N'Số lượng thuốc tồn kho'
		FROM V_XEM_THEM_SUA_XOA_TTTHUOC TTTHUOC LEFT JOIN V_XEM_THEM_SUA_XOA_SOLUONGTONKHO SL
		ON SL.ID_THUOC = TTTHUOC.ID_THUOC
		WHERE TTTHUOC.ID_THUOC = @idthuoc
	commit tran
GO


--Trans 2
--=========================CẬP NHẬT THÔNG TIN THUỐC=======================================

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
		GIATIEN = @giatien,
		ID_QTV = @id_qtv
	WHERE ID_THUOC = @ID_THUOC

	--waitfor delay '00:00:10'

	UPDATE V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
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