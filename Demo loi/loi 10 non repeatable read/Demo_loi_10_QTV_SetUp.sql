USE QL_NHAKHOA
GO

--Trans 1
--=========================XEM THÔNG TIN 1 TÀI KHOẢN NGƯỜI DÙNG=======================================
CREATE OR ALTER PROC sp_XEM_1TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255)
AS
	begin tran
		SELECT *
		FROM V_XEM_TTTK
		WHERE ID_TAIKHOAN = @idtaikhoan

		waitfor delay '00:00:10'

		SELECT *
		FROM V_XEM_TTTK
		WHERE ID_TAIKHOAN = @idtaikhoan
	commit tran
GO


--Trans 2
--=========================CẬP NHẬT THÔNG TÀi KHOẢN=======================================

CREATE OR ALTER PROC sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL
AS

BEGIN TRAN
	DECLARE @OLDloaitaikhoan varchar(20)
	SET @OLDloaitaikhoan = (SELECT LOAITK FROM V_THEM_XOA_SUA_TK WHERE ID_TAIKHOAN = @idtaikhoan)
	IF (@OLDloaitaikhoan = '')
		BEGIN
			RAISERROR (N'Không tồn tại id tài khoản. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END

	IF (LEN(ISNULL(@tentaikhoan, '')) = 0)
		BEGIN
			SET @tentaikhoan = (SELECT HOTEN FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@ngaysinh, '')) = 0)
		BEGIN
			SET @ngaysinh = (SELECT NGAYSINH FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@email, '')) = 0)
		BEGIN
			SET @email = (SELECT EMAIL FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@loaitaikhoan, '')) = 0)
		BEGIN
			SET @loaitaikhoan = (SELECT LOAITK FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END
	ELSE IF (@loaitaikhoan = 'QTV')
		BEGIN
			RAISERROR (N'Không thể phân thành quản trị viên. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END


	UPDATE V_THEM_XOA_SUA_TK
	SET HOTEN = @tentaikhoan,
		NGAYSINH = @ngaysinh,
		EMAIL = @email,
		LOAITK = @loaitaikhoan,
		ID_QTV = CURRENT_USER
	WHERE ID_TAIKHOAN = @idtaikhoan
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN

--XÓA ROLE CŨ CỦA TÀI KHOẢN
IF (@OLDloaitaikhoan = 'KH')
	BEGIN
		EXEC sp_droprolemember 'KHACHHANG', @idtaikhoan
	END
ELSE IF (@OLDloaitaikhoan = 'NV')
	BEGIN
		EXEC sp_droprolemember 'NHAN_VIEN', @idtaikhoan
	END
ELSE 
	BEGIN
		EXEC sp_droprolemember 'NHA_SI', @idtaikhoan
	END

--CẬP NHẬT ROLE MỚI CHO TÀI KHOẢN
IF (@loaitaikhoan = 'KH')
	BEGIN
		EXEC sp_addrolemember 'KHACHHANG', @idtaikhoan
	END
ELSE IF (@loaitaikhoan = 'NV')
	BEGIN
		EXEC sp_addrolemember 'NHAN_VIEN', @idtaikhoan
	END
ELSE 
	BEGIN
		EXEC sp_addrolemember 'NHA_SI', @idtaikhoan
	END

GO