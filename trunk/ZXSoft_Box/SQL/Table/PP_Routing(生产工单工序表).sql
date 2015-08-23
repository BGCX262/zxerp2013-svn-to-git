
drop table [dbo].[PP_Routing] ----PP(Product Plan)
GO
--wo bom so soitem custid custpo custpoit proddate prodqty allowqty ReceivedQty status WOcategory Keyinby KeyInon  prodstartTime ConfirmedBy confirmedOn PlanedBy planedOn 
CREATE TABLE [dbo].[PP_Routing] (
	[sWO][varchar](20)COLLATE Chinese_PRC_CI_AS NOT NULL ,--工单编号
	[sBOM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,--产品编号
	[dRoutingNo] [int]NOT NULL,--工序顺序
	[sMachine][varchar](20),--机床
	[sRoutingName][varchar](100)COLLATE Chinese_PRC_CI_AS ,--工序分类
	[tProdStartTime] [datetime] Null,--生产开始日期
	[tProdEndTime] [datetime] Null,--生产结束日期
	[dWOIn][int]Null,--工序进量
	[dWOOut][int]Null,--工序出量
	[dProdQty][decimal](10,4)NuLL,--数量
	[sStatus] [varchar] (20) NULL ,--工单状态
	[dAllowqty][decimal](10,4)NULL ,--放损量
	[sMemo][varchar](500),--说明
	[sCreateName] [varchar] (10) NULL ,--创建人姓名
	[tCreateDate] [datetime] NULL ,--创建时间
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PP_Routing] ADD 
	CONSTRAINT [PK_PP_Routing] PRIMARY KEY  CLUSTERED 
	(
		[sWO],
		[sBOM],
		[dWOProcessNo]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '生产工单工序表', N'user', N'dbo', N'table', N'PP_Routing', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'工单编号', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sWO'
exec sp_addextendedproperty N'MS_Description', N'产品编号', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sBOM'
exec sp_addextendedproperty N'MS_Description', N'工序顺序', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dRoutingNo'
exec sp_addextendedproperty N'MS_Description', N'工序名称', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sRoutingName'
exec sp_addextendedproperty N'MS_Description', N'机床', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sMachine'

exec sp_addextendedproperty N'MS_Description', N'工序进量', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dWOIn'
exec sp_addextendedproperty N'MS_Description', N'工序出量', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dWOOut'
exec sp_addextendedproperty N'MS_Description', N'开始日期', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tProdStartTime'
exec sp_addextendedproperty N'MS_Description', N'结束日期', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tProdEndTime'
exec sp_addextendedproperty N'MS_Description', N'生产数量', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dProdQty'
exec sp_addextendedproperty N'MS_Description', N'工单状态', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sStatus'
exec sp_addextendedproperty N'MS_Description', N'放损量', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'dAllowQty'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sMemo'
exec sp_addextendedproperty N'MS_Description', N'创建人姓名', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'PP_Routing', N'column', N'tCreateDate'
GO
sp_gettableinfo 'PP_Routing'
