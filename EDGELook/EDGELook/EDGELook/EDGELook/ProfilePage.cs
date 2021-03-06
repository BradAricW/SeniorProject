﻿using MySql.Data.MySqlClient;
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
        //initialize variables and setup
        private int empHours;
        private MySqlConnection conn;
        private String eID;

        public void Setup(MySqlConnection newConn, String newEmpID)
        {
            conn = newConn;
            eID = newEmpID;
        }//end setup

        //Display functions
        public void ListProjects(DataGridView projectsGrid)
        {
            conn.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT P.prjNo AS 'Project #', P.Description, W.hours AS Hours FROM Project P, WorksOn W WHERE P.prjNo = W.prjNo AND W.employeeID = '" + this.eID + "';", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                projectsGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }//end list projects

        public void ListVacations(DataGridView vacationGrid)
        {
            conn.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT startDate AS Start, endDate AS End, status as Status FROM Vacation WHERE employeeID = '" + this.eID + "';", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                vacationGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }//end list vacations

        public void GetHours(TextBox hoursBox)
        {
            conn.Open();
            try
            {
                String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
                MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hoursBox.Text = reader.GetString("hoursAvail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end get hours

        public void GetEmail(TextBox emailBox)
        {
            conn.Open();
            try
            {
                String getEmail = "SELECT email FROM Employee WHERE employeeID = '" + this.eID + "';";
                MySqlCommand cmd = new MySqlCommand(getEmail, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emailBox.Text = reader.GetString("email");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end get email

        public void GetPhone(TextBox phoneBox)
        {
            conn.Open();
            try
            {
                String getPhone = "SELECT phone FROM Employee WHERE employeeID = '" + this.eID + "';";
                MySqlCommand cmd = new MySqlCommand(getPhone, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    phoneBox.Text = reader.GetString("phone");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }//end get phone

        public void GetName(TextBox fName, TextBox lName)
        {
            conn.Open();
            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end get name

        public Boolean GetAdmin()
        {
            Boolean isAdmin = false;
            int result = 0;
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT admin FROM Employee WHERE employeeID = '" + this.eID + "';", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetInt16("admin");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            if (result == 1)
            {
                isAdmin = true;
            }
            return isAdmin;
        }//end get admin

        public int GetProjHours(String prjNo)
        {
            int hours = 0;
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT hours FROM WorksOn WHERE prjNo = '" + prjNo + "' AND employeeID = '" + this.eID + "';", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hours = reader.GetInt16("hours");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return hours;
        }//end get project hours

        //core functionality
        public void EditMyHours(TextBox hoursBox)
        {
            empHours = -1;
            try
            {
                empHours = int.Parse(hoursBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (empHours >= 0)
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "'WHERE employeeID = '" + this.eID + "';", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
                MessageBox.Show("Hours Updated");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        } //end edit total hours
        
        public void EditProjectHours(TextBox newHoursBox, String pid)
        {
            int prjHours = -1;
            try {
                prjHours = int.Parse(newHoursBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int currHours = GetProjHours(pid);

            int hoursNeeded = 0;
            conn.Open();
            try
            {
                String getHoursNeeded = "SELECT hoursNeeded FROM Project WHERE prjNo = '" + pid + "';";
                MySqlCommand cmd = new MySqlCommand(getHoursNeeded, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hoursNeeded = reader.GetInt16("hoursNeeded");
                }
                reader.Close();

                String getEmpHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
                MySqlCommand cmdSet = new MySqlCommand(getEmpHours, this.conn);
                MySqlDataReader reader2 = cmdSet.ExecuteReader();
                while (reader2.Read())
                {
                    empHours = reader2.GetInt16("hoursAvail");
                }
                reader2.Close();

                if ((empHours + currHours) >= prjHours || prjHours <= currHours)
                {
                    if (prjHours <= hoursNeeded || prjHours <= currHours)
                    {
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE WorksOn SET hours = '" + prjHours + "' WHERE employeeID = '" + eID + "' AND prjNo = '" + pid + "';", conn);
                        cmd1.ExecuteNonQuery();

                        empHours += currHours - prjHours;

                        MySqlCommand cmd2 = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "' WHERE employeeID = '" + eID + "';", conn);
                        cmd2.ExecuteNonQuery();

                        hoursNeeded += currHours - prjHours;
                        MySqlCommand cmd3 = new MySqlCommand("UPDATE Project SET hoursNeeded = '" + hoursNeeded + "' WHERE prjNo = '" + pid + "';", conn);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Hours Updated");

                        if (prjHours == 0)
                        {
                            String checkEmpID = "";
                            String checkID = "SELECT prjLeader FROM Project WHERE prjNo  = '" + pid + "' ;";
                            MySqlCommand cmd0 = new MySqlCommand(checkID, this.conn);
                            MySqlDataReader reader0 = cmd0.ExecuteReader();
                            while (reader0.Read())
                            {
                                checkEmpID = reader0.GetString("prjLeader");
                            }
                            reader0.Close();
                            if (checkEmpID != this.eID)
                            {
                                cmd = new MySqlCommand("DELETE FROM WorksOn WHERE employeeID = '" + this.eID + "' AND prjNo = '" + this.eID + "';", conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("0 Hours Assigned. Removed From Project");
                            }
                            else
                            {
                                MessageBox.Show("Hours set to 0, but you are Project Leader and cannot be deleted from project.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This project only requires " + hoursNeeded + " hours.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();

        }//end edit project hours

        public void EditVacation(DateTimePicker newStartDate, DateTimePicker newEndDate)
        {
            newStartDate.Format = DateTimePickerFormat.Custom;
            newStartDate.CustomFormat = "yyyy-MM-dd";
            newEndDate.Format = DateTimePickerFormat.Custom;
            newEndDate.CustomFormat = "yyyy-MM-dd";
            String startDate = newStartDate.Text;
            String endDate = newEndDate.Text;
            String defaultStatus = "Pending";
            conn.Open();
            try
            {
                String dupId = null;
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
                    MySqlCommand cmd = new MySqlCommand("INSERT into Vacation VALUES(?val1, ?val2, ?val3, ?val4)", conn);
                    cmd.Parameters.AddWithValue("?val1", eID);
                    cmd.Parameters.AddWithValue("?val2", startDate);
                    cmd.Parameters.AddWithValue("?val3", endDate);
                    cmd.Parameters.AddWithValue("?val4", defaultStatus);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vacation Days Created");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        } //end edit vacation

        public void RemoveVacation(String startDate)
        {
            conn.Open();
            try
            {
                if (startDate == null)
                {
                    MessageBox.Show("Date not Selected");
                }
                else {
                    String[] dateTime = startDate.Split(' ');
                    String date = dateTime[0];
                    String[] dateSeperated = date.Split('/');
                    String month = dateSeperated[0];
                    String day = dateSeperated[1];
                    String year = dateSeperated[2];
                    String newDateFormat = "" + year + "-" + month + "-" + day + "";
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Vacation WHERE employeeID = '" + eID + "' AND startDate = '" + newDateFormat + "';", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }//end remove vacation

        public void EditContact(TextBox emailBox, TextBox phoneBox, TextBox fnameBox, TextBox lnameBox)
        {
            String phoneNum = phoneBox.Text;
            String emailAdd = emailBox.Text;
            String fname = fnameBox.Text;
            String lname = lnameBox.Text;
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET phone = '" + phoneNum + "', email = '" + emailAdd + "', fname = '" + fname + "', lname = '" + lname + "' WHERE employeeID = '" + this.eID + "';", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            MessageBox.Show("Contact Information Updated");
        }//end edit contact info

    }//end class
}//end namespace
