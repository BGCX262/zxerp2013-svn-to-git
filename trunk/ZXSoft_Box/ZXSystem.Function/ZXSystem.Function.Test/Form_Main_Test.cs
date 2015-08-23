using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.Test
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_Test : Form,IZXMessage
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        public Form_Main_Test()
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
          // dgv_Customer.AllowUserToAddRows = false;
            gridControlEx1.Tag = "Bas_Customer";
            gridView1.OptionsView.ColumnAutoWidth = false;
            
            LoadData();
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gridControlEx1);
            
           // this. gridView1.Columns[n].BestFit();

        }


        


        private void LoadData()
        {
            string strSql = "select * from Bas_Customer";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            gridControlEx1.DataSource = DT;
           // dgv_Customer.DataSource = DT;
            

            //if (DT.Columns.Contains("CustLevel") == true)
            //{
            //    GridColumn gcStore = gridView1.Columns.ColumnByFieldName("CustLevel");
            //    if (gcStore != null)
            //    {

            //        DataSet ds = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("select sValue from Bas_DataList where sClass='客户等级设置' order by ssortby");
            //        DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            //        lupEdit.DataSource = ds.Tables[0].DefaultView;
            //        lupEdit.ValueMember = "sValue";
            //        lupEdit.DisplayMember = "sValue";
            //        lupEdit.ShowFooter = false;
            //        //lupEdit.ShowHeader = false;
            //        lupEdit.NullText = "";
            //        gcStore.ColumnEdit = lupEdit;


                    
            //    }
            //}
            //if (DT.Columns.Contains("CreateDate") == true)
            //{
            //    GridColumn gcStore = gridView1.Columns.ColumnByFieldName("CreateDate");
            //    if (gcStore != null)
            //    {

            //        //DataSet ds = ZX.ZXSystem.DBUtility.DbHelperSQL.Query("select sValue from Bas_DataList where sClass='客户等级设置' order by ssortby");
            //        DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit lupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
                    
            //        gcStore.ColumnEdit = lupEdit;


            //        //DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            //    }
            //}



           

            //ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_Customer.Name, "通用", this.dgv_Customer);
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "增加":
                    
                    break;
                case "保存":
                    AdjustPanel2();
                    break;
                case "调整":
                    AdjustPanel();
                    break;
                case "删除":
                  
                    break;
                case "帮助":
                    ShowLabelMessage("好东东呀");
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        public void ShowLabelMessage(string sMessage)
        {

            if ((this.MdiParent != null) && (this.MdiParent is IZXMessage))
            {
                (this.MdiParent as IZXMessage).ShowLabelMessage(sMessage);
            }


        }

        private void AdjustPanel()
        {
            //this.groupBox1.SendToBack();
            //this.groupBox2.Visible = false;
            //this.groupBox3.SendToBack();
            //this.groupBox4.SendToBack();
        }


        private void AdjustPanel2()
        {
            //this.groupBox4.SendToBack();
            //this.groupBox3.SendToBack();
            //this.groupBox2.Visible = true; 
            //this.groupBox2.SendToBack();
            //this.groupBox1.SendToBack();
        }

        private void AddData()
        {

            //DataRow dr = ((DataTable)dgv_Customer.DataSource).NewRow();
            //dr["CreateDate"] = System.DateTime.Now;
            //ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            //dr["CreateName"] = fp.pub_YHMC;
            //dr["ModifyDate"] = System.DateTime.Now;
            //dr["ModifierName"] = fp.pub_YHMC;
            //((DataTable)dgv_Customer.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //dgv_Customer.Rows.Remove(this.dgv_Customer.CurrentRow);

            }
        }
        private void SaveDate()
        {
        //    BindingSource binding = new BindingSource();
        //    binding.DataSource = ((DataTable)dgv_Customer.DataSource);
        //    dgv_Customer.DataSource = binding;
        //    binding.EndEdit();

        //    if (DT.GetChanges() != null)
        //    {
        //        try
        //        {
        //            ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_Customer");
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }


        //    }
        //    LoadData();
        }

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

       
        






    }
}

