
drop table [dbo].[Sal_SalesOrder]
GO

CREATE TABLE [dbo].[Sal_SalesOrder] (
	[sSO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--�������
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS Null,--�ͻ����
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Ʒ���
	[sSOClass] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��������
	[sPartTypeID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--���ͱ��
	[sDimension] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�ߴ�����
	[sLWH] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--�ߴ���
	[sFluteType] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����
	[dL] [decimal](10,4),--��
	[dW] [decimal](10,4),--��
	[dH] [decimal](10,4),--��
	[sBoardMaterial] [varchar] (300) COLLATE Chinese_PRC_CI_AS NULL ,--ֽ������
	[dMaterialPrice] [money]NULL,--ֽ��ƽ����
	[sCustBOM] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--�ͻ��Ϻ�
	[sCustPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--�ɹ�����
	[sCustSubPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--�ɹ�����
	[dUnitPrice][money]NULL ,--����
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--˰�����
	[dOrderQty][decimal](10,4),--����
	[tDelieryDate][datetime] NULL ,--�ͻ�ʱ��
	[sStatus] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--����״̬
	[sSalesMan] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--ҵ��Ա
	[dPrintBeforeFee][money]NULL ,--ӡǰ��
	[dPrintingFee][money]NULL ,--ӡˢ��
	[dPrintAfterFee][money]NULL ,--ӡ���
	[dFinishProductFee][money]NULL ,--��Ʒ��
	[dMaterialFee][money]NULL ,--���Ϸ�
	[dProcessFee][money]NULL ,--�����
	[sMemo][varchar](500),--˵��
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sal_SalesOrder] ADD 
	CONSTRAINT [PK_Sal_SalesOrder] PRIMARY KEY  CLUSTERED 
	(
		[sSO]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '���۶�����', N'user', N'dbo', N'table', N'Sal_SalesOrder', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'���ͱ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'�ߴ�����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'�ߴ���', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sLWH'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dL'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dW'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dH'
exec sp_addextendedproperty N'MS_Description', N'ֽ������', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'�ͻ��Ϻ�', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustBOM'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSOClass'
exec sp_addextendedproperty N'MS_Description', N'�ɹ��ӵ���', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCustSubPO'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dOrderQty'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�ʱ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'tDeliveryDate'
exec sp_addextendedproperty N'MS_Description', N'����״̬', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'˰�����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sTaxCode'
exec sp_addextendedproperty N'MS_Description', N'ӡǰ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintBeforeFee'
exec sp_addextendedproperty N'MS_Description', N'ӡˢ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintingFee'
exec sp_addextendedproperty N'MS_Description', N'ӡ���', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dPrintAfterFee'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dProcessFee'
exec sp_addextendedproperty N'MS_Description', N'���Ϸ�', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dMaterialFee'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'dFinishProductFee'


exec sp_addextendedproperty N'MS_Description', N'ҵ��Ա', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sSalesMan'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Sal_SalesOrder', N'column', N'tCreateDate'
GO
sp_gettableinfo 'Sal_SalesOrder'
