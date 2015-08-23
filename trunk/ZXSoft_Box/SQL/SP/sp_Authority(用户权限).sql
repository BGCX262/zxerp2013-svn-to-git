drop PROCEDURE dbo.sp_Authority
go


create PROCEDURE dbo.sp_Authority
	@sRole	VARCHAR(50)=''
as

	


	CREATE TABLE [#sp_Authority] (
	[sRole] [varchar] (50)  ,
	[sFunctionID] [varchar] (50) ,
	[sFunctionName] [varchar] (50)  ,
	[iValidFlag] [int] NULL ,
	[sMemo] [varchar] (1000)  ,
	[sOperator] [varchar] (50)  ,
	[tCreateDate] [datetime] ,
	[sMenuGroupID][varchar] (50)
	)
	insert into 
		#sp_Authority
		(
		[sRole] ,
		[sFunctionID],
		[sFunctionName],
		[iValidFlag],
		[sMemo],
		[sOperator],
		[tCreateDate]
		
		)

	select 
		[sRole] ,
		[sFunctionID],
		[sFunctionName],
		[iValidFlag],
		[sMemo],
		[sOperator],
		[tCreateDate]
	from 
		SYS_User_Authority A
	Where 
		A.sRole=@sRole
--		And isnull(A.sMenuGroupID,'')<>''
	




	update 
		#sp_Authority  
	set 
		sMenuGroupID=M.sMenuGroupID

	from 
		SYS_Menu M
	Where M.sFunctionID=#sp_Authority.sFunctionID

	update 
		#sp_Authority  
	set 
		sMenuGroupID=M.sFunctionName

	from 
		(select * from SYS_Menu where isnull(sMenuGroupID,'')='') M
	Where M.sFunctionID=#sp_Authority.sMenuGroupID


	update 
		#sp_Authority  
	set 
		sMenuGroupID='Ö÷Ä£¿é'

	where isnull(sMenuGroupID,'')=''



select * from  #sp_Authority order by sMenuGroupID
