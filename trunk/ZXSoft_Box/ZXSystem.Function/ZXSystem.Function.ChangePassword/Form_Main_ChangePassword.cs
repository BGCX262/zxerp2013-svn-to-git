using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.ChangePassword
{
    public partial class Form_Main_ChangePassword : Form
    {
        ZX.Win.FunctionParameter FP;
        public Form_Main_ChangePassword()
        {
            InitializeComponent();
        }

        private void Form_Main_ChangePassword_Load(object sender, EventArgs e)
        {
            //this.PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath + @"\Images\Backgroup\Title.jpg");
            FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            this.txtOldPassWord.Focus();
            this.txtOldPassWord.Select();
        }

        private void CheckOld_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOld.Checked)
            {
                this.txtOldPassWord.PasswordChar ='\0';
            }
            else
            {
                this.txtOldPassWord.PasswordChar ='*';
            }
        }

        private void CheckNew_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNew.Checked)
            {
                this.txtNewPassWord.PasswordChar = '\0';
            }
            else
            {
                this.txtNewPassWord.PasswordChar = '*';
            }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "确定":
                    SaveData();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void Form_Main_ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }
        private void SaveData()
        {
            if (this.txtNewPassWord.Text == txtOldPassWord.Text)
            {
               SystemClass.MessageBoxShow.ShowMessage("新的用户密码不能与原始密码相同！");
                return;
            }
            if (this.txtNewPassWord.Text.Trim() == "")
            {
               SystemClass.MessageBoxShow.ShowMessage("密码设置不能为空！");
                return;
            }
            ZX.Class.StringOption.Encrypt SE=new ZX.Class.StringOption.Encrypt();
            string strNewPassWord=SE.EncryptString(this.txtNewPassWord.Text);
            string strOldPassWord = SE.EncryptString(this.txtOldPassWord.Text);
            string strSql = "select sUserName,sUserNameByChinese,sLoginPassword from SYS_USER_INFO where sUserNameByChinese='" + FP.pub_sUserNameByChinese + "' and sLoginPassword='" + strOldPassWord + "'";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            if (DT.Rows.Count > 0 && DT.Rows[0]["sLoginPassword"].ToString() == strOldPassWord)
            {
                strSql = "update SYS_USER_INFO set sLoginPassword='" + strNewPassWord + "' where sUserNameByChinese='" + FP.pub_sUserNameByChinese + "'";
                if (ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql) == 1)
                {
                    SystemClass.MessageBoxShow.ShowMessage("修改用户密码成功！");
                    this.Close();
                }
                else
                {
                   SystemClass.MessageBoxShow.ShowMessage("修改用户密码失败！");
                }
            }
            else
            {
               SystemClass.MessageBoxShow.ShowMessage("输入原始密码不正确，请重新输入！");
            }
        }
    }
}
