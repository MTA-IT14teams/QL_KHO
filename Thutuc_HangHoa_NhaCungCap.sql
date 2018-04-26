-- thủ tục xem nhà cung cấp
create proc dbo.Xem_NCC
as
begin
select * from NCC
end
go
-- thủ tục xem hàng hóa
create proc dbo.Xem_HH
as
begin
select * from HangHoa
end
go
-- thủ tục thêm hàng hóa
create proc dbo.them_HH
(
@MaHH char(10),
@TenHH nvarchar(50),
@MaNCC char(10),
@soluong int
)
as 
begin
insert into HangHoa
values(@MaHH,@TenHH,@MaNCC,@soluong)
end
go
-- thủ tục xem tên nhà cung cấp
alter proc dbo.Xem_TenNCC
as
begin
select maNCC,tenNCC
from NCC
end
go

select maHH, tenHH, NCC.maNCC, soluong from HangHoa, NCC
where HangHoa.maNCC = NCC.maNCC

 -- thủ tục xóa nhà cung cấp
create proc dbo.Xoa_NhaCungCap (@maNCC char(10))
as
begin
delete HangHoa
where maNCC = @maNCC
delete NCC
where maNCC = @maNCC
end
go