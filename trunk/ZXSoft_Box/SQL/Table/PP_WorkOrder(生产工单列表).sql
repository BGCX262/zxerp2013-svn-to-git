
drop table [dbo].[PP_WorkOrder] ----PP ����(Manufacture Order)
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_WorkOrder] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--�������
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS NOT Null,--�ͻ����
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ʒ���
	[sSO] [varchar] (20) NULL ,--�������
	[tProddate] [datetime] Null,--��������(ȡ�ͻ�����)
	[dProdQty][decimal](10,4)NuLL,--����
	[dRate][decimal](10,4)NuLL,--����
	[sStatus] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--����״̬
	[dAllowqty][decimal](10,4)NULL ,--������
	[dReceivedQty][decimal](10,4)NULL ,--������
	[sWOClass][money]NULL ,--�������
	[sMemo][varchar](500),--˵��
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WorkOrder] ADD 
	CONSTRAINT [PK_PP_WorkOrder] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sCustID],
		[sBOM]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '����������', N'user', N'dbo', N'table', N'PP_WorkOrder', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'tProddate'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dProdQty'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dRate'
exec sp_addextendedproperty N'MS_Description', N'����״̬', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dAllowQty'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'dReceivedQty'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sWOClass'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'PP_WorkOrder', N'column', N'tCreateDate'
GO
sp_gettableinfo 'PP_WorkOrder'
