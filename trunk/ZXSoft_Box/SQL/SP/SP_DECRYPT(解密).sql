drop PROCEDURE [dbo].[SP_DECRYPT]
go
CREATE PROCEDURE [dbo].[SP_DECRYPT]
(
	@ObjectName		VARCHAR(50)
)
WITH ENCRYPTION
AS
BEGIN

-- ZXSoft:kingry   copyright:2011.05.04
-- 破解字节不受限制，适用于SQLSERVER2000存储过程，函数，视图，触发器   

	SET NOCOUNT ON
	BEGIN TRANSACTION
	DECLARE @ObjectName1	VARCHAR(100),
			@OrgVarBin		VARBINARY(8000),
			@SQL1			NVARCHAR(4000),
			@SQL2			VARCHAR(8000),
			@SQL3			NVARCHAR(4000),
			@SQL4			NVARCHAR(4000),
			@OrigSpText1	NVARCHAR(4000),
			@OrigSpText2	NVARCHAR(4000),
			@OrigSpText3	NVARCHAR(4000),
			@resultSP		NVARCHAR(4000)

	DECLARE @i				INT,
			@status			INT,
			@type			VARCHAR(10),
			@ParentID		INT,
			@ColID			INT,
			@n				INT,
			@q				INT,
			@j				INT,
			@k				INT,
			@encrypted		INT,
			@number			INT

	SELECT @type = xtype, @ParentID = parent_obj FROM sysobjects WHERE id = OBJECT_ID(@objectname)

	CREATE TABLE #temp
	(
		number		int,
		colid		int,
		ctext		varbinary(8000),
		encrypted	int,
		status		int
	)

	INSERT #temp SELECT number,colid,ctext,encrypted,status FROM syscomments WHERE id = OBJECT_ID(@ObjectName)

	SELECT @number = MAX(number) FROM #temp
	SET @k = 0

	WHILE @k <= @number
	BEGIN
		IF exists(SELECT 1 FROM syscomments WHERE id = OBJECT_ID(@ObjectName) AND number = @k)
		BEGIN
			IF @type = 'P'
				SET @SQL1 = CASE WHEN @number > 1 THEN 'ALTER PROCEDURE ' + @ObjectName + ';' + RTRIM(@k) + ' WITH ENCRYPTION AS '
								ELSE 'ALTER PROCEDURE ' + @ObjectName + ' WITH ENCRYPTION AS '
							END

			IF @type = 'TR'
			BEGIN
				DECLARE @parent_obj			VARCHAR(255),
						@tr_parent_xtype	VARCHAR(10)

				SELECT @parent_obj = parent_obj FROM sysobjects WHERE id = OBJECT_ID(@ObjectName)
				SELECT @tr_parent_xtype = xtype FROM sysobjects WHERE id = @parent_obj

				IF @tr_parent_xtype = 'V'
					SET @SQL1 = 'ALTER TRIGGER ' + @ObjectName + ' ON ' + OBJECT_NAME(@ParentID) + ' WITH ENCRYPTION INSTEAD OF INSERT AS PRINT 1 '
				ELSE
					SET @SQL1 = 'ALTER TRIGGER ' + @ObjectName + ' ON ' + OBJECT_NAME(@ParentID) + ' WITH ENCRYPTION FOR INSERT AS PRINT 1 '
			END

			IF @type IN ('FN','TF','IF')
				SET @SQL1 = 'ALTER FUNCTION ' + @ObjectName + 
							CASE @type
								WHEN 'TF' THEN '(@A CHAR(1)) RETURNS @B TABLE(A VARCHAR(10)) WITH ENCRYPTION AS BEGIN INSERT @B SELECT @A RETURN END'
								WHEN 'FN' THEN '(@A CHAR(1)) RETURNS CHAR(1) WITH ENCRYPTION AS BEGIN RETURN @A END'
								WHEN 'IF' THEN '(@A CHAR(1)) RETURNS TABLE WITH ENCRYPTION AS RETURN SELECT @A AS A'
							END

			IF @type = 'V'
			SET @SQL1 = 'ALTER VIEW ' + @objectname + ' WITH ENCRYPTION AS SELECT 1 AS F'


			SET @q = LEN(@SQL1)
			SET @SQL1 = @SQL1 + REPLICATE('-',4000-@q)
			SET @SQL2 = REPLICATE('-',8000)
			SET @SQL3 = 'EXEC(@SQL1'
			SELECT @ColID = MAX(ColID) FROM #temp WHERE number = @k

			SET @n = 1
			WHILE @n <= CEILING(1.0*(@ColID-1)/2) AND LEN(@SQL3)<=3996
			BEGIN
				SET @SQL3 = @SQL3 + '+@'
				SET @n = @n + 1
			END

			SET @SQL3 = @SQL3 + ')'
			EXEC SP_EXECUTESQL @SQL3, N'@SQL1 NVARCHAR(4000),@ VARCHAR(8000)', @SQL1 = @SQL1, @ = @SQL2
		END

		SET @k = @k + 1
	END

	SET @k = 0
	WHILE @k <= @number
	BEGIN
		IF exists(SELECT 1 FROM syscomments WHERE id = OBJECT_ID(@ObjectName) AND number = @k)
		BEGIN
			SELECT @ColID = MAX(ColID) FROM #temp WHERE number = @k

			SET @n = 1
			WHILE @n <= @ColID
			BEGIN
				SELECT @OrigSpText1 = ctext, @encrypted = encrypted, @status = status FROM #temp WHERE ColID = @n AND number = @k
				SELECT @OrigSpText3 = ctext FROM syscomments WHERE ID = OBJECT_ID(@ObjectName) AND ColID = @n AND number = @k

				IF @n = 1
				BEGIN
					IF @type = 'P'
						SET @OrigSpText2 = CASE WHEN @number > 1 THEN 'CREATE PROCEDURE ' + @ObjectName + ';' + RTRIM(@k) + ' WITH ENCRYPTION AS '
												ELSE 'CREATE PROCEDURE '+ @ObjectName +' WITH ENCRYPTION AS '
											END

					IF @type IN ('FN','TF','IF')
					SET @OrigSpText2 = 'CREATE FUNCTION ' + @ObjectName + 
										CASE @type
											WHEN 'TF' THEN '(@A CHAR(1)) RETURNS @B TABLE(A VARCHAR(10)) WITH ENCRYPTION AS BEGIN INSERT @B SELECT @A RETURN END'
											WHEN 'FN' THEN '(@A CHAR(1)) RETURNS CHAR(1) WITH ENCRYPTION AS BEGIN RETURN @A END'
											WHEN 'IF' THEN '(@A CHAR(1)) RETURNS TABLE WITH ENCRYPTION AS RETURN SELECT @A AS A'
										END

					IF @type = 'TR'
					BEGIN
						IF @tr_parent_xtype = 'V'
							SET @OrigSpText2 = 'CREATE TRIGGER ' + @ObjectName + ' ON ' + OBJECT_NAME(@ParentID) + ' WITH ENCRYPTION INSTEAD OF INSERT AS PRINT 1 '
						ELSE
							SET @OrigSpText2 = 'CREATE TRIGGER ' + @ObjectName + ' ON ' + OBJECT_NAME(@ParentID) + ' WITH ENCRYPTION FOR INSERT AS PRINT 1 '
					END

					IF @type = 'V'
					SET @OrigSpText2 = 'CREATE VIEW ' + @objectname + ' WITH ENCRYPTION AS SELECT 1 AS F'

					SET @q = 4000 - LEN(@OrigSpText2)
					SET @OrigSpText2 = @OrigSpText2 + REPLICATE('-', @q)
				END
				ELSE
					SET @OrigSpText2 = REPLICATE('-', 4000)

				SET @i = 1
				SET @ResultSP = REPLICATE(N'A', (DATALENGTH(@OrigSpText1) / 2))

				WHILE @i <= DATALENGTH(@OrigSpText1) / 2
				BEGIN
					SET @ResultSP = STUFF(@resultsp, @i, 1, NCHAR(UNICODE(substring(@OrigSpText1, @i, 1)) ^ (UNICODE(SUBSTRING(@OrigSpText2, @i, 1)) ^ UNICODE(SUBSTRING(@OrigSpText3, @i, 1)))))
					SET @i = @i + 1
				END

				SET @OrgVarBin = CAST(@OrigSpText1 as   varbinary(8000))   
				SET @ResultSP = CASE
									WHEN @encrypted = 1 THEN @ResultSP
									ELSE CONVERT(NVARCHAR(4000),CASE WHEN @status&2 = 2 THEN UNCOMPRESS(@OrgVarBin) ELSE @OrgVarBin END)
								END

				PRINT @ResultSP

				SET @n = @n + 1
			END
		END
		SET @k = @k + 1
	END

	DROP TABLE #temp
	ROLLBACK TRANSACTION

END

