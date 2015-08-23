--sp_FrxWO 'S120923001'
drop PROCEDURE dbo.sp_FrxWO
go 

Create PROCEDURE dbo.sp_FrxWO
	@sWO	VARCHAR(20)=''
WITH ENCRYPTION
as


	


	CREATE TABLE [#sp_FrxWO] (
	[sWO] [varchar] (20)  ,
	[sCustID] [varchar] (20)  ,
	[sBOM] [varchar] (20)  ,
	[sSO] [varchar] (20)  ,
	[sCustPO] [varchar] (100)  ,
	[sCustSubPO] [varchar] (100)  ,
	[tProddate] [datetime]  ,
	[dProdQty] [decimal](10, 4)  ,
	[sStatus] [varchar] (20)  ,
	[dAllowqty] [decimal](10, 4)  ,
	[dReceivedQty] [decimal](10, 4)  ,
	[sWOClass] [money]  ,
	[sMemo] [varchar] (500)  ,
	[sCreateName] [varchar] (10)  ,
	[tCreateDate] [datetime] ,
	[sMachine1] varchar(20),
	[sMachine2] varchar(20),
	[sMachine3] varchar(20),
	[sMachine4] varchar(20),
	[sMachine5] varchar(20),
	[sMachine6] varchar(20),
	[sMachine7] varchar(20),
	[sMachine8] varchar(20),
	[sMachine9] varchar(20),
	[sMachine10] varchar(20),
	[sMachine11] varchar(20),
	[sMachine12] varchar(20),
	[sMachine13] varchar(20),
	[sPartTypeID] [varchar] (20)   ,
--瓦楞,
	
	[Picture][image],
	[sBoardMaterialByWork] [varchar] (100)   ,
	[dMFL] [decimal](10, 4)  ,
	[dMFW] [decimal](10, 4)  ,
	[dMFH] [decimal](10, 4)  ,
	[dCRLength] [decimal](10, 4)  ,
	[dCRWidth] [decimal](10, 4)  ,
	[sCRLineL] [varchar] (200)   ,
	[sCRLineW] [varchar] (200)   ,
	[dPaperWidth] [decimal](10, 4)  ,
--模切
	[sDieCutPlate1] [varchar] (100)  ,
	[sDieCutPlate2] [varchar] (100)  ,
	[sDieCutPlate3] [varchar] (100)  ,
	[dDieCutLength] [decimal](10, 4)  ,
	[dDieCutWidth] [decimal](10, 4)  ,
--粘合
	[sGuleMethod] [varchar] (20)  ,
	[sGuleMaterial] [varchar] (100)  ,
	[dGuleArea] [decimal](10, 4)  ,
	[dGuleQty] [decimal](10, 4)  ,
--打包
	[sPackMathod] [varchar] (20)  ,
	[sPackMaterial] [varchar] (100)  ,
	[iPackQty] [int]  ,
--胶印
	[iPrintColors] [varchar] (20)  ,
	[sColor1] [varchar] (20)  ,
	[sColor2] [varchar] (20)  ,
	[sColor3] [varchar] (20)  ,
	[sColor4] [varchar] (20)  ,
	[sColor5] [varchar] (20)  ,
	[sColor6] [varchar] (20)  ,
	[sColor7] [varchar] (20)  ,
	[sColor8] [varchar] (20)  ,
	[sBackingUpColor1] [varchar] (20)  ,
	[sBackingUpColor2] [varchar] (20)  ,
	[sBackingUpColor3] [varchar] (20)  ,
	[sBackingUpColor4] [varchar] (20)  ,
	[sBackingUpColor5] [varchar] (20)  ,
	[sBackingUpColor6] [varchar] (20)  ,
	[sBackingUpColor7] [varchar] (20)  ,
	[sBackingUpColor8] [varchar] (20)  ,
--水印
	[iWPrintColors] [varchar] (20)  ,
	[sWColor1] [varchar] (20)  ,
	[sWColor2] [varchar] (20)  ,
	[sWColor3] [varchar] (20)  ,
	[sWColor4] [varchar] (20)  ,
--装钉
	[sStitchMathod] [varchar] (20)  ,
	[sStitchMaterial] [varchar] (100)  ,
	[dStitchQty] [decimal](10, 4)  ,
	[RoutingLine][varchar] (1000)  ,
	
)

		INSERT INTO [#sp_FrxWO]
			([sWO], [sCustID], [sBOM], [sSO], [tProddate], [dProdQty], [sStatus], [dAllowqty], [dReceivedQty], [sWOClass], [sMemo], [sCreateName], [tCreateDate])
			
		select 
			[sWO], [sCustID], [sBOM], [sSO],  [tProddate], [dProdQty], [sStatus], [dAllowqty], [dReceivedQty], [sWOClass], [sMemo], [sCreateName], [tCreateDate]
		from 
		PP_WorkOrder
		where sWO=@sWO
	
	
	DECLARE	@i				INTEGER
	DECLARE	@dRoutingNo		INTEGER
	DECLARE	@sMachine		VARCHAR(20)
	DECLARE	@RoutingLine		VARCHAR(1000)

	
		set @RoutingLine=''


		DECLARE TC_Routing CURSOR SCROLL FOR
			SELECT
				dRoutingNo,
				sMachine
				
			FROM
				PP_Routing 
			WHERE sWO=@sWO--
			ORDER BY
				--sBOM,
				dRoutingNo

		SET @i=1
		OPEN TC_Routing
		FETCH FIRST FROM TC_Routing INTO @dRoutingNo, @sMachine
		WHILE (@@fetch_Status=0) AND (@i<=12)
		BEGIN
			IF @i=1
				UPDATE #sp_FrxWO SET sMachine1=@sMachine,@RoutingLine=@RoutingLine+@sMachine WHERE sWO=@sWO
			ELSE IF @i=2
				UPDATE #sp_FrxWO SET sMachine2=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=3
				UPDATE #sp_FrxWO SET sMachine3=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=4
				UPDATE #sp_FrxWO SET sMachine4=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=5
				UPDATE #sp_FrxWO SET sMachine5=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=6
				UPDATE #sp_FrxWO SET sMachine6=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=7
				UPDATE #sp_FrxWO SET sMachine7=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=8
				UPDATE #sp_FrxWO SET sMachine8=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=9
				UPDATE #sp_FrxWO SET sMachine9=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=10
				UPDATE #sp_FrxWO SET sMachine10=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=11
				UPDATE #sp_FrxWO SET sMachine11=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			ELSE IF @i=12
				UPDATE #sp_FrxWO SET sMachine12=@sMachine,@RoutingLine=@RoutingLine+'→'+@sMachine WHERE sWO=@sWO
			
			SET @i = @i + 1

			FETCH NEXT FROM TC_Routing INTO @dRoutingNo, @sMachine
		END
		CLOSE TC_Routing
		DEALLOCATE TC_Routing



	UPDATE 
		#sp_FrxWO
	SET 
 	[sBoardMaterialByWork]=A.sBoardMaterialByWork,
	[dMFL]=A.dMFL,
	[dMFW]=A.dMFW,
	[dMFH]=A.dMFH,
	[dCRLength]=A.dCRLength ,
	[dCRWidth]=A.dCRWidth,
	[sCRLineL]=A.sCRLineL,
	[sCRLineW]=A.sCRLineW,
	[dPaperWidth]=A.dPaperWidth 
	FROM
		dbo.PP_WCR A
	WHERE
		A.sWO=@sWO


	update #sp_FrxWO
		Set 
	iWPrintColors=A.iWPrintColors,
	sWColor1=A.sWColor1,
	sWColor2=A.sWColor2,
	sWColor3=A.sWColor3,
	sWColor4=A.sWColor4
	FROM
		PP_WPrint_WBI A
	WHERE
		A.sWO=@sWO
		


	update #sp_FrxWO
		Set 
	RoutingLine=@RoutingLine


	UPDATE 	#sp_FrxWO
		SET
	sPartTypeID=A.sPartTypeID
		From
		PP_WorkOrderExt A
		Where 
		A.sWO=#sp_FrxWO.sWO
	update #sp_FrxWO
		Set 
	Picture=A.Picture
	From
		Bas_PartType A
	Where
		A.sPartTypeID=#sp_FrxWO.sPartTypeID
	

select * from #sp_FrxWO


