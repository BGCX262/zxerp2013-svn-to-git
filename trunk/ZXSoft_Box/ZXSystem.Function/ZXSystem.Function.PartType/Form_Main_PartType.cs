using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.PartType
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_PartType : Form
    {
        DataTable DT;
        /// <summary>
        /// 功能入口
        /// </summary>
        public Form_Main_PartType()
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
            dgv_Common.Tag = "Bas_PartType";
            dgv_Common.AllowUserToAddRows = false;
            gc_Common.Tag = "Bas_PartType";

            LoadData();
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);
        }

        private void LoadData()
        {
            string strSql = "select * from Bas_PartType";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            gc_Common.DataSource = DT;
            
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
                case "箱型图片":
                    ModifyPicture();
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

        private void ModifyPicture()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "图片 (*.png)|*.png|图片(*.bmp)|*.bmp";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.dgv_Common.CurrentRow.Cells["Picture"].Value = Image.FromFile(OFD.FileName);
            }

            //this.dgv_Common.CurrentRow.Cells["Picture"].Value = Image.FromFile(Application.StartupPath + "\\Images\\未命名.BMP");
        }

        private void AddData()

        {

            DataRow dr = ((DataTable)gc_Common.DataSource).NewRow();
            dr["CreateDate"] = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = (ZX.Win.FunctionParameter)this.Tag;
            dr["CreateName"] = fp.pub_sUserNameByChinese;
            dr["ModifyDate"] = System.DateTime.Now;
           
            dr["ModifierName"] = fp.pub_sUserNameByChinese;
            ((DataTable)gc_Common.DataSource).Rows.Add(dr);
            
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

            BindingSource binding=new BindingSource();
            binding.DataSource = ((DataTable)gc_Common.DataSource);
            gc_Common.DataSource = binding;
            binding.EndEdit();         



            if (DT.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "Bas_PartType");
                }
                catch (Exception)
                {
                    
                    throw;
                }

               
            }
            LoadData();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void dgv_Common_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["CreateDate"].Value = System.DateTime.Now;
            e.Row.Cells["ModifyDate"].Value = System.DateTime.Now;
            ZX.Win.FunctionParameter fp = new ZX.Win.FunctionParameter();
            fp = (ZX.Win.FunctionParameter)this.Tag;
            
               
                e.Row.Cells["ModifierName"].Value=fp.pub_sUserNameByChinese;

            if (e.Row.Cells["CreateName"].Value==null)
            {
                
                e.Row.Cells["CreateName"].Value = fp.pub_sUserNameByChinese;
            }
        }






    }
}

