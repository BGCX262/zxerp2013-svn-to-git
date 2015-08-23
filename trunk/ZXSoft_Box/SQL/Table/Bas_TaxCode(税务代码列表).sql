if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bas_TaxCode]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bas_TaxCode]
GO

CREATE TABLE [dbo].[Bas_TaxCode] (
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sTaxName] [varchar] (20) NULL ,
	[dTaxRate] [decimal](18, 4)NULL ,
	[bIsPriceIncludingTax] [bit] Null,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sMemo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bas_TaxCode] ADD 
	CONSTRAINT [PK_Bas_TaxCode] PRIMARY KEY  CLUSTERED 
	(
		[sTaxCode]
	)  ON [PRIMARY] 
GO






EXECUTE sp_addextendedproperty N'MS_Description', '˰������б�', N'user', N'dbo', N'table', N'Bas_TaxCode', NULL, NULL
go

exec sp_addextendedproperty N'MS_Description', N'˰�����', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'sTaxCode'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'sTaxName'
exec sp_addextendedproperty N'MS_Description', N'˰��', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'dTaxRate'
exec sp_addextendedproperty N'MS_Description', N'�۸�˰', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'bIsPriceIncludingTax'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'sCreateName'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'tCreateDate'
exec sp_addextendedproperty N'MS_Description', N'�޸�ʱ��', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'sModifierName'
exec sp_addextendedproperty N'MS_Description', N'�޸���', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'tModifyDate'
exec sp_addextendedproperty N'MS_Description', N'˵��', N'user', N'dbo', N'table', N'Bas_TaxCode', N'column', N'sMemo'
GO
sp_gettableinfo 'Bas_TaxCode'
