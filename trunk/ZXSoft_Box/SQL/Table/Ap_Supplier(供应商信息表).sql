--sp_gettableinfo 'Ap_Supplier'
drop table [dbo].[Ap_Supplier]
GO

CREATE TABLE [dbo].[Ap_Supplier] (
	[sSupplierID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ӧ�̱��
	[sSupplierName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--��Ӧ��ȫ��
	[sSupplierShortName] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Ӧ�̼��
	[sSupplierQk] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--���Ƿ�
	[sSupplierType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--��Ӧ������
	[sCharge] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--������
	[sLinkMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--��ϵ��
	[sTel1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�绰1
	[sTel2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�绰2
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--����
	[sZip] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--�ʱ�
	[sCompAddr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,--ע���ַ
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sPayType] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--���ʽ
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--ע��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ap_Supplier] ADD 
	CONSTRAINT [PK_Ap_Supplier] PRIMARY KEY  CLUSTERED 
	(
		[sSupplierID]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '��Ӧ����Ϣ��', N'user', N'dbo', N'table', N'Ap_Supplier', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'��Ӧ�̱��', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierID'
exec sp_addextendedproperty N'MS_Description', N'��Ӧ������', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierName'
exec sp_addextendedproperty N'MS_Description', N'��Ӧ�̼��', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierShortName'
exec sp_addextendedproperty N'MS_Description', N'���Ƿ�', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierQk'
exec sp_addextendedproperty N'MS_Description', N'��Ӧ������', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sSupplierType'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCharge'
exec sp_addextendedproperty N'MS_Description', N'��ϵ��', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sLinkMan'
exec sp_addextendedproperty N'MS_Description', N'�绰1', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sTel1'
exec sp_addextendedproperty N'MS_Description', N'�绰2', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sTel2'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sFax'
exec sp_addextendedproperty N'MS_Description', N'�ʱ�', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sZip'
exec sp_addextendedproperty N'MS_Description', N'ע���ַ', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCompAddr'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'���ʽ', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sPayType'
exec sp_addextendedproperty N'MS_Description', N'ע��', N'user', N'dbo', N'table', N'Ap_Supplier', N'column', N'sMemo'



GO



sp_gettableinfo 'Ap_Supplier'

