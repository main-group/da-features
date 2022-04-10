create database DB_DA_FEATURES
go
use DB_DA_FEATURES

create table Sach
(
	MaSach int identity(1, 1),
	TenSach nvarchar(50),
	constraint PK_Sach primary key (MaSach)
)

create table KeSach
(
	MaKeSach int identity(1, 1),
	TenKeSach nvarchar(50),
	constraint PK_KeSach primary key (MaKeSach)
)

create table ViTriSach
(
	MaSach int,
	MaKeSach int,
	ViTri int,
	constraint PK_ViTriSach primary key (MaSach, MaKeSach, ViTri)
)

alter table ViTriSach add
constraint FK_ViTriSach_Sach foreign key (MaSach) references Sach (MaSach),
constraint FK_KeSach_Sach foreign key (MaKeSach) references KeSach (MaKeSach)

insert into Sach values
(N'Hoa và Lá'), (N'Mưa xuân'), (N'Ước nguyện'), (N'Lời hứa năm ấy'), (N'Chuyến đi thành phô'),
(N'Con ngõ nhỏ'), (N'Chuyện thời sinh viên'), (N'C# Winform'), (N'Java OOP'), (N'Toán cao cấp A1'),
(N'Toán cao cấp A2'), (N'Pháp luật đại cương'), (N'Vùng trời bình yên'), (N'Hoa nở trong phô'), (N'Dưới những tán cây'),
(N'Nhập môn lập trình'), (N'C++ của kẻ lười'), (N'Cơ sở dữ liệu'), (N'Liệu anh có nhớ'), (N'Trường của tôi'), 
(N'Hoa hướng dương'), (N'Sinh học đại cương'), (N'Cuối con đường'), (N'Lẻ loi năm ấy'), (N'Đời của người lính'), 
(N'Đoạn trường bất tử'), (N'Tình của kẻ điên'), (N'Trong đêm mơ'), (N'Hóa đại cương'), (N'Kẻ khờ dại'), 
(N'Bóng trăng'), (N'Người hở lưng'), (N'Con đò'), (N'Người phố'), (N'Lặng thinh'), 
(N'Dần')

insert into KeSach values
(N'KS01'), (N'KS02'), (N'KS03'), (N'KS04'), (N'KS05')

select * from Sach
select * from KeSach