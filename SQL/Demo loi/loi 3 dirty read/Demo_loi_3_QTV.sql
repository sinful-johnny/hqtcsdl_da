USE QL_NHAKHOA
GO

--sp_cập nhật thông tin thuốc Quản trị viên

declare @idthuoc VARCHAR(255),
		@tenthuoc NVARCHAR(30) = NULL,
		@chidinh NVARCHAR(100) = NULL,
		@ngayhethan DATE,
		@giatien money = NULL,
		@soluong int

set @idthuoc = (select top 1 ID_THUOC
				from THUOC)
set @tenthuoc = N'thuôc đau dạ dày'
set @ngayhethan = '2/2/2003'
set @soluong = 10

exec sp_CAPNHAT_TT_THUOC @idthuoc, 
						 @tenthuoc, 
						 @chidinh,
						 @ngayhethan, 
						 @giatien,
						 @soluong
GO
