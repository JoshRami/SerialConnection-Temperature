using System;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    static class Program
    {
        /// <summary>
        /// Main entry for the app
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
