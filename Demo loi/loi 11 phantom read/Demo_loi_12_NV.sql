use QL_NHAKHOA
go

declare @ID_NV VARCHAR(255) = NULL,
	@ID_BA VARCHAR(255)

select @ID_BA = BA.ID_BA
from BENH_AN as BA
		inner join TAI_KHOAN as TK on BA.ID_KH = TK.ID_TAIKHOAN
where	TK.SDT = '0888123456'

select TSD.*
from THUOC_SD as TSD
		inner join BENH_AN as BA on BA.ID_BA = TSD.ID_BA
where BA.ID_BA = @ID_BA

exec SP_NV_LAPHOADON @ID_NV, @ID_BA
go