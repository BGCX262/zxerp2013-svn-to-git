using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;
using System.Collections;

namespace ZXSystem.Function.CommonQry
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_CommonQry : Form
    {
        
        static Dictionary<string, string> Dic=new Dictionary<string,string>();
        Hashtable hs = new Hashtable();
     

        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_CommonQry()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            
            DataGridView HRDG = FP.MyGridView;

            string strSql = FP.SqlQrystr;
            gv_CommonQry.OptionsSelection.MultiSelect = FP.pub_DataGridViewMultiSelect;
            if (FP.pub_Object is DataRow)
            {
                DataRow dr = (DataRow)FP.pub_Object;
            }
           

            //todo取参数字段
            
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

           

            if (gv_CommonQry.OptionsSelection.MultiSelect)
            {
                DT.Columns.Add("选择", System.Type.GetType("System.Boolean"));
                DT.Columns["选择"].SetOrdinal(0);    


             }
            //MessageBox.Show(strSql);
            gc_CommonQry.DataSource = DT;


            //是否需要通用翻译 默认是需要翻译，如有特殊情况则不使用翻译
            if (FP.isGetFieldTitleFromDictionary)
            {
                ZX.Controls.DataGridViewEx.GridControlEx.GetFieldTitleFromDictionary(gc_CommonQry);
            }
            gv_CommonQry.BestFitColumns();
            gv_CommonQry.OptionsBehavior.Editable = false;
            hs.Clear();
            for (int i = 0; i < gv_CommonQry.Columns.Count; i++)
            {
                //hashtabel记录下来
                //去重复项
                if (hs.ContainsKey(gv_CommonQry.Columns[i].Caption))
                {
                    continue;
                }
                //MessageBox.Show(gv_CommonQry.Columns[i].Caption);
                hs.Add(gv_CommonQry.Columns[i].Caption, gv_CommonQry.Columns[i].FieldName);
                cbb_QryValue.Items.Add(gv_CommonQry.Columns[i].Caption);


            }
        }

        private void Form_Main_CommonQry_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Tag = Dic;
            SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void dgv_CommonQry_DoubleClick(object sender, EventArgs e)
        {
            //if (this.dgv_CommonQry_Old.CurrentRow.Index >= 0)
            //{
            //    Dic.Clear();
            //    Dic.Add("kingry", "kingry");
            //    //ReturnValue = dgv_CommonQry[this.dgv_CommonQry.CurrentRow.Cells[returnField].ColumnIndex, this.dgv_CommonQry.CurrentRow.Index].Value.ToString();
            //    DataGridViewRow dr = dgv_CommonQry_Old.CurrentRow;
            //    foreach (DataGridViewCell c in dr.Cells)
            //    {
            //        //MessageBox.Show(c.Value.ToString());//得到对应列名的值
            //        //MessageBox.Show(c.OwningColumn.Name.ToString());//得到列名

            //        Dic.Add(c.OwningColumn.Name.ToString(), c.Value.ToString());
                    
            //    }
                
            //    this.Close();
            //}
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "查询":
                    QryData();
                    break;
             
                case "帮助":
                   
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void QryData()
        {
            if (cbb_QryValue.Text != "")
            {
                ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
                DataGridView HRDG = FP.MyGridView;
                string strSql = FP.SqlQrystr;
                DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];


                string qrystr = hs[cbb_QryValue.Text].ToString() + " Like '%" + tb_QryValue.Text + "%'";
                qrystr = qrystr.Replace("*", "[*]");
                // MessageBox.Show(qrystr);
                DataTable newdt = new DataTable();
                //newdt = ((DataTable)dgv_CommonQry.DataSource).Clone(); ;// 克隆dt 的结构，包括所有 dt 架构和约束,并无数据； 
                newdt = DT.Clone();
                DataRow[] rows = DT.Select(qrystr); // 从dt 中查询符合条件的记录； 
                foreach (DataRow row in rows)  // 将查询的结果添加到dt中； 
                {
                    newdt.Rows.Add(row.ItemArray);
                }
                gc_CommonQry.DataSource = newdt.DefaultView;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_CommonQry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gc_CommonQry_DoubleClick(object sender, EventArgs e)
        {
            if (this.gv_CommonQry.FocusedRowHandle>= 0)
            {
                Dic.Clear();
                Dic.Add("kingry", "kingry");
                //ReturnValue = dgv_CommonQry[this.dgv_CommonQry.CurrentRow.Cells[returnField].ColumnIndex, this.dgv_CommonQry.CurrentRow.Index].Value.ToString();
                DataRow dr = gv_CommonQry.GetDataRow(gv_CommonQry.FocusedRowHandle);
                //foreach (object c in dr.ItemArray)
                //{
                //    //MessageBox.Show(c.Value.ToString());//得到对应列名的值
                //    //MessageBox.Show(c.OwningColumn.Name.ToString());//得到列名

                //    Dic.Add(c.ToString(), c.ToString());

                //}
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    //(new System.Collections.ArrayList.ArrayListDebugView(dr.Table.Columns.List)).Items[0]
                    
                    //string Key=((System.Data.DataColumn)((new System.Collections.ArrayList.ArrayListDebugView(((System.Data.InternalDataCollectionBase)(dr.Table.Columns)).List)).Items[i])).ColumnName;
                    Dic.Add(dr.Table.Columns[i].ColumnName, dr.ItemArray[i].ToString());
                }



                this.Close();
            }
        }






    }
}

