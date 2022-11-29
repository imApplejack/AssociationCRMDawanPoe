USE [CRM]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 25/11/2022 14:19:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderName] [varchar](40) NOT NULL,
	[OrderState] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT (NULL) FOR [OrderName]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT (NULL) FOR [OrderState]
GO