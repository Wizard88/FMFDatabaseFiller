using System;
using System.Windows.Forms;

namespace FMFDatabaseFiller
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DAL.TableCase.Scope.Factory = new DAL.TableCase.Factory();
            DAL.ExternalDatabase.Scope.Factory = new DAL.ExternalDatabase.Factory();
            DAL.Submodules.Scope.Factory = new DAL.Submodules.Factory();

            Application.Run(new DatabaseFiller());
        }
    }
}
