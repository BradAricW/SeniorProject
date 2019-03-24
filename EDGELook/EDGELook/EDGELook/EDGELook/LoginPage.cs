using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class LoginPage
    {
        private string email;
        private string password;
        private MySqlConnection conn;
        private DBConn Conn;
        private int? result;
        private int success;
        private int? eID;

        public int? Login (TextBox emailBox, TextBox passwordBox)
        {

            Conn = new DBConn();
            email = emailBox.Text;
            password = passwordBox.Text;
            String connString = Conn.connectionSetUp();
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + email + "' AND pssword = '" + password + "';";
            MySqlCommand cmd = new MySqlCommand(getLogin, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eID = reader.GetInt16("employeeID");
            }
            if (eID == null)
            {
                Console.WriteLine("Not valid login");
            }
            else
                Console.WriteLine("Logged in");
            /*if (result == null)
                success = 0;
            else
                success = 1;
            return success;*/
            return eID;
        }
    }
}
