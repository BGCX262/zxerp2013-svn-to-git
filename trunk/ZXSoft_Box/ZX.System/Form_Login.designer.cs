namespace ZX.ZXSystem
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.ButtCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtCancel
            // 
            this.ButtCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ButtCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtCancel.Location = new System.Drawing.Point(189, 200);
            this.ButtCancel.Name = "ButtCancel";
            this.ButtCancel.Size = new System.Drawing.Size(87, 28);
            this.ButtCancel.TabIndex = 21;
            this.ButtCancel.Text = "取消(&C)";
            this.ButtCancel.UseVisualStyleBackColor = false;
            this.ButtCancel.Click += new System.EventHandler(this.ButtCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Location = new System.Drawing.Point(30, 200);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(87, 28);
            this.ButtonOK.TabIndex = 20;
            this.ButtonOK.Text = "登录(&L)";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.TxtPassword);
            this.MainPanel.Controls.Add(this.TxtUserName);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Location = new System.Drawing.Point(12, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(273, 100);
            this.MainPanel.TabIndex = 22;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPassword.Location = new System.Drawing.Point(99, 63);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(152, 23);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.Text = "admin";
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPassWord_KeyDown);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtUserName.Location = new System.Drawing.Point(99, 21);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(152, 23);
            this.TxtUserName.TabIndex = 3;
            this.TxtUserName.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "密 码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "用 户：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.labelTitle.Text = "  置祥软件";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMsg
            // 
            this.labelMsg.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.labelMsg.Location = new System.Drawing.Point(1, 53);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(294, 24);
            this.labelMsg.TabIndex = 24;
            this.labelMsg.Text = "欢迎使用置祥软件";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Controls.Add(this.labelTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(308, 50);
            this.TopPanel.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 240);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

