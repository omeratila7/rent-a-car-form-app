USE [rentAcar]
GO

/****** Object:  Table [dbo].[CarInventory]    Script Date: 23.01.2021 16:29:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarInventory](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL,
	[Make] [varchar](40) NULL,
	[Model] [varchar](40) NULL,
	[Color] [varchar](10) NULL,
	[InLot] [bit] NOT NULL,
	[SysStartTime] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[SysEndTime] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
	PERIOD FOR SYSTEM_TIME ([SysStartTime], [SysEndTime])
) ON [PRIMARY]
WITH
(
SYSTEM_VERSIONING = ON ( HISTORY_TABLE = [dbo].[CarInventoryHistory] )
)
GO

ALTER TABLE [dbo].[CarInventory] ADD  DEFAULT ((1)) FOR [InLot]
GO


