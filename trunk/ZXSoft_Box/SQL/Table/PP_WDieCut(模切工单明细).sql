if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WDieCut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WDieCut]
GO

CREATE TABLE [dbo].[PP_WDieCut] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDieCutPlate1][varchar](100),--ģ��1
	[sDieCutPlate2][varchar](100),--ģ��2
	[sDieCutPlate3][varchar](100),--ģ��3
	[dDieCutLength][decimal](10,4),--ģ�泤
	[dDieCutWidth][decimal](10,4),--ģ���
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WDieCut] ADD 
	CONSTRAINT [PK_PP_WDieCut] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WDieCut] ADD 
	CONSTRAINT [FK_PP_WDieCut_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', 'ģ�й�����ϸ', N'user', N'dbo', N'table', N'PP_WDieCut', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'ģ���1', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate1'
exec sp_addextendedproperty N'MS_Description', N'ģ���2', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate2'
exec sp_addextendedproperty N'MS_Description', N'ģ���3', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate3'
exec sp_addextendedproperty N'MS_Description', N'ģ�泤', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dDieCutLength'
exec sp_addextendedproperty N'MS_Description', N'ģ���', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dDieCutWidth'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sMachine'

exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WDieCut'