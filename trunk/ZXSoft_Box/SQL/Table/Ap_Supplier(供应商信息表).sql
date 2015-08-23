--sp_gettableinfo 'Ap_Supplier'
drop table [dbo].[Ap_Supplier]
GO

CREATE TABLE [dbo].[Ap_Supplier] (
	[sSupplierID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--供应商编号
	[sSupplierName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--供应商全称
	[sSupplierShortName] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--供应商简称
	[sSupplierQk] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--助记符
	[sSupplierType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--供应商类型
	[sCharge] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--负责人
	[sLinkMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--联系人
	[sTel1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--电话1
	[sTel2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--电话2
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--传真
	[sZip] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--邮编
	[sCompAddr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--注册地址
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sPayType] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--付款方式
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--注释
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ap_Supplier] ADD 
	CONSTRAINT [PK_Ap_Supplier] PRIMARY KEY  CLUSTERED 
	(
		[sSupplierID]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '供应商信息表', N'user', N'dbo', N'table', N'Ap_Supplier', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'供应商编号', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierID'
exec sp_addextendedproperty N'MS_Description', N'供应商名称', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierName'
exec sp_addextendedproperty N'MS_Description', N'供应商简称', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierShortName'
exec sp_addextendedproperty N'MS_Description', N'助记符', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierQk'
exec sp_addextendedproperty N'MS_Description', N'供应商类型', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierType'
exec sp_addextendedproperty N'MS_Description', N'负责人', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCharge'
exec sp_addextendedproperty N'MS_Description', N'联系人', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sLinkMan'
exec sp_addextendedproperty N'MS_Description', N'电话1', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sTel1'
exec sp_addextendedproperty N'MS_Description', N'电话2', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sTel2'
exec sp_addextendedproperty N'MS_Description', N'传真', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'邮编', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sZip'
exec sp_addextendedproperty N'MS_Description', N'注册地址', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCompAddr'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'付款方式', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sPayType'
exec sp_addextendedproperty N'MS_Description', N'注释', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sMemo'



GO



sp_gettableinfo 'Ap_Supplier'

