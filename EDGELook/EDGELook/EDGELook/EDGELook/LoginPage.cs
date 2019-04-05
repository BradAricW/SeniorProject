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
        private int? eID;

        public int? Login (TextBox emailBox, TextBox passwordBox)
        {
            email = emailBox.Text;
            password = passwordBox.Text;
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
                MessageBox.Show("Not valid login");
            }
            else
                Console.WriteLine("Logged in");
            conn.Close();
            return eID;
        }
        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        }
    }
}
