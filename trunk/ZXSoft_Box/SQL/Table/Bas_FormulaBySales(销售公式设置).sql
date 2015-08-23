--sp_gettableinfo 'Bas_FormulaBySales'
--sp_gettableinfo 'Bas_FormulaBySales'
drop table [dbo].[Bas_FormulaBySales]
GO

CREATE TABLE [dbo].[Bas_FormulaBySales] (
	[CustID] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ͻ����(Bas_Customer)
	[PartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,--���ͱ��(Bas_PartType)
	[Dimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ߴ�(Bas_DataList)
	[FluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,--����(Bas_DataList)
	[Formula] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,--���㹫ʽ
	[CreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[CreateDate] [datetime] NULL ,--����ʱ��
	[ModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�޸�������
	[ModifyDate] [datetime] NULL ,--�޸�����
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

EXECUTE sp_addextendedproperty N'MS_Description', '���۹�ʽ����', N'user', N'dbo', N'table', N'Bas_FormulaBySales', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CustID'
exec sp_addextendedproperty N'MS_Description', N'���ͱ��', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'PartTypeID'
exec sp_addextendedproperty N'MS_Description', N'�ߴ�����', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'dimension'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'FluteType'
exec sp_addextendedproperty N'MS_Description', N'���㹫ʽ', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'Formula'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'CreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�������', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'ModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸�����', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'ModifyDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_FormulaBySales', N'column', N'Memo'


GO



