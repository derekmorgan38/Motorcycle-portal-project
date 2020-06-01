USE [master]
GO
/****** Object:  Database [Bike]    Script Date: 05/04/2015 11:33:06 ******/
CREATE DATABASE [Bike] ON  PRIMARY 
( NAME = N'Bike', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Bike.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bike_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Bike_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Bike] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bike].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bike] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Bike] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Bike] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Bike] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Bike] SET ARITHABORT OFF
GO
ALTER DATABASE [Bike] SET AUTO_CLOSE ON
GO
ALTER DATABASE [Bike] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Bike] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Bike] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Bike] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Bike] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Bike] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Bike] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Bike] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Bike] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Bike] SET  ENABLE_BROKER
GO
ALTER DATABASE [Bike] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Bike] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Bike] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Bike] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Bike] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Bike] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Bike] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Bike] SET  READ_WRITE
GO
ALTER DATABASE [Bike] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Bike] SET  MULTI_USER
GO
ALTER DATABASE [Bike] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Bike] SET DB_CHAINING OFF
GO
USE [Bike]
GO
/****** Object:  Table [dbo].[topic]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[topic](
	[userid] [varchar](50) NULL,
	[id] [varchar](50) NULL,
	[topic] [varchar](50) NULL,
	[image] [varchar](50) NULL,
	[decription] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[topic] ([userid], [id], [topic], [image], [decription]) VALUES (N'1003', N'1', N'garden', N'images/Bike Portalbanner2.jpg', N'good')
INSERT [dbo].[topic] ([userid], [id], [topic], [image], [decription]) VALUES (N'1003', N'2', N'blue', N'images/Bike Portalbanner2.jpg', N'sports bike')
INSERT [dbo].[topic] ([userid], [id], [topic], [image], [decription]) VALUES (N'1003', N'3', N'blue', N'images/Bike Portalbanner2.jpg', N'sports bike')
/****** Object:  Table [dbo].[service]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[service](
	[transid] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[time] [varchar](50) NULL,
	[brandname] [varchar](50) NULL,
	[modelno] [varchar](50) NULL,
	[registrationno] [varchar](50) NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[contact] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[service] ([transid], [date], [time], [brandname], [modelno], [registrationno], [fname], [lname], [contact]) VALUES (N'502', N'08-May-15', N'11:00 am', N'honda', N'78745', N'54445', N'mary', N'samy', N'7045087277')
INSERT [dbo].[service] ([transid], [date], [time], [brandname], [modelno], [registrationno], [fname], [lname], [contact]) VALUES (N'501', N'01-May-15', N'11:00 am', N'Hero', N'5191', N'54564', N'mary', N'samy', N'7045087277')
/****** Object:  Table [dbo].[sell]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sell](
	[img] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Contact_no] [varchar](50) NULL,
	[Item] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[sell] ([img], [Name], [Contact_no], [Item]) VALUES (N'', N'Neeraj Sawant', N'9855445566', N'Fruits')
/****** Object:  Table [dbo].[Rent]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rent](
	[image] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[description] [varchar](1000) NULL,
	[price] [varchar](50) NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[email] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Rent] ([image], [name], [description], [price], [fname], [lname], [contact], [email]) VALUES (N'images\bike\h2.png', N'h2', N'The legacy of weapons manufacture is reflected in the logo, a cannon, and their motto "Made Like A Gun".', N'55000', N'mary', N'samy', N'7045087277', N'mary@gmail.com')
INSERT [dbo].[Rent] ([image], [name], [description], [price], [fname], [lname], [contact], [email]) VALUES (N'images\2012_KTM-Duke-200.jpg', N'h18', N'superb', N'5000', N'mary', N'samy', N'7045087277', N'mary@gmail.com')
/****** Object:  Table [dbo].[Products]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Pid] [int] NULL,
	[PName] [varchar](100) NULL,
	[Pimg] [varchar](80) NULL,
	[Psdesc] [varchar](1000) NULL,
	[Pprice] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (101, N'h1', N'images\2012_KTM-Duke-200.jpg', N'superb', 5000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (102, N'h2', N'images\bike\h2.png', N'The legacy of weapons manufacture is reflected in the logo, a cannon, and their motto "Made Like A Gun".', 55000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (103, N'h3', N'images\bike\h3.png', N'Royal Enfield opened its establishment in India in 1955 named as Enfield of India based in Chennai.', 45000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (104, N'h4', N'images\bike\h4.png', N'It started assembling Bullet motorcycles with the imported components from UK.', 50000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (105, N'h5', N'images\bike\h5.png', N'The original Redditch, Worcestershire based company dissolved in 1971, but Enfield of India continued, and bought the rights to use the Royal Enfield name.', 80000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (106, N'h6', N'images\bike\h6.png', N'In 1955, the Redditch Company partnered Madras Motors in India in forming ''Enfield India'' and gave the licence to assemble the 350 cc Royal Enfield Bullet motorcycle in Madras.', 78000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (107, N'h7', N'images\bike\h7.png', N'Under Indian law, Madras Motors owned the majority (over 50%) of shares in the company. In 1957 tooling equipment was sold to Enfield India so that they could manufacture components.', 90000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (108, N'h8', N'images\bike\h8.png', N'The first machines were assembled entirely from components shipped from England, but by 1962 all components were made in India.', 80000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (109, N'h9', N'images\bike\h9.png', N'The Indian government needed a motorcycle suitable for its police and army which they could use for patrolling.', 85000)
INSERT [dbo].[Products] ([Pid], [PName], [Pimg], [Psdesc], [Pprice]) VALUES (110, N'h10', N'images\2012_KTM-Duke-200.jpg', N'superb', 5000)
/****** Object:  Table [dbo].[Parts]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parts](
	[id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[img] [varchar](50) NULL,
	[sdesc] [varchar](1000) NULL,
	[price] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'201', N'p1', N'images\parts\p1.jpg', N'as in the generic definition  a rod that serves to attach a wheel to a bicycle and provides support for bearings on which the wheel rotates. ', N'1500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'202', N'p2', N'images\parts\p2.jpg', N'. Also sometimes used to describe suspension components, for example a swing arm pivot axle', N'2000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'203', N'p3', N'images\parts\p3.jpg', N'extensions at the end of straight handlebars to allow for multiple hand positions', N'2500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'204', N'p4', N'images\parts\p4.jpg', N'plugs for the ends of handlebars', N'3000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'205', N'p5', N'images\parts\p5.jpg', N'a device that facilitates rotation by reducing friction', N'3500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'206', N'p6', N'images\parts\p6.jpg', N'an audible device for warning pedestrians and other cyclists', N'4000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'207', N'p7', N'images\parts\p7.jpg', N'The bearing system that the pedals (and cranks) rotate around.', N'4500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'208', N'p8', N'images\parts\p8.jpg', N'Contains a spindle to which the crankset is attached and the bearings themselves.', N'5000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'209', N'p9', N'images\parts\p9.jpg', N'The bottom bracket fits inside the bottom bracket shell, which is part of the bicycle frame', N'5500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'210', N'p10', N'images\parts\p10.jpg', N'devices used to stop or slow down a bicycle.', N'6000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'211', N'p11', N'images\parts\p11.jpg', N' Rim brakes and disc brakes are operated by brake levers, which are mounted on the handlebars. Band brake is an alternative to rim brakes but can only be installed at the rear wheel. ', N'6500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'212', N'p12', N'images\parts\p12.jpg', N' a lever for actuating a bicycle brake', N'7000')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'213', N'p13', N'images\parts\p13.jpg', N'Coaster brakes are operated by pedaling backward', N'5500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'112', N'phu', N'images\p13.jpg', N'hgh', N'1500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'112', N'phu', N'images\p13.jpg', N'hgh', N'1500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'112', N'phu', N'images\p13.jpg', N'hgh', N'1500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'112', N'phu', N'images\p13.jpg', N'hgh', N'1500')
INSERT [dbo].[Parts] ([id], [name], [img], [sdesc], [price]) VALUES (N'112', N'phu', N'images\p13.jpg', N'hgh', N'1500')
/****** Object:  Table [dbo].[order1]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[order1](
	[uid] [varchar](50) NULL,
	[items] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
	[cost] [varchar](50) NULL,
	[Total] [varchar](50) NULL,
	[modeofpayment] [varchar](50) NULL,
	[date] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[order1] ([uid], [items], [quantity], [cost], [Total], [modeofpayment], [date]) VALUES (N'marysamy', N'mary', N'7045087277', N' phu ,', N'3000', N'COD', N'1-May-15')
INSERT [dbo].[order1] ([uid], [items], [quantity], [cost], [Total], [modeofpayment], [date]) VALUES (N'marysamy', N'mary', N'7045087277', N' phu ,', N'3000', N'COD', N'30-Apr-15')
/****** Object:  Table [dbo].[Login]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[Fname] [varchar](50) NOT NULL,
	[Mname] [varchar](50) NULL,
	[Lname] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Contact] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Uid] [int] NOT NULL,
	[Gender] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Login] ([Fname], [Mname], [Lname], [Email], [Contact], [City], [Address], [Username], [Password], [Uid], [Gender]) VALUES (N'Neeraj', N'Prasad', N'Sawant', N'n.sawant@gmail.com', N'9855445566', N'Mumbai', N'Andheri', N'nrj', N'nrj', 1001, N'Male')
INSERT [dbo].[Login] ([Fname], [Mname], [Lname], [Email], [Contact], [City], [Address], [Username], [Password], [Uid], [Gender]) VALUES (N'rahul', N'rohit', N'dube', N'jfjfj@ghhg.com', N'9855442211', N'', N'', N'rahul', N'1234', 1002, N'Male')
INSERT [dbo].[Login] ([Fname], [Mname], [Lname], [Email], [Contact], [City], [Address], [Username], [Password], [Uid], [Gender]) VALUES (N'mary', N'antony', N'samy', N'maryantony32@yahoo.co.in', N'7045087277', N'mumbai', N'mira road', N'marysamy', N'samy', 1003, N'Female')
/****** Object:  Table [dbo].[feed]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[feed](
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Feedback] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[feed] ([Name], [Contact], [Feedback]) VALUES (N'Neeraj Sawant', N'9855445566', N'dfsdfsd')
/****** Object:  Table [dbo].[comment]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comment](
	[userid] [varchar](50) NULL,
	[comment] [varchar](50) NULL,
	[id] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[comment] ([userid], [comment], [id]) VALUES (N'1003', N'superb bike', N'1')
INSERT [dbo].[comment] ([userid], [comment], [id]) VALUES (N'1003', N'ok ', N'2')
INSERT [dbo].[comment] ([userid], [comment], [id]) VALUES (N'1003', N'well', N'3')
INSERT [dbo].[comment] ([userid], [comment], [id]) VALUES (N'1003', N'not too good', N'2')
/****** Object:  Table [dbo].[cart]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cart](
	[User_id] [varchar](50) NULL,
	[Item] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Cost] [int] NULL,
	[Total_cost] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bikesell]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bikesell](
	[id] [varchar](50) NULL,
	[image] [varchar](50) NULL,
	[company] [varchar](50) NULL,
	[modelname] [varchar](50) NULL,
	[modelno] [varchar](50) NULL,
	[modelyear] [varchar](50) NULL,
	[price] [varchar](50) NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[mobileno] [varchar](50) NULL,
	[emailid] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[bikesell] ([id], [image], [company], [modelname], [modelno], [modelyear], [price], [fname], [lname], [mobileno], [emailid]) VALUES (N'110', N'Bike Portalbanner2.jpg', N'honda', N'MH02', N'205154', N'2012', N'50000', N'mary', N'samy', N'7045087277', N'mary@gmail.com')
INSERT [dbo].[bikesell] ([id], [image], [company], [modelname], [modelno], [modelyear], [price], [fname], [lname], [mobileno], [emailid]) VALUES (N'112', N'2012_KTM-Duke-200.jpg', N'hero', N'h6', N'MH03', N'1582', N'40000', N'mary', N'samy', N'7045087277', N'mary@gmail.com')
/****** Object:  Table [dbo].[Bike]    Script Date: 05/04/2015 11:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bike](
	[Himg] [varchar](50) NULL,
	[Hname] [varchar](50) NULL,
	[des] [varchar](200) NULL,
	[cost] [varchar](50) NULL,
	[UId] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
