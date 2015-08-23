using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.SetServerComputer
{
    public partial class Form_Main_SetServerComputer : Form
    {
        public Form_Main_SetServerComputer()
        {
            InitializeComponent();
        }
        private void Form_Main_SetServerComputer_Load(object sender, EventArgs e)
        {
            LoadData();
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            this.txtComputer.Focus();
            this.txtComputer.Select();

        }
        private void LoadData()
        {
            this.txtDatabase.Text = SystemClass.ConnectString.GetDatabase();
            this.txtComputer.Text = SystemClass.ConnectString.GetComputerName();
            this.txtPassword.Text = SystemClass.ConnectString.GetPassWord();
            this.txtUserName.Text = SystemClass.ConnectString.GetUserName();

        }
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "保存":
                    SaveSet();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Tag = null;
                    this.Close();
                    break;
            }
        }
        private void SaveSet()
        {
            if (this.txtComputer.Text.Trim() == "")
            {
               SystemClass.MessageBoxShow.ShowMessage("数据库服务器不能为空！");
                return;
            }
            if (this.txtUserName.Text.Trim() == "")
            {
               SystemClass.MessageBoxShow.ShowMessage("数据库服务器用户名不能为空！");
                return;
            }
            if (SystemClass.ConnectString.SetConnectionString(this.txtDatabase.Text, this.txtComputer.Text, this.txtUserName.Text, this.txtPassword.Text) == true)
            {
                ZX.Class.Log.WriteLog.Write("ZXSystem.Function.SetServerComputer", "SaveSet", "保存数据库服务器设置成功", ZX.Class.Log.NormalLogType.InfoLog);
                this.Close();
            }
            else
            {
                ZX.Class.Log.WriteLog.Write("ZXSystem.Function.SetServerComputer", "SaveSet", "保存数据库服务器设置失败", ZX.Class.Log.NormalLogType.InfoLog);
               SystemClass.MessageBoxShow.ShowMessage("保存数据库服务器设置失败！");
            }
        }

        private void Form_Main_SetServerComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }
     
    }
}
