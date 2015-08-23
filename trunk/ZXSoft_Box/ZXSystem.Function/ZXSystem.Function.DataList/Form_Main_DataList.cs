using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.DataList
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_DataList : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_DataList()
        {
            InitializeComponent();
        }
        DataTable DT_Common = new DataTable();
        BindingSource BS_Common = new BindingSource(); 
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag; ;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            //ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();

            //ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_DataList.Name, "通用", this.dgv_DataList);


            this.gc_FunctionName.Tag = "SYS_Menu";
            this.gc_Common.Tag = "Bas_DataList";
            

            string treestrSql = "select m.sFunctionName sFunctionName from SYS_USER_AUTHORITY a left outer join dbo.SYS_Menu m on a.sfunctionID=m.sfunctionID where m.smenugroupid='C' And iValidFlag>0 and sRole='" + FP.pub_sRole + "'";
            DataTable treeDT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(treestrSql).Tables[0];


            this.gc_FunctionName.DataSource = treeDT;

            LoadData();
            
            //左边选择只读
            BS_Common.DataSource = DT_Common;
            this.gc_Common.DataSource = BS_Common;
            this.gv_Common.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_FunctionName);
            gv_FuntionName.OptionsView.ShowAutoFilterRow = true;//----打开网格过滤
           // ZX.Controls.DataGridViewEx.DataGridViewC.GetDatagridviewFromDB(this.Text + '-' + dgv_sFunctionName.Name, "通用", this.dgv_sFunctionName);
        }

        private void LoadData()
        {
            //string strSql = "select * from Bas_Client";
            //DTClient = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            //this.gc_Client.DataSource = DTClient;
          


            if (this.gv_FuntionName.RowCount > 0)
            {
                string sclass = gv_FuntionName.GetFocusedRowCellValue(this.gv_FuntionName.Columns.ColumnByFieldName("sFunctionName")).ToString();
                string sqlQuery = "select * from Bas_DataList where sClass='" + sclass + "'order by ssortby";
                DT_Common = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(sqlQuery).Tables[0];                
            }
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
                    DeletData();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void DeletData()
        {
             if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_Common.DeleteSelectedRows();
                SaveData();

            }

            //if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //   // dgv_DataList.Rows.Remove(this.dgv_DataList.CurrentRow);
                
               
            //}
        }

        private void SaveData()
        {
            
            //gv_Common.GetDataRow(this.gv_Common.FocusedRowHandle).EndEdit();
            gv_Common.CloseEditor();
            ((BindingSource)gv_Common.DataSource).EndEdit();
            gc_Common.MainView.PostEditor();


           // DataRowView dv = new DataRowView();

            
           // BS_Common.EndEdit();

            if (DT_Common.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT_Common.GetChanges(), "Bas_DataList");
                }
                catch (Exception)
                {

                    throw;
                }


            }
           
            LoadData();
            BS_Common.DataSource = DT_Common;
        }

        private void AddData()
        {
            //DataRow dr = ((DataTable)dgv_DataList.DataSource).NewRow();
            //dr["sClass"] = this.dgv_sFunctionName.Rows[this.dgv_sFunctionName.CurrentCell.RowIndex].Cells["sfunctionName"].Value.ToString();

            //((DataTable)dgv_DataList.DataSource).Rows.Add(dr);

            DataView view = (DataView)((BindingSource)gc_Common.DataSource).List;
            DataRowView newRow = view.AddNew();
            newRow["sClass"] = this.gv_FuntionName.GetFocusedRowCellValue(this.gv_FuntionName.Columns.ColumnByFieldName("sFunctionName")).ToString(); 
                
        }

        private void Form_Main_DataList_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

       


        private void dgv_sFunctionName_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

       

        private void gv_FuntionName_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            string sclass = "";

            //int intRowHandle = e.FocusedRowHandle;
            try
            {
                sclass = gv_FuntionName.GetFocusedRowCellValue(this.gv_FuntionName.Columns.ColumnByFieldName("sFunctionName")).ToString();
                //MessageBox.Show(sclass);
            }
            catch (Exception)
            {

                return;
            }

            string sqlQuery = "select * from Bas_DataList where sClass='" + sclass + "'order by ssortby";
            DT_Common = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(sqlQuery).Tables[0];

            BS_Common.DataSource = DT_Common;
        }






    }
}

