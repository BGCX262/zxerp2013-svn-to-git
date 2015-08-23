if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WPrint_Offset]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WPrint_Offset]
GO

CREATE TABLE [dbo].[PP_WPrint_Offset] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[iPrintColors][varchar] (20),--印色,
	[sColor1][varchar] (20),--印色1,
	[sColor2][varchar] (20),--印色2,
	[sColor3][varchar] (20),--印色3,
	[sColor4][varchar] (20),--印色4,
	[sColor5][varchar] (20),--印色5,
	[sColor6][varchar] (20),--印色6,
	[sColor7][varchar] (20),--印色7,
	[sColor8][varchar] (20),--印色8,
	[sBackingUpColor1][varchar] (20),--反色1
	[sBackingUpColor2][varchar] (20),--反色2
	[sBackingUpColor3][varchar] (20),--反色3
	[sBackingUpColor4][varchar] (20),--反色4
	[sBackingUpColor5][varchar] (20),--反色5
	[sBackingUpColor6][varchar] (20),--反色6
	[sBackingUpColor7][varchar] (20),--反色7
	[sBackingUpColor8][varchar] (20),--反色8
	
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WPrint_Offset] ADD 
	CONSTRAINT [PK_PP_WPrint_Offset] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WPrint_Offset] ADD 
	CONSTRAINT [FK_PP_WPrint_Offset_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', '胶印工单明细', N'user', N'dbo', N'table', N'PP_WPrint_Offset', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'工序顺序', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'机床', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'色数', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'iPrintColors'
exec sp_addextendedproperty N'MS_Description', N'印色1', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor1'
exec sp_addextendedproperty N'MS_Description', N'印色2', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor2'
exec sp_addextendedproperty N'MS_Description', N'印色3', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor3'
exec sp_addextendedproperty N'MS_Description', N'印色4', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor4'
exec sp_addextendedproperty N'MS_Description', N'印色5', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor5'
exec sp_addextendedproperty N'MS_Description', N'印色6', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor6'
exec sp_addextendedproperty N'MS_Description', N'印色7', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor7'
exec sp_addextendedproperty N'MS_Description', N'印色8', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor8'
exec sp_addextendedproperty N'MS_Description', N'反面印色1', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor1'
exec sp_addextendedproperty N'MS_Description', N'反面印色2', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor2'
exec sp_addextendedproperty N'MS_Description', N'反面印色3', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor3'
exec sp_addextendedproperty N'MS_Description', N'反面印色4', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor4'
exec sp_addextendedproperty N'MS_Description', N'反面印色5', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor5'
exec sp_addextendedproperty N'MS_Description', N'反面印色6', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor6'
exec sp_addextendedproperty N'MS_Description', N'反面印色7', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor7'
exec sp_addextendedproperty N'MS_Description', N'反面印色8', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor8'

exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WPrint_Offset'