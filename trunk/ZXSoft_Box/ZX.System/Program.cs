using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZX.ZXSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DevExpress.XtraBars.Localization.BarLocalizer.Active = new DevExpress.LocalizationCHS.XtraBarsLocalizer();
           // DevExpress.XtraBars.Localization.BarLocalizer.Active = new DevExpress.LocalizationCHS.XtraBarsLocalizer();
            //DevExpress.XtraCharts.Localization.ChartLocalizer.Active = new DevExpress.LocalizationCHS.XtraChartsLocalizer();
            DevExpress.XtraEditors.Controls.Localizer.Active = new DevExpress.LocalizationCHS.XtraEditorsLocalizer();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new DevExpress.LocalizationCHS.XtraGridLocalizer();
            //DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new DevExpress.LocalizationCHS.XtraLayoutLocalizer();
           // DevExpress.XtraNavBar.NavBarLocalizer.Active = new DevExpress.LocalizationCHS.XtraNavBarLocalizer();
           // DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer.Active = new DevExpress.LocalizationCHS.XtraPivotGridLocalizer();
           // DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.XtraPrintingLocalizer();
           // DevExpress.XtraReports.Localization.ReportLocalizer.Active = new DevExpress.LocalizationCHS.XtraReportsLocalizer();
           // DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.XtraSchedulerLocalizer();
            //DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new DevExpress.LocalizationCHS.XtraTreeListLocalizer();
            //Application.Run(new Test());

            //Form_Login frm_Login = new Form_Login();
            //frm_Login.ShowDialog();


            if (args.Length == 0)
            {

                Form_Login frm_Login = new Form_Login();
                frm_Login.ShowDialog();
                Form_Main frm_Main = new Form_Main();
                frm_Main.Tag = frm_Login.Tag;
                frm_Main.ShowDialog();

            }

            else
            {
                //带参数启动
                Form_Login frm_Login = new Form_Login(args);
                frm_Login.ShowDialog();


                //Application.Run(new Form_Login(args));
                Form_Main frm_Main = new Form_Main();
                frm_Main.Tag = frm_Login.Tag;
                frm_Main.ShowDialog();

            }






          
          
        }
    }
}
