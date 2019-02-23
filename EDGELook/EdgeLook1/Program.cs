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
        [STAThread]
        static void Main()
        {
            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            //MySqlConnection conn = new MySqlConnection(connString);
            //MySqlCommand command = conn.CreateCommand();
            //command.CommandText = "select * from Employee";

            //try
            //{
            //    //conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //MySqlDataReader reader = command.ExecuteReader();
            //String test = "";
            //while (reader.Read())
            //{
            //    test += reader["fname"].ToString() + "\n";
            //}
            //MessageBox.Show(test);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddProjectPage());
            //Application.Run(new ProfilePage());
            //Application.Run(new EmployeePage());
            //Application.Run(new LoginPage());
            //Application.Run(new HomePage());
            Application.Run(new EditProjectPage());
            //conn.Close();
        }
    }
}
