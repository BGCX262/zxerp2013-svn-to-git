--建立系统菜单
CREATE TABLE [SYS_Menu] (
	[sFunctionID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFunctionName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sMenuGroupID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sSortBy] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_SYS_Menu] PRIMARY KEY  CLUSTERED 
	(
		[sFunctionID],
		[sFunctionName]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO



GO



EXECUTE sp_addextendedproperty N'MS_Description', '系统菜单', N'user', N'dbo', N'table', N'SYS_Menu', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'功能ID', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sFunctionID'
exec sp_addextendedproperty N'MS_Description', N'功能名称', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sFunctionName'
exec sp_addextendedproperty N'MS_Description', N'分组功能', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sMenuGroupID'
exec sp_addextendedproperty N'MS_Description', N'排序', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sSortBy'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sMemo'
GO



