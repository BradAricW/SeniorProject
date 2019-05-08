using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class AdminPage
    {
        //initialize variables and setup
        private MySqlConnection conn;

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        } //end setup

        //display functions
        public void DisplayEmployees(DataGridView emp)
        {
            conn.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT employeeID AS ID, fname AS First, lname AS Last, email AS Email, phone AS Phone, hoursAvail AS Hours, admin AS Admin, active AS Active FROM Employee ORDER BY active DESC;", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                emp.DataSource = table;
                emp.Columns[1].Width = 115;
                emp.Columns[2].Width = 115;
                emp.Columns[3].Width = 200;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end display employees

        //core functionality
        public void NewEmployee(TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, TextBox pass, NumericUpDown hours, CheckBox admin, CheckBox active)
        {
            String fname = firstName.Text;
            String lname = lastName.Text;
            String userName = email.Text;
            String phoneNumber = phone.Text;
            int isAdmin;
            if (admin.Checked)
            {
                isAdmin = 1;
            }
            else
            {
                isAdmin = 0;
            }
            int isActive;
            if (active.Checked)
            {
                isActive = 1;
            }
            else
            {
                isActive = 0;
            }

            String defaultPassword = pass.Text;
            int defaultHours = -1;
            try { defaultHours = (int)hours.Value; }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            String eID;
            eID = employeeID.Text;
            conn.Open();
            try
            {
                String dupId = null;
                String getEmpDup = "SELECT employeeID FROM Employee WHERE employeeID = '" + eID + "';";
                MySqlCommand cmd1 = new MySqlCommand(getEmpDup, this.conn);
                MySqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    dupId = reader.GetString("employeeID");
                }
                reader.Close();
                if (dupId != null)
                {
                    MessageBox.Show("Duplicate Employee: " + dupId);
                }
                else
                {
                    String insertEmp = "INSERT INTO Employee VALUES (?val1, ?val2, ?val3, ?val4, ?val5, ?val6, ?val7, ?val8, ?val9);";
                    MySqlCommand cmd = new MySqlCommand(insertEmp, conn);
                    cmd.Parameters.AddWithValue("?val1", eID);
                    cmd.Parameters.AddWithValue("?val2", fname);
                    cmd.Parameters.AddWithValue("?val3", lname);
                    cmd.Parameters.AddWithValue("?val4", userName);
                    cmd.Parameters.AddWithValue("?val5", defaultPassword);
                    cmd.Parameters.AddWithValue("?val6", phoneNumber);
                    cmd.Parameters.AddWithValue("?val7", defaultHours);
                    cmd.Parameters.AddWithValue("?val8", isAdmin);
                    cmd.Parameters.AddWithValue("?val9", isActive);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end new employee

        public void UpdateEmployee(TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, NumericUpDown hours, CheckBox admin, CheckBox active)
        {
            int isAdmin;
            if (admin.Checked)
            {
                isAdmin = 1;
            }
            else
            {
                isAdmin = 0;
            }

            int isActive;
            if (active.Checked)
            {
                isActive = 1;
            }
            else
            {
                isActive = 0;
            }

            String fName = firstName.Text;
            String lName = lastName.Text;
            String eMail = email.Text;
            String phoneNum = phone.Text;
            String empID = employeeID.Text;
            int hoursAvail = (int)hours.Value;
            conn.Open();
            try
            {
                String upDateEmployee = "UPDATE Employee SET employeeID = '" + empID + "', fname = '" + fName + "', lname = '" + lName + "', email = '" + eMail + "', phone = '" + phoneNum + "', hoursAvail = '" + hoursAvail + "', admin = '" + isAdmin + "', active = '" + isActive + "' WHERE employeeID = '" + empID + "';";
                MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            MessageBox.Show("Employee Updated");
        } //end update employee

        public void UpdateVacationStatus(String approval, String selectedEID, String selectedDate)
        {
            conn.Open();
            try
            {               
                if (selectedDate == null)
                {
                    MessageBox.Show("Date not Selected");
                }
                else
                {
                    String[] dateTime = selectedDate.Split(' ');
                    String date = dateTime[0];
                    String[] dateSeperated = date.Split('/');
                    String month = dateSeperated[0];
                    String day = dateSeperated[1];
                    String year = dateSeperated[2];
                    String newDateFormat = "" + year + "-" + month + "-" + day + "";
                    MySqlCommand cmd = new MySqlCommand("UPDATE Vacation SET status = '" + approval + "' WHERE employeeID = '" + selectedEID + "' AND startDate = '" + newDateFormat + "';", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

        public void DeleteVacation(String selectedEID, String startDate)
        {
            conn.Open();
            try
            {
                if (startDate == null)
                {
                    MessageBox.Show("Date not Selected");
                }
                else
                {
                    String[] dateTime = startDate.Split(' ');
                    String date = dateTime[0];
                    String[] dateSeperated = date.Split('/');
                    String month = dateSeperated[0];
                    String day = dateSeperated[1];
                    String year = dateSeperated[2];
                    String newDateFormat = "" + year + "-" + month + "-" + day + "";
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Vacation WHERE employeeID = '" + selectedEID + "' AND startDate = '" + newDateFormat + "';", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }//end remove vacation

            public void SelectEmployee(String selectedEID, TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, NumericUpDown hours, CheckBox admin, CheckBox active)
        {
            int eID = -1;
            try { eID = int.Parse(selectedEID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int testAdmin = 0;
            int testActive = 0;
            conn.Open();
            try
            {
                String getEmployeeInfo = "SELECT * FROM Employee WHERE employeeID = '" + selectedEID + "';";
                MySqlCommand cmd = new MySqlCommand(getEmployeeInfo, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    employeeID.Text = dr.GetString(0);
                    firstName.Text = dr.GetString(1);
                    lastName.Text = dr.GetString(2);
                    email.Text = dr.GetString(3);
                    phone.Text = dr.GetString(5);
                    hours.Value = dr.GetDecimal(6);
                    testAdmin = dr.GetInt16(7);
                    testActive = dr.GetInt16(8);
                }
                dr.Close();
                if (testAdmin == 1)
                {
                    admin.Checked = true;
                }
                else
                {
                    admin.Checked = false;
                }
                if (testActive == 1)
                {
                    active.Checked = true;
                }
                else
                {
                    active.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end select employee

        public void ResetPassword(TextBox eID, TextBox newPass)
        {
            String pass = newPass.Text;
            String empID = eID.Text;
            conn.Open();
            try
            {
                String upDateEmployee = ("UPDATE Employee SET pssword = '" + pass + "' WHERE employeeID = '" + empID + "';");
                MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            MessageBox.Show("Password Updated");
        } //end reset password
    }//end class
}//end namespace
