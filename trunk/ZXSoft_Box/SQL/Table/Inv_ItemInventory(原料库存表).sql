
drop table [dbo].[Inv_ItemInventory]
GO

CREATE TABLE [dbo].[Inv_ItemInventory] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--原料条码
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--原料号
	[dInventoryQty] [decimal](10,4) ,--库存数量
	[tInDate] [datetime] ,--入库时间
	[dPrice] [money] ,--单价
	[sUOM][varchar](10),--单位
	[sLocation][varchar](10),--库存位置
	[sLocationSub][varchar](10),--库存子位置
	[sCreateName] [varchar] (10)COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_ItemInventory] ADD 
	CONSTRAINT [PK_Inv_ItemInventory] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '原料库存表', N'user', N'dbo', N'table', N'Inv_ItemInventory', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'原料号', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'原料条码', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sBarCode'

exec sp_addextendedproperty N'MS_Description', N'库存数量', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'dInventoryQty'
exec sp_addextendedproperty N'MS_Description', N'入库时间', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'tInDate'
exec sp_addextendedproperty N'MS_Description', N'单价', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'单位', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'库存位置', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sLocation'
exec sp_addextendedproperty N'MS_Description', N'库存子位置', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sLocationsub'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_ItemInventory'
