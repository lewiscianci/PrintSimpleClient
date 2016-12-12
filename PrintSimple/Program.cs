using System;
using System.Windows.Forms;
using log4net.Config;
using PrintSimple.Properties;

namespace PrintSimple
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.PrintServers == null)
                Application.Run(new Startup());
            else
                Application.Run(new MainWindow());
        }
    }
}