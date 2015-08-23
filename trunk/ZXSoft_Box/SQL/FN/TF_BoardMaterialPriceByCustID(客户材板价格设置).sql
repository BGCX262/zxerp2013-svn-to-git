IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE ID = OBJECT_ID(N'[dbo].[TF_BoardMaterialPriceByCustID]') AND xType IN (N'FN', N'IF', N'TF'))
DROP FUNCTION [dbo].[TF_BoardMaterialPriceByCustID]
go
Create FUNCTION dbo.TF_BoardMaterialPriceByCustID
	(
	@sCustID 	VARCHAR(10)
	)
RETURNS @BoardMaterialPrice TABLE
 (
	
	[sFluteType] [varchar] (10)  ,
	[sBoardMaterial] [varchar] (100)  ,
	[tBeginDate] [datetime]  ,
	[tEndDate] [datetime]  ,
	[dMaterialPrice] [money]  ,
	[sMemo] [varchar] (50)   	
) 
AS
BEGIN
	insert into @BoardMaterialPrice 
	select 
		sFluteType,
		sBoardMaterial,
		tBeginDate,
		tEndDate,
		dMaterialPrice,
		sMemo 
	from 
		Bas_BoardMaterialPrice A 
	where 
		A.sCustID=@sCustID

	insert into 
		@BoardMaterialPrice 
		select 
		sFluteType,
		sBoardMaterial,
		tBeginDate,
		tEndDate,
		dMaterialPrice,
		sMemo 
	from 
		Bas_BoardMaterialPrice A 
		where 
		A.sCustID='Õ®”√' 
		and A.sFluteType+A.SBoardMaterial not in (select sFluteType+SBoardMaterial from Bas_BoardMaterialPrice A where A.sCustID=@sCustID)

	RETURN
END
