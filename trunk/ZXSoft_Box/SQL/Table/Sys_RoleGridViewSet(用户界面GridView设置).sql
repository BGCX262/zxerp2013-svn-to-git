--sp_gettableinfo 'Sys_RoleGridViewSet'
drop table [dbo].[Sys_RoleGridViewSet]
GO

CREATE TABLE [dbo].[Sys_RoleGridViewSet] (
			[Role] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��ɫ(Bas_Customer)
			[GridViewName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--����
			[FieldName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ֶ���
			[FieldTitle] [varchar] (50)COLLATE Chinese_PRC_CI_AS NULL,--������
			[FieldIndex] [smallint] ,--�ֶ�λ��
			[FieldWidth] [smallint] ,--�ֶο��
			[Alignment] [varchar](50) ,--�ֶζ��뷽ʽ
			[FieldColor] [varchar](50) ,--�ֶα���ɫ
			[FontSize] [varchar](50) ,--���弰��С
			[IsReadOnly] [bit] ,--�ֶ��Ƿ�ֻ��(Ĭ�Ͽ�д=1)
			[IsVisible] [bit] ,--�ֶ��Ƿ�ɼ�(Ĭ�Ͽɼ�=1)
			[ListText] [varchar](500), --�ֶ�picklist���ò�ѯ���
			[ValueType][varchar](50) --ֵ����

) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_RoleGridViewSet] ADD 
	CONSTRAINT [PK_Sys_RoleGridViewSet] PRIMARY KEY  CLUSTERED 
	(
		[Role],
		[GridViewName],
		[FieldName]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '�û�����gridview����', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'��ɫ', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'Role'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'GridViewName'
exec sp_addextendedproperty N'MS_Description', N'�ֶ���', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldName'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldTitle'
exec sp_addextendedproperty N'MS_Description', N'�ֶ�λ��', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldIndex'
exec sp_addextendedproperty N'MS_Description', N'�ֶο��', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldWidth'
exec sp_addextendedproperty N'MS_Description', N'�ֶζ��뷽ʽ', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'Alignment'
exec sp_addextendedproperty N'MS_Description', N'�ֶα���ɫ', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldColor'
exec sp_addextendedproperty N'MS_Description', N'���弰��С', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FontSize'
exec sp_addextendedproperty N'MS_Description', N'�ֶ��Ƿ�ֻ��', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'IsReadOnly'
exec sp_addextendedproperty N'MS_Description', N'�ֶ��Ƿ�ɼ�', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'IsVisible'
exec sp_addextendedproperty N'MS_Description', N'�ֶ�picklist���ò�ѯ���', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'ListText'
exec sp_addextendedproperty N'MS_Description', N'�ֶ�ֵ����', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'ValueType'
GO

