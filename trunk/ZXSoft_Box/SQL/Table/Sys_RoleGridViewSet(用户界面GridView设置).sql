--sp_gettableinfo 'Sys_RoleGridViewSet'
drop table [dbo].[Sys_RoleGridViewSet]
GO

CREATE TABLE [dbo].[Sys_RoleGridViewSet] (
			[Role] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--角色(Bas_Customer)
			[GridViewName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--表名
			[FieldName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,--字段名
			[FieldTitle] [varchar] (50)COLLATE Chinese_PRC_CI_AS NULL,--中文名
			[FieldIndex] [smallint] ,--字段位置
			[FieldWidth] [smallint] ,--字段宽度
			[Alignment] [varchar](50) ,--字段对齐方式
			[FieldColor] [varchar](50) ,--字段背景色
			[FontSize] [varchar](50) ,--字体及大小
			[IsReadOnly] [bit] ,--字段是否只读(默认可写=1)
			[IsVisible] [bit] ,--字段是否可见(默认可见=1)
			[ListText] [varchar](500), --字段picklist设置查询语句
			[ValueType][varchar](50) --值类型

) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_RoleGridViewSet] ADD 
	CONSTRAINT [PK_Sys_RoleGridViewSet] PRIMARY KEY  CLUSTERED 
	(
		[Role],
		[GridViewName],
		[FieldName]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '用户界面gridview设置', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'角色', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'Role'
exec sp_addextendedproperty N'MS_Description', N'表名', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'GridViewName'
exec sp_addextendedproperty N'MS_Description', N'字段名', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldName'
exec sp_addextendedproperty N'MS_Description', N'中文名', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldTitle'
exec sp_addextendedproperty N'MS_Description', N'字段位置', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldIndex'
exec sp_addextendedproperty N'MS_Description', N'字段宽度', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldWidth'
exec sp_addextendedproperty N'MS_Description', N'字段对齐方式', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'Alignment'
exec sp_addextendedproperty N'MS_Description', N'字段背景色', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FieldColor'
exec sp_addextendedproperty N'MS_Description', N'字体及大小', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'FontSize'
exec sp_addextendedproperty N'MS_Description', N'字段是否只读', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'IsReadOnly'
exec sp_addextendedproperty N'MS_Description', N'字段是否可见', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'IsVisible'
exec sp_addextendedproperty N'MS_Description', N'字段picklist设置查询语句', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'ListText'
exec sp_addextendedproperty N'MS_Description', N'字段值类型', N'user', N'dbo', N'table', N'Sys_RoleGridViewSet', N'column', N'ValueType'
GO

