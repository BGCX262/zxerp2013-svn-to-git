
drop table [dbo].[PP_WorkOrder] ----PP 制令(Manufacture Order)
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_WorkOrder] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--工单编号
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS NOT Null,--客户编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--产品编号
	[sSO] [varchar] (20) NULL ,--订单编号
	[tProddate] [datetime] Null,--生产日期(取送货日期)
	[dProdQty][decimal](10,4)NuLL,--数量
	[dRate][decimal](10,4)NuLL,--比例
	[sStatus] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--工单状态
	[dAllowqty][decimal](10,4)NULL ,--放损量
	[dReceivedQty][decimal](10,4)NULL ,--接收量
	[sWOClass][money]NULL ,--工单类别
	[sMemo][varchar](500),--说明
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WorkOrder] ADD 
	CONSTRAINT [PK_PP_WorkOrder] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sCustID],
		[sBOM]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '生产工单表', N'user', N'dbo', N'table', N'PP_WorkOrder', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'订单编号', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'生产日期', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'tProddate'
exec sp_addextendedproperty N'MS_Description', N'生产数量', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dProdQty'
exec sp_addextendedproperty N'MS_Description', N'比例', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dRate'
exec sp_addextendedproperty N'MS_Description', N'工单状态', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'放损量', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dAllowQty'
exec sp_addextendedproperty N'MS_Description', N'入库数量', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dReceivedQty'
exec sp_addextendedproperty N'MS_Description', N'工单类别', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sWOClass'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'tCreateDate'
GO
sp_gettableinfo 'PP_WorkOrder'
