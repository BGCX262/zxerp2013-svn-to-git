
drop table [dbo].[ItemInfo]
GO

CREATE TABLE [dbo].[ItemInfo] (
	[sItem] [varchar] (50) COLLATE Chinese_PRC_CI_AS not Null,--���ϱ��
	[sItemName] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--��������
	[sItemSpec] [varchar] (50) COLLATE Chinese_PRC_CI_AS,--���Ϲ��(Specification)
	[sClassGroup1][varchar](50)COLLATE Chinese_PRC_CI_AS,--һ������
	[sClassGroup2][varchar](50)COLLATE Chinese_PRC_CI_AS,--��������
	[sClassGroup3][varchar](50)COLLATE Chinese_PRC_CI_AS,--��������
	[sUOM][varchar](10),--��λ
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,--����������
	[tCreateDate] [datetime] NULL ,--����ʱ��
	[sMemo] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL --˵��
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItemInfo] ADD 
	CONSTRAINT [PK_ItemInfo] PRIMARY KEY  CLUSTERED 
	(
		[sItem]
	)  ON [PRIMARY] 
GO


EXECUTE sp_addextendedproperty N'MS_Description', '���ϵ���', N'user', N'dbo', N'table', N'ItemInfo', NULL, NULL
go
exec sp_addextendedproperty N'MS_Description', N'���ϱ��', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItem'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItemName'
exec sp_addextendedproperty N'MS_Description', N'���Ϲ��', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sItemSpec'
exec sp_addextendedproperty N'MS_Description', N'һ������', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup1'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup2'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sClassGroup3'
exec sp_addextendedproperty N'MS_Description', N'��λ', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sUOM'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'ItemInfo', N'column', N'sMemo'
GO
sp_gettableinfo 'ItemInfo'
