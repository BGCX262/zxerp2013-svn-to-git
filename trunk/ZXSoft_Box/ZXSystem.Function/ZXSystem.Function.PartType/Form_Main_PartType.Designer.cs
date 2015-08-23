namespace ZXSystem.Function.PartType
{
    partial class Form_Main_PartType
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
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_Common = new ZX.Controls.DataGridViewEx.DataGridViewC();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gc_Common = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_Common = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Common)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Common)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Common)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ToolStripButton6,
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
            this.toolStripButton1.ToolTipText = "保存功能列表";
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
            this.ToolStripButton6.ToolTipText = "保存功能列表";
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
            this.ToolStripButton4.ToolTipText = "删除菜单";
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
            // dgv_Common
            // 
            this.dgv_Common.AllowUserToAddRows = false;
            this.dgv_Common.AllowUserToDeleteRows = false;
            this.dgv_Common.AllowUserToOrderColumns = true;
            this.dgv_Common.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_Common.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_Common.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Common.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Common.GridColor = System.Drawing.Color.Green;
            this.dgv_Common.HRAllowColumnSort = true;
            this.dgv_Common.HRFormID = 0;
            this.dgv_Common.Location = new System.Drawing.Point(544, 315);
            this.dgv_Common.Name = "dgv_Common";
            this.dgv_Common.RowTemplate.Height = 23;
            this.dgv_Common.Size = new System.Drawing.Size(219, 256);
            this.dgv_Common.TabIndex = 6;
            this.dgv_Common.Tag = "Bas_PartType";
            this.dgv_Common.VirtualMode = true;
            this.dgv_Common.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_Common_DefaultValuesNeeded);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gc_Common
            // 
            this.gc_Common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Common.EmbeddedNavigator.Name = "";
            this.gc_Common.Location = new System.Drawing.Point(0, 25);
            this.gc_Common.MainView = this.gv_Common;
            this.gc_Common.Name = "gc_Common";
            this.gc_Common.Size = new System.Drawing.Size(763, 546);
            this.gc_Common.TabIndex = 7;
            this.gc_Common.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Common});
            // 
            // gv_Common
            // 
            this.gv_Common.GridControl = this.gc_Common;
            this.gv_Common.Name = "gv_Common";
            this.gv_Common.OptionsView.ShowGroupPanel = false;
            // 
            // Form_Main_PartType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.gc_Common);
            this.Controls.Add(this.dgv_Common);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_PartType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "产品类型(箱型)";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Common)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Common)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Common)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolTip toolTip1;
        private ZX.Controls.DataGridViewEx.DataGridViewC dgv_Common;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_Common;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Common;

    }
}

