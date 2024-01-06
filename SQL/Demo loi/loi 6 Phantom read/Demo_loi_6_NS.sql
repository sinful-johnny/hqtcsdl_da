use QL_NHAKHOA
go

declare @ID_BA VARCHAR(255),
	@ID_THUOC VARCHAR(255),
	@SOLUONG INT = 1

select @ID_BA = BA.ID_BA
from BENH_AN as BA
		inner join TAI_KHOAN as TK on BA.ID_KH = TK.ID_TAIKHOAN
where	TK.SDT = '0888123456'

select @ID_THUOC = ID_THUOC
from THUOC
where TENTHUOC = 'Diazepam'

exec SP_NS_THEM_THUOC_SD @ID_BA, @ID_THUOC, @SOLUONG
go