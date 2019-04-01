using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class ProfilePage
    {
        private int myHours;
        private int empHours;
        private MySqlConnection conn;
        private int? eID;

        public void EditMyHours(TextBox hoursBox, int? eID)
        {
            empHours = int.Parse(hoursBox.Text);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "'WHERE employeeID = '" + this.eID + "';", conn);
            Console.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
            int currentHours = 0;
            String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                currentHours = reader.GetInt16("hoursAvail");
            }
            Console.WriteLine(currentHours);
            conn.Close();
            if (empHours != currentHours)
            {
                conn.Open();
                String setHours = "UPDATE Employee SET hoursAvail = " + empHours + "WHERE employeeID = this.eID;";
                MySqlCommand cmd3 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine("Hours Updated");
                Console.WriteLine(cmd3.ExecuteNonQuery());
                currentHours = empHours;
                conn.Close();
            }

        }
        public void Setup(MySqlConnection newConn, int? newEmpID)
        {
            conn = newConn;
            eID = newEmpID;
        }
        public void GetHours(TextBox hoursBox)
        {

            String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
            /*MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hoursBox.Text = reader.GetString("hoursAvail");
            }*/

        }
    }
}
