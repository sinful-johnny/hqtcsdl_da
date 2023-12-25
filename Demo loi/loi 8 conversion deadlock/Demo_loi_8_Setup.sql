use QL_NHAKHOA
go
drop proc SP_NS_SUA_TTCANHAN
go
CREATE PROC SP_NS_SUA_TTCANHAN
	@tentaikhoan NVARCHAR(30),
	@ngaysinh DATE,
	@email VARCHAR(30)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	DECLARE @idtaikhoan VARCHAR(255)
	SET @idtaikhoan = CURRENT_USER

	IF (LEN(ISNULL(@tentaikhoan, '')) = 0)
		BEGIN
			SET @tentaikhoan = (SELECT HOTEN FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END

	IF (LEN(ISNULL(@ngaysinh, NULL)) = 0)
		BEGIN
			SET @ngaysinh = (SELECT NGAYSINH FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END

	IF (LEN(ISNULL(@email, '')) = 0)
		BEGIN
			SET @email = (SELECT EMAIL FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan)
		END
	


	UPDATE V_TKNHASI
	SET HOTEN = @tentaikhoan,
		NGAYSINH = @ngaysinh,
		EMAIL = @email
	WHERE ID_TAIKHOAN = @idtaikhoan
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN
GO
GRANT EXECUTE ON OBJECT::SP_NS_SUA_TTCANHAN
    TO NHA_SI;  
GO

drop proc sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
go
CREATE PROC sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL
AS
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
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

	WAITFOR DELAY '00:00:10'

	UPDATE V_THEM_XOA_SUA_TK
	SET HOTEN = @tentaikhoan,
		NGAYSINH = @ngaysinh,
		EMAIL = @email,
		LOAITK = @loaitaikhoan
	WHERE ID_TAIKHOAN = @idtaikhoan
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN
go