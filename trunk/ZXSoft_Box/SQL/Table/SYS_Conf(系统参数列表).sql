if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SYS_Conf]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SYS_Conf]
GO

CREATE TABLE [SYS_Conf] (
	[sConf] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sConfvalue] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_SYS_Conf] PRIMARY KEY  CLUSTERED 
	(
		[sConf]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO





EXECUTE sp_addextendedproperty N'MS_Description', '系统参数列表', N'user', N'dbo', N'table', N'SYS_Conf', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'参数', N'user', N'dbo', N'table', N'SYS_Conf', N'column', N'sConf'
exec sp_addextendedproperty N'MS_Description', N'值', N'user', N'dbo', N'table', N'SYS_Conf', N'column', N'sConfvalue'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'SYS_Conf', N'column', N'sMemo'


GO
sp_gettableinfo 'SYS_Conf'