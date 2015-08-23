using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.ItemInfo
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_ItemInfo : Form
    {
        DataTable DT_Common = new DataTable();
        BindingSource BS_Common = new BindingSource(); 
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_ItemInfo()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);

            gc_Common.Tag = "ItemInfo";

            LoadData();
            BS_Common.DataSource = DT_Common;
            this.gc_Common.DataSource = BS_Common;
            this.gv_Common.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);
        }

        private void LoadData()
        {
           
            string strSql = "select * from ItemInfo";
            DT_Common = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            
            
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "查找":

                    break;
                case "增加":
                    AddData();
                    break;
                case "保存":
                    SaveData();
                    break;
                case "修改":

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

        private void AddData()
        {
            DataView view = (DataView)((BindingSource)gc_Common.DataSource).List;
            DataRowView newRow = view.AddNew();
            newRow["tCreateDate"] = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            newRow["sCreateName"] = fp.pub_sUserNameByChinese;

            
        }


        private void DeleteData()
        {

            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_Common.DeleteSelectedRows();
                SaveData();

            }
        }
        private void SaveData()
        {

            gv_Common.CloseEditor();
            ((BindingSource)gv_Common.DataSource).EndEdit();
            gc_Common.MainView.PostEditor();


            if (DT_Common.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT_Common.GetChanges(), "ItemInfo");
                }
                catch (Exception)
                {

                    throw;
                }


            }

            LoadData();
            BS_Common.DataSource = DT_Common;
        }

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }






    }
}

