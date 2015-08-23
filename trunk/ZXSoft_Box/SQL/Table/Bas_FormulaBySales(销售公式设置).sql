--sp_gettableinfo 'Bas_FormulaBySales'
--sp_gettableinfo 'Bas_FormulaBySales'
drop table [dbo].[Bas_FormulaBySales]
GO

CREATE TABLE [dbo].[Bas_FormulaBySales] (
	[CustID] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--客户编号(Bas_Customer)
	[PartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--箱型编号(Bas_PartType)
	[Dimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--尺寸(Bas_DataList)
	[FluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--瓦楞(Bas_DataList)
	[Formula] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,--计算公式
	[CreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--创建人姓名
	[CreateDate] [datetime] NULL ,--创建时间
	[ModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--修改人姓名
	[ModifyDate] [datetime] NULL ,--修改日期
	[Memo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bas_FormulaBySales] ADD 
	CONSTRAINT [PK_Bas_FormulaBySales] PRIMARY KEY  CLUSTERED 
	(
		[CustID],
		[PartTypeID],
		[Dimension],
		[FluteType]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '销售公式设置', N'user', N'dbo', N'table', N'Bas_FormulaBySales', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CustID'
exec sp_addextendedproperty N'MS_Description', N'箱型编号', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'PartTypeID'
exec sp_addextendedproperty N'MS_Description', N'尺寸类型', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'dimension'
exec sp_addextendedproperty N'MS_Description', N'瓦楞', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'FluteType'
exec sp_addextendedproperty N'MS_Description', N'计算公式', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'Formula'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CreateDate'
exec sp_addextendedproperty N'MS_Description', N'修改人姓名', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'ModifierName'
exec sp_addextendedproperty N'MS_Description', N'修改日期', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'ModifyDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'Memo'


GO



