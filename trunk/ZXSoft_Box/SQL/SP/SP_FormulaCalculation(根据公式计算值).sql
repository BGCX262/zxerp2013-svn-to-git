drop PROCEDURE dbo.SP_FormulaCalculation
go
CREATE PROCEDURE dbo.SP_FormulaCalculation

	@formula		VARCHAR(500), 
	@SQLString	NVARCHAR(1000), 
	@CalcValue		FLOAT OUTPUT
WITH ENCRYPTION
AS
	IF ISNULL(@Formula,'') ='' 
		SET @CalcValue = NULL
	ELSE
	BEGIN
		CREATE TABLE #CalcValue (CalcVal FLOAT)
		SET @SQLString=N'Insert INTO #CalcValue SELECT '+@formula + '  FROM ('+@SQLString+') TEMP'
		IF ISNULL(@SQLString,'') <> ''
		BEGIN
			EXEC SP_executeSQL @SQLString
			SELECT @CalcValue=(SELECT TOP 1 * FROM #CalcValue)
		END
	END

	SET @CalcValue=ISNULL(@CalcValue,0)
