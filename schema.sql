USE [MerchantDb]
GO

/****** Object:  Table [dbo].[Merchant]    Script Date: 6/03/2017 9:48:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Merchant](
	[_id] [varchar](100) NOT NULL,
	[display_name] [varchar](100) NOT NULL,
	[date_created] [datetime] NULL,
	[date_modified] [datetime] NULL,
	[email] [varchar](50) NOT NULL,
	[logo] [varchar](500) NULL,
	[phone] [varchar](15) NULL,
	[registered_name] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_Merchant] PRIMARY KEY CLUSTERED 
(
	[_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


