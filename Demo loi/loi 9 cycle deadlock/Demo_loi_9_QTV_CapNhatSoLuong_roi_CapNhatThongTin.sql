use QL_NHAKHOA
go

SELECT *
FROM V_XEM_THEM_SUA_XOA_TTTHUOC

SELECT *
FROM V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
GO

-- Sửa thông tin của số lường rồi thông tin thuốc --
DECLARE	@ID_THUOC varchar(255),
	@tenthuoc NVARCHAR(30),
	@chidinh NVARCHAR(100),
	@ngayhethan DATE,
	@giatien MONEY,
	@soluong int,
	@id_qtv varchar(255)
SET @ID_THUOC = '34C0D33E-1BD4-4183-844E-46EF64DDEAC1'
SET	@tenthuoc = 'zxc'
SET	@chidinh = 'zxcv'
SET	@giatien = 4000
SET @soluong = 200

EXEC sp_CAPNHAT_TT_THUOC_SOLUONG_THONGTIN @ID_THUOC, @tenthuoc, @chidinh, @ngayhethan, @giatien, @soluong
GO

SELECT *
FROM V_XEM_THEM_SUA_XOA_TTTHUOC

SELECT *
FROM V_XEM_THEM_SUA_XOA_SOLUONGTONKHO
GO