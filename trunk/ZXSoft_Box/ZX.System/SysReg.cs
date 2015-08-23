using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ZX.ZXSystem
{
    public partial class SysReg : Form
    {
       
        public SysReg(string[] args)
        {
            
            
            InitializeComponent();
        }


        public SysReg()
        {
            InitializeComponent();
        }

        //登录系统
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void labelMsg_Click(object sender, EventArgs e)
        {
           
        }
        //退出程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }



        

        private void SysReg_Shown(object sender, EventArgs e)
        {
            string Com = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='Com'");
            string Reg = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='reg'");
            string Mac = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle("select sconfvalue from SYS_Conf where sconf='Mac'");
            this.TxtCom.Text = Com;
            this.TxtMac.Text = Mac;
            this.TxtReg.Text = Reg;

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("update SYS_Conf set sconfvalue='" + TxtCom.Text + "' where sconf='Com'");
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("update SYS_Conf set sconfvalue='" + TxtReg.Text + "' where sconf='Reg'");
            this.Close();
        }

      


    }
}