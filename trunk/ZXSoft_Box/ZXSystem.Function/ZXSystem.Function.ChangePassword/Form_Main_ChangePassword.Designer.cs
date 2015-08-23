namespace ZXSystem.Function.ChangePassword
{
    partial class Form_Main_ChangePassword
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
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.CheckOld = new System.Windows.Forms.CheckBox();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelMSG = new System.Windows.Forms.Label();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSave = new System.Windows.Forms.ToolStripButton();
            this.CheckNew = new System.Windows.Forms.CheckBox();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtOldPassWord = new System.Windows.Forms.TextBox();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // CheckOld
            // 
            this.CheckOld.AutoSize = true;
            this.CheckOld.ForeColor = System.Drawing.Color.Blue;
            this.CheckOld.Location = new System.Drawing.Point(357, 147);
            this.CheckOld.Name = "CheckOld";
            this.CheckOld.Size = new System.Drawing.Size(48, 16);
            this.CheckOld.TabIndex = 28;
            this.CheckOld.Text = "显示";
            this.CheckOld.UseVisualStyleBackColor = true;
            this.CheckOld.CheckedChanged += new System.EventHandler(this.CheckOld_CheckedChanged);
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Location = new System.Drawing.Point(98, 188);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.PasswordChar = '*';
            this.txtNewPassWord.Size = new System.Drawing.Size(251, 21);
            this.txtNewPassWord.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 185);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 27);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "新的密码：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelMSG
            // 
            this.LabelMSG.Location = new System.Drawing.Point(12, 142);
            this.LabelMSG.Name = "LabelMSG";
            this.LabelMSG.Size = new System.Drawing.Size(79, 27);
            this.LabelMSG.TabIndex = 24;
            this.LabelMSG.Text = "原始密码：";
            this.LabelMSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSplitButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(35, 22);
            this.ToolStripSave.Text = "确定";
            this.ToolStripSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolStripSave.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripSave.ToolTipText = "确定输入";
            // 
            // CheckNew
            // 
            this.CheckNew.AutoSize = true;
            this.CheckNew.ForeColor = System.Drawing.Color.Blue;
            this.CheckNew.Location = new System.Drawing.Point(358, 191);
            this.CheckNew.Name = "CheckNew";
            this.CheckNew.Size = new System.Drawing.Size(48, 16);
            this.CheckNew.TabIndex = 29;
            this.CheckNew.Text = "显示";
            this.CheckNew.UseVisualStyleBackColor = true;
            this.CheckNew.CheckedChanged += new System.EventHandler(this.CheckNew_CheckedChanged);
            // 
            // ToolStripSplitButton2
            // 
            this.ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            this.ToolStripSplitButton2.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSplitButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // txtOldPassWord
            // 
            this.txtOldPassWord.Location = new System.Drawing.Point(98, 145);
            this.txtOldPassWord.Name = "txtOldPassWord";
            this.txtOldPassWord.PasswordChar = '*';
            this.txtOldPassWord.Size = new System.Drawing.Size(251, 21);
            this.txtOldPassWord.TabIndex = 22;
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
            // ToolStrip1
            // 
            this.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSave,
            this.ToolStripSplitButton1,
            this.ToolStripButton3,
            this.ToolStripSplitButton2,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(415, 25);
            this.ToolStrip1.TabIndex = 25;
            this.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox1.Location = new System.Drawing.Point(0, 25);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(415, 88);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 26;
            this.PictureBox1.TabStop = false;
            // 
            // Form_Main_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 250);
            this.Controls.Add(this.CheckOld);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelMSG);
            this.Controls.Add(this.CheckNew);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtOldPassWord);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "用户密码修改";
            this.Load += new System.EventHandler(this.Form_Main_ChangePassword_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_ChangePassword_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.CheckBox CheckOld;
        internal System.Windows.Forms.TextBox txtNewPassWord;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabelMSG;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripSave;
        internal System.Windows.Forms.CheckBox CheckNew;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2;
        internal System.Windows.Forms.TextBox txtOldPassWord;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.PictureBox PictureBox1;

    }
}

