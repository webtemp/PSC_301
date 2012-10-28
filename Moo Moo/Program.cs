using System;
using System.Windows.Forms;

namespace Moo_Moo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow main = new MainWindow();
            Application.Run(main);
        }
    }
}
