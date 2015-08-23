using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ZX.ZXSystem
{
     public class GenCode
    {
         public GenCode()
         { 
         
         }
         public static string GetCode(string Code)

         {
            int sum = 0;
            int i3 = 0;

             
            foreach (char a in Code)
           {
               i3 = i3 + 1;
               sum = sum + ((int)a)*i3;
               
           }
          
           int k = sum / i3;
           return k.ToString();

         }

         private static string GetSubstring(string st1, char a,int count)
         {


             string[] t = st1.Split(a);
             return t[count];
         }

         public static bool CheckSN()
         {
            //返回数据库内存
             DataSet ds = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("exec master..xp_msver 'PhysicalMemory'");
             string pm = ds.Tables[0].Rows[0][3].ToString();
            //CPU核心 
             DataSet ds1 = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("exec master..xp_msver 'ProcessorCount'");
             string pc = ds1.Tables[0].Rows[0][3].ToString();

             string Com = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='Com'");
             string Reg = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='reg'");
             string Mac = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='Mac'");
             if (Mac != pc + pm)
             {
                 ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("update SYS_Conf set sconfvalue='" + pc + pm + "' where sconf='Mac'");
             }

             string t1 = GenCode.GetCode(Com + pc + pm);
             ////显示数据库中的序列号第一部分
             //MessageBox.Show(GetSubstring(Reg, '-', 0));
             //MessageBox.Show(t1);


             //核查公司名称是否正确！   
             if (t1 == GetSubstring(Reg, '-', 0))
             {
                // MessageBox.Show("头码正常");

             }
             else
             {
                 MessageBox.Show("①数据库连接失败!");
                 return false;
             }

             //核查天数校验码是否正确
             //数据库中的天数
             string sn2 = GetSubstring(Reg, '-', 1);
             //数据库中天数
             int dayFromDatabase = int.Parse(sn2) / int.Parse(GenCode.GetCode(pc+pm));
             //MessageBox.Show("计算天数用的"+(int.Parse(GenCode.GetCode(pc+pm)).ToString()));
             //MessageBox.Show("计算出来的天数:" + dayFromDatabase);
             string sn3 = GetSubstring(Reg, '-', 2);
             string compare_sn3 = GenCode.GetCode((dayFromDatabase * int.Parse(GenCode.GetCode(pc + pm))).ToString()) + GenCode.GetCode((dayFromDatabase * int.Parse(GenCode.GetCode(Com))).ToString());
             //MessageBox.Show(compare_sn3);
             ////注意查看是否带有空格
             //MessageBox.Show(sn3);
             //判断是否正确
            
           

             if (sn3 == compare_sn3)
             {
                // MessageBox.Show("天数计算正确");
             }
             else
             {
                 MessageBox.Show("②数据库连接失败!");
                 return false;
             }
             //返回今天是多少天
             DateTime d1 = DateTime.Parse(ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("Select CONVERT(varchar(100), GETDATE(), 111)").ToString());
             
             DateTime d2 = DateTime.Parse("1900-01-01");

             TimeSpan ts = d1.Subtract(d2);
            // MessageBox.Show("今天的天数"+ts.Days.ToString());
             if (dayFromDatabase >= ts.Days)
             {
                 //MessageBox.Show("天数在时间范围内");
             }
             else
             {
                 MessageBox.Show("③数据库连接失败!");
                 return false;
             }


             return true;
         }
    }

}
