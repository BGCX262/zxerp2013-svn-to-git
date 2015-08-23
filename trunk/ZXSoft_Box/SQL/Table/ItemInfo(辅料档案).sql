
drop table [dbo].[ItemInfo]
GO

CREATE TABLE [dbo].[ItemInfo] (
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS not Null,--辅料编号
	[sItemName] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--辅料名称
	[sItemSpec] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--辅料规格(Specification)
	[sClassGroup1][varchar](50)COLLATE Chinese_PRC_CI_AS,--一级分类
	[sClassGroup2][varchar](50)COLLATE Chinese_PRC_CI_AS,--二级分类
	[sClassGroup3][varchar](50)COLLATE Chinese_PRC_CI_AS,--三级分类
	[sUOM][varchar](10),--单位
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItemInfo] ADD 
	CONSTRAINT [PK_ItemInfo] PRIMARY KEY  CLUSTERED 
	(
		[sItem]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '辅料档案', N'user', N'dbo', N'table', N'ItemInfo', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'辅料编号', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'辅料名称', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItemName'
exec sp_addextendedproperty N'MS_Description', N'辅料规格', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItemSpec'
exec sp_addextendedproperty N'MS_Description', N'一级分类', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup1'
exec sp_addextendedproperty N'MS_Description', N'二级分类', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup2'
exec sp_addextendedproperty N'MS_Description', N'三级分类', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup3'
exec sp_addextendedproperty N'MS_Description', N'单位', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sMemo'
GO
sp_gettableinfo 'ItemInfo'
