
drop table [dbo].[Inv_ItemInventory]
GO

CREATE TABLE [dbo].[Inv_ItemInventory] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--ԭ������
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--ԭ�Ϻ�
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

ALTER TABLE [dbo].[Inv_ItemInventory] ADD 
	CONSTRAINT [PK_Inv_ItemInventory] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', 'ԭ�Ͽ���', N'user', N'dbo', N'table', N'Inv_ItemInventory', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'ԭ�Ϻ�', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'ԭ������', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sBarCode'

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'dInventoryQty'
exec sp_addextendedproperty N'MS_Description', N'���ʱ��', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'tInDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'���λ��', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sLocation'
exec sp_addextendedproperty N'MS_Description', N'�����λ��', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sLocationsub'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Inv_ItemInventory', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_ItemInventory'
