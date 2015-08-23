
drop table [dbo].[PP_Routing] ----PP(Product Plan)
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_Routing] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--�������
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--��Ʒ���
	[dRoutingNo] [int]NOT NULL,--����˳��
	[sMachine][varchar](20),--����
	[sRoutingName][varchar](100)COLLATE Chinese_PRC_CI_AS ,--�������
	[tProdStartTime] [datetime] Null,--������ʼ����
	[tProdEndTime] [datetime] Null,--������������
	[dWOIn][int]Null,--�������
	[dWOOut][int]Null,--�������
	[dProdQty][decimal](10,4)NuLL,--����
	[sStatus] [varchar] (20) NULL ,--����״̬
	[dAllowqty][decimal](10,4)NULL ,--������
	[sMemo][varchar](500),--˵��
	[sCreateName] [varchar] (10) NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_Routing] ADD 
	CONSTRAINT [PK_PP_Routing] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dWOProcessNo]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '�������������', N'user', N'dbo', N'table', N'PP_Routing', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sRoutingName'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sMachine'

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dWOIn'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dWOOut'
exec sp_addextendedproperty N'MS_Description', N'��ʼ����', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tProdStartTime'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tProdEndTime'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dProdQty'
exec sp_addextendedproperty N'MS_Description', N'����״̬', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dAllowQty'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tCreateDate'
GO
sp_gettableinfo 'PP_Routing'
