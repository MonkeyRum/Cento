using Cento.Core.Controllers;
using Cento.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cento
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

            IMainController controller = new MainController(new MainView());

            // Quick cast because I know we're using WinForms
            Application.Run((Form)controller.View);
        }
    }
}
