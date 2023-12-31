﻿USE QL_NHAKHOA
GO

--sp_thêm thông tin thuốc

declare	@tenthuoc NVARCHAR(30),
		@chidinh NVARCHAR(100),
		@ngayhethan DATE,
		@giatien MONEY,
		@soluong int
set @tenthuoc = N'thuốc đau dạ dày'
set @chidinh = N'Uống trước khi hết hạn'
set	@ngayhethan = '2/2/2020' --Quá hạn sd hôm nay để trigger
set @giatien = '1000'
set @soluong = 10

EXEC sp_THEM_TT_THUOC	@tenthuoc,
						@chidinh,
						@ngayhethan,
						@giatien,
						@soluong
go
