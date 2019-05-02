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
                MessageBox.Show("Hours Updated");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //for editing those hours, temporary pid passed in
        public void EditProjectHours(TextBox newHoursBox, TextBox projectTextBox)
        {
            string pid = projectTextBox.Text;
            int prjHours = -1;
            try { prjHours = int.Parse(newHoursBox.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if(empHours >= 0)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE WorksOn SET hours = '" + prjHours + "' WHERE emplopyeeID = '" + eID + "' AND prjNo = '" + pid + "';", conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                conn.Close();
                MessageBox.Show("Hours Updated");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        public void EditVacation(DateTimePicker newStartDate, DateTimePicker newEndDate)
        {
            string startDate = newStartDate.Text;
            string endDate = newEndDate.Text;
            conn.Open();

            string dupId = null;
            String getVacDup = "SELECT  employeeID FROM Vacation WHERE employeeID = '" + this.eID + "' AND startDate = '" + startDate + "';";
            MySqlCommand cmd1 = new MySqlCommand(getVacDup, this.conn);
            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                dupId = reader.GetString("employeeID");
            }
            reader.Close();

            if (dupId != null)
            {
                MessageBox.Show("Duplicate Vacation");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT into Vacation VALUES(" + eID + ", '" + startDate + "','" + endDate + "');", conn);
                Console.WriteLine(cmd.ExecuteNonQuery());                
                MessageBox.Show("Vacation Days Created");
            }
            conn.Close();
        }

        public void RemoveVacation(string startDate)
        {
            conn.Open();
            MessageBox.Show(startDate);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Vacation WHERE employeeID = " + eID + " AND startDate = '" + startDate + "';", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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
        public void GetName(TextBox fName, TextBox lName)
        {
            conn.Open();
            String getFirst = "SELECT fname FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd = new MySqlCommand(getFirst, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fName.Text = reader.GetString("fname");
            }
            reader.Close();
            String getLast = "SELECT lname FROM Employee WHERE employeeID = '" + this.eID + "';";
            cmd = new MySqlCommand(getLast, this.conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lName.Text = reader.GetString("lname");
            }
            conn.Close();
        }
        public void ListProjects(DataGridView projectsGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select p.prjNo AS ID, p.Description, w.hours AS Hours from Project p, WorksOn w where p.prjNo = w.prjNo AND w.employeeID = '" + this.eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();           
        }

        public void ListVacations(DataGridView vacationGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select startDate AS Start, endDate AS End from Vacation where employeeID = '" + this.eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            vacationGrid.DataSource = table;
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
        public Boolean GetAdmin()
        {
            Boolean isAdmin = false;
            int result = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT admin FROM Employee WHERE employeeID = '" + this.eID + "';", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt16("admin");
            }
            conn.Close();
            if(result == 1)
            {
                isAdmin = true;              
            }
            return isAdmin;
        }
        public void GetProjHours(String prjNo, TextBox prjHours)
        {
            int hours = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT hours FROM WorksOn WHERE prjNo = '" + prjNo + "' AND employeeID = '" + this.eID + "';", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hours = reader.GetInt16("hours");
            }
            conn.Close();
            prjHours.Text = hours.ToString();
        }
    }
}
