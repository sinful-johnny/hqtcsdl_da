USE QL_NHAKHOA
GO

--sp_cập nhật thông tin thuốc Quản trị viên

declare @idthuoc VARCHAR(255),
		@tenthuoc NVARCHAR(30) = NULL,
		@chidinh NVARCHAR(100) = NULL,
		@ngayhethan DATE,
		@giatien money = NULL,
		@soluong int = NULL

set @idthuoc = '93A8817E-1C85-426A-B5BB-01A619176468'
--set @tenthuoc = 'Gabapentin'
--set @chidinh = N'Đau thần kinh'
--set @ngayhethan = '2024-12-18'
--set @giatien = 12500.00
set @ngayhethan = '2029-12-18'
set @giatien = 16000.00
set @soluong = 150

exec sp_CAPNHAT_TT_THUOC @idthuoc, 
						 @tenthuoc, 
						 @chidinh,
						 @ngayhethan, 
						 @giatien,
						 @soluong
GO
