--sp_gettableinfo 'Ap_Cooperation'
drop table [dbo].[Ap_Cooperation]
GO

CREATE TABLE [dbo].[Ap_Cooperation] (	

	[sSO][varchar] (20) COLLATE Chinese_PRC_CI_AS Not NULL ,--�������
	[iSOCount][int] Not NULL,--�����ɹ�����	
	[sPO][varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Э���
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Ӧ�̱��
	[sSupplierID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Ӧ�̱��
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��Ʒ���
	[dPOPrice] [money] NULL ,--�ɹ�ƽ����
	[dPOUnitPrice][money]NULL ,--�ɹ�����
	[dPOQty][decimal](10,4),--����
	[dPOCRL][decimal](10, 4),--�ɹ����ϳ�
	[dPOCRW][decimal](10, 4),--�ɹ����Ͽ�
	[dCRL][decimal](10, 4),--���ϳ�
	[dCRW][decimal](10, 4),--���Ͽ�
	[sCLineL][varchar](100),--��ѹ��CreasingLineL
	[sCLineW][varchar](100),--��ѹ��CreasingLineW
	[tDfpDate] [datetime] NULL ,--�ͻ�ʱ��
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--ע��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ap_Cooperation] ADD 
	CONSTRAINT [PK_Ap_Cooperation] PRIMARY KEY  CLUSTERED 
	(
		[sSO],
		[iSOCount]
	)  ON [PRIMARY] 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '��Ӧ����Ϣ��', N'user', N'dbo', N'table', N'Ap_Cooperation', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sSO'
exec sp_addextendedproperty N'MS_Description', N'�����ɹ�����', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'iSOCount'

exec sp_addextendedproperty N'MS_Description', N'��Э���', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sPO'
exec sp_addextendedproperty N'MS_Description', N'��Ӧ�̱��', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sSupplierID'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�ID', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCustID'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�ƽ����', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOPrice'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOUnitPrice'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOQty'
exec sp_addextendedproperty N'MS_Description', N'�ɹ����ϳ�', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOCRL'
exec sp_addextendedproperty N'MS_Description', N'�ɹ����Ͽ�', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dPOCRW'
exec sp_addextendedproperty N'MS_Description', N'���ϳ�', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dCRL'
exec sp_addextendedproperty N'MS_Description', N'���Ͽ�', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'dCRW'
exec sp_addextendedproperty N'MS_Description', N'��ѹ��:CreasingLineL', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCLineL'
exec sp_addextendedproperty N'MS_Description', N'��ѹ��:CreasingLineW', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCLineW'
exec sp_addextendedproperty N'MS_Description', N'�ͻ�ʱ��', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'tDfpDate'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'ע��', N'user', N'dbo', N'table', N'Ap_Cooperation', N'column', N'sMemo'



GO



sp_gettableinfo 'Ap_Cooperation'

