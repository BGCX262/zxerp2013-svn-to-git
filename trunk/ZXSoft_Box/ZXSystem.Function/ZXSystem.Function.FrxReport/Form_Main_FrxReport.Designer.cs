namespace ZXSystem.Function.FrxReport
{
    partial class Form_Main_FrxReport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.report = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.ReportResourceString = "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ReportInfo.Created=\"08/18/2012 1" +
                "0:50:05\" ReportInfo.Modified=\"09/15/2012 13:41:44\" ReportInfo.CreatorVersion=\"1." +
                "2.47.0\">\r\n  <Dictionary/>\r\n</Report>\r\n";
            // 
            // Form_Main_FrxReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 123);
            this.Name = "Form_Main_FrxReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "系统报表";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_Customer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Report report;


    }
}

