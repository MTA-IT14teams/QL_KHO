select pn.maPN, ngayNhap, tongTien, maCTN,maHH, soLuong, donGia
from PhieuNhap pn, Chitietnhap ct
where pn.maPN=ct.maPN
go


alter proc ThemNH(@MaPN char(10), @NgayNhap date, @Tongtien int, @MaHH char(10), @SLuong int, @DonGia int)
as
begin
insert into PhieuNhap(maPN, ngayNhap, tongTien)
values (@MaPN, @NgayNhap, @Tongtien)
select @MaPN from PhieuNhap
where @MaPN=maPN
insert into Chitietnhap( maPN, maHH, soLuong, donGia)
values (@MaPN, @MaHH, @SLuong, @DonGia) 
end
go

alter proc SuaNH(@MaPN char(10), @NgayNhap date, @Tongtien int, @MaHH char(10), @SLuong int, @DonGia int)
as
begin
update PhieuNhap
set ngayNhap=@NgayNhap, tongTien=@Tongtien
where maPN=@MaPN
update Chitietnhap
set  maHH=@MaHH, soLuong=@SLuong, donGia=@DonGia
where maPN=@MaPN
end
go


create proc XoaNH(@MaPN nchar(10))
as
begin
delete Chitietnhap
where maPN=@MaPN
delete PhieuNhap
where maPN=@MaPN
end

go

alter proc XemNH
as
begin
select pn.maPN, ngayNhap, tongTien, maHH, soLuong, donGia
from PhieuNhap pn, Chitietnhap ct
where pn.maPN=ct.maPN 
end
go



alter proc XemNH1(@MaPN nchar(10))
as
begin
select pn.maPN, ngayNhap, tongTien, maHH, soLuong, donGia
from PhieuNhap pn, Chitietnhap ct
where pn.maPN=ct.maPN and @MaPN=pn.maPN
end
go

XemNH '001'
go


select px.maPX, ngayXuat, tongTien,maHH, soLuong, donGia
from PhieuXuat px, Chitietxuat ct
where px.maPX=ct.maPX
go

alter proc ThemXH(@MaPX char(10), @NgayXuat date, @Tongtien int, @MaHH char(10), @SLuong int, @DonGia int)
as
begin
insert into PhieuXuat(maPX, ngayXuat, tongTien)
values (@MaPX, @NgayXuat, @Tongtien)
select @MaPX from PhieuXuat
where @MaPX=maPX
insert into Chitietxuat( maPX, maHH, soLuong, donGia)
values (@MaPX, @MaHH, @SLuong, @DonGia) 
end
go


alter proc SuaXH(@MaPX char(10), @NgayXuat date, @Tongtien int,  @MaHH char(10), @SLuong int, @DonGia int)
as
begin
update PhieuXuat
set ngayXuat=@NgayXuat, tongTien=@Tongtien
where maPX=@MaPX
update Chitietxuat
set  maHH=@MaHH, soLuong=@SLuong, donGia=@DonGia
where maPX=@MaPX
end
go


create proc XoaXH(@MaPX nchar(10))
as
begin
delete Chitietxuat
where maPX=@MaPX
delete PhieuXuat
where maPX=@MaPX
end

go


alter proc XemXH 
as
begin
select px.maPX, ngayXuat, tongTien,maHH, soLuong, donGia
from PhieuXuat px, Chitietxuat ct
where px.maPX=ct.maPX
end
go

alter proc XemXH1(@MaPX nchar(10))
as
begin
select px.maPX, ngayXuat, tongTien,maHH, soLuong, donGia
from PhieuXuat px, Chitietxuat ct
where px.maPX=ct.maPX and @MaPX=px.maPX
end
go