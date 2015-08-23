--select dbo.FN_GetsDimensiondExtral('010','001','生产','a','W')
--select * from dbo.Bas_DimConvert

/*
(返回内外径转化尺寸LWH)
*/




drop FUNCTION dbo.FN_GetsDimensiondExtral
GO
CREATE FUNCTION dbo.FN_GetsDimensiondExtral
	(
	@sCustID 			VARCHAR(20),
	@sPartTypeID				VARCHAR(20),
	@sDimension	 			VARCHAR(20),
	@sFluteType 				VARCHAR(10),
	@LWH					VARCHAR(10)
	)
RETURNS Decimal(18,4)
WITH ENCRYPTION
AS
BEGIN
	DECLARE @长加		Decimal(18,4)
	DECLARE @宽加		Decimal(18,4)
	DECLARE @高加		Decimal(18,4)
	DECLARE @ReturnValue	Decimal(18,4)

if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID and sDimension=@sDimension and sFluteType=@sFluteType )
--客户 盒式 sDimension sFluteType	
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE A.sCustID=@sCustID
	And A.sPartTypeID=@sPartTypeID
	And A.sDimension=@sDimension
	And A.sFluteType=@sFluteType

if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID and sDimension=@sDimension and isnull(sFluteType,'')='' )
---客户 盒式 sDimension sFluteType=null
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And isnull(A.sFluteType,'')=''


---客户 盒式 sFluteType sDimension=null
if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID And IsNull(sDimension,'')='' and IsNull(sFluteType,'')=IsNull(@sFluteType,'') )
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE 
		A.sCustID=@sCustID
	and IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And IsNull(A.sDimension,'')=''

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'通用')='通用' and sPartTypeID=@sPartTypeID and sDimension=@sDimension and sFluteType=@sFluteType )
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	AND IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	AND IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'通用')='通用' and sPartTypeID=@sPartTypeID and sDimension=@sDimension and IsNull(sFluteType,'')='' )
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	And IsNull(A.sFluteType,'')=''

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'通用')='通用' and sPartTypeID=@sPartTypeID and IsNull(sDimension,'')='' and IsNull(sFluteType,'')=IsNull(@sFluteType,'') )
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'通用')='通用' and sPartTypeID=@sPartTypeID and isNull(sDimension,'')='' and IsNull(sFluteType,'')='' )
	SELECT 	@长加=dExtraL,
			@宽加=dExtraW,
			@高加=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND A.sPartTypeID=@sPartTypeID
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=''
	
	if @LWH='L'
		select @ReturnValue=ISNULL(@长加,0)
	if @LWH='W'
		select @ReturnValue=ISNULL(@宽加,0)
	if @LWH='H'
		select @ReturnValue=ISNULL(@高加,0)

	return @ReturnValue

END
