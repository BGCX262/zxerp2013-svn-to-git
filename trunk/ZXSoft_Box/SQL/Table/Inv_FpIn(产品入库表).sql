
drop table [dbo].[Inv_FpIn]
GO

CREATE TABLE [dbo].[Inv_FpIn] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--成品条码
	[iBarCodeCount][integer]NOT NULL ,--条码次数
	[sSO] [varchar](20)COLLATE Chinese_PRC_CI_AS,--销售单
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--原料号
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--原料号
	[sInType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--入库类型
	[sInBill] [varchar] (10) COLLATE Chinese_PRC_CI_AS ,--入库单号
	[dInQty] [decimal](10,4) ,--入库数量
	[tInDate] [datetime] ,--入库时间
	[dPrice] [money] ,--单价
	[sUOM][varchar](10),--单位
	[sLocation][varchar](10),--库存位置
	[sLocationSub][varchar](10),--库存子位置
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_FpIn] ADD 
	CONSTRAINT [PK_Inv_FpIn] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[iBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '产品入库表', N'user', N'dbo', N'table', N'Inv_FpIn', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'成品条码', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'条码次数', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'销售单', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'入库类型', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sInType'
exec sp_addextendedproperty N'MS_Description', N'入库单号', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sInBill'
exec sp_addextendedproperty N'MS_Description', N'入库数量', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'dInQty'
exec sp_addextendedproperty N'MS_Description', N'入库时间', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'tInDate'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'单位', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'库存位置', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sLocation'
exec sp_addextendedproperty N'MS_Description', N'库存子位置', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sLocationSub'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Inv_FpIn', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_FpIn'
