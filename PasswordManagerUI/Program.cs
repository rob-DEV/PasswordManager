using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManagerUI
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


            if (Data.FileIO.isFirstTimeUser())
                Application.Run(new Forms.PM_CREATEUSER());
            else
                Application.Run(new Forms.APPLOGIN());
        }
    }
}
