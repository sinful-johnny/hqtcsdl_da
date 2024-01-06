use QL_NHAKHOA
go

alter trigger TR_6 on THUOC for insert,update
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

CREATE OR ALTER PROC SP_NV_XEMTTTHUOC
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN
	SELECT * 
	FROM V_DANHMUC_THUOC 
END
GO

CREATE OR ALTER PROC sp_THEM_TT_THUOC
	@tenthuoc NVARCHAR(30),
	@chidinh NVARCHAR(100),
	@ngayhethan DATE,
	@giatien MONEY,
	@soluong int
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
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
											GIATIEN)

	VALUES									(@ID_THUOC,
											@tenthuoc,
											@chidinh,
											@ngayhethan,
											@giatien)

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