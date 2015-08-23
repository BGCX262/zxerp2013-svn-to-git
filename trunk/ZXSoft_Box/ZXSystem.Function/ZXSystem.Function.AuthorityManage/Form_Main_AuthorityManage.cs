using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.AuthorityManage
{
public partial class Form_Main_AuthorityManage : Form
    {
        public Form_Main_AuthorityManage()
        {
            InitializeComponent();
        }

        private void Form_Main_AuthorityManage_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);

            LoadUserList();
            AddFunctionTreeViewNodes();
        }
        /// <summary>
        /// 根据菜单添加结构到功能普通树
        /// </summary>
        private void AddFunctionTreeViewNodes()
        {
            //string strSql = "SELECT FBH,GNBH,replace(GNMC,'&','') as GNMC FROM SYS_FUNCTION where GNMC<>'-' order by GNBH";

            //string strSql = "SELECT sParentFunctionID,sFunctionID,replace(sFunctionName,'&','') as sFunctionName FROM SYS_MainFunctions where sFunctionName<>'-' order by sFunctionID";
            string strSql = "SELECT sMenuGroupID,sFunctionID,sFunctionName FROM SYS_Menu  order by sSortBy";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            TV.ReadNodesFromDataTable(this.treeViewFunction, DT, false, 0, 1, 2);
            DT.Clear();
            GC.Collect();
        }
        /// <summary>
        /// 读取要设置权限的用户列表
        /// </summary>
        private void LoadUserList()
        {
            SetListView();
            string strSql;
            //strSql = "select YHBH,YHMC,YHLX= case YHLX WHEN 0 THEN '系统管理员' else '普通人员' end "
            //+ "from SYS_USER_INF where YHMC<>'admin' order by YHBH";

            strSql = "select * from SYS_USER_INFO";
            System.Data.SqlClient.SqlDataReader SDR = ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteReader(strSql);
            while (SDR.Read())
            {
                ListViewItem LV = new ListViewItem(new string[] { "分配", SDR["sUserID"].ToString(), SDR["sUserName"].ToString(), SDR["sDepartMent"].ToString() });
                this.listView1.Items.Add(LV);
            }
            SDR.Close();
            SDR.Dispose();
        }

        /// <summary>
        /// 设置控件属性
        /// </summary>
        private void SetListView()
        {
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Items.Clear();
            this.listView1.Columns.Clear();

            this.listView1.View = View.Details;
            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "选择";
            columnHeader0.Width = 80;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "用户编号";
            columnHeader1.Width = 100;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "用户名称";
            columnHeader2.Width = 150;
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "用户类型";
            columnHeader3.Width = 150;
            this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3 });
            this.listView1.CheckBoxes = true;
        }
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "清空":
                    DeleteAssignResult();
                    break;
                case "保存":
                    SaveData();
                    break;
                case "一键分配":
                    SaveAllAssign();
                    break;
                case "全选":
                    SelectAll();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }
        /// <summary>
        /// 删除权限分配结果
        /// </summary>
        private void DeleteAssignResult()
        {
            if (SystemClass.MessageBoxShow.ShowMessage("是否真的要清空原有权限分配信息，重新进行权限分配？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string strSql = "delete from SYS_USER_AUTHORITY";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql);
            LoadUserList();
        }
        /// <summary>
        /// 保存此功能分配结果
        /// </summary>
        private void SaveData()
        {
            this.Cursor = Cursors.WaitCursor;
            string strUserBH = "";
            string strFunctionBH = "";
            string strFunctioinName = "";
            string strSql = "";
            int EffectRows = 0;

           

            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                strUserBH = this.listView1.Items[i].SubItems[2].Text;
                strFunctionBH = this.treeViewFunction.SelectedNode.Tag.ToString();
                strFunctioinName = this.treeViewFunction.SelectedNode.Name.ToString();

                //删除权限分配结果
                string deletestrSql = "delete from SYS_USER_AUTHORITY where sFunctionID='" + strFunctionBH + "';";
                ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(deletestrSql);

                if (this.listView1.Items[i].Checked)
                {
                    strSql = strSql + System.Environment.NewLine + "insert SYS_USER_AUTHORITY(sUserName,sFunctionID,sFunctionName,iValidFlag,iDefaultMenuFlag) values('" + strUserBH + "','" + strFunctionBH + "','" + strFunctioinName + "',1,1);";
                    EffectRows++;
                }
                else
                {
                    strSql = strSql + System.Environment.NewLine + "delete SYS_USER_AUTHORITY where sUserName='" + strUserBH + "' and sFunctionID='" + strFunctionBH + "';";
                }
            }
            if (strSql.Length > 5)
            {
                if (ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql) < EffectRows)
                {
                   SystemClass.MessageBoxShow.ShowMessage("设置用户权限失败！");
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Function.AuthorityManage.Form_Main_AuthorityManage", "listView1_ItemCheck", "分配功能［" + this.treeViewFunction.SelectedNode.Text + "］权限失败！", ZX.Class.Log.NormalLogType.InfoLog);
                }
                else
                {
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Function.AuthorityManage.Form_Main_AuthorityManage", "listView1_ItemCheck", "分配功能［" + this.treeViewFunction.SelectedNode.Text + "］权限成功！", ZX.Class.Log.NormalLogType.InfoLog);
                }
            }
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// 一键分配，所有功能到所有用户
        /// </summary>
        private void SaveAllAssign()
        {
            if (SystemClass.MessageBoxShow.ShowMessage("是否真的要统一设定所有用户为最大权限？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string strSql = "delete from SYS_USER_AUTHORITY";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql);
            //strSql = "insert into SYS_USER_AUTHORITY(sFunctionID,sFunctionName,sUserID,ivalidFlag,idefaultMenuFlag) "
            //    + " select A.sFunctionID,A.sFunctionName,B.sUserName,1,1 from "
            //    + " (select sFunctionId,'' as sUserID,sFunctionName from SYS_MainFunctions where sDllpath<>'' and sDllpath is not null) as A,"
            //    + " (select sUserName from SYS_USER_INFO) as B"
            //    + " where A.sUserID<>B.sUserName";

            strSql = "insert into SYS_USER_AUTHORITY(sFunctionID,sFunctionName,sUserName,ivalidFlag,idefaultMenuFlag) "
               + " select A.sFunctionID,A.sFunctionName,B.sUserName,1,1 from "
               + " (select sFunctionId,'' as sUserName,sFunctionName from SYS_Menu) as A,"
               + " (select sUserName from SYS_USER_INFO) as B"
               + " where A.sUserName<>B.sUserName";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// 选择全部用户
        /// </summary>
        private void SelectAll()
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                this.listView1.Items[i].Checked = true;
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void 取消全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                this.listView1.Items[i].Checked = false;
            }
        }

        private void 反向选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                this.listView1.Items[i].Checked = !this.listView1.Items[i].Checked;
            }
        }

        /// <summary>
        /// 读取当前选定功能的权限分配结果
        /// </summary>
        private void LoadData()
        {
            object sender = null;
            EventArgs e = null;
            取消全选ToolStripMenuItem_Click(sender, e);

            //string strSql = "select sFunctionId from SYS_USER_AUTHORITY where GNBH='" + this.treeViewFunction.SelectedNode.Tag.ToString() + "'";
            string strSql = "select sFunctionId,sUserName from SYS_USER_AUTHORITY where sFunctionID='" + this.treeViewFunction.SelectedNode.Tag.ToString() + "'";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    for (int j = 0; j < this.listView1.Items.Count; j++)
                    {
                        if (DT.Rows[i]["sUserName"].ToString() == this.listView1.Items[j].SubItems[2].Text)
                        {
                            this.listView1.Items[j].Checked = true;
                        }
                    }
                }
            }
        }

        private void treeViewFunction_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeViewFunction.SelectedNode.GetNodeCount(false)>0)
            {
                取消全选ToolStripMenuItem_Click(sender, e);
                this.toolStripButton5.Enabled = false;
                this.listView1.Enabled = false;
            }
            else
            {
                this.toolStripButton5.Enabled = true;
                this.listView1.Enabled = true;
                LoadData();
            }
        }

        private void Form_Main_AuthorityManage_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }
    }
}
