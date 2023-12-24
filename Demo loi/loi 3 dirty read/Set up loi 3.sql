use QL_NHAKHOA
create or  alter trigger TR_6 on THUOC for insert,update
as
	if exists	(
					select *
					from inserted as I
					where datediff(day,I.NGAYHETHAN,getdate()) >= 0
				)
	begin
		waitfor delay '00:00:10'
		;throw 50006, N'Không thể thêm thuốc đã hết hạn',1
		rollback tran
	end
go