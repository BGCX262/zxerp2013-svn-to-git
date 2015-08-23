using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZX.ZXSystem
{
    public partial class Test : Form,IZXMessage
    {
        public Test()
        {
            InitializeComponent();
        }

        public void ShowLabelMessage(string sMessage)
        {

            if ((this.MdiParent != null) && (this.MdiParent is IZXMessage))
            {
                (this.MdiParent as IZXMessage).ShowLabelMessage(sMessage);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            int I = 0;
            for (I = 0; I <= this.MenuStrip1.Items.Count - 1; I++)
            {
                ToolStripMenuItem Tool = (ToolStripMenuItem)this.MenuStrip1.Items[I];
                TreeNode NodeGroup = new TreeNode(this.MenuStrip1.Items[I].Text + "$$$$");
                //TreeNode NodeGroup = new TreeNode(this.MenuStrip1.Items[I].Text.Replace("&", "") + "$$$$");
                this.treeView1.Nodes.Add(NodeGroup);
                int J = 0;
                for (J = 0; J <= Tool.DropDownItems.Count - 1; J++)
                {
                    if (Tool.DropDownItems[J].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator")
                    {
                        NodeGroup.Nodes.Add("-$$$$");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Tool.DropDownItems[J].Text))
                        {
                            TreeNode TNode = new TreeNode(Tool.DropDownItems[J].Text + "$$$$");
                            NodeGroup.Nodes.Add(TNode);
                            int K = 0;
                            ToolStripMenuItem ToolM = (ToolStripMenuItem)Tool.DropDownItems[J];
                            if (ToolM.DropDownItems.Count > 0)
                            {
                                for (K = 0; K <= ToolM.DropDownItems.Count - 1; K++)
                                {
                                    if (ToolM.DropDownItems[K].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator")
                                    {
                                        TNode.Nodes.Add("-$$$$");
                                    }
                                    else
                                    {
                                        if (!string.IsNullOrEmpty(ToolM.DropDownItems[K].Text))
                                        {
                                            TreeNode TNodeM = new TreeNode(ToolM.DropDownItems[K].Text + "$$$$");
                                            TNodeM.ImageIndex = 0;
                                            TNodeM.SelectedImageIndex = 1;
                                            TNode.Nodes.Add(TNodeM);
                                            TNode.ImageIndex = 0;
                                            TNode.SelectedImageIndex = 0;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                TNode.ImageIndex = 0;
                                TNode.SelectedImageIndex = 1;
                            }
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            TV.SetTreeViewTag(this.treeView1);

            DataTable DT = TV.SaveToDataTable(this.treeView1, "FBH", "GNBH", "GNMC");
            DT.TableName = "SYS_FUNCTION";
            if (DT.Rows.Count > 0)
            {
                DataColumn DC1 = new DataColumn("WJMC");
                DC1.MaxLength = 100;
                DataColumn DC2 = new DataColumn("MMKJ");
                DC1.MaxLength = 200;
                DataColumn DC3 = new DataColumn("WJICO");
                DC1.MaxLength = 500;
                DataColumn DC4 = new DataColumn("HELPPATH");
                DC1.MaxLength = 200;
                DT.Columns.AddRange(new DataColumn[] { DC1, DC2, DC3, DC4 });
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    //文本字串格式
                    //功能菜单名称$功能程序集文件名$功能命名空间加类名$功能图标$功能帮助
                    string[] SplitStr = DT.Rows[i]["GNMC"].ToString().Split('$');
                    DT.Rows[i]["GNMC"] = SplitStr[0];
                    DT.Rows[i]["WJMC"] = SplitStr[1];
                    DT.Rows[i]["MMKJ"] = SplitStr[2];
                    DT.Rows[i]["WJICO"] = SplitStr[3];
                    DT.Rows[i]["HELPPATH"] = SplitStr[4];
                }
                DT.AcceptChanges();

                if (SystemClass.AdoNetOperation.DataTableInputDataBase(SystemClass.ConnectString.GetConnectionString(), DT, "SYS_FUNCTION", false) == true)
                {
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Function.FunManage", "SaveFunctionNode", "保存功能列表到数据库成功", ZX.Class.Log.NormalLogType.InfoLog);
                }
                else
                {
                    SystemClass.MessageBoxShow.ShowMessage("保存功能列表到数据库失败！");
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Function.FunManage", "SaveFunctionNode", "保存功能列表到数据库失败", ZX.Class.Log.NormalLogType.WarnLog);
                }
            }
        }


        private void Test_Load(object sender, EventArgs e)
        {
            ZX.ZXSystem.DBUtility.DbHelperSQL.connectionString = SystemClass.ConnectString.GetConnectionString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MenuStrip1.Items.Clear();
        }

        private void ForEachNextMenu(ToolStripMenuItem Tool,string FBH,DataTable DT)
        {
            foreach (DataRow DR in DT.Select("FBH='" + FBH + "'", "GNBH"))
            {
                if (DR["GNMC"].ToString() == "-")
                {
                    ToolStripSeparator ToolNext = new ToolStripSeparator();
                    Tool.DropDownItems.Add(ToolNext);
                }
                else
                {
                    ToolStripMenuItem ToolNext = new ToolStripMenuItem(DR["GNMC"].ToString());
                    Tool.Tag = DR["GNBH"].ToString();
                    Tool.DropDownItems.Add(ToolNext);
                    ForEachNextMenu(ToolNext, DR["GNBH"].ToString(), DT);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT [GNBH]"
                            + ",[GNMC]"
                            + ",[FBH]"
                            + ",[WJMC]"
                            + ",[MMKJ]"
                            + ",[WJICO]"
                            + "FROM [SYS_FUNCTION] order by GNBH";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            DataRow[] DR = DT.Select("FBH=''", "GNBH");
            for (int i = 0; i < DR.Length; i++)
            {
                ToolStripMenuItem Tool = new ToolStripMenuItem(DR[i]["GNMC"].ToString());
                Tool.Tag = DR[i]["GNBH"].ToString();
                MenuStrip1.Items.Add(Tool);
                ForEachNextMenu(Tool, DR[i]["GNBH"].ToString(),DT);
            }
        }

        private void ToolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            ShowLabelMessage("好东东啊");

        }

    }
}
