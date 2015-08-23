if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WGule]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WGule]
GO

CREATE TABLE [dbo].[PP_WGule] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sGuleMethod] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--粘合方式
	[sGuleMaterial] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,--粘合材料
	[dGuleArea] [decimal](10, 4),--粘合面积
	[dGuleQty] [decimal](10, 4), --粘合材料用量
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WGule] ADD 
	CONSTRAINT [PK_PP_WGule] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WGule] ADD 
	CONSTRAINT [FK_PP_WGule_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', '粘合工单明细', N'user', N'dbo', N'table', N'PP_WGule', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'工序顺序', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'机床', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'粘合材料', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sGuleMaterial'
exec sp_addextendedproperty N'MS_Description', N'粘合方式', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sGuleMethod'
exec sp_addextendedproperty N'MS_Description', N'粘合面积', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'dGuleArea'
exec sp_addextendedproperty N'MS_Description', N'材料用量', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'dGuleQty'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'PP_WGule', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WGule'