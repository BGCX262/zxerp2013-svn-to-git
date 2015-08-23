namespace ZXSystem.Function.FunManage
{
    partial class Form_Main_FunManage
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
            this.ToolStripSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHelpPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.btnDll = new System.Windows.Forms.Button();
            this.txtFunDll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFunID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gc_Common = new ZX.Controls.DataGridViewEx.GridControlEx();
            this.gv_Common = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Common)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Common)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSave,
            this.ToolStripSplitButton1,
            this.ToolStripButton5,
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
            // ToolStripSave
            // 
            this.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(35, 22);
            this.ToolStripSave.Text = "添加";
            this.ToolStripSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripSave.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripSave.ToolTipText = "增加";
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSplitButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
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
            this.ToolStripButton5.ToolTipText = "修改功能设置";
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
            this.groupBox1.Size = new System.Drawing.Size(763, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能信息：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnHelp, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtHelpPath, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtIcon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnIcon, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNameSpace, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDll, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFunDll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFunName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFunID, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 200);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Location = new System.Drawing.Point(721, 168);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 21);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "...";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnHelp, "浏览打开文件");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "功能帮助路径：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHelpPath
            // 
            this.txtHelpPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHelpPath.Location = new System.Drawing.Point(116, 168);
            this.txtHelpPath.Name = "txtHelpPath";
            this.txtHelpPath.ReadOnly = true;
            this.txtHelpPath.Size = new System.Drawing.Size(599, 21);
            this.txtHelpPath.TabIndex = 11;
            this.txtHelpPath.TextChanged += new System.EventHandler(this.txtHelpPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "功能菜单图标：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIcon
            // 
            this.txtIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIcon.Location = new System.Drawing.Point(116, 135);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = true;
            this.txtIcon.Size = new System.Drawing.Size(599, 21);
            this.txtIcon.TabIndex = 8;
            // 
            // btnIcon
            // 
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIcon.Location = new System.Drawing.Point(721, 135);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(33, 21);
            this.btnIcon.TabIndex = 9;
            this.btnIcon.Text = "...";
            this.btnIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnIcon, "浏览打开文件");
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "程序集命名空间：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameSpace.Location = new System.Drawing.Point(116, 102);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(599, 21);
            this.txtNameSpace.TabIndex = 6;
            // 
            // btnDll
            // 
            this.btnDll.FlatAppearance.BorderSize = 0;
            this.btnDll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDll.Location = new System.Drawing.Point(721, 69);
            this.btnDll.Name = "btnDll";
            this.btnDll.Size = new System.Drawing.Size(33, 21);
            this.btnDll.TabIndex = 4;
            this.btnDll.Text = "...";
            this.btnDll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnDll, "浏览打开文件");
            this.btnDll.UseVisualStyleBackColor = true;
            this.btnDll.Click += new System.EventHandler(this.btnDll_Click);
            // 
            // txtFunDll
            // 
            this.txtFunDll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFunDll.Location = new System.Drawing.Point(116, 69);
            this.txtFunDll.Name = "txtFunDll";
            this.txtFunDll.Size = new System.Drawing.Size(599, 21);
            this.txtFunDll.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "功能对应程序集：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能菜单名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFunName
            // 
            this.txtFunName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFunName.Location = new System.Drawing.Point(116, 36);
            this.txtFunName.Name = "txtFunName";
            this.txtFunName.Size = new System.Drawing.Size(599, 21);
            this.txtFunName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "功能菜单ID：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFunID
            // 
            this.txtFunID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFunID.Location = new System.Drawing.Point(116, 3);
            this.txtFunID.Name = "txtFunID";
            this.txtFunID.Size = new System.Drawing.Size(599, 21);
            this.txtFunID.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 16);
            this.panel1.TabIndex = 8;
            // 
            // gc_Common
            // 
            this.gc_Common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Common.EmbeddedNavigator.Name = "";
            this.gc_Common.Location = new System.Drawing.Point(0, 261);
            this.gc_Common.MainView = this.gv_Common;
            this.gc_Common.Name = "gc_Common";
            this.gc_Common.Size = new System.Drawing.Size(763, 310);
            this.gc_Common.TabIndex = 9;
            this.gc_Common.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Common});
            this.gc_Common.DoubleClick += new System.EventHandler(this.gc_Common_DoubleClick);
            // 
            // gv_Common
            // 
            this.gv_Common.GridControl = this.gc_Common;
            this.gv_Common.Name = "gv_Common";
            this.gv_Common.OptionsView.ShowGroupPanel = false;
            // 
            // Form_Main_FunManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.gc_Common);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_FunManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "系统功能维护";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FunManage_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Common)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Common)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripSave;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.TextBox txtHelpPath;
        private System.Windows.Forms.Button btnDll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.TextBox txtFunName;
        private System.Windows.Forms.TextBox txtFunDll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFunID;
        private ZX.Controls.DataGridViewEx.GridControlEx gc_Common;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Common;

    }
}

