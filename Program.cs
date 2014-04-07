using System;
using System.Windows.Forms;

namespace ClipQR
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

            Form qrForm = new QRform();

            Application.Run();
        }
    }
}
