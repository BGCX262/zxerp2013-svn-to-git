if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WStitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WStitch]
GO

CREATE TABLE [dbo].[PP_WStitch] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sStitchMathod] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sStitchMaterial] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[dStitchQty] [decimal](10,4),--װ������
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WStitch] ADD 
	CONSTRAINT [PK_PP_WStitch] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WStitch] ADD 
	CONSTRAINT [FK_PP_WStitch_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', 'װ��������ϸ', N'user', N'dbo', N'table', N'PP_WStitch', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'װ����ʽ', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sStitchMathod'
exec sp_addextendedproperty N'MS_Description', N'װ������', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sStitchMaterial'
exec sp_addextendedproperty N'MS_Description', N'װ������', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'dStitchQty'

exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WStitch', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WStitch'