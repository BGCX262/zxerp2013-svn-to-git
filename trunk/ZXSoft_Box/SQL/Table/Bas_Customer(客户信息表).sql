--sp_gettableinfo 'Bas_Customer'
drop table [dbo].[Bas_Customer]
GO

CREATE TABLE [dbo].[Bas_Customer] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--客户编号
	[sCustName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--客户全称
	[sCustShortName] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--客户简称
	[sCustQk] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--助记符
	[sCustLevel] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--客户级别
	[sSOClass] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--订单类别
	[sCharge] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--负责人
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--税务代码
	[sDept] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--部门
	[sLinkMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--联系人
	[sTel1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--电话1
	[sTel2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--电话2
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--传真
	[sZip] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--邮编
	[sCompAddr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--注册地址
	[sDeliveryAddress] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--送货地址
	[sCustArea] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--客户区域
	[sSalesMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--业务员
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--修改人姓名
	[tModifyDate] [datetime] NULL ,--修改日期
	[sCurrency] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--币种
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--注释
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_Customer] ADD 
	CONSTRAINT [PK_Bas_Customer] PRIMARY KEY  CLUSTERED 
	(
		[sCustID]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '客户信息表', N'user', N'dbo', N'table', N'Bas_Customer', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'客户名称', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustName'
exec sp_addextendedproperty N'MS_Description', N'客户简称', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustShortName'
exec sp_addextendedproperty N'MS_Description', N'助记符', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustQk'
exec sp_addextendedproperty N'MS_Description', N'客户等级', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustLevel'
exec sp_addextendedproperty N'MS_Description', N'订单类别', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sSOClass'
exec sp_addextendedproperty N'MS_Description', N'负责人', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCharge'
exec sp_addextendedproperty N'MS_Description', N'税务代码', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTaxCode'
exec sp_addextendedproperty N'MS_Description', N'部门', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sDept'
exec sp_addextendedproperty N'MS_Description', N'联系人', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sLinkMan'
exec sp_addextendedproperty N'MS_Description', N'电话1', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTel1'
exec sp_addextendedproperty N'MS_Description', N'电话2', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTel2'
exec sp_addextendedproperty N'MS_Description', N'传真', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'邮编', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sZip'
exec sp_addextendedproperty N'MS_Description', N'注册地址', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCompAddr'
exec sp_addextendedproperty N'MS_Description', N'送货地址', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sDeliveryAddress'
exec sp_addextendedproperty N'MS_Description', N'客户区域', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustArea'
exec sp_addextendedproperty N'MS_Description', N'业务员', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sSalesMan'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'修改人姓名', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'修改日期', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'币种', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCurrency'
exec sp_addextendedproperty N'MS_Description', N'注释', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sMemo'



GO
sp_gettableinfo 'Bas_Customer'





