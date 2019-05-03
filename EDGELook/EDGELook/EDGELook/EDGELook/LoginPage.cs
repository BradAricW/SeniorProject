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
        private String email;
        private String password;
        private MySqlConnection conn;
        private String eID;

        public String Login (TextBox emailBox, TextBox passwordBox)
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

            String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + email + "' AND BINARY pssword = '" + password + "';";
            MySqlCommand cmd = new MySqlCommand(getLogin, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eID = reader.GetString("employeeID");
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
