﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summa >
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
