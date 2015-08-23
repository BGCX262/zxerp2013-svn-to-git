drop PROCEDURE dbo.SP_CalculateUnitPrice
go
CREATE PROCEDURE dbo.SP_CalculateUnitPrice
	@sCustID			VARCHAR(20),
 	@sPartTypeID		VARCHAR(20),
	@sDimension		VARCHAR(20),
	@sFluteType		VARCHAR(20),
	@sSQLStr			VARCHAR(500),
	@dPrice			DECIMAL(18,6) OUTPUT
WITH ENCRYPTION
AS
	DECLARE  @sFormula varChar(200)

	SELECT @sFormula=dbo.FN_GetFromulaBySales
						(
							@sCustID,
						 	@sPartTypeID,
							@sDimension,
							@sFluteType
						)
	SET @dPrice=0

	IF NOT @sFormula IS NULL
	BEGIN
		EXEC SP_FormulaCalculation @sFormula, @sSQLStr, @dPrice OUTPUT
--设置价格精度
		DECLARE @iPieceDecimal		INTEGER
		SET @iPieceDecimal=2
--四舍五入
		SET @dPrice=ROUND(CONVERT(DECIMAL(18,6),ISNULL(@dPrice,0)),@iPieceDecimal)
		select @dPrice
	END


