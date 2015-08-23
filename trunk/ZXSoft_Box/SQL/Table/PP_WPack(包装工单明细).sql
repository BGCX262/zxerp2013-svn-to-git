if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PP_WPack]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PP_WPack]
GO

CREATE TABLE [dbo].[PP_WPack] (
	[sWO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[dRoutingNo] [int] NOT NULL ,
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sPackMathod] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,--��װ��ʽ
	[sPackMaterial][varchar](100),--��װ����
	[iPackQty][int],--��װ����
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_WPack] ADD 
	CONSTRAINT [PK_PP_WPack] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dRoutingNo]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PP_WPack] ADD 
	CONSTRAINT [FK_PP_WPack_PP_Routing] FOREIGN KEY 
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

EXECUTE sp_addextendedproperty N'MS_Description', '��װ������ϸ', N'user', N'dbo', N'table', N'PP_WPack', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'����˳��', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'��װ��ʽ', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sPackMathod'
exec sp_addextendedproperty N'MS_Description', N'��װ����', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sPackMaterial'
exec sp_addextendedproperty N'MS_Description', N'��װ����', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'iPackQty'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'PP_WPack', N'column', N'sMemo'
GO
sp_gettableinfo 'PP_WPack'