using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.Pdf;
using FastReport.Data;
using FastReport.Format;
using FastReport.Utils;
using System.Collections;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.FrxReport
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_FrxReport : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
       // DataTable DT;
        public Form_Main_FrxReport()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;


            ShowReport(FP.pub_ReportName, FP.pub_StoredProcName, FP.pub_Sqlparam);

            

        }
        public void ShowReport(string ReportName, string storedProcName, IDataParameter[] parameters)
        {
            //todo 形成字符串，显示查询条件
            // FrxReport fm = new FrxReport();



            DataSet ds = ZX.ZXSystem.DBUtility.DbHelperSQL.RunProcedure(storedProcName, parameters, "TB");
                //ZX.ZXSystem.DBUtility.DbHelperSQL.RunProcedure(storedProcName, parameters, "TB");
            //sp.("select * from Bas_Customer", ref ds);
            DataSet tempds = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("SELECT * FROM SYS_Conf WHERE sConf = 'Com'");
            DataTable tempdt = tempds.Tables[0].Copy();
            tempdt.TableName = "Com";
            ds.Tables.Add(tempdt);


            //todo 取数据库中报表位置
            string sRptCaption="";
            string rptID = "";
            string rptPath;
            int rptcount = (int)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select count(*) from TB_MainRptSet where srptName='" + ReportName + "'");
            if (rptcount <= 1)
            {
                DataTable singleDT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("select sRptCaption,sRptID from TB_MainRptSet where srptName='" + ReportName + "'").Tables[0];
                if (singleDT.Rows.Count>0)
                {
                    DataRow dr=singleDT.Rows[0];
                    sRptCaption=dr["sRptCaption"].ToString();
                    rptID = dr["sRptID"].ToString();

                }

            }
            else
            {
                ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
                FP.SqlQrystr = "select sRptCaption,sRptID,sRptFilePath from TB_MainRptSet where srptName='" + ReportName + "' order by sRptID";
                Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", FP, null);
                Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;

                if (Dic.ContainsKey("sRptCaption"))
                {

                    sRptCaption = Dic["sRptCaption"];
                    rptID = Dic["sRptID"];
                }





                if (sRptCaption == "")
                {
                    this.Close();
                    return;

                }
                
            }
            
            rptPath = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sRptFilePath from TB_MainRptSet where sRptCaption='" + sRptCaption + "' and sRptID='" + rptID + "'");
            // MessageBox.Show(Application.StartupPath + rptPath);
            try
            {
                report.Load(Application.StartupPath + "\\" + rptPath);
            }
            catch (Exception)
            {

                MessageBox.Show("未找报表报表文件" + Application.StartupPath + "\\" + rptPath);
                this.Close();
                return;
            }




            FastReport.TextObject t = report.FindObject("FrxTitle") as TextObject;
            if (t != null)
            {
                t.Text = sRptCaption;
            }



            report.RegisterData(ds.Tables[0], "TB");
            report.RegisterData(ds.Tables[1], "Com");

            //查看是否设计报表
            if ((string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select isnull(sConfValue,'') from SYS_Conf where sConf='PrintDesign'") == "1")
            {
                report.Design();

            }
            else
            {
                try
                {
                    report.Show(); ;
                }
                catch (Exception)
                {

                    MessageBox.Show("报表文件存在数据问题，请与研发人员联系!");

                }

            }
            this.Close();
        }
        

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }






    }
}

