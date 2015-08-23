--sp_gettableinfo 'Bas_FormulaByWorking'
--sp_gettableinfo 'Bas_FormulaByWorking'
drop table [dbo].[Bas_FormulaByWorking]
GO

CREATE TABLE [Bas_FormulaByWorking] (
	[sCustID] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFormulaName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sPartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sFormula] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [DF_Bas_FormulaByWorking_sPartTypeID] DEFAULT ('') FOR [sPartTypeID],
	CONSTRAINT [DF_Bas_FormulaByWorking_sFluteType] DEFAULT ('') FOR [sFluteType],
	CONSTRAINT [PK_Bas_FormulaByWorking] PRIMARY KEY  CLUSTERED 
	(
		[sCustID],
		[sFormulaName],
		[sPartTypeID],
		[sFluteType]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO



EXECUTE sp_addextendedproperty N'MS_Description', '������ʽ����', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'�ֶ�����', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sFormulaName'
exec sp_addextendedproperty N'MS_Description', N'���ͱ��', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'���㹫ʽ', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sFormula'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�������', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸�����', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_FormulaByWorking', N'column', N'sMemo'


GO



sp_gettableinfo 'Bas_FormulaByWorking'
