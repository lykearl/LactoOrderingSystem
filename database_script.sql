USE [master]
GO
/****** Object:  Database [LactoBioticsss]    Script Date: 9/14/2019 11:20:43 PM ******/
CREATE DATABASE [LactoBioticsss]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LactoBioticsss', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEJASEARL\MSSQL\DATA\LactoBioticsss.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LactoBioticsss_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEJASEARL\MSSQL\DATA\LactoBioticsss_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LactoBioticsss] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LactoBioticsss].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LactoBioticsss] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LactoBioticsss] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LactoBioticsss] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LactoBioticsss] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LactoBioticsss] SET ARITHABORT OFF 
GO
ALTER DATABASE [LactoBioticsss] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LactoBioticsss] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LactoBioticsss] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LactoBioticsss] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LactoBioticsss] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LactoBioticsss] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LactoBioticsss] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LactoBioticsss] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LactoBioticsss] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LactoBioticsss] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LactoBioticsss] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LactoBioticsss] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LactoBioticsss] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LactoBioticsss] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LactoBioticsss] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LactoBioticsss] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LactoBioticsss] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LactoBioticsss] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LactoBioticsss] SET  MULTI_USER 
GO
ALTER DATABASE [LactoBioticsss] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LactoBioticsss] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LactoBioticsss] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LactoBioticsss] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LactoBioticsss] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LactoBioticsss]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 9/14/2019 11:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[users_id] [int] NULL,
	[customer_name] [varchar](50) NULL,
	[tin] [varchar](50) NULL,
	[address_] [varchar](50) NULL,
	[business_style] [varchar](50) NULL,
	[contact_no] [varchar](20) NULL,
	[customer_type] [varchar](50) NULL,
	[date_] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventory](
	[inventory_id] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[stock_in] [int] NULL,
	[users_id] [int] NULL,
	[stock_in_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[inventory_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[users_id] [int] NULL,
	[product_code] [varchar](50) NULL,
	[product_name] [varchar](50) NULL,
	[product_category] [varchar](50) NULL,
	[product_price] [int] NULL,
	[product_description] [varchar](100) NULL,
	[date_] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsDelivery]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsDelivery](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[order_quantity] [int] NULL,
	[totalPrice] [decimal](18, 0) NULL,
	[transactiontype] [varchar](50) NULL,
	[Delivery_Date] [datetime] NULL,
	[deliveryStatus] [varchar](50) NULL,
	[customer_id] [int] NULL,
	[users_id] [int] NULL,
	[Date_] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsReservation]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsReservation](
	[ReservationId] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[order_quantity] [int] NULL,
	[totalPrice] [decimal](18, 0) NULL,
	[transactiontype] [varchar](50) NULL,
	[ClaimDate] [datetime] NULL,
	[reservationStatus] [varchar](50) NULL,
	[customer_id] [int] NULL,
	[users_id] [int] NULL,
	[Reservation_Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReports]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReports](
	[SalesReport_ID] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[order_quantity] [int] NULL,
	[TotalAmount] [decimal](18, 0) NULL,
	[transactiontype] [varchar](50) NULL,
	[customer_id] [int] NULL,
	[users_id] [int] NULL,
	[date_] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesReport_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stocks](
	[stocks_id] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[stock_in] [int] NULL,
	[users_id] [int] NULL,
	[stock_in_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[stocks_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_acc](
	[users_id] [int] IDENTITY(1,1) NOT NULL,
	[user_uname] [varchar](20) NOT NULL,
	[user_pass] [varchar](20) NOT NULL,
	[user_type] [varchar](50) NOT NULL,
	[user_Fname] [varchar](20) NOT NULL,
	[user_Lname] [varchar](20) NOT NULL,
	[user_email] [varchar](50) NOT NULL,
	[user_status] [varchar](20) NOT NULL,
	[secQuest] [varchar](max) NOT NULL,
	[secAns] [varchar](max) NOT NULL,
	[date_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[users_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_id], [users_id], [customer_name], [tin], [address_], [business_style], [contact_no], [customer_type], [date_]) VALUES (1, 1, N'Botica John Pharmacy', N'17-2000004', N'Tabunoc, City of Talisay, Cebu', N'Pharmacy', N'236-3038', N'Company Client', CAST(N'2019-09-12 17:51:18.320' AS DateTime))
INSERT [dbo].[customers] ([customer_id], [users_id], [customer_name], [tin], [address_], [business_style], [contact_no], [customer_type], [date_]) VALUES (2, 1, N'Mario P. Guias', N'17-2000008', N'San Isidro, City of Talisay, Cebu', N'None', N'09222581654', N'Walk-in Client', CAST(N'2019-09-12 17:52:09.760' AS DateTime))
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[inventory] ON 

INSERT [dbo].[inventory] ([inventory_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (1, 1, 700, 1, CAST(N'2019-09-12 17:54:45.043' AS DateTime))
INSERT [dbo].[inventory] ([inventory_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (2, 2, 800, 1, CAST(N'2019-09-12 17:54:57.490' AS DateTime))
INSERT [dbo].[inventory] ([inventory_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (3, 3, 700, 1, CAST(N'2019-09-12 17:55:05.547' AS DateTime))
SET IDENTITY_INSERT [dbo].[inventory] OFF
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([productID], [users_id], [product_code], [product_name], [product_category], [product_price], [product_description], [date_]) VALUES (1, 1, N'SP-0', N'Green Papaya Soap', N'Soap', 50, N'For healthier skin', CAST(N'2019-09-12 17:52:46.140' AS DateTime))
INSERT [dbo].[products] ([productID], [users_id], [product_code], [product_name], [product_category], [product_price], [product_description], [date_]) VALUES (2, 1, N'HM-0', N'LactoVitale', N'Herbal Medicine', 148, N'Lactobacillus drink for your family', CAST(N'2019-09-12 17:53:43.627' AS DateTime))
INSERT [dbo].[products] ([productID], [users_id], [product_code], [product_name], [product_category], [product_price], [product_description], [date_]) VALUES (3, 1, N'SP-1', N'Carrot Soap', N'Soap', 50, N'Para sa skin na kapansin-pansin', CAST(N'2019-09-12 17:54:29.657' AS DateTime))
INSERT [dbo].[products] ([productID], [users_id], [product_code], [product_name], [product_category], [product_price], [product_description], [date_]) VALUES (4, 1, N'HM-1', N'lacto pafi', N'Herbal Medicine', 148, N'ssa', CAST(N'2019-09-12 18:20:34.717' AS DateTime))
SET IDENTITY_INSERT [dbo].[products] OFF
SET IDENTITY_INSERT [dbo].[ProductsDelivery] ON 

INSERT [dbo].[ProductsDelivery] ([DeliveryId], [productID], [order_quantity], [totalPrice], [transactiontype], [Delivery_Date], [deliveryStatus], [customer_id], [users_id], [Date_]) VALUES (1, 2, 15, CAST(2220 AS Decimal(18, 0)), N'Delivery', CAST(N'2019-09-12 17:56:00.000' AS DateTime), N'Not Delivered', 1, 1, CAST(N'2019-09-12 17:56:29.000' AS DateTime))
INSERT [dbo].[ProductsDelivery] ([DeliveryId], [productID], [order_quantity], [totalPrice], [transactiontype], [Delivery_Date], [deliveryStatus], [customer_id], [users_id], [Date_]) VALUES (2, 3, 19, CAST(950 AS Decimal(18, 0)), N'Delivery', CAST(N'2019-09-12 17:59:51.000' AS DateTime), N'Not Delivered', 1, 1, CAST(N'2019-09-12 18:00:12.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductsDelivery] OFF
SET IDENTITY_INSERT [dbo].[ProductsReservation] ON 

INSERT [dbo].[ProductsReservation] ([ReservationId], [productID], [order_quantity], [totalPrice], [transactiontype], [ClaimDate], [reservationStatus], [customer_id], [users_id], [Reservation_Date]) VALUES (1, 1, 10, CAST(500 AS Decimal(18, 0)), N'Reservation', CAST(N'2019-09-12 17:57:03.000' AS DateTime), N'Unclaim', 1, 1, CAST(N'2019-09-12 17:57:36.000' AS DateTime))
INSERT [dbo].[ProductsReservation] ([ReservationId], [productID], [order_quantity], [totalPrice], [transactiontype], [ClaimDate], [reservationStatus], [customer_id], [users_id], [Reservation_Date]) VALUES (2, 1, 10, CAST(500 AS Decimal(18, 0)), N'Reservation', CAST(N'2019-09-12 17:57:03.000' AS DateTime), N'Unclaim', 1, 1, CAST(N'2019-09-12 17:58:16.000' AS DateTime))
INSERT [dbo].[ProductsReservation] ([ReservationId], [productID], [order_quantity], [totalPrice], [transactiontype], [ClaimDate], [reservationStatus], [customer_id], [users_id], [Reservation_Date]) VALUES (3, 1, 5, CAST(250 AS Decimal(18, 0)), N'Reservation', CAST(N'2019-09-12 18:22:13.000' AS DateTime), N'Unclaim', 1, 1, CAST(N'2019-09-12 18:22:20.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductsReservation] OFF
SET IDENTITY_INSERT [dbo].[SalesReports] ON 

INSERT [dbo].[SalesReports] ([SalesReport_ID], [productID], [order_quantity], [TotalAmount], [transactiontype], [customer_id], [users_id], [date_]) VALUES (1, 2, 15, CAST(2220 AS Decimal(18, 0)), N'Delivery', 1, 1, CAST(N'2019-09-12 17:56:29.000' AS DateTime))
INSERT [dbo].[SalesReports] ([SalesReport_ID], [productID], [order_quantity], [TotalAmount], [transactiontype], [customer_id], [users_id], [date_]) VALUES (2, 1, 10, CAST(500 AS Decimal(18, 0)), N'Reservation', 1, 1, CAST(N'2019-09-12 17:57:36.000' AS DateTime))
INSERT [dbo].[SalesReports] ([SalesReport_ID], [productID], [order_quantity], [TotalAmount], [transactiontype], [customer_id], [users_id], [date_]) VALUES (3, 1, 10, CAST(500 AS Decimal(18, 0)), N'Reservation', 1, 1, CAST(N'2019-09-12 17:58:16.000' AS DateTime))
INSERT [dbo].[SalesReports] ([SalesReport_ID], [productID], [order_quantity], [TotalAmount], [transactiontype], [customer_id], [users_id], [date_]) VALUES (4, 3, 19, CAST(950 AS Decimal(18, 0)), N'Delivery', 1, 1, CAST(N'2019-09-12 18:00:12.000' AS DateTime))
INSERT [dbo].[SalesReports] ([SalesReport_ID], [productID], [order_quantity], [TotalAmount], [transactiontype], [customer_id], [users_id], [date_]) VALUES (5, 1, 5, CAST(250 AS Decimal(18, 0)), N'Reservation', 1, 1, CAST(N'2019-09-12 18:22:20.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[SalesReports] OFF
SET IDENTITY_INSERT [dbo].[stocks] ON 

INSERT [dbo].[stocks] ([stocks_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (1, 1, 675, 1, CAST(N'2019-09-12 17:54:44.963' AS DateTime))
INSERT [dbo].[stocks] ([stocks_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (2, 2, 785, 1, CAST(N'2019-09-12 17:54:57.490' AS DateTime))
INSERT [dbo].[stocks] ([stocks_id], [productID], [stock_in], [users_id], [stock_in_date]) VALUES (3, 3, 681, 1, CAST(N'2019-09-12 17:55:05.547' AS DateTime))
SET IDENTITY_INSERT [dbo].[stocks] OFF
SET IDENTITY_INSERT [dbo].[User_acc] ON 

INSERT [dbo].[User_acc] ([users_id], [user_uname], [user_pass], [user_type], [user_Fname], [user_Lname], [user_email], [user_status], [secQuest], [secAns], [date_reg]) VALUES (1, N'admin', N'admin', N'Administrator', N'earl', N'cejas', N'lykearl@gmail.com', N'Active', N'What is the name of your pet?', N'earl', CAST(N'2019-05-09 00:00:00.000' AS DateTime))
INSERT [dbo].[User_acc] ([users_id], [user_uname], [user_pass], [user_type], [user_Fname], [user_Lname], [user_email], [user_status], [secQuest], [secAns], [date_reg]) VALUES (2, N'act.marvinrojo', N'09222581654', N'Staff', N'marvin', N'rojo', N'act.marvinrojo@gmail.com', N'Active', N'Who is your first kiss?', N'myself', CAST(N'2019-09-12 17:50:17.800' AS DateTime))
SET IDENTITY_INSERT [dbo].[User_acc] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__User_acc__99FAAAF1FB523F19]    Script Date: 9/14/2019 11:20:44 PM ******/
ALTER TABLE [dbo].[User_acc] ADD UNIQUE NONCLUSTERED 
(
	[user_uname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[customers]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
ALTER TABLE [dbo].[stocks]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[stocks]  WITH CHECK ADD FOREIGN KEY([users_id])
REFERENCES [dbo].[User_acc] ([users_id])
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ChangePassword]
@user_uname varchar (50),
@newPass varchar (50)
as 
update user_acc  set user_pass = @newPass where user_uname = @user_uname

GO
/****** Object:  StoredProcedure [dbo].[forgotPassword]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[forgotPassword]
@user_uname varchar (50),
@secQuest varchar (max),
@secAns varchar (max)
as
select * from user_acc where user_uname = @user_uname and secQuest= @secQuest and secAns= @secAns

GO
/****** Object:  StoredProcedure [dbo].[sp_add_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_acc]
@user_uname varchar (20),
@user_pass varchar (20),
@user_type varchar (50),
@user_Fname varchar (20),
@user_Lname varchar (20),
@user_email varchar (50),
@user_status varchar (20), 
@secQuest varchar (max),
@secAns varchar (max),
@date_reg datetime
as
insert into user_acc 
values (@user_uname,@user_pass,@user_type,@user_Fname,@user_Lname, @user_email, @user_status, @secQuest, @secAns,@date_reg) return

------------------
GO
/****** Object:  StoredProcedure [dbo].[sp_add_customer]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_customer]
@users_id int,
@customer_name varchar (50),
@tin varchar (50),
@address_ varchar(50),
@business_style varchar (50),
@contact_no varchar (20),
@customer_type varchar (50),
@date_ datetime 
as
insert into customers
values (@users_id, @customer_name, @tin, @address_, @business_style, @contact_no ,@customer_type, @date_) return

GO
/****** Object:  StoredProcedure [dbo].[sp_add_delivery]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_delivery]
@productId int,
@order_quantity int,
@totalPrice decimal,
@transactiontype varchar(50),
@Delivery_Date datetime,
@deliveryStatus varchar (50),
@customer_id int,
@user_id int,
@Date_ datetime
as
insert into ProductsReservation
values (@productID, @order_quantity, @totalPrice, @transactiontype, @Delivery_Date, @deliveryStatus, @customer_id, @user_id, @Date_)

GO
/****** Object:  StoredProcedure [dbo].[sp_add_inventory]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_inventory]
@productID int,
@stock_in int,
@users_id int,
@stock_in_date datetime
as
insert into inventory
values (@productID, @stock_in, @users_id, @stock_in_date)

GO
/****** Object:  StoredProcedure [dbo].[sp_add_products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_products]
@users_id int,
@product_code varchar (50),
@product_name varchar (50),
@product_category varchar (50),
@product_price decimal,
@product_description varchar (100),
@date_ datetime
as
insert into products
values (@users_id, @product_code, @product_name, @product_category, @product_price, @product_description,  @date_) return

GO
/****** Object:  StoredProcedure [dbo].[sp_add_reservation]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_reservation]
@productId int,
@order_quantity int,
@totalPrice decimal,
@transactiontype varchar(50),
@ClaimDate datetime,
@reservationStatus varchar (50),
@customer_id int,
@user_id int,
@Reservation_Date datetime
as
insert into ProductsReservation
values (@productID, @order_quantity, @totalPrice, @transactiontype, @ClaimDate, @reservationStatus, @customer_id, @user_id, @Reservation_Date)

GO
/****** Object:  StoredProcedure [dbo].[sp_add_SalesReports]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_SalesReports]
@productID int,
@order_quantity int,
@TotalAmount decimal,
@transactiontype varchar (50),
@customer_id int,
@users_id int,
@date_ datetime
as
insert into SalesReports
values(@productID,@order_quantity ,@TotalAmount ,@transactiontype, @customer_id, @users_id, @date_)

---------
GO
/****** Object:  StoredProcedure [dbo].[sp_add_stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_add_stocks]
@productID int,
@stock_in int,
@users_id int,
@stock_in_date datetime
as
insert into stocks
values (@productID, @stock_in, @users_id, @stock_in_date)

-------
GO
/****** Object:  StoredProcedure [dbo].[sp_cancel_order]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_cancel_order]
@quantityToRevert int,
@product_ID varchar(max)
as
update stocks
set stock_in = stock_in + @quantityToRevert 
where productID = @product_ID

GO
/****** Object:  StoredProcedure [dbo].[sp_delete_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_delete_acc]
@users_id int
as
delete from user_acc
where users_id = @users_id return

---------------------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_delete_stocks]
@stocks_id int
as
delete from stocks
where stocks_id = @stocks_id

GO
/****** Object:  StoredProcedure [dbo].[sp_login_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_login_acc]
@user_uname varchar (max),
@user_pass varchar (max)
as
select * from user_acc where user_uname = @user_uname and user_pass = @user_pass return

----------------
GO
/****** Object:  StoredProcedure [dbo].[sp_remove_customer]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_remove_customer]
@customer_id int
as
delete from customers
where customer_id = @customer_id return

GO
/****** Object:  StoredProcedure [dbo].[sp_remove_products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_remove_products]
@productID int
as
delete from products
where productID = @productID  return

---
GO
/****** Object:  StoredProcedure [dbo].[sp_search_customer]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_search_customer]
@key varchar (max)
as
select * from customers
where customer_id like '%' +@key+ '%' or
	  users_id like '%' +@key+ '%' or
      customer_name like '%' + @key+ '%' or
	  tin like '%' + @key+ '%' or
      address_ like '%' + @key+ '%' or
	  business_style like '%' + @key+ '%' or
	  contact_no like '%' + @key+ '%' or
	  customer_type like '%' + @key+ '%' or
	  date_ like '%' + @key+ '%' 
	  return

GO
/****** Object:  StoredProcedure [dbo].[sp_search_products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_search_products]
@key varchar (max)
as
select * from products
where productID like '%' +@key+ '%' or
	  product_code like '%' +@key+ '%' or
	  product_name like '%' +@key+ '%' or
	  product_category like '%' +@key+ '%' or
	  product_price like '%' +@key+ '%' or
	  product_description like '%' +@key+ '%' or
	  users_id like '%' +@key+ '%' or
	  date_ like '%' +@key+ '%'

-----------
GO
/****** Object:  StoredProcedure [dbo].[sp_search_stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_search_stocks]
@key varchar (max)
as
select * from stocks
where stocks_id like '%' + @key + '%' or
      productId like '%' + @key + '%' or
	  stock_in like '%' + @key + '%' or
	  users_id like '%' + @key + '%' or
	  stock_in_date like '%' + @key + '%'

-----------
GO
/****** Object:  StoredProcedure [dbo].[sp_search_user_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_search_user_acc]
@key varchar (max)
as
select * from user_acc
where users_id like '%' +@key+ '%' or
      user_uname like '%' +@key+ '%' or
      user_pass like '%' +@key+ '%' or
	  user_type like '%' +@key+ '%' or
      user_Fname like '%' + @key+ '%' or
	  user_Lname like '%' + @key+ '%' or
	  user_email like '%' + @key+ '%' or
	  user_status like '%' + @key+ '%' or
	  secQuest like '%' + @key+ '%'or
	  secAns like '%' + @key+ '%'or
	  date_reg  like '%' + @key+ '%'
	  return
GO
/****** Object:  StoredProcedure [dbo].[sp_select_delivery]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_delivery]
as
select DeliveryId, products.productId, products.product_code, products.product_name, ProductsDelivery.order_quantity, ProductsDelivery.totalPrice,  ProductsDelivery.transactiontype, ProductsDelivery.Delivery_Date, ProductsDelivery.deliveryStatus, 
customers.customer_name, customers.address_, customers.customer_id, User_acc.users_id, ProductsDelivery.Date_
from ProductsDelivery inner join products on ProductsDelivery.productID = products.productId inner join customers on ProductsDelivery.customer_id = customers.customer_id inner join User_acc on ProductsDelivery.users_id = User_acc.users_id

----------
GO
/****** Object:  StoredProcedure [dbo].[sp_select_reservation]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_reservation]
as
select ReservationId, products.productId, products.product_code, products.product_name, ProductsReservation.order_quantity, ProductsReservation.totalPrice, ProductsReservation.transactiontype, ProductsReservation.ClaimDate, ProductsReservation.reservationStatus, 
customers.customer_name, customers.address_, customers.customer_id, User_acc.users_id, ProductsReservation.Reservation_Date
from ProductsReservation inner join products on ProductsReservation.productID = products.productId inner join customers on ProductsReservation.customer_id = customers.customer_id inner join User_acc on ProductsReservation.users_id = User_acc.users_id

GO
/****** Object:  StoredProcedure [dbo].[sp_select_stocks_inventory]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_stocks_inventory]
as
select inventory_id, products.productID, products.product_code, products.product_name, products.product_category, products.product_price, inventory.stock_in, products.product_description, User_acc.user_Fname, User_acc.user_Lname, User_acc.users_id, inventory.stock_in_date
from inventory inner join User_acc on inventory.users_id = User_acc.users_id inner join products on inventory.productID = products.productID
 
GO
/****** Object:  StoredProcedure [dbo].[sp_update_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_update_acc]
@users_id int,
@user_uname varchar (20),
@user_pass varchar (20),
@user_type varchar (50),
@user_Fname varchar (20),
@user_Lname varchar (20),
@user_email varchar (50),
@user_status varchar (20), 
@secQuest varchar (max),
@secAns varchar (max),
@date_reg datetime
as
update user_acc
set user_uname=@user_uname, user_pass=@user_pass, user_type=@user_type, user_Fname=@user_Fname, user_Lname=@user_Lname, user_email=@user_email,
user_status=@user_status, secQuest=@secQuest, secAns=@secAns, date_reg=@date_reg
from user_acc
where users_id=@users_id;

----------
GO
/****** Object:  StoredProcedure [dbo].[sp_update_customer]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_customer]
@customer_id int,
@customer_name varchar (50),
@tin varchar (50),
@address_ varchar(20),
@business_style varchar (50),
@contact_no varchar (20),
@customer_type varchar (50),
@date_ datetime
as
update customers
set customer_name = @customer_name, tin = @tin, address_ = @address_, business_style = @business_style, contact_no = @contact_no, customer_type = @customer_type,  date_ = @date_
where customer_id = @customer_id return

GO
/****** Object:  StoredProcedure [dbo].[sp_update_delivery]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_delivery]
@DeliveryId int,
@deliveryStatus varchar(50)
as
update ProductsDelivery
set deliveryStatus = @deliveryStatus
where DeliveryId = @DeliveryId

GO
/****** Object:  StoredProcedure [dbo].[sp_update_products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_products]
@productID int,
@product_code varchar (50),
@product_name varchar (50),
@product_catergory varchar (50),
@product_price decimal,
@product_description varchar (50),
@date_ datetime
as
update products
set product_code = @product_code, product_name = @product_name, product_category = @product_catergory, product_price = @product_price, product_description = @product_description, date_ = @date_
where productID = @productID return

-----
GO
/****** Object:  StoredProcedure [dbo].[sp_update_reservation]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_reservation]
@ReservationId int,
@reservationStatus varchar(50)
as
update ProductsReservation
set reservationStatus = @reservationStatus
where ReservationId = @ReservationId

GO
/****** Object:  StoredProcedure [dbo].[sp_update_stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_stocks]
@stocks_id int,
@productID int,
@stock_in int,
@stock_in_date datetime
as
update stocks
set  productID = @productID, stock_in = @stock_in, stock_in_date = @stock_in_date
where stocks_id = @stocks_id

-------
GO
/****** Object:  StoredProcedure [dbo].[sp_update_stocks_pro]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_update_stocks_pro]
 @productID int,
 @stock_in int
 as
 update stocks 
 set stock_in = stock_in - @stock_in
 WHERE stocks.productID = @productID

---------
GO
/****** Object:  StoredProcedure [dbo].[sp_view_acc]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_view_acc]
as
select * from user_acc

---------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_view_customer]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_view_customer]
as
select * from customers

 
GO
/****** Object:  StoredProcedure [dbo].[sp_view_products]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_view_products]
as
select * from products

GO
/****** Object:  StoredProcedure [dbo].[sp_view_SalesReports]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_view_SalesReports]
as
select SalesReport_ID, products.productID, products.product_code, products.product_name, products.product_category, products.product_price, order_quantity, SalesReports.TotalAmount, SalesReports.transactiontype, products.product_description, customers.customer_id, User_acc.users_id, SalesReports.date_
from SalesReports inner join products on SalesReports.productID = products.productID inner join User_acc on SalesReports.users_id = User_acc.users_id
inner join customers on SalesReports.customer_id = customers.customer_id 
 
------
GO
/****** Object:  StoredProcedure [dbo].[sp_view_stocks]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_view_stocks]
as
select stocks_id, stocks.productID,  products.product_code, products.product_name, products.product_category, products.product_price, stocks.stock_in, products.product_description
from stocks inner join products on stocks.productID = products.productID
 
GO
/****** Object:  StoredProcedure [dbo].[spGenerateDogFoodProCode]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGenerateDogFoodProCode]
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID
---------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spGenerateHerbalProCode]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGenerateHerbalProCode]
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

GO
/****** Object:  StoredProcedure [dbo].[spGenerateSoapProCode]    Script Date: 9/14/2019 11:20:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGenerateSoapProCode]
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

GO
USE [master]
GO
ALTER DATABASE [LactoBioticsss] SET  READ_WRITE 
GO
