using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.UserAuthority
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_UserAuthority : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DTAuthority;
        string sRole;
       
        public Form_Main_UserAuthority()
        {
            InitializeComponent();
        }


        public Form_Main_UserAuthority(string role)
        {
            InitializeComponent();
            sRole = role;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            gc_Authority.Tag = "SYS_User_Authority";

            gc_Role.Tag = "SYS_User_Info";
            string strSqlRole = "select distinct(sRole) from SYS_User_Info";
            DataTable DTRole = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlRole).Tables[0];

            this.gc_Role.DataSource = DTRole;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Role);


            this.gv_Authority.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Authority);



            
           

           

        }

       

        private void LoadData()
        {
            string strSql = "exec sp_Authority '" + sRole + "'";
            DTAuthority = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            this.gc_Authority.DataSource = DTAuthority;


        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "刷新":
                    InitRoleAuthority();
                    break;
                case "保存":
                    SaveDate();
                    break;
                
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void InitRoleAuthority()
        {
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("exec sp_InitRoleAuthority '" + sRole + "'");
        }


      
        private void SaveDate()
        {
            gv_Authority.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_Authority.DataSource);
            gc_Authority.DataSource = binding;
            binding.EndEdit();

            if (DTAuthority.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTAuthority.GetChanges(), "SYS_User_Authority");
                }
                catch (Exception)
                {

                    throw;
                }


            }
            LoadData();
        }

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void gv_Role_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_Role.RowCount > 0)
            {
                int intRowHandle = e.FocusedRowHandle;
                sRole = gv_Role.GetFocusedRowCellValue("sRole").ToString();
                InitRoleAuthority();
                string strSql = "exec sp_Authority '" + sRole + "'";
                DTAuthority = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

                this.gc_Authority.DataSource = DTAuthority;
               
            }
           

        }






    }
}

