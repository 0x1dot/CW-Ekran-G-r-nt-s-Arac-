using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CW_Ekran_G�r�nt�s�_Arac�
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
            Application.Run(new ControlPanel());
        }
    }
}