using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.CPMSet
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_CPMSet : Form
    {
        DataTable DT_Common = new DataTable();
        BindingSource BS_Common = new BindingSource(); 
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_CPMSet()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);

            gc_Common.Tag = "Bas_CPMSet";
            LoadData();
            BS_Common.DataSource = DT_Common;
            this.gc_Common.DataSource = BS_Common;
            this.gv_Common.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);
        }

        private void LoadData()
        {
            string strSql = "select * from Bas_CPMSet";
            DT_Common = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            //dgv_Common.DataSource = DT;
           

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
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
            //DataRow dr = ((DataTable)dgv_Common.DataSource).NewRow();
            //dr["CreateDate"] = System.DateTime.Now;
            //ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            //dr["CreateName"] = fp.pub_sUserNameByChinese;
            //dr["ModifyDate"] = System.DateTime.Now;

            //dr["ModifierName"] = fp.pub_sUserNameByChinese;
            //((DataTable)dgv_Common.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_Common.DeleteSelectedRows();
                SaveData();

            }
            //if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{

            //    dgv_Common.Rows.Remove(this.dgv_Common.CurrentRow);

            //}
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
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT_Common.GetChanges(), "Bas_FluteType");
                }
                catch (Exception)
                {

                    throw;
                }


            }

            LoadData();
            BS_Common.DataSource = DT_Common;


            //BindingSource binding = new BindingSource();
            //binding.DataSource = ((DataTable)dgv_Common.DataSource);
            //dgv_Common.DataSource = binding;
            //binding.EndEdit();



            //if (DT.GetChanges() != null)
            //{
            //    try
            //    {
            //        ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_CPMSet");
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }


            //}
            //LoadData();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void dgv_Common_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           
        }

        private void dgv_Common_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }






    }
}

