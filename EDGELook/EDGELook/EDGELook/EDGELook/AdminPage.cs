using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class AdminPage
    {
        private MySqlConnection conn;
        public void NewEmployee(TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, TextBox admin)
        {
            string fname = firstName.Text;
            string lname = lastName.Text;
            string userName = email.Text;
            string phoneNumber = phone.Text;
            int isAdmin = 0;
            string defaultPassword = "password";
            int defaultHours = 0;
            
            int eID = -1;
            try { eID = int.Parse(employeeID.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conn.Open();
            string dupId = null;
            string getEmpDup = "SELECT  employeeID FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd1 = new MySqlCommand(getEmpDup, this.conn);
            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                dupId = reader.GetString("employeeID");
            }

            if (dupId != null)
            {
                MessageBox.Show("Duplicate Employee");
            }
            else
            {
                string insertEmp = "INSERT INTO Employee VALUES (" + eID + ", '" + fname + "', '" + lname + "', '" + userName + "', '" + defaultPassword + "', '" + phoneNumber + "', " + defaultHours + ", " + isAdmin + ");";
                MySqlCommand cmd = new MySqlCommand(insertEmp, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
            }
            conn.Close();
        }
        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;          
        }
    }
}
