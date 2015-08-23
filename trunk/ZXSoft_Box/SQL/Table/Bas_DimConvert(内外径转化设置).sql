drop table [dbo].[Bas_DimConvert]--���⾶ת������
GO

CREATE TABLE [dbo].[Bas_DimConvert] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ͻ����(Bas_Customer)
	[sPartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--���ͱ��(Bas_PartType)
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--����(Bas_DataList)
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ߴ�(Bas_DataList)
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


EXECUTE sp_addextendedproperty N'MS_Description', '���⾶ת������', N'user', N'dbo', N'table', N'Bas_DimConvert', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���ͱ��', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'�ߴ�����', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraL'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraW'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'Bas_DimConvert', N'column', N'dExtraH'

go
sp_gettableinfo 'Bas_DimConvert'