using System;
using System.Windows.Forms;

using KeLi.Gobang.App.Forms;

namespace KeLi.Gobang.App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
