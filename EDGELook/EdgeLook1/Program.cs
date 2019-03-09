using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace EdgeLook1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            //string server = "athena";
            //string database = "sevenwonders";
            //string uid = "sevenwonders";
            //string password = "sw_db";
            //string connstring = "server=" + server + ";" + "database=" +
            //database + ";" + "uid=" + uid + ";" + "password=" + password + ";";


            //MySqlConnection conn = new MySqlConnection(connstring);
            //MySqlCommand command = conn.CreateCommand();
            //command.CommandText = "select * from employee";

            //try
            //{
            //    conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddProjectPage());
            Application.Run(new AddProjectPage());
            //Application.Run(new ProfilePage());
            //Application.Run(new EmployeePage());
            //Application.Run(new LoginPage());
            //Application.Run(new HomePage());
            //Application.Run(new EditProjectPage());
            //conn.Close();
        }
    }
}
