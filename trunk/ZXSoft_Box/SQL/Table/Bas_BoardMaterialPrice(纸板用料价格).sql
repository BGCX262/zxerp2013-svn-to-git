
drop table [dbo].[Bas_BoardMaterialPrice]
GO

CREATE TABLE [dbo].[Bas_BoardMaterialPrice] (
	[sCustID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--客户编号
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--瓦楞
	[sBoardMaterial] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--生产用料
	[tBeginDate] [datetime]  NOT NULL ,--价格开始时间
	[tEndDate] [datetime]  NOT NULL ,--价格结束时间
	[dMaterialPrice] [money] NULL ,--平方价
	[sBoardMaterialPriceNo] [varchar] (50) COLLATE Chinese_PRC_CI_AS  NULL ,--报价单号
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--修改人姓名
	[tModifyDate] [datetime] NULL ,--修改日期
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_BoardMaterialPrice] ADD 
	CONSTRAINT [PK_Bas_BoardMaterialPrice] PRIMARY KEY  CLUSTERED 
	(
		[sCustID],
		[sFluteType],
		[sBoardMaterial],
		[tBeginDate],
		[tEndDate]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '用料价格设置', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'瓦楞', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'生产用料', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'平方价', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'dMaterialPrice'
exec sp_addextendedproperty N'MS_Description', N'价格开始时间', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tBeginDate'
exec sp_addextendedproperty N'MS_Description', N'价格结束时间', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tEndDate'
exec sp_addextendedproperty N'MS_Description', N'报价单号', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sBoardMaterialPriceNo'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'修改人姓名', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'修改日期', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sMemo'
GO
sp_gettableinfo 'Bas_BoardMaterialPrice'
