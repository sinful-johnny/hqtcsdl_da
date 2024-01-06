USE QL_NHAKHOA
GO
 --Xem thuoc truoc khi cap nhat == 
SELECT *
FROM V_XEM_THEM_SUA_XOA_TTTHUOC
WHERE TENTHUOC = N'Lisinopril'
go

--sp_cập nhật thông tin thuốc Quản trị viên

declare @idthuoc VARCHAR(255),
		@tenthuoc NVARCHAR(30) = NULL,
		@chidinh NVARCHAR(100) = NULL,
		@ngayhethan DATE,
		@giatien money = NULL,
		@soluong int

set @idthuoc = (select top 1 ID_THUOC from THUOC where TENTHUOC = N'Lisinopril')
set @soluong = 120
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

WAITFOR DELAY '00:00:20'

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
exec sp_CAPNHAT_TT_THUOC @idthuoc, 
						 @tenthuoc, 
						 @chidinh,
						 @ngayhethan, 
						 @giatien,
						 @soluong
GO

SELECT * 
FROM V_XEM_THEM_SUA_XOA_TTTHUOC
WHERE TENTHUOC = N'Lisinopril'