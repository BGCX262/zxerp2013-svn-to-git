using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.Controls.DotNetMagic.Controls;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.LookAndFeel;
using ZX.ZXSystem.Win;


namespace ZXSystem.Function.Area
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_Area : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        int iTreeNodeIndex = 0;
        public Form_Main_Area()
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
            //gc_Customer.Tag = "Bas_Customer";

            LoadData();
            //this.gv_Customer.OptionsView.ColumnAutoWidth = false;
            //ZX.Controls.GridControlEx.GetDatagridviewFromDB("通用", gc_Customer);
            //treeList1.OptionsView.ShowCheckBoxes = true;          

        }

        private void LoadData()
        {
            string strSql = "select * from Bas_Area";
            //DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            //this.gc_Customer.DataSource = DT;

           DT= ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            //BindRoot();

            //treeList1.DataSource = DT;
            //treeList1.KeyFieldName = "sAreaID";//设置主键 
            //treeList1.ParentFieldName = "sParentAreaID";//设置父级主键 
            //treeList1.RootValue = "";//顶级树结点的值 
           
           //TreeListFillInfo();

            ZX.Controls.TreeViewC tv = new ZX.Controls.TreeViewC();
            tv.ReadNodesFromDataTable(this.treeView1, DT, false, 1, 0, 2);



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
                case "查找":
                    FindNodeByNodeText(ts_NodeText.Text);
                   // FindNodeByTag("10000");
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void FindNodeByTag(string sNodeTag)
        {
            treeView1.Focus();
            ZX.Controls.TreeViewC tv = new ZX.Controls.TreeViewC();
            TreeNode[] TempTreeNode = tv.FindTreeNodeFromTag(this.treeView1, sNodeTag);
            //iTreeNodeIndex = TempTreeNode.Length;
            if (iTreeNodeIndex < TempTreeNode.Length)
            {

                this.treeView1.SelectedNode = TempTreeNode[iTreeNodeIndex];
                iTreeNodeIndex += 1;
            }
            else
            {
                iTreeNodeIndex = 0;
            }
        }

        public  void TreeListFillInfo()
        {
            try
            {
                DataTable treedata = DT;
                this.treeList1.Nodes.Clear();

                foreach (DataRow row in treedata.Rows)
                {
                    TreeListNode node = this.treeList1.AppendNode("sAreaID", null);
                    node.SetValue(GetTreeListCoumnName, row["sAreaName"].ToString());
                    //node.SetValue()
                    node.Tag = row["sParentAreaID"].ToString();
                    // TreeSon(node, row["sParentAreaID"].ToString());
                }
            }
            catch (Exception)
            {
                
                throw;
            }
               
           
        }

       // private void TreeSon(TreeListNode node, string ID)
       // {
       //     try
       //     {
       //         DataRow[] Rows = DT.Select("sParentAreaID='" + ID + "'");
       //         foreach (DataRow row in Rows)
       //         {
       //             TreeListNode sonnode = node.TreeList.AppendNode(tb, node);
       //             sonnode.SetValue(GetTreeListCoumnName, row["sAreaName"].ToString());
       //             sonnode.Tag = row["sAreaID"].ToString();
       //         }
       //     }
       //     catch (Exception ex)
       //     { }
       // }


        //获取Treelist树形内column名称
        public string GetTreeListCoumnName
        {
            get { return this.treeList1.Columns[0].FieldName; }
        }

        //设置Treelist树形的标题名
        public string SetTreeListColumnCaption
        {
            set { this.treeList1.Columns[0].Caption = value; }
        }







        private void BindRoot()
        {

            DataRow[] rows = DT.Select("sParentAreaID=''"); //取根

            foreach (DataRow dRow in rows)
            {

                Node rootNode = new Node();
                rootNode.Tag = dRow;
                rootNode.Text = dRow["sAreaName"].ToString();
                this.tr_Area.Nodes.Add(rootNode);
                BindChildAreas(rootNode);

            }
        }
       



        private void BindChildAreas(Node fNode)
        {

            DataRow dr = (DataRow)fNode.Tag; //父节点数据关联的数据行
            string fAreaId = (string)dr["sAreaID"];  //父节点ID
            DataRow[] rows = DT.Select("sParentAreaID='" + fAreaId+"'"); //子区域
            if (rows.Length == 0)   //递归终止，区域不包含子区域时
            {
                return;
            }

            foreach (DataRow dRow in rows)
            {

                Node node = new Node();
                node.Tag = dRow;
                node.Text = dRow["sAreaName"].ToString();

                //添加子节点

                fNode.Nodes.Add(node);

                //递归

               // BindChildAreas(node);

            }
        }





        

        private void FindNodeByNodeText(string sNodeText)
        {

            treeView1.Focus();
            ZX.Controls.TreeViewC tv = new ZX.Controls.TreeViewC();
            TreeNode[] TempTreeNode = tv.FindTreeNodeFromNodeText(this.treeView1, sNodeText);
            //iTreeNodeIndex = TempTreeNode.Length;
            if (iTreeNodeIndex < TempTreeNode.Length)
            {

                this.treeView1.SelectedNode = TempTreeNode[iTreeNodeIndex];
                iTreeNodeIndex += 1;
            }
            else
            {
                iTreeNodeIndex = 0;
            }

            
            



        }


        private void AddData()
        {

            //DataRow dr = ((DataTable)gc_Customer.DataSource).NewRow();
            //dr["tCreateDate"] = System.DateTime.Now;
            //ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            //dr["sCreateName"] = fp.pub_YHMC;
            //dr["tModifyDate"] = System.DateTime.Now;
            //dr["sModifierName"] = fp.pub_YHMC;
            //((DataTable)gc_Customer.DataSource).Rows.Add(dr);

        }

        private void DeleteData()
        {
        //    if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        this.gv_Customer.DeleteSelectedRows();

        //    }
        }
        private void SaveDate()
        {
            //gv_Customer.CloseEditor();
            //BindingSource binding = new BindingSource();
            //binding.DataSource = ((DataTable)gc_Customer.DataSource);
            //gc_Customer.DataSource = binding;
            //binding.EndEdit();

            //if (DT.GetChanges() != null)
            //{
            //    try
            //    {
            //        ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_Customer");
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }


            //}
            //LoadData();
        }

        private void Form_Main_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            
        }

        private void treeList1_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            
        }

        private void treeList1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tb_ZJF.Text = ZX.Class.StringOption.ChineseCap(this.textBox2.Text);

        }






    }
}

