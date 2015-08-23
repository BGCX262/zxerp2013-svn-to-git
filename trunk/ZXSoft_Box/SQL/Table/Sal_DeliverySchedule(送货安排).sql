
drop table [dbo].[Sal_DeliverySchedule]
GO

CREATE TABLE [dbo].[Sal_DeliverySchedule] (
	[sSO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--订单编号
	[dSOCount][int] NOT NULL ,--订单次数
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS ,--客户编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--产品编号
	[sCustPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--采购单号
	[dUnitPrice][money]NULL ,--单价
	[dDeliveryQty][decimal](10,4),--数量
	[tDfpDate] [datetime] NULL ,--送货时间
	[tOrgDfpDate] [datetime] NULL ,--原送货时间
	[sAddress][varchar](100),--地址
	[sDO][varchar](20),--送货单号
	[sDriver][varchar](20),--司机
	[dAcceptQty][decimal](10,4),--接受数量
	[sMemo][varchar](500),--说明
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sal_DeliverySchedule] ADD 
	CONSTRAINT [PK_Sal_DeliverySchedule] PRIMARY KEY  CLUSTERED 
	(
		[sSO],
		[dSOCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '送货表', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'订单编号', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'次数', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dSOCount'

exec sp_addextendedproperty N'MS_Description', N'采购单号', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'送货地址', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sAddress'
exec sp_addextendedproperty N'MS_Description', N'送货单号', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sDO'
exec sp_addextendedproperty N'MS_Description', N'司机', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sDriver'
exec sp_addextendedproperty N'MS_Description', N'数量', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dDeliveryQty'
exec sp_addextendedproperty N'MS_Description', N'送货日期', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tDfpDate'
exec sp_addextendedproperty N'MS_Description', N'计划日期', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tOrgDfpDate'
exec sp_addextendedproperty N'MS_Description', N'接受数量', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dAcceptQty'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tCreateDate'
GO
sp_gettableinfo 'Sal_DeliverySchedule'


--EXEC sp_dropextendedproperty 'MS_Description','user',dbo,'table','Sal_DeliverySchedule','column',OrgDfpDate 

