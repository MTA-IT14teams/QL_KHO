alter proc xuat_hh_tk
as begin
select maHH as[Mã Hàng Hóa],tenHH as [Tên Hàng Hóa],tenNCC as[Tên NCC],soluong as[ Số Lượng] from HangHoa,NCC
where HangHoa.maNCC=NCC.maNCC
end
xuat_hh_tk