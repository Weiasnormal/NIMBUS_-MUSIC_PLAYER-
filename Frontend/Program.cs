﻿using NIMBUS__MUSIC_PLAYER_.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMBUS__MUSIC_PLAYER_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Nimbus());

           // PlayerState.BackgroundWorker.RunWorkerAsync();
        }
    }
}
