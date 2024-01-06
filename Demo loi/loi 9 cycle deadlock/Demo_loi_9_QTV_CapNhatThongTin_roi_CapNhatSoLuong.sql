use QL_NHAKHOA
go

SELECT *
FROM V_XEM_THEM_SUA_XOA_TTTHUOC

SELECT *
FROM V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
GO

-- Sửa thông tin thuốc rồi số lượng thuốc --
DECLARE	@ID_THUOC varchar(255),
	@tenthuoc NVARCHAR(30),
	@chidinh NVARCHAR(100),
	@ngayhethan DATE,
	@giatien MONEY,
	@soluong int,
	@id_qtv varchar(255)
SET @ID_THUOC = '34C0D33E-1BD4-4183-844E-46EF64DDEAC1'
SET	@tenthuoc = 'abc'
SET	@chidinh = 'abcd'
SET	@giatien = 2000
SET @soluong = 100

EXEC sp_CAPNHAT_TT_THUOC_THONGTIN_SOLUONG @ID_THUOC, @tenthuoc, @chidinh, @ngayhethan, @giatien, @soluong
GO

SELECT *
FROM V_XEM_THEM_SUA_XOA_TTTHUOC

SELECT *
FROM V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
GO