using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.UserManage
{
    public partial class Form_UserInf : Form
    {
        string strUserID = "";
        public Form_UserInf(string UserID)
        {
            strUserID = UserID;
            InitializeComponent();
        }

        private void Form_UserInf_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            //this.CheckTrue.Checked = true;
            if (strUserID != "")//修改
            {
                LoadData();
            }
            else
            {
                GetMaxID();
            }
        }
        /// <summary>
        /// 得到最大的用户编号
        /// </summary>
        /// <returns></returns>
        private void GetMaxID()
        {
            string strSql = "select max(str(sUserID))+1 from SYS_USER_INFO";
            object maxID = ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(strSql);
            this.txtUserID.Text = maxID.ToString().PadLeft(4, '0') ;
        }
        /// <summary>
        /// 读取被修改的用户信息
        /// </summary>
        private void LoadData()
        {
            string strSql;
            strSql = "select * from SYS_USER_INFO where sUserID='" + strUserID + "'";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            if (DT.Rows.Count > 0)
            {
                this.txtUserID.Text = strUserID;
                this.txtUserName.Text = DT.Rows[0]["sUserName"].ToString();
                this.txt_UserNameByChines.Text = DT.Rows[0]["sUserNameByChinese"].ToString();
                ZX.Class.StringOption.Encrypt ET = new ZX.Class.StringOption.Encrypt();
                //this.txtPassWord.Text = ET.DecryptString(DT.Rows[0]["sLoginPassWord"].ToString());
                //this.CheckTrue.Checked = true;
                this.txtDepartment.Text = DT.Rows[0]["sDepartMent"].ToString();
                this.txtRole.Text = DT.Rows[0]["sRole"].ToString();
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
                    this.DialogResult = DialogResult.Cancel;
                    break;
            }
        }
        /// <summary>
        /// 保存用户信息
        /// </summary>
        private void SaveData()
        {
            if (this.txtUserName.Text.Trim() == "" || this.txtDepartment.Text == "")
            {
               SystemClass.MessageBoxShow.ShowMessage("所输入的信息不全，请录入完整的用户信息！");
                return;
            }
            string strSql;
            if (strUserID.Trim() == "")
            {
                strSql = "insert into SYS_USER_INFO(sUserID,sUserName,sUserNameByChinese,sLoginPassWord,sDepartment,sRole) values (@sUserID,@sUserName,@sUserNameByChinese,@sLoginPassWord,@sDepartment,@sRole)";
            }
            else
            {
                strSql = "update SYS_USER_INFO set sUserID=@sUserID,sUserName=@sUserName,sUserNameByChinese=@sUserNameByChinese,sLoginPassword=@sLoginPassWord,sDepartment=@sDepartment,sRole=@sRole where sUserID='" + this.strUserID + "'";
            }
            System.Data.SqlClient.SqlParameter[] sqlParameterList = new System.Data.SqlClient.SqlParameter[6];
            sqlParameterList[0] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[0].ParameterName = "@sUserID";
            sqlParameterList[0].Value = this.txtUserID.Text;
            sqlParameterList[0].SqlDbType = System.Data.SqlDbType.VarChar;

            sqlParameterList[1] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[1].ParameterName = "@sUserName";
            sqlParameterList[1].Value = this.txtUserName.Text;
            sqlParameterList[1].SqlDbType = System.Data.SqlDbType.VarChar;

            sqlParameterList[2] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[2].ParameterName = "@sUserNameByChinese";
            sqlParameterList[2].Value = this.txt_UserNameByChines.Text;
            sqlParameterList[2].SqlDbType = System.Data.SqlDbType.VarChar;


            ZX.Class.StringOption.Encrypt ET = new ZX.Class.StringOption.Encrypt();
            sqlParameterList[3] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[3].ParameterName = "@sLoginPassWord";
            sqlParameterList[3].Value = ET.EncryptString(this.txtUserName.Text);
            sqlParameterList[3].SqlDbType = System.Data.SqlDbType.VarChar;

            sqlParameterList[4] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[4].ParameterName = "@sDepartment";
            sqlParameterList[4].Value = this.txtDepartment.Text;
            sqlParameterList[4].SqlDbType = System.Data.SqlDbType.VarChar;

            sqlParameterList[5] = new System.Data.SqlClient.SqlParameter();
            sqlParameterList[5].ParameterName = "@sRole";
            sqlParameterList[5].Value = this.txtRole.Text;
            sqlParameterList[5].SqlDbType = System.Data.SqlDbType.VarChar;


            if (ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql, sqlParameterList) == 1)
            {
                ZX.Class.Log.WriteLog.Write("ZXSystem.Function.UserManage.Form_UserInfo", "SaveData", "保存用户信息成功", ZX.Class.Log.NormalLogType.InfoLog);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
               SystemClass.MessageBoxShow.ShowMessage("保存用户信息失败！");
            }
        }

        private void CheckTrue_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.CheckTrue.Checked)
            //{
            //    this.txtPassWord.PasswordChar = '\0';
            //}
            //else
            //{
            //    this.txtPassWord.PasswordChar = '*';
            //}

        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {

        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            //不需要翻译
            FP.isGetFieldTitleFromDictionary = false;
            FP.SqlQrystr = "select sValue 部门 from Bas_DataList where sClass='部门设置'";
            Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", FP, null);
            Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;
            if (Dic.ContainsKey("部门"))
            {
                //MessageBox.Show(Dic["功能ID"]);
                this.txtDepartment.Text = Dic["部门"];
            }

           
        }

        private void btn_Role_Click(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            //不需要翻译
            FP.isGetFieldTitleFromDictionary =false;
            FP.SqlQrystr = "select distinct(sRole) 角色 from SYS_USER_INFO";
            Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", FP, null);
            Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;
            if (Dic.ContainsKey("角色"))
            {

                this.txtRole.Text = Dic["角色"];
            }
        }
    }
}
