--select dbo.FN_GetFromulaByWorking('','001','A','长压线')
--select * from Bas_FormulaByWorking

drop FUNCTION dbo.FN_GetFromulaByWorking
go

CREATE FUNCTION dbo.FN_GetFromulaByWorking
	(
	@sCustID 				VARCHAR(20),
	@sPartTypeID				VARCHAR(20),
	@sFluteType 				VARCHAR(10),
	@sFormulaName			VARCHAR(100)
	)
RETURNS varchar(500)
WITH ENCRYPTION
AS
BEGIN
	DECLARE @sFormula			VARCHAR(500)

-----Custid 全匹配	
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName

--Custid 瓦楞=通用
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE 
	A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--Custid、箱型=通用、瓦楞=通用
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--客户=通用 全匹配
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'通用')='通用'
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName
--客户=通用 瓦楞=通用
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'通用')='通用'
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--客户=通用 箱型=通用
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'通用')='通用'
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName

--客户=通用 箱型=通用
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'通用')='通用'
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

	RETURN(ISNULL(@sFormula,''))
END

