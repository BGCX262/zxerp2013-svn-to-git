namespace ZXSystem.Function.SetServerComputer
{
    partial class Form_Main_SetServerComputer
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
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtComputer = new System.Windows.Forms.TextBox();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
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
            // txtComputer
            // 
            this.txtComputer.Location = new System.Drawing.Point(149, 118);
            this.txtComputer.Name = "txtComputer";
            this.txtComputer.Size = new System.Drawing.Size(214, 21);
            this.txtComputer.TabIndex = 9;
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
            this.ToolStripSeparator1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(421, 25);
            this.ToolStrip1.TabIndex = 15;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.ToolStripButton1.Text = "保存";
            this.ToolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton1.ToolTipText = "保存转数结果";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(374, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "   请录入数据库用名称和数据库密码 。如有疑点，请与数据库服务器管理员联系。";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(66, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 12);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "服务器名称：";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(421, 71);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 256);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 21);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 209);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 21);
            this.txtUserName.TabIndex = 13;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(42, 259);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 12);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "数据库用户密码：";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(54, 212);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 12);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "数据用户名称：";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(149, 166);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(214, 21);
            this.txtDatabase.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "数据库名称：";
            // 
            // Form_Main_SetServerComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 327);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComputer);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main_SetServerComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置数据库服务器";
            this.Load += new System.EventHandler(this.Form_Main_SetServerComputer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_SetServerComputer_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.TextBox txtComputer;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDatabase;
        internal System.Windows.Forms.Label label5;
    }
}

