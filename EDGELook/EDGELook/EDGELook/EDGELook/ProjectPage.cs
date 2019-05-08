using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EDGELook
{
    class ProjectPage
    {
        //variable initialization and setup
        private String  projectDesc;
        private String  projectDeliverables;
        private int     projectHours;
        private String  projectID;
        private String notesPNum;
        private String leaderID, fName, lName;

        private MySqlConnection conn;

        private int flag = 0;

        public void Setup(MySqlConnection con)
        {
            this.conn = con;
        }//end setup

        public int GetFlag()
        {
            return flag;
        }//end get flag

        public void SetFlag(int n)
        {
            flag = n;
        }//end set flag
        
        public void EditID(String newID)
        {
            projectID = newID;
        }//end edit ID

        //display functions (search project page)
        public void ListProjects(DataGridView projectsGrid, String eID)
        {
            try
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT E.fname AS 'Leader First Name', E.lname AS 'Leader Last Name', P.prjNo AS 'Project #', P.Description, P.prjComplete AS 'Complete' FROM Project P, Employee E WHERE P.prjLeader = E.employeeID ORDER BY P.prjComplete;", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                projectsGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end list projects

        //display functions (project page)
        public void AutoDisplay(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox leaderLNameBox, TextBox leaderFNameBox, TextBox projectPageDeliverablesBox, NumericUpDown projectPageHoursBox, String prjNo, CheckBox compCheck)
        {
            bool temp = false;
            bool check = false;
            try
            {
                conn.Open();
                String getProjInfo = "SELECT * FROM Project WHERE prjNo = '" + prjNo + "';";
                MySqlCommand cmd = new MySqlCommand(getProjInfo, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    projectPagePNumBox.Text = dr.GetString(0);
                    notesPNum = dr.GetString(0);
                    leaderID = dr.GetString(1);
                    projectPageDescriptionBox.Text = dr.GetString(2);
                    projectPageDeliverablesBox.Text = dr.GetString(3);
                    projectPageHoursBox.Value = dr.GetDecimal(4);
                    check = dr.GetBoolean(5);
                    temp = true;
                }

                if (temp == false)
                {
                    MessageBox.Show("Not found");
                }
                dr.Close();
                String getName = "SELECT fname, lname FROM Employee WHERE employeeID = '" + leaderID + "';";
                MySqlCommand cmdSet = new MySqlCommand(getName, this.conn);
                MySqlDataReader reader2 = cmdSet.ExecuteReader();
                while (reader2.Read())
                {
                    fName = reader2.GetString("fname");
                    lName = reader2.GetString("lname");
                }
                reader2.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            leaderFNameBox.Text = fName;
            leaderLNameBox.Text = lName;
            if (check)
            {
                compCheck.Checked = true;
            }
            else
            {
                compCheck.Checked = false;
            }
        } // END AUTODISPLAY

        public void DisplayEmployees(DataGridView unassigned, DataGridView assigned)
        {
            try
            {
                conn.Open();
                //populate assigned gird
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT E.employeeID AS ID, E.fname AS First, E.lname AS Last, W.hours AS Hours FROM Employee E, WorksOn W WHERE W.employeeID = E.employeeID AND W.prjNo = '" + projectID + "';", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                assigned.DataSource = table;
                //populate unassigned grid
                MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT E.employeeID AS ID, E.fname AS First, E.lname AS Last, E.hoursAvail AS Hours FROM Employee E WHERE(not exists(SELECT * FROM WorksOn W WHERE prjNo = '" + projectID + "' AND E.employeeID = W.employeeID)) OR(not exists(SELECT * FROM WorksOn X WHERE E.employeeID = X.employeeID))", conn);
                DataTable table2 = new DataTable();
                da2.Fill(table2);
                unassigned.DataSource = table2;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } //end display employees

        public void DisplayNotes(DataGridView grid)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT nDate AS Date, notes AS Notes FROM Notes WHERE prjNo = '" + notesPNum + "';", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                grid.DataSource = table;
                grid.Columns[0].Width = 100;
                grid.Columns[1].Width = 205;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } //end display notes

        public void ListPhases(DataGridView phases)
        {
            try
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT prjNo AS 'Project #', prjPhase AS 'Phase', phaseDueDate AS 'Phase Due Date', status AS Status FROM ProjectPhase WHERE prjNo = '" + projectID + "' ORDER BY phaseDueDate;", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                phases.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end list phases

        public void HoursDisplay(Label hours)
        {
            try
            {
                conn.Open();
                String getHours = "SELECT hoursNeeded FROM Project WHERE prjNo = '" + projectID + "';";
                MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hours.Text = reader.GetString("hoursNeeded") + " Hours";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } //end hours display

        //core functionality (search project page)
        public void ProjectSearch(String projSearch, DataGridView projectsGrid, int passable)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da;
                switch (passable)
                {
                    case 1: da = new MySqlDataAdapter("call Search_By_Project('" + projSearch + "');", conn); break;
                    case 2: da = new MySqlDataAdapter("call Search_By_Description('" + projSearch + "');", conn); break;
                    case 3: da = new MySqlDataAdapter("call Search_By_Lead('" + projSearch + "');", conn); break;
                    default: da = new MySqlDataAdapter("call Project_Search('" + projSearch + "');", conn); break;
                }

                DataTable table = new DataTable();
                da.Fill(table);
                projectsGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end project search

        //core functionality (project page)
        public void EditProject(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDeliverablesBox, NumericUpDown projectPageHoursBox, TextBox projectPageStatusBox, String eID)
        {
            int flag = GetFlag();
            if (projectPagePNumBox.Text == "")
            {
                MessageBox.Show("Please Enter a Project Number");
            } else { 

                projectID = projectPagePNumBox.Text;
                projectDesc = projectPageDescriptionBox.Text;
                projectDeliverables = projectPageDeliverablesBox.Text;
                projectHours = (int)projectPageHoursBox.Value;
                int projectComplete = 0;
                int defaultHours = 0;
                try
                {
                    conn.Open();

                    if (flag == 1)
                    { // if its an update
                        String upDateProject = ("UPDATE Project SET description = '" + projectDesc + "', deliverables = '" + projectDeliverables + "', hoursNeeded = " + projectHours + " WHERE prjNo = '" + projectID + "';");
                        MySqlCommand cmd = new MySqlCommand(upDateProject, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Project Changed");
                    }
                    else if (flag == 0)
                    { // if its a new project

                        //Checks for a duplicate project
                        String prj = null;
                        String getPrjDup = "SELECT p.prjNo FROM Project p, ProjectPhase w WHERE p.prjNo = w.prjNo AND p.prjNo = '" + projectID + "';";
                        MySqlCommand cmd1 = new MySqlCommand(getPrjDup, this.conn);
                        MySqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            prj = reader.GetString("prjNo");
                        }
                        reader.Close();
                        if (prj != null)
                        {
                            MessageBox.Show("Duplicate Project");
                        }
                        else
                        {

                            String addProject = ("INSERT INTO Project VALUES (?val1, ?val2, ?val3, ?val4, ?val5, ?val6);");
                            MySqlCommand cmd = new MySqlCommand(addProject, conn);
                            cmd.Parameters.AddWithValue("?val1", projectID);
                            cmd.Parameters.AddWithValue("?val2", eID);
                            cmd.Parameters.AddWithValue("?val3", projectDesc);
                            cmd.Parameters.AddWithValue("?val4", projectDeliverables);
                            cmd.Parameters.AddWithValue("?val5", projectHours);
                            cmd.Parameters.AddWithValue("?val6", projectComplete);                       
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Project Added");

                            String addLeader = ("INSERT INTO WorksOn VALUES (?val7, ?val8, ?val9);");
                            MySqlCommand cmd2 = new MySqlCommand(addLeader, conn);
                            cmd2.Parameters.AddWithValue("?val7", eID);
                            cmd2.Parameters.AddWithValue("?val8", projectID);
                            cmd2.Parameters.AddWithValue("?val9", defaultHours);
                            cmd2.ExecuteNonQuery();
                        }
                        SetFlag(1);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        } // END EDITPROJECT

        public void DeleteProject()
        {
            try
            {
                conn.Open();
                String deleteWorksOn = "DELETE FROM WorksOn WHERE prjNo = '" + projectID + "';";
                MySqlCommand cmd = new MySqlCommand(deleteWorksOn, conn);
                cmd.ExecuteNonQuery();

                String deleteNotes = "DELETE FROM Notes WHERE prjNo = '" + projectID + "';";
                MySqlCommand cmd2 = new MySqlCommand(deleteNotes, conn);
                cmd2.ExecuteNonQuery();

                String deleteProjectPhase = "DELETE FROM ProjectPhase WHERE prjNo = '" + projectID + "';";
                MySqlCommand cmd3 = new MySqlCommand(deleteProjectPhase, conn);
                cmd3.ExecuteNonQuery();

                String deleteProject = "DELETE FROM Project WHERE prjNo = '" + projectID + "';";
                MySqlCommand cmd4 = new MySqlCommand(deleteProject, conn);
                cmd4.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddNotes(String eID, TextBox projectPagePNumBox, TextBox projectPageNotesBox)
        {
            //Don't need validation here because NOW() will always make the entry unique
            String pid = projectPagePNumBox.Text;
            String notesText = projectPageNotesBox.Text;           
            try
            {
                conn.Open();
                String notes = "INSERT INTO Notes VALUES (?val1, ?val2, NOW(), ?val3); ";
                MySqlCommand cmd = new MySqlCommand(notes, conn);
                cmd.Parameters.AddWithValue("?val1", eID);
                cmd.Parameters.AddWithValue("?val2", pid);
                cmd.Parameters.AddWithValue("?val3", notesText);
                cmd.ExecuteNonQuery();
                projectPageNotesBox.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } // END ADDNOTES

        public void SetCompleteIncomplete(CheckBox complete)
        {
            if(complete.Checked)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Project SET prjCOmplete = 1 WHERE prjNo = '" + projectID + "';", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                MessageBox.Show("Project set to Complete");
            }
            else
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Project SET prjCOmplete = 0 WHERE prjNo = '" + projectID + "';", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }//end set completion

        public void AssignEmployee(int prjHours, String empID)
        {

            int currHours = 0;
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT hours FROM WorksOn WHERE prjNo = '" + projectID + "' AND employeeID = '" + empID + "';", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    currHours = reader.GetInt16("hours");
                }
                reader.Close();

                int hoursNeeded = 0;
                String getHoursNeeded = "SELECT hoursNeeded FROM Project WHERE prjNo = '" + projectID + "';";
                cmd = new MySqlCommand(getHoursNeeded, this.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hoursNeeded = reader.GetInt16("hoursNeeded");
                }
                reader.Close();

                int empHours = 0;
                String getEmpHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + empID + "';";
                cmd = new MySqlCommand(getEmpHours, this.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empHours = reader.GetInt16("hoursAvail");
                }
                reader.Close();

                String dupId = null;
                String getEmpDup = "SELECT employeeID FROM WorksOn WHERE employeeID = '" + empID + "' AND prjNo = '" + projectID + "';";
                cmd = new MySqlCommand(getEmpDup, this.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dupId = reader.GetString("employeeID");
                }
                reader.Close();

                if ((empHours + currHours) >= prjHours || prjHours <= currHours)
                {
                    if (prjHours <= hoursNeeded || prjHours <= currHours)
                    {
                        if (dupId != null)
                        {
                            cmd = new MySqlCommand("UPDATE WorksOn SET hours = '" + prjHours + "' WHERE employeeID = '" + empID + "' AND prjNo = '" + projectID + "';", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            String setMyID = "INSERT INTO WorksOn VALUES (?val1, ?val2, ?val3);";
                            cmd = new MySqlCommand(setMyID, this.conn);
                            cmd.Parameters.AddWithValue("?val1", empID);
                            cmd.Parameters.AddWithValue("?val2", projectID);
                            cmd.Parameters.AddWithValue("?val3", prjHours);                           
                            cmd.ExecuteNonQuery();
                        }

                        empHours += currHours - prjHours;

                        cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "' WHERE employeeID = '" + empID + "';", conn);
                        cmd.ExecuteNonQuery();

                        hoursNeeded += currHours - prjHours;
                        cmd = new MySqlCommand("UPDATE Project SET hoursNeeded = '" + hoursNeeded + "' WHERE prjNo = '" + projectID + "';", conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hours Updated");

                        if (prjHours == 0)
                        {
                            String checkEmpID = "";
                            String checkID = "SELECT prjLeader FROM Project WHERE prjNo  = '" + projectID + "' ;";
                            MySqlCommand cmd0 = new MySqlCommand(checkID, this.conn);
                            MySqlDataReader reader0 = cmd0.ExecuteReader();
                            while (reader0.Read())
                            {
                                checkEmpID = reader0.GetString("prjLeader");
                            }
                            reader0.Close();
                            if (checkEmpID != empID)
                            {
                                cmd = new MySqlCommand("DELETE FROM WorksOn WHERE employeeID = '" + empID + "' AND prjNo = '" + projectID + "';", conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("0 Hours Assigned. Removed From Project");
                            }
                            else
                            {
                                MessageBox.Show("Hours set to 0, but Employee is Project Leader and cannot be deleted from project.");
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
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } //end assign employee

        public void RemoveEmployee(String empID)
        {
            //get project leader of current project
            try
            {
                conn.Open();
                String checkEmpID = "";
                String checkID = "SELECT prjLeader FROM Project WHERE prjNo  = '" + projectID + "' ;";
                MySqlCommand cmd0 = new MySqlCommand(checkID, this.conn);
                MySqlDataReader reader0 = cmd0.ExecuteReader();
                while (reader0.Read())
                {
                    checkEmpID = reader0.GetString("prjLeader");
                }
                reader0.Close();

                if (checkEmpID != empID)
                {
                    int hoursAssigned = 0;
                    String getHours = "SELECT hours FROM WorksOn WHERE employeeID  = '" + empID + "' ;";
                    MySqlCommand cmd1 = new MySqlCommand(getHours, this.conn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        hoursAssigned = reader1.GetInt32("hours");
                    }
                    reader1.Close();

                    int hoursAvail = 0;
                    String availGetHours = "SELECT hoursAvail FROM Employee WHERE employeeID  = '" + empID + "' ;";
                    MySqlCommand cmd2 = new MySqlCommand(availGetHours, this.conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        hoursAvail = reader2.GetInt32("hoursAvail");
                    }
                    reader2.Close();

                    String removeID = "DELETE FROM WorksOn WHERE employeeID = '" + empID + "' AND prjNo = '" + projectID + "';";
                    MySqlCommand cmd3 = new MySqlCommand(removeID, conn);
                    cmd3.ExecuteNonQuery();

                    int totalHours = 0;
                    totalHours = hoursAvail + hoursAssigned;
                    String setHours = "UPDATE Employee SET hoursAvail = '" + totalHours + "'WHERE employeeID = '" + empID + "';";
                    MySqlCommand cmd4 = new MySqlCommand(setHours, this.conn);
                    cmd4.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Project Leader cannot be removed.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } //END REMOVEEMPLOYEE   

        public void UpdatePhase(TextBox phase, DateTimePicker due, TextBox status)
        {
            due.Format = DateTimePickerFormat.Custom;
            due.CustomFormat = "yyyy-MM-dd";
            due.MinDate = DateTime.Today;
            String projectPhase = phase.Text;
            String projectDueDates = due.Text;
            String projectStatus = status.Text;
            if (projectPhase != "" && projectDueDates != "" && projectStatus != "")
            {
                try
                {
                    conn.Open();
                    String prj = null;
                    String getPrjDup = "SELECT prjNo FROM ProjectPhase WHERE prjNo = '" + projectID + "' AND prjPhase = '" + projectPhase + "';";
                    MySqlCommand cmd = new MySqlCommand(getPrjDup, this.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        prj = reader.GetString("prjNo");
                    }
                    reader.Close();
                    String pid = null;
                    String getPID = "SELECT prjNo FROM Project WHERE prjNo = '" + projectID + "';";
                    cmd = new MySqlCommand(getPID, this.conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pid = reader.GetString("prjNo");
                    }
                    reader.Close();
                    if (pid != null)
                    {
                        if (prj != null)
                        {
                            String upDatePhase = "UPDATE ProjectPhase SET phaseDueDate = '" + projectDueDates + "', status = '" + projectStatus + "' WHERE prjNo = '" + projectID + "' AND prjPhase = '" + projectPhase + "';";
                            MySqlCommand cmd2 = new MySqlCommand(upDatePhase, conn);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Phase " + projectPhase + " Updated");
                        }
                        else
                        {
                            String addProjectPhase = "INSERT INTO ProjectPhase VALUES (?val1, ?val2, ?val3, ?val4);";
                            MySqlCommand cmd2 = new MySqlCommand(addProjectPhase, conn);
                            cmd2.Parameters.AddWithValue("?val1", projectID);
                            cmd2.Parameters.AddWithValue("?val2", projectPhase);
                            cmd2.Parameters.AddWithValue("?val3", projectDueDates);
                            cmd2.Parameters.AddWithValue("?val4", projectStatus);                            
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Phase " + projectPhase + " Created");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please create project before adding phases.");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid input for Phase, Status, and Due Date.");
            }
        } //end update phase

        public void UpdateLeader(String eID)
        {
            if (projectID != null)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Project SET prjLeader = '" + eID + "'WHERE prjNo = '" + projectID + "';", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        } //end update leader

    } // END INTERNAL CLASS EDGELOOK
} // END EDGELOOK