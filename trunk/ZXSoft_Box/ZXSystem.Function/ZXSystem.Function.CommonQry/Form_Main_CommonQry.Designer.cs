namespace ZXSystem.Function.CommonQry
{
    partial class Form_Main_CommonQry
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
            this.dgv_CommonQry_Old = new ZX.Controls.DataGridViewEx.DataGridViewC();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbb_QryValue = new System.Windows.Forms.ToolStripComboBox();
            
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_QryValue = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gc_CommonQry = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_CommonQry = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonQry_Old)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CommonQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CommonQry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CommonQry_Old
            // 
            this.dgv_CommonQry_Old.AllowUserToAddRows = false;
            this.dgv_CommonQry_Old.AllowUserToDeleteRows = false;
            this.dgv_CommonQry_Old.AllowUserToOrderColumns = true;
            this.dgv_CommonQry_Old.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_CommonQry_Old.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_CommonQry_Old.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CommonQry_Old.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_CommonQry_Old.GridColor = System.Drawing.Color.Green;
            this.dgv_CommonQry_Old.HRAllowColumnSort = true;
            this.dgv_CommonQry_Old.HRFormID = 0;
            this.dgv_CommonQry_Old.Location = new System.Drawing.Point(47, 130);
            this.dgv_CommonQry_Old.Name = "dgv_CommonQry_Old";
            this.dgv_CommonQry_Old.RowTemplate.Height = 23;
            this.dgv_CommonQry_Old.Size = new System.Drawing.Size(139, 112);
            this.dgv_CommonQry_Old.TabIndex = 6;
            this.dgv_CommonQry_Old.VirtualMode = true;
            this.dgv_CommonQry_Old.DoubleClick += new System.EventHandler(this.dgv_CommonQry_DoubleClick);
            this.dgv_CommonQry_Old.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CommonQry_CellContentClick);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cbb_QryValue,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tb_QryValue,
            this.toolStripButton1,
            this.ToolStripButton3,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(830, 25);
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "条件";
            this.toolStripLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // cbb_QryValue
            // 
            this.cbb_QryValue.Name = "cbb_QryValue";
            this.cbb_QryValue.Size = new System.Drawing.Size(121, 25);
            this.cbb_QryValue.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "值";
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tb_QryValue
            // 
            this.tb_QryValue.Name = "tb_QryValue";
            this.tb_QryValue.Size = new System.Drawing.Size(100, 25);
            this.tb_QryValue.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "查询";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "修改功能设置";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // gc_CommonQry
            // 
            this.gc_CommonQry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CommonQry.EmbeddedNavigator.Name = "";
            this.gc_CommonQry.Location = new System.Drawing.Point(0, 25);
            this.gc_CommonQry.MainView = this.gv_CommonQry;
            this.gc_CommonQry.Name = "gc_CommonQry";
            this.gc_CommonQry.Size = new System.Drawing.Size(830, 490);
            this.gc_CommonQry.TabIndex = 9;
            this.gc_CommonQry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CommonQry});
            this.gc_CommonQry.DoubleClick += new System.EventHandler(this.gc_CommonQry_DoubleClick);
            // 
            // gv_CommonQry
            // 
            this.gv_CommonQry.GridControl = this.gc_CommonQry;
            this.gv_CommonQry.Name = "gv_CommonQry";
            this.gv_CommonQry.OptionsView.ShowGroupPanel = false;
            // 
            // Form_Main_CommonQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 515);
            this.Controls.Add(this.gc_CommonQry);
            this.Controls.Add(this.dgv_CommonQry_Old);
            this.Controls.Add(this.ToolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form_Main_CommonQry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通用查询";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_CommonQry_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonQry_Old)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CommonQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CommonQry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZX.Controls.DataGridViewEx.DataGridViewC dgv_CommonQry_Old;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cbb_QryValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tb_QryValue;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_CommonQry;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CommonQry;

    }
}

