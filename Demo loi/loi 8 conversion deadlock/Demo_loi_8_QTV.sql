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
	SET @OLDloaitaikhoan = (SELECT LOAITK FROM V_THEM_XOA_SUA_TK WITH (HOLDLOCK,UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
	IF (@OLDloaitaikhoan = '')
		BEGIN
			RAISERROR (N'Không tồn tại id tài khoản. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END

	IF (LEN(ISNULL(@tentaikhoan, '')) = 0)
		BEGIN
			SET @tentaikhoan = (SELECT HOTEN FROM TAI_KHOAN WITH (HOLDLOCK,UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@ngaysinh, '')) = 0)
		BEGIN
			SET @ngaysinh = (SELECT NGAYSINH FROM TAI_KHOAN WITH (HOLDLOCK,UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@email, '')) = 0)
		BEGIN
			SET @email = (SELECT EMAIL FROM TAI_KHOAN WITH (HOLDLOCK,UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@loaitaikhoan, '')) = 0)
		BEGIN
			SET @loaitaikhoan = (SELECT LOAITK FROM TAI_KHOAN WITH (HOLDLOCK,UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END
	ELSE IF (@loaitaikhoan = 'QTV')
		BEGIN
			RAISERROR (N'Không thể phân thành quản trị viên. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END


	UPDATE V_THEM_XOA_SUA_TK WITH (HOLDLOCK,UPDLOCK)
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

declare @idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL

select top 1 @idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '09123456789'

set @tentaikhoan = 'test NS updated by QTV'


exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan,@tentaikhoan,@ngaysinh,@email,@loaitaikhoan
select * from TAI_KHOAN where SDT ='09123456789' 
--exec sp_THEM_TAIKHOAN_NGUOIDUNG 'test NS', '03626', '2003-1-1','test@gmail.com','123','NS'