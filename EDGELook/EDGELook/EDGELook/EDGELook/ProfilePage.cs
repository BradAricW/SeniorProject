using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace EDGELook
{
    class ProfilePage
    {
        private int empHours;
        private MySqlConnection conn;
        private int? eID;

        public void EditMyHours(TextBox hoursBox, int? eID)
        {
            empHours = -1;
            try { empHours = int.Parse(hoursBox.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (empHours >= 0)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "'WHERE employeeID = '" + this.eID + "';", conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                conn.Close();
                /*int currentHours = 0;
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
                }*/
                MessageBox.Show("Hours Updated");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        public void Setup(MySqlConnection newConn, int? newEmpID)
        {
            conn = newConn;
            eID = newEmpID;
        }
        public void GetHours(TextBox hoursBox)
        {
            conn.Open();
            String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hoursBox.Text = reader.GetString("hoursAvail");
            }
            conn.Close();
        }
        public void GetEmail(TextBox emailBox)
        {
            conn.Open();
            String getEmail = "SELECT email FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd = new MySqlCommand(getEmail, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                emailBox.Text = reader.GetString("email");
            }
            conn.Close();
        }
        public void GetPhone(TextBox phoneBox)
        {
            conn.Open();
            String getPhone = "SELECT phone FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd = new MySqlCommand(getPhone, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                phoneBox.Text = reader.GetString("phone");
            }
            conn.Close();
        }
        public void ListProjects(DataGridView projectsGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select p.prjNo, p.Description from Project p, WorksOn w where p.prjNo = w.prjNo AND w.employeeID = '" + this.eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();
        }

        public void EditContact(TextBox emailBox, TextBox phoneBox)
        {
            String phoneNum = phoneBox.Text;
            String emailAdd = emailBox.Text;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET phone = '" + phoneNum + "'WHERE employeeID = '" + this.eID + "';", conn);
            Console.WriteLine(cmd.ExecuteNonQuery());
            MySqlCommand cmd2 = new MySqlCommand("UPDATE Employee SET email = '" + emailAdd + "'WHERE employeeID = '" + this.eID + "';", conn);
            Console.WriteLine(cmd2.ExecuteNonQuery());
            conn.Close();
            MessageBox.Show("Contact Information Updated");
        }
    }
}
