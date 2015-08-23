using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.FormulaByWorking
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_FormulaByWorking_old : Form
    {
        DataTable DT;
        DataTable DT_cust;
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_FormulaByWorking_old()
        {
            InitializeComponent();
            this.dgv_Common.DataError += delegate(object sender, DataGridViewDataErrorEventArgs e) { };
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            dgv_Common.Tag = "Bas_FormulaByWorking";
            dgv_Common.AllowUserToAddRows = false;

            dgv_Customer.Tag = "Bas_Customer";
            string CuststrSql = "select '通用' sCustID,'针对所有客户通用' sCustName Union All select sCustID,sCustName from Bas_Customer";
            DT_cust = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(CuststrSql).Tables[0];
            dgv_Customer.AllowUserToAddRows = false;
           
            dgv_Customer.DataSource = DT_cust;
            ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_Customer.Name, "通用", this.dgv_Customer);
            LoadData();





        }

        private void LoadData()
        {
            string strSql = "select * from Bas_FormulaByWorking";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            dgv_Common.DataSource = DT;
            ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_Common.Name, "通用", this.dgv_Common);
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
            DataRow dr = ((DataTable)dgv_Common.DataSource).NewRow();
            dr["tCreateDate"] = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            dr["sCreateName"] = fp.pub_sUserNameByChinese;
            dr["tModifyDate"] = System.DateTime.Now;
            dr["sModifierName"] = fp.pub_sUserNameByChinese;
            dr["sCustId"] = this.dgv_Customer.Rows[this.dgv_Customer.CurrentCell.RowIndex].Cells["sCustId"].Value.ToString();

            ((DataTable)dgv_Common.DataSource).Rows.Add(dr);
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

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_FormulaByWorking");
            }
            LoadData();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void dgv_Common_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            e.Row.Cells["sCustID"].Value = this.dgv_Customer.Rows[this.dgv_Customer.CurrentCell.RowIndex].Cells["sCustId"].Value.ToString();

        }

        private void dgv_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string sqlQuery = "select * from Bas_FormulaByWorking where sCustID='" + this.dgv_Customer.Rows[this.dgv_Customer.CurrentCell.RowIndex].Cells["sCustId"].Value.ToString() + "'";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(sqlQuery).Tables[0];

            this.dgv_Common.DataSource = DT;
        }






    }
}

