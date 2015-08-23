namespace ZXSystem.Function.UserManage
{
    partial class Form_Main_UserManage
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
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dgv_Usermanage = new ZX.Controls.DataGridViewEx.DataGridViewC();
            this.gc_UserManage = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_UserManage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usermanage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserManage)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton6,
            this.ToolStripButton5,
            this.ToolStripButton4,
            this.ToolStripSeparator1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(628, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton6.Text = "添加";
            this.ToolStripButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton6.ToolTipText = "添加用户";
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton5.Text = "修改";
            this.ToolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripButton5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton5.ToolTipText = "修改用户信息";
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
            this.ToolStripButton4.ToolTipText = "删除选定用户";
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
            // dgv_Usermanage
            // 
            this.dgv_Usermanage.AllowUserToAddRows = false;
            this.dgv_Usermanage.AllowUserToDeleteRows = false;
            this.dgv_Usermanage.AllowUserToOrderColumns = true;
            this.dgv_Usermanage.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_Usermanage.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_Usermanage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Usermanage.GridColor = System.Drawing.Color.Green;
            this.dgv_Usermanage.HRAllowColumnSort = true;
            this.dgv_Usermanage.HRFormID = 0;
            this.dgv_Usermanage.Location = new System.Drawing.Point(419, 258);
            this.dgv_Usermanage.Name = "dgv_Usermanage";
            this.dgv_Usermanage.RowTemplate.Height = 23;
            this.dgv_Usermanage.Size = new System.Drawing.Size(209, 177);
            this.dgv_Usermanage.TabIndex = 0;
            this.dgv_Usermanage.Tag = "SYS_USER_INFO";
            this.dgv_Usermanage.VirtualMode = true;
            this.dgv_Usermanage.Visible = false;
            // 
            // gc_UserManage
            // 
            this.gc_UserManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_UserManage.EmbeddedNavigator.Name = "";
            this.gc_UserManage.Location = new System.Drawing.Point(0, 25);
            this.gc_UserManage.MainView = this.gv_UserManage;
            this.gc_UserManage.Name = "gc_UserManage";
            this.gc_UserManage.Size = new System.Drawing.Size(628, 410);
            this.gc_UserManage.TabIndex = 7;
            this.gc_UserManage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UserManage});
            // 
            // gv_UserManage
            // 
            this.gv_UserManage.GridControl = this.gc_UserManage;
            this.gv_UserManage.Name = "gv_UserManage";
            this.gv_UserManage.OptionsView.ShowGroupPanel = false;
            // 
            // Form_Main_UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 435);
            this.Controls.Add(this.gc_UserManage);
            this.Controls.Add(this.dgv_Usermanage);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_UserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.Form_Main_UserManage_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_UserManage_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usermanage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZX.Controls.DataGridViewEx.DataGridViewC dgv_Usermanage;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_UserManage;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UserManage;
    }
}

