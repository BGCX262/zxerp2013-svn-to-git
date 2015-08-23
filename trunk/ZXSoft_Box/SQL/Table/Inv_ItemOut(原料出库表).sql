
drop table [dbo].[Inv_ItemOut]
GO

CREATE TABLE [dbo].[Inv_ItemOut] (
	[sBarCode][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--ԭ������
	[iBarCodeCount][integer]NOT NULL ,--�������
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--ԭ�Ϻ�
	[sOutType] [varchar] (10) COLLATE Chinese_PRC_CI_AS,--��������
	[sOutBill] [varchar] (20) COLLATE Chinese_PRC_CI_AS ,--���ⵥ��
	[dOldQty] [decimal](10,4) ,--ԭ�������	
	[dOutQty] [decimal](10,4) ,--��������
	[sOutForUse] [varchar](20),--������;
	[tOutDate] [datetime] ,--����ʱ��
	[dPrice] [money] ,--����
	[sUOM][varchar](10),--��λ
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_ItemOut] ADD 
	CONSTRAINT [PK_Inv_ItemOut] PRIMARY KEY  CLUSTERED 
	(
		[sBarCode],
		[iBarCodeCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', 'ԭ�ϳ����', N'user', N'dbo', N'table', N'Inv_ItemOut', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'ԭ�Ϻ�', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'ԭ������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sBarCode'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'iBarCodeCount'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutType'
exec sp_addextendedproperty N'MS_Description', N'���ⵥ��', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutBill'
exec sp_addextendedproperty N'MS_Description', N'ԭ�������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dOldQty'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dOutQty'
exec sp_addextendedproperty N'MS_Description', N'������;', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sOutForUse'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'tOutDate'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'dPrice'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Inv_ItemOut', N'column', N'sMemo'
GO
sp_gettableinfo 'Inv_ItemOut'
