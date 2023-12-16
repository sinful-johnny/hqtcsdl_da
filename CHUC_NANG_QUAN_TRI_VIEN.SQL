USE QL_NHAKHOA
GO

-- CHỨC NĂNG CHO QUẢN TRỊ VIÊN
-- CHỨC NĂNG TẠO ID TÀI KHOẢN

CREATE OR ALTER PROC sp_TAOID
	@ID VARCHAR(255) OUTPUT
AS
BEGIN
	SET @ID =  CAST(NEWID() AS VARCHAR(255))
	RETURN
END
GO

--=========================THÊM TÀI KHOẢN=======================================

CREATE OR ALTER PROC sp_THEM_TAIKHOAN_NGUOIDUNG
	@tentaikhoan NVARCHAR(255),
	@sdt CHAR(11),
	@ngaysinh DATE,
	@email VARCHAR(30),
	@matKhau varchar(100),
	@loaitaikhoan varchar(20)
AS
BEGIN TRAN
	--TẠO ID TÀI KHOẢN MỚI
	DECLARE @ID_TK VARCHAR(255)
	EXEC sp_TAOID @ID_TK OUTPUT

	--GÁN ID QUẢN TRỊ VIÊN HIỆN TẠI THỰC HIỆN
	DECLARE @id_qtv VARCHAR(255)
	SET @id_qtv = CURRENT_USER
	print @id_qtv
	INSERT INTO V_THEM_XOA_SUA_TKNHASI_NHANVIEN(
												ID_TAIKHOAN,
												HOTEN,
												SDT,
												NGAYSINH,
												EMAIL,
												MATKHAU,
												LOAITK,
												ID_QTV)

VALUES											(@ID_TK,
												@tentaikhoan,
												@sdt,
												@ngaysinh,
												@email,
												@matkhau,
												@loaitaikhoan,
												@id_qtv)
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể thêm. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END

COMMIT TRAN
DECLARE @cmd varchar(200), @username varchar(50)
IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = @sdt)
	BEGIN
		exec sp_addlogin @sdt, @matkhau, 'QL_NHAKHOA'
	END
----------------------------------------------
set @cmd = ' 
   USE QL_NHAKHOA
   CREATE USER [' + @ID_TK + ']' + ' FOR LOGIN '+ '[' + @sdt +']'
PRINT @cmd
EXEC (@cmd)
IF (@loaitaikhoan = 'KH')
	BEGIN
		exec sp_addrolemember 'KHACHHANG', @ID_TK
	END
ELSE IF (@loaitaikhoan = 'NS')
	BEGIN
		exec sp_addrolemember 'NHA_SI', @ID_TK
	END
ELSE IF (@loaitaikhoan = 'NV')
	BEGIN
		exec sp_addrolemember 'NHAN_VIEN', @ID_TK
	END
GO

--=========================XÓA TÀI KHOẢN=======================================

CREATE OR ALTER PROC sp_XOA_TAIKHOAN
	@idtaikhoan VARCHAR(255)
AS
	IF EXISTS(SELECT* FROM V_THEM_XOA_SUA_TKNHASI_NHANVIEN WHERE ID_TAIKHOAN = @idtaikhoan)
		BEGIN
			-- Xóa login
			DECLARE @sdt CHAR(11)
			SET @sdt = (SELECT SDT FROM V_THEM_XOA_SUA_TKNHASI_NHANVIEN WHERE ID_TAIKHOAN = @idtaikhoan)
			exec sp_droplogin @sdt


			-- Xóa tài khoản
			EXEC sp_revokedbaccess @idtaikhoan

			if EXISTS(	SELECT*
						FROM TAI_KHOAN TK
						WHERE TK.ID_TAIKHOAN = @idtaikhoan
							AND TK.LOAITK = 'NS')
			BEGIN
				DELETE FROM V_THEM_XOA_SUA_LICHDATKHAM
				WHERE ID_LLV IN (SELECT LLV.ID_LLV FROM LICH_LAM_VIEC LLV WHERE LLV.ID_NS = @idtaikhoan)

				DELETE FROM V_THEM_XOA_SUA_LICHLAMVIEC
				WHERE ID_NS = @idtaikhoan
			END

			ELSE
			BEGIN
				UPDATE V_THEM_XOA_SUA_LICHDATKHAM
				SET ID_NV = NULL
				WHERE ID_NV = @idtaikhoan

				UPDATE V_THEM_XOA_SUA_LICHDATKHAM
				SET ID_NV = NULL
				WHERE ID_NV = @idtaikhoan
			END

			--Xóa data của tài khoản
			DELETE FROM V_THEM_XOA_SUA_TK
			WHERE ID_TAIKHOAN = @idtaikhoan
			
			RETURN

		END
	ELSE
		BEGIN
			RAISERROR (N'Không tòn tại tài khoản để xóa. Vui lòng nhập tài khoản khác', 0, 0)
			RETURN
		END
GO

--=========================CẬP NHẬT TÀI KHOẢN=======================================

CREATE OR ALTER PROC sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL
AS

BEGIN TRAN
	DECLARE @OLDloaitaikhoan varchar(20)
	SET @OLDloaitaikhoan = (SELECT LOAITK FROM V_THEM_XOA_SUA_TKNHASI_NHANVIEN WHERE ID_TAIKHOAN = @idtaikhoan)
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


	UPDATE V_THEM_XOA_SUA_TKNHASI_NHANVIEN
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

--=========================XEM THÔNG TIN 1 TÀI KHOẢN=======================================
CREATE OR ALTER PROC sp_XEM_1TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255)
AS
	SELECT *
	FROM V_XEM_TTTK
	WHERE ID_TAIKHOAN = @idtaikhoan
GO

--=========================XEM THÔNG TIN CÁC TÀI KHOẢN=======================================
CREATE OR ALTER PROC sp_XEM_NHIEU_TAIKHOAN
AS
	SELECT *
	FROM V_XEM_TTTK
GO

--=========================KHÓA TÀI KHOẢN=======================================
CREATE OR ALTER PROC sp_KHOA_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255)
AS
	exec sp_revokedbaccess @idtaikhoan
GO

--=========================MỞ KHÓA TÀI KHOẢN=======================================
CREATE OR ALTER PROC sp_MOKHOA_TAIKHOAN_NGUOIDUNG
	@idtaikhoan VARCHAR(255)
AS
	DECLARE @loaitaikhoan NVARCHAR(20)
	SET @loaitaikhoan = (SELECT LOAITK FROM V_THEM_XOA_SUA_TK WHERE ID_TAIKHOAN = @idtaikhoan)
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

--=========================XEM THÔNG TIN 1 LOẠI THUỐC=======================================
CREATE OR ALTER PROC sp_XEM_1TT_THUOC
	@idthuoc VARCHAR(255)
AS
	SELECT TTTHUOC.*, SL.SOLUONG AS N'Số lượng thuốc tồn kho'
	FROM V_XEM_THEM_SUA_XOA_TTTHUOC TTTHUOC, V_XEM_THEM_SUA_XOA_SOLUONGTONKHO SL
	WHERE TTTHUOC.ID_THUOC = @idthuoc
		AND SL.ID_THUOC = TTTHUOC.ID_THUOC
GO

--=========================XEM THÔNG TIN DANH SÁCH THUỐC=======================================
CREATE OR ALTER PROC sp_XEM_NHIEU_THUOC
AS
	SELECT TTTHUOC.*, SL.SOLUONG AS N'Số lượng thuốc tồn kho'
	FROM V_XEM_THEM_SUA_XOA_TTTHUOC TTTHUOC, V_XEM_THEM_SUA_XOA_SOLUONGTONKHO SL
GO

--=========================XEM THÔNG TIN 1 LOẠI THUỐC SỬ DỤNG=======================================
CREATE OR ALTER PROC sp_XEM_1TT_THUOC_SD
	@idthuoc VARCHAR(255)
AS
	SELECT *
	FROM V_XEM_THEM_SUA_XOA_THUOCSD
	WHERE ID_THUOC = @idthuoc
GO

--=========================XEM THÔNG TIN DANH SÁCH THUỐC SỬ DỤNG=======================================
CREATE OR ALTER PROC sp_XEM_NHIEU_THUOC_SD
AS
	SELECT *
	FROM V_XEM_THEM_SUA_XOA_THUOCSD
GO

--========================================================================================================


--=========================THÊM THÔNG TIN THUỐC=======================================
CREATE OR ALTER PROC sp_THEM_TT_THUOC
	@tenthuoc NVARCHAR(30),
	@chidinh NVARCHAR(100),
	@ngayhethan DATE,
	@giatien MONEY,
	@soluong int
AS
BEGIN TRAN
	--TẠO ID TÀI KHOẢN MỚI
	DECLARE @ID_THUOC VARCHAR(255)
	EXEC sp_TAOID @ID_THUOC OUTPUT

	--GÁN ID QUẢN TRỊ VIÊN HIỆN TẠI THỰC HIỆN

	DECLARE @id_qtv VARCHAR(255)
	SET @id_qtv = CURRENT_USER

	INSERT INTO V_XEM_THEM_SUA_XOA_TTTHUOC(
											ID_THUOC,
											TENTHUOC,
											CHIDINH,
											NGAYHETHAN,
											GIATIEN,
											ID_QTV)

	VALUES									(@ID_THUOC,
											@tenthuoc,
											@chidinh,
											@ngayhethan,
											@giatien,
											@id_qtv)

	INSERT INTO V_XEM_THEM_SUA_XOA_SOLUONGTONKHO(
													ID_THUOC,
													SOLUONG
												)
	VALUES										(
													@ID_THUOC,
													@soluong
												)
			
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể thêm. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
	
COMMIT TRAN
GO

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


--=========================XÓA THÔNG TIN THUỐC=======================================

CREATE OR ALTER PROC sp_XOA_TT_THUOC
	@ID_THUOC VARCHAR(255)
AS
BEGIN TRAN

	DECLARE @id_qtv VARCHAR(255)
	SET @id_qtv = CURRENT_USER

	DELETE FROM V_XEM_THEM_SUA_XOA_THUOCSD
	WHERE ID_THUOC = @ID_THUOC

	DELETE FROM V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
	WHERE ID_THUOC = @ID_THUOC

	DELETE FROM V_XEM_THEM_SUA_XOA_TTTHUOC
	WHERE ID_THUOC = @ID_THUOC
		
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR (N'Không thể xóa. Vui lòng thử lại', 0, 0)
			ROLLBACK TRAN
			RETURN
		END
	
COMMIT TRAN
GO


--=========================PHÂN QUYỀN PROC TÀI KHOẢN=======================================

GRANT EXECUTE ON OBJECT::sp_THEM_TAIKHOAN_NGUOIDUNG
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XOA_TAIKHOAN
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_CAPNHAT_TAIKHOAN_NGUOIDUNG
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XEM_1TAIKHOAN_NGUOIDUNG
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XEM_NHIEU_TAIKHOAN
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_KHOA_TAIKHOAN_NGUOIDUNG
    TO QUAN_TRI_VIEN;  
GO


--=========================PHÂN QUYỀN PROC THUỐC=======================================

GRANT EXECUTE ON OBJECT::sp_XEM_1TT_THUOC
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XEM_NHIEU_THUOC
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XEM_1TT_THUOC_SD
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XEM_NHIEU_THUOC_SD
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_THEM_TT_THUOC
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_CAPNHAT_TT_THUOC
    TO QUAN_TRI_VIEN;  
GO

GRANT EXECUTE ON OBJECT::sp_XOA_TT_THUOC
    TO QUAN_TRI_VIEN;  
GO
