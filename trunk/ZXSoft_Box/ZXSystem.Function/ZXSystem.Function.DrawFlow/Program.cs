﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZXSystem.Function.DrawFlow;

namespace ZXSystem.Function.SetServerComputer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main_DrawFlow());
        }
    }
}
