using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;



namespace ZXSystem.Function.Client
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_Client : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DTCustomer;
        DataTable DTCustomerMaster;
        DataTable DTCustomerAddress;
        DataTable DTCustomerContact;
        public Form_Main_Client()
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
            //gc_Client.Tag = "Bas_Client";
            gc_CustomerMaster.Tag = "Bas_Customer";
            gc_CustomerAddress.Tag = "Bas_CustomerAddress";
            gc_CustomerContact.Tag = "Bas_CustomerContact";

            

            LoadData();
            //this.gv_Client.OptionsView.ColumnAutoWidth = false;
            //ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Client);
            this.gv_CustomerMaster.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_CustomerMaster);
            gv_CustomerMaster.OptionsView.ShowAutoFilterRow = true;
            tabPage1.Selected = true;
        }

        private void LoadData()
        {
            //string strSql = "select * from Bas_Client";
            //DTClient = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            //this.gc_Client.DataSource = DTClient;


            string strClientMaster = "select * from Bas_Customer";
            DTCustomerMaster = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strClientMaster).Tables[0];

            this.gc_CustomerMaster.DataSource = DTCustomerMaster;



            string strCustomerAddress = "select * from Bas_CustomerAddress";
            DTCustomerAddress = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strCustomerAddress).Tables[0];

            this.gc_CustomerAddress.DataSource = DTCustomerAddress;


            string strCustomerContact = "select * from Bas_CustomerContact";
            DTCustomerContact = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strCustomerContact).Tables[0];

            this.gc_CustomerContact.DataSource = DTCustomerContact;


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
            dr["sCreateName"] = fp.Pub_sUserName;
            dr["tModifyDate"] = System.DateTime.Now;
            dr["sModifierName"] = fp.Pub_sUserName;
            ((DataTable)gc_Customer.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                 this.gv_CustomerMaster.DeleteSelectedRows();

            }
        }
        private void SaveDate()
        {
            this.gv_CustomerMaster.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_Customer.DataSource);
            gc_Customer.DataSource = binding;
            binding.EndEdit();

            if (DTCustomer.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTCustomer.GetChanges(), "Bas_Customer");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Client_SelectionChanged(ZX.Controls.DotNetMagic.Controls.TabControl sender, ZX.Controls.DotNetMagic.Controls.TabPage oldPage, ZX.Controls.DotNetMagic.Controls.TabPage newPage)
        {

        }

        private void ts_CustomerContact_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void ts_CustomerAddress_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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


        //private void FuzzyQuery()
        //{
        //    string newFilter = string.Empty;
        //    string filter = this.gv_CustomerMaster.ActiveFilterString;
        //    newFilter = filter;//.Replace("Like '", "Like '%");
        //    MessageBox.Show(newFilter);
        //    gv_CustomerMaster.ActiveFilterString = newFilter;
        //}

        private void gv_CustomerMaster_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {

        }

        private void gv_CustomerMaster_ColumnFilterChanged(object sender, EventArgs e)
        {
            FuzzyQuery();
        }


        /// <summary>
        /// 处理过滤条件Like '%{0}%'
        /// </summary>
        private void FuzzyQuery()
        {
            
            string filter = gv_CustomerMaster.ActiveFilterString;
            if (filter.Contains("Like '%"))
            {
                return;
            }
            else
            {
                string newFilter = string.Empty;
                newFilter = filter.Replace("Like '", "Like '%");
               // MessageBox.Show(newFilter);
                gv_CustomerMaster.ActiveFilterString = newFilter;
            }

        }
    }
}

