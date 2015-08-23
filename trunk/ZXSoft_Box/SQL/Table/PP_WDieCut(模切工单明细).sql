if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WDieCut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WDieCut]
GO

CREATE TABLE [dbo].[PP_WDieCut] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDieCutPlate1][varchar](100),--模版1
	[sDieCutPlate2][varchar](100),--模版2
	[sDieCutPlate3][varchar](100),--模版3
	[dDieCutLength][decimal](10,4),--模版长
	[dDieCutWidth][decimal](10,4),--模版宽
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

EXECUTE sp_addextendedproperty N'MS_Description', '模切工单明细', N'user', N'dbo', N'table', N'PP_WDieCut', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'工序顺序', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'模版号1', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate1'
exec sp_addextendedproperty N'MS_Description', N'模版号2', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate2'
exec sp_addextendedproperty N'MS_Description', N'模版号3', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sDieCutPlate3'
exec sp_addextendedproperty N'MS_Description', N'模版长', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dDieCutLength'
exec sp_addextendedproperty N'MS_Description', N'模版宽', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'dDieCutWidth'
exec sp_addextendedproperty N'MS_Description', N'机床', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sMachine'

exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'PP_WDieCut', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WDieCut'