if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bas_CPMSet]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bas_CPMSet]
GO

CREATE TABLE [dbo].[Bas_CPMSet] (
	[sCPM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dPaperWidth] [decimal](18, 4) NOT NULL ,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_CPMSet] ADD 
	CONSTRAINT [PK_Bas_CPMSet] PRIMARY KEY  CLUSTERED 
	(
		[sCPM],
		[dPaperWidth]
	)  ON [PRIMARY] 
GO






EXECUTE sp_addextendedproperty N'MS_Description', '����������б�', N'user', N'dbo', N'table', N'Bas_CPMSet', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'sCPM'
exec sp_addextendedproperty N'MS_Description', N'�ŷ�', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'dPaperWidth'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�ʱ��', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸���', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_CPMSet', N'column', N'sMemo'
GO
sp_gettableinfo 'Bas_CPMSet'
