--sp_gettableinfo 'Bas_Customer'
drop table [dbo].[Bas_Customer]
GO

CREATE TABLE [dbo].[Bas_Customer] (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--�ͻ����
	[sCustName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ�ȫ��
	[sCustShortName] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ����
	[sCustQk] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--���Ƿ�
	[sCustLevel] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ�����
	[sSOClass] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�������
	[sCharge] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--������
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--˰�����
	[sDept] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����
	[sLinkMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--��ϵ��
	[sTel1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�绰1
	[sTel2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�绰2
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--����
	[sZip] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�ʱ�
	[sCompAddr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--ע���ַ
	[sDeliveryAddress] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ���ַ
	[sCustArea] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ�����
	[sSalesMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--ҵ��Ա
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�޸�������
	[tModifyDate] [datetime] NULL ,--�޸�����
	[sCurrency] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--����
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--ע��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_Customer] ADD 
	CONSTRAINT [PK_Bas_Customer] PRIMARY KEY  CLUSTERED 
	(
		[sCustID]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '�ͻ���Ϣ��', N'user', N'dbo', N'table', N'Bas_Customer', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustName'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustShortName'
exec sp_addextendedproperty N'MS_Description', N'���Ƿ�', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustQk'
exec sp_addextendedproperty N'MS_Description', N'�ͻ��ȼ�', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustLevel'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sSOClass'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCharge'
exec sp_addextendedproperty N'MS_Description', N'˰�����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTaxCode'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sDept'
exec sp_addextendedproperty N'MS_Description', N'��ϵ��', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sLinkMan'
exec sp_addextendedproperty N'MS_Description', N'�绰1', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTel1'
exec sp_addextendedproperty N'MS_Description', N'�绰2', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sTel2'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'�ʱ�', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sZip'
exec sp_addextendedproperty N'MS_Description', N'ע���ַ', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCompAddr'
exec sp_addextendedproperty N'MS_Description', N'�ͻ���ַ', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sDeliveryAddress'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCustArea'
exec sp_addextendedproperty N'MS_Description', N'ҵ��Ա', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sSalesMan'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�������', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸�����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sCurrency'
exec sp_addextendedproperty N'MS_Description', N'ע��', N'user', N'dbo', N'table', N'Bas_Customer', N'column', N'sMemo'



GO
sp_gettableinfo 'Bas_Customer'





