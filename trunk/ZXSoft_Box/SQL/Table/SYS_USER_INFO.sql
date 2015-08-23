if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SYS_USER_INFO]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SYS_USER_INFO]
GO

CREATE TABLE [dbo].[SYS_USER_INFO] (
	[sUserID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sUserName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sUserNameByChinese] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sLoginPassword] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDepartment] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sRole] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sEMail] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCreateName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SYS_USER_INFO] ADD 
	CONSTRAINT [DF_SYS_USER_INFO_CreateName] DEFAULT (suser_sname(suser_sid())) FOR [sCreateName],
	CONSTRAINT [DF_SYS_USER_INFO_CreateDate] DEFAULT (convert(char(10),getdate(),120)) FOR [tCreateDate],
	CONSTRAINT [PK_SYS_USER_INFO] PRIMARY KEY  CLUSTERED 
	(
		[sUserName]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '�û���Ϣ��', N'user', N'dbo', N'table', N'SYS_USER_INFO', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�û����', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sUSERID'
exec sp_addextendedproperty N'MS_Description', N'�û�����', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sUSERName'
exec sp_addextendedproperty N'MS_Description', N'��½����', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sLoginPassword'
exec sp_addextendedproperty N'MS_Description', N'��ɫ', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sRole'
exec sp_addextendedproperty N'MS_Description', N'�����ʼ�', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sEMail'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sDepartment'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'CreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'SYS_USER_INFO', N'column', N'tCreateDate'
GO




