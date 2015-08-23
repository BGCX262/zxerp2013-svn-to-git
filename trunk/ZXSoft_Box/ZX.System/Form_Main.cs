using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Configuration;
using System.IO;
using ZX.Controls.DotNetMagic.Controls;
using ZX.ZXSystem.Win;

namespace ZX.ZXSystem
{
    /// <summary>
    /// 主界面接口
    /// </summary>
   



    public partial class Form_Main : Form, IZXMessage
    {
        ZX.Win.FunctionParameter FormMainFP;
      //  private IPaintItem m_currentitem = null;
        /// <summary>
        /// 当窗体实例化时
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
        }

        //#region "隐藏性的添加功能（当系统第一次运行时）"
        //private void treeViewLeftFun_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F11 && e.Control == true && e.Alt == true)
        //    {
        //        ZX.Win.FunctionParameter FP = new ZX.Win.FunctionParameter();
        //        FP.ToolStripitemDisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        //        FP.functionFormID = "-1";
        //        ZX.Win.ReflectionFunction RF = new ZX.Win.ReflectionFunction();
        //        Form frm = RF.LoadMdiForm("ZXSystem.Function.FunManage.dll", "ZXSystem.Function.FunManage.Form_Main_FunManage", this, FP);
        //        System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(frm.Text);
        //        TP.Tag = frm;
        //        this.TabControFormList.TabPages.Add(TP);
        //        this.TabControFormList.SelectedTab = TP;
        //        TP.Select();
        //    }
           
        //}
        //#endregion

        private void Form_Main_Load(object sender, EventArgs e)
        {
            zxPanel1.ShowGrid = false;
            //没有搞明白为什么删除控件主界面会无法显示窗体内容
            slidingTitleBarLeft.Visible = false;

            //没有搞明白为什么删除控件主界面会无法显示窗体内容
            this.slidingTitleBarRight.Visible = false;
            this.slidingTitleBarRight.SendToBack();

            FormMainFP = (ZX.Win.FunctionParameter)this.Tag;
            if (FormMainFP == null)
            {
                return;
            }
            
            this.TabControFormList.SelectedTab = null;
            //菜单
            AddMenu();
            //toolstripMain
            AddToolStripMain();
            //去掉超级用户特权
           if (FormMainFP.Pub_sUserNameByChinese != "admin")
            {
                SystemClass.ApplicationFormMain.CheckFunctionAssign(this.menuStrip1, FormMainFP.Pub_sUserName);
            }

            AddTreeViewFunctionNodes();
            AddTreeViewHelpNodes();
            LoadWorkFile();
            SystemClass.ApplicationFormMain.SetFunctionEnabled(true, this);
            SetControl();
            SetStatus();
            
            LoadZXPanel();
        }

            private void LoadZXPanel()
            {

                //this.zxPanel1.PaintItems.Clear();
                //this.zxPanel1.Refresh();

                //this.zxPanel1.PaintItems = UnSerializeObjectFromFile(Application.StartupPath + @"\11.mpf");
                //this.zxPanel1.Refresh();
                
            }



            public void ShowLabelMessage(string sMessage)
            {

                
                strMessageLable.BackColor = Color.Red;
                strMessageLable.ForeColor = Color.White;
                strMessageLable.Text = sMessage;
                timer_MessageLabel.Enabled = true;
            }

        private void SetStatus()
        {

            ToolStripStatusLabel toolLabelInf = new ToolStripStatusLabel("开发单位：置祥科技有限公司");
            toolLabelInf.AutoSize = false;
            toolLabelInf.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabelInf.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabelInf.Size = new System.Drawing.Size(222, 21);

            ToolStripStatusLabel toolLabelHttp = new ToolStripStatusLabel("联系客服人员");
            toolLabelHttp.AutoSize = false;
            toolLabelHttp.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabelHttp.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabelHttp.IsLink = true;
            toolLabelHttp.ToolTipText = "作者网站";
            toolLabelHttp.Size = new System.Drawing.Size(180, 21);

            ToolStripStatusLabel toolLabel1 = new ToolStripStatusLabel("操作人员:" + FormMainFP.Pub_sUserNameByChinese);
            toolLabel1.AutoSize = false;
            toolLabel1.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabel1.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabel1.Size = new System.Drawing.Size(120, 21);


            ToolStripStatusLabel toolLabelRole = new ToolStripStatusLabel("角色:" + FormMainFP.Pub_sRole);
            toolLabelRole.AutoSize = false;
            toolLabelRole.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabelRole.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabelRole.Size = new System.Drawing.Size(120, 21);

            ToolStripStatusLabel toolLabel2 = new ToolStripStatusLabel("数据库:" + FormMainFP.pub_DbName);
            toolLabel2.AutoSize = false;
            toolLabel2.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabel2.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabel2.Size = new System.Drawing.Size(150, 21);

            ToolStripStatusLabel toolLabelTime = new ToolStripStatusLabel();
            toolLabelTime.AutoSize = false;
            toolLabelTime.BorderSides = ToolStripStatusLabelBorderSides.All;
            toolLabelTime.BorderStyle = Border3DStyle.SunkenOuter;
            toolLabelTime.Size = new System.Drawing.Size(200, 21);
            toolLabelTime.Spring = true;
            toolLabelTime.Text = "登录时间：" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            toolLabelTime.Spring = true;
            toolLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;




   



            this.statusStrip1.Items.Add(toolLabelInf);
            this.statusStrip1.Items.Add(toolLabelHttp);
            toolLabelHttp.Click += new EventHandler(toolStripHttp_Click);
            this.statusStrip1.Items.Add(toolLabel1);
            this.statusStrip1.Items.Add(toolLabelRole);
            this.statusStrip1.Items.Add(toolLabel2);
            this.statusStrip1.Items.Add(toolLabelTime);


        }

       



        /// <summary>
        /// 窗体启动时设置控件属性等
        /// </summary>
        private void SetControl()
        {
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco\", this.ToolStripMain, ToolStripItemDisplayStyle.ImageAndText);
            this.WindowState = FormWindowState.Maximized;

            this.slidingTitleBarLeft.Width = 280;
            this.slidingTitleBarLeft.Length = 20;
            this.slidingTitleBarLeft.Dock = DockStyle.Left;
            this.slidingTitleBarLeft.Edge = ZX.Controls.DotNetMagic.Controls.TitleEdge.Left;
            this.slidingTitleBarLeft.Text = "软件功能导航";
            this.slidingTitleBarLeft.Open = false;

            //this.slidingTitleBarRight.Width = 280;
            //this.slidingTitleBarRight.Length = 20;
            //this.slidingTitleBarRight.Dock = DockStyle.Right;
            //this.slidingTitleBarRight.Edge = ZX.Controls.DotNetMagic.Controls.TitleEdge.Right;
            //this.slidingTitleBarRight.Text = "常用功能导航";
            //this.slidingTitleBarRight.Open = false;

            this.slidingTitleBarLeft.Panel.Controls.Clear();
            this.slidingTitleBarLeft.Panel.Controls.Add(this.treeViewLeftFun);
            //this.slidingTitleBarRight.Panel.Controls.Clear();
            //this.slidingTitleBarRight.Panel.Controls.Add(this.TabControlRight);

            this.treeViewLeftFun.Nodes.Clear();
            this.treeViewLeftFun.ImageList = this.imageList1;
            this.treeViewLeftFun.ImageIndex = 0;
            this.treeViewLeftFun.SelectedImageIndex = 1;
            this.treeViewLeftFun.Dock = DockStyle.Fill;
            this.TabControlRight.Dock = DockStyle.Fill;

            this.treeViewHelp.Nodes.Clear();
            this.treeViewHelp.ImageList = this.imageList1;
            this.treeViewHelp.ImageIndex = 5;
            this.treeViewHelp.SelectedImageIndex = 6;
            this.treeViewHelp.LineColor = Color.Green;

            Application.DoEvents();

        }

        /// <summary>
        /// 递归添加菜单项目
        /// </summary>
        /// <param name="Tool">传入的菜单项目</param>
        /// <param name="sParentFunctionID">当前传入菜单的编号</param>
        /// <param name="DT">菜单DataTable</param>
        private void ForEachNextMenu(ToolStripMenuItem Tool, string sParentFunctionID, DataTable DT)
        {
            //foreach (DataRow DR in DT.Select("sParentFunctionID='" + sParentFunctionID + "'", "sFunctionID"))
            //{
            //    if (DR["sFunctionName"].ToString() == "-")
            //    {
            //        ToolStripSeparator ToolNext = new ToolStripSeparator();
            //        Tool.DropDownItems.Add(ToolNext);
            //    }
            //    else
            //    {
            //        ToolStripMenuItem ToolNext;
            //        if (DR["sFunctionICO"] != null && DR["sFunctionICO"].ToString() != "")
            //        {
            //            ToolNext = new ToolStripMenuItem(DR["sFunctionName"].ToString(), Image.FromFile(Application.StartupPath + "\\Images\\MenuIcons\\" + DR["sFunctionICO"].ToString()));
            //        }
            //        else
            //        {
            //            ToolNext = new ToolStripMenuItem(DR["sFunctionName"].ToString());
            //        }
            //        ToolNext.Name = DR["sFunctionName"].ToString();

            //        ToolNext.Click += new EventHandler(ToolNext_Click);


            //        ToolNext.Tag = DR["sFunctionID"].ToString();
            //        Tool.DropDownItems.Add(ToolNext);
            //        ForEachNextMenu(ToolNext, DR["sFunctionID"].ToString(), DT);
            //    }
            //}
            foreach (DataRow DR in DT.Select("sMenuGroupID='" + sParentFunctionID + "'", "sFunctionID"))
            {
                ToolStripMenuItem ToolNext;
                if (DR["sFunctionICO"] != null && DR["sFunctionICO"].ToString() != "")
                {
                    ToolNext = new ToolStripMenuItem(DR["sMenuName"].ToString(), Image.FromFile(Application.StartupPath + "\\Images\\MenuIcons\\" + DR["sFunctionICO"].ToString()));
                }
                else
                {
                    ToolNext = new ToolStripMenuItem(DR["sFunctionName"].ToString());
                }
                ToolNext.Name = DR["sFunctionName"].ToString();

                ToolNext.Click += new EventHandler(ToolNext_Click);


                ToolNext.Tag = DR["sFunctionID"].ToString();
                Tool.DropDownItems.Add(ToolNext);
            }
        }
        
        /// <summary>
        /// 为菜单项指定单击事件，以便调用功能
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>事件内容 instance containing the event data.</param>
        private void ToolNext_Click(object sender, EventArgs e)
        {
            Form Frm = null;
            if (sender.GetType().ToString().IndexOf("Node") > 0)
            {
                string FunctionText = "";
                FunctionText = ((ZX.Controls.DotNetMagic.Controls.Node)(sender)).Text;
                FormMainFP.pub_Object = FunctionText;//为特殊功能做准备
                if (PeculiarFunction(FunctionText) == false)//判断是不是特殊功能
                {
                    ZXPanelVisibleFalse();
                    Frm = SystemClass.ApplicationFormMain.LoadFunction(((ZX.Controls.DotNetMagic.Controls.Node)sender).Tag.ToString(), FormMainFP, this);
                }
            }
            else if (sender.GetType().ToString().IndexOf("ToolStripMenuItem") > 0)
            {
                string FunctionText = "";
                FunctionText = sender.ToString();
                FormMainFP.pub_Object = FunctionText;//为特殊功能做准备
                if (PeculiarFunction(FunctionText) == false)//判断是不是特殊功能
                {
                    
                    ZXPanelVisibleFalse();
                    Frm = SystemClass.ApplicationFormMain.LoadFunction(((ToolStripItem)sender).Tag.ToString(), FormMainFP, this);
                }
            }
            if (Frm != null)
            {
                ZXPanelVisibleFalse();
                System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(Frm.Text);
                TP.Tag = Frm;
                TP.ToolTipText = Frm.Text;
                this.TabControFormList.TabPages.Add(TP);
                this.TabControFormList.SelectedTab = TP;
                TP.Select();

                AddAgoFormList();

            }
        }
        
        /// <summary>
        /// 设置流程图不可见
        /// </summary>
        private void ZXPanelVisibleFalse()
        {
            if (zxPanel1.Visible == true)
            {
                zxPanel1.Visible = false;
            }

            //zxPanel1.SendToBack();
        }
        /// <summary>
        /// 判断是不是特殊功能
        /// </summary>
        /// <param name="FunctionText">功能名称文本.</param>
        /// <returns></returns>
        private bool PeculiarFunction(string FunctionText)
        {
            switch (FunctionText.Trim())
            {
                case "切换用户":
                    Form_Login Frm = new Form_Login();
                    Frm.ShowDialog();
                    //添加后续代码
                    FormMainFP.pub_sUserName = ((ZX.Win.FunctionParameter)(Frm.Tag)).Pub_sUserName;
                    FormMainFP.pub_sUserNameByChinese = ((ZX.Win.FunctionParameter)(Frm.Tag)).Pub_sUserNameByChinese;
                    SystemClass.ApplicationFormMain.SetFunctionEnabled(false, this);
                    if (FormMainFP.Pub_sUserNameByChinese != "admin")
                    {
                        SystemClass.ApplicationFormMain.CheckFunctionAssign(this.menuStrip1, FormMainFP.Pub_sUserName);
                    }

                    return true;
                case "退出系统":
                    Application.Exit();
                    return true;
                case "项目获取数据":
                    GetData();
                    return true;
                case "审计人员待办事宜":
                    WorkFile();
                    return true;


                case "关闭所有窗体":
                    CloseAllMdiForm();
                    return true;
                case "关闭当前窗体":
                    if (this.ActiveMdiChild != null)
                    {
                        this.ActiveMdiChild.Close();
                    }
                    return true;
                case "层叠所有窗口":
                    this.LayoutMdi(MdiLayout.Cascade);
                    return true;
                case "横向平铺所有窗口":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    return true;
                case "纵向平铺所有窗口":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    return true;
                case "最小化所有窗口":
                    MinAllMdiForm();
                    return true;
                case "注册产品":
                    return true;
                case "公司主页":

                    return true;
                case "联机帮助":

                    return true;
                case "联系我们":
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// 关闭所有窗体
        /// </summary>
        private void CloseAllMdiForm()
        {
            int maxForm = this.MdiChildren.Length;
            if (maxForm > 0)
            {
                for (int i = maxForm - 1; i >= 0; i--)
                {
                    this.MdiChildren[i].Close();
                }
            }
        }
        /// <summary>
        /// 最小化所有窗口
        /// </summary>
        private void MinAllMdiForm()
        {
            int maxForm = this.MdiChildren.Length;
            if (maxForm > 0)
            {
                for (int i = maxForm - 1; i >= 0; i--)
                {
                    if (this.MdiChildren[i].MinimizeBox)
                    {
                        this.MdiChildren[i].WindowState = FormWindowState.Minimized;
                    }
                }
            }
        }
        /// <summary>
        /// 项目获取数据
        /// </summary>
        private void GetData()
        {
            string strGetDataDir = Application.StartupPath + @"\GetData";
            if (System.IO.Directory.Exists(strGetDataDir))
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                FBD.Description = "请选择您要导出取数工具的文件夹:";
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    ZX.Class.IO.DirOperate DO = new ZX.Class.IO.DirOperate();
                    DO.CopyDir(strGetDataDir, FBD.SelectedPath);
                }

            }
        }

        /// <summary>
        /// 根据菜单添加结构到主窗体
        /// </summary>
        private void AddMenu()
        {
            
            //string strSql = "SELECT sFunctionID,sFunctionName,sParentFunctionID,sFunctionICO,sDllPath FROM SYS_MainFunctions order by sFunctionID";
            //DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            //DataRow[] DR = DT.Select("sParentFunctionID=''", "sFunctionID");
            //for (int i = 0; i < DR.Length; i++)
            //{
            //    ToolStripMenuItem Tool = new ToolStripMenuItem(DR[i]["sFunctionName"].ToString());
            //    Tool.Tag = DR[i]["sFunctionID"].ToString();
            //    this.menuStrip1.Items.Add(Tool);
            //    ForEachNextMenu(Tool, DR[i]["sFunctionID"].ToString(), DT);
            //}

            this.menuStrip1.Items.Clear();
           // string strMenuGroupSql = "select * from SYS_Menu where sMenuGroupID='' and sFunctionID not in ('C') order by ssortby";
            string strMenuGroupSql = "select A.sFunctionName,A.sFunctionID from SYS_User_Authority A left outer join sys_menu M on A.sFunctionID=M.sFunctionID where M.sMenuGroupID='' and A.sFunctionID not in ('C') and iValidFlag>0 and A.sRole='" + FormMainFP.Pub_sRole + "'order by ssortby ";
            DataTable MenuGroupDT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strMenuGroupSql).Tables[0];
            string strAuthoritySql = "select m.smenugroupid,A.iValidFlag,F.* from sys_menu m left outer join SYS_User_Authority A on A.sfunctionid=m.sfunctionid left outer join Sys_Functions F on F.sFunctionID=m.sFunctionID where A.sRole='" + FormMainFP.Pub_sRole + "'";
            DataTable AuthoritySqlDT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strAuthoritySql).Tables[0];

            DataRow[] DR = MenuGroupDT.Select();
            for (int i = 0; i < DR.Length; i++)
            {
                ToolStripMenuItem Tool = new ToolStripMenuItem(DR[i]["sFunctionName"].ToString());
                   Tool.Tag = DR[i]["sFunctionID"].ToString();
                    this.menuStrip1.Items.Add(Tool);
                    ForEachNextMenu(Tool, DR[i]["sFunctionID"].ToString(), AuthoritySqlDT);
            }


            AuthoritySqlDT.Clear();
            AuthoritySqlDT.Reset();
            AuthoritySqlDT.Dispose();
            MenuGroupDT.Clear();
            MenuGroupDT.Reset();
            MenuGroupDT.Dispose();
            GC.Collect();
        }

        /// <summary>
        /// 增加toolstrip窗体界面 by kingry 12.06.29
        /// </summary>
        private void AddToolStripMain()
        {
            ToolStripMain.Items.Clear();

            string strMenuGroupSql = "select A.sFunctionName,A.sFunctionID,M.sMenuGroupID from SYS_User_Authority A left outer join sys_menu M on A.sFunctionID=M.sFunctionID where M.sMenuGroupID='' and A.sFunctionID not in ('C') and iValidFlag>0 and A.sRole='" + FormMainFP.Pub_sRole + "'order by ssortby ";
            DataTable MenuGroupDT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strMenuGroupSql).Tables[0];
             DataRow[] DR = MenuGroupDT.Select();
             for (int i = 0; i < DR.Length; i++)
             {

                 ToolStripButton Tool = new ToolStripButton(DR[i]["sFunctionName"].ToString());
                 Tool.Font = this.Font;
                 Tool.Tag = DR[i]["sMenuGroupID"].ToString();
                 this.ToolStripMain.Items.Add(Tool);
             }

             ToolStripSeparator separator = new ToolStripSeparator();
             //Tool.Tag = DR[i]["sMenuGroupID"].ToString();
             this.ToolStripMain.Items.Add(separator);

             ToolStripButton exitsystem = new ToolStripButton("退出系统");
             exitsystem.ToolTipText = "退出系统";
             exitsystem.Font = this.Font;
             this.ToolStripMain.Items.Add(exitsystem);

        }


        /// <summary>
        /// 根据菜单添加结构到功能HR树
        /// </summary>
        private void AddTreeViewFunctionNodes()
        {
            //string strSql = "SELECT FBH,GNBH,replace(GNMC,'&','') as GNMC FROM SYS_FUNCTION where GNMC<>'-' order by GNBH";
            //DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            #region"用普通的树TreeView控件"
            //ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            //TV.ReadNodesFromDataTable(this.treeViewLeftFun, DT, false, 0, 1, 2);
            #endregion
            #region"用HR的树控件"
            FromMenuAddNodeToTreeView();
            #endregion
            //DT.Clear();
            //DT.Reset();
            //DT.Dispose();
            GC.Collect();
        }
        /// <summary>
        /// 根据菜单添加结构到功能普通树
        /// </summary>
        private void AddTreeViewHelpNodes()
        {
            string strSql = "SELECT sMenugroupID,sFunctionID,replace(sFunctionName,'&','') as sFunctionName FROM SYS_Menu where sFunctionName<>'-' order by smenugroupid,ssortby";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            #region"用普通的树TreeView控件"
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            TV.ReadNodesFromDataTable(this.treeViewHelp, DT, false, 0, 1, 2);
            #endregion
            #region"用HR的树控件"
            //FromMenuAddNodeToTreeView();
            #endregion
            DT.Clear();
            GC.Collect();
        }
        /// <summary>
        /// 根据菜单添加结构到树
        /// </summary>
        private void FromMenuAddNodeToTreeView()
        {
            this.treeViewLeftFun.SetTreeControlStyle(ZX.Controls.DotNetMagic.Controls.TreeControlStyles.GroupOfficeLight);
            this.treeViewLeftFun.Indicators = ZX.Controls.DotNetMagic.Controls.Indicators.AtGroup;
            this.treeViewLeftFun.LineColor = Color.Green;
            this.treeViewLeftFun.LineDashStyle = ZX.Controls.DotNetMagic.Controls.LineDashStyle.Solid;

            for (int I = 0; I < this.menuStrip1.Items.Count; I++)
            {
                ZX.Controls.DotNetMagic.Controls.Node NodeGroup = new ZX.Controls.DotNetMagic.Controls.Node(this.menuStrip1.Items[I].Text.Replace("&", ""));
                NodeGroup.ImageIndex = 3;
                NodeGroup.SelectedImageIndex = 4;
                NodeGroup.Tag = this.menuStrip1.Items[I].Tag;
                this.treeViewLeftFun.Nodes.Add(NodeGroup);
                ToolStripMenuItem Tool = (ToolStripMenuItem)this.menuStrip1.Items[I];
                for (int J = 0; J < Tool.DropDownItems.Count; J++)
                {
                    if (!string.IsNullOrEmpty(Tool.DropDownItems[J].Text))
                    {
                        ZX.Controls.DotNetMagic.Controls.Node TNode = new ZX.Controls.DotNetMagic.Controls.Node(Tool.DropDownItems[J].Text);
                        TNode.Tag = Tool.DropDownItems[J].Tag;

                        if (Tool.DropDownItems[J].Enabled == false)
                        {
                            TNode.ForeColor = Color.LightGray;
                        }


                        NodeGroup.Nodes.Add(TNode);
                        ToolStripMenuItem ToolM = (ToolStripMenuItem)Tool.DropDownItems[J];
                        if (ToolM.DropDownItems.Count > 0)
                        {
                            for (int K = 0; K < ToolM.DropDownItems.Count; K++)
                            {
                                if (!string.IsNullOrEmpty(ToolM.DropDownItems[K].Text))
                                {
                                    ZX.Controls.DotNetMagic.Controls.Node TNodeM = new ZX.Controls.DotNetMagic.Controls.Node(ToolM.DropDownItems[K].Text);
                                    TNodeM.Tag = ToolM.DropDownItems[K].Tag;

                                    if (ToolM.DropDownItems[K].Enabled == false)
                                    {
                                        TNodeM.ForeColor = Color.LightGray;
                                    }

                                    TNode.Nodes.Add(TNodeM);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///双击树节点，启动功能
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void treeViewLeftFun_DoubleClick(object sender, EventArgs e)
        {
            if (this.treeViewLeftFun.SelectedNode.GetNodeCount() == 0 && this.treeViewLeftFun.SelectedNode.Tag != null && this.treeViewLeftFun.SelectedNode.ForeColor != Color.LightGray)
            {
                sender = this.treeViewLeftFun.SelectedNode;
                ToolNext_Click(sender, e);
                
                //隐藏流程图
                //zxPanel1.
            }
        }
        /// <summary>
        /// 当选择功能Tab时，要执行的事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TabControFormList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if ((this.TabControFormList.TabPages.Count != 0))
            {
                Form STag = (Form)this.TabControFormList.SelectedTab.Tag;
                Form[] MdiForm = this.MdiChildren;
                for (int I = 0; I <= MdiForm.Length - 1; I++)
                {
                    if (STag == MdiForm[I])
                    {
                        MdiForm[I].Activate();
                        if (MdiForm[I].MaximizeBox == true)
                        {
                            MdiForm[I].WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            MdiForm[I].WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 设置已打开窗体的菜单列表
        /// </summary>
        private void AddAgoFormList()
        {
            ToolStripMenuItem AgoToolStrip = null;
            for (int i = 0; i < this.menuStrip1.Items.Count; i++)
            {
                if (this.menuStrip1.Items[i].Text == "系统管理(&S)")
                {
                    ToolStripMenuItem toolStrip = (ToolStripMenuItem)this.menuStrip1.Items[i];
                    AgoToolStrip = (ToolStripMenuItem)toolStrip.DropDownItems.Find("已打开的窗体", false)[0];
                    break;
                }
            }
            if (AgoToolStrip != null)
            {
                string strFunctionName = this.TabControFormList.SelectedTab.Text;
                ToolStripMenuItem toolStripMenu = new ToolStripMenuItem(strFunctionName);
                toolStripMenu.Tag = this.TabControFormList.SelectedTab.Tag;
                AgoToolStrip.DropDownItems.Add(toolStripMenu);
                toolStripMenu.Click += new EventHandler(AgoToolStrip_Click);
            }
        }

        private void AgoToolStrip_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.TabPage TP in this.TabControFormList.TabPages)
            {
                if (TP.Tag == ((ToolStripMenuItem)sender).Tag)
                {
                    this.TabControFormList.SelectedTab = TP;
                    TP.Select();
                    break;
                }
            }
        }

        #region "审计人员待办事宜"
        /// <summary>
        /// 审计人员待办事宜
        /// </summary>
        private void WorkFile()
        {
           // slidingTitleBarRight.Open = true;//右边导航
            TabControlRight.SelectedTab = tabPage1;//工作情况
        }
        /// <summary>
        ///读取工作日志文件
        /// </summary>
        private void LoadWorkFile()
        {
            this.自动换行ToolStripMenuItem.CheckOnClick = true;
            string strWorkFile;
            strWorkFile = Application.StartupPath + @"\System\工作日志.doc";
            if (File.Exists(strWorkFile))
            {
                this.richTextWork.LoadFile(strWorkFile, RichTextBoxStreamType.RichText);
            }
        }
        private void 撤消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.Undo();
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.Redo();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.Cut();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.Paste();
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.SelectedText = "";
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.SelectAll();
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.ShowApply = true;
            FD.ShowColor = true;
            FD.ShowEffects = true;
            FD.ShowHelp = true;
            FD.Color = this.richTextWork.SelectionColor;
            FD.Font = this.richTextWork.SelectionFont;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                this.richTextWork.SelectionColor = FD.Color;
                this.richTextWork.SelectionFont = new Font(FD.Font.Name, FD.Font.Size, FD.Font.Style, FD.Font.Unit);
            }
        }

        private void 字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            CD.Color = this.richTextWork.SelectionColor;
            if (CD.ShowDialog() == DialogResult.OK)
            {
                this.richTextWork.SelectionColor = CD.Color;
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strWorkFile;
            strWorkFile = Application.StartupPath + @"\System\工作日志.doc";
            this.richTextWork.SaveFile(strWorkFile, RichTextBoxStreamType.RichText);
        }

        private void 保护选定文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextWork.SelectionLength != 0)
            {
                this.richTextWork.SelectionColor = Color.LightSalmon;
                this.richTextWork.SelectionProtected = true;
            }
        }

        private void 取消选定的保护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextWork.SelectionLength != 0)
            {
                this.richTextWork.SelectionColor = Color.Black;
                this.richTextWork.SelectionProtected = false;
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextWork.WordWrap = this.自动换行ToolStripMenuItem.Checked;
        }
        #endregion

        private void Form_Main_MdiChildActivate(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm != null && frm.WindowState == FormWindowState.Minimized)
            {
                for (int i = 0; i < TabControFormList.TabCount; i++)
                {

                    if (TabControFormList.SelectedTab.Tag == frm)
                    {
                        return;
                    }
                    if (TabControFormList.TabPages[i].Tag == frm)
                    {
                        TabControFormList.SelectedTab = TabControFormList.TabPages[i];
                        return;
                    }
                }
            }
        }

        private void toolStripHttp_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start("http://21233571.qzone.qq.com");

            System.Diagnostics.Process.Start("http://wpa.qq.com/msgrd?V=1&Uin=18000498");


        }

        private void ToolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.Text == "退出系统")
            {
                Application.Exit();
            }
            else
            {

                
                try
                {
                    string strFilePath = Application.StartupPath + "\\SYSFlow\\" + e.ClickedItem.ToolTipText + ".mpf";
                    this.zxPanel1.PaintItems.Clear();
                    this.zxPanel1.PaintItems = UnSerializeObjectFromFile(strFilePath);
                    this.zxPanel1.Refresh();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="FunctionText">功能名称</param>
        private void ToolNext_Click(string FunctionText)
        {
            
            string id = ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sFunctionID  from SYS_FUNCTIONs where sFunctionName like '%" + FunctionText + "%'").ToString();
            Form Frm = null;
            Frm = SystemClass.ApplicationFormMain.LoadFunction(id, FormMainFP, this);
            if (Frm != null)
            {
                System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(Frm.Text);
                TP.Tag = Frm;
                TP.ToolTipText = Frm.Text;
                this.TabControFormList.TabPages.Add(TP);
                this.TabControFormList.SelectedTab = TP;
                TP.Select();

                AddAgoFormList();

            }
        }

        private void Form_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                ZX.Win.FunctionParameter FP = new ZX.Win.FunctionParameter();
                FP.ToolStripitemDisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                FP.functionFormID = "-1";
                ZX.Win.ReflectionFunction RF = new ZX.Win.ReflectionFunction();
                Form frm = RF.LoadMdiForm("ZXSystem.Function.FunManage.dll", "ZXSystem.Function.FunManage.Form_Main_FunManage", this, FP);
                System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(frm.Text);
                TP.Tag = frm;
                this.TabControFormList.TabPages.Add(TP);
                this.TabControFormList.SelectedTab = TP;
                TP.Select();
                this.zxPanel1.Visible = false;
            }
            ///F12重新加载菜单
            if (e.KeyCode == Keys.F12)
            {
                AddMenu();
                AddToolStripMain();
                ZX.Win.SetToolBarIcon SBI1 = new ZX.Win.SetToolBarIcon();
                SBI1.SetImage(Application.StartupPath + @"\Images\TooBarIco\", this.ToolStripMain, ToolStripItemDisplayStyle.ImageAndText);
            }
        }

         //<summary>
         //反序列化
         //</summary>
         //<param name="storefilename">文件名</param>
         //<returns></returns>
        public List<IPaintItem> UnSerializeObjectFromFile(string storefilename)
        {
            List<IPaintItem> offlineobject = null;

          
            try
            {

                IFormatter formatter = new BinaryFormatter();
                Stream writer = new FileStream(storefilename, FileMode.Open);// new IsolatedStorageFileStream(string.Concat(@"OBU\", storefilename), FileMode.OpenOrCreate, isoStore);
                writer.Seek(0, SeekOrigin.Begin);
               offlineobject = (List<IPaintItem>)formatter.Deserialize(writer);
                writer.Close();

            }
            catch (Exception)
            {

                throw;
            }

                 
             

            return offlineobject;
            
        }

        /// <summary>
        /// 从本地存储反序列化业务对象
        /// </summary>
        /// <param name="storefilename">文件路径</param>
        /// <returns></returns>
        public void SerializeObjectToFile(string storefilename)
        {
            IFormatter formatter = new BinaryFormatter();


            // To write to a file, create a StreamWriter object.
            
            try
            {
                Stream writer = new FileStream(storefilename, FileMode.Create);
                formatter.Serialize(writer, zxPanel1.PaintItems);
                byte[] objbuffer = new byte[writer.Length];
                writer.Seek(0, SeekOrigin.Begin);
                writer.Read(objbuffer, 0, objbuffer.Length);
                writer.Close();

            }
            catch (Exception)
            {
                
                throw;
            }
            
           
        }


        private void zxPanel1_DragDrop(object sender, DragEventArgs e)
        {

        }

       

        private void zxPanel1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void zxPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form Frm = null;

            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标

            Point ZxpanelPoint = this.PointToClient(zxPanel1.Location);//zxpanel1的位置

            //两个坐标相减
            Point ItemPoint = new Point((formPoint.X - ZxpanelPoint.X), (formPoint.Y - ZxpanelPoint.Y - 20));
           

            //foreach (IPaintItem item1 in zxPanel1.m_paintitems)
            //{

            //    MessageBox.Show(formPoint.ToString() + "=" + item1.ItemLocate.ToString() + "+" + ZxpanelPoint.ToString());
            //    //MessageBox.Show(item1.ItemLocate.ToString());
            //}

            IPaintItem item = this.zxPanel1.GetItemAtPoint(ItemPoint);
            if (item != null && item is PaintUnit)
            {
                //string itemname = ZX.Controls.DotNetMagic.Controls.InputBox.InputBox.ShowInputBox();
                //MessageBox.Show(item.ItemName);
                //MessageBox.Show(item.ItemSpace);

                string FunctionID = "";
                FunctionID = item.ItemSpace;//sender.ToString();
                FormMainFP.pub_Object = FunctionID;//为特殊功能做准备

                //判断是否有权限
                string strSqlAUTHORITY = "SELECT * FROM SYS_USER_AUTHORITY where iValidFlag>0 and sFunctionID='" + FunctionID + "' and sRole='" + FormMainFP.Pub_sRole + "'";
                if ((ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlAUTHORITY).Tables[0].Rows.Count) == 0)
                {

                    ////ShowstatusMessage("没有权限访问");
                    //strMessageLable.BackColor = Color.Blue;
                    //strMessageLable.ForeColor = Color.White;
                    //strMessageLable.Text = "没有权限访问";
                    ShowLabelMessage("没有权限访问");
                    return;
                }
               


                string strSql = "SELECT * FROM SYS_Functions where sFunctionID='" + FunctionID + "'";
                if ((ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0].Rows.Count) > 0)
                {
                    zxPanel1.Visible = false;
                }
                
                if (PeculiarFunction(FunctionID) == false)//判断是不是特殊功能
                {
                    
                    Frm = SystemClass.ApplicationFormMain.LoadFunction(FunctionID, FormMainFP, this);
                    if (Frm != null)
                    {
                        
                        System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(Frm.Text);
                        TP.Tag = Frm;
                        TP.ToolTipText = Frm.Text;
                        this.TabControFormList.TabPages.Add(TP);
                        this.TabControFormList.SelectedTab = TP;
                        TP.Select();

                        AddAgoFormList();
                        
                       

                    }
                }
                

            }

            //MessageBox.Show("OK");
        }

        private void SaveFlow()
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SerializeObjectToFile(this.saveFileDialog1.FileName);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFlow();
        }

        private void OpenFlow()
        {
            
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.zxPanel1.PaintItems.Clear();
                    this.zxPanel1.PaintItems = UnSerializeObjectFromFile(this.openFileDialog1.FileName);
                    this.zxPanel1.Refresh();
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SaveFlow();
            MessageBox.Show("保存成功！");
        }

        private void TabControFormList_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void TabControFormList_ControlRemoved(object sender, ControlEventArgs e)
        {
           
            if (TabControFormList.TabPages.Count == 1)
            {
                
                zxPanel1.Visible = true;
            }
        }

        private void timer_MessageLabel_Tick(object sender, EventArgs e)
        {
            strMessageLable.BackColor = System.Drawing.SystemColors.Control;
            strMessageLable.Text = "";
            timer_MessageLabel.Enabled = false;
        }

        
       
    }
}
