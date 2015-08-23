
drop table [dbo].[PP_WorkOrderExt] ----PP 
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_WorkOrderExt] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--工单编号
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS NOT Null,--客户编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--产品编号
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
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WorkOrderExt] ADD 
	CONSTRAINT [PK_PP_WorkOrderExt] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sCustID],
		[sBOM]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '生产工单表扩展表', N'user', N'dbo', N'table', N'PP_WorkOrderExt', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sBOM'

exec sp_addextendedproperty N'MS_Description', N'箱型编号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'尺寸类型', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'尺寸规格', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sLWH'
exec sp_addextendedproperty N'MS_Description', N'瓦楞', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'长', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dL'
exec sp_addextendedproperty N'MS_Description', N'宽', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dW'
exec sp_addextendedproperty N'MS_Description', N'高', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dH'
exec sp_addextendedproperty N'MS_Description', N'纸板用料', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'用料平方价', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dMaterialPrice'
exec sp_addextendedproperty N'MS_Description', N'客户料号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustBOM'
exec sp_addextendedproperty N'MS_Description', N'采购号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'采购子单号', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustSubPO'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dUnitPrice'
GO
sp_gettableinfo 'PP_WorkOrderExt'
