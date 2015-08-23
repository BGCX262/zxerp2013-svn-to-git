create   function   f_GetPySZ(@str   nvarchar(4000)) 
returns   nvarchar(4000) 
as 
begin 
declare   @strlen   int,@re   nvarchar(4000) 
declare   @t   table(chr   nchar(1)   collate   Chinese_PRC_CI_AS,letter   nchar(1)) 
insert   into   @t(chr,letter) 
    select   '߹ ', 'A '   union   all   select   '�� ', 'B '   union   all 
    select   '�� ', 'C '   union   all   select   '�� ', 'D '   union   all 
    select   '�� ', 'E '   union   all   select   '�� ', 'F '   union   all 
    select   '� ', 'G '   union   all   select   '�� ', 'H '   union   all 
    select   'آ ', 'J '   union   all   select   '�� ', 'K '   union   all 
    select   '�� ', 'L '   union   all   select   '�` ', 'M '   union   all 
    select   '�� ', 'N '   union   all   select   '�� ', 'O '   union   all 
    select   '�r ', 'P '   union   all   select   '�� ', 'Q '   union   all 
    select   '�� ', 'R '   union   all   select   '�� ', 'S '   union   all 
    select   '�� ', 'T '   union   all   select   '�� ', 'W '   union   all 
    select   'Ϧ ', 'X '   union   all   select   'Ѿ ', 'Y '   union   all 
    select   '�� ', 'Z ' 
    select   @strlen=len(@str),@re= ' ' 
    while   @strlen> 0 
    begin 
        select   top   1   @re=letter+@re,@strlen=@strlen-1 
            from   @t   a   where   chr <=substring(@str,@strlen,1) 
            order   by   chr   desc 
        if   @@rowcount=0 
            select   @re=substring(@str,@strlen,1)+@re,@strlen=@strlen-1 
    end 
    return(@re) 
end 
go 
