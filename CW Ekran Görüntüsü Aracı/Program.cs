using System;
using System.Windows.Forms;

namespace CW_Ekran_G�r�nt�s�_Arac�
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}