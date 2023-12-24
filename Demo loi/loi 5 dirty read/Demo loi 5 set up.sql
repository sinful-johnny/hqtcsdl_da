use QL_NHAKHOA
go

create or alter trigger TR_8 on TAI_KHOAN for insert,update
as
	if exists	(
					select *
					from inserted
					where datediff(day,NGAYSINH,getdate()) < 0
				)
	begin
		waitfor delay '00:00:10'
		;throw 50008, N'Ngày sinh không hợp lệ', 1
		rollback tran
	end
go