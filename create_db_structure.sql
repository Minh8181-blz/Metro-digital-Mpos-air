SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BasketId] [bigint] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Price] [decimal](12, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[LastUpdatedAt] [datetime] NOT NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baskets](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Customer] [nvarchar](150) NOT NULL,
	[PaysVAT] [bit] NOT NULL,
	[TotalNet] [decimal](12, 2) NOT NULL,
	[TotalGross] [decimal](12, 2) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[LastUpdatedAt] [datetime] NOT NULL
) ON [PRIMARY]
GO
