USE [QLHSSV]
GO
/****** Object:  Table [dbo].[KHOAVIEN]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KTX]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIHINHDT]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGANH]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGOAITRU]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NOITRU]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 02/12/2019 4:35:52 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USERS]    Script Date: 02/12/2019 4:35:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nchar](50) NULL,
	[MatKhau] [nchar](20) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'GD                  ', N'Khoa giáo dục thể chất')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'KTCN                ', N'Viện Kĩ thuật công nghệ')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'LUAT                ', N'Khoa Luật')
INSERT [dbo].[KHOAVIEN] ([MKV], [TenKhoaVien]) VALUES (N'SPTN                ', N'Viện sư phạm tự nhiên')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'                    ', N'                    ')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTA                 ', N'Kí túc xá A         ')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTB                 ', N'kí túc xá B         ')
INSERT [dbo].[KTX] ([MaKTX], [TenKTX]) VALUES (N'KTC                 ', N'Kí túc xá C         ')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT2                 ', N'Đại học ')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT3                 ', N'Liên thông')
INSERT [dbo].[LOAIHINHDT] ([MaDT], [LoaiHinhDT]) VALUES (N'DT4                 ', N'Cao học')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57A2                ', N'N3                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57B4                ', N'N3                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57K3                ', N'N1                  ')
INSERT [dbo].[LOP] ([MaLop], [MaNganh]) VALUES (N'57M1                ', N'N2                  ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N1                  ', N'CNTT', N'KTCN                ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N2                  ', N'GDMN', N'GD                  ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N3                  ', N'LUAT', N'LUAT                ')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MKV]) VALUES (N'N4                  ', N'SPTOAN', N'SPTN                ')
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'                    ', N' ', N'                    ', N' ')
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'NGT1                ', N'Nguyễn Văn Sơn', N'0335845457          ', N'Số 6 - Ngõ 1 - Nguyễn Kiệm -TP.Vinh')
INSERT [dbo].[NGOAITRU] ([MaNGT], [TenChuHo], [SoDT], [DiaChi]) VALUES (N'NGT2                ', N'Phan Nhật Long', N'0987458485          ', N'Số 3A - Ngõ 5 - Võ Thị Sáu - TP.Vinh')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'                    ', 0, 0, N'                    ')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'A202                ', 5, 0, N'KTA                 ')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'B304                ', 6, 1, N'KTB                 ')
INSERT [dbo].[NOITRU] ([TenPhong], [SoLuong], [Status], [MaKTX]) VALUES (N'C101                ', 6, 1, N'KTC                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV1                 ', N'Nguyễn Văn An', N'08/06/1998', N'Nam', N'184299999           ', N'0989321468          ', N'Kinh', N'Nam Đàn - Nghệ An', N'Nam Đàn - Nghệ An', N'57A2                ', N'A202                ', NULL, N'DT2                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV2                 ', N'Nguyễn Thị Bình', N'02/08/1998', N'Nữ', N'184222471           ', N'0987412582          ', N'Kinh', N'Can Lộc - Hà Tĩnh', N'Can Lộc - Hà Tĩnh', N'57M1                ', NULL, N'NGT1                ', N'DT2                 ')
INSERT [dbo].[SINHVIEN] ([MSV], [HoTenSV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DanToc], [NoiSinh], [QueQuan], [MaLop], [TenPhong], [MaNGT], [MaDT]) VALUES (N'SV3                 ', N'Võ Huy Cường', N'01/07/1997', N'Nam', N'184788787           ', N'0323254854          ', N'Kinh', N'Cẩm Xuyên - Hà Tĩnh', N'Cẩm Xuyên - Hà Tĩnh', N'57B4                ', N'C101                ', NULL, N'DT2                 ')
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (1, N'ADMIN                                             ', N'123                 ', 1)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (2, N'USER1                                             ', N'1                   ', 0)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (3, N'USER2                                             ', N'2                   ', 0)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (4, N'USER3                                             ', N'3                   ', 0)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (5, N'USER4                                             ', N'111                 ', 0)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (6, N'user5                                             ', N'12                  ', 0)
INSERT [dbo].[USERS] ([ID], [TenDangNhap], [MatKhau], [Status]) VALUES (7, N'user6                                             ', N'234                 ', 0)
SET IDENTITY_INSERT [dbo].[USERS] OFF
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_NGANH1] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGANH] ([MaNganh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_NGANH1]
GO
ALTER TABLE [dbo].[NGANH]  WITH CHECK ADD  CONSTRAINT [FK_NGANH_KHOAVIEN1] FOREIGN KEY([MKV])
REFERENCES [dbo].[KHOAVIEN] ([MKV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NGANH] CHECK CONSTRAINT [FK_NGANH_KHOAVIEN1]
GO
ALTER TABLE [dbo].[NOITRU]  WITH CHECK ADD  CONSTRAINT [FK_NOITRU_KTX1] FOREIGN KEY([MaKTX])
REFERENCES [dbo].[KTX] ([MaKTX])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NOITRU] CHECK CONSTRAINT [FK_NOITRU_KTX1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOAIHINHDT1] FOREIGN KEY([MaDT])
REFERENCES [dbo].[LOAIHINHDT] ([MaDT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOAIHINHDT1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP1] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_NGOAITRU1] FOREIGN KEY([MaNGT])
REFERENCES [dbo].[NGOAITRU] ([MaNGT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_NGOAITRU1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_NOITRU1] FOREIGN KEY([TenPhong])
REFERENCES [dbo].[NOITRU] ([TenPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_NOITRU1]
GO
