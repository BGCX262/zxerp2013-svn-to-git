if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Sys_Doc]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Sys_Doc]
GO

CREATE TABLE [dbo].[Sys_Doc] (
	[Path] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[FileName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ModifyTime] [datetime] NOT NULL ,
	[UpdateTime] [datetime] NOT NULL ,
	[Memo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[Document] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_Doc] ADD 
	CONSTRAINT [PK_Sys_Doc] PRIMARY KEY  CLUSTERED 
	(
		[Path],
		[FileName],
		[ModifyTime],
		[UpdateTime]
	)  ON [PRIMARY] 
GO

GO
EXECUTE sp_addextendedproperty N'MS_Description', '文件上传列表', N'user', N'dbo', N'table', N'Sys_Doc', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'下载路径', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'Path'
exec sp_addextendedproperty N'MS_Description', N'文件名', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'FileName'
exec sp_addextendedproperty N'MS_Description', N'修改时间', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'ModifyTime'
exec sp_addextendedproperty N'MS_Description', N'上传时间', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'UpdateTime'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'Memo'
exec sp_addextendedproperty N'MS_Description', N'文件', N'user', N'dbo', N'table', N'Sys_Doc', N'column', N'Document'
go
sp_gettableinfo 'Sys_Doc'