USE [Db]
GO

/****** Object:  Table [dbo].[movieTb]    Script Date: 19-05-2019 13:13:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[movieTb](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movieName] [varchar](50) NULL,
	[year] [int] NULL,
	[plot] [varchar](50) NULL,
	[posterurl] [varchar](max) NULL,
	[actor1] [varchar](50) NULL,
	[actor2] [varchar](50) NULL,
	[actor3] [varchar](50) NULL,
	[producer] [varchar](50) NULL,
 CONSTRAINT [PK_movieTb] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

