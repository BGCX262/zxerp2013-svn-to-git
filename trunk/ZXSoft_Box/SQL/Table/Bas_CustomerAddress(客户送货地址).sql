if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bas_CustomerAddress]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bas_CustomerAddress]
GO

CREATE TABLE [dbo].[Bas_CustomerAddress] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[iAddrNo] [smallint] NOT NULL ,
	[sPersonName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDeliveryAddress] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDeliveryPostCode] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sPhone] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMobilePhone] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sEmail] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_CustomerAddress] ADD 
	CONSTRAINT [PK_Bas_CustomerAddress] PRIMARY KEY  CLUSTERED 
	(
		[sCustID],
		[iAddrNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Bas_CustomerAddress] ADD 
	CONSTRAINT [FK_Bas_CustomerAddress_Bas_Customer] FOREIGN KEY 
	(
		[sCustID]
	) REFERENCES [dbo].[Bas_Customer] (
		[sCustID]
	)
GO


EXECUTE sp_addextendedproperty N'MS_Description', '�ͻ��ͻ���ַ', N'user', N'dbo', N'table', N'Bas_CustomerAddress', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��ַ���', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'iAddrNo'
exec sp_addextendedproperty N'MS_Description', N'��ϵ��', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sPersonName'
exec sp_addextendedproperty N'MS_Description', N'�ͻ���ַ', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sDeliveryAddress'
exec sp_addextendedproperty N'MS_Description', N'�ʱ�', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sDeliveryPostCode'
exec sp_addextendedproperty N'MS_Description', N'�绰', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sPhone'
exec sp_addextendedproperty N'MS_Description', N'�ֻ�', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sMobilePhone'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'EMail', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sEmail'
exec sp_addextendedproperty N'MS_Description', N'ע��', N'user', N'dbo', N'table', N'Bas_CustomerAddress', N'column', N'sMemo'



GO
sp_gettableinfo 'Bas_CustomerAddress'

