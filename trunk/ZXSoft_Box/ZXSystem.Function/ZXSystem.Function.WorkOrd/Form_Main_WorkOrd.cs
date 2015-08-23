using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.WorkOrd
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_WorkOrd : Form
    {
        DataTable DTSalesOrder;
        DataTable DTBas_Machines;
        DataTable DTWorkOrder;
        DataTable DTWorkOrderExt;
        DataTable DTRouting;
        ZX.Win.FunctionParameter FP = new ZX.Win.FunctionParameter();
        private DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo downHitInfo;
        private DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo downHitInfo2;


        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_WorkOrd()
        {
            InitializeComponent();

        }


        private void Form_Main_Load(object sender, EventArgs e)
        {
            FP = (ZX.Win.FunctionParameter)this.Tag;
            //DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);


            gc_SalesOrder.Tag = "Sal_SalesOrder";
            gv_SalesOrder.OptionsView.ColumnAutoWidth = false;
            

            //初始化工单信息
            this.gc_WorkOrder.Tag = "PP_WorkOrder";
            gv_WorkOrder.OptionsView.ColumnAutoWidth = false;


            //初始化工序信息
            this.gc_Routing.Tag = "PP_Routing";
            gv_Routing.OptionsView.ColumnAutoWidth = false;

            
            //单选行
            //gv_Routing.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            //gv_Routing.OptionsSelection.MultiSelect = false;


            //初始化机床信息
            this.gc_Machine.Tag = "Bas_Machines";
            gv_Machine.OptionsView.ColumnAutoWidth = false;
            //设置不可编辑
            gv_Machine.OptionsBehavior.Editable = false;

            string strSql2 = "select * from Bas_Machines order by ssortby";
            DTBas_Machines = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql2).Tables[0];
            gc_Machine.DataSource = DTBas_Machines;
            if (FP.pub_Object.ToString() == "")
            {
                LoadDataNull();
            }
            else
            {
                LoadData(FP.pub_Object.ToString());
            }


            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Machine);

        }

        private void LoadData(string sSO)
        {
            string strSql = "select * from Sal_SalesOrder where sSO='" + sSO + "'";
            DTSalesOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            gc_SalesOrder.DataSource = DTSalesOrder;




            string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.swo=e.swo where w.sSO='" + sSO + "'";
            DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
            gc_WorkOrder.DataSource = DTWorkOrder;


            if (this.gv_WorkOrder.RowCount > 0)
            {
                string sWO = this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO")).ToString();

                if (sWO != "")
                {
                    string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                    DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                    gc_Routing.DataSource = DTRouting;
                }
            }


            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_SalesOrder);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_WorkOrder);
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Routing);


        }


        private void LoadDataNull()
        {
            string strSql = "select * from Sal_SalesOrder where 1=2";
            DTSalesOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            gc_SalesOrder.DataSource = DTSalesOrder;


            string strSql2 = "select * from Bas_Machines order by ssortby";
            DTBas_Machines = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql2).Tables[0];
            gc_Machine.DataSource = DTBas_Machines;

            string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.swo=e.swo where 1=2";
            DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
            gc_WorkOrder.DataSource = DTWorkOrder;

            //string sSo = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO")).ToString();
            //if (sSo != "")
            //{
            //    string strSql3 = "select * from PP_WorkOrder sSO='" + sSo + "'";
            //    DT3 = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
            //    gc_WorkOrder.DataSource = DT3;
            //}

            string strSql4 = "select * from PP_Routing where 1=2";
            DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
            gc_Routing.DataSource = DTRouting;




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
                case "保存工单":
                   
                    break;
                case "计算单价":
                   CalcUnitPrice();
                    break;
                case "保存工序":
          
                    break;
                case "删除":
                    DeleteData();
                    break;
                case "打印":
                    FrxReport();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void CalcUnitPrice()
        {
            //没有数据就不计算
            if (this.gv_SalesOrder.RowCount == 0) return;

            //得到本行记录的数据
            DataRow dr = gv_SalesOrder.GetDataRow(gv_SalesOrder.FocusedRowHandle);
            string dL = dr["dL"].ToString();
            string dW = dr["dW"].ToString();
            string dH = dr["dH"].ToString();
            string sDimension = dr["sDimension"].ToString();
            string sFluteType = dr["sFluteType"].ToString();
            string dMaterialPrice = dr["dMaterialPrice"].ToString();
            string sCustID = dr["sCustID"].ToString();
            string sPartTypeID = dr["sPartTypeID"].ToString();

            if (dL == "") { dL="0";}
            if (dW == "") { dW="0";}
            if (dH == "") { dH="0";}
            if (dMaterialPrice == "") { dMaterialPrice = "0"; }


            //取面积计算公式
            string QuerySql_Fromula = string.Format("select dbo.FN_GetFromulaBySales ('{0}','{1}','{2}','{3}')", new object[] { sCustID, sPartTypeID, sDimension, sFluteType });

           

            string FromulaBySales=(string)ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_Fromula);
           //显示
            //MessageBox.Show(FromulaBySales);



            string QuerySql_Params = string.Format("(select {0} as 长,{1} as 宽,{2} as 高,{3} as 平方价) A", new object[] { dL, dW, dH, dMaterialPrice });

            //MessageBox.Show(QuerySql_Params);

            if (FromulaBySales == "")
            {
                FromulaBySales = "0";
            }

            //计算单价
            string QuerySql_dUnitPrice = string.Format("select {0} from {1}", new object[] { FromulaBySales, QuerySql_Params });

            string sUnitPrice = ZX.ZXSystem.DBUtility.DbHelperSQL.GetSingle(QuerySql_dUnitPrice).ToString() ;
          
            sUnitPrice=string.Format("{0:F2}",double.Parse(sUnitPrice));
            //MessageBox.Show(sUnitPrice);
            gv_SalesOrder.SetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dUnitPrice"), sUnitPrice);



        }

        private void FrxReport()
        {
            ZX.Win.FunctionParameter param = new ZX.Win.FunctionParameter();
            param.Pub_ReportName = "FrxWO";
            param.Pub_StoredProcName = "sp_FrxWO";
            SqlParameter[] parameters = {
			            new SqlParameter("@sWO", SqlDbType.VarChar,20)     
                                            };
            parameters[0].Value = gv_WorkOrder.GetFocusedRowCellValue(gv_WorkOrder.Columns.ColumnByFieldName("sWO"));
            param.Pub_Sqlparam = parameters;
            Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_FrxReport", param, null);

           
        }

       

        

        private void AddData()
        {

            if (this.gv_SalesOrder.RowCount > 0) return;
            //显示客户查询
            ZX.Win.FunctionParameter Qry = new ZX.Win.FunctionParameter();

            Qry.SqlQrystr = "select sCustID,sCustName,sSalesMan,sSOClass,sTaxCode from Bas_Customer";
            Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", Qry, null);
            Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;
            if (Dic.Count > 1)
            {
                DataRow dr = ((DataTable)gc_SalesOrder.DataSource).NewRow();
                dr["sSOClass"] = Dic["sSOClass"];
                dr["sSalesMan"] = Dic["sSalesMan"];
                dr["sCustID"] = Dic["sCustID"];
                dr["sTaxCode"] = Dic["sTaxCode"];
                dr["sSO"] = ZX.ZXSystem.DBUtility.DbHelperSQL.GetBilNo("sSO");
                //设置sSo
                FP.pub_Object = dr["sSO"];
                dr["sBOM"] = ZX.ZXSystem.DBUtility.DbHelperSQL.GetBilNo("sBOM");
                // dr["sBOM"] = ZX.ZXSystem.DBUtility.DbHelperSQL.GetBilNo("sBOM");

                ((DataTable)gc_SalesOrder.DataSource).Rows.Add(dr);
            }

            //一定放在新增行之后


        }

        private void DeleteData()
        {
            if (MessageBox.Show("订单删除？工单信息也将删除，不可恢复！", "删除确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                this.gv_SalesOrder.DeleteSelectedRows();
                ///更新表
                ///同时删除workorder 表

            }
        }
        private void SaveDate()
        {
            if (gv_SalesOrder.Editable)
            {
                gv_SalesOrder.CloseEditor();
            }
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_SalesOrder.DataSource);
            gc_SalesOrder.DataSource = binding;


            if (DTSalesOrder.GetChanges() != null)
            {

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTSalesOrder.GetChanges(), "Sal_SalesOrder");
            }

            if (this.gv_WorkOrder.RowCount == 0 && FP.pub_Object.ToString()!="")
            {
                if (MessageBox.Show("是否增加工单信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        WorkOrdInsert();
                    }
            }
            


            


            //this.gv_WorkOrder.CloseEditor();
            //BindingSource binding2 = new BindingSource();
            //binding2.DataSource = ((DataTable)this.gc_WorkOrder.DataSource);
            //gc_WorkOrder.DataSource = binding2;


            //if (DT3.GetChanges() != null)
            //{

            //    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT3.GetChanges(), "PP_WorkOrder");
            //}

            LoadData(FP.pub_Object.ToString());
        }

        /// <summary>
        /// 插入工单
        /// </summary>
        private void WorkOrdInsert()
        {
            DataRow dr = ((DataTable)this.gc_WorkOrder.DataSource).NewRow();
            dr["sBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBOM"));
            dr["sWO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO"));
            dr["sCustID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustID"));
            dr["sSO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO"));
            dr["tProddate"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("tDeliveryDate"));
            dr["dProdQty"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dOrderQty"));
            dr["dRate"] = 1;
             ((DataTable)gc_WorkOrder.DataSource).Rows.Add(dr);


             string strSql_WorkOrderExt = "select * from pp_WorkOrderExt where 1=2";
             DTWorkOrderExt = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql_WorkOrderExt).Tables[0];
             DataRow drWorkOrderExt = DTWorkOrderExt.NewRow();
             drWorkOrderExt["sBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBOM"));
             drWorkOrderExt["sWO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO"));
             drWorkOrderExt["sCustID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustID"));
             drWorkOrderExt["sCustPO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustPO"));
             drWorkOrderExt["sCustSubPO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustSubPO"));
             drWorkOrderExt["sCustBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustBOM"));
             drWorkOrderExt["sPartTypeID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sPartTypeID"));
             drWorkOrderExt["sDimension"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sDimension"));
             drWorkOrderExt["sLWH"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sLWH"));
             drWorkOrderExt["sFluteType"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sFluteType"));
             drWorkOrderExt["dL"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dL"));
             drWorkOrderExt["dW"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dW"));
             drWorkOrderExt["dH"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dH"));
             drWorkOrderExt["sBoardMaterial"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBoardMaterial"));
             drWorkOrderExt["dMaterialPrice"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dMaterialPrice"));
             DTWorkOrderExt.Rows.Add(drWorkOrderExt);

            




            this.gv_WorkOrder.CloseEditor();
            BindingSource binding2 = new BindingSource();
            binding2.DataSource = ((DataTable)this.gc_WorkOrder.DataSource);
            gc_WorkOrder.DataSource = binding2;


            if (DTWorkOrder.GetChanges() != null)
            {

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrder.GetChanges(), "PP_WorkOrder");
            }
            if (DTWorkOrderExt.GetChanges() != null)
            {

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrderExt.GetChanges(), "PP_WorkOrderExt");
            }

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void dgv_Common_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {



        }

        private void dgv_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip7_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //switch (e.ClickedItem.Text)
            //{
            //    case "增加":
            //        AddDataDelivery();
            //        break;
            //    case "保存":
            //        SaveDateDelivery();
            //        break;
            //    case "删除":
            //        DeleteDataeDelivery();
            //        break;

            //}
        }

        private void gv_SalesOrder_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "sPartTypeID" && this.gv_WorkOrder.RowCount == 0)
            //{
            //    DataRow dr = ((DataTable)this.gc_WorkOrder.DataSource).NewRow();
            //    dr["sBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBOM"));
            //    dr["sWO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO"));
            //    ((DataTable)gc_WorkOrder.DataSource).Rows.Add(dr);
            //}

        }

        private void gv_SalesOrder_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        private void gc_Machine_DoubleClick(object sender, EventArgs e)
        {
            //  MessageBox.Show(sender.ToString());



            string Machine = this.gv_Machine.GetFocusedRowCellValue(gv_Machine.Columns.ColumnByFieldName("sMachine")).ToString().Trim();
            string RoutingClass = this.gv_Machine.GetFocusedRowCellValue(gv_Machine.Columns.ColumnByFieldName("sRoutingClass")).ToString().Trim();



            if (this.gv_WorkOrder.RowCount > 0)
            {
                int maxNo = this.gv_Routing.RowCount + 1;
                DataRow dr = ((DataTable)this.gc_Routing.DataSource).NewRow();

                dr["sRoutingClass"] = RoutingClass;
                dr["sMachine"] = Machine;
                dr["sBOM"] = this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sBOM")).ToString();
                dr["sWO"] = this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO")).ToString();
                dr["dRoutingNo"] = maxNo; //Convert.ToInt16(gv_Machine.GetFocusedRowCellValue(gv_Machine.Columns.ColumnByFieldName("sSortBy")));
                dr["dWOIn"] = 1;
                dr["dWOOut"] = 1;
                dr["dProdQty"] = this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("dProdQty"));

                ((DataTable)gc_Routing.DataSource).Rows.Add(dr);


                //保存

                if (gv_Routing.Editable)
                {
                    gv_Routing.CloseEditor();
                }
                BindingSource binding = new BindingSource();
                binding.DataSource = ((DataTable)gc_Routing.DataSource);
                gc_Routing.DataSource = binding;


                if (DTRouting.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTRouting.GetChanges(), "PP_Routing");
                }

                SqlParameter[] parameters = {
                    new SqlParameter("@RoutingClass", SqlDbType.VarChar,20),
                    new SqlParameter("@sMachine", SqlDbType.VarChar,20),
                    new SqlParameter("@sWO", SqlDbType.VarChar,20),
                    new SqlParameter("@sBOM", SqlDbType.VarChar,20),
                    new SqlParameter("@dRoutingNo", SqlDbType.Int),};
                parameters[0].Value = RoutingClass;
                parameters[1].Value = Machine;
                parameters[2].Value = dr["sWO"];
                parameters[3].Value = dr["sBOM"];
                parameters[4].Value = maxNo;
                ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("exec sp_InsertRouting @RoutingClass,@sMachine,@sWO,@sBOM,@dRoutingNo", parameters);



                
               
                //查询工单号即可
                string sWO = (string)this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO"));


                if (sWO != "")
                {
                    string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                    DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                    gc_Routing.DataSource = DTRouting;
                }
            }



            

        }

        private void gc_Routing_DragDrop(object sender, DragEventArgs e)
        {
            
        
            
            DataRow oldrow = e.Data.GetData(typeof(DataRow)) as DataRow;

            Point p = PointToClient(new Point(e.X, e.Y));
            Point tabp = this.tabControl1.Location;
            Point gcp = this.gc_Routing.Location;
            Point Top = new Point((p.X - tabp.X - gcp.X), (p.Y - tabp.Y - gcp.Y - 24));
            downHitInfo2 = gv_Routing.CalcHitInfo(Top);
            // MessageBox.Show(Top.ToString());


            DataRow newrow = gv_Routing.GetDataRow(downHitInfo2.RowHandle);
            //MessageBox.Show(data["dRoutingNo"].ToString());
            // row["dRoutingNo"]=0;

            int OldPos = Convert.ToInt32(oldrow["dRoutingNo"]);
            int NewPos = Convert.ToInt32(newrow["dRoutingNo"]);
            //下向上移时
            if (OldPos > NewPos)
            {
               
                oldrow["dRoutingNo"] = 0;

                foreach (DataRow item in this.DTRouting.Rows)
                {
                    // MessageBox.Show(item["sMachine"].ToString());
                    if (Convert.ToInt32(item["dRoutingNo"]) >= NewPos)
                    {

                        item["dRoutingNo"] = Convert.ToInt32(item["dRoutingNo"])*10+1;
                    }

                }
                oldrow["dRoutingNo"] = NewPos * 10;
                //因为是批量更新，所以表主键不可以重复

                if (DTRouting.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTRouting.GetChanges(), "PP_Routing");
                }
                string strSql4 = "select * from PP_Routing where sWO='" + oldrow["sWO"] + "' order by dRoutingNo";
                DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
               
                
            }

            //上向下移时
            if (OldPos < NewPos)
            {

                oldrow["dRoutingNo"] = 0;

                foreach (DataRow item in this.DTRouting.Rows)
                {
                    // MessageBox.Show(item["sMachine"].ToString());
                    if (Convert.ToInt32(item["dRoutingNo"]) >NewPos)
                    {

                        item["dRoutingNo"] = Convert.ToInt32(item["dRoutingNo"]) * 10 + 1;
                    }

                }
                oldrow["dRoutingNo"] = NewPos*10;
                //因为是批量更新，所以表主键不可以重复

                if (DTRouting.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTRouting.GetChanges(), "PP_Routing");
                }
                string strSql4 = "select * from PP_Routing where sWO='" + oldrow["sWO"] + "' order by dRoutingNo";
                DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];


            }




            RoutingReOrder();
       

           // LoadData(FP.pub_Object.ToString());

            string sWO = (string)this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO"));


            if (sWO != "")
            {
                string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                gc_Routing.DataSource = DTRouting;
            }


        }

        private void RoutingReOrder()
        {
            int i = 1;
            foreach (DataRow item in this.DTRouting.Rows)
            {



                item["dRoutingNo"] = i;
                i += 1;


            }
            if (DTRouting.GetChanges() != null)
            {

                ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTRouting.GetChanges(), "PP_Routing");
            }
        }

        private void gc_Routing_DragEnter(object sender, DragEventArgs e)
        {
         
            e.Effect = DragDropEffects.Move;

        }

        private void gc_Routing_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("MouseDown:"+e.X + ":" + e.Y);
            downHitInfo = gv_Routing.CalcHitInfo(new Point(e.X, e.Y));

        }

        private void gc_Routing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (downHitInfo == null) return;
            
            //移动矩形，点击位置为中心，画一个矩形
            Rectangle dragRect = new Rectangle(new Point(
                downHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                downHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);

            //当判断为移动时
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                DataRow data = gv_Routing.GetDataRow(downHitInfo.RowHandle);

                if (data != null)
                {
                    gc_Routing.DoDragDrop(data, DragDropEffects.Move);
                }
            }

        }

        private void gc_Routing_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
        /// <summary>
        /// 工单导航按钮设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gc_WorkOrder_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            string LocalWO = "";
            //if (e.Button.ButtonType ==DevExpress.XtraEditors.NavigatorButtonType.Custom)
            //{
            //    string Machine = this.gv_Routing.GetFocusedRowCellValue(gv_Routing.Columns.ColumnByFieldName("sMachine")).ToString();
            //    MessageBox.Show(Machine);
            //}

            
        

            if (e.Button.ButtonType ==DevExpress.XtraEditors.NavigatorButtonType.Append) 
            {

               
                e.Handled = true;   //取消默认新增事件

                if (this.gv_WorkOrder.RowCount == 0 && FP.pub_Object.ToString() != "")
                {

                    WorkOrdInsert();
                    //string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.swo=e.swo where w.sSO='" + FP.pub_Object.ToString() + "'";
                    //DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
                    //gc_WorkOrder.DataSource = DTWorkOrder;
                    LoadData(FP.pub_Object.ToString());
                    return;
                }


                if (this.gv_WorkOrder.RowCount >0 && FP.pub_Object.ToString() != "")
                {

                    int Count = gv_WorkOrder.RowCount;
                    string sNewBOM = ZX.ZXSystem.DBUtility.DbHelperSQL.GetBilNo("sBOM");
                        DataRow dr = ((DataTable)this.gc_WorkOrder.DataSource).NewRow();
                        dr["sBOM"] = sNewBOM;
                      //dr["sBOM"] =gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBOM")) + "-" + Count.ToString("00");
                        dr["sWO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO")) + "-" + Count.ToString("00");
                        LocalWO = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO")) + "-" + Count.ToString("00");
                        dr["sCustID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustID"));
                        dr["sSO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO"));
                        dr["tProddate"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("tDeliveryDate"));
                        dr["dProdQty"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dOrderQty"));
                        dr["dRate"] = 1;
                        dr["sPartTypeID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sPartTypeID"));
                        dr["sCustBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustBOM"));
                        dr["dL"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dL"));
                        dr["dW"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dW"));
                        dr["dH"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dH"));

                        ((DataTable)gc_WorkOrder.DataSource).Rows.Add(dr);


                        string strSql_WorkOrderExt = "select * from pp_WorkOrderExt where 1=2";
                        DTWorkOrderExt = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql_WorkOrderExt).Tables[0];
                        DataRow drWorkOrderExt = DTWorkOrderExt.NewRow();
                        drWorkOrderExt["sBOM"] = sNewBOM;
                        drWorkOrderExt["sWO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sSO")) + "-" + Count.ToString("00");
                        drWorkOrderExt["sCustID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustID"));
                        drWorkOrderExt["sCustPO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustPO"));
                        drWorkOrderExt["sCustBOM"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustBOM"));
                        drWorkOrderExt["sCustSubPO"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sCustSubPO"));
                        drWorkOrderExt["sPartTypeID"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sPartTypeID"));
                        drWorkOrderExt["sDimension"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sDimension"));
                        drWorkOrderExt["sLWH"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sLWH"));
                        drWorkOrderExt["sFluteType"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sFluteType"));
                        drWorkOrderExt["dL"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dL"));
                        drWorkOrderExt["dW"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dW"));
                        drWorkOrderExt["dH"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("dH"));
                       // drWorkOrderExt["sBoardMaterial"] = gv_SalesOrder.GetFocusedRowCellValue(gv_SalesOrder.Columns.ColumnByFieldName("sBoardMaterial"));
                        DTWorkOrderExt.Rows.Add(drWorkOrderExt);



                        this.gv_WorkOrder.CloseEditor();
                        BindingSource binding2 = new BindingSource();
                        binding2.DataSource = ((DataTable)this.gc_WorkOrder.DataSource);
                        gc_WorkOrder.DataSource = binding2;


                        if (DTWorkOrder.GetChanges() != null)
                        {

                            ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrder.GetChanges(), "PP_WorkOrder");
                            
                        }



                        

                        if (DTWorkOrderExt.GetChanges() != null)
                        {

                            ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrderExt.GetChanges(), "PP_WorkOrderExt");
                        }



                        string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.swo=e.swo where w.sSO='" + FP.pub_Object.ToString() + "'";
                        DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
                        gc_WorkOrder.DataSource = DTWorkOrder;

                        //自动定位行
                        if (!string.IsNullOrEmpty(LocalWO))
                            gv_WorkOrder.FocusedRowHandle = gv_WorkOrder.LocateByValue(0, gv_WorkOrder.Columns[0], LocalWO);
                }
            


            }


            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {

                
                e.Handled = true;   //取消默认删除事件
                if (MessageBox.Show("是否删除工单信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string sWO = gv_WorkOrder.GetFocusedRowCellValue(gv_WorkOrder.Columns.ColumnByFieldName("sWO")).ToString();
                    //MessageBox.Show(sWO);
                    


                    //this.gv_WorkOrder.FocusedRowHandle//.DeleteSelectedRows();
                    this.gv_WorkOrder.DeleteRow(this.gv_WorkOrder.FocusedRowHandle);
                    this.gv_WorkOrder.CloseEditor();
                    BindingSource binding2 = new BindingSource();
                    binding2.DataSource = ((DataTable)this.gc_WorkOrder.DataSource);
                    gc_WorkOrder.DataSource = binding2;

                   


                    if (DTWorkOrder.GetChanges() != null)
                    {

                        ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrder.GetChanges(), "PP_WorkOrder");
                    }

                    //删除工艺路线
                    if (sWO != "")
                    {
                        ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("delete from pp_routing where sWO='" + sWO + "'");
                    }


                    string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.swo=e.swo where w.sSO='" + FP.pub_Object.ToString() + "'";
                    DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
                    gc_WorkOrder.DataSource = DTWorkOrder;

                }
                  
            


            }



            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
            {
                e.Handled = true;   //取消事件

                this.gv_WorkOrder.CloseEditor();
                BindingSource binding2 = new BindingSource();
                binding2.DataSource = ((DataTable)this.gc_WorkOrder.DataSource);
               
                gc_WorkOrder.DataSource = binding2;

                if (DTWorkOrder.GetChanges() != null)
                {

                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrder.GetChanges(), "PP_WorkOrder");
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTWorkOrder.GetChanges(), "PP_WorkOrderExt");
                }



                string strSql3 = "select w.*,e.* from pp_workorder w left outer join pp_workorderext e on w.sWO=e.sWO where w.sSO='" + FP.pub_Object.ToString() + "'";
                DTWorkOrder = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql3).Tables[0];
                gc_WorkOrder.DataSource = DTWorkOrder;

            }


            
          
        }

        /// <summary>
        /// 工单焦点变化时：流程跟着变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_WorkOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (this.gv_WorkOrder.RowCount > 0)
            {
                //string sWO = this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO")).ToString();


                int intRowHandle = e.FocusedRowHandle;
                string sWO = (string)gv_WorkOrder.GetRowCellValue(intRowHandle, this.gv_WorkOrder.Columns.ColumnByFieldName("sWO"));


                if (sWO != "")
                {
                    string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                    DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                    gc_Routing.DataSource = DTRouting;
                }
            }
            else
            {
                string strSql4 = "select * from PP_Routing where sWO='' order by dRoutingNo";
                DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                gc_Routing.DataSource = DTRouting;
            }
        }

        /// <summary>
        /// 流程导航按钮设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gc_Routing_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {

                
                e.Handled = true;   
                if (MessageBox.Show("是否删除工序信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.gv_Routing.DeleteSelectedRows();
                    this.gv_Routing.CloseEditor();
                    BindingSource binding2 = new BindingSource();
                    binding2.DataSource = ((DataTable)this.gc_Routing.DataSource);
                    gc_Routing.DataSource = binding2;

                    

                    if (DTRouting.GetChanges() != null)
                    {

                        ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DTRouting.GetChanges(), "PP_Routing");
                    }

                    string sWO = (string)this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO"));
                    
                    if (sWO != "")
                    {
                        string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                        DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                        gc_Routing.DataSource = DTRouting;
                    }

                    RoutingReOrder();

                    //string sWO = (string)this.gv_WorkOrder.GetFocusedRowCellValue(this.gv_WorkOrder.Columns.ColumnByFieldName("sWO"));


                    if (sWO != "")
                    {
                        string strSql4 = "select * from PP_Routing where sWO='" + sWO + "' order by dRoutingNo";
                        DTRouting = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql4).Tables[0];
                        gc_Routing.DataSource = DTRouting;
                    }
                }



            }
        }

        private void gc_Routing_DoubleClick(object sender, EventArgs e)
        {

            //string Machine = this.gv_Routing.GetFocusedRowCellValue(gv_Routing.Columns.ColumnByFieldName("sMachine")).ToString();
            //MessageBox.Show(Machine);

            if (gv_WorkOrder.RowCount > 0)
            {


                ZX.Win.FunctionParameter Qry = new ZX.Win.FunctionParameter();
                Qry = (ZX.Win.FunctionParameter)this.Tag;
                Qry.pub_Object = this.gv_WorkOrder.GetFocusedRowCellValue(gv_WorkOrder.Columns.ColumnByFieldName("sWO")).ToString();
                //Qry.pub_Object = this.gv_Routing.GetFocusedRowCellValue(gv_Routing.Columns.ColumnByFieldName("sWO")).ToString();
                Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_ProductProcess", Qry, null);
            }
        }

        private void gc_Routing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           
        }

        private void gv_Routing_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gv_Routing_MouseDown(object sender, MouseEventArgs e)
        {
            
            //DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gv_Routing.CalcHitInfo(new Point(e.X,e.Y)); 
            //if(e.Button == MouseButtons.Left && e.Clicks == 2) 
            //{
            //    if (hInfo.InRow)
            //    {

            //        string Machine = this.gv_Routing.GetFocusedRowCellValue(gv_Routing.Columns.ColumnByFieldName("sMachine")).ToString();
            //        MessageBox.Show(Machine);
            //    } 

            //}
        }











    }
    }


