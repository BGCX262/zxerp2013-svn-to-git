
drop table [dbo].[Inv_ItemOut]
GO

CREATE TABLE [dbo].[Inv_ItemOut] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--原料条码
	[iBarCodeCount][integer]NOT NULL ,--条码次数
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--原料号
	[sOutType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--出库类型
	[sOutBill] [varchar] (20) COLLATE Chinese_PRC_CI_AS ,--出库单号
	[dOldQty] [decimal](10,4) ,--原库存数量	
	[dOutQty] [decimal](10,4) ,--出库数量
	[sOutForUse] [varchar](20),--出库用途
	[tOutDate] [datetime] ,--出库时间
	[dPrice] [money] ,--单价
	[sUOM][varchar](10),--单位
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_ItemOut] ADD 
	CONSTRAINT [PK_Inv_ItemOut] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[iBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '原料出库表', N'user', N'dbo', N'table', N'Inv_ItemOut', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'原料号', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'原料条码', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'条码次数', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'出库类型', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutType'
exec sp_addextendedproperty N'MS_Description', N'出库单号', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutBill'
exec sp_addextendedproperty N'MS_Description', N'原库存数量', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dOldQty'
exec sp_addextendedproperty N'MS_Description', N'出库数量', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dOutQty'
exec sp_addextendedproperty N'MS_Description', N'出库用途', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutForUse'
exec sp_addextendedproperty N'MS_Description', N'出库时间', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'tOutDate'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'单位', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_ItemOut'
