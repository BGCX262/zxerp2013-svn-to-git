using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.Customer
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_Customer : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        public Form_Main_Customer()
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
            gc_Customer.Tag = "Bas_Customer";

            LoadData();
            this.gv_Customer.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Customer);

        }

        private void LoadData()
        {
            string strSql = "select * from Bas_Customer";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            this.gc_Customer.DataSource = DT;


        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "增加":
                    AddData();
                    break;
                case "保存":
                    SaveDate();
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

            DataRow dr = ((DataTable)gc_Customer.DataSource).NewRow();
            dr["tCreateDate"] = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            dr["sCreateName"] = fp.pub_sUserNameByChinese;
            dr["tModifyDate"] = System.DateTime.Now;
            dr["sModifierName"] = fp.pub_sUserNameByChinese;
            ((DataTable)gc_Customer.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_Customer.DeleteSelectedRows();

            }
        }
        private void SaveDate()
        {
            gv_Customer.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_Customer.DataSource);
            gc_Customer.DataSource = binding;
            binding.EndEdit();

            if (DT.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_Customer");
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






    }
}

