CREATE function f_GetPy(@str varchar(100)) 
returns varchar(8000) 
as 
begin 
declare @re varchar(8000) 
--������ʱ�� 
--geovindu@163.com www.dusystem.com www.dupcit.com 
declare @geovindu table(chr nchar(2) collate Chinese_PRC_CS_AS_KS_WS,py nvarchar(20)) 
insert into @geovindu select N'߹','a' 
insert into @geovindu select N'��','aes' 
insert into @geovindu select N'��','ai' 
insert into @geovindu select N'��','an' 
insert into @geovindu select N'��','ang' 
insert into @geovindu select N'��','ao' 
insert into @geovindu select N'��','ba' 
insert into @geovindu select N'��','bai' 
insert into @geovindu select N'��','baike' 
insert into @geovindu select N'�B','baiwa' 
insert into @geovindu select N'��','ban' 
insert into @geovindu select N'��','bang' 
insert into @geovindu select N'��','bao' 
insert into @geovindu select N'�`','be' 
insert into @geovindu select N'��','bei' 
insert into @geovindu select N'��','ben' 
insert into @geovindu select N'��','beng' 
insert into @geovindu select N'�n','bi' 
insert into @geovindu select N'��','bian' 
insert into @geovindu select N'�m','uu' 
insert into @geovindu select N'��','biao' 
insert into @geovindu select N'��','bie' 
insert into @geovindu select N'��','bin' 
insert into @geovindu select N'��','bing' 
insert into @geovindu select N'�h','bo' 
insert into @geovindu select N'�m','bu' 
insert into @geovindu select N'��','ca' 
insert into @geovindu select N'��','cai' 
insert into @geovindu select N'�k','cal' 
insert into @geovindu select N'��','can' 
insert into @geovindu select N'��','cang' 
insert into @geovindu select N'��','cao' 
insert into @geovindu select N'��','ce' 
insert into @geovindu select N'�~','cen' 
insert into @geovindu select N'��','ceng' 
insert into @geovindu select N'��','ceok' 
insert into @geovindu select N'�K','ceom' 
insert into @geovindu select N'�e','ceon' 
insert into @geovindu select N'�u','ceor' 
insert into @geovindu select N'��','cha' 
insert into @geovindu select N'��','chai' 
insert into @geovindu select N'�{','chan' 
insert into @geovindu select N'��','chang' 
insert into @geovindu select N'��','chao' 
insert into @geovindu select N'��','che' 
insert into @geovindu select N'��','chen' 
insert into @geovindu select N'�p','cheng' 
insert into @geovindu select N'��','chi' 
insert into @geovindu select N'��','chong' 
insert into @geovindu select N'��','chou' 
insert into @geovindu select N'��','chu' 
insert into @geovindu select N'�u','chuai' 
insert into @geovindu select N'��','chuan' 
insert into @geovindu select N'�V','chuang' 
insert into @geovindu select N'��','chui' 
insert into @geovindu select N'�I','chun' 
insert into @geovindu select N'��','chuo' 
insert into @geovindu select N'��','ci' 
insert into @geovindu select N'��','cis' 
insert into @geovindu select N'��','cong' 
insert into @geovindu select N'��','cou' 
insert into @geovindu select N'��','cu' 
insert into @geovindu select N'��','cuan' 
insert into @geovindu select N'��','cui' 
insert into @geovindu select N'ߗ','cun' 
insert into @geovindu select N'��','cuo' 
insert into @geovindu select N'��','chua' 
insert into @geovindu select N'��','da' 
insert into @geovindu select N'߾','dai' 
insert into @geovindu select N'��','dan' 
insert into @geovindu select N'��','dang' 
insert into @geovindu select N'��','dao' 
insert into @geovindu select N'�z','de' 
insert into @geovindu select N'�g','dem' 
insert into @geovindu select N'�O','den' 
insert into @geovindu select N'��','deng' 
insert into @geovindu select N'��','di' 
insert into @geovindu select N'��','dia' 
insert into @geovindu select N'��','dian' 
insert into @geovindu select N'��','diao' 
insert into @geovindu select N'��','die' 
insert into @geovindu select N'�O','dei' 
insert into @geovindu select N'��','dim' 
insert into @geovindu select N'��','ding' 
insert into @geovindu select N'�G','diu' 
insert into @geovindu select N'��','dong' 
insert into @geovindu select N'��','dou' 
insert into @geovindu select N'��','du' 
insert into @geovindu select N'�Z','duan' 
insert into @geovindu select N'��','dug' 
insert into @geovindu select N'��','dui' 
insert into @geovindu select N'��','dun' 
insert into @geovindu select N'��','duo' 
insert into @geovindu select N'��','e' 
insert into @geovindu select N'�C','en' 
insert into @geovindu select N'�E','eng' 
insert into @geovindu select N'��','eo' 
insert into @geovindu select N'�s','eol' 
insert into @geovindu select N'��','eos' 
insert into @geovindu select N'��','er' 
insert into @geovindu select N'��','fa' 
insert into @geovindu select N'��','fan' 
insert into @geovindu select N'��','fang' 
insert into @geovindu select N'��','fei' 
insert into @geovindu select N'��','fen' 
insert into @geovindu select N'��','feng' 
insert into @geovindu select N'��','fenwa' 
insert into @geovindu select N'҅','fiao' 
insert into @geovindu select N'��','fo' 
insert into @geovindu select N'��','fou' 
insert into @geovindu select N'��','fu' 
insert into @geovindu select N'�g','fui' 
insert into @geovindu select N'�','ga' 
insert into @geovindu select N'��','gai' 
insert into @geovindu select N'��','gan' 
insert into @geovindu select N'��','gang' 
insert into @geovindu select N'��','gao' 
insert into @geovindu select N'��','ge' 
insert into @geovindu select N'��','gei' 
insert into @geovindu select N'��','gen' 
insert into @geovindu select N'��','geng' 
insert into @geovindu select N'��','geu' 
insert into @geovindu select N'��','gib' 
insert into @geovindu select N'��','go' 
insert into @geovindu select N'��','gong' 
insert into @geovindu select N'��','gongfen' 
insert into @geovindu select N'��','gongli' 
insert into @geovindu select N'��','gou' 
insert into @geovindu select N'��','gu' 
insert into @geovindu select N'��','gua' 
insert into @geovindu select N'��','guai' 
insert into @geovindu select N'��','guan' 
insert into @geovindu select N'��','guang' 
insert into @geovindu select N'��','gui' 
insert into @geovindu select N'ح','gun' 
insert into @geovindu select N'��','guo' 
insert into @geovindu select N'�o','ha' 
insert into @geovindu select N'��','hai' 
insert into @geovindu select N'�a','hal' 
insert into @geovindu select N'��','han' 
insert into @geovindu select N'�','hang' 
insert into @geovindu select N'ƒ','hao' 
insert into @geovindu select N'��','haoke' 
insert into @geovindu select N'ڭ','he' 
insert into @geovindu select N'�\','hei' 
insert into @geovindu select N'��','hen' 
insert into @geovindu select N'��','heng' 
insert into @geovindu select N'��','heui' 
insert into @geovindu select N'�Y','ho' 
insert into @geovindu select N'�b','hol' 
insert into @geovindu select N'��','hong' 
insert into @geovindu select N'�J','hou' 
insert into @geovindu select N'��','hu' 
insert into @geovindu select N'��','hua' 
insert into @geovindu select N'��','huai' 
insert into @geovindu select N'��','huan' 
insert into @geovindu select N'�x','huang' 
insert into @geovindu select N'��','hui' 
insert into @geovindu select N'��','hun' 
insert into @geovindu select N'��','huo' 
insert into @geovindu select N'��','geo' 
insert into @geovindu select N'��','hwa' 
insert into @geovindu select N'آ','ji' 
insert into @geovindu select N'��','jia' 
insert into @geovindu select N'��','jialun' 
insert into @geovindu select N'�','jian' 
insert into @geovindu select N'��','jiang' 
insert into @geovindu select N'ܴ','jiao' 
insert into @geovindu select N'��','jie' 
insert into @geovindu select N'��','jin' 
insert into @geovindu select N'�i','jing' 
insert into @geovindu select N'��','jiong' 
insert into @geovindu select N'�L','jiu' 
insert into @geovindu select N'��','jou' 
insert into @geovindu select N'�H','ju' 
insert into @geovindu select N'��','juan' 
insert into @geovindu select N'��','jue' 
insert into @geovindu select N'��','jun' 
insert into @geovindu select N'��','ka' 
insert into @geovindu select N'��','kai' 
insert into @geovindu select N'�f','kal' 
insert into @geovindu select N'��','kan' 
insert into @geovindu select N'��','hem' 
insert into @geovindu select N'�T','kang' 
insert into @geovindu select N'��','kao' 
insert into @geovindu select N'��','ke' 
insert into @geovindu select N'�G','ken' 
insert into @geovindu select N'��','keng' 
insert into @geovindu select N'�|','keo' 
insert into @geovindu select N'�g','keol' 
insert into @geovindu select N'�{','keos' 
insert into @geovindu select N'��','keum' 
insert into @geovindu select N'�]','ki' 
insert into @geovindu select N'��','kong' 
insert into @geovindu select N'�W','kos' 
insert into @geovindu select N'��','kou' 
insert into @geovindu select N'�H','ku' 
insert into @geovindu select N'��','kua' 
insert into @geovindu select N'��','kuai' 
insert into @geovindu select N'��','kuan' 
insert into @geovindu select N'��','kuang' 
insert into @geovindu select N'��','kui' 
insert into @geovindu select N'��','kun' 
insert into @geovindu select N'��','kuo' 
insert into @geovindu select N'�i','kweok' 
insert into @geovindu select N'��','la' 
insert into @geovindu select N'��','lai' 
insert into @geovindu select N'��','lan' 
insert into @geovindu select N'�','lang' 
insert into @geovindu select N'��','lao' 
insert into @geovindu select N'��','le' 
insert into @geovindu select N'��','lei' 
insert into @geovindu select N'ܨ','leng' 
insert into @geovindu select N'�o','li' 
insert into @geovindu select N'��','lia' 
insert into @geovindu select N'��','lian' 
insert into @geovindu select N'�|','liang' 
insert into @geovindu select N'�G','liao' 
insert into @geovindu select N'��','lie' 
insert into @geovindu select N'��','lin' 
insert into @geovindu select N'��','ling' 
insert into @geovindu select N'��','liu' 
insert into @geovindu select N'�F','liwa' 
insert into @geovindu select N'��','lo' 
insert into @geovindu select N'��','long' 
insert into @geovindu select N'¦','lou' 
insert into @geovindu select N'��','lu' 
insert into @geovindu select N'¿','lv' 
insert into @geovindu select N'��','lue' 
insert into @geovindu select N'��','luan' 
insert into @geovindu select N'��','lun' 
insert into @geovindu select N'�b','luo' 
insert into @geovindu select N'��','m' 
insert into @geovindu select N'��','ma' 
insert into @geovindu select N'�j','hweong' 
insert into @geovindu select N'��','mai' 
insert into @geovindu select N'�','man' 
insert into @geovindu select N'��','mang' 
insert into @geovindu select N'��','mangmi' 
insert into @geovindu select N'è','mao' 
insert into @geovindu select N'�x','mas' 
insert into @geovindu select N'��','me' 
insert into @geovindu select N'��','mei' 
insert into @geovindu select N'��','men' 
insert into @geovindu select N'��','meng' 
insert into @geovindu select N'�_','meo' 
insert into @geovindu select N'�[','mi' 
insert into @geovindu select N'�','mian' 
insert into @geovindu select N'��','miao' 
insert into @geovindu select N'ؿ','mie' 
insert into @geovindu select N'��','miliklanm' 
insert into @geovindu select N'��','min' 
insert into @geovindu select N'��','lem' 
insert into @geovindu select N'��','ming' 
insert into @geovindu select N'��','miu' 
insert into @geovindu select N'��','mo' 
insert into @geovindu select N'�i','mol' 
insert into @geovindu select N'��','mou' 
insert into @geovindu select N'ĸ','mu' 
insert into @geovindu select N'��','myeo' 
insert into @geovindu select N'�C','myeon' 
insert into @geovindu select N'��','myeong' 
insert into @geovindu select N'��','na' 
insert into @geovindu select N'�G','nai' 
insert into @geovindu select N'��','nan' 
insert into @geovindu select N'��','nang' 
insert into @geovindu select N'�e','keg' 
insert into @geovindu select N'ث','nao' 
insert into @geovindu select N'��','ne' 
insert into @geovindu select N'��','nei' 
insert into @geovindu select N'��','nem' 
insert into @geovindu select N'��','nen' 
insert into @geovindu select N'ǂ','neus' 
insert into @geovindu select N'�','ngag' 
insert into @geovindu select N'�G','ngai' 
insert into @geovindu select N'��','ngam' 
insert into @geovindu select N'��','ni' 
insert into @geovindu select N'��','nian' 
insert into @geovindu select N'��','niang' 
insert into @geovindu select N'��','niao' 
insert into @geovindu select N'��','nie' 
insert into @geovindu select N'À','nin' 
insert into @geovindu select N'��','ning' 
insert into @geovindu select N'ţ','niu' 
insert into @geovindu select N'ũ','nong' 
insert into @geovindu select N'��','nou' 
insert into @geovindu select N'ū','nu' 
insert into @geovindu select N'Ů','nv' 
insert into @geovindu select N'ű','nue' 
insert into @geovindu select N'��','nve' 
insert into @geovindu select N'�f','nuan' 
insert into @geovindu select N'�Q','nun' 
insert into @geovindu select N'�\','nung' 
insert into @geovindu select N'Ų','nuo' 
insert into @geovindu select N'�p','o' 
insert into @geovindu select N'��','oes' 
insert into @geovindu select N'�j','ol' 
insert into @geovindu select N'�M','on' 
insert into @geovindu select N'ک','ou' 
insert into @geovindu select N'�r','pa' 
insert into @geovindu select N'ٽ','pai' 
insert into @geovindu select N'�s','pak' 
insert into @geovindu select N'�e','pan' 
insert into @geovindu select N'��','pang' 
insert into @geovindu select N'��','pao' 
insert into @geovindu select N'��','pei' 
insert into @geovindu select N'��','pen' 
insert into @geovindu select N'��','peng' 
insert into @geovindu select N'��','peol' 
insert into @geovindu select N'��','phas' 
insert into @geovindu select N'�C','phdeng' 
insert into @geovindu select N'�n','phoi' 
insert into @geovindu select N'��','phos' 
insert into @geovindu select N'ا','pi' 
insert into @geovindu select N'��','pian' 
insert into @geovindu select N'��','piao' 
insert into @geovindu select N'�','pie' 
insert into @geovindu select N'د','pianpang' 
insert into @geovindu select N'�','pin' 
insert into @geovindu select N'ƹ','ping' 
insert into @geovindu select N'��','po' 
insert into @geovindu select N'��','pou' 
insert into @geovindu select N'�V','deo' 
insert into @geovindu select N'��','ppun' 
insert into @geovindu select N'��','pu' 
insert into @geovindu select N'��','qi' 
insert into @geovindu select N'��','qia' 
insert into @geovindu select N'ǧ','qian' 
insert into @geovindu select N'Ǽ','qiang' 
insert into @geovindu select N'��','qianke' 
insert into @geovindu select N'��','qianwa' 
insert into @geovindu select N'��','qiao' 
insert into @geovindu select N'�j','qie' 
insert into @geovindu select N'��','qin' 
insert into @geovindu select N'ψ','kem' 
insert into @geovindu select N'��','qing' 
insert into @geovindu select N'��','qiong' 
insert into @geovindu select N'��','qiu' 
insert into @geovindu select N'��','qu' 
insert into @geovindu select N'ޑ','keop' 
insert into @geovindu select N'�Z','quan' 
insert into @geovindu select N'�U','que' 
insert into @geovindu select N'��','qun' 
insert into @geovindu select N'��','ra' 
insert into @geovindu select N'��','ram' 
insert into @geovindu select N'��','ran' 
insert into @geovindu select N'�y','rang' 
insert into @geovindu select N'��','rao' 
insert into @geovindu select N'��','re' 
insert into @geovindu select N'��','ren' 
insert into @geovindu select N'��','reng' 
insert into @geovindu select N'��','ri' 
insert into @geovindu select N'��','rong' 
insert into @geovindu select N'�b','rou' 
insert into @geovindu select N'�]','ru' 
insert into @geovindu select N'��','ruan' 
insert into @geovindu select N'�M','rui' 
insert into @geovindu select N'��','run' 
insert into @geovindu select N'��','ruo' 
insert into @geovindu select N'��','sa' 
insert into @geovindu select N'��','saeng' 
insert into @geovindu select N'��','sai' 
insert into @geovindu select N'̃','sal' 
insert into @geovindu select N'��','san' 
insert into @geovindu select N'��','sang' 
insert into @geovindu select N'��','sao' 
insert into @geovindu select N'ɫ','se' 
insert into @geovindu select N'�S','sed' 
insert into @geovindu select N'�{','sei' 
insert into @geovindu select N'ɭ','sen' 
insert into @geovindu select N'�O','seng' 
insert into @geovindu select N'�~','seo' 
insert into @geovindu select N'�L','seon' 
insert into @geovindu select N'ɱ','sha' 
insert into @geovindu select N'ɸ','shai' 
insert into @geovindu select N'ɽ','shan' 
insert into @geovindu select N'��','shang' 
insert into @geovindu select N'��','shao' 
insert into @geovindu select N'��','she' 
insert into @geovindu select N'��','shen' 
insert into @geovindu select N'��','sheng' 
insert into @geovindu select N'ʬ','shi' 
insert into @geovindu select N'��','shike' 
insert into @geovindu select N'��','shiwa' 
insert into @geovindu select N'��','shou' 
insert into @geovindu select N'��','shu' 
insert into @geovindu select N'ˢ','shua' 
insert into @geovindu select N'ˤ','shuai' 
insert into @geovindu select N'��','shuan' 
insert into @geovindu select N'˫','shuang' 
insert into @geovindu select N'˭','shei' 
insert into @geovindu select N'ß','shui' 
insert into @geovindu select N'˱','shun' 
insert into @geovindu select N'�d','shuo' 
insert into @geovindu select N'˿','si' 
insert into @geovindu select N'�A','so' 
insert into @geovindu select N'�r','sol' 
insert into @geovindu select N'��','song' 
insert into @geovindu select N'��','sou' 
insert into @geovindu select N'��','su' 
insert into @geovindu select N'�i','suan' 
insert into @geovindu select N'��','sui' 
insert into @geovindu select N'�','suo' 
insert into @geovindu select N'��','ta' 
insert into @geovindu select N'�k','tae' 
insert into @geovindu select N'��','tai' 
insert into @geovindu select N'̮','tan' 
insert into @geovindu select N'�','tang' 
insert into @geovindu select N'��','tao' 
insert into @geovindu select N'�z','tap' 
insert into @geovindu select N'߯','te' 
insert into @geovindu select N'Ć','teng' 
insert into @geovindu select N'�z','teo' 
insert into @geovindu select N'�Y','teul' 
insert into @geovindu select N'��','ti' 
insert into @geovindu select N'��','tian' 
insert into @geovindu select N'��','tiao' 
insert into @geovindu select N'�G','tie' 
insert into @geovindu select N'��','ting' 
insert into @geovindu select N'�h','tol' 
insert into @geovindu select N'��','tong' 
insert into @geovindu select N'͵','tou' 
insert into @geovindu select N'͹','tu' 
insert into @geovindu select N'��','tuan' 
insert into @geovindu select N'��','tui' 
insert into @geovindu select N'�H','tun' 
insert into @geovindu select N'ر','tuo' 
insert into @geovindu select N'��','wa' 
insert into @geovindu select N'��','wai' 
insert into @geovindu select N'�^','wan' 
insert into @geovindu select N'��','wang' 
insert into @geovindu select N'Σ','wei' 
insert into @geovindu select N'�e','wen' 
insert into @geovindu select N'��','weng' 
insert into @geovindu select N'��','wo' 
insert into @geovindu select N'��','wu' 
insert into @geovindu select N'Ϧ','xi' 
insert into @geovindu select N'��','ei' 
insert into @geovindu select N'�P','xia' 
insert into @geovindu select N'��','xian' 
insert into @geovindu select N'��','xiang' 
insert into @geovindu select N'��','xiao' 
insert into @geovindu select N'Ш','xie' 
insert into @geovindu select N'��','xin' 
insert into @geovindu select N'��','xing' 
insert into @geovindu select N'��','xiong' 
insert into @geovindu select N'��','xiu' 
insert into @geovindu select N'�B','xu' 
insert into @geovindu select N'�R','xuan' 
insert into @geovindu select N'�T','xue' 
insert into @geovindu select N'�_','xun' 
insert into @geovindu select N'Ѿ','ya' 
insert into @geovindu select N'��','yan' 
insert into @geovindu select N'��','eom' 
insert into @geovindu select N'��','yang' 
insert into @geovindu select N'Ϳ','tu' 
insert into @geovindu select N'��','ju' 
insert into @geovindu select N'��','wen' 
insert into @geovindu select N'ߺ','yao' 
insert into @geovindu select N'Ҭ','ye' 
insert into @geovindu select N'Č','yen' 
insert into @geovindu select N'һ','yi' 
insert into @geovindu select N'�U','i' 
insert into @geovindu select N'�]','yin' 
insert into @geovindu select N'Ӧ','ying' 
insert into @geovindu select N'Ӵ','yo' 
insert into @geovindu select N'Ӷ','yong' 
insert into @geovindu select N'��','you' 
insert into @geovindu select N'��','yu' 
insert into @geovindu select N'��','yuan' 
insert into @geovindu select N'Ի','yue' 
insert into @geovindu select N'�C','yun' 
insert into @geovindu select N'��','za' 
insert into @geovindu select N'��','zai' 
insert into @geovindu select N'��','zan' 
insert into @geovindu select N'��','zang' 
insert into @geovindu select N'��','zao' 
insert into @geovindu select N'��','ze' 
insert into @geovindu select N'��','zei' 
insert into @geovindu select N'��','zen' 
insert into @geovindu select N'��','zeng' 
insert into @geovindu select N'߸','zha' 
insert into @geovindu select N'�h','gad' 
insert into @geovindu select N'��','zhai' 
insert into @geovindu select N'ձ','zhan' 
insert into @geovindu select N'��','zhang' 
insert into @geovindu select N'��','zhao' 
insert into @geovindu select N'��','zhe' 
insert into @geovindu select N'��','zhen' 
insert into @geovindu select N'�J','zheng' 
insert into @geovindu select N'֮','zhi' 
insert into @geovindu select N'��','zhong' 
insert into @geovindu select N'��','zhou' 
insert into @geovindu select N'��','zhu' 
insert into @geovindu select N'ץ','zhua' 
insert into @geovindu select N'ר','zhuan' 
insert into @geovindu select N'ת','zhuai' 
insert into @geovindu select N'ױ','zhuang' 
insert into @geovindu select N'��','zhui' 
insert into @geovindu select N'�d','zhun' 
insert into @geovindu select N'׿','zhuo' 
insert into @geovindu select N'��','zi' 
insert into @geovindu select N'��','zo' 
insert into @geovindu select N'��','zong' 
insert into @geovindu select N'��','zou' 
insert into @geovindu select N'�X','zu' 
insert into @geovindu select N'��','zuan' 
insert into @geovindu select N'��','zui' 
insert into @geovindu select N'��','zun' 
insert into @geovindu select N'��','zuo' 
insert into @geovindu select N'��','sun' 
insert into @geovindu select N'˹','si' 

declare @strlen int 
select @strlen=len(@str),@re='' 
while @strlen>0 
begin 
select top 1 @re=UPPER(substring(py,1,1) )+substring(py,2,len(py))+@re,@strlen=@strlen-1 
from @geovindu a where chr<=substring(@str,@strlen,1) 
order by chr collate Chinese_PRC_CS_AS_KS_WS desc 
if @@rowcount=0 
select @re=substring(@str,@strlen,1)+@re,@strlen=@strlen-1 
end 
return(@re) 
end 
GO 