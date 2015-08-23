drop PROCEDURE dbo.sp_GetTableInfo 
go
create PROCEDURE dbo.sp_GetTableInfo 
	@TableName	VARCHAR(500)=''
as
	
	set @TableName=replace(@TableName,'dbo.','')
		SELECT   
		--表名=case   when   a.colorder=1   then   d.name   else   ''   end, 
		表名=d.name,
		--表说明=case   when   a.colorder=1   then   isnull(f.value, '')   else   ''   end, 
		表说明=isnull(f.value, ''),
		字段序号=a.colorder, 
		字段名=a.name, 
		字段说明=isnull(g.[value], '') ,
		标识=case   when   COLUMNPROPERTY(a.id,a.name, 'IsIdentity')=1   then   '√ 'else   ''   end, 
		主键=case   when   exists(SELECT   1   FROM   sysobjects   where   xtype= 'PK '   and   parent_obj=a.id   and   name   in   ( 
		SELECT   name   FROM   sysindexes   WHERE   indid   in( 
		SELECT   indid   FROM   sysindexkeys   WHERE   id   =   a.id   AND   colid=a.colid 
		)))   then   '√ '   else   ''   end, 
		类型=b.name, 
		占用字节数=a.length, 
		长度=COLUMNPROPERTY(a.id,a.name, 'PRECISION'), 
		小数位数=isnull(COLUMNPROPERTY(a.id,a.name, 'Scale'),0), 
		允许空=case   when   a.isnullable=1   then   '√ 'else   ''   end, 
		默认值=isnull(e.text, '')
		--字段说明=isnull(g.[value], '') 
		FROM   syscolumns   a 
		left   join   systypes   b   on   a.xusertype=b.xusertype 
		inner   join   sysobjects   d   on   a.id=d.id     and   d.xtype= 'U '   and     d.name <> 'dtproperties ' 
		left   join   syscomments   e   on   a.cdefault=e.id 
		LEFT JOIN sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id     
		LEFT JOIN sys.extended_properties f on a.id=f.major_id AND f.minor_id=0
		where ((@TableName='') or (d.name=@TableName))      --如果只查询指定表,加上此条件 
		order   by   a.id,a.colorder 
	
 


