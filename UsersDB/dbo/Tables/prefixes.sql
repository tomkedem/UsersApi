CREATE TABLE [dbo].[prefixes]
(
	[id] INT NOT NULL PRIMARY KEY,
	[description] [nvarchar](50) NULL,
	[is_hidden] [bit] NOT NULL DEFAULT 0 
)