-- thủ tục xem nhà cung cấp
create proc dbo.Xem_NCC
as
begin
select * from NCC
end

-- thủ tục xem hàng hóa
create proc dbo.Xem_HH
as
begin
select * from HangHoa
end

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