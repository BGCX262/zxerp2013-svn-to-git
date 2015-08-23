namespace ZXSystem.Function.UserAuthority
{
    partial class Form_Main_UserAuthority
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
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gc_Authority = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_Authority = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Role = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_Role = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Authority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Authority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Role)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripButton1.Text = "刷新";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // gc_Authority
            // 
            this.gc_Authority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Authority.EmbeddedNavigator.Name = "";
            this.gc_Authority.Location = new System.Drawing.Point(271, 25);
            this.gc_Authority.MainView = this.gv_Authority;
            this.gc_Authority.Name = "gc_Authority";
            this.gc_Authority.Size = new System.Drawing.Size(492, 546);
            this.gc_Authority.TabIndex = 6;
            this.gc_Authority.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Authority});
            // 
            // gv_Authority
            // 
            this.gv_Authority.GridControl = this.gc_Authority;
            this.gv_Authority.Name = "gv_Authority";
            this.gv_Authority.OptionsView.ShowGroupPanel = false;
            // 
            // gc_Role
            // 
            this.gc_Role.Dock = System.Windows.Forms.DockStyle.Left;
            this.gc_Role.EmbeddedNavigator.Name = "";
            this.gc_Role.Location = new System.Drawing.Point(0, 25);
            this.gc_Role.MainView = this.gv_Role;
            this.gc_Role.Name = "gc_Role";
            this.gc_Role.Size = new System.Drawing.Size(261, 546);
            this.gc_Role.TabIndex = 7;
            this.gc_Role.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Role});
            // 
            // gv_Role
            // 
            this.gv_Role.GridControl = this.gc_Role;
            this.gv_Role.Name = "gv_Role";
            this.gv_Role.OptionsView.ShowGroupPanel = false;
            this.gv_Role.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Role_FocusedRowChanged);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(261, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 546);
            this.splitter1.TabIndex = 59;
            this.splitter1.TabStop = false;
            // 
            // Form_Main_UserAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.gc_Authority);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gc_Role);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_UserAuthority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "权限设置";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_Customer_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Authority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Authority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Role)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolTip toolTip1;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_Authority;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Authority;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_Role;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Role;
        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

