--sp_gettableinfo 'Sys_RoleFormSet'

drop table [dbo].[Sys_RoleFormSet]
GO

CREATE TABLE [dbo].[Sys_RoleFormSet](
	[sRole][varchar](100) Not NUll,--��ɫ
	[sFormName][varchar](100) Not NUll,--�������ƣ�����dgv ��ʾΪ����-dgv�� �����Ƿ�dgv�ؼ�������ʾ������
	[sFieldName] [varchar](100) Not NUll,--�ֶ�
	[sControlName][varchar](100) Not NUll,--�ؼ�����
	[sFieldTitle] [varchar](100) NULL,--����
	[sFont] [varchar](100) NULL,--����
	[sType] [varchar](100) NULL,--��������
	[sFormat][varchar](100) NULL,--��ʾ��ʽ
	[bDataField] [bit] NULL,--�Ƿ�Ϊ������
	[bVisible] [bit] NULL,--�Ƿ���ʾ
	[bIsReadOnly] [bit] NULL,--�Ƿ�ֻ��
	[sSumType] [varchar](100) NULL,--�ϼ�����
	[sFootFormat] [varchar](100) NULL,--�ϼƸ�ʽ
	[iFitWidth] [int] NULL,--���
	[iDropDown] [int] NULL,--��������
	[sDropDownList] [varchar](1000) NULL,--��������
	[iOrder] [int] NULL,--����
	[tCreateDate] [datetime] NULL,--����ʱ��
	[sCreateName] [varchar](100) NULL,--������
	[sSqlParam][varchar](1000) NULL,--SQL��������
	[sAssignField] [varchar](4500) NULL,--��ֵ����
	[iVisCount] [int] NULL,--��������
	[bNewRecord] [bit] NULL,--�Ƿ��¼�¼
	[bFirstEmpty] [bit] NULL,--����Ϊ��
	[iDropWidth] [int] NULL,--�����б���
	[bNotEmpty] [bit] NULL,--�Ƿ�Ϊ��
	[sModifer] [varchar](100) NULL,--�޸���
	[tModifyDate] [datetime] NULL,--�޸�ʱ��
	[sActiveForm] [varchar](100) NULL,--�����
	[sActiveDll] [varchar](100) NULL,--����Dll
	[sActiveKey] [varchar](100) NULL--�������
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Sys_RoleFormSet] ADD 
	CONSTRAINT [PK_Sys_RoleFormSet] PRIMARY KEY  CLUSTERED 
	(
		[sRole],
		[sFormName],
		[sFieldName],
		[sControlName]
	)  ON [PRIMARY] 
GO
EXECUTE sp_addextendedproperty N'MS_Description', '�û���������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'��ɫ', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sRole'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFormName'
exec sp_addextendedproperty N'MS_Description', N'�ֶ���', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFieldName'
exec sp_addextendedproperty N'MS_Description', N'�ؼ�����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sControlName'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFieldTitle'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFont'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sType'
exec sp_addextendedproperty N'MS_Description', N'��ʾ��ʽ', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFormat'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ�Ϊ������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bDataField'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ���ʾ', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bVisible'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ�ֻ��', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bIsReadOnly'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sSumType'
exec sp_addextendedproperty N'MS_Description', N'�ϼƸ�ʽ', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFootFormat'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iFitWidth'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iDropDown'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sDropDownList'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iOrder'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'��ֵ����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sAssignField'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iVisCount'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ��¼�¼', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bNewRecord'
exec sp_addextendedproperty N'MS_Description', N'����Ϊ��', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bFirstEmpty'
exec sp_addextendedproperty N'MS_Description', N'�����б���', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iDropWidth'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ�Ϊ��', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bNotEmpty'
exec sp_addextendedproperty N'MS_Description', N'�޸���', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sModifer'
exec sp_addextendedproperty N'MS_Description', N'�޸�ʱ��', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveForm'
exec sp_addextendedproperty N'MS_Description', N'����Dll', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveDll'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveKey'

GO
sp_gettableinfo 'Sys_RoleFormSet'
