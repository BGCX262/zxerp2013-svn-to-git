if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SYS_USER_AUTHORITY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SYS_USER_AUTHORITY]
GO

CREATE TABLE [dbo].[SYS_USER_AUTHORITY] (
	[sRole] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFunctionID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFunctionName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[iValidFlag] [int] NULL ,
	[sMemo] [varchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[sOperator] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SYS_USER_AUTHORITY] ADD 
	CONSTRAINT [PK_SYS_USER_AUTHORITY] PRIMARY KEY  CLUSTERED 
	(
		[sRole],
		[sFunctionID]
	)  ON [PRIMARY] 
GO





EXECUTE sp_addextendedproperty N'MS_Description', '用户权限设置', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'角色', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sRole'
exec sp_addextendedproperty N'MS_Description', N'功能编号', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sFunctionID'
exec sp_addextendedproperty N'MS_Description', N'功能名称', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sFunctionName'
exec sp_addextendedproperty N'MS_Description', N'是否有效', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'iValidFlag'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'操作员', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sOperator'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'tCreateDate'

GO