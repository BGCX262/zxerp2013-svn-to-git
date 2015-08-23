--����ϵͳ�˵�
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



EXECUTE sp_addextendedproperty N'MS_Description', 'ϵͳ�˵�', N'user', N'dbo', N'table', N'SYS_Menu', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'����ID', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sFunctionID'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sFunctionName'
exec sp_addextendedproperty N'MS_Description', N'���鹦��', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sMenuGroupID'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sSortBy'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'SYS_Menu', N'column', N'sMemo'
GO



