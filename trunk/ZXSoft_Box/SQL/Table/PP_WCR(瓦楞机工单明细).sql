if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WCR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WCR]
GO

CREATE TABLE [dbo].[PP_WCR] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sBoardQualityByWork] [varchar](100),--ʵ�ʲ���
	[dMFL][decimal](10,4),--���쳤 MF=manufacture
	[dMFW][decimal](10,4),--�����
	[dMFH][decimal](10,4),--�����
	[dCRLength][decimal](10,4),--��Ƭ��
	[dCRWidth][decimal](10,4),--��Ƭ��
	[sCRLineL][varchar] (200) ,--��ѹ��
	[sCRLineW][varchar] (200) ,--��ѹ��
	[dPaperWidth][decimal](10,4),--�ŷ�
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WCR] ADD 
	CONSTRAINT [PK_PP_WCR] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WCR] ADD 
	CONSTRAINT [FK_PP_WCR_PP_Routing] FOREIGN KEY 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	) REFERENCES [dbo].[PP_Routing] (
		[sWO],
		[sBOM],
		[dRoutingNo]
	) ON DELETE CASCADE  ON UPDATE CASCADE  NOT FOR REPLICATION 
GO

EXECUTE sp_addextendedproperty N'MS_Description', '�����������ϸ', N'user', N'dbo', N'table', N'PP_WCR', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dMFL'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dMFW'
exec sp_addextendedproperty N'MS_Description', N'��(����)', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dMFH'

exec sp_addextendedproperty N'MS_Description', N'��Ƭ��', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dCRLength'
exec sp_addextendedproperty N'MS_Description', N'��Ƭ��', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dCRWidth'
exec sp_addextendedproperty N'MS_Description', N'ѹ�߳�', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sCRLineL'
exec sp_addextendedproperty N'MS_Description', N'ѹ�߿�', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sCRLineW'
exec sp_addextendedproperty N'MS_Description', N'ʵ������', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sBoardQualityByWork'
exec sp_addextendedproperty N'MS_Description', N'�ŷ�', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'dPaperWidth'

exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WCR', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WCR'