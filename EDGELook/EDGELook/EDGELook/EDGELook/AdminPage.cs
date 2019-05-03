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
        private MySqlConnection conn;
        public void NewEmployee(TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, TextBox pass, NumericUpDown hours, CheckBox admin)
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
            
            String defaultPassword = pass.Text;
            int defaultHours = -1;
            try { defaultHours = (int)hours.Value; }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int eID = -1;
            try { eID = int.Parse(employeeID.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
                String insertEmp = "INSERT INTO Employee VALUES (" + eID + ", '" + fname + "', '" + lname + "', '" + userName + "', SHA2('" + defaultPassword + "', CONCAT('$6$', SUBSTRING(SHA(RAND()), -16))), '" + phoneNumber + "', " + defaultHours + ", " + isAdmin + ", " + 1 + ");";
                MySqlCommand cmd = new MySqlCommand(insertEmp, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
            }
            conn.Close();
        }
        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;          
        }
        public void RemoveEmployee(String employeeID)
        {
            int employeeRem = -1;
            try { employeeRem = int.Parse(employeeID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Open();
            if (employeeRem == -1)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                String deleteEmployee = "update Employee set active = 0 WHERE employeeID = '" + employeeRem + "';";
                MySqlCommand cmd = new MySqlCommand(deleteEmployee, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                MessageBox.Show("Employee " + employeeID + "set to inactive. They will still appear in the list of employees, but they cannot be assigned to projects.");
            }
            conn.Close();
        }

        public void DisplayEmployees(DataGridView emp)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select employeeID as ID, fname as First, lname as Last, email as Email, phone as Phone, hoursAvail as Hours, admin as Admin from Employee;", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            emp.DataSource = table;
            emp.Columns[0].Width = 50;
            emp.Columns[1].Width = 90;
            emp.Columns[2].Width = 90;
            emp.Columns[3].Width = 150;
            emp.Columns[4].Width = 100;
            emp.Columns[5].Width = 50;
            emp.Columns[6].Width = 45;
        }

        public void UpdateEmployee(String selectedEID, TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, NumericUpDown hours, CheckBox admin)
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

            String fName = firstName.Text;
            String lName = lastName.Text;
            String eMail = email.Text;
            String phoneNum = phone.Text;
            int empId = Int32.Parse(employeeID.Text);
            int hoursAvail = (int)hours.Value;

            conn.Open();
                String upDateEmployee = ("UPDATE Employee SET employeeID = '" + empId +
                                                            "', fname = '" + fName +
                                                            "', lname = '" + lName +
                                                            "', email = '" + eMail +
                                                            "', phone = '" + phoneNum +
                                                            "', hoursAvail = '" + hoursAvail +
                                                            "', admin = '" + isAdmin +
                                                            "' WHERE employeeID = '" + selectedEID + "';");
                MySqlCommand cmd = new MySqlCommand(upDateEmployee, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }
        public void SelectEmployee(String selectedEID, TextBox employeeID, TextBox firstName, TextBox lastName, TextBox email, TextBox phone, NumericUpDown hours, CheckBox admin)
        {
            int eID = -1;
            try { eID = int.Parse(selectedEID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int testHours = 0;
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
                testHours = dr.GetInt16(7);
            }
            dr.Close();
            if (testHours == 1)
            {
                admin.Checked = true;
            }
            else
            {
                admin.Checked = false;
            }
            
            conn.Close();
        }

    }
}
