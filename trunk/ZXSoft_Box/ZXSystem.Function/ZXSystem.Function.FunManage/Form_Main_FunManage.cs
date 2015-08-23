using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.FunManage
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_FunManage : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 

        public Form_Main_FunManage()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            DataGridView HRDG = FP.MyGridView;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);
            ZX.Controls.TreeViewC TV = new ZX.Controls.TreeViewC();
            gc_Common.Tag = "SYS_Functions";

            LoadData();
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_Common);
            
        }

        private void LoadData()
        {
            string strSql = "select * from SYS_Functions";
            DataTable DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            this.gc_Common.DataSource = DT;
           
        }
        private void btnDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Microsoft .NET 应用程序集(*.dll)|*.dll";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.txtFunDll.Text = System.IO.Path.GetFileName(OFD.FileName);//OFD.FileName;文件路径
                if (txtNameSpace.Text == "")
                {
                    ZX.Class.IO.FileOperate FO = new ZX.Class.IO.FileOperate();
                    this.txtNameSpace.Text = FO.GetFileName(OFD.FileName, false) + ".Form_Main_[添加后缀]";
                    this.txtFunID.Text = "Form_Main_[添加后缀]";
                }
            }
        }
        private void btnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "图标文件(*.ico)|*.ico";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.txtIcon.Text = OFD.FileName;
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Microsoft Windows 联机帮助文档(*.chm)|*.chm|所有文件(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.txtHelpPath.Text = OFD.FileName;
            }

        }
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "添加":
                    AddFunction();
                    break;
                case "修改":
                    Edit();
                    break;
                case "删除":
                   Delete();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Close();
                    break;
            }
        }

        private void Edit()
        {
            string deletesqlstr = "delete from SYS_FUNCTIONS where sFunctionID='"+this.txtFunID.Text+"'";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(deletesqlstr);
            string sqlstr = "insert into SYS_FUNCTIONS (sFunctionID,sFunctionName,sDllPath,sFunctionNameSpace,sFunctionICO,sHelpPath)"
                + " values('" + this.txtFunID.Text + "','" + this.txtFunName.Text + "','" + this.txtFunDll.Text + "','" + this.txtNameSpace.Text + "','" + this.txtIcon.Text + "','" + this.txtHelpPath.Text + "')";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(sqlstr);
            LoadData();
        }



        private void Delete()
        {
            string deletesqlstr = "delete from SYS_FUNCTIONS where sFunctionID='" + this.txtFunID.Text + "'";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(deletesqlstr);
            LoadData();
            this.txtFunID.Text = "";
            this.txtFunName.Text = "";
            this.txtFunDll.Text = "";
            this.txtIcon.Text = "";
            this.txtNameSpace.Text = "";
            this.txtHelpPath.Text = "";
        }

        private void AddFunction()
        {
            string sqlstr="insert into SYS_FUNCTIONS (sFunctionID,sFunctionName,sDllPath,sFunctionNameSpace,sFunctionICO,sHelpPath)"
                + " values('" + this.txtFunID.Text + "','" + this.txtFunName.Text + "','" + this.txtFunDll.Text + "','" + this.txtNameSpace.Text + "','" + this.txtIcon.Text + "','" + this.txtHelpPath.Text + "')";
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql(sqlstr);
            LoadData();
        }

        

        private void SaveFunctionNode()
        {
           
        }
        
        /// <summary>
        /// 验证输入的完整性
        /// </summary>
        /// <returns></returns>
        private bool VerifyText()
        {
            if (this.txtFunName.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// 针对添加、删除、修改功能，对文件进行复制删除等操作
        /// </summary>
        /// <param name="EditType">功能维护类型0为添加本级；1为添加下级；2为修改；-1为删除</param>
        private void SaveFileSet(int EditType)
        {
            
        }
       

        /// <summary>
        /// 关闭窗体时，将父窗体的Tab选项也关闭
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form_Main_FunManage_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Functions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            /////绘制行号
            //using (SolidBrush b = new SolidBrush(dgv_Functions.RowHeadersDefaultCellStyle.ForeColor))
            //{
            //    int linen = 0;
            //    linen = e.RowIndex + 1;
            //    string line = linen.ToString();
            //    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X+10, e.RowBounds.Location.Y + 5);
            //    SolidBrush B = new SolidBrush(Color.Red);

            //    //SolidBrush的构造函数：=new SolidBrush(Color color)
            //    /*DrawString方法：DrawString(string s,Font font,Brush brush,float x,float y)
            //             s：要绘制的字符串
            //             f：定义字符串的文本格式
            //     brush：确定所绘制的文本的颜色和纹理
            //             x：左上角的x坐标
            //             y：左上角的y坐标
            //     */
            //    //System.Globalization.CultureInfo.CurrentUICulture：提供区域性特定的格式设置信息



           // }
        }

        private void txtHelpPath_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void gc_Common_DoubleClick(object sender, EventArgs e)
        {
            this.txtFunID.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sFunctionID")).ToString().Trim();
            this.txtFunName.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sFunctionName")).ToString().Trim();
            this.txtFunDll.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sDllPath")).ToString().Trim();
            this.txtIcon.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sFunctionICO")).ToString().Trim();
            this.txtNameSpace.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sFunctionNameSpace")).ToString().Trim();
            this.txtHelpPath.Text = this.gv_Common.GetFocusedRowCellValue(gv_Common.Columns.ColumnByFieldName("sHelpPath")).ToString().Trim();
        }

        //private void dgv_Functions_DoubleClick(object sender, EventArgs e)
        //{
        //    if (dgv_Functions.Rows.Count == 0)
        //    { return; }
        //    if (this.dgv_Functions.SelectedCells.Count > 0)
        //    {
        //        this.txtFunID.Text = (string)dgv_Functions["sFunctionID", dgv_Functions.CurrentRow.Index].Value;
        //        this.txtFunName.Text = (string)dgv_Functions["sFunctionName", dgv_Functions.CurrentRow.Index].Value;
        //        this.txtFunDll.Text = (string)dgv_Functions["sDllPath", dgv_Functions.CurrentRow.Index].Value;
        //        this.txtIcon.Text = (string)dgv_Functions["sFunctionICO", dgv_Functions.CurrentRow.Index].Value;
        //        this.txtNameSpace.Text = (string)dgv_Functions["sFunctionNameSpace", dgv_Functions.CurrentRow.Index].Value;
        //        this.txtHelpPath.Text = (string)dgv_Functions["sHelpPath", dgv_Functions.CurrentRow.Index].Value; 
        //    }
        //}
    }
}

