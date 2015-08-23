drop table [dbo].[Bas_DimConvert]--内外径转化设置
GO

CREATE TABLE [dbo].[Bas_DimConvert] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--客户编号(Bas_Customer)
	[sPartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--箱型编号(Bas_PartType)
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--瓦楞(Bas_DataList)
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--尺寸(Bas_DataList)
	[dExtraL] [decimal](18, 4) NOT NULL ,
	[dExtraW] [decimal](18, 4) NOT NULL ,
	[dExtraH] [decimal](18, 4) NOT NULL 
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bas_DimConvert] ADD 
	CONSTRAINT [DF_Bas_DimConvert_ExtraL] DEFAULT (0) FOR [dExtraL],
	CONSTRAINT [DF_Bas_DimConvert_ExtraW] DEFAULT (0) FOR [dExtraW],
	CONSTRAINT [DF_Bas_DimConvert_ExtraH] DEFAULT (0) FOR [dExtraH],
	CONSTRAINT [PK_Bas_DimConvert] PRIMARY KEY  CLUSTERED 
	(
		[sCustID],
		[sPartTypeID],
		[sFluteType],
		[sDimension]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '内外径转化设置', N'user', N'dbo', N'table', N'Bas_DimConvert', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'客户编号', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'产品类型编号', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'瓦楞', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'尺寸类型', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'长(附加)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraL'
exec sp_addextendedproperty N'MS_Description', N'宽(附加)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraW'
exec sp_addextendedproperty N'MS_Description', N'高(附加)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraH'

go
sp_gettableinfo 'Bas_DimConvert'