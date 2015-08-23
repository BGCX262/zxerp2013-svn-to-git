
drop table [dbo].[Sal_SalesOrder]
GO

CREATE TABLE [dbo].[Sal_SalesOrder] (
	[sSO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--订单编号
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS Null,--客户编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--产品编号
	[sSOClass] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--订单类型
	[sPartTypeID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--箱型编号
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--尺寸类型
	[sLWH] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--尺寸规格
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--瓦楞
	[dL] [decimal](10,4),--长
	[dW] [decimal](10,4),--宽
	[dH] [decimal](10,4),--高
	[sBoardMaterial] [varchar] (300) COLLATE Chinese_PRC_CI_AS NULL ,--纸板用料
	[dMaterialPrice] [money]NULL,--纸板平方价
	[sCustBOM] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--客户料号
	[sCustPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--采购单号
	[sCustSubPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--采购单号
	[dUnitPrice][money]NULL ,--单价
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--税务代码
	[dOrderQty][decimal](10,4),--数量
	[tDelieryDate][datetime] NULL ,--送货时间
	[sStatus] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--订单状态
	[sSalesMan] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--业务员
	[dPrintBeforeFee][money]NULL ,--印前费
	[dPrintingFee][money]NULL ,--印刷费
	[dPrintAfterFee][money]NULL ,--印后费
	[dFinishProductFee][money]NULL ,--成品费
	[dMaterialFee][money]NULL ,--材料费
	[dProcessFee][money]NULL ,--工序费
	[sMemo][varchar](500),--说明
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sal_SalesOrder] ADD 
	CONSTRAINT [PK_Sal_SalesOrder] PRIMARY KEY  CLUSTERED 
	(
		[sSO]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '销售订单表', N'user', N'dbo', N'table', N'Sal_SalesOrder', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'订单编号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'采购单号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'箱型编号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'尺寸类型', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'尺寸规格', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sLWH'
exec sp_addextendedproperty N'MS_Description', N'长', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dL'
exec sp_addextendedproperty N'MS_Description', N'宽', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dW'
exec sp_addextendedproperty N'MS_Description', N'高', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dH'
exec sp_addextendedproperty N'MS_Description', N'纸板用料', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'客户料号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustBOM'
exec sp_addextendedproperty N'MS_Description', N'订单类别', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSOClass'
exec sp_addextendedproperty N'MS_Description', N'采购子单号', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustSubPO'
exec sp_addextendedproperty N'MS_Description', N'订单数量', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dOrderQty'
exec sp_addextendedproperty N'MS_Description', N'送货时间', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'tDeliveryDate'
exec sp_addextendedproperty N'MS_Description', N'订单状态', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'税务代码', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sTaxCode'
exec sp_addextendedproperty N'MS_Description', N'印前费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintBeforeFee'
exec sp_addextendedproperty N'MS_Description', N'印刷费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintingFee'
exec sp_addextendedproperty N'MS_Description', N'印后费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintAfterFee'
exec sp_addextendedproperty N'MS_Description', N'工序费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dProcessFee'
exec sp_addextendedproperty N'MS_Description', N'材料费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dMaterialFee'
exec sp_addextendedproperty N'MS_Description', N'成品费', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dFinishProductFee'


exec sp_addextendedproperty N'MS_Description', N'业务员', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSalesMan'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'tCreateDate'
GO
sp_gettableinfo 'Sal_SalesOrder'
