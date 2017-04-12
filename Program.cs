﻿using CMNNPM.BM1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMNNPM
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
            Application.Run(new Quản_lý());
            Application.Run(new BM1_tiendung());
            Application.Run(new BM1_hieuqua());
            Application.Run(new BM1_dungdan());
            Application.Run(new BM1_tudo());
        }
    }
}
