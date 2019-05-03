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
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT employeeID AS ID, fname AS First, lname AS Last, email AS Email, phone AS Phone, hoursAvail AS Hours, admin AS Admin, active AS Active FROM Employee ORDER BY active DESC;", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                emp.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            try
            {
                conn.Open();
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
                    MessageBox.Show("Duplicate Employee");
                }
                else
                {
                    //String insertEmp = "INSERT INTO Employee VALUES ('" + eID + "', '" + fname + "', '" + lname + "', '" + userName + "', SHA2('" + defaultPassword + "', CONCAT('$6$', SUBSTRING(SHA(RAND()), -16))), '" + phoneNumber + "', '" + hours + "', '" + isAdmin + "', '" + isActive + "');";
                    String insertEmp = "INSERT INTO Employee VALUES ('" + eID + "', '" + fname + "', '" + lname + "', '" + userName + "','" + defaultPassword + "', '" + phoneNumber + "', '" + hours + "', '" + isAdmin + "', '" + isActive + "');";
                    MySqlCommand cmd = new MySqlCommand(insertEmp, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            try
            {
                conn.Open();
                String upDateEmployee = "UPDATE Employee SET employeeID = '" + empID + "', fname = '" + fName + "', lname = '" + lName + "', email = '" + eMail + "', phone = '" + phoneNum + "', hoursAvail = '" + hoursAvail + "', admin = '" + isAdmin + "', active = '" + isActive + "' WHERE employeeID = '" + empID + "';";
                MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Employee Updated");
        } //end update employee

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
            try
            {
                conn.Open();
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

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } //end select employee

        public void ResetPassword(TextBox eID, TextBox newPass)
        {
            String pass = newPass.Text;
            String empID = eID.Text;
            try
            {
                conn.Open();
                String upDateEmployee = ("UPDATE Employee SET pssword = '" + pass + "' WHERE employeeID = '" + empID + "';");
                MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Password Updated");
        } //end reset password

    }//end class
}//end namespace
