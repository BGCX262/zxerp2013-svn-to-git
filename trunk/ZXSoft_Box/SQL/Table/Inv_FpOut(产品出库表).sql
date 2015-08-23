
drop table [dbo].[Inv_FpOut]
GO

CREATE TABLE [dbo].[Inv_FpOut] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ʒ����
	[iBarCodeCount][integer]NOT NULL ,--�������
	[sSO] [varchar](20)COLLATE Chinese_PRC_CI_AS,--���۵�
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--��Ʒ��ź�
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--�ͻ����
	[sOutType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--��������
	[sOutBill] [varchar] (10) COLLATE Chinese_PRC_CI_AS ,--���ⵥ��
	[dOutQty] [decimal](10,4) ,--��������
	[tOutDate] [datetime] ,--����ʱ��
	[dPrice] [money] ,--����
	[sUOM][varchar](10),--��λ
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_FpOut] ADD 
	CONSTRAINT [PK_Inv_FpOut] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[siBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '��Ʒ�����', N'user', N'dbo', N'table', N'Inv_FpOut', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'��Ʒ����', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'���۵�', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sOutType'
exec sp_addextendedproperty N'MS_Description', N'���ⵥ��', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sOutBill'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dOutQty'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'tOutDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'dCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Inv_FpOut', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_FpOut'
