namespace ZX.ZXSystem
{
    partial class SysReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysReg));
            this.TxtMac = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMac
            // 
            this.TxtMac.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMac.Location = new System.Drawing.Point(91, 46);
            this.TxtMac.Name = "TxtMac";
            this.TxtMac.ReadOnly = true;
            this.TxtMac.Size = new System.Drawing.Size(180, 23);
            this.TxtMac.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(207, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.TxtReg);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TxtMac);
            this.MainPanel.Controls.Add(this.TxtCom);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(12, 56);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(283, 131);
            this.MainPanel.TabIndex = 17;
            // 
            // TxtReg
            // 
            this.TxtReg.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReg.Location = new System.Drawing.Point(91, 75);
            this.TxtReg.Name = "TxtReg";
            this.TxtReg.Size = new System.Drawing.Size(180, 23);
            this.TxtReg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "序列号";
            // 
            // TxtCom
            // 
            this.TxtCom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCom.Location = new System.Drawing.Point(91, 17);
            this.TxtCom.Name = "TxtCom";
            this.TxtCom.Size = new System.Drawing.Size(180, 23);
            this.TxtCom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "注册机器码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Location = new System.Drawing.Point(101, 202);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(87, 28);
            this.btnReg.TabIndex = 15;
            this.btnReg.Text = "注册";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(255, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "  软件注册";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Controls.Add(this.labelTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(308, 50);
            this.TopPanel.TabIndex = 16;
            // 
            // SysReg
            // 
            this.AcceptButton = this.btnReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(308, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统注册";
            this.Shown += new System.EventHandler(this.SysReg_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMac;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox TxtReg;
        private System.Windows.Forms.Label label3;
    }
}