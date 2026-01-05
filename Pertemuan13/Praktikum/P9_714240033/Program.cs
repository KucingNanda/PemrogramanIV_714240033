using P9_714240033.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace P9_714240033
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.License.SetNonCommercialPersonal("ULBI");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.StartUp());
            Application.Run(new view.FormLogin());
        }
    }
}
