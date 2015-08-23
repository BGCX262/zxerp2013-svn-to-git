--sp_gettableinfo 'Ap_Cooperation'
drop table [dbo].[Ap_Cooperation]
GO

CREATE TABLE [dbo].[Ap_Cooperation] (	

	[sSO][varchar] (20) COLLATE Chinese_PRC_CI_AS Not NULL ,--订单编号
	[iSOCount][int] Not NULL,--订单采购次数	
	[sPO][varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--外协编号
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--供应商编号
	[sSupplierID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--供应商编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--产品编号
	[dPOPrice] [money] NULL ,--采购平方价
	[dPOUnitPrice][money]NULL ,--采购单价
	[dPOQty][decimal](10,4),--数量
	[dPOCRL][decimal](10, 4),--采购开料长
	[dPOCRW][decimal](10, 4),--采购开料宽
	[dCRL][decimal](10, 4),--开料长
	[dCRW][decimal](10, 4),--开料宽
	[sCLineL][varchar](100),--长压线CreasingLineL
	[sCLineW][varchar](100),--宽压线CreasingLineW
	[tDfpDate] [datetime] NULL ,--送货时间
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--注释
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ap_Cooperation] ADD 
	CONSTRAINT [PK_Ap_Cooperation] PRIMARY KEY  CLUSTERED 
	(
		[sSO],
		[iSOCount]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '供应商信息表', N'user', N'dbo', N'table', N'Ap_Cooperation', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'订单编号', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'订单采购次数', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'iSOCount'

exec sp_addextendedproperty N'MS_Description', N'外协编号', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sPO'
exec sp_addextendedproperty N'MS_Description', N'供应商编号', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sSupplierID'
exec sp_addextendedproperty N'MS_Description', N'客户ID', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'采购平方价', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOPrice'
exec sp_addextendedproperty N'MS_Description', N'采购单价', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'数量', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOQty'
exec sp_addextendedproperty N'MS_Description', N'采购开料长', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOCRL'
exec sp_addextendedproperty N'MS_Description', N'采购开料宽', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOCRW'
exec sp_addextendedproperty N'MS_Description', N'开料长', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dCRL'
exec sp_addextendedproperty N'MS_Description', N'开料宽', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dCRW'
exec sp_addextendedproperty N'MS_Description', N'长压线:CreasingLineL', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCLineL'
exec sp_addextendedproperty N'MS_Description', N'宽压线:CreasingLineW', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCLineW'
exec sp_addextendedproperty N'MS_Description', N'送货时间', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'tDfpDate'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'注释', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sMemo'



GO



sp_gettableinfo 'Ap_Cooperation'

