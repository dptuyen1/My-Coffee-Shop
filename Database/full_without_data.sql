USE [master]
GO
/****** Object:  Database [MyCoffeeShopDB]    Script Date: 4/27/2023 3:39:52 PM ******/
CREATE DATABASE [MyCoffeeShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyCoffeeShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyCoffeeShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyCoffeeShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyCoffeeShopDB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyCoffeeShopDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyCoffeeShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyCoffeeShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyCoffeeShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyCoffeeShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MyCoffeeShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyCoffeeShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MyCoffeeShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyCoffeeShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyCoffeeShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyCoffeeShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyCoffeeShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyCoffeeShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyCoffeeShopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyCoffeeShopDB', N'ON'
GO
ALTER DATABASE [MyCoffeeShopDB] SET QUERY_STORE = OFF
GO
USE [MyCoffeeShopDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](max) NOT NULL,
	[password] [varchar](max) NOT NULL,
	[type] [bit] NOT NULL,
	[staff_id] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[phone] [varchar](100) NULL,
	[address] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NOT NULL,
	[unit_price] [float] NOT NULL,
	[product_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[name] [nvarchar](max) NOT NULL,
	[value] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[staff_name] [nvarchar](max) NULL,
	[created_date] [date] NOT NULL,
	[total_price] [float] NOT NULL,
	[total_quantity] [int] NOT NULL,
	[discount_price] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[table_id] [int] NOT NULL,
	[shift_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[price] [float] NOT NULL,
	[path] [nvarchar](max) NULL,
	[photo] [varbinary](max) NULL,
	[category_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShiftInfo]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShiftInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[opening_time] [time](7) NOT NULL,
	[closing_time] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[phone] [varchar](100) NULL,
	[address] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableInfo]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Working]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Working](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login_time] [time](7) NOT NULL,
	[staff_id] [int] NOT NULL,
	[shift_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[Details] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[Details] ADD  DEFAULT ((0)) FOR [unit_price]
GO
ALTER TABLE [dbo].[Discount] ADD  DEFAULT ((0)) FOR [value]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [total_price]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [total_quantity]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [discount_price]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[TableInfo] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Working] ADD  DEFAULT (getdate()) FOR [login_time]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([staff_id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Details]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[Invoice] ([id])
GO
ALTER TABLE [dbo].[Details]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Discount]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([shift_id])
REFERENCES [dbo].[ShiftInfo] ([id])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([table_id])
REFERENCES [dbo].[TableInfo] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Working]  WITH CHECK ADD FOREIGN KEY([shift_id])
REFERENCES [dbo].[ShiftInfo] ([id])
GO
ALTER TABLE [dbo].[Working]  WITH CHECK ADD FOREIGN KEY([staff_id])
REFERENCES [dbo].[Staff] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_CalculateUnitPrice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CalculateUnitPrice]
AS
BEGIN
    UPDATE dbo.Details
	SET unit_price = d.quantity * p.price
	FROM dbo.Product p, dbo.Details d
	WHERE d.product_id = p.id
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteDetails]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteDetails]
(
    @invoice_id INT,
    @product_id INT
)
AS
BEGIN
    DECLARE @count INT;
    SELECT @count = quantity
    FROM dbo.Details
    WHERE invoice_id = @invoice_id
          AND product_id = @product_id;

    IF (@count = 1)
    BEGIN
        DELETE FROM dbo.Details
        WHERE invoice_id = @invoice_id
              AND product_id = @product_id;
    END;
    ELSE
    BEGIN
        UPDATE dbo.Details
        SET quantity = quantity - 1
        WHERE invoice_id = @invoice_id
              AND product_id = @product_id;
    END;
    EXEC dbo.USP_CalculateUnitPrice
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteInvoice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteInvoice] (@invoice_id INT)
AS
BEGIN
    DECLARE @count INT;

	SELECT @count = COUNT(*) FROM dbo.Details WHERE invoice_id = @invoice_id

	IF (@count = 0)
	BEGIN
	    DELETE FROM dbo.Invoice WHERE id = @invoice_id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDetailsList]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetDetailsList]
(@invoice_id INT)
AS
BEGIN
    SELECT d.invoice_id AS N'Mã hóa đơn',
           p.name AS N'Tên sản phẩm',
           p.price AS N'Giá',
           d.quantity AS N'Số lượng',
           d.unit_price AS N'Tổng tiền'
    FROM dbo.Details d,
         dbo.Product p
    WHERE d.invoice_id = @invoice_id AND d.product_id = p.id;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDiscountListByPhone]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetDiscountListByPhone] (@phone VARCHAR(100))
AS
BEGIN
    SELECT d.* FROM dbo.Discount d, dbo.Customer c WHERE (SELECT c.id WHERE phone = @phone) = d.customer_id
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInvoiceByShift]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetInvoiceByShift] (@shift_id INT)
AS
BEGIN
    SELECT i.id AS N'Mã hóa đơn',
           created_date AS N'Ngày tạo hóa đơn',
           i.staff_name AS N'Nhân viên',
           t.name AS N'Bàn',
		   s.name AS N'Ca làm việc',
           i.total_quantity AS N'Số lượng',
           total_price AS N'Tổng tiền',
           discount_price AS N'Giảm giá'
    FROM dbo.Invoice i,
         dbo.TableInfo t,
         dbo.ShiftInfo s
    WHERE i.shift_id = @shift_id
          AND i.table_id = t.id
          AND i.shift_id = s.id;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInvoiceList]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetInvoiceList]
AS
BEGIN
    SELECT i.id AS N'Mã hóa đơn',
           created_date AS N'Ngày tạo hóa đơn',
           i.staff_name AS N'Nhân viên',
           t.name AS N'Bàn',
		   s.name AS N'Ca làm việc',
           i.total_quantity AS N'Số lượng',
           total_price AS N'Tổng tiền',
           discount_price AS N'Giảm giá'
    FROM dbo.Invoice i,
         dbo.TableInfo t,
         dbo.ShiftInfo s
    WHERE i.table_id = t.id
          AND i.shift_id = s.id;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInvoiceListByDate]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetInvoiceListByDate]
(@created_date DATE)
AS
BEGIN
    SELECT i.id AS N'Mã hóa đơn',
           created_date AS N'Ngày tạo hóa đơn',
           i.staff_name AS N'Nhân viên',
           t.name AS N'Bàn',
		   s.name AS N'Ca làm việc',
           i.total_quantity AS N'Số lượng',
           total_price AS N'Tổng tiền',
           discount_price AS N'Giảm giá'
    FROM dbo.Invoice i,
         dbo.TableInfo t,
         dbo.ShiftInfo s
    WHERE i.created_date = @created_date
          AND i.table_id = t.id
          AND i.shift_id = s.id;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInvoiceListByDates]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetInvoiceListByDates]
(
    @from DATE,
    @to DATE
)
AS
BEGIN
    SELECT i.id AS N'Mã hóa đơn',
           created_date AS N'Ngày tạo hóa đơn',
           i.staff_name AS N'Nhân viên',
           t.name AS N'Bàn',
		   s.name AS N'Ca làm việc',
           i.total_quantity AS N'Số lượng',
           total_price AS N'Tổng tiền',
           discount_price AS N'Giảm giá'
    FROM dbo.Invoice i,
         dbo.TableInfo t,
         dbo.ShiftInfo s
    WHERE i.created_date <= @to
          AND i.created_date >= @from
          AND i.table_id = t.id
          AND i.shift_id = s.id;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetMenuItem]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetMenuItem] (@table_id INT, @shift_id INT)
AS
BEGIN
    SELECT *
	FROM dbo.Invoice i, dbo.Details d, dbo.Product p
	WHERE i.status = 0 AND d.product_id = p.id
	AND d.invoice_id = i.id AND i.table_id = @table_id
	AND i.shift_id = @shift_id
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetUnpaidInvoiceId]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetUnpaidInvoiceId] (@table_id INT, @shift_id INT)
AS
BEGIN
    SELECT *
	FROM dbo.Invoice
	WHERE status = 0 AND table_id = @table_id AND shift_id = @shift_id
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertAccount]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertAccount]
(@username VARCHAR(MAX), @password VARCHAR(MAX), @type BIT, @staff_id INT)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Account WHERE username COLLATE Latin1_General_CS_AI = @username)
	BEGIN
	    INSERT INTO dbo.Account
	    (
	        username,
	        password,
	        type,
	        staff_id
	    )
	    VALUES
	    (   @username,      -- username - varchar(max)
	        @password,      -- password - varchar(max)
	        @type, -- type - bit
	        @staff_id        -- staff_id - int
	        )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertCategory]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertCategory] (@name NVARCHAR(MAX))
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Category WHERE name = N'' + @name)
	BEGIN
	    INSERT INTO dbo.Category
	    (
	        name
	    )
	    VALUES
	    (N'' + @name -- name - nvarchar(max)
	        )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertCustomer]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertCustomer]
(@name NVARCHAR(MAX), @phone VARCHAR(100), @address NVARCHAR(MAX) NULL)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Customer WHERE phone = @phone)
	BEGIN
	    IF NULLIF(@address, '') IS NULL
		BEGIN
		    INSERT INTO dbo.Customer
		    (
		        name,
		        phone,
		        address
		    )
		    VALUES
		    (   N'' + @name,  -- name - nvarchar(max)
		        @phone, -- phone - varchar(100)
		        NULL  -- address - nvarchar(max)
		        )
		END

		ELSE
		BEGIN
		    INSERT INTO dbo.Customer
		(
		    name,
		    phone,
		    address
		)
		VALUES
		(   N'' + @name,  -- name - nvarchar(max)
		    @phone, -- phone - varchar(100)
		    @address  -- address - nvarchar(max)
		    )
		END
		
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertDetails]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertDetails]
(
    @invoice_id INT,
    @product_id INT
)
AS
BEGIN
    DECLARE @isExitsDetails INT;

    SELECT @isExitsDetails = COUNT(*)
    FROM dbo.Details
    WHERE invoice_id = @invoice_id
          AND product_id = @product_id;

    IF (@isExitsDetails > 0)
    BEGIN
        UPDATE dbo.Details
        SET quantity = quantity + 1
        WHERE invoice_id = @invoice_id
              AND product_id = @product_id;
    END;
    ELSE
    BEGIN
        INSERT INTO dbo.Details
        (
            quantity,
            unit_price,
            product_id,
            invoice_id
        )
        VALUES
        (   1,           -- quantity - int
            DEFAULT,     -- unit_price - float
            @product_id, -- product_id - int
            @invoice_id  -- invoice_id - int
            );
    END;
    EXEC dbo.USP_CalculateUnitPrice;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertDiscount]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertDiscount] (@name NVARCHAR(MAX), @value INT, @customer_id INT)
AS
BEGIN
	INSERT INTO dbo.Discount
	(
	    name,
	    value,
	    customer_id
	)
	VALUES
	(   N'' + @name,     -- name - nvarchar(max)
	    @value, -- value - int
	    @customer_id        -- customer_id - int
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertInvoice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertInvoice] (@table_id INT, @shift_id INT)
AS
BEGIN
    INSERT INTO dbo.Invoice
    (
        staff_name,
        created_date,
        total_price,
        total_quantity,
        discount_price,
        status,
        table_id,
        shift_id
    )
    VALUES
    (   NULL,    -- staff_name - nvarchar(max)
        DEFAULT, -- created_date - date
        DEFAULT, -- total_price - float
        DEFAULT, -- total_quantity - int
        DEFAULT, -- discount_price - float
        DEFAULT, -- status - bit
        @table_id,       -- table_id - int
        @shift_id        -- shift_id - int
    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertProduct]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertProduct]
(
    @name NVARCHAR(MAX),
    @price FLOAT,
    @img_path NVARCHAR(MAX) NULL,
    @category_id INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Product WHERE name = N'' + @name)
    BEGIN
        IF NULLIF(@img_path, '') IS NULL
        BEGIN
            INSERT INTO dbo.Product
            (
                name,
                price,
                path,
                photo,
                category_id
            )
            VALUES
            (   N'' + @name, -- name - nvarchar(max)
                @price,      -- price - float
                NULL,        -- path - nvarchar(max)
                NULL,        -- photo - varbinary(max)
                @category_id -- category_id - int
                );
        END;
        ELSE
        BEGIN
            INSERT INTO dbo.Product
            (
                name,
                price,
                path,
                photo,
                category_id
            )
            VALUES
            (   N'' + @name, -- name - nvarchar(max)
                @price,      -- price - float
                @img_path,   -- path - nvarchar(max)
                NULL,        -- photo - varbinary(max)
                @category_id -- category_id - int
                );

            DECLARE @query NVARCHAR(MAX);

            SET @query
                = N'update dbo.Product 
							set photo = (SELECT * FROM OPENROWSET(BULK ''' + @img_path
                  + N''', SINGLE_BLOB) AS img) 
							where id = (select max(id) from dbo.Product)';
            EXEC sys.sp_executesql @query;
        END;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertShift]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertShift]
(@name NVARCHAR(100), @opening_time TIME, @closing_time TIME)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM dbo.ShiftInfo WHERE name = N'' + @name)
	BEGIN
	    INSERT INTO dbo.ShiftInfo
	    (
	        name,
	        opening_time,
	        closing_time
	    )
	    VALUES
	    (   N'' + @name,        -- name - nvarchar(100)
	        @opening_time, -- opening_time - time(7)
	        @closing_time  -- closing_time - time(7)
	        )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertStaff]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertStaff]
(@name NVARCHAR(MAX), @phone VARCHAR(100) NULL, @address NVARCHAR(MAX) NULL)
AS
BEGIN
	BEGIN
	    IF NULLIF(@phone, '') IS NULL
		BEGIN
		    INSERT INTO dbo.Staff
		    (
		        name,
		        phone,
		        address
		    )
		    VALUES
		    (   N'' + @name,  -- name - nvarchar(max)
		        NULL, -- phone - varchar(100)
		        @address  -- address - nvarchar(max)
		        )
		END

		ELSE IF NULLIF(@address, '') IS NULL
		BEGIN
		    INSERT INTO dbo.Staff
		    (
		        name,
		        phone,
		        address
		    )
		    VALUES
		    (   N'' + @name,  -- name - nvarchar(max)
		        @phone, -- phone - varchar(100)
		        NULL  -- address - nvarchar(max)
		        )
		END

		ELSE
		BEGIN
		    INSERT INTO dbo.Staff
		(
		    name,
		    phone,
		    address
		)
		VALUES
		(   N'' + @name,  -- name - nvarchar(max)
		    @phone, -- phone - varchar(100)
		    @address  -- address - nvarchar(max)
		    )
		END
		
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertTable]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertTable] (@name NVARCHAR(100), @status BIT)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.TableInfo WHERE name = N'' + @name)
	BEGIN
	    INSERT INTO dbo.TableInfo
	    (
	        name,
	        status
	    )
	    VALUES
	    (   N'' + @name,    -- name - nvarchar(100)
	        @status -- status - bit
	        )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertWorking]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertWorking] (@staff_id INT, @shift_id INT)
AS
BEGIN
    DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Working

	IF (@count > 0)
	BEGIN
	    UPDATE dbo.Working SET login_time = GETDATE(), staff_id = @staff_id, shift_id = @shift_id
	END

	ELSE
	BEGIN
	    INSERT INTO dbo.Working
	    (
	        login_time,
	        staff_id,
	        shift_id
	    )
	    VALUES
	    (   DEFAULT, -- login_time - time(7)
	        @staff_id,       -- staff_id - int
	        @shift_id        -- shift_id - int
	        )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login] (@username VARCHAR(MAX), @password VARCHAR(MAX))
AS
BEGIN
    SELECT * FROM dbo.Account WHERE username COLLATE Latin1_General_CS_AI = @username AND password COLLATE Latin1_General_CS_AI = @password
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SwitchTable]
(
    @first_table_id INT,
    @second_table_id INT,
    @shift_id INT
)
AS
BEGIN
    DECLARE @first_invoice_id INT,
            @second_invoice_id INT,
            @mark_table INT = 0;

    SELECT @first_invoice_id = id
    FROM dbo.Invoice
    WHERE status = 0
          AND table_id = @first_table_id
          AND shift_id = @shift_id;

    SELECT @second_invoice_id = id
    FROM dbo.Invoice
    WHERE status = 0
          AND table_id = @second_table_id
          AND shift_id = @shift_id;

    IF (@first_invoice_id IS NULL)
    BEGIN
        SELECT @mark_table = 1;

        EXEC dbo.USP_InsertInvoice @table_id = @first_table_id, -- int
                                   @shift_id = @shift_id;       -- int


        SELECT @first_invoice_id = MAX(id)
        FROM dbo.Invoice
        WHERE status = 0
              AND table_id = @first_table_id
              AND shift_id = @shift_id;
    END;

    IF (@second_invoice_id IS NULL)
    BEGIN
        SELECT @mark_table = 2;

        EXEC dbo.USP_InsertInvoice @table_id = @second_table_id, -- int
                                   @shift_id = @shift_id;        -- int

        SELECT @second_invoice_id = MAX(id)
        FROM dbo.Invoice
        WHERE status = 0
              AND table_id = @second_table_id
              AND shift_id = @shift_id;
    END;

    SELECT id
    INTO IDTable
    FROM dbo.Details
    WHERE invoice_id = @second_invoice_id;

    UPDATE dbo.Details
    SET invoice_id = @second_invoice_id
    WHERE invoice_id = @first_invoice_id;

    UPDATE dbo.Details
    SET invoice_id = @first_invoice_id
    WHERE id IN
          (
              SELECT * FROM dbo.IDTable
          );

    DROP TABLE dbo.IDTable;

    IF (@mark_table = 1)
    BEGIN
        DELETE FROM dbo.Details
        WHERE invoice_id = @second_invoice_id;
        DELETE FROM dbo.Invoice
        WHERE id = @second_invoice_id;


        UPDATE dbo.TableInfo
        SET status = 0
        WHERE id = @second_table_id;
    END;

    ELSE IF (@mark_table = 2)
    BEGIN
        DELETE FROM dbo.Details
        WHERE invoice_id = @first_invoice_id;
        DELETE FROM dbo.Invoice
        WHERE id = @first_invoice_id;

        UPDATE dbo.TableInfo
        SET status = 0
        WHERE id = @first_table_id;
    END;

END;
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
(@username VARCHAR(MAX), @password VARCHAR(MAX), @type BIT, @staff_id INT)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Account WHERE username COLLATE Latin1_General_CS_AI = @username AND staff_id <> @staff_id)
	BEGIN
	    UPDATE dbo.Account
		SET username = @username, password = @password, type = @type
		WHERE staff_id = @staff_id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateCategory]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateCategory] (@category_id INT, @name NVARCHAR(MAX))
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Category WHERE name = N'' + @name AND id <> @category_id)
	BEGIN
	    UPDATE dbo.Category
		SET name = @name
		WHERE id = @category_id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateCustomer]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateCustomer]
(@customer_id INT, @name NVARCHAR(MAX), @phone VARCHAR(100), @address NVARCHAR(MAX) NULL)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.Customer WHERE phone = @phone AND id <> @customer_id)
	BEGIN
	    IF NULLIF(@address, '') IS NULL
		BEGIN
		    UPDATE dbo.Customer
			SET	name = @name, phone = @phone, address = NULL
			WHERE id = @customer_id
		END

		ELSE
		BEGIN
		    UPDATE dbo.Customer
			SET	name = @name, phone = @phone, address = @address
			WHERE id = @customer_id
		END
		
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateDiscount]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateDiscount] (@name NVARCHAR(MAX), @value INT, @customer_id INT)
AS
BEGIN
	UPDATE dbo.Discount
	SET name = @name, value = @value
	WHERE customer_id = @customer_id
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateInvoice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateInvoice]
(
    @invoice_id INT,
    @total_quantity INT,
    @total_price FLOAT,
    @discount_price FLOAT,
    @staff_name NVARCHAR(MAX)
)
AS
BEGIN
    UPDATE dbo.Invoice
    SET status = 1,
        total_quantity = @total_quantity,
        total_price = @total_price,
        discount_price = @discount_price,
        staff_name = @staff_name
    WHERE id = @invoice_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateProduct]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateProduct]
(
    @product_id INT,
    @name NVARCHAR(MAX),
    @price FLOAT,
    @img_path NVARCHAR(MAX) NULL,
    @category_id INT
)
AS
BEGIN

    IF NOT EXISTS
    (
        SELECT *
        FROM dbo.Product
        WHERE name = N'' + @name
              AND id <> @product_id
    )
    BEGIN
        IF NULLIF(@img_path, '') IS NULL
        BEGIN
            UPDATE dbo.Product
            SET name = N'' + @name,
                price = @price,
                path = NULL,
                photo = NULL,
                category_id = @category_id
            WHERE id = @product_id;
        END;
        ELSE
        BEGIN
            UPDATE dbo.Product
            SET name = N'' + @name,
                price = @price,
                path = @img_path,
                photo = NULL,
                category_id = @category_id
            WHERE id = @product_id;

            DECLARE @query NVARCHAR(MAX);
            SET @query = N'update dbo.Product 
		set photo = (SELECT * FROM OPENROWSET(BULK ''' + @img_path + N''', SINGLE_BLOB) AS img) 
		where id = ''' + CAST(@product_id AS NVARCHAR(MAX)) + N'''';
            EXEC sys.sp_executesql @query;
        END;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateShift]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateShift]
(@shift_id INT, @name NVARCHAR(100), @opening_time TIME, @closing_time TIME)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.ShiftInfo WHERE name = N'' + @name AND id <> @shift_id)
	BEGIN
	    UPDATE dbo.ShiftInfo
		SET name = @name, opening_time = @opening_time, closing_time = @closing_time
		WHERE id = @shift_id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateStaff]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateStaff]
(@staff_id INT, @name NVARCHAR(MAX), @phone VARCHAR(100) NULL, @address NVARCHAR(MAX) NULL)
AS
BEGIN
	BEGIN
	    IF NULLIF(@phone, '') IS NULL
		BEGIN
		    UPDATE dbo.Staff
			SET name = @name, phone = NULL, address = @address
			WHERE id = @staff_id
		END

		ELSE IF NULLIF(@address, '') IS NULL
		BEGIN
		    UPDATE dbo.Staff
			SET name = @name, phone = @phone, address = NULL
			WHERE id = @staff_id
		END

		ELSE
		BEGIN
		    UPDATE dbo.Staff
			SET name = @name, phone = @phone, address = @address
			WHERE id = @staff_id
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateTable]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateTable] (@table_id INT, @name NVARCHAR(MAX), @status BIT)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM dbo.TableInfo WHERE name = N'' + @name AND id <> @table_id)
	BEGIN
	    UPDATE dbo.TableInfo
		SET name = @name, status = @status
		WHERE id = @table_id
	END
END
GO
/****** Object:  Trigger [dbo].[UTG_UpdateDetails]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[UTG_UpdateDetails]
ON [dbo].[Details]
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @invoice_id INT;
    DECLARE @table_id INT;
    DECLARE @count INT = 0;

    IF EXISTS (SELECT * FROM Inserted)
    BEGIN
        SELECT @invoice_id = Inserted.invoice_id
        FROM Inserted;

        SELECT @table_id = table_id
        FROM dbo.Invoice
        WHERE id = @invoice_id
              AND status = 0;

        UPDATE dbo.TableInfo
        SET status = 1
        WHERE id = @table_id;
    END;

    ELSE IF EXISTS (SELECT * FROM Deleted)
    BEGIN
        SELECT @invoice_id = Deleted.invoice_id
        FROM Deleted;

        SELECT @table_id = table_id
        FROM dbo.Invoice
        WHERE id = @invoice_id
              AND status = 0;

        SELECT @count = COUNT(*)
        FROM dbo.Details
        WHERE invoice_id = @invoice_id;

        IF (@count = 0)
        BEGIN
            UPDATE dbo.TableInfo
            SET status = 0
            WHERE id = @table_id;
        END;


    END;

END;
GO
ALTER TABLE [dbo].[Details] ENABLE TRIGGER [UTG_UpdateDetails]
GO
/****** Object:  Trigger [dbo].[UTG_UpdateInvoice]    Script Date: 4/27/2023 3:39:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[UTG_UpdateInvoice]
ON [dbo].[Invoice]
FOR UPDATE, DELETE
AS
BEGIN
    DECLARE @invoice_id INT;

    SELECT @invoice_id = Inserted.id
    FROM Inserted;

    DECLARE @table_id INT,
            @shift_id INT;

    SELECT @table_id = table_id,
           @shift_id = shift_id
    FROM dbo.Invoice
    WHERE id = @invoice_id;

    DECLARE @count INT = 0;

    SELECT @count = COUNT(*)
    FROM dbo.Invoice
    WHERE status = 0
          AND table_id = @table_id
          AND shift_id = @shift_id
          AND id = @invoice_id;

    IF (@count = 0)
    BEGIN
        UPDATE dbo.TableInfo
        SET status = 0
        WHERE id = @table_id;
    END;
END;
GO
ALTER TABLE [dbo].[Invoice] ENABLE TRIGGER [UTG_UpdateInvoice]
GO
USE [master]
GO
ALTER DATABASE [MyCoffeeShopDB] SET  READ_WRITE 
GO
