﻿USE QL_NHAKHOA
GO

--sp_Xem thông tin thuốc Quản trị viên
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
exec sp_XEM_NHIEU_THUOC

waitfor delay '00:00:10'

exec sp_XEM_NHIEU_THUOC

GO