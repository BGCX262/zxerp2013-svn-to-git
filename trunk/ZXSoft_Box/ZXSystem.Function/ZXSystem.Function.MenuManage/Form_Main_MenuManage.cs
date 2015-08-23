using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.MenuManage
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_MenuManage : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_MenuManage()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; 
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            
            gc_CommonQry.Tag = "SYS_Menu";
            LoadData();
        }

        private void LoadData()
        {
            string strSql = "select * from SYS_Menu order by smenuGroupID,sSortBy";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            
            this.gc_CommonQry.DataSource = DT;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", this.gc_CommonQry);
        }
        private void btnDll_Click(object sender, EventArgs e)
        {
             ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
             FP.SqlQrystr = "select sFunctionID,sFunctionName from SYS_Functions order by sFunctionID";
             Form f=SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", FP, null);
             Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;
             if (Dic.ContainsKey("sFunctionID"))
            {
                //MessageBox.Show(Dic["功能ID"]);
                this.txtFunID.Text = Dic["sFunctionID"];
            }

             if (Dic.ContainsKey("sFunctionName"))
            {
                //MessageBox.Show(Dic["功能名称"]);
                this.txtFunName.Text = Dic["sFunctionName"];
            }

           
        }
        private void btnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "图标文件(*.ico)|*.ico";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.txtsSortBy.Text = OFD.FileName;
            }
        }
        
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "保存":
                    SaveData();
                    break;
                case "修改":
                    Edit();
                    break;
                case "删除":
                    Delete();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void Edit()
        {
            string deletesqlstr = "delete from SYS_Menu where sFunctionID='" + this.txtFunID.Text + "'";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(deletesqlstr);
            if (!VerifyText())
            {
                MessageBox.Show("功能ID不可为空！");
                return;
            }
            string sqlstr = "insert into SYS_Menu (sFunctionID,sFunctionName,sMenuGroupID,sSortBy)"
                + " values('" + this.txtFunID.Text + "','" + this.txtFunName.Text + "','" + this.txtMenuGroupID.Text + "','" + this.txtsSortBy.Text + "')";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(sqlstr);
            LoadData();
            LoadData();
        }

      

        private void Delete()
        {
            if (this.txtMenuGroupID.Text == "")
            {
                return;
            }

            string deletesqlstr = "delete from SYS_Menu where sFunctionID='" + this.txtFunID.Text + "'";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(deletesqlstr);
            LoadData();
            this.txtFunID.Text = "";
            this.txtFunName.Text = "";
            this.txtMenuGroupID.Text = "";
            this.txtsSortBy.Text = "";
        }

        private void SaveData()
        {
            if (!VerifyText())
            {
                MessageBox.Show("功能ID不可为空！");
                return;
            }
            string sqlstr = "insert into SYS_Menu (sFunctionID,sFunctionName,sMenuGroupID,sSortBy)"
                + " values('" + this.txtFunID.Text + "','" + this.txtFunName.Text + "','" + this.txtMenuGroupID.Text + "','" + this.txtsSortBy.Text + "')";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(sqlstr);
            LoadData();
        }

       

        
        

        //private void SaveFunctionNode()
        //{
           
        //    try
        //    {
        //        ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
        //        TV.SetTreeViewTag(this.TreeView1);
        //        DataTable DT = TV.SaveToDataTable(this.TreeView1, "smenuGroupID", "sFunctionID", "sFunctionName");
        //        DT.TableName = "SYS_Menu";
        //        if (DT.Rows.Count > 0)
        //        {
        //            DT.AcceptChanges();

        //            if (SystemClass.AdoNetOperation.DataTableInputDataBase(SystemClass.ConnectString.GetConnectionString(), DT, "SYS_MainFunctions", false) == true)
        //            {
        //                ZX.Class.Log.WriteLog.Write("ZXSystem.Function.MenuManage", "SaveFunctionNode", "保存功能列表到数据库成功", ZX.Class.Log.NormalLogType.InfoLog);
        //               SystemClass.MessageBoxShow.ShowMessage("保存功能列表到数据库成功，请重新启动应用系统！");
        //            }
        //            else
        //            {
        //               SystemClass.MessageBoxShow.ShowMessage("保存功能列表到数据库失败！");
        //                ZX.Class.Log.WriteLog.Write("ZXSystem.Function.MenuManage", "SaveFunctionNode", "保存功能列表到数据库失败", ZX.Class.Log.NormalLogType.WarnLog);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ZX.Class.Log.WriteLog.Write("ZXSystem.Function.MenuManage", "SaveFunctionNode", "保存功能列表到数据库出错", ex, ZX.Class.Log.ErrorLogType.FatalLog);
        //    }
        //}
       
        /// <summary>
        /// 验证输入的完整性
        /// </summary>
        /// <returns></returns>
        private bool VerifyText()
        {
            if (this.txtFunID.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
       
 
        



       

        private void Form_Main_MenuManage_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void gv_CommonQry_DoubleClick(object sender, EventArgs e)
        {
            if (gv_CommonQry.RowCount == 0)
            { return; }
            this.txtFunID.Text = gv_CommonQry.GetFocusedRowCellValue("sFunctionID").ToString();
            this.txtFunName.Text = gv_CommonQry.GetFocusedRowCellValue("sFunctionName").ToString();
            this.txtMenuGroupID.Text = gv_CommonQry.GetFocusedRowCellValue("sMenuGroupID").ToString();
            this.txtsSortBy.Text = gv_CommonQry.GetFocusedRowCellValue("sSortBy").ToString();
        }
    }
}

