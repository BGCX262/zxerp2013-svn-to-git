using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.RoleGridViewSet
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_RoleGridViewSet : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        public Form_Main_RoleGridViewSet()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            dgv_Common.Tag = "Sys_RoleGridViewSet";
            
            LoadData();
        }

        private void LoadData()
        {
            string strSql = "select * from Sys_RoleGridViewSet";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            dgv_Common.DataSource = DT;
            dgv_Common.AllowUserToAddRows = false;
            ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_Common.Name, "通用", this.dgv_Common);
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "增加":

                    break;
                case "保存":
                    SaveDate();
                    break;
                case "查询":
                    QueryDate();
                    break;
                case "删除":
                    DeleteData();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void QueryDate()
        {
            string strSql = "select * from Sys_RoleGridViewSet where 1=1";
            if (ts_FieldTitle.Text != "")
            {
                strSql += " And FieldTitle like '%" + ts_FieldTitle.Text + "%'";
            }
            if (ts_TableName.Text != "")
            {
                strSql += " And GridViewName like '%" + ts_TableName.Text + "%'";
            }
            if (ts_FieldName.Text != "")
            {
                strSql += " And FieldName like '%" + ts_FieldName.Text + "%'";
            }

            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            dgv_Common.DataSource = DT;
            dgv_Common.AllowUserToAddRows = false;
            ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_Common.Name, "通用", this.dgv_Common);
        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_Common.Rows.Remove(this.dgv_Common.CurrentRow);

            }
        }
        private void SaveDate()
             
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)dgv_Common.DataSource);
            dgv_Common.DataSource = binding;
            binding.EndEdit();
            if (DT.GetChanges() != null)
            {

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Sys_RoleGridViewSet");
            }
            LoadData();
        }

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }






    }
}

