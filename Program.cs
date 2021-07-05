using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_app9.View;

namespace WinForm_app9
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

            var repository = new Repository.CustomerRepository(Application.StartupPath);
            var view = new View.CustomerForm();
            var presenter = new Presenter.CustomerPresenter(view,repository);
            Application.Run(view);
        }
    }
}
