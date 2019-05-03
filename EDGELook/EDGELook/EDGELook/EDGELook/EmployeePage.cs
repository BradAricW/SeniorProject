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
    class EmployeePage
    {
        //initialize variables and setup
        private MySqlConnection conn;
        private String eID;

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        } //end setup

        public void SetID(String newEmpID)
        {
            eID = newEmpID;
        } //end set ID

        public void GetHours(TextBox hoursBox)
        {
            conn.Open();
            String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hoursBox.Text = reader.GetString("hoursAvail");
            }
            conn.Close();
        } //end get hours

        public void GetEmail(TextBox emailBox)
        {
            conn.Open();
            String getEmail = "SELECT email FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd = new MySqlCommand(getEmail, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                emailBox.Text = reader.GetString("email");
            }
            conn.Close();
        } //end get email

        public void GetName(TextBox fName, TextBox lName)
        {
            conn.Open();
            String getName = "SELECT fname, lname FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd = new MySqlCommand(getName, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fName.Text = reader.GetString("fname");
                lName.Text = reader.GetString("lname");
            }
            conn.Close();
        } //end get name

        public void GetPhone(TextBox phoneBox)
        {
            conn.Open();
            String getPhone = "SELECT phone FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd = new MySqlCommand(getPhone, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                phoneBox.Text = reader.GetString("phone");
            }
            conn.Close();
        } //end get phone

        //display
        public void ListProjects(DataGridView projectsGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select P.prjNo AS 'Project #', P.Description FROM Project P, WorksOn W WHERE P.prjNo = W.prjNo AND W.employeeID = '" + eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();
        } //end projects display

        public void NameDisplay(Label employeeName)
        {
            conn.Open();
            String getName = "SELECT fname, lname FROM Employee WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd = new MySqlCommand(getName, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employeeName.Text = reader.GetString("fname") + " " + reader.GetString("lname");
            }
            conn.Close();
        } //end name display

        public void ListEmployees(DataGridView employeeGrid, String eID)
        {
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT employeeID AS ID, fname AS First, lname AS Last, active AS Active FROM Employee ORDER BY active DESC;", conn); 
            DataTable table = new DataTable();
            da.Fill(table);
            employeeGrid.DataSource = table;
            conn.Close();
            employeeGrid.Columns[0].Width = 50;
        } //end employees display      

        public void ListVacations(DataGridView vacationGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT startDate AS Start, endDate AS End FROM Vacation where employeeID = '" + this.eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            vacationGrid.DataSource = table;
            conn.Close();
        } //end vacations display

        //core functionality
        public void EmployeeSearch(String EmpSearch, DataGridView searchEmployeesGrid)
        {
            conn.Open();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("call Employee_Search('" + EmpSearch + "');", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            searchEmployeesGrid.DataSource = table;
            conn.Close();
        } //end employee search

    }//end class
}//end namespace
