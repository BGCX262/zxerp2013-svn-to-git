
--sp_InitRoleAuthority '普通用户'
drop procedure c
go

--角色权限初始化
Create Procedure sp_InitRoleAuthority
(
	@sRole varchar(50)=''
	
)
WITH ENCRYPTION
as
	if isnull(@sRole,'')='' return

	SELECT 
		M.* 
	INTO 
		#sp_InitRoleAuthority
	FROM 
		sys_menu M 
		LEFT OUTER JOIN
	SYS_USER_AUTHORITY A 
	ON 
		m.sfunctionId=A.sfunctionId
		And A.srole=@sRole
	WHERE
		 A.srole IS NULL


--select * from sys_menu

IF NOT EXISTS (SELECT * FROM #sp_InitRoleAuthority) 	RETURN


	INSERT INTO 
		SYS_USER_AUTHORITY
		(sRole,
		sFunctionId,
		sFunctionName,
		IvalidFlag,
		sMemo
		)
	SELECT 
	@sRole,
	sFunctionId,
	sFunctionName,
	0,
	sMemo
	From
	#sp_InitRoleAuthority
		
