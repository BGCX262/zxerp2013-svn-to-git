using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.Controls;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.ProductProcess
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_ProductProcess : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DTWCR;
        DataTable DTWDieCut;
        DataTable DTWPack;
        DataTable DTWPrint_Offset;
        DataTable DTWPrint_WBI;
        DataTable DTWStitch;
        DataTable DTWGule;
        DataTable DTWorkOrderExt;
        string sWO = "";

        public Form_Main_ProductProcess()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            sWO = FP.pub_Object.ToString();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            gc_WCR.Tag = "PP_WCR";
            gc_WDieCut.Tag = "PP_WDieCut";
            gc_WGule.Tag = "PP_WGule";
            gc_WPack.Tag = "PP_WPack";
            gc_WPrint_Offset.Tag = "PP_WPrint_Offset";
            gc_WPrint_WBI.Tag = "PP_WPrint_WBI";
            gc_WStitch.Tag = "PP_WStitch";
            gc_WorkOrderExt.Tag = "PP_WorkorderExt";
            LoadData();
            this.gv_WCR.OptionsView.ColumnAutoWidth = false;
           this.gv_WDieCut.OptionsView.ColumnAutoWidth = false;
            this.gv_WPack.OptionsView.ColumnAutoWidth = false;  
            this.gv_WPrint_Offset.OptionsView.ColumnAutoWidth = false;
            this.gv_WPrint_WBI.OptionsView.ColumnAutoWidth = false;
            this.gv_WStitch.OptionsView.ColumnAutoWidth = false;
            this.gv_WGule.OptionsView.ColumnAutoWidth = false;
            this.gv_WorkOrderExt.OptionsView.ColumnAutoWidth = false;
            
            
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WCR);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WDieCut);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WPack);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WPrint_Offset);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WPrint_WBI);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WStitch);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WGule);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WorkOrderExt);
            
            //设置显示高度
            int Titleheight = 40;
            int Rowheight = 30;

            gb_WCR.Height = gv_WCR.RowCount * Rowheight + Titleheight;
            gb_WDieCut.Height = gv_WDieCut.RowCount * Rowheight + Titleheight;
            gb_WGule.Height = gv_WGule.RowCount * Rowheight + Titleheight;
            gb_WPack.Height = gv_WPack.RowCount * Rowheight + Titleheight;
            gb_WPrint_Offset.Height = gv_WPrint_Offset.RowCount * Rowheight + Titleheight;
            gb_WPrint_WBI.Height = gv_WPrint_WBI.RowCount * Rowheight + Titleheight;
            gb_WStitch.Height = gv_WStitch.RowCount * Rowheight + Titleheight;
            gb_WorkOrderExt.Height = gv_WorkOrderExt.RowCount * Rowheight + Titleheight;

            //为了显示美观，设置多选及多选模式
            //gv_WCR.OptionsSelection.MultiSelect = true;
            //gv_WCR.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WDieCut.OptionsSelection.MultiSelect = true;
            //gv_WDieCut.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WGule.OptionsSelection.MultiSelect = true;
            //gv_WGule.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WPack.OptionsSelection.MultiSelect = true;
            //gv_WPack.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WPrint_Offset.OptionsSelection.MultiSelect = true;
            //gv_WPrint_Offset.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WPrint_WBI.OptionsSelection.MultiSelect = true;
            //gv_WPrint_WBI.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WGule.OptionsSelection.MultiSelect = true;
            //gv_WGule.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gv_WStitch.OptionsSelection.MultiSelect = true;
            //gv_WStitch.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;

            

            Hashtable ht = new Hashtable();
            foreach (Control item in this.Controls)
            {
                if (item is System.Windows.Forms.GroupBox)

                {
                    DataTable dt=(DataTable)item.Tag;
                    if (dt.Rows.Count == 0)
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        if (dt.Columns.Contains("dRoutingNo"))
                        {
                            item.Tag = dt.Rows[0]["dRoutingNo"];
                            ht.Add(item.Tag.ToString(), item.Name);
                        }
                        else
                        {
                            item.Tag = 0;
                            ht.Add(item.Tag.ToString(), item.Name);
                        }
                    
                    }
                }

                
            }


            ArrayList list = new ArrayList(ht.Keys);
            list.Sort();
            foreach (string str in list)
            {
               // MessageBox.Show(str+":"+ht[str]);
                foreach (Control item in this.Controls)
                    {
                        if (item is System.Windows.Forms.GroupBox)

                        {
                            if ((string)ht[str] == (string)item.Name)
                            {
                                //item.SendToBack();
                                item.BringToFront();
                            }
                        }

                    }
                }


           

        }

        private void LoadData()
        {
            string strSqlWCR = "select * from PP_WCR Where sWo='" + sWO + "'";
            DTWCR = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWCR).Tables[0];
            this.gc_WCR.DataSource = DTWCR;
            gc_WCR.Parent.Tag = DTWCR;


            string strSqlWDieCut = "select * from PP_WDieCut Where sWo='" + sWO + "'";
            DTWDieCut = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWDieCut).Tables[0];
            this.gc_WDieCut.DataSource = DTWDieCut;
            gc_WDieCut.Parent.Tag = DTWDieCut;

            string strSqlWPack = "select * from PP_WPack Where sWo='" + sWO + "'";
            DTWPack = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWPack).Tables[0];
            this.gc_WPack.DataSource = DTWPack;
            gc_WPack.Parent.Tag = DTWPack;

            string strSqlWPrint_Offset = "select * from PP_WPrint_Offset Where sWo='" + sWO + "'";
            DTWPrint_Offset = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWPrint_Offset).Tables[0];
            this.gc_WPrint_Offset.DataSource = DTWPrint_Offset;
            gc_WPrint_Offset.Parent.Tag = DTWPrint_Offset;


            string strSqlWPrint_WBI = "select * from PP_WPrint_WBI Where sWo='" + sWO + "'";
            DTWPrint_WBI = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWPrint_WBI).Tables[0];
            this.gc_WPrint_WBI.DataSource = DTWPrint_WBI;
            gc_WPrint_WBI.Parent.Tag = DTWPrint_WBI;

            string strSqlWStitch = "select * from PP_WStitch Where sWo='" + sWO + "'";
            DTWStitch = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWStitch).Tables[0];
            this.gc_WStitch.DataSource = DTWStitch;
            gc_WStitch.Parent.Tag = DTWStitch;

            string strSqlWGule = "select * from PP_WGule Where sWo='" + sWO + "'";
            DTWGule = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWGule).Tables[0];
            this.gc_WGule.DataSource = DTWGule;
            gc_WGule.Parent.Tag = DTWGule;


            string strSqlWorkOrderExt = "select * from PP_WorkOrderExt Where sWo='" + sWO + "'";
            DTWorkOrderExt = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSqlWorkOrderExt).Tables[0];
            this.gc_WorkOrderExt.DataSource = DTWorkOrderExt;
            gc_WorkOrderExt.Parent.Tag = DTWorkOrderExt;



            
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
               

                case "保存":
                    SaveDate();
                    break;
                case "修改":

                    break;
                case "删除":
                    DeleteData();
                    break;
                case "算料":


                    CalcUnitPrice();
                    //计算生产尺寸
                    CalcMFDimension();
                    CalcScore();
                    CalcCRDimension();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void CalcCRDimension()
        {
            DataRow dr = gv_WCR.GetDataRow(gv_WCR.FocusedRowHandle);
            string dL = dr["dMFL"].ToString();
            string dW = dr["dMFW"].ToString();
            string dH = dr["dMFH"].ToString();
            string sFluteType = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sFluteType"));
            string sCustID = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sCustID"));
            string sPartTypeID = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sPartTypeID"));

            if (dL == "") { dL = "0"; }
            if (dW == "") { dW = "0"; }
            if (dH == "") { dH = "0"; }

            string QuerySql_Params = string.Format("select {0} as 长,{1} as 宽,{2} as 高", new object[] { dL, dW, dH });

            //string QuerySql_dUnitPrice = string.Format("select {0} from {1}", new object[] { FromulaBySales, QuerySql_Params });

            string QuerySql_ScoreL = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID, sFluteType, QuerySql_Params, "压线长", 0 });
            string sCRLineL = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_ScoreL);
            string QuerySql_ScoreW = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID, sFluteType, QuerySql_Params, "压线宽", 0 });
            string sCRLineW = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_ScoreW);

            string QuerySql_ParamsCR = string.Format("select {0} as 长,{1} as 宽,{2} as 高,{3} 压线长,{4} 压线宽", new object[] { dL, dW, dH, sCRLineL, sCRLineW });
            //MessageBox.Show(QuerySql_Paramscr);

            string QuerySql_CFL = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID, sFluteType, QuerySql_ParamsCR, "开片长", 0 });
            string dCRLength = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_CFL);
            string QuerySql_CRW = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID, sFluteType, QuerySql_ParamsCR, "开片宽", 0 });
            string dCRWidth = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_CRW);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("dCRLength"), dCRLength);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("dCRWidth"), dCRWidth);


        }

        /// <summary>
        /// 客户尺寸转制造尺寸
        /// </summary>
        private void CalcMFDimension()
        {
            DataRow dr = gv_WorkOrderExt.GetDataRow(gv_WorkOrderExt.FocusedRowHandle);
             string sFluteType = dr["sFluteType"].ToString();
            string sCustID = dr["sCustID"].ToString();
            string sPartTypeID = dr["sPartTypeID"].ToString();
            string sDimension = dr["sDimension"].ToString();
            string dL = dr["dL"].ToString();
            string dW = dr["dW"].ToString();
            string dH = dr["dH"].ToString();

            if (dL == "") { dL = "0"; }
            if (dW == "") { dW = "0"; }
            if (dH == "") { dH = "0"; }
            string sqldMFLadd = string.Format("select dbo.FN_GetsDimensiondExtral ('{0}','{1}','{2}','{3}','{4}')", new object[] { sCustID, sPartTypeID, sDimension, sFluteType, "L" });
            string sqldMFWadd = string.Format("select dbo.FN_GetsDimensiondExtral ('{0}','{1}','{2}','{3}','{4}')", new object[] { sCustID, sPartTypeID, sDimension, sFluteType, "W" });
            string sqldMFHadd = string.Format("select dbo.FN_GetsDimensiondExtral ('{0}','{1}','{2}','{3}','{4}')", new object[] { sCustID, sPartTypeID, sDimension, sFluteType, "H" });
            //MessageBox.Show(sqldMFLadd.ToString() + ":" + sqldMFWadd.ToString() + ":" + sqldMFHadd.ToString());
            decimal MFLadd = (decimal)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(sqldMFLadd);
            decimal MFWadd = (decimal)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(sqldMFWadd);
            decimal MFHadd = (decimal)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(sqldMFHadd);
           // MessageBox.Show(MFLadd.ToString() + ":" + MFWadd.ToString() + ":" + MFHadd.ToString());

            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("dMFL"), Convert.ToDecimal(dL) + MFLadd);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("dMFW"), Convert.ToDecimal(dW) + MFWadd);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("dMFH"), Convert.ToDecimal(dH) + MFHadd);

        }

        /// <summary>
        /// 计算压线
        /// </summary>
        private void CalcScore()
        {
            DataRow dr = gv_WCR.GetDataRow(gv_WCR.FocusedRowHandle);
            string dL = dr["dMFL"].ToString();
            string dW = dr["dMFW"].ToString();
            string dH = dr["dMFH"].ToString();
            string sFluteType = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sFluteType"));
            string sCustID = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sCustID"));
            string sPartTypeID = (string)gv_WorkOrderExt.GetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("sPartTypeID"));

            if (dL == "") { dL = "0"; }
            if (dW == "") { dW = "0"; }
            if (dH == "") { dH = "0"; }

            string QuerySql_Params = string.Format("select {0} as 长,{1} as 宽,{2} as 高", new object[] { dL, dW, dH });

            //string QuerySql_dUnitPrice = string.Format("select {0} from {1}", new object[] { FromulaBySales, QuerySql_Params });

            string QuerySql_ScoreL = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID,  sFluteType, QuerySql_Params,"压线长", 0 });
            string sCRLineL = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_ScoreL);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("sCRLineL"), sCRLineL);

            string QuerySql_ScoreW = string.Format("exec SP_ProductCtnFormulaScoreByInfo '{0}','{1}','{2}','{3}','{4}','{5}'", new object[] { sCustID, sPartTypeID, sFluteType, QuerySql_Params, "压线宽", 0 });
            string sCRLineW = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_ScoreW);
            gv_WCR.SetFocusedRowCellValue(gv_WCR.Columns.ColumnByFieldName("sCRLineW"), sCRLineW);

        }

        /// <summary>
        /// 计算单价
        /// </summary>
        private void CalcUnitPrice()
        {
            DataRow dr = gv_WorkOrderExt.GetDataRow(gv_WorkOrderExt.FocusedRowHandle);
            string dL = dr["dL"].ToString();
            string dW = dr["dW"].ToString();
            string dH = dr["dH"].ToString();
            string sDimension = dr["sDimension"].ToString();
            string sFluteType = dr["sFluteType"].ToString();
            string dMaterialPrice = dr["dMaterialPrice"].ToString();
            string sCustID = dr["sCustID"].ToString();
            string sPartTypeID = dr["sPartTypeID"].ToString();
            if (dMaterialPrice == "")
            {
                return;
            }
            if (dL == "") { dL = "0"; }
            if (dW == "") { dW = "0"; }
            if (dH == "") { dH = "0"; }
            if (dMaterialPrice == "") { dMaterialPrice = "0"; }

            //string QuerySql_Fromula = string.Format("select dbo.FN_GetFromulaBySales ('{0}','{1}','{2}','{3}')", new object[] { sCustID, sPartTypeID, sDimension, sFluteType });


            //测试用 查看公式
            //string FromulaBySales = (string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_Fromula);

            //if (FromulaBySales == "")
            //{
            //    FromulaBySales = "0";
            //}

            string QuerySql_Params = string.Format("select {0} as 长,{1} as 宽,{2} as 高,{3} as 平方价", new object[] { dL, dW, dH, dMaterialPrice });

            //string QuerySql_dUnitPrice = string.Format("select {0} from {1}", new object[] { FromulaBySales, QuerySql_Params });

            string QuerySql_dPrice=string.Format("exec SP_CalculateUnitPrice '{0}','{1}','{2}','{3}','{4}','{5}'",new object[] { sCustID, sPartTypeID, sDimension, sFluteType,QuerySql_Params,0});
            decimal sUnitPrice = (decimal)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_dPrice);
            gv_WorkOrderExt.SetFocusedRowCellValue(gv_WorkOrderExt.Columns.ColumnByFieldName("dUnitPrice"), sUnitPrice);
        }


      
        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //this.gv_WCR.DeleteSelectedRows();

            }
        }
        private void SaveDate()
        {

            SaveDateWCR();
            SaveDateWDieCut();
            SaveDateWPack();
            SaveDateWPrint_Offset();
            SaveDateWPrint_WBI();
            SaveDateWGule();
            SaveDateWStitch();
            SaveDateWorkOrderExt();
            

             LoadData();
        }

        private void SaveDateWorkOrderExt()
        {
            gv_WorkOrderExt.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WorkOrderExt.DataSource);
            gc_WorkOrderExt.DataSource = binding;
            binding.EndEdit();

            if (DTWorkOrderExt.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrderExt.GetChanges(), "PP_WorkOrderExt");
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }


        private void SaveDateWCR()
        {
            gv_WCR.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WCR.DataSource);
            gc_WCR.DataSource = binding;
            binding.EndEdit();

            if (DTWCR.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWCR.GetChanges(), "PP_WCR");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }

        private void SaveDateWDieCut()
        {
            gv_WDieCut.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WDieCut.DataSource);
            gc_WDieCut.DataSource = binding;
            binding.EndEdit();

            if (DTWDieCut.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWDieCut.GetChanges(), "PP_WDieCut");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }

        private void SaveDateWGule()
        {
            this.gv_WGule.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WGule.DataSource);
            gc_WGule.DataSource = binding;
            binding.EndEdit();

            if (DTWGule.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWGule.GetChanges(), "PP_WGule");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }


        private void SaveDateWPack()
        {
            this.gv_WPack.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WPack.DataSource);
            gc_WPack.DataSource = binding;
            binding.EndEdit();

            if (DTWPack.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWPack.GetChanges(), "PP_WPack");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }

        private void SaveDateWPrint_Offset()
        {
            this.gv_WPrint_Offset.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WPrint_Offset.DataSource);
            gc_WPrint_Offset.DataSource = binding;
            binding.EndEdit();

            if (DTWPrint_Offset.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWPrint_Offset.GetChanges(), "PP_WPrint_Offset");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }


        private void SaveDateWPrint_WBI()
        {
            this.gv_WPrint_WBI.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WPrint_WBI.DataSource);
            gc_WPrint_WBI.DataSource = binding;
            binding.EndEdit();

            if (DTWPrint_WBI.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWPrint_WBI.GetChanges(), "PP_WPrint_WBI");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }

        private void SaveDateWStitch()
        {
            this.gv_WStitch.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_WStitch.DataSource);
            gc_WStitch.DataSource = binding;
            binding.EndEdit();

            if (DTWStitch.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWStitch.GetChanges(), "PP_WStitch");
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }
        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void gc_WCR_Click(object sender, EventArgs e)
        {
           
        }

        private void gv_WCR_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           

        }






    }
}

