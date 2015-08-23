namespace ZXSystem.Function.ProductProcess
{
    partial class Form_Main_ProductProcess
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_WCR = new System.Windows.Forms.GroupBox();
            this.gc_WCR = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WCR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WPrint_Offset = new System.Windows.Forms.GroupBox();
            this.gc_WPrint_Offset = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WPrint_Offset = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WPrint_WBI = new System.Windows.Forms.GroupBox();
            this.gc_WPrint_WBI = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WPrint_WBI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WDieCut = new System.Windows.Forms.GroupBox();
            this.gc_WDieCut = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WDieCut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WPack = new System.Windows.Forms.GroupBox();
            this.gc_WPack = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WPack = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WStitch = new System.Windows.Forms.GroupBox();
            this.gc_WStitch = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WStitch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gb_WGule = new System.Windows.Forms.GroupBox();
            this.gc_WGule = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WGule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_WorkOrderExt = new System.Windows.Forms.GroupBox();
            this.gc_WorkOrderExt = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_WorkOrderExt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gb_WCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WCR)).BeginInit();
            this.gb_WPrint_Offset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPrint_Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPrint_Offset)).BeginInit();
            this.gb_WPrint_WBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPrint_WBI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPrint_WBI)).BeginInit();
            this.gb_WDieCut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WDieCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WDieCut)).BeginInit();
            this.gb_WPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPack)).BeginInit();
            this.gb_WStitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WStitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WStitch)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.gb_WGule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGule)).BeginInit();
            this.gb_WorkOrderExt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WorkOrderExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WorkOrderExt)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_WCR
            // 
            this.gb_WCR.Controls.Add(this.gc_WCR);
            this.gb_WCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WCR.Location = new System.Drawing.Point(0, 25);
            this.gb_WCR.Name = "gb_WCR";
            this.gb_WCR.Size = new System.Drawing.Size(952, 106);
            this.gb_WCR.TabIndex = 7;
            this.gb_WCR.TabStop = false;
            this.gb_WCR.Text = "瓦楞机";
            // 
            // gc_WCR
            // 
            this.gc_WCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WCR.EmbeddedNavigator.Name = "";
            this.gc_WCR.Location = new System.Drawing.Point(3, 17);
            this.gc_WCR.MainView = this.gv_WCR;
            this.gc_WCR.Name = "gc_WCR";
            this.gc_WCR.Size = new System.Drawing.Size(946, 86);
            this.gc_WCR.TabIndex = 7;
            this.gc_WCR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WCR});
            this.gc_WCR.Click += new System.EventHandler(this.gc_WCR_Click);
            // 
            // gv_WCR
            // 
            this.gv_WCR.GridControl = this.gc_WCR;
            this.gv_WCR.Name = "gv_WCR";
            this.gv_WCR.OptionsView.ShowGroupPanel = false;
            this.gv_WCR.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_WCR_RowStyle);
            // 
            // gb_WPrint_Offset
            // 
            this.gb_WPrint_Offset.Controls.Add(this.gc_WPrint_Offset);
            this.gb_WPrint_Offset.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WPrint_Offset.Location = new System.Drawing.Point(0, 131);
            this.gb_WPrint_Offset.Name = "gb_WPrint_Offset";
            this.gb_WPrint_Offset.Size = new System.Drawing.Size(952, 94);
            this.gb_WPrint_Offset.TabIndex = 8;
            this.gb_WPrint_Offset.TabStop = false;
            this.gb_WPrint_Offset.Text = "印刷";
            // 
            // gc_WPrint_Offset
            // 
            this.gc_WPrint_Offset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WPrint_Offset.EmbeddedNavigator.Name = "";
            this.gc_WPrint_Offset.Location = new System.Drawing.Point(3, 17);
            this.gc_WPrint_Offset.MainView = this.gv_WPrint_Offset;
            this.gc_WPrint_Offset.Name = "gc_WPrint_Offset";
            this.gc_WPrint_Offset.Size = new System.Drawing.Size(946, 74);
            this.gc_WPrint_Offset.TabIndex = 7;
            this.gc_WPrint_Offset.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WPrint_Offset});
            // 
            // gv_WPrint_Offset
            // 
            this.gv_WPrint_Offset.GridControl = this.gc_WPrint_Offset;
            this.gv_WPrint_Offset.Name = "gv_WPrint_Offset";
            this.gv_WPrint_Offset.OptionsView.ShowGroupPanel = false;
            // 
            // gb_WPrint_WBI
            // 
            this.gb_WPrint_WBI.Controls.Add(this.gc_WPrint_WBI);
            this.gb_WPrint_WBI.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WPrint_WBI.Location = new System.Drawing.Point(0, 225);
            this.gb_WPrint_WBI.Name = "gb_WPrint_WBI";
            this.gb_WPrint_WBI.Size = new System.Drawing.Size(952, 106);
            this.gb_WPrint_WBI.TabIndex = 9;
            this.gb_WPrint_WBI.TabStop = false;
            this.gb_WPrint_WBI.Text = "水印";
            // 
            // gc_WPrint_WBI
            // 
            this.gc_WPrint_WBI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WPrint_WBI.EmbeddedNavigator.Name = "";
            this.gc_WPrint_WBI.Location = new System.Drawing.Point(3, 17);
            this.gc_WPrint_WBI.MainView = this.gv_WPrint_WBI;
            this.gc_WPrint_WBI.Name = "gc_WPrint_WBI";
            this.gc_WPrint_WBI.Size = new System.Drawing.Size(946, 86);
            this.gc_WPrint_WBI.TabIndex = 7;
            this.gc_WPrint_WBI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WPrint_WBI});
            // 
            // gv_WPrint_WBI
            // 
            this.gv_WPrint_WBI.GridControl = this.gc_WPrint_WBI;
            this.gv_WPrint_WBI.Name = "gv_WPrint_WBI";
            this.gv_WPrint_WBI.OptionsView.ShowGroupPanel = false;
            // 
            // gb_WDieCut
            // 
            this.gb_WDieCut.Controls.Add(this.gc_WDieCut);
            this.gb_WDieCut.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WDieCut.Location = new System.Drawing.Point(0, 440);
            this.gb_WDieCut.Name = "gb_WDieCut";
            this.gb_WDieCut.Size = new System.Drawing.Size(952, 82);
            this.gb_WDieCut.TabIndex = 10;
            this.gb_WDieCut.TabStop = false;
            this.gb_WDieCut.Text = "模切";
            // 
            // gc_WDieCut
            // 
            this.gc_WDieCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WDieCut.EmbeddedNavigator.Name = "";
            this.gc_WDieCut.Location = new System.Drawing.Point(3, 17);
            this.gc_WDieCut.MainView = this.gv_WDieCut;
            this.gc_WDieCut.Name = "gc_WDieCut";
            this.gc_WDieCut.Size = new System.Drawing.Size(946, 62);
            this.gc_WDieCut.TabIndex = 7;
            this.gc_WDieCut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WDieCut});
            // 
            // gv_WDieCut
            // 
            this.gv_WDieCut.GridControl = this.gc_WDieCut;
            this.gv_WDieCut.Name = "gv_WDieCut";
            this.gv_WDieCut.OptionsView.ShowGroupPanel = false;
            // 
            // gb_WPack
            // 
            this.gb_WPack.Controls.Add(this.gc_WPack);
            this.gb_WPack.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WPack.Location = new System.Drawing.Point(0, 331);
            this.gb_WPack.Name = "gb_WPack";
            this.gb_WPack.Size = new System.Drawing.Size(952, 109);
            this.gb_WPack.TabIndex = 11;
            this.gb_WPack.TabStop = false;
            this.gb_WPack.Text = "打包";
            // 
            // gc_WPack
            // 
            this.gc_WPack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WPack.EmbeddedNavigator.Name = "";
            this.gc_WPack.Location = new System.Drawing.Point(3, 17);
            this.gc_WPack.MainView = this.gv_WPack;
            this.gc_WPack.Name = "gc_WPack";
            this.gc_WPack.Size = new System.Drawing.Size(946, 89);
            this.gc_WPack.TabIndex = 7;
            this.gc_WPack.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WPack});
            // 
            // gv_WPack
            // 
            this.gv_WPack.GridControl = this.gc_WPack;
            this.gv_WPack.Name = "gv_WPack";
            this.gv_WPack.OptionsView.ShowGroupPanel = false;
            // 
            // gb_WStitch
            // 
            this.gb_WStitch.Controls.Add(this.gc_WStitch);
            this.gb_WStitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WStitch.Location = new System.Drawing.Point(0, 522);
            this.gb_WStitch.Name = "gb_WStitch";
            this.gb_WStitch.Size = new System.Drawing.Size(952, 98);
            this.gb_WStitch.TabIndex = 12;
            this.gb_WStitch.TabStop = false;
            this.gb_WStitch.Text = "装钉";
            // 
            // gc_WStitch
            // 
            this.gc_WStitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WStitch.EmbeddedNavigator.Name = "";
            this.gc_WStitch.Location = new System.Drawing.Point(3, 17);
            this.gc_WStitch.MainView = this.gv_WStitch;
            this.gc_WStitch.Name = "gc_WStitch";
            this.gc_WStitch.Size = new System.Drawing.Size(946, 78);
            this.gc_WStitch.TabIndex = 7;
            this.gc_WStitch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WStitch});
            // 
            // gv_WStitch
            // 
            this.gv_WStitch.GridControl = this.gc_WStitch;
            this.gv_WStitch.Name = "gv_WStitch";
            this.gv_WStitch.OptionsView.ShowGroupPanel = false;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ToolStripButton6,
            this.ToolStripSeparator1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(952, 25);
            this.ToolStrip1.TabIndex = 13;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton6.Text = "保存";
            this.ToolStripButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton6.ToolTipText = "保存数据";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton3.Text = "帮助";
            this.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton3.ToolTipText = "系统帮助";
            // 
            // ToolStripSplitButton2
            // 
            this.ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            this.ToolStripSplitButton2.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSplitButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton2.Text = "关闭";
            this.ToolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton2.ToolTipText = "关闭窗口";
            // 
            // gb_WGule
            // 
            this.gb_WGule.Controls.Add(this.gc_WGule);
            this.gb_WGule.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WGule.Location = new System.Drawing.Point(0, 620);
            this.gb_WGule.Name = "gb_WGule";
            this.gb_WGule.Size = new System.Drawing.Size(952, 95);
            this.gb_WGule.TabIndex = 14;
            this.gb_WGule.TabStop = false;
            this.gb_WGule.Text = "粘合";
            // 
            // gc_WGule
            // 
            this.gc_WGule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WGule.EmbeddedNavigator.Name = "";
            this.gc_WGule.Location = new System.Drawing.Point(3, 17);
            this.gc_WGule.MainView = this.gv_WGule;
            this.gc_WGule.Name = "gc_WGule";
            this.gc_WGule.Size = new System.Drawing.Size(946, 75);
            this.gc_WGule.TabIndex = 7;
            this.gc_WGule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WGule});
            // 
            // gv_WGule
            // 
            this.gv_WGule.GridControl = this.gc_WGule;
            this.gv_WGule.Name = "gv_WGule";
            this.gv_WGule.OptionsView.ShowGroupPanel = false;
            // 
            // gb_WorkOrderExt
            // 
            this.gb_WorkOrderExt.Controls.Add(this.gc_WorkOrderExt);
            this.gb_WorkOrderExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_WorkOrderExt.Location = new System.Drawing.Point(0, 715);
            this.gb_WorkOrderExt.Name = "gb_WorkOrderExt";
            this.gb_WorkOrderExt.Size = new System.Drawing.Size(952, 106);
            this.gb_WorkOrderExt.TabIndex = 15;
            this.gb_WorkOrderExt.TabStop = false;
            this.gb_WorkOrderExt.Text = "产品信息";
            // 
            // gc_WorkOrderExt
            // 
            this.gc_WorkOrderExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WorkOrderExt.EmbeddedNavigator.Name = "";
            this.gc_WorkOrderExt.Location = new System.Drawing.Point(3, 17);
            this.gc_WorkOrderExt.MainView = this.gv_WorkOrderExt;
            this.gc_WorkOrderExt.Name = "gc_WorkOrderExt";
            this.gc_WorkOrderExt.Size = new System.Drawing.Size(946, 86);
            this.gc_WorkOrderExt.TabIndex = 7;
            this.gc_WorkOrderExt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WorkOrderExt});
            // 
            // gv_WorkOrderExt
            // 
            this.gv_WorkOrderExt.GridControl = this.gc_WorkOrderExt;
            this.gv_WorkOrderExt.Name = "gv_WorkOrderExt";
            this.gv_WorkOrderExt.OptionsView.ShowGroupPanel = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "算料";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "保存数据";
            // 
            // Form_Main_ProductProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 573);
            this.Controls.Add(this.gb_WorkOrderExt);
            this.Controls.Add(this.gb_WGule);
            this.Controls.Add(this.gb_WStitch);
            this.Controls.Add(this.gb_WDieCut);
            this.Controls.Add(this.gb_WPack);
            this.Controls.Add(this.gb_WPrint_WBI);
            this.Controls.Add(this.gb_WPrint_Offset);
            this.Controls.Add(this.gb_WCR);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_ProductProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "工序信息";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_Customer_FormClosing);
            this.gb_WCR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WCR)).EndInit();
            this.gb_WPrint_Offset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPrint_Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPrint_Offset)).EndInit();
            this.gb_WPrint_WBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPrint_WBI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPrint_WBI)).EndInit();
            this.gb_WDieCut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WDieCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WDieCut)).EndInit();
            this.gb_WPack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WPack)).EndInit();
            this.gb_WStitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WStitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WStitch)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.gb_WGule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGule)).EndInit();
            this.gb_WorkOrderExt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WorkOrderExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WorkOrderExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gb_WCR;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WCR;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WCR;
        private System.Windows.Forms.GroupBox gb_WPrint_Offset;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WPrint_Offset;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WPrint_Offset;
        private System.Windows.Forms.GroupBox gb_WPrint_WBI;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WPrint_WBI;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WPrint_WBI;
        private System.Windows.Forms.GroupBox gb_WDieCut;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WDieCut;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WDieCut;
        private System.Windows.Forms.GroupBox gb_WPack;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WPack;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WPack;
        private System.Windows.Forms.GroupBox gb_WStitch;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WStitch;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WStitch;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.GroupBox gb_WGule;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WGule;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WGule;
        private System.Windows.Forms.GroupBox gb_WorkOrderExt;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_WorkOrderExt;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WorkOrderExt;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

