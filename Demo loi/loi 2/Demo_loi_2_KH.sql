﻿USE QL_NHAKHOA
GO

--sp_xem thông tin danh sách thuốc KHÁCH HÀNG

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
exec sp_KH_XemDSThuoc
go