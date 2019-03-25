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
        private DBConn Conn;
        private int empHours;
        private MySqlConnection conn;
        private int? eID;

        public void EditMyHours(TextBox hoursBox, int? eID)
        {
            Conn = new DBConn();
            empHours = int.Parse(hoursBox.Text);
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

            MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "'WHERE employeeID = '" + this.eID + "';", conn);
            Console.WriteLine(cmd.ExecuteNonQuery());

            int currentHours = 0;
            String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd2 = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                currentHours = reader.GetInt16("hoursAvail");
            }
            Console.WriteLine(currentHours);
            if (empHours != currentHours)
            {
                String setHours = "UPDATE Employee SET hoursAvail = " + empHours + "WHERE employeeID = this.eID;";
                MySqlCommand cmd3 = new MySqlCommand(setHours, this.conn);          
                Console.WriteLine("Hours Updated");
               // Console.WriteLine(cmd2.ExecuteNonQuery());
                currentHours = empHours;
            }
          
        }
    }
}
