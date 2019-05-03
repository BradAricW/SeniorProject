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
        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        }

        private MySqlConnection conn;
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
            String dupId = null;
            String getEmpDup = "SELECT  employeeID FROM Employee WHERE employeeID = '" + eID + "';";
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
                String insertEmp = ("INSERT INTO Employee VALUES ('" + eID + "', '" + fname + "', '" + lname + "', '" + userName + "', '" + defaultPassword + "', '" + phoneNumber + "', '" + hours + "', '" + isAdmin + "', '" + isActive + "');");
                MySqlCommand cmd = new MySqlCommand(insertEmp, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added");
            }
            conn.Close();
        }

        public void DisplayEmployees(DataGridView emp)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select employeeID as ID, fname as First, lname as Last, email as Email, phone as Phone, hoursAvail as Hours, admin as Admin, active as Active from Employee ORDER BY active DESC;", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            emp.DataSource = table;
        }

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
            String upDateEmployee = ("UPDATE Employee SET employeeID = '" + empID + "', fname = '" + fName + "', lname = '" + lName + "', email = '" + eMail + "', phone = '" + phoneNum + "', hoursAvail = '" + hoursAvail + "', admin = '" + isAdmin + "', active = '" + isActive + "' WHERE employeeID = '" + empID + "';");
            MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee Updated");
        }
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
            String getEmployeeInfo = "select * from Employee where employeeID = '" + selectedEID + "';";
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

        public void ResetPassword(TextBox eID, TextBox newPass)
        {
            String pass = newPass.Text;
            String empID = eID.Text;
            conn.Open();
            String upDateEmployee = ("UPDATE Employee SET pssword = '" + pass + "' WHERE employeeID = '" + empID + "';");
            MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Password Updated");
        }

    }
}
