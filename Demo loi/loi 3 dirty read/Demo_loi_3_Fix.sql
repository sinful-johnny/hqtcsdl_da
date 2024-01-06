use QL_NHAKHOA
GO
create or  alter trigger TR_6 on THUOC for insert,update
as
	if exists	(
					select *
					from inserted as I
					where datediff(day,I.NGAYHETHAN,getdate()) >= 0
				)
	begin
		waitfor delay '00:00:10'
		;throw 50006, N'Không thể thêm thuốc đã hết hạn',1
		rollback tran
	end
go

CREATE OR ALTER PROC sp_CAPNHAT_TT_THUOC
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

	UPDATE V_XEM_THEM_SUA_XOA_TTTHUOC
	SET TENTHUOC = @tenthuoc,
		CHIDINH = @chidinh,
		NGAYHETHAN = @ngayhethan,
		GIATIEN = @giatien
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

CREATE OR ALTER PROC SP_NV_XEMTTTHUOC
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN
	SELECT * 
	FROM V_DANHMUC_THUOC 
END
GO