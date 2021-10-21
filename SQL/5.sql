USE [rentAcar]
GO

/****** Object:  Trigger [dbo].[contratCreater]    Script Date: 23.01.2021 16:30:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[contratCreater]
ON [dbo].[Contracts] 
AFTER INSERT, UPDATE
AS
BEGIN
DECLARE @Carid int
DECLARE @Customerid int
SELECT  @Carid = CarId , @Customerid=CustemerId from inserted
UPDATE CarInventory SET InLot = ~InLot WHERE CarId = @Carid
UPDATE Customers SET haveActiveRent= ~haveActiveRent WHERE CustomerId= @Customerid
END
GO

ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [contratCreater]
GO


20:21e bak