USE [rentAcar]
GO

/****** Object:  Table [dbo].[Contracts]    Script Date: 23.01.2021 16:29:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contracts](
	[ContractsId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[CustemerId] [int] NOT NULL,
	[Price] [int] NULL,
	[RentDate] [datetime2](7) NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContractsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Contracts] ADD  CONSTRAINT [DF_Contracts_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[CarInventory] ([CarId])
GO

ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([CustemerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO


