using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeLook1
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
            Application.Run(new AddProjectPage());
            Application.Run(new ProfilePage());
            Application.Run(new EmployeePage());
            Application.Run(new LoginPage());
            Application.Run(new HomePage());
            Application.Run(new TaskBar());
        }
    }
}
