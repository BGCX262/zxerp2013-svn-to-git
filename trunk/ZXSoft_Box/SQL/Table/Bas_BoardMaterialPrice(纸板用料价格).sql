
drop table [dbo].[Bas_BoardMaterialPrice]
GO

CREATE TABLE [dbo].[Bas_BoardMaterialPrice] (
	[sCustID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ͻ����
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--����
	[sBoardMaterial] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��������
	[tBeginDate] [datetime]  NOT NULL ,--�۸�ʼʱ��
	[tEndDate] [datetime]  NOT NULL ,--�۸����ʱ��
	[dMaterialPrice] [money] NULL ,--ƽ����
	[sBoardMaterialPriceNo] [varchar] (50) COLLATE Chinese_PRC_CI_AS  NULL ,--���۵���
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�޸�������
	[tModifyDate] [datetime] NULL ,--�޸�����
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
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


EXECUTE sp_addextendedproperty N'MS_Description', '���ϼ۸�����', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'ƽ����', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'dMaterialPrice'
exec sp_addextendedproperty N'MS_Description', N'�۸�ʼʱ��', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tBeginDate'
exec sp_addextendedproperty N'MS_Description', N'�۸����ʱ��', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tEndDate'
exec sp_addextendedproperty N'MS_Description', N'���۵���', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sBoardMaterialPriceNo'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�������', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸�����', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_BoardMaterialPrice', N'column', N'sMemo'
GO
sp_gettableinfo 'Bas_BoardMaterialPrice'
