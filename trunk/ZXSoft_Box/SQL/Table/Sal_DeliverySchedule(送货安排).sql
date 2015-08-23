
drop table [dbo].[Sal_DeliverySchedule]
GO

CREATE TABLE [dbo].[Sal_DeliverySchedule] (
	[sSO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--�������
	[dSOCount][int] NOT NULL ,--��������
	[sCustID][varchar] (20) COLLATE Chinese_PRC_CI_AS ,--�ͻ����
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS,--��Ʒ���
	[sCustPO][varchar](100)COLLATE Chinese_PRC_CI_AS ,--�ɹ�����
	[dUnitPrice][money]NULL ,--����
	[dDeliveryQty][decimal](10,4),--����
	[tDfpDate] [datetime] NULL ,--�ͻ�ʱ��
	[tOrgDfpDate] [datetime] NULL ,--ԭ�ͻ�ʱ��
	[sAddress][varchar](100),--��ַ
	[sDO][varchar](20),--�ͻ�����
	[sDriver][varchar](20),--˾��
	[dAcceptQty][decimal](10,4),--��������
	[sMemo][varchar](500),--˵��
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sal_DeliverySchedule] ADD 
	CONSTRAINT [PK_Sal_DeliverySchedule] PRIMARY KEY  CLUSTERED 
	(
		[sSO],
		[dSOCount]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '�ͻ���', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dSOCount'

exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCustPO'
exec sp_addextendedproperty N'MS_Description', N'�ͻ����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'�ͻ���ַ', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sAddress'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sDO'
exec sp_addextendedproperty N'MS_Description', N'˾��', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sDriver'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dDeliveryQty'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tDfpDate'
exec sp_addextendedproperty N'MS_Description', N'�ƻ�����', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tOrgDfpDate'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'dAcceptQty'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Sal_DeliverySchedule', N'column', N'tCreateDate'
GO
sp_gettableinfo 'Sal_DeliverySchedule'


--EXEC sp_dropextendedproperty 'MS_Description','user',dbo,'table','Sal_DeliverySchedule','column',OrgDfpDate 

