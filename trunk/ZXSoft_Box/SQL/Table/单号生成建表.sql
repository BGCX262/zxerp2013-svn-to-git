if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TB_BILDEL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TB_BILDEL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TB_BILN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TB_BILN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TB_BILSET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TB_BILSET]
GO

CREATE TABLE [dbo].[TB_BILDEL] (
	[BIL_NO] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[USER] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[DEL_DD] [datetime] NULL ,
	[ISUES] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_BILN] (
	[BIL_ID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[BIL_SET] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ITM] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_BILSET] (
	[BIL_ID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[BIL_NM] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[BIL_PRE] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[DD_SET] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[SEQ_SET] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[BIL_SET] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TB_BILDEL] ADD 
	CONSTRAINT [PK_TB_BILDEL] PRIMARY KEY  CLUSTERED 
	(
		[BIL_NO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TB_BILN] ADD 
	CONSTRAINT [PK_TB_BILN] PRIMARY KEY  CLUSTERED 
	(
		[BIL_ID],
		[BIL_SET]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TB_BILSET] ADD 
	CONSTRAINT [PK_TB_BILSET] PRIMARY KEY  CLUSTERED 
	(
		[BIL_ID]
	)  ON [PRIMARY] 
GO

