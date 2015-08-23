namespace ZXSystem.Function.MenuManage
{
    partial class Form_Main_MenuManage
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
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsSortBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenuGroupID = new System.Windows.Forms.TextBox();
            this.txtFunID = new System.Windows.Forms.TextBox();
            this.txtFunName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gc_CommonQry = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_CommonQry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CommonQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CommonQry)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
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
            // toolStripButton5
            // 
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton5.Text = "保存";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.ToolTipText = "保存功能列表";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "修改";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "修改功能列表";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能信息：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.54954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.29855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtsSortBy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMenuGroupID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFunID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFunName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 121);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "功能名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDll
            // 
            this.btnDll.FlatAppearance.BorderSize = 0;
            this.btnDll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDll.Location = new System.Drawing.Point(721, 33);
            this.btnDll.Name = "btnDll";
            this.btnDll.Size = new System.Drawing.Size(33, 21);
            this.btnDll.TabIndex = 4;
            this.btnDll.Text = "...";
            this.btnDll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnDll, "浏览打开文件");
            this.btnDll.UseVisualStyleBackColor = true;
            this.btnDll.Click += new System.EventHandler(this.btnDll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "菜单分组：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsSortBy
            // 
            this.txtsSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsSortBy.Location = new System.Drawing.Point(98, 93);
            this.txtsSortBy.Name = "txtsSortBy";
            this.txtsSortBy.Size = new System.Drawing.Size(617, 21);
            this.txtsSortBy.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "功能菜单排序：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMenuGroupID
            // 
            this.txtMenuGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuGroupID.Location = new System.Drawing.Point(98, 63);
            this.txtMenuGroupID.Name = "txtMenuGroupID";
            this.txtMenuGroupID.Size = new System.Drawing.Size(617, 21);
            this.txtMenuGroupID.TabIndex = 6;
            // 
            // txtFunID
            // 
            this.txtFunID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFunID.Location = new System.Drawing.Point(98, 3);
            this.txtFunID.Name = "txtFunID";
            this.txtFunID.ReadOnly = true;
            this.txtFunID.Size = new System.Drawing.Size(617, 21);
            this.txtFunID.TabIndex = 1;
            // 
            // txtFunName
            // 
            this.txtFunName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFunName.Location = new System.Drawing.Point(98, 33);
            this.txtFunName.Name = "txtFunName";
            this.txtFunName.ReadOnly = true;
            this.txtFunName.Size = new System.Drawing.Size(617, 21);
            this.txtFunName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能ID：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 16);
            this.panel1.TabIndex = 8;
            // 
            // gc_CommonQry
            // 
            this.gc_CommonQry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CommonQry.EmbeddedNavigator.Name = "";
            this.gc_CommonQry.Location = new System.Drawing.Point(0, 182);
            this.gc_CommonQry.MainView = this.gv_CommonQry;
            this.gc_CommonQry.Name = "gc_CommonQry";
            this.gc_CommonQry.Size = new System.Drawing.Size(763, 389);
            this.gc_CommonQry.TabIndex = 11;
            this.gc_CommonQry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CommonQry});
            // 
            // gv_CommonQry
            // 
            this.gv_CommonQry.GridControl = this.gc_CommonQry;
            this.gv_CommonQry.Name = "gv_CommonQry";
            this.gv_CommonQry.OptionsView.ShowAutoFilterRow = true;
            this.gv_CommonQry.OptionsView.ShowGroupPanel = false;
            this.gv_CommonQry.DoubleClick += new System.EventHandler(this.gv_CommonQry_DoubleClick);
            // 
            // Form_Main_MenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.gc_CommonQry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_MenuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "系统菜单维护";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_MenuManage_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CommonQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CommonQry)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsSortBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMenuGroupID;
        private System.Windows.Forms.TextBox txtFunID;
        private System.Windows.Forms.TextBox txtFunName;
        private System.Windows.Forms.ToolTip toolTip1;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_CommonQry;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CommonQry;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;

    }
}

