if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bas_Machines]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bas_Machines]
GO

CREATE TABLE [dbo].[Bas_Machines] (
	[sMachine] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sRoutingClass] [varchar](20) NOT NULL ,
	[sSortBy][varchar](20) NULL ,
	[dBeforeWorkingTime] [decimal](18, 4) NULL ,
	[dWorkingTime] [decimal](18, 4) NULL ,
	[dAfterWorkingTime] [decimal](18, 4) NULL ,
	[dWorkingQtyPerHour] [decimal](18, 4) NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_Machines] ADD 
	CONSTRAINT [PK_Bas_Machines] PRIMARY KEY  CLUSTERED 
	(
		[sMachine],
		[sProcessName]
	)  ON [PRIMARY] 
GO






EXECUTE sp_addextendedproperty N'MS_Description', '机床参数列表', N'user', N'dbo', N'table', N'Bas_Machines', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'机床', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sMachine'
exec sp_addextendedproperty N'MS_Description', N'工序类别', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sRoutingClass'
exec sp_addextendedproperty N'MS_Description', N'排序', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sSortBy'
exec sp_addextendedproperty N'MS_Description', N'准备时间', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'dBeforeWorkingTime'
exec sp_addextendedproperty N'MS_Description', N'生产时间', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'dWorkingTime'
exec sp_addextendedproperty N'MS_Description', N'收尾时间', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'dAfterWorkingTime'
exec sp_addextendedproperty N'MS_Description', N'小时数量', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'dWorkingQtyPerHour'
exec sp_addextendedproperty N'MS_Description', N'修改人', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'修改时间', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'说明', N'user', N'dbo', N'table', N'Bas_Machines', N'column', N'sMemo'
GO

sp_gettableinfo 'Bas_Machines'
