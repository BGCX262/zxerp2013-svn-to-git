if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TB_MainRptSet]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TB_MainRptSet]
GO

CREATE TABLE [dbo].[TB_MainRptSet] (
	[sRptName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sRptID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sRptCaption] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sRptFilePath] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TB_MainRptSet] ADD 
	CONSTRAINT [PK_TB_MainRptSet] PRIMARY KEY  CLUSTERED 
	(
		[sRptName],
		[sRptID]
	)  ON [PRIMARY] 
GO



EXECUTE sp_addextendedproperty N'MS_Description', '�������ñ�', N'user', N'dbo', N'table', N'TB_MainRptSet', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'����ID', N'user', N'dbo', N'table', N'TB_MainRptSet', N'column', N'sRptName'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'TB_MainRptSet', N'column', N'sRptID'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'TB_MainRptSet', N'column', N'sRptCaption'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'TB_MainRptSet', N'column', N'sRptFilePath'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'TB_MainRptSet', N'column', N'sMemo'
GO



INSERT INTO dbo.TB_MainRptSet (sRptName, sRptID, sRptCaption, sRptFilePath, sMemo)
VALUES ('FrxItemInBill', '01', '������ⵥ', 'Frx\FrxItemInBill.frx', NULL)
GO
INSERT INTO dbo.TB_MainRptSet (sRptName, sRptID, sRptCaption, sRptFilePath, sMemo)
VALUES ('FrxItemOutBill', '01', '���ϳ��ⵥ', 'Frx\FrxItemOutBill.frx', NULL)
GO
sp_gettableinfo 'TB_MainRptSet'



