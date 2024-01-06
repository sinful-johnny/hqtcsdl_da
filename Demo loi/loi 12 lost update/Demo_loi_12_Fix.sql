--Fix lỗi chức năng 1
alter proc sp_KH_SuaTTCaNhan
	@hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)
as
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	begin transaction
		if	@hoten is null
		begin
			select @hoten = HOTEN
			from V_KH_TTCANHAN WITH (UPDLOCK)
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@ngaysinh is null
		begin
			select @ngaysinh = NGAYSINH
			from V_KH_TTCANHAN WITH (UPDLOCK)
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@email is null
		begin
			select @email = EMAIL
			from V_KH_TTCANHAN WITH (UPDLOCK)
			where ID_TAIKHOAN = CURRENT_USER
		end

		update V_KH_TTCANHAN with (XLOCK)
		set HOTEN = @hoten, NGAYSINH = @ngaysinh, EMAIL = @email
		where ID_TAIKHOAN = CURRENT_USER

		SELECT CASE transaction_isolation_level 
    WHEN 0 THEN 'Unspecified' 
    WHEN 1 THEN 'ReadUncommitted' 
    WHEN 2 THEN 'ReadCommitted' 
    WHEN 3 THEN 'Repeatable' 
    WHEN 4 THEN 'Serializable' 
    WHEN 5 THEN 'Snapshot' END AS TRANSACTION_ISOLATION_LEVEL 
FROM sys.dm_exec_sessions 
where session_id = @@SPID
	commit transaction
go

--Fix lỗi chức năng 2
CREATE OR ALTER PROC sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN transaction
	
	DECLARE @OLDloaitaikhoan varchar(20)
	SET @OLDloaitaikhoan = (SELECT LOAITK FROM V_THEM_XOA_SUA_TK WITH (UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
	IF (@OLDloaitaikhoan = '')
		BEGIN
			RAISERROR (N'Không tồn tại id tài khoản. Vui lòng thử lại', 0, 0)
			ROLLBACK transaction
			RETURN
		END

	IF (LEN(ISNULL(@tentaikhoan, '')) = 0)
		BEGIN
			SET @tentaikhoan = (SELECT HOTEN FROM TAI_KHOAN WITH (UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@ngaysinh, '')) = 0)
		BEGIN
			SET @ngaysinh = (SELECT NGAYSINH FROM TAI_KHOAN WITH (UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@email, '')) = 0)
		BEGIN
			SET @email = (SELECT EMAIL FROM TAI_KHOAN WITH (UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END


	IF (LEN(ISNULL(@loaitaikhoan, '')) = 0)
		BEGIN
			SET @loaitaikhoan = (SELECT LOAITK FROM TAI_KHOAN WITH (UPDLOCK) WHERE ID_TAIKHOAN = @idtaikhoan)
		END
	ELSE IF (@loaitaikhoan = 'QTV')
		BEGIN
			RAISERROR (N'Không thể phân thành quản trị viên. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END

	WAITFOR DELAY '00:00:10'
	UPDATE V_THEM_XOA_SUA_TK with (XLOCK)
	SET HOTEN = @tentaikhoan,
		NGAYSINH = @ngaysinh,
		EMAIL = @email,
		LOAITK = @loaitaikhoan
	WHERE ID_TAIKHOAN = @idtaikhoan
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể cập nhật. Vui lòng thử lại', 0, 0)
			ROLLBACK transaction
			RETURN
		END

		SELECT CASE transaction_isolation_level 
    WHEN 0 THEN 'Unspecified' 
    WHEN 1 THEN 'ReadUncommitted' 
    WHEN 2 THEN 'ReadCommitted' 
    WHEN 3 THEN 'Repeatable' 
    WHEN 4 THEN 'Serializable' 
    WHEN 5 THEN 'Snapshot' END AS TRANSACTION_ISOLATION_LEVEL 
FROM sys.dm_exec_sessions 
where session_id = @@SPID

COMMIT transaction
GO