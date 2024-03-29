USE [QLHSSV]
GO
/****** Object:  Table [dbo].[LOAIHINHDT]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHINHDT](
	[MaDT] [nchar](20) NOT NULL,
	[LoaiHinhDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHINHDT] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT1                 ', N'Cao đẳng')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT2                 ', N'Đại học ')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT3                 ', N'Liên thông')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT4                 ', N'Cao học')
/****** Object:  Table [dbo].[KTX]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KTX](
	[MaKTX] [nchar](20) NOT NULL,
	[TenKTX] [nchar](20) NULL,
 CONSTRAINT [PK_KTX] PRIMARY KEY CLUSTERED 
(
	[MaKTX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTA                 ', N'Kí túc xá A         ')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTB                 ', N'kí túc xá B         ')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTC                 ', N'Kí túc xá C         ')
/****** Object:  Table [dbo].[KHOAVIEN]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOAVIEN](
	[MKV] [nchar](20) NOT NULL,
	[TenKhoaVien] [nvarchar](250) NULL,
 CONSTRAINT [PK_KHOAVIEN] PRIMARY KEY CLUSTERED 
(
	[MKV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'GD                  ', N'Khoa giáo dục thể chất')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'KTCN                ', N'Viện Kĩ thuật công nghệ')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'LUAT                ', N'Khoa Luật')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'SPTN                ', N'Viện sư phạm tự nhiên')
/****** Object:  Table [dbo].[NGOAITRU]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGOAITRU](
	[MaNGT] [nchar](20) NOT NULL,
	[TenChuHo] [nvarchar](50) NULL,
	[SoDT] [nchar](20) NULL,
	[DiaChi] [nvarchar](500) NULL,
 CONSTRAINT [PK_NGOAITRU_1] PRIMARY KEY CLUSTERED 
(
	[MaNGT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'NGT1                ', N'Nguyễn Văn Sơn', N'0335845457          ', N'Số 6 - Ngõ 1 - Nguyễn Kiệm -TP.Vinh')
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'NGT2                ', N'Phan Nhật Long', N'0987458485          ', N'Số 3A - Ngõ 5 - Võ Thị Sáu - TP.Vinh')
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'null                ', NULL, NULL, NULL)
/****** Object:  Table [dbo].[USER]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nchar](50) NULL,
	[MatKhau] [nchar](20) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[USER] ON
INSERT [dbo].[USER] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (1, N'ADMIN                                             ', N'123                 ', 1)
INSERT [dbo].[USER] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (2, N' USERS1                                           ', N'1                   ', 0)
INSERT [dbo].[USER] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (3, N' USERS2                                           ', N'2                   ', 0)
INSERT [dbo].[USER] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (4, N' USERS3                                           ', N'3                   ', 0)
INSERT [dbo].[USER] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (5, N' USERS4                                           ', N'111                 ', 0)
SET IDENTITY_INSERT [dbo].[USER] OFF
/****** Object:  Table [dbo].[NOITRU]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOITRU](
	[TenPhong] [nchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[Status] [bit] NULL,
	[MaKTX] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NOITRU_1] PRIMARY KEY CLUSTERED 
(
	[TenPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'A202                ', 5, 0, N'KTA                 ')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'B304                ', 6, 1, N'KTB                 ')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'C101                ', 6, 1, N'KTC                 ')
/****** Object:  Table [dbo].[NGANH]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGANH](
	[MaNganh] [nchar](20) NOT NULL,
	[TenNganh] [nvarchar](250) NULL,
	[MKV] [nchar](20) NULL,
 CONSTRAINT [PK_NGANH] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N1                  ', N'CNTT', N'KTCN                ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N2                  ', N'GDMN', N'GD                  ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N3                  ', N'LUAT', N'LUAT                ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N4                  ', N'SPTOAN', N'SPTN                ')
/****** Object:  Table [dbo].[LOP]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [nchar](20) NOT NULL,
	[MaNganh] [nchar](20) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57A2                ', N'N3                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57B4                ', N'N3                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57K3                ', N'N1                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57M1                ', N'N2                  ')
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MSV] [nchar](20) NOT NULL,
	[HoTenSV] [nvarchar](50) NULL,
	[NgaySinh] [nchar](10) NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[CMND] [nchar](20) NULL,
	[SDT] [nchar](20) NULL,
	[DanToc] [nvarchar](50) NULL,
	[NoiSinh] [nvarchar](250) NULL,
	[QueQuan] [nvarchar](250) NULL,
	[MaLop] [nchar](20) NULL,
	[TenPhong] [nchar](20) NULL,
	[MaNGT] [nchar](20) NULL,
	[MaDT] [nchar](20) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV1                 ', N'Nguyễn Văn An', N'08/06/1998', N'Nam', N'184299999           ', N'0989321468          ', N'Kinh', N'Nam Đàn - Nghệ An', N'Nam Đàn - Nghệ An', N'57A2                ', N'A202                ', NULL, N'DT2                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV2                 ', N'Nguyễn Thị Bình', N'02/08/1998', N'Nữ', N'184222471           ', N'0987412582          ', N'Kinh', N'Can Lộc - Hà Tĩnh', N'Can Lộc - Hà Tĩnh', N'57M1                ', NULL, N'NGT1                ', N'DT2                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV3                 ', N'Võ Huy Cường', N'01/07/1997', N'Nam', N'184788787           ', N'0323254854          ', N'Kinh', N'Cẩm Xuyên - Hà Tĩnh', N'Cẩm Xuyên - Hà Tĩnh', N'57B4                ', N'C101                ', NULL, N'DT2                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV4                 ', N'Phan Ngọc Danh', N'02/02/1998', N'Nam', N'187415714           ', N'0336447185          ', N'Kinh', N'TP.Vinh - Nghệ An', N'TP.Vinh - Nghệ An', N'57A2                ', NULL, N'NGT2                ', N'DT2                 ')
/****** Object:  Table [dbo].[NGUOITHAN]    Script Date: 11/26/2019 21:55:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOITHAN](
	[MSV] [nchar](20) NOT NULL,
	[HoTenNT] [nvarchar](50) NULL,
	[NamSinh] [nchar](10) NULL,
	[QuanHe] [nvarchar](10) NOT NULL,
	[SDT] [nchar](15) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_NGUOITHAN] PRIMARY KEY CLUSTERED 
(
	[MSV] ASC,
	[QuanHe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV1                 ', N'Nguyễn Văn Sơn', N'1975      ', N'Bố', N'0987485754     ', N'Nam Đàn - Nghệ An')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV1                 ', N'Nguyễn Thị Lan', N'1981      ', N'Mẹ', N'0987451245     ', N'Nam Đàn - Nghệ An')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV2                 ', N'Phạm Hồng Quân', N'1968      ', N'Bố', N'0324578545     ', N'Can Lộc - Hà Tĩnh')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV2                 ', N'Lê Thị Thương', N'1971      ', N'Mẹ', N'0987458158     ', N'Nghi Xuân - Hà tĩnh')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV3                 ', N'Võ Huy Thông', N'1969      ', N'Bố', N'0888747474     ', N'Cẩm Xuyên - Hà Tĩnh')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV3                 ', N'Võ Thị Lan', N'1970      ', N'Mẹ', N'0968656521     ', N'Thạch Hà - Hà Tĩnh')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV4                 ', N'Phan Ngọc Công ', N'1975      ', N'Bố ', N'0985214114     ', N'Hưng Nguyên - Nghệ An')
INSERT [dbo].[NGUOITHAN] ([MSV], [HoTenNT], [NamSinh], [QuanHe], [SDT], [DiaChi]) VALUES (N'SV4                 ', N'Phạm Thị Thắm', N'1979      ', N'Mẹ', N'0345785854     ', N'Nghi Xuân - Hà Tĩnh')
/****** Object:  ForeignKey [FK_LOP_NGANH]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_NGANH] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGANH] ([MaNganh])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_NGANH]
GO
/****** Object:  ForeignKey [FK_NGANH_KHOAVIEN]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[NGANH]  WITH CHECK ADD  CONSTRAINT [FK_NGANH_KHOAVIEN] FOREIGN KEY([MKV])
REFERENCES [dbo].[KHOAVIEN] ([MKV])
GO
ALTER TABLE [dbo].[NGANH] CHECK CONSTRAINT [FK_NGANH_KHOAVIEN]
GO
/****** Object:  ForeignKey [FK_NGUOITHAN_SINHVIEN]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[NGUOITHAN]  WITH CHECK ADD  CONSTRAINT [FK_NGUOITHAN_SINHVIEN] FOREIGN KEY([MSV])
REFERENCES [dbo].[SINHVIEN] ([MSV])
GO
ALTER TABLE [dbo].[NGUOITHAN] CHECK CONSTRAINT [FK_NGUOITHAN_SINHVIEN]
GO
/****** Object:  ForeignKey [FK_NOITRU_KTX]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[NOITRU]  WITH CHECK ADD  CONSTRAINT [FK_NOITRU_KTX] FOREIGN KEY([MaKTX])
REFERENCES [dbo].[KTX] ([MaKTX])
GO
ALTER TABLE [dbo].[NOITRU] CHECK CONSTRAINT [FK_NOITRU_KTX]
GO
/****** Object:  ForeignKey [FK_SINHVIEN_LOAIHINHDT]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOAIHINHDT] FOREIGN KEY([MaDT])
REFERENCES [dbo].[LOAIHINHDT] ([MaDT])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOAIHINHDT]
GO
/****** Object:  ForeignKey [FK_SINHVIEN_LOP]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
/****** Object:  ForeignKey [FK_SINHVIEN_NGOAITRU]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_NGOAITRU] FOREIGN KEY([MaNGT])
REFERENCES [dbo].[NGOAITRU] ([MaNGT])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_NGOAITRU]
GO
/****** Object:  ForeignKey [FK_SINHVIEN_NOITRU]    Script Date: 11/26/2019 21:55:32 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_NOITRU] FOREIGN KEY([TenPhong])
REFERENCES [dbo].[NOITRU] ([TenPhong])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_NOITRU]
GO
