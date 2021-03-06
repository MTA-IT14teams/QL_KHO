﻿-- thủ tục xem nhà cung cấp
alter proc dbo.Xem_NCC
as
begin
select * from NCC
end
go
-- thủ tục xem hàng hóa
alter proc dbo.Xem_HH
as
begin
select * from HangHoa
end
go
-- thủ tục thêm hàng hóa
alter proc dbo.them_HH
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
alter proc dbo.Xoa_NhaCungCap (@maNCC char(10))
as
begin
delete HangHoa
where maNCC = @maNCC
delete NCC
where maNCC = @maNCC
end
go

-- thủ tục xóa hàng hóa
alter proc dbo.Xoa_HangHoa(@maHH char(10))
as
begin
delete Chitietnhap
where maHH = @maHH
delete Chitietxuat
where maHH = @maHH
delete HangHoa
where maHH = @maHH
end
go