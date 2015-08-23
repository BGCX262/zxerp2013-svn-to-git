--返回开片尺寸
--SP_ProductCtnFormulaScoreByInfo 'AA','平口箱','A','SELECT 463 as 长, 263 as 宽,172 as 高','板宽',''
--select dbo.FN_GetFromulaByWorking('AA','平口箱','A','板长')
drop PROCEDURE dbo.SP_ProductCtnFormulaScoreByValue
go
create PROCEDURE dbo.SP_ProductCtnFormulaScoreByValue
	@CustID			VARCHAR(20),
 	@PartTypeID		VARCHAR(50),
 	@FluteType			VARCHAR(20),
	@SQLStr			VARCHAR(500),
	@FormulaName		VARCHAR(50),
	@svalue		VARCHAR(50) output
WITH ENCRYPTION
AS
Declare @Formula 		nVARCHAR(500)
DECLARE @CalFormula		VARCHAR(200)
DECLARE @i				Integer
DECLARE @Result			decimal(20,4)
DECLARE	@value			decimal(20,4)
DECLARE	@Score1			decimal(20,4) 
DECLARE	@Score2			decimal(20,4) 
DECLARE	@Score3			decimal(20,4) 
DECLARE	@Score4			decimal(20,4) 
DECLARE	@Score5			decimal(20,4) 
DECLARE	@Score6			decimal(20,4) 
DECLARE	@Score7			decimal(20,4)

--set @Scoreinfo=''
Set @value=0

select @Formula=dbo.FN_GetFromulaByWorking(@CustID, @PartTypeID, @FluteType,@FormulaName)





set @Formula=replace(@Formula,'        ',' ')
set @Formula=replace(@Formula,'       ',' ')
set @Formula=replace(@Formula,'      ',' ')
set @Formula=replace(@Formula,'     ',' ')
set @Formula=replace(@Formula,'    ',' ')
set @Formula=replace(@Formula,'   ',' ')
set @Formula=replace(@Formula,'  ',' ')

DECLARE @DecimalPoints	SmallInt

-- 
Select @DecimalPoints=0 


set @i=1
while @i<=7
begin
	select @CalFormula=dbo.FN_StrSubBySeperator(@Formula,' + ',@i)
	if isNull(@CalFormula,'') <> ''
		exec SP_FormulaCalculation @CalFormula,@SQLStr,@Result output

	SET @Result=isNull(@Result,0)
	

			Select @Result=CEILING(@Result*power(10,@DecimalPoints))/power(10,@DecimalPoints)



	if ((@i=1) and (isNull(@Result,0)>0)) 
	begin
	--set @Scoreinfo=@Scoreinfo+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=2) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=3) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=4) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=5) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=6) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
	if ((@i=7) and (isNull(@Result,0)>0))
	begin
	--set @Scoreinfo=@Scoreinfo+'+'+dbo.FT_FloatToString(@Result)
	set	@value=@value+@Result
	end
--print @Scoreinfo
--print dbo.FT_FloatToString(@value) 
	set @i=@i+1
	set @Result=0
end

select @svalue=convert(varchar(50),@value)
select @svalue
