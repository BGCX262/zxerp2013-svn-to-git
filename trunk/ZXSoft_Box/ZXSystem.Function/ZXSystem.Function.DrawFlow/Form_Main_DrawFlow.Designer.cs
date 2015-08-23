namespace ZXSystem.Function.DrawFlow
{
    partial class Form_Main_DrawFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_DrawFlow));
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip_set = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除控件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaintoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.zxPanel1 = new ZX.Controls.DotNetMagic.Controls.ZXPanel();
            this.ToolStrip1.SuspendLayout();
            this.contextMenuStrip_set.SuspendLayout();
            this.MaintoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton3.Text = "帮助";
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
            this.ToolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton2.ToolTipText = "关闭窗口";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.toolStripButton4,
            this.ToolStripSeparator1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(698, 25);
            this.ToolStrip1.TabIndex = 15;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton1.Text = "打开";
            this.ToolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton1.ToolTipText = "打开流程图";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton4.Text = "保存";
            this.toolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.ToolTipText = "保存流程图";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // contextMenuStrip_set
            // 
            this.contextMenuStrip_set.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置图片ToolStripMenuItem,
            this.设置窗体ToolStripMenuItem,
            this.删除控件ToolStripMenuItem,
            this.设置名称ToolStripMenuItem});
            this.contextMenuStrip_set.Name = "contextMenuStrip_set";
            this.contextMenuStrip_set.Size = new System.Drawing.Size(153, 114);
            this.contextMenuStrip_set.Paint += new System.Windows.Forms.PaintEventHandler(this.contextMenuStrip_set_Paint);
            // 
            // 设置窗体ToolStripMenuItem
            // 
            this.设置窗体ToolStripMenuItem.Name = "设置窗体ToolStripMenuItem";
            this.设置窗体ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置窗体ToolStripMenuItem.Text = "设置窗体";
            this.设置窗体ToolStripMenuItem.Click += new System.EventHandler(this.设置窗体ToolStripMenuItem_Click);
            // 
            // 设置图片ToolStripMenuItem
            // 
            this.设置图片ToolStripMenuItem.Name = "设置图片ToolStripMenuItem";
            this.设置图片ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置图片ToolStripMenuItem.Text = "设置图片";
            this.设置图片ToolStripMenuItem.Click += new System.EventHandler(this.设置图片ToolStripMenuItem_Click);
            // 
            // 删除控件ToolStripMenuItem
            // 
            this.删除控件ToolStripMenuItem.Name = "删除控件ToolStripMenuItem";
            this.删除控件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除控件ToolStripMenuItem.Text = "删除控件";
            this.删除控件ToolStripMenuItem.Click += new System.EventHandler(this.删除控件ToolStripMenuItem_Click);
            // 
            // 设置名称ToolStripMenuItem
            // 
            this.设置名称ToolStripMenuItem.Name = "设置名称ToolStripMenuItem";
            this.设置名称ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置名称ToolStripMenuItem.Text = "设置名称";
            this.设置名称ToolStripMenuItem.Click += new System.EventHandler(this.设置名称ToolStripMenuItem_Click_1);
            // 
            // MaintoolStrip
            // 
            this.MaintoolStrip.AllowDrop = true;
            this.MaintoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImg,
            this.toolStripButton5});
            this.MaintoolStrip.Location = new System.Drawing.Point(0, 25);
            this.MaintoolStrip.Name = "MaintoolStrip";
            this.MaintoolStrip.Size = new System.Drawing.Size(698, 25);
            this.MaintoolStrip.TabIndex = 63;
            this.MaintoolStrip.Text = "toolStrip2";
            this.MaintoolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MaintoolStrip_ItemClicked);
            // 
            // toolStripButtonImg
            // 
            this.toolStripButtonImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImg.Image")));
            this.toolStripButtonImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImg.Name = "toolStripButtonImg";
            this.toolStripButtonImg.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonImg.Text = "绘制流程图";
            this.toolStripButtonImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton7_MouseDown);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "绘制流程图";
            this.toolStripButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton5_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mpf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mpf|*.mpf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "mpf";
            this.saveFileDialog1.Filter = "mpf|*.mpf";
            // 
            // zxPanel1
            // 
            this.zxPanel1.AllowDrop = true;
            this.zxPanel1.ContextMenuStrip = this.contextMenuStrip_set;
            this.zxPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zxPanel1.DrawingLink = false;
            this.zxPanel1.GridColor = System.Drawing.Color.Yellow;
            this.zxPanel1.GridSpace = 10;
            this.zxPanel1.Location = new System.Drawing.Point(0, 50);
            this.zxPanel1.Name = "zxPanel1";
            this.zxPanel1.PaintItems = ((System.Collections.Generic.List<ZX.Controls.DotNetMagic.Controls.IPaintItem>)(resources.GetObject("zxPanel1.PaintItems")));
            this.zxPanel1.ShowGrid = true;
            this.zxPanel1.Size = new System.Drawing.Size(698, 396);
            this.zxPanel1.TabIndex = 16;
            this.zxPanel1.Text = "zxPanel1";
            this.zxPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zxPanel1_MouseDoubleClick);
            this.zxPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.zxPanel1_DragDrop);
            this.zxPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zxPanel1_MouseUp);
            this.zxPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.zxPanel1_DragEnter);
            // 
            // Form_Main_DrawFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 446);
            this.Controls.Add(this.zxPanel1);
            this.Controls.Add(this.MaintoolStrip);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form_Main_DrawFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "流程设置";
            this.Load += new System.EventHandler(this.Form_Main_SetServerComputer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_SetServerComputer_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.contextMenuStrip_set.ResumeLayout(false);
            this.MaintoolStrip.ResumeLayout(false);
            this.MaintoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private ZX.Controls.DotNetMagic.Controls.ZXPanel zxPanel1;
        private System.Windows.Forms.ToolStrip MaintoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_set;
        private System.Windows.Forms.ToolStripMenuItem 设置窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除控件ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 设置名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

