namespace ZXSystem.Function.UpLoad
{
    partial class Form_Main_UpLoad
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gc_UpLoad = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_UpLoad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UpLoadPanel = new System.Windows.Forms.Panel();
            this.ccb_Location = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UpLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UpLoad)).BeginInit();
            this.UpLoadPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ToolStripButton4,
            this.ToolStripSeparator1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(763, 25);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "增加";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "增加信息";
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton4.Text = "删除";
            this.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton4.ToolTipText = "删除信息";
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
            // gc_UpLoad
            // 
            this.gc_UpLoad.AllowDrop = true;
            this.gc_UpLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_UpLoad.EmbeddedNavigator.Name = "";
            this.gc_UpLoad.Location = new System.Drawing.Point(0, 81);
            this.gc_UpLoad.MainView = this.gv_UpLoad;
            this.gc_UpLoad.Name = "gc_UpLoad";
            this.gc_UpLoad.Size = new System.Drawing.Size(763, 490);
            this.gc_UpLoad.TabIndex = 6;
            this.gc_UpLoad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UpLoad});
            this.gc_UpLoad.DragDrop += new System.Windows.Forms.DragEventHandler(this.gc_UpLoad_DragDrop);
            this.gc_UpLoad.DragEnter += new System.Windows.Forms.DragEventHandler(this.gc_UpLoad_DragEnter);
            // 
            // gv_UpLoad
            // 
            this.gv_UpLoad.GridControl = this.gc_UpLoad;
            this.gv_UpLoad.Name = "gv_UpLoad";
            this.gv_UpLoad.OptionsView.ShowGroupPanel = false;
            // 
            // UpLoadPanel
            // 
            this.UpLoadPanel.Controls.Add(this.txt_FilePath);
            this.UpLoadPanel.Controls.Add(this.label1);
            this.UpLoadPanel.Controls.Add(this.ccb_Location);
            this.UpLoadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpLoadPanel.Location = new System.Drawing.Point(0, 25);
            this.UpLoadPanel.Name = "UpLoadPanel";
            this.UpLoadPanel.Size = new System.Drawing.Size(763, 56);
            this.UpLoadPanel.TabIndex = 7;
            // 
            // ccb_Location
            // 
            this.ccb_Location.FormattingEnabled = true;
            this.ccb_Location.Items.AddRange(new object[] {
            ".\\Frx\\",
            ".\\Images\\",
            ".\\SYSFlow\\",
            ".\\System\\",
            ".\\"});
            this.ccb_Location.Location = new System.Drawing.Point(71, 17);
            this.ccb_Location.Name = "ccb_Location";
            this.ccb_Location.Size = new System.Drawing.Size(101, 20);
            this.ccb_Location.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件位置";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.AllowDrop = true;
            this.txt_FilePath.Location = new System.Drawing.Point(195, 16);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(565, 21);
            this.txt_FilePath.TabIndex = 2;
            this.txt_FilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_FilePath_DragDrop);
            this.txt_FilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_FilePath_DragEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel1.Text = "文件拖拽入界面,点击上传";
            // 
            // Form_Main_UpLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gc_UpLoad);
            this.Controls.Add(this.UpLoadPanel);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_UpLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "程序上传";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_Customer_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UpLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UpLoad)).EndInit();
            this.UpLoadPanel.ResumeLayout(false);
            this.UpLoadPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_UpLoad;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UpLoad;
        private System.Windows.Forms.Panel UpLoadPanel;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccb_Location;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

