drop TABLE [Bas_PartType]
go
CREATE TABLE [Bas_PartType] (
	[sPartTypeID] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sPartTypeName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[sPartTypeStruct][varchar] (250) COLLATE Chinese_PRC_CI_AS NULL ,
	[sClassGroup1] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sClassGroup2] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sClassGroup3] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCreateDate] [datetime] NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_Bas_PartType] PRIMARY KEY  CLUSTERED 
	(
		[PartTypeID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bas_PartType] ADD 
	CONSTRAINT [PK_Bas_PartType] PRIMARY KEY  CLUSTERED 
	(
		[sPartTypeID]
	)  ON [PRIMARY] 
GO


GO

EXECUTE sp_addextendedproperty N'MS_Description', '��Ʒ����(����)', N'user', N'dbo', N'table', N'Bas_PartType', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'���ͱ��', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sPartTypeName'
exec sp_addextendedproperty N'MS_Description', N'���ͽṹ', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sPartTypeStruct'
exec sp_addextendedproperty N'MS_Description', N'����1', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sClassGroup1'
exec sp_addextendedproperty N'MS_Description', N'����2', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sClassGroup2'
exec sp_addextendedproperty N'MS_Description', N'����3', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sClassGroup3'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�������', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸�����', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'ע��', N'user', N'dbo', N'table', N'Bas_PartType', N'column', N'sMemo'
