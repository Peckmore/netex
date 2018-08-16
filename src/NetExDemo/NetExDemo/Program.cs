﻿using NetExDemo.ProgressDialog;
using System;
using System.Windows.Forms;

namespace NetExDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgressDialogForm());
        }
    }
}