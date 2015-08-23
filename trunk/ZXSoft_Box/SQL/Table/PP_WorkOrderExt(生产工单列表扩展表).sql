
drop table [dbo].[PP_WorkOrderExt] ----PP 
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_WorkOrderExt] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--�������
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS NOT Null,--�ͻ����
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ʒ���
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
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WorkOrderExt] ADD 
	CONSTRAINT [PK_PP_WorkOrderExt] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sCustID],
		[sBOM]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '������������չ��', N'user', N'dbo', N'table', N'PP_WorkOrderExt', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sBOM'

exec sp_addextendedproperty N'MS_Description', N'���ͱ��', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sPartTypeID'
exec sp_addextendedproperty N'MS_Description', N'�ߴ�����', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sDimension'
exec sp_addextendedproperty N'MS_Description', N'�ߴ���', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sLWH'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sFluteType'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dL'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dW'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dH'
exec sp_addextendedproperty N'MS_Description', N'ֽ������', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sBoardMaterial'
exec sp_addextendedproperty N'MS_Description', N'����ƽ����', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dMaterialPrice'
exec sp_addextendedproperty N'MS_Description', N'�ͻ��Ϻ�', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustBOM'
exec sp_addextendedproperty N'MS_Description', N'�ɹ���', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'�ɹ��ӵ���', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'sCustSubPO'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WorkOrderExt', N'column', N'dUnitPrice'
GO
sp_gettableinfo 'PP_WorkOrderExt'
