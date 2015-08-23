if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bas_CustomerContact]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bas_CustomerContact]
GO

CREATE TABLE [dbo].[Bas_CustomerContact] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sPersonName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sJobTitle] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sMobilePhone] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sPhone] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sEmail] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (30) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_CustomerContact] ADD 
	CONSTRAINT [PK_Bas_CustomerContact] PRIMARY KEY  CLUSTERED 
	(
		[sCustID],
		[sPersonName],
		[sJobTitle]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Bas_CustomerContact] ADD 
	CONSTRAINT [FK_Bas_CustomerContact_Bas_Customer] FOREIGN KEY 
	(
		[sCustID]
	) REFERENCES [dbo].[Bas_Customer] (
		[sCustID]
	)
GO




EXECUTE sp_addextendedproperty N'MS_Description', '客户联系人', N'user', N'dbo', N'table', N'Bas_CustomerContact', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'联系人', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sPersonName'
exec sp_addextendedproperty N'MS_Description', N'工作职务', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sJobTitle'
exec sp_addextendedproperty N'MS_Description', N'手机', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sMobilePhone'
exec sp_addextendedproperty N'MS_Description', N'电话', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sPhone'
exec sp_addextendedproperty N'MS_Description', N'传真', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'EMail', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sEmail'
exec sp_addextendedproperty N'MS_Description', N'注释', N'user', N'dbo', N'table', N'Bas_CustomerContact', N'column', N'sMemo'



GO
sp_gettableinfo 'Bas_CustomerContact'

