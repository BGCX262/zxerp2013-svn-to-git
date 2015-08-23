



drop Procedure dbo.sp_InsertRouting
go
Create Procedure dbo.sp_InsertRouting
(
	@RoutingCalss VARCHAR(20),
	@sMachine	VARCHAR(20),
	@sWO	VARCHAR(20),
	@sBOM VARCHAR(20) ,
	@dRoutingNo	int
)
WITH ENCRYPTION
as
--set @sMachine=ltrim(rtrim(@sMachine))

	if @RoutingCalss='瓦楞机'
		begin

			INSERT INTO 
				PP_WCR
				(sWO,sBOM,dRoutingNo,sMachine)
			VALUES(@sWO,@sBOM,@dRoutingNo,@sMachine)
			
-----写法有问题，只更新插入这条记录	
			UPDATE 
				PP_WCR
			SET
				sBoardMaterial=A.sBoardMaterial
			FROM
				PP_WorkOrderExt A
			WHERE 
				A.sBOM=PP_WCR.sBOM
				And A.sWO=PP_WCR.sWO
				
			
				
		
			
	
		end

	if @RoutingCalss='水印'
		begin
			insert into 
				PP_WPrint_WBI
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end


	if @RoutingCalss='胶印'
		begin
			insert into 
				PP_WPrint_Offset 
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end


	if @RoutingCalss='模切'
		begin
			insert into 
				PP_WDieCut
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end



	if @RoutingCalss='粘合'
		begin
			insert into 
				PP_WGule
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end


	if @RoutingCalss='装钉'
		begin
			insert into 
				PP_WStitch
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end

	if @RoutingCalss='打包'
		begin
			insert into 
				PP_WPack
				(sWO,sBOM,dRoutingNo,sMachine)
				values(@sWO,@sBOM,@dRoutingNo,@sMachine)
	
		end






