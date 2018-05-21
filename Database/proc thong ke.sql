
update HangHoa
set soluong= slhh
from (select HH.MaHH, (CTN.soLuong-CTX.soLuong) as slhh from HangHoa HH, Chitietnhap CTN, Chitietxuat CTX where HH.maHH=CTN.maHH and HH.maHH=CTX.maHH group by HH.maHH, CTN.soLuong, CTX.soLuong)
as A
where HangHoa.maHH=A.maHH


go

alter proc tk_xuat
as
 begin
 select HH.maHH as N'Mã HH', tenHH as N'Tên HH', tenNCC as N'Tên NCC',sum(CTX.soluong) as 'SL Xuất', donGia as N'Đơn giá', sum(CTX.donGia*CTX.soLuong) as N'Tiền Xuất'
 from HangHoa HH, NCC,  Chitietxuat  CTX
 where HH.maNCC=NCC.maNCC and HH.maHH=CTX.maHH
 group by HH.maHH, tenHH, tenNCC, donGia
 end


 go
alter proc tk_nhap
 as
 begin
 select HH.maHH as N'Mã HH', tenHH as N'Tên HH', tenNCC as N'Tên NCC',sum(CTN.soluong) as 'SL Nhập', donGia as N'Đơn giá', sum(CTN.donGia*CTN.soLuong) as N'Tiền Nhập'
 from HangHoa HH, NCC,  Chitietnhap  CTN
 where HH.maNCC=NCC.maNCC and HH.maHH=CTN.maHH
 group by HH.maHH, tenHH, tenNCC, donGia 
 end


 go
alter proc tk_hh
 as
 begin
 select  maHH as N'Mã Hàng hóa', tenHH as N'Tên Hàng hóa', tenNCC as N'Nhà cung cấp' , soluong as 'Số lượng'
 from HangHoa HH, NCC
 where HH.maNCC=NCC.maNCC
 end

 