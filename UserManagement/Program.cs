﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
[assembly: SuppressIldasm]
namespace UserManagement
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
            Application.Run(new frmUserManagement());
            //Application.Run(new frmForgetPassword());
        }
    }
}