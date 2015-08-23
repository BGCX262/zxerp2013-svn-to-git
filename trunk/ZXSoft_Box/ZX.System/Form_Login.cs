using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZX.ZXSystem
{
    public partial class Form_Login : Form
    {
        string Pub_Image = Application.StartupPath + @"\Images\Backgroup\";
        ZX.Win.FunctionParameter FP;
        bool IsTrue;
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        public Form_Login(string[] args)
        {
                   
            InitializeComponent();
            this.TxtUserName.Text = args[0];
            this.TxtPassword.Text = args[1];
            timer1.Enabled = true;
        }

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(235, 241, 254);
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(77, 103, 162);
            this.labelMsg.ForeColor = System.Drawing.Color.FromArgb(47, 113, 156);
            this.TxtUserName.Focus();
            this.TxtUserName.Select();
            //处理登陆时加载系统外图片
            //try
            //{
            //    this.BackgroundImage = System.Drawing.Image.FromFile(Pub_Image + "登录界面背景图.JPG");
            //    this.PictureCrile1.Image = System.Drawing.Image.FromFile(Pub_Image + "圈.JPG");
            //    this.PictureLogo.Image = System.Drawing.Image.FromFile(Pub_Image + "Logo.JPG");
            //    this.ButtonOK1.Image = System.Drawing.Image.FromFile(Pub_Image + "登录.JPG");
            //    this.ButtCancel1.Image = System.Drawing.Image.FromFile(Pub_Image + "关闭.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "Form_Login_Load", "系统登录功能图片", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }
        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    this.BackgroundImage = System.Drawing.Image.FromFile(Pub_Image + "登录界面背景图.JPG");
            //    this.PictureCrile1.Image = System.Drawing.Image.FromFile(Pub_Image + "圈.JPG");
            //    this.PictureLogo.Image = System.Drawing.Image.FromFile(Pub_Image + "Logo.JPG");
            //    this.ButtonOK1.Image = System.Drawing.Image.FromFile(Pub_Image + "登录.JPG");
            //    this.ButtCancel1.Image = System.Drawing.Image.FromFile(Pub_Image + "关闭.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "Form_Login_Load", "系统登录功能图片", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }

        private void PictureLogo_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    this.PictureLogo.Image = System.Drawing.Image.FromFile(Pub_Image + "Logomove.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "PictureLogo_MouseMove", "系统登录功能图片Logomove.JPG", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }

        private void ButtonOK_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    this.ButtonOK1.Image = System.Drawing.Image.FromFile(Pub_Image + "登录move.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "ButtonOK_MouseMove", "系统登录功能图片 登录move.JPG", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }

        private void ButtCancel_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    this.ButtCancel1.Image = System.Drawing.Image.FromFile(Pub_Image + "关闭move.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "ButtCancel_MouseMove", "系统登录功能图片 关闭move.JPG", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }

        private void PictureCrile_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    this.PictureCrile1.Image = System.Drawing.Image.FromFile(Pub_Image + "圈move.JPG");
            //}
            //catch
            //{
            //    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "PictureCrile_MouseMove", "系统登录功能图片 圈move.JPG", ZX.Class.Log.NormalLogType.WarnLog);
            //}
        }
        private void PictureCrile_Click(object sender, EventArgs e)
        {
           // SystemClass.MessageBoxShow.ShowMessage("此系统为 置祥信息科技有限公司 开发：版权所有－翻版必究！]");
        }

        private void PictureLogo_Click(object sender, EventArgs e)
        {
           // SystemClass.MessageBoxShow.ShowMessage("此系统为 置祥信息科技有限公司 开发：版权所有－翻版必究！]");
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
           
            //程序启动时，将数据联结串设置好  
            ZX.ZXSystem.DBUtility.DbHelperSQL.connectionString = SystemClass.ConnectString.GetConnectionString();
            
            string strUserName = this.TxtUserName.Text;
            string strPassWord = this.TxtPassword.Text;
            ZX.Class.StringOption.Encrypt ET = new ZX.Class.StringOption.Encrypt();
            strPassWord = ET.EncryptString(strPassWord);
            if (GenCode.CheckSN() == false)
            {
                return;
            }
            string strSql = "select sUSERID,sUserName,sUserNameByChinese,sLoginPassword,sRole,sDepartMent,sEMail,sMemo from SYS_USER_INFO  where sUserName='" + strUserName + "' and sLoginPassword='" + strPassWord + "'";
           // MessageBox.Show(strSql);

            try
            {
                DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
                if (DT.Rows.Count != 0 && DT.Rows[0]["sLoginPassword"].ToString() == strPassWord && DT.Rows[0]["sUserName"].ToString() == strUserName)
                {
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "ButtonOK_Click", "用户登录成功：" + strUserName, ZX.Class.Log.NormalLogType.InfoLog);
                   
                    FP = new ZX.Win.FunctionParameter();
                    FP.functionFormID = "-1";
                    FP.toolStripItemDisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

                    FP.pub_CnnDest = SystemClass.ConnectString.GetConnectionString();
                    FP.pub_ComputerName = SystemClass.ConnectString.GetComputerName();
                    FP.pub_DbPassWord = SystemClass.ConnectString.GetPassWord();
                    FP.pub_DBUsername = SystemClass.ConnectString.GetUserName();
                    FP.pub_DbName = SystemClass.ConnectString.GetDatabase();
                    FP.pub_sUserName = DT.Rows[0]["sUserName"].ToString();
                   //用户类型
                    FP.pub_YHLX = DT.Rows[0]["sDepartMent"].ToString();
                    FP.pub_sUserNameByChinese = DT.Rows[0]["sUserNameByChinese"].ToString();
                    FP.Pub_sRole = DT.Rows[0]["sRole"].ToString();
                    //FP.pub_SJDWBH = DT.Rows[0]["SJDWBH"].ToString();

                    this.Tag = FP;
                    IsTrue = true;
                    this.Close();
                }
                else
                {
                    SystemClass.MessageBoxShow.ShowMessage("输入的用户名与密码不正确，请确认后重试！");
                    ZX.Class.Log.WriteLog.Write("ZXSystem.Form_Login", "ButtonOK_Click", "输入的用户名与密码不正确，请确认后重试", ZX.Class.Log.NormalLogType.InfoLog);
                }
            }
            catch
            {
                FP = new ZX.Win.FunctionParameter();
                FP.ToolStripitemDisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                FP.functionFormID = "-1";
                ZX.Win.ReflectionFunction RF = new ZX.Win.ReflectionFunction();
                RF.LoadMdiForm("ZXSystem.Function.SetServerComputer.dll", "ZXSystem.Function.SetServerComputer.Form_Main_SetServerComputer",null, FP);
                GC.Collect();
            }

        }
     
        private void ButtCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsTrue == false)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // MessageBox.Show("", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonOK_Click(sender, e);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ButtonOK_Click(null, null);
            timer1.Enabled = false;
        }

        /// <summary>
        /// 注册界面显示(Ctrl+F2)
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            //
            if (keyData == (Keys.Control | Keys.F2))
            {
                ZX.ZXSystem.DBUtility.DbHelperSQL.connectionString = SystemClass.ConnectString.GetConnectionString();
                SysReg fm = new SysReg();
                fm.ShowDialog();

            }
            return base.ProcessCmdKey(ref   msg, keyData);
        }
    }
}
