if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SYS_FUNCTIONS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SYS_FUNCTIONS]
GO

CREATE TABLE [dbo].[SYS_FUNCTIONS] (
	[sFunctionID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFunctionName] [varchar] (200) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sDllPath] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[sFunctionNameSpace] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[sFunctionICO] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[sHelpPath] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SYS_FUNCTIONS] ADD 
	CONSTRAINT [PK_SYS_FUNCTIONS] PRIMARY KEY  CLUSTERED 
	(
		[sFunctionID],
		[sFunctionName]
	)  ON [PRIMARY] 
GO




EXECUTE sp_addextendedproperty N'MS_Description', '系统功能列表', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'功能编号', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sFunctionID'
exec sp_addextendedproperty N'MS_Description', N'功能名称', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sFunctionName'
exec sp_addextendedproperty N'MS_Description', N'文件路径', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sDllPath'
exec sp_addextendedproperty N'MS_Description', N'命名空间', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sFunctionNameSpace'
exec sp_addextendedproperty N'MS_Description', N'图标', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sFunctionICO'
exec sp_addextendedproperty N'MS_Description', N'帮助路径', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'sHelpPath'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'SYS_FUNCTIONS', N'column', N'tCreateDate'
GO
