using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(@"C:\Users\Itanio-PC24\Source\Repos\Itanio.SessaoAoVivo\Itanio.SessaoAoVivo.WebUI.Frontend\App_Data"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
