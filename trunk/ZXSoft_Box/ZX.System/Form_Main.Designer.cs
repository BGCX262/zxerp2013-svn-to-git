namespace ZX.ZXSystem
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabControFormList = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.strMessageLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewLeftFun = new ZX.Controls.DotNetMagic.Controls.TreeControl();
            this.toolStripTemp = new System.Windows.Forms.ToolStrip();
            this.TabControlRight = new ZX.Controls.DotNetMagic.Controls.TabControl();
            this.tabPage1 = new ZX.Controls.DotNetMagic.Controls.TabPage();
            this.richTextWork = new System.Windows.Forms.RichTextBox();
            this.ContextMenuRichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.撤消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem26 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem36 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem47 = new System.Windows.Forms.ToolStripSeparator();
            this.字体FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem53 = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem54 = new System.Windows.Forms.ToolStripSeparator();
            this.保护选定文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消选定的保护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem55 = new System.Windows.Forms.ToolStripSeparator();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new ZX.Controls.DotNetMagic.Controls.TabPage();
            this.treeViewHelp = new System.Windows.Forms.TreeView();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.zxPanel1 = new ZX.Controls.DotNetMagic.Controls.ZXPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.slidingTitleBarLeft = new ZX.Controls.DotNetMagic.Controls.SlidingTitleBar();
            this.slidingTitleBarRight = new ZX.Controls.DotNetMagic.Controls.SlidingTitleBar();
            this.timer_MessageLabel = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.TabControlRight.SuspendLayout();
            this.ContextMenuRichText.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidingTitleBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingTitleBarRight)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(274, 351);
            this.Panel1.TabIndex = 39;
            // 
            // TabControFormList
            // 
            this.TabControFormList.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControFormList.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControFormList.HotTrack = true;
            this.TabControFormList.Location = new System.Drawing.Point(0, 56);
            this.TabControFormList.Name = "TabControFormList";
            this.TabControFormList.SelectedIndex = 0;
            this.TabControFormList.ShowToolTips = true;
            this.TabControFormList.Size = new System.Drawing.Size(901, 20);
            this.TabControFormList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControFormList.TabIndex = 40;
            this.TabControFormList.Tag = "TabControFormList";
            this.TabControFormList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TabControFormList_ControlAdded);
            this.TabControFormList.SelectedIndexChanged += new System.EventHandler(this.TabControFormList_SelectedIndexChanged);
            this.TabControFormList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.TabControFormList_ControlRemoved);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.strMessageLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(901, 22);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // strMessageLable
            // 
            this.strMessageLable.AutoSize = false;
            this.strMessageLable.BackColor = System.Drawing.SystemColors.Control;
            this.strMessageLable.ForeColor = System.Drawing.Color.Red;
            this.strMessageLable.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
            this.strMessageLable.Name = "strMessageLable";
            this.strMessageLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.strMessageLable.Size = new System.Drawing.Size(230, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Nomorl.ico");
            this.imageList1.Images.SetKeyName(1, "SelectOne.ico");
            this.imageList1.Images.SetKeyName(2, "SelectTwo.ico");
            this.imageList1.Images.SetKeyName(3, "打开.ICO");
            this.imageList1.Images.SetKeyName(4, "打开1.ico");
            this.imageList1.Images.SetKeyName(5, "186.ICO");
            this.imageList1.Images.SetKeyName(6, "帮助.ico");
            // 
            // treeViewLeftFun
            // 
            this.treeViewLeftFun.FocusNode = null;
            this.treeViewLeftFun.HotBackColor = System.Drawing.Color.Empty;
            this.treeViewLeftFun.HotForeColor = System.Drawing.Color.Empty;
            this.treeViewLeftFun.Location = new System.Drawing.Point(34, 195);
            this.treeViewLeftFun.Name = "treeViewLeftFun";
            this.treeViewLeftFun.SelectedNode = null;
            this.treeViewLeftFun.SelectedNoFocusBackColor = System.Drawing.SystemColors.Control;
            this.treeViewLeftFun.Size = new System.Drawing.Size(139, 193);
            this.treeViewLeftFun.TabIndex = 51;
            this.treeViewLeftFun.Text = "treeControl1";
            this.treeViewLeftFun.DoubleClick += new System.EventHandler(this.treeViewLeftFun_DoubleClick);
            // 
            // toolStripTemp
            // 
            this.toolStripTemp.AllowMerge = false;
            this.toolStripTemp.AutoSize = false;
            this.toolStripTemp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTemp.Location = new System.Drawing.Point(0, 51);
            this.toolStripTemp.Name = "toolStripTemp";
            this.toolStripTemp.Size = new System.Drawing.Size(901, 5);
            this.toolStripTemp.TabIndex = 53;
            this.toolStripTemp.Text = "toolStrip1";
            // 
            // TabControlRight
            // 
            this.TabControlRight.Location = new System.Drawing.Point(625, 97);
            this.TabControlRight.Name = "TabControlRight";
            this.TabControlRight.OfficeDockSides = false;
            this.TabControlRight.OfficeStyle = ZX.Controls.DotNetMagic.Controls.OfficeStyle.Light;
            this.TabControlRight.SelectedIndex = 0;
            this.TabControlRight.ShowDropSelect = false;
            this.TabControlRight.Size = new System.Drawing.Size(276, 376);
            this.TabControlRight.TabIndex = 55;
            this.TabControlRight.TabPages.AddRange(new ZX.Controls.DotNetMagic.Controls.TabPage[] {
            this.tabPage1,
            this.tabPage2});
            this.TabControlRight.TextTips = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Control = this.richTextWork;
            this.tabPage1.Icon = ((System.Drawing.Icon)(resources.GetObject("tabPage1.Icon")));
            this.tabPage1.InactiveBackColor = System.Drawing.Color.Empty;
            this.tabPage1.InactiveTextBackColor = System.Drawing.Color.Empty;
            this.tabPage1.InactiveTextColor = System.Drawing.Color.Empty;
            this.tabPage1.Location = new System.Drawing.Point(1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.SelectBackColor = System.Drawing.Color.Empty;
            this.tabPage1.SelectTextBackColor = System.Drawing.Color.Empty;
            this.tabPage1.SelectTextColor = System.Drawing.Color.Empty;
            this.tabPage1.Size = new System.Drawing.Size(278, 511);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Title = "工作情况";
            this.tabPage1.ToolTip = "Page";
            // 
            // richTextWork
            // 
            this.richTextWork.ContextMenuStrip = this.ContextMenuRichText;
            this.richTextWork.Location = new System.Drawing.Point(1, 1);
            this.richTextWork.Name = "richTextWork";
            this.richTextWork.Size = new System.Drawing.Size(274, 351);
            this.richTextWork.TabIndex = 56;
            this.richTextWork.Text = "";
            // 
            // ContextMenuRichText
            // 
            this.ContextMenuRichText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消ToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.ToolStripMenuItem26,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.删除DToolStripMenuItem,
            this.ToolStripMenuItem36,
            this.全选AToolStripMenuItem,
            this.ToolStripMenuItem47,
            this.字体FToolStripMenuItem,
            this.字体颜色ToolStripMenuItem,
            this.ToolStripMenuItem53,
            this.保存SToolStripMenuItem,
            this.ToolStripMenuItem54,
            this.保护选定文本ToolStripMenuItem,
            this.取消选定的保护ToolStripMenuItem,
            this.ToolStripMenuItem55,
            this.自动换行ToolStripMenuItem});
            this.ContextMenuRichText.Name = "ContextMenuRichText";
            this.ContextMenuRichText.Size = new System.Drawing.Size(207, 326);
            // 
            // 撤消ToolStripMenuItem
            // 
            this.撤消ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("撤消ToolStripMenuItem.Image")));
            this.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem";
            this.撤消ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.撤消ToolStripMenuItem.Text = "撤消(&U)";
            this.撤消ToolStripMenuItem.Click += new System.EventHandler(this.撤消ToolStripMenuItem_Click);
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("重复RToolStripMenuItem.Image")));
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            this.重复RToolStripMenuItem.Click += new System.EventHandler(this.重复RToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem26
            // 
            this.ToolStripMenuItem26.Name = "ToolStripMenuItem26";
            this.ToolStripMenuItem26.Size = new System.Drawing.Size(203, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            this.剪切TToolStripMenuItem.Click += new System.EventHandler(this.剪切TToolStripMenuItem_Click);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            this.粘贴PToolStripMenuItem.Click += new System.EventHandler(this.粘贴PToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除DToolStripMenuItem.Image")));
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem36
            // 
            this.ToolStripMenuItem36.Name = "ToolStripMenuItem36";
            this.ToolStripMenuItem36.Size = new System.Drawing.Size(203, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            this.全选AToolStripMenuItem.Click += new System.EventHandler(this.全选AToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem47
            // 
            this.ToolStripMenuItem47.Name = "ToolStripMenuItem47";
            this.ToolStripMenuItem47.Size = new System.Drawing.Size(203, 6);
            // 
            // 字体FToolStripMenuItem
            // 
            this.字体FToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("字体FToolStripMenuItem.Image")));
            this.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem";
            this.字体FToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.字体FToolStripMenuItem.Text = "字体(&F)";
            this.字体FToolStripMenuItem.Click += new System.EventHandler(this.字体FToolStripMenuItem_Click);
            // 
            // 字体颜色ToolStripMenuItem
            // 
            this.字体颜色ToolStripMenuItem.Name = "字体颜色ToolStripMenuItem";
            this.字体颜色ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.字体颜色ToolStripMenuItem.Text = "字体颜色";
            this.字体颜色ToolStripMenuItem.Click += new System.EventHandler(this.字体颜色ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem53
            // 
            this.ToolStripMenuItem53.Name = "ToolStripMenuItem53";
            this.ToolStripMenuItem53.Size = new System.Drawing.Size(203, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem54
            // 
            this.ToolStripMenuItem54.Name = "ToolStripMenuItem54";
            this.ToolStripMenuItem54.Size = new System.Drawing.Size(203, 6);
            // 
            // 保护选定文本ToolStripMenuItem
            // 
            this.保护选定文本ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保护选定文本ToolStripMenuItem.Image")));
            this.保护选定文本ToolStripMenuItem.Name = "保护选定文本ToolStripMenuItem";
            this.保护选定文本ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.保护选定文本ToolStripMenuItem.Text = "保护选定文本";
            this.保护选定文本ToolStripMenuItem.Click += new System.EventHandler(this.保护选定文本ToolStripMenuItem_Click);
            // 
            // 取消选定的保护ToolStripMenuItem
            // 
            this.取消选定的保护ToolStripMenuItem.Name = "取消选定的保护ToolStripMenuItem";
            this.取消选定的保护ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.取消选定的保护ToolStripMenuItem.Text = "取消选定的保护　　　　";
            this.取消选定的保护ToolStripMenuItem.Click += new System.EventHandler(this.取消选定的保护ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem55
            // 
            this.ToolStripMenuItem55.Name = "ToolStripMenuItem55";
            this.ToolStripMenuItem55.Size = new System.Drawing.Size(203, 6);
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.Checked = true;
            this.自动换行ToolStripMenuItem.CheckOnClick = true;
            this.自动换行ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.自动换行ToolStripMenuItem.Text = "自动换行";
            this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Control = this.treeViewHelp;
            this.tabPage2.Icon = ((System.Drawing.Icon)(resources.GetObject("tabPage2.Icon")));
            this.tabPage2.InactiveBackColor = System.Drawing.Color.Empty;
            this.tabPage2.InactiveTextBackColor = System.Drawing.Color.Empty;
            this.tabPage2.InactiveTextColor = System.Drawing.Color.Empty;
            this.tabPage2.Location = new System.Drawing.Point(1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.SelectBackColor = System.Drawing.Color.Empty;
            this.tabPage2.Selected = false;
            this.tabPage2.SelectTextBackColor = System.Drawing.Color.Empty;
            this.tabPage2.SelectTextColor = System.Drawing.Color.Empty;
            this.tabPage2.Size = new System.Drawing.Size(278, 511);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Title = "联机帮助";
            this.tabPage2.ToolTip = "Page";
            // 
            // treeViewHelp
            // 
            this.treeViewHelp.HideSelection = false;
            this.treeViewHelp.ImageIndex = 5;
            this.treeViewHelp.ImageList = this.imageList1;
            this.treeViewHelp.LineColor = System.Drawing.Color.Empty;
            this.treeViewHelp.Location = new System.Drawing.Point(1, 1);
            this.treeViewHelp.Name = "treeViewHelp";
            this.treeViewHelp.SelectedImageIndex = 5;
            this.treeViewHelp.Size = new System.Drawing.Size(274, 351);
            this.treeViewHelp.TabIndex = 56;
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripButton13
            // 
            this.ToolStripButton13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton13.Name = "ToolStripButton13";
            this.ToolStripButton13.Size = new System.Drawing.Size(69, 24);
            this.ToolStripButton13.Text = "退出系统";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.AllowDrop = true;
            this.ToolStripMain.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator8,
            this.ToolStripButton13});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(901, 27);
            this.ToolStripMain.Stretch = true;
            this.ToolStripMain.TabIndex = 46;
            this.ToolStripMain.Text = "ToolStrip1";
            this.ToolStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripMain_ItemClicked);
            // 
            // zxPanel1
            // 
            this.zxPanel1.AllowDrop = true;
            this.zxPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zxPanel1.DrawingLink = false;
            this.zxPanel1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.zxPanel1.GridSpace = 20;
            this.zxPanel1.Location = new System.Drawing.Point(0, 76);
            this.zxPanel1.Name = "zxPanel1";
            this.zxPanel1.PaintItems = ((System.Collections.Generic.List<ZX.Controls.DotNetMagic.Controls.IPaintItem>)(resources.GetObject("zxPanel1.PaintItems")));
            this.zxPanel1.ShowGrid = true;
            this.zxPanel1.Size = new System.Drawing.Size(901, 548);
            this.zxPanel1.TabIndex = 65;
            this.zxPanel1.Text = "zxPanel1";
            this.zxPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zxPanel1_MouseDoubleClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "mpf";
            this.saveFileDialog1.Filter = "mpf|*.mpf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mpf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mpf|*.mpf";
            // 
            // slidingTitleBarLeft
            // 
            this.slidingTitleBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingTitleBarLeft.Edge = ZX.Controls.DotNetMagic.Controls.TitleEdge.Left;
            this.slidingTitleBarLeft.GradientDirection = ZX.Controls.DotNetMagic.Controls.GradientDirection.TopToBottom;
            this.slidingTitleBarLeft.Location = new System.Drawing.Point(0, 76);
            this.slidingTitleBarLeft.MouseOverColor = System.Drawing.Color.Empty;
            this.slidingTitleBarLeft.Name = "slidingTitleBarLeft";
            // 
            // 
            // 
            this.slidingTitleBarLeft.Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.slidingTitleBarLeft.Panel.Location = new System.Drawing.Point(28, 0);
            this.slidingTitleBarLeft.Panel.Name = "";
            this.slidingTitleBarLeft.Panel.Size = new System.Drawing.Size(143, 546);
            this.slidingTitleBarLeft.Panel.TabIndex = 1;
            this.slidingTitleBarLeft.Size = new System.Drawing.Size(173, 548);
            this.slidingTitleBarLeft.TabIndex = 67;
            this.slidingTitleBarLeft.Text = "系统功能导航";
            this.slidingTitleBarLeft.TextAlignment = System.Drawing.StringAlignment.Center;
            this.slidingTitleBarLeft.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.slidingTitleBarLeft.TitleFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slidingTitleBarLeft.TitleForeColor = System.Drawing.Color.Blue;
            // 
            // slidingTitleBarRight
            // 
            this.slidingTitleBarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.slidingTitleBarRight.Edge = ZX.Controls.DotNetMagic.Controls.TitleEdge.Right;
            this.slidingTitleBarRight.GradientDirection = ZX.Controls.DotNetMagic.Controls.GradientDirection.TopToBottom;
            this.slidingTitleBarRight.Location = new System.Drawing.Point(706, 76);
            this.slidingTitleBarRight.MouseOverColor = System.Drawing.Color.Empty;
            this.slidingTitleBarRight.Name = "slidingTitleBarRight";
            // 
            // 
            // 
            this.slidingTitleBarRight.Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.slidingTitleBarRight.Panel.Location = new System.Drawing.Point(0, 0);
            this.slidingTitleBarRight.Panel.Name = "";
            this.slidingTitleBarRight.Panel.Size = new System.Drawing.Size(165, 546);
            this.slidingTitleBarRight.Panel.TabIndex = 1;
            this.slidingTitleBarRight.Size = new System.Drawing.Size(195, 548);
            this.slidingTitleBarRight.TabIndex = 56;
            this.slidingTitleBarRight.Text = "软件功能导航";
            this.slidingTitleBarRight.TextAlignment = System.Drawing.StringAlignment.Center;
            this.slidingTitleBarRight.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.slidingTitleBarRight.TitleFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slidingTitleBarRight.TitleForeColor = System.Drawing.Color.Blue;
            // 
            // timer_MessageLabel
            // 
            this.timer_MessageLabel.Interval = 10000;
            this.timer_MessageLabel.Tick += new System.EventHandler(this.timer_MessageLabel_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 646);
            this.Controls.Add(this.slidingTitleBarRight);
            this.Controls.Add(this.slidingTitleBarLeft);
            this.Controls.Add(this.zxPanel1);
            this.Controls.Add(this.treeViewLeftFun);
            this.Controls.Add(this.TabControFormList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTemp);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "置祥软件";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form_Main_MdiChildActivate);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabControlRight.ResumeLayout(false);
            this.ContextMenuRichText.ResumeLayout(false);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidingTitleBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingTitleBarRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
       
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private ZX.Controls.DotNetMagic.Controls.TreeControl treeViewLeftFun;
        private System.Windows.Forms.ToolStrip toolStripTemp;
        private System.Windows.Forms.TabControl TabControFormList;
        private ZX.Controls.DotNetMagic.Controls.TabControl TabControlRight;
        private ZX.Controls.DotNetMagic.Controls.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextWork;
        internal System.Windows.Forms.TreeView treeViewHelp;
        private ZX.Controls.DotNetMagic.Controls.TabPage tabPage2;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuRichText;
        internal System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem26;
        internal System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem36;
        internal System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem47;
        internal System.Windows.Forms.ToolStripMenuItem 字体FToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 字体颜色ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem53;
        internal System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem54;
        internal System.Windows.Forms.ToolStripMenuItem 保护选定文本ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 取消选定的保护ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem55;
        internal System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton ToolStripButton13;
        internal System.Windows.Forms.ToolStrip ToolStripMain;
        private ZX.Controls.DotNetMagic.Controls.ZXPanel zxPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ZX.Controls.DotNetMagic.Controls.SlidingTitleBar slidingTitleBarLeft;
        private ZX.Controls.DotNetMagic.Controls.SlidingTitleBar slidingTitleBarRight;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel strMessageLable;
        private System.Windows.Forms.Timer timer_MessageLabel;

    }
}
