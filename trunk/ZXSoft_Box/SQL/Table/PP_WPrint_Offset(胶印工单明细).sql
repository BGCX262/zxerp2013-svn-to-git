if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WPrint_Offset]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WPrint_Offset]
GO

CREATE TABLE [dbo].[PP_WPrint_Offset] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[iPrintColors][varchar] (20),--ӡɫ,
	[sColor1][varchar] (20),--ӡɫ1,
	[sColor2][varchar] (20),--ӡɫ2,
	[sColor3][varchar] (20),--ӡɫ3,
	[sColor4][varchar] (20),--ӡɫ4,
	[sColor5][varchar] (20),--ӡɫ5,
	[sColor6][varchar] (20),--ӡɫ6,
	[sColor7][varchar] (20),--ӡɫ7,
	[sColor8][varchar] (20),--ӡɫ8,
	[sBackingUpColor1][varchar] (20),--��ɫ1
	[sBackingUpColor2][varchar] (20),--��ɫ2
	[sBackingUpColor3][varchar] (20),--��ɫ3
	[sBackingUpColor4][varchar] (20),--��ɫ4
	[sBackingUpColor5][varchar] (20),--��ɫ5
	[sBackingUpColor6][varchar] (20),--��ɫ6
	[sBackingUpColor7][varchar] (20),--��ɫ7
	[sBackingUpColor8][varchar] (20),--��ɫ8
	
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

EXECUTE sp_addextendedproperty N'MS_Description', '��ӡ������ϸ', N'user', N'dbo', N'table', N'PP_WPrint_Offset', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'ɫ��', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'iPrintColors'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ1', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor1'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ2', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor2'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ3', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor3'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ4', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor4'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ5', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor5'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ6', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor6'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ7', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor7'
exec sp_addextendedproperty N'MS_Description', N'ӡɫ8', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sColor8'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ1', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor1'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ2', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor2'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ3', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor3'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ4', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor4'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ5', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor5'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ6', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor6'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ7', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor7'
exec sp_addextendedproperty N'MS_Description', N'����ӡɫ8', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sBackingUpColor8'

exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WPrint_Offset', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WPrint_Offset'