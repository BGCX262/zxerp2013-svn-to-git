
drop table [dbo].[Inv_FpInventory]
GO

CREATE TABLE [dbo].[Inv_FpInventory] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ʒ����
	[iBarCodeCount][integer]NOT NULL ,--�������
	[sSO] [varchar](20)COLLATE Chinese_PRC_CI_AS,--���۵�
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--ԭ�Ϻ�
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--ԭ�Ϻ�
	[dInventoryQty] [decimal](10,4) ,--�������
	[tInDate] [datetime] ,--���ʱ��
	[dPrice] [money] ,--����
	[sUOM][varchar](10),--��λ
	[sLocation][varchar](10),--���λ��
	[sLocationSub][varchar](10),--�����λ��
	[sCreateName] [varchar] (10)COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_FpInventory] ADD 
	CONSTRAINT [PK_Inv_FpInventory] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[iBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '��Ʒ����', N'user', N'dbo', N'table', N'Inv_FpInventory', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'��Ʒ����', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'���۵�', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'dInventoryQty'
exec sp_addextendedproperty N'MS_Description', N'���ʱ��', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'tInDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'���λ��', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sLocation'
exec sp_addextendedproperty N'MS_Description', N'�����λ��', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sLocationsub'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Inv_FpInventory', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_FpInventory'
