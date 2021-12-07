CREATE TABLE [dbo].[directory]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY,
	[user_id] [varchar](50) NULL,
	[f_name] [nvarchar](20) NULL,
	[l_name] [nvarchar](20) NULL,
	[name_for_print] [nvarchar](30) NULL,
	[gender_id] INT NULL ,
	[prefix_id] INT NULL ,
	[mail] [varchar](40) NOT NULL,
	[mail2] [varchar](40) NULL,
	[cellphone] [nvarchar](20) NULL,
	
	[id_number] [nvarchar](20) NULL,
	[en_f_name] [nvarchar](20) NULL,
	[en_l_name] [nvarchar](20) NULL,
	[birth_date] [date] NULL,
	[job_address] [nvarchar](50) NULL,
	[home_address] [nvarchar](50) NULL,
	[home_phone] [nvarchar](20) NULL,
	[job_phone] [nvarchar](20) NULL,
	[organization] [nvarchar](20) NULL,
	[following_by] [nvarchar](250) NULL,
	[is_active] [bit] NOT NULL DEFAULT 1,
	[insert_date] [datetime] NOT NULL DEFAULT getdate() ,
	[insert_user_id] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user_id] [nvarchar](50) NULL,
	CONSTRAINT FK_active_dir_To_prefix FOREIGN KEY (prefix_id) REFERENCES [dbo].[prefixes] ([id]),
	CONSTRAINT FK_active_dir_To_gender FOREIGN KEY (gender_id) REFERENCES [dbo].[gender] ([id]),
	
)

GO

CREATE INDEX [IX_user_id] ON [dbo].[directory] ([user_id])


GO

CREATE INDEX [IX_name_for_print] ON [dbo].[directory] ([name_for_print])
