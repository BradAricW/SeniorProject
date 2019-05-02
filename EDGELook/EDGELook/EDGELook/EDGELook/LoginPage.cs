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

            String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + email + "' AND BINARY pssword = '" + password + "';";
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
        //This only works after the user logs in and has a connection set up
        public void ChangePassword(TextBox newPasswordBox)
        {
            String newPassword = newPasswordBox.Text;
            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
            }
            else
            {
                conn.Open();
                String setPassword = "UPDATE EMPLOYEE SET pssword = '" + newPassword + "' WHERE employeeID = " + eID + ";";
                MySqlCommand cmd = new MySqlCommand(setPassword, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                conn.Close();
            }
        }
    }
}
