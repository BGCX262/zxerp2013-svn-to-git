
drop table [dbo].[Inv_ItemIn]
GO

CREATE TABLE [dbo].[Inv_ItemIn] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--ԭ������
	[iBarCodeCount][integer]NOT NULL ,--�������
	[sPO][varchar](20)COLLATE Chinese_PRC_CI_AS,--�ɹ�����
	[sSupplierID][varchar](20)COLLATE Chinese_PRC_CI_AS,--��Ӧ�̱��
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--ԭ�Ϻ�
	[sInType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--�������
	[sInBill] [varchar] (20) COLLATE Chinese_PRC_CI_AS ,--��ⵥ��
	[dInQty] [decimal](10,4) ,--�������
	[tInDate] [datetime] ,--���ʱ��
	[dPrice] [money] ,--����
	[sUOM][varchar](10),--��λ
	[sLocation][varchar](10),--���λ��
	[sLocationSub][varchar](10),--�����λ��
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_ItemIn] ADD 
	CONSTRAINT [PK_Inv_ItemIn] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[iBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', 'ԭ������', N'user', N'dbo', N'table', N'Inv_ItemIn', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'ԭ������', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sPO'
exec sp_addextendedproperty N'MS_Description', N'��Ӧ��ID', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sSupplierID'
exec sp_addextendedproperty N'MS_Description', N'ԭ�Ϻ�', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sInType'
exec sp_addextendedproperty N'MS_Description', N'��ⵥ��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sInBill'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'dInQty'
exec sp_addextendedproperty N'MS_Description', N'���ʱ��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'tInDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'���λ��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sLocation'
exec sp_addextendedproperty N'MS_Description', N'�����λ��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sLocationSub'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Inv_ItemIn', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_ItemIn'
