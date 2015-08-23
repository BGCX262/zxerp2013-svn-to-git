/*
返回对应客户平方价
select dbo.FN_GetFromulaBySales('','','','')
*/


--select * from dbo.Bas_FormulaBySales
--select dbo.FN_GetFromulaBySales ('001','001','内径','A')


drop FUNCTION dbo.FN_GetFromulaBySales
GO
CREATE FUNCTION dbo.FN_GetFromulaBySales
	(
	@sCustID 			VARCHAR(10),
	@sPartTypeID			VARCHAR(20),
	@sDimension 			VARCHAR(20),
	@sFluteType			VARCHAR(10)
	)
RETURNS varchar(500)
WITH ENCRYPTION
AS
BEGIN
	DECLARE @sFormula		VARCHAR(500)


---客户 盒式 sDimension sFluteType	
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')


---客户 盒式 sDimension sFluteType=null
if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And isnull(A.sFluteType,'')=''

---客户 盒式 sFluteType sDimension=null
if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And A.sCustID=@sCustID
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And IsNull(A.sDimension,'')=''

if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	AND IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	AND IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')

if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	And IsNull(A.sFluteType,'')=''

if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'通用')='通用'
	AND A.sPartTypeID=@sPartTypeID
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=''

	RETURN(ISNULL(@sFormula,''))
END
