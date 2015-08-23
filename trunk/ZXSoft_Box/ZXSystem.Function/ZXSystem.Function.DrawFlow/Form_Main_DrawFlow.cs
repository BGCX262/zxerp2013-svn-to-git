using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZX.Controls.DotNetMagic.Controls;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ZX.ZXSystem.Win;

namespace ZXSystem.Function.DrawFlow
{
    public partial class Form_Main_DrawFlow : Form
    {
        public Form_Main_DrawFlow()
        {
            InitializeComponent();
            toolStripButtonImg.AllowDrop = true;
           // toolStripButtonImg.AllowDrop = true;

        }
        private void Form_Main_SetServerComputer_Load(object sender, EventArgs e)
        {
            LoadData();
            ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
            ZX.Win.SetToolBarIcon SBI = new ZX.Win.SetToolBarIcon();
            SBI.SetImage(Application.StartupPath + @"\Images\TooBarIco", this.ToolStrip1, FP.ToolStripitemDisplayStyle);


        }
        private void LoadData()
        {

        }
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "保存":
                    SaveFlow();
                    break;

                case "打开":
                    OpenFlow();
                    break;
                case "帮助":
                    break;
                case "关闭":
                    this.Tag = null;
                    this.Close();
                    break;
            }
        }
        private void SaveSet()
        {

        }

        private void Form_Main_SetServerComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
           SystemClass.ApplicationFormMain.CloseingForm(this);
        }

        private void zxPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string itemtype = e.Data.GetData(typeof(string)).ToString();
            if (itemtype == "Image")
            {
            //MessageBox.Show("dragdrop");
                try
                {
                    Point lefttoppoint = this.PointToScreen(this.zxPanel1.Location);


                    PaintUnit item =
                        new PaintUnit("未命名", Image.FromFile(Application.StartupPath + "\\Images\\未命名.BMP"),
                        ItemStatus.Actived,
                        //               new Point(e.X - lefttoppoint.X - 20 / 2, e.Y - lefttoppoint.Y - 20 / 2), new Pen(Color.Gray), new Font("微软雅黑", 12));
                         new Point(e.X - lefttoppoint.X - 40, e.Y - lefttoppoint.Y - 40), new Pen(Color.Gray), new Font(this.Font.FontFamily, 12, this.Font.Style | FontStyle.Bold));
                    // MessageBox.Show(e.X.ToString() + ":" + e.Y.ToString());
                    this.zxPanel1.PaintItems.Add(item);
                    this.zxPanel1.Refresh();
                }
                catch (Exception)
                {
                    
                    throw;
                }
           
            }

            if (itemtype == "Link")
            {
                try
                {
                    //MessageBox.Show("dragdrop");
                    Point lefttoppoint = this.PointToScreen(this.zxPanel1.Location);


                    PaintUnitLink item =
                        new PaintUnitLink("", Image.FromFile(Application.StartupPath + "\\Images\\箭头.png"),
                        ItemStatus.Actived,
                        //               new Point(e.X - lefttoppoint.X - 20 / 2, e.Y - lefttoppoint.Y - 20 / 2), new Pen(Color.Gray), new Font("微软雅黑", 12));
                         new Point(e.X - lefttoppoint.X - 40, e.Y - lefttoppoint.Y - 40), new Pen(Color.Gray), new Font(this.Font.FontFamily, 10, this.Font.Style | FontStyle.Bold));
                    // MessageBox.Show(e.X.ToString() + ":" + e.Y.ToString());
                    this.zxPanel1.PaintItems.Add(item);
                    this.zxPanel1.Refresh();
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
            }
        }

        private void zxPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }



        private void Savebutton_Click(object sender, EventArgs e)
        {
            SaveFlow();

        }



        private void SaveFlow()
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                SerializeObjectToFile(this.saveFileDialog1.FileName);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFlow();
        }

        private void OpenFlow()
        {
            this.openFileDialog1.Filter = "mpf|*.mpf";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.saveFileDialog1.FileName = this.openFileDialog1.FileName;

                    this.zxPanel1.PaintItems.Clear();
                    this.zxPanel1.PaintItems = UnSerializeObjectFromFile(this.openFileDialog1.FileName);
                    this.zxPanel1.Refresh();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        //<summary>
        //反序列化
        //</summary>
        //<param name="storefilename">文件名</param>
        //<returns></returns>
        public List<IPaintItem> UnSerializeObjectFromFile(string storefilename)
        {
            try
            {
                List<IPaintItem> offlineobject = null;

                IFormatter formatter = new BinaryFormatter();

                Stream writer = new FileStream(storefilename, FileMode.Open);// new IsolatedStorageFileStream(string.Concat(@"OBU\", storefilename), FileMode.OpenOrCreate, isoStore);
                writer.Seek(0, SeekOrigin.Begin);
                offlineobject = (List<IPaintItem>)formatter.Deserialize(writer);

                writer.Close();
                return offlineobject;
            }
            catch (Exception)
            {
                
                throw;
            }
               
           
           

        }

        /// <summary>
        /// 从本地存储反序列化业务对象
        /// </summary>
        /// <param name="storefilename">文件路径</param>
        /// <returns></returns>
        public void SerializeObjectToFile(string storefilename)
        {

            
            try
            {
                IFormatter formatter = new BinaryFormatter();


                // To write to a file, create a StreamWriter object.
                Stream writer = new FileStream(storefilename, FileMode.Create); //new StreamWriter( new IsolatedStorageFileStream(string.Concat(@"OBU\", obj.OffFileName), FileMode.OpenOrCreate, isoStore);

                // formatter.Serialize(writer, zxPanel1.PaintItems);
                formatter.Serialize(writer, this.zxPanel1.PaintItems);
                byte[] objbuffer = new byte[writer.Length];
                writer.Seek(0, SeekOrigin.Begin);
                writer.Read(objbuffer, 0, objbuffer.Length);
                writer.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            
           

           
        }

        private void toolStripButton7_MouseDown(object sender, MouseEventArgs e)
        {
            MaintoolStrip.DoDragDrop("Image", DragDropEffects.Link);
        }

        private void 设置名称ToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void zxPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.PointToClient(Control.MousePosition).ToString());
            //IPaintItem item = this.zxPanel1.GetItemAtPoint(e.Location);
            //if (item != null && item is PaintUnit)
            //{
            //    string itemname = ZX.Controls.DotNetMagic.Controls.InputBox.InputBox.ShowInputBox();
            //    item.ItemName = itemname;

            //}
        }

        private void zxPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Location.ToString());
        }

        private void contextMenuStrip_set_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 设置名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Point screenPoint = Control.MousePosition;
            //Point2 contextMenuPoint = this.contextMenuStrip_set.PointToClient(Control.MousePosition);
            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标

            //MessageBox.Show("鼠标坐标："+screenPoint.ToString());

            //MessageBox.Show("菜单坐标：" + contextMenuPoint.ToString());

            //MessageBox.Show("窗体坐标：" + formPoint.ToString());



            IPaintItem item = this.zxPanel1.GetItemAtPoint2(formPoint);
            if (item != null && item is PaintUnit)
            {
                string itemname = ZX.Controls.DotNetMagic.Controls.InputBox.InputBox.ShowInputBox();
                item.ItemName = itemname;

            }

        }

        private void MaintoolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 设置窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标



            IPaintItem item = this.zxPanel1.GetItemAtPoint2(formPoint);
            if (item != null && item is PaintUnit)
            {
                ZX.Win.FunctionParameter FP = (ZX.Win.FunctionParameter)this.Tag;
                FP.SqlQrystr = "select sFunctionID,sFunctionName,sFunctionNameSpace from SYS_Functions order by sfunctionID";
                Form f = SystemClass.ApplicationFormMain.LoadFunction("Form_Main_CommonQry", FP, null);
                Dictionary<string, string> Dic = (Dictionary<string, string>)f.Tag;
                if (Dic.ContainsKey("sFunctionID"))
                {
                    item.ItemSpace = Dic["sFunctionID"];
                }

                if (Dic.ContainsKey("sFunctionName"))
                {
                    //MessageBox.Show(Dic["功能名称"]);
                    item.ItemName = Dic["sFunctionName"];
                }

                //string sItemSpace =// ZX.Controls.DotNetMagic.Controls.InputBox.InputBox.ShowInputBox(item.ItemSpace);
                //item.ItemSpace = sItemSpace;

            }
        }

        private void 设置图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标
           
           
            //Point formPoint = this.PointToScreen(Control.MousePosition);

            IPaintItem item = this.zxPanel1.GetItemAtPoint2(formPoint);
            // MessageBox.Show("窗体坐标：" + formPoint.ToString());
            if (item != null && item is PaintUnit)
            {

                this.openFileDialog1.Filter = "*.png|*.png|*.bmp|*.bmp"; 
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(this.openFileDialog1.FileName);
                    item.ItemImage = img;
                }

            }

            if (item != null && item is PaintUnitLink)
            {

                this.openFileDialog1.Filter = "*.png|*.png|*.bmp|*.bmp";
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(this.openFileDialog1.FileName);
                    item.ItemImage = img;
                }

            }
        }

        private void 删除控件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标
            IPaintItem item = this.zxPanel1.GetItemAtPoint2(formPoint);
            if (item != null && item is PaintUnit)
            {


                this.zxPanel1.PaintItems.Remove(item);
                

            }
            if (item != null && item is PaintUnitLink)
            {


                this.zxPanel1.PaintItems.Remove(item);
               

            }
            this.zxPanel1.Refresh();


        }

        private void 设置名称ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标
            IPaintItem item = this.zxPanel1.GetItemAtPoint2(formPoint);
            if (item != null && item is PaintUnit)
            {


                string sName = ZX.Controls.DotNetMagic.Controls.InputBox.InputBox.ShowInputBox(item.ItemName);
                item.ItemName = sName;
                
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton5_MouseDown(object sender, MouseEventArgs e)
        {
            MaintoolStrip.DoDragDrop("Link", DragDropEffects.Link);
        }
    }
}
