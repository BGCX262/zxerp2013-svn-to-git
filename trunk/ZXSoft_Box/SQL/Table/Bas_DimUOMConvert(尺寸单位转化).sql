drop table [dbo].[Bas_DimUOMConvert]
GO

CREATE TABLE [dbo].[Bas_DimUOMConvert] (
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ߴ絥λ
	[dUOMConvert] [decimal](18, 2) NOT NULL,--ת������
	[sMemo][varchar] (20) COLLATE Chinese_PRC_CI_AS,--˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_DimUOMConvert] ADD 
		CONSTRAINT [PK_Bas_DimUOMConvert] PRIMARY KEY  CLUSTERED 
	(
		[sDimension]
	)  ON [PRIMARY] 
GO
EXECUTE sp_addextendedproperty N'MS_Description', '�ߴ絥λת��', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ߴ絥λ', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'ת������', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'dUOMConvert'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_DimUOMConvert', N'column', N'sMemo'
go
sp_gettableinfo 'Bas_DimUOMConvert'