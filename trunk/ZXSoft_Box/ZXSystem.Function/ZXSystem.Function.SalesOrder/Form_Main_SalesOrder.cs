using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.SalesOrder
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_SalesOrder : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        public Form_Main_SalesOrder()
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
            gc_SalesOrder.Tag = "Sal_SalesOrder";
            
            LoadData();
            this.gv_SalesOrder.OptionsView.ColumnAutoWidth = false;
            gv_SalesOrder.OptionsBehavior.Editable = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_SalesOrder);

        }

        private void LoadData()
        {
            string strSql = "select * from Sal_SalesOrder";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            this.gc_SalesOrder.DataSource = DT;


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
                    ModifiData();
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

        private void ModifiData()
        {
            string so = this.gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO")).ToString();
            ZX.Win.FunctionParameter FP = new ZX.Win.FunctionParameter();
            FP = (ZX.Win.FunctionParameter)this.Tag;
            FP.pub_Object = so;
            //MessageBox.Show(this.MdiParent.Name.ToString());
            Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_WorkOrd", FP, this.MdiParent);

            System.Windows.Forms.TabPage TP = new System.Windows.Forms.TabPage(f.Text);
            TP.Tag = f;
            TP.ToolTipText = f.Text;
            foreach (Control item in this.ParentForm.Controls)
            {
                if ((item is System.Windows.Forms.TabControl) && (item.Name == "TabControFormList"))
                {
                    TabControl c = (TabControl)item;
                    c.TabPages.Add(TP);
                    c.SelectedTab = TP;
                }
            }
            TP.Select();




            this.Close();
        }


        private void AddData()
        {

            DataRow dr = ((DataTable)gc_SalesOrder.DataSource).NewRow();
            dr["tCreateDate"] = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            dr["sCreateName"] = fp.pub_sUserNameByChinese;
            dr["tModifyDate"] = System.DateTime.Now;
            dr["sModifierName"] = fp.pub_sUserNameByChinese;
            ((DataTable)gc_SalesOrder.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_SalesOrder.DeleteSelectedRows();

            }
        }
        private void SaveData()
        {
            gv_SalesOrder.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_SalesOrder.DataSource);
            gc_SalesOrder.DataSource = binding;
            binding.EndEdit();

            if (DT.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Sal_SalesOrder");
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

        private void gc_SalesOrder_DoubleClick(object sender, EventArgs e)
        {
            ModifiData();

        }






    }
}

