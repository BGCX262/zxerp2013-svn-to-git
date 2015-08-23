if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WPrint_WBI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WPrint_WBI]
GO

CREATE TABLE [dbo].[PP_WPrint_WBI] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[iWPrintColors] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sWColor1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sWColor2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sWColor3] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sWColor4] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WPrint_WBI] ADD 
	CONSTRAINT [PK_PP_WPrint_WBI] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WPrint_WBI] ADD 
	CONSTRAINT [FK_PP_WPrint_WBI_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', 'ˮӡ������ϸ', N'user', N'dbo', N'table', N'PP_WPrint_WBI', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'ɫ��', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'iWPrintColors'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ1', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sWColor1'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ2', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sWColor2'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ3', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sWColor3'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ4', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sWColor4'

exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WPrint_WBI', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WPrint_WBI'