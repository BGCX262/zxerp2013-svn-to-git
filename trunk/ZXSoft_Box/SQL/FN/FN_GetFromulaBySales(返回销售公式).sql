/*
���ض�Ӧ�ͻ�ƽ����
select dbo.FN_GetFromulaBySales('','','','')
*/


--select * from dbo.Bas_FormulaBySales
--select dbo.FN_GetFromulaBySales ('001','001','�ھ�','A')


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


---�ͻ� ��ʽ sDimension sFluteType	
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')


---�ͻ� ��ʽ sDimension sFluteType=null
if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'')  
	And isnull(A.sFluteType,'')=''

---�ͻ� ��ʽ sFluteType sDimension=null
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
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	AND IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	AND IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')

if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=IsNull(@sDimension,'') 
	And IsNull(A.sFluteType,'')=''

if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
if isnull(@sFormula,'')='' 
	SELECT @sFormula=sFormula
	FROM Bas_FormulaBySales A
	WHERE isnull(A.sCustID,'ͨ��')='ͨ��'
	AND A.sPartTypeID=@sPartTypeID
	And IsNull(A.sDimension,'')=''
	And IsNull(A.sFluteType,'')=''

	RETURN(ISNULL(@sFormula,''))
END
