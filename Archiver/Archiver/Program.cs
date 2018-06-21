using Archiver.Model;
using Archiver.Presenter;
using Archiver.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IArchiverModel fillModel = new ArchiverModel();
            View.Archiver archiver = new View.Archiver();
            ArchiverPresenter presenter = new ArchiverPresenter(archiver, fillModel);
            Application.Run(archiver);
        }
    }
}
