--sp_gettableinfo 'Sys_RoleFormSet'

drop table [dbo].[Sys_RoleFormSet]
GO

CREATE TABLE [dbo].[Sys_RoleFormSet](
	[sRole][varchar](100) Not NUll,--角色
	[sFormName][varchar](100) Not NUll,--窗体名称：如是dgv 显示为窗体-dgv名 ，如是非dgv控件：就显示窗体名
	[sFieldName] [varchar](100) Not NUll,--字段
	[sControlName][varchar](100) Not NUll,--控件名称
	[sFieldTitle] [varchar](100) NULL,--中文
	[sFont] [varchar](100) NULL,--字体
	[sType] [varchar](100) NULL,--数据类型
	[sFormat][varchar](100) NULL,--显示格式
	[bDataField] [bit] NULL,--是否为表数据
	[bVisible] [bit] NULL,--是否显示
	[bIsReadOnly] [bit] NULL,--是否只读
	[sSumType] [varchar](100) NULL,--合计类型
	[sFootFormat] [varchar](100) NULL,--合计格式
	[iFitWidth] [int] NULL,--宽度
	[iDropDown] [int] NULL,--下拉类型
	[sDropDownList] [varchar](1000) NULL,--下拉数据
	[iOrder] [int] NULL,--排序
	[tCreateDate] [datetime] NULL,--创建时间
	[sCreateName] [varchar](100) NULL,--创建人
	[sSqlParam][varchar](1000) NULL,--SQL参数变量
	[sAssignField] [varchar](4500) NULL,--赋值配置
	[iVisCount] [int] NULL,--下拉行数
	[bNewRecord] [bit] NULL,--是否新记录
	[bFirstEmpty] [bit] NULL,--首行为空
	[iDropWidth] [int] NULL,--下拉列表宽度
	[bNotEmpty] [bit] NULL,--是否为空
	[sModifer] [varchar](100) NULL,--修改人
	[tModifyDate] [datetime] NULL,--修改时间
	[sActiveForm] [varchar](100) NULL,--激活窗体
	[sActiveDll] [varchar](100) NULL,--激活Dll
	[sActiveKey] [varchar](100) NULL--激活参数
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Sys_RoleFormSet] ADD 
	CONSTRAINT [PK_Sys_RoleFormSet] PRIMARY KEY  CLUSTERED 
	(
		[sRole],
		[sFormName],
		[sFieldName],
		[sControlName]
	)  ON [PRIMARY] 
GO
EXECUTE sp_addextendedproperty N'MS_Description', '用户窗体设置', N'user', N'dbo', N'table', N'Sys_RoleFormSet', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'角色', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sRole'
exec sp_addextendedproperty N'MS_Description', N'窗体名称', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFormName'
exec sp_addextendedproperty N'MS_Description', N'字段名', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFieldName'
exec sp_addextendedproperty N'MS_Description', N'控件名称', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sControlName'
exec sp_addextendedproperty N'MS_Description', N'中文', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFieldTitle'
exec sp_addextendedproperty N'MS_Description', N'字体', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFont'
exec sp_addextendedproperty N'MS_Description', N'数据类型', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sType'
exec sp_addextendedproperty N'MS_Description', N'显示格式', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFormat'
exec sp_addextendedproperty N'MS_Description', N'是否为表数据', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bDataField'
exec sp_addextendedproperty N'MS_Description', N'是否显示', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bVisible'
exec sp_addextendedproperty N'MS_Description', N'是否只读', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bIsReadOnly'
exec sp_addextendedproperty N'MS_Description', N'是否求和', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sSumType'
exec sp_addextendedproperty N'MS_Description', N'合计格式', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sFootFormat'
exec sp_addextendedproperty N'MS_Description', N'宽度', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iFitWidth'
exec sp_addextendedproperty N'MS_Description', N'下拉类型', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iDropDown'
exec sp_addextendedproperty N'MS_Description', N'下拉数据', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sDropDownList'
exec sp_addextendedproperty N'MS_Description', N'排序', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iOrder'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'赋值配置', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sAssignField'
exec sp_addextendedproperty N'MS_Description', N'下拉行数', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iVisCount'
exec sp_addextendedproperty N'MS_Description', N'是否新记录', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bNewRecord'
exec sp_addextendedproperty N'MS_Description', N'首行为空', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bFirstEmpty'
exec sp_addextendedproperty N'MS_Description', N'下拉列表宽度', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'iDropWidth'
exec sp_addextendedproperty N'MS_Description', N'是否为空', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'bNotEmpty'
exec sp_addextendedproperty N'MS_Description', N'修改人', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sModifer'
exec sp_addextendedproperty N'MS_Description', N'修改时间', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'激活窗体', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveForm'
exec sp_addextendedproperty N'MS_Description', N'激活Dll', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveDll'
exec sp_addextendedproperty N'MS_Description', N'激活参数', N'user', N'dbo', N'table', N'Sys_RoleFormSet', N'column', N'sActiveKey'

GO
sp_gettableinfo 'Sys_RoleFormSet'
