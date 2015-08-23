drop table [dbo].[Bas_DimUOMConvert]
GO

CREATE TABLE [dbo].[Bas_DimUOMConvert] (
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--尺寸单位
	[dUOMConvert] [decimal](18, 2) NOT NULL,--转化比例
	[sMemo][varchar] (20) COLLATE Chinese_PRC_CI_AS,--说明
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_DimUOMConvert] ADD 
		CONSTRAINT [PK_Bas_DimUOMConvert] PRIMARY KEY  CLUSTERED 
	(
		[sDimension]
	)  ON [PRIMARY] 
GO
EXECUTE sp_addextendedproperty N'MS_Description', '尺寸单位转化', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'尺寸单位', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'转化比例', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'dUOMConvert'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'sMemo'
go
sp_gettableinfo 'Bas_DimUOMConvert'