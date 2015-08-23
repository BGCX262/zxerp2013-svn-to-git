using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.BoardMaterialPrice
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_BoardMaterialPrice : Form
    {
        DataTable DT;
        DataTable DT_cust;
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_BoardMaterialPrice()
        {
            InitializeComponent();
            //this.gc_Common.DataError += delegate(object sender, DataGridViewDataErrorEventArgs e) { };  
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);


            gc_Common.Tag = "Bas_BoardMaterialPrice";
            this.gv_Common.OptionsView.ColumnAutoWidth = false;



            gc_Customer.Tag = "Bas_Customer";
            string CuststrSql = "select '通用' sCustID,'针对所有客户通用' sCustName Union All select sCustID,sCustName from Bas_Customer";
            DT_cust = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(CuststrSql).Tables[0];
            this.gv_Customer.OptionsView.ColumnAutoWidth = false;
            gc_Customer.DataSource = DT_cust;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Customer);
            LoadData();

            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);



        }

        private void LoadData()
        {
            if (gv_Customer.RowCount > 0)
            {
                string sCustID = this.gv_Customer.GetFocusedRowCellValue(this.gv_Customer.Columns.ColumnByFieldName("sCustID")).ToString();

                //string sCustID = (string)gv_Customer.GetRowCellValue(intRowHandle, this.gv_Customer.Columns.ColumnByFieldName("sCustID"));

                string strSql = "select * from Bas_BoardMaterialPrice where sCustID='" + sCustID + "'";

                DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

                gc_Common.DataSource = DT;
            }

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
            DataRow dr = ((DataTable)gc_Common.DataSource).NewRow();
            dr["sCustId"] = this.gv_Customer.GetFocusedRowCellValue(this.gv_Customer.Columns.ColumnByFieldName("sCustID")).ToString();
            //this.gv_Customer.Rows[this.dgv_Customer.CurrentCell.RowIndex].Cells["sCustId"].Value.ToString();

            ((DataTable)gc_Common.DataSource).Rows.Add(dr);
        }

        private void DeleteData()
        {
            if (MessageBox.Show("是否删除工序信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.gv_Common.DeleteSelectedRows();
                this.gv_Common.CloseEditor();
                BindingSource binding2 = new BindingSource();
                binding2.DataSource = ((DataTable)this.gc_Common.DataSource);
                gc_Common.DataSource = binding2;



                if (DT.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_BoardMaterialPrice");
                }
            }
            LoadData();

        }
        private void SaveDate()
        {
            if (gv_Common.Editable)
            {
                gv_Common.CloseEditor();
            }
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_Common.DataSource);
            gc_Common.DataSource = binding;
            binding.EndEdit();

            try
            {
                if (DT.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_BoardMaterialPrice");
                }

            }
            catch (Exception)
            {

                throw;
            }

            LoadData();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemClass.ApplicationFormMain.CloseingForm(this);
        }





        private void gv_Customer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int intRowHandle = e.FocusedRowHandle;
            string sCustID = (string)gv_Customer.GetRowCellValue(intRowHandle, this.gv_Customer.Columns.ColumnByFieldName("sCustID"));

            string sqlQuery = "select * from Bas_BoardMaterialPrice where sCustID='" + sCustID + "'";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(sqlQuery).Tables[0];


            this.gc_Common.DataSource = DT;
        }






    }
}

