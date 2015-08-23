--select dbo.FN_GetsDimensiondExtral('010','001','����','a','W')
--select * from dbo.Bas_DimConvert

/*
(�������⾶ת���ߴ�LWH)
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
	DECLARE @����		Decimal(18,4)
	DECLARE @���		Decimal(18,4)
	DECLARE @�߼�		Decimal(18,4)
	DECLARE @ReturnValue	Decimal(18,4)

if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID and sDimension=@sDimension and sFluteType=@sFluteType )
--�ͻ� ��ʽ sDimension sFluteType	
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE A.sCustID=@sCustID
	And A.sPartTypeID=@sPartTypeID
	And A.sDimension=@sDimension
	And A.sFluteType=@sFluteType

if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID and sDimension=@sDimension and isnull(sFluteType,'')='' )
---�ͻ� ��ʽ sDimension sFluteType=null
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And isnull(A.sFluteType,'')=''


---�ͻ� ��ʽ sFluteType sDimension=null
if Exists(Select * from [Bas_DimConvert] where sCustID=@sCustID and sPartTypeID=@sPartTypeID And IsNull(sDimension,'')='' and IsNull(sFluteType,'')=IsNull(@sFluteType,'') )
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE 
		A.sCustID=@sCustID
	and IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And IsNull(A.sDimension,'')=''

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'ͨ��')='ͨ��' and sPartTypeID=@sPartTypeID and sDimension=@sDimension and sFluteType=@sFluteType )
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	AND IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	AND IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'ͨ��')='ͨ��' and sPartTypeID=@sPartTypeID and sDimension=@sDimension and IsNull(sFluteType,'')='' )
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	And IsNull(A.sFluteType,'')=''

if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'ͨ��')='ͨ��' and sPartTypeID=@sPartTypeID and IsNull(sDimension,'')='' and IsNull(sFluteType,'')=IsNull(@sFluteType,'') )
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
if Exists(Select * from [Bas_DimConvert] where isnull(sCustID,'ͨ��')='ͨ��' and sPartTypeID=@sPartTypeID and isNull(sDimension,'')='' and IsNull(sFluteType,'')='' )
	SELECT 	@����=dExtraL,
			@���=dExtraW,
			@�߼�=dExtraH
	FROM Bas_DimConvert A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND A.sPartTypeID=@sPartTypeID
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=''
	
	if @LWH='L'
		select @ReturnValue=ISNULL(@����,0)
	if @LWH='W'
		select @ReturnValue=ISNULL(@���,0)
	if @LWH='H'
		select @ReturnValue=ISNULL(@�߼�,0)

	return @ReturnValue

END
