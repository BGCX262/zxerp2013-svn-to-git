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





EXECUTE sp_addextendedproperty N'MS_Description', '�û�Ȩ������', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'��ɫ', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sRole'
exec sp_addextendedproperty N'MS_Description', N'���ܱ��', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sFunctionID'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sFunctionName'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ���Ч', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'iValidFlag'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'����Ա', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'sOperator'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'SYS_USER_AUTHORITY', N'column', N'tCreateDate'

GO