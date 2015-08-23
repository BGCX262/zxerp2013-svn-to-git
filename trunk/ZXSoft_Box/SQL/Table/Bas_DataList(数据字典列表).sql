--sp_gettableinfo 'Bas_DataList'
drop table [dbo].[Bas_DataList]
GO

CREATE TABLE [Bas_DataList] (
	[sClass] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sValue] [varchar] (200) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sOrderNo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_Bas_DataList] PRIMARY KEY  CLUSTERED 
	(
		[sClassValue],
		[sClass]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO


EXECUTE sp_addextendedproperty N'MS_Description', '数据字典列表(存放List列表)', N'user', N'dbo', N'table', N'Bas_DataList', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'分类', N'user', N'dbo', N'table', N'Bas_DataList', N'column', N'sClass'
exec sp_addextendedproperty N'MS_Description', N'值', N'user', N'dbo', N'table', N'Bas_DataList', N'column', N'sValue'
exec sp_addextendedproperty N'MS_Description', N'排序编号', N'user', N'dbo', N'table', N'Bas_DataList', N'column', N'sOrderNo'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Bas_DataList', N'column', N'sMemo'


GO



