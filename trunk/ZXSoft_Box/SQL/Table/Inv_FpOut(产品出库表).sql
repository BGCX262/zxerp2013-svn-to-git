
drop table [dbo].[Inv_FpOut]
GO

CREATE TABLE [dbo].[Inv_FpOut] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--产品条码
	[iBarCodeCount][integer]NOT NULL ,--条码次数
	[sSO] [varchar](20)COLLATE Chinese_PRC_CI_AS,--销售单
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--产品编号号
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--客户编号
	[sOutType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--出库类型
	[sOutBill] [varchar] (10) COLLATE Chinese_PRC_CI_AS ,--出库单号
	[dOutQty] [decimal](10,4) ,--出库数量
	[tOutDate] [datetime] ,--出库时间
	[dPrice] [money] ,--单价
	[sUOM][varchar](10),--单位
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_FpOut] ADD 
	CONSTRAINT [PK_Inv_FpOut] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[siBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '产品出库表', N'user', N'dbo', N'table', N'Inv_FpOut', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'产品条码', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'条码次数', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'销售单', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'出库类型', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sOutType'
exec sp_addextendedproperty N'MS_Description', N'出库单号', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sOutBill'
exec sp_addextendedproperty N'MS_Description', N'出库数量', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dOutQty'
exec sp_addextendedproperty N'MS_Description', N'出库时间', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'tOutDate'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'单位', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_FpOut'
