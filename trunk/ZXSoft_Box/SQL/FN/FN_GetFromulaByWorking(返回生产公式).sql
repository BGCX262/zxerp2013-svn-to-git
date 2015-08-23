--select dbo.FN_GetFromulaByWorking('','001','A','��ѹ��')
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

-----Custid ȫƥ��	
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName

--Custid ����=ͨ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE 
	A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--Custid������=ͨ�á�����=ͨ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE A.sCustID=@sCustID
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--�ͻ�=ͨ�� ȫƥ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'ͨ��')='ͨ��'
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName
--�ͻ�=ͨ�� ����=ͨ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'ͨ��')='ͨ��'
	And IsNull(A.sPartTypeID,'')=IsNull(@sPartTypeID,'')  
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

--�ͻ�=ͨ�� ����=ͨ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'ͨ��')='ͨ��'
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=IsNull(@sFluteType,'')
	And A.sFormulaName=@sFormulaName

--�ͻ�=ͨ�� ����=ͨ��
if isnull(@sFormula,'')='' 
	SELECT @sFormula=A.sFormula
	FROM Bas_FormulaByWorking A
	WHERE isnull(A.sCustid,'ͨ��')='ͨ��'
	And IsNull(A.sPartTypeID,'')=''
	And IsNull(A.sFluteType,'')=''
	And A.sFormulaName=@sFormulaName

	RETURN(ISNULL(@sFormula,''))
END

