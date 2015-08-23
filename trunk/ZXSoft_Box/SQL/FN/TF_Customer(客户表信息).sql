
--select * from TF_Customer('001')

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE ID = OBJECT_ID(N'[dbo].[TF_Customer]') AND xType IN (N'FN', N'IF', N'TF'))
DROP FUNCTION [dbo].[TF_Customer]
go
CREATE FUNCTION dbo.TF_Customer
	(
	@sCustID 	VARCHAR(10)
	)
RETURNS @Customer TABLE
 (
	[sCustID] [varchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[sCustName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCustShortName] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCustQk] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCustLevel] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sSOClass] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCharge] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sTaxCode] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDept] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sLinkMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sTel1] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sTel2] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sFax] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sZip] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCompAddr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sDeliveryAddress] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCustArea] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sSalesMan] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[sCreateName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tCreateDate] [datetime] NULL ,
	[sModifierName] [varchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[tModifyDate] [datetime] NULL ,
	[sCurrency] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sMemo] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
	
) 
AS
BEGIN
	insert into @Customer select * from Bas_Customer A where A.sCustID=@sCustID

	RETURN
END
GO
