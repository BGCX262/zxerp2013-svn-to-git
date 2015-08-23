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
    public partial class Form_Main_UserManage : Form
    {
        ZX.Win.FunctionParameter FP;
        public Form_Main_UserManage()
        {
            InitializeComponent();
        }

        private void Form_Main_UserManage_Load(object sender, EventArgs e)
        {
            
            FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            this.gc_UserManage.Tag = "SYS_USER_INFO";
            LoadData();
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_UserManage);
        }
        /// <summary>
        /// 读取现有用户列表
        /// </summary>
        private void LoadData()
        {
            string strSql;
            strSql = "select * from SYS_USER_INFO";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            ZX.Class.StringOption.Encrypt ET = new ZX.Class.StringOption.Encrypt();
          
            
           // this.dgv_Usermanage.DataSource = DT;
            gc_UserManage.DataSource = DT;
            
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "添加":
                    AddUser();
                    break;
                case "修改":
                    AlterUser();
                    break;
                case "删除":
                    DeleteUser();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        private void AddUser()
        {
            Form FrmUserInf = new Form_UserInf("");
            FrmUserInf.Tag = this.Tag;
            FrmUserInf.ShowDialog();
            if (FrmUserInf.DialogResult == DialogResult.OK)
            {
                LoadData();
            }
            this.dgv_Usermanage.CurrentCell = null;
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        private void AlterUser()
        {
            if (this.gv_UserManage.RowCount == 0 )
            {
                return;
            }
            //string strUserID = this.dgv_Usermanage.Rows[this.dgv_Usermanage.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string strUserID = gv_UserManage.GetFocusedRowCellValue("sUserID").ToString();
            Form FrmUserInf = new Form_UserInf(strUserID);
            FrmUserInf.Tag = this.Tag;
            FrmUserInf.ShowDialog();
            if (FrmUserInf.DialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        private void DeleteUser()
        {
            if (this.gv_UserManage.RowCount == 0)
            {
                return;
            }
            if (SystemClass.MessageBoxShow.ShowMessage("是否真的要删除选定用户？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strUserID = gv_UserManage.GetFocusedRowCellValue("sUserID").ToString();
                string strSql = "delete from SYS_USER_INFO where sUserID='" + strUserID + "'";
                if (ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(strSql) == 1)
                {
                    LoadData();
                }
                else
                {
                   SystemClass.MessageBoxShow.ShowMessage("删除用户失败！");
                }
            }
        }

        private void Form_Main_UserManage_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

    }
}
