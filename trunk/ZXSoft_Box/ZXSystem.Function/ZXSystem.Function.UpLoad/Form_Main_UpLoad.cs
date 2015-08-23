using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.UpLoad
{
    /// <summary>
    /// 实例类
    /// </summary>
    public partial class Form_Main_UpLoad : Form
    {
        /// <summary>
        /// 功能入口
        /// </summary>
        /// 
        DataTable DT;
        public Form_Main_UpLoad()
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
            gc_UpLoad.Tag = "SYS_DOC";

            LoadData();
            this.gv_UpLoad.OptionsView.ColumnAutoWidth = false;
            ZX.Controls.DataGridViewEx.GridControlEx.GetDatagridviewFromDB("通用", gc_UpLoad);

        }

        private void LoadData()
        {
            string strSql = "select * from SYS_DOC";
            DT = ZX.ZXSystem.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            this.gc_UpLoad.DataSource = DT;


        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "增加":
                    AddData();
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
            if (ccb_Location.Text == "") return;
           
            FileInfo fi = new FileInfo(txt_FilePath.Text);
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("delete from  Sys_Doc where Path='" + ccb_Location.Text + "' and FileName='" + fi.Name + "'");
            FileStream fs = new FileStream(txt_FilePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@Path",ccb_Location.Text),
              new SqlParameter ("@FileName",fi.Name),
              new SqlParameter ("@ModifyTime",fi.LastWriteTime.ToString()),
              new SqlParameter ("@UpdateTime",System.DateTime.Now.ToString()),
              new SqlParameter ("@Memo",""),
              //文件上传
              new SqlParameter("@Document", imgBytesIn),     
            };
            ZX.ZXSystem.DBUtility.DbHelperSQL.ExecuteSql("insert into Sys_Doc(Path,FileName,ModifyTime,UpdateTime,Memo,Document) values(@Path,@FileName,@ModifyTime,@UpdateTime,@Memo,@Document)", para);

            LoadData();

        }

        private void DeleteData()
        {
            if (MessageBox.Show("确认删除？删除不可恢复！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gv_UpLoad.DeleteSelectedRows();
                SaveDate();

            }
        }
        private void SaveDate()
        {
            gv_UpLoad.CloseEditor();
            BindingSource binding = new BindingSource();
            binding.DataSource = ((DataTable)gc_UpLoad.DataSource);
            gc_UpLoad.DataSource = binding;
            binding.EndEdit();

            if (DT.GetChanges() != null)
            {
                try
                {
                    ZX.ZXSystem.DBUtility.DbHelperSQL.UpdateTable(DT.GetChanges(), "SYS_DOC");
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

        private void gc_UpLoad_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void gc_UpLoad_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);


            string s = "";

            foreach (string File in FileList)
                s = s + " " + File;
            txt_FilePath.Text = s;
        }

        private void txt_FilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; else e.Effect = DragDropEffects.None; 
        }

        private void txt_FilePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);


            string s = "";

            foreach (string File in FileList)
                s = s + " " + File;
            txt_FilePath.Text = s;
        }






    }
}

