
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
        private string  projectNum;
        private string  projectDesc;
        private string  projectDueDates;
        private string  projectPhase;
        private string  projectDeliverables;
        private int     projectHours;
        private string  projectStatus;
        private string  projectID;
        private string notesPNum;
        //private int? eID;

        private MySqlConnection conn;

        private int flag = 0;

        public int getFlag()
        {
            return flag;
        }
        public void setFlag(int n)
        {
             flag = n;
            Console.WriteLine("Flag Set: " + flag);
        }
        public void Setup(MySqlConnection con)
        {
            this.conn = con;
        }

        //Edit Project
        public void EditProject(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, DateTimePicker projectPageDueDateBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, NumericUpDown projectPageHoursBox, TextBox projectPageStatusBox, int? eID)
        {
            int flag = getFlag();
            if (projectPagePNumBox.Text == "")
            {
                MessageBox.Show("please enter Project Number");
            } else { 

                projectNum = projectPagePNumBox.Text;
                projectDesc = projectPageDescriptionBox.Text;
                projectDueDates = projectPageDueDateBox.Text;
                projectPhase = projectPagePhaseBox.Text;
                projectDeliverables = projectPageDeliverablesBox.Text;
                projectHours = (int)projectPageHoursBox.Value;
                projectStatus = projectPageStatusBox.Text;
                conn.Open();

                if (flag == 1)
                { // if its an update
                    String upDateProject = ("UPDATE Project SET description = '" + projectDesc +
                                                                           "', dueDate = '" + projectDueDates +
                                                                           "', prjPhase = '" + projectPhase +
                                                                           "', deliverables = '" + projectDeliverables +
                                                                           "', hoursNeeded = " + projectHours +
                                                                           ", prjStatus = '" + projectStatus +
                                                                           "' WHERE prjNo = '" + projectNum + "';");
                    //sql.queryRunner(upDateProject);
                    MySqlCommand cmd = new MySqlCommand(upDateProject, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project Changed");
                }
                else if (flag == 0)
                { // if its a new project

                    //Checks for a duplicate project
                    string prj = null;
                    String getPrjDup = "SELECT  prjNo FROM Project WHERE prjNo = '" + this.projectNum + "';";
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

                        String addProject = ("INSERT INTO Project (prjNo, prjLeader, description, prjPhase, dueDate, deliverables, hoursNeeded, prjStatus)" +
                                                     "VALUES ('" + projectNum + "', " + "'" + eID + "', '" + projectDesc + "', '" + projectPhase + "', '" + projectDueDates + "', '" + projectDeliverables + "', '" + projectHours + "', '" + projectStatus + "');");
                        MySqlCommand cmd = new MySqlCommand(addProject, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(addProject);
                        MessageBox.Show("Project Added");
                    }
                }
                else
                {
                    Console.WriteLine("ISSUE WITH EDIT PROJECT! FLAG PASSED INCORRECT VALUE.");
                }
            }

        } // END EDITPROJECT


        // Auto Display Project Info in Edit Project Page
        public void AutoDisplay(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, DateTimePicker projectPageDueDateBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, NumericUpDown projectPageHoursBox, TextBox projectPageStatusBox, int? eID, String prjNo)
        {
            bool temp = false;
            conn.Open();
            String getProjInfo = "select * from Project where prjNo = '" + prjNo + "';"; // and prjLeader = " + eID + "
            MySqlCommand cmd = new MySqlCommand(getProjInfo, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectPagePNumBox.Text = dr.GetString(0);
                notesPNum = dr.GetString(0);
                projectPageDescriptionBox.Text = dr.GetString(2);
                projectPagePhaseBox.Text = dr.GetString(3);
                projectPageDueDateBox.Text = dr.GetString(4);
                projectPageDeliverablesBox.Text = dr.GetString(5);
                projectPageHoursBox.Value = dr.GetDecimal(6);
                projectPageStatusBox.Text = dr.GetString(7);
                
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("Not found");
            conn.Close();
        } // END AUTODISPLAY


        public void AddNotes(int? eID, TextBox projectPagePNumBox, TextBox projectPageNotesBox)
        {
            //Don't need validation here because NOW() will always make the entry unique
            string pid = projectPagePNumBox.Text;          
            conn.Open();
            String notes = "INSERT INTO Notes (employeeID, prjNo, nDate, notes) VALUES (" + eID + ", '" + pid + "', NOW(), '" + projectPageNotesBox.Text + "'); ";
            MySqlCommand cmd = new MySqlCommand(notes, conn);
            cmd.ExecuteNonQuery();
            projectPageNotesBox.Text = "";
            conn.Close();
            
           

        } // END ADDNOTES

        public void DisplayEmployees(DataGridView unassigned, DataGridView assigned)
        {
            conn.Open();
            //populate assigned gird
            MySqlDataAdapter da = new MySqlDataAdapter("select fname, lname, hoursAvail from Employee e, WorksOn w where w.employeeID = e.employeeID AND w.prjNo = '" + projectID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            assigned.DataSource = table;
            assigned.Columns[0].Width = 55;
            assigned.Columns[1].Width = 55;
            assigned.Columns[2].Width = 47;
            //populate unassigned grid
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT fname, lname, hoursAvail FROM Employee e WHERE(not exists(SELECT * FROM WorksOn w WHERE prjNo = '" + projectID + "' AND e.employeeID = w.employeeID)) OR(not exists(SELECT * FROM WorksOn x WHERE e.employeeID = x.employeeID))", conn);
            DataTable table2 = new DataTable();
            da2.Fill(table2);
            unassigned.DataSource = table2;
            unassigned.Columns[0].Width = 55;
            unassigned.Columns[1].Width = 55;
            unassigned.Columns[2].Width = 47;
            conn.Close();

        }

        // Displays Notes in the Edit Project Page
        public void DisplayNotes(DataGridView grid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("select nDate, notes from Notes where prjNo = '" + notesPNum +"';",conn);
            DataTable table = new DataTable();
            da.Fill(table);
            grid.DataSource = table;
            grid.Columns[0].Width = 100;
            grid.Columns[1].Width = 157;
            conn.Close();
        } // END EDIT NOTES

        public void ListProjects(DataGridView projectsGrid, int? eID)
        {
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("Select E.fname as 'PrjLeader', P.prjNo, P.Description from Project as P, Employee as E where P.prjLeader = E.employeeID;", conn); //where prjLeader = '" + eID + "'
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();
        }

        public void ProjectSearch(String projSearch, DataGridView projectsGrid, int passable)
        {
            conn.Open();
            MySqlDataAdapter da;
            switch (passable) {
                case 1:  da = new MySqlDataAdapter("call Search_By_Project('" + projSearch + "');", conn); break;
                case 2:  da = new MySqlDataAdapter("call Search_By_Description('" + projSearch + "');", conn); break;
                case 3:  da = new MySqlDataAdapter("call Search_By_Lead('" + projSearch + "');", conn); break;
                default: da = new MySqlDataAdapter("call Project_Search('" + projSearch + "');", conn); break;     
        }
               
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();
        }

        public void AssignMyself(int hours, int? eID)
        {
            conn.Open();
            int hoursAvail = 0;
            String getHours = "SELECT hoursAvail FROM Employee E WHERE " + eID + " = E.employeeID;";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hoursAvail = reader.GetInt32("hoursAvail");
            }
            conn.Close();
            if(hours <= hoursAvail) 
            {
                conn.Open();

                String setMyID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (" + eID + ",\'" + projectID + "');";
                MySqlCommand cmd1 = new MySqlCommand(setMyID, this.conn);
                Console.WriteLine(cmd1.ExecuteNonQuery());

                //update hours in employee table hoursAvail - hours

                String setHours = "UPDATE WorksOn SET hours = '" + hours + "'WHERE employeeID = '" + eID + "';";
                MySqlCommand cmd5 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd5.ExecuteNonQuery());
                conn.Close();
            }

            
        }
        public void AssignEmployee(int hours, String firstName, String lastName)
        {
            
            conn.Open();
          
            int empID = 0;
            String getID = "SELECT employeeID FROM Employee E WHERE E.fname  = '" + firstName + "' AND  E.lname  = '" + lastName + "';";
            MySqlCommand cmd = new MySqlCommand(getID, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empID = reader.GetInt32("employeeID");
            }
            Console.WriteLine(empID);
            
            conn.Close();

            conn.Open();
            int hoursAvail = 0;
            String getHours = "SELECT hoursAvail FROM Employee E WHERE '" + empID + "' = E.employeeID;";
            MySqlCommand cmd1 = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                hoursAvail = reader1.GetInt32("hoursAvail");
            }
            conn.Close();

            if(hours <= hoursAvail) 
            {
                conn.Open();
                //this ensures the program doesn't crash due to duplicate entries in the db
                string dupId = null;
                String getEmpDup = "SELECT  employeeID FROM WorksOn WHERE employeeID = '" + empID + "' AND prjNo = '" + projectID + "';";
                MySqlCommand cmddup = new MySqlCommand(getEmpDup, this.conn);
                MySqlDataReader reader2 = cmddup.ExecuteReader();
                while (reader2.Read())
                {
                    dupId = reader2.GetString("employeeID");
                }
                conn.Close();
                if (dupId != null)
                {
                    MessageBox.Show("Duplicate Employee on Project, Hours Updated");
                }
                else
                {
                    conn.Open();
                    String setMyID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (" + empID + ",'" + projectID + "');";
                    MySqlCommand cmd2 = new MySqlCommand(setMyID, this.conn);
                    Console.WriteLine(cmd2.ExecuteNonQuery());
                    conn.Close();
                }
                //update hours in employee table hoursAvail - hours
                int totalHours = 0;
                totalHours = hoursAvail - hours; //get new hours available for employee

                conn.Open();
                String setHours = "UPDATE WorksOn SET hours = '" + hours + "'WHERE employeeID = '" + empID + "';";
                MySqlCommand cmd5 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd5.ExecuteNonQuery());
                conn.Close();

                conn.Open();
                String setAvailHours = "UPDATE Employee SET hoursAvail = '" + totalHours + "'WHERE employeeID = '" + empID + "';";
                MySqlCommand cmd6 = new MySqlCommand(setAvailHours, this.conn);
                Console.WriteLine(cmd6.ExecuteNonQuery());
                conn.Close();
            }
            else 
            {
                MessageBox.Show("Not enough hours available to be added to project.");
            }

        } //END ASSIGNEMPLOYEE: MM and SZ

        public void RemoveEmployee(String firstName, String lastName)
        { 
            //get project leader of current project
            conn.Open();
            int checkEmpID = 0;
            String checkID = "SELECT prjLeader FROM Project P WHERE P.prjNo  = '" + projectID + "' ;";
            MySqlCommand cmd0 = new MySqlCommand(checkID, this.conn);
            MySqlDataReader reader0 = cmd0.ExecuteReader();
            while (reader0.Read())
            {
                checkEmpID = reader0.GetInt32("prjLeader");
            }
            conn.Close();

            //Get ID with first name and last name
            conn.Open();
            int empID = 0;
            String getID = "SELECT employeeID FROM Employee E WHERE E.fname  = '" + firstName + "' AND  E.lname  = '" + lastName + "';";
            MySqlCommand cmd = new MySqlCommand(getID, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empID = reader.GetInt32("employeeID");
            }
            
            conn.Close();

            if(checkEmpID != empID) {

                conn.Open();
                int hoursAssigned = 0;
                String getHours = "SELECT hours FROM WorksOn E WHERE " + empID + " = E.employeeID;";
                MySqlCommand cmd1 = new MySqlCommand(getHours, this.conn);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    hoursAssigned = reader1.GetInt32("hours");
                }
                conn.Close();

                conn.Open();
                int hoursAvail = 0;
                String availGetHours = "SELECT hoursAvail FROM Employee E WHERE " + empID + " = E.employeeID;";
                MySqlCommand cmd2 = new MySqlCommand(availGetHours, this.conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                   hoursAvail = reader2.GetInt32("hoursAvail");
                }
                conn.Close();
            
                conn.Open();

                String removeID = "DELETE FROM WorksOn WHERE employeeID = '" + empID + "' ";
                MySqlCommand cmd3 = new MySqlCommand(removeID, conn);
                Console.WriteLine(cmd3.ExecuteNonQuery());

                int totalHours = 0;
                totalHours = hoursAvail + hoursAssigned;
                String setHours = "UPDATE Employee SET hoursAvail = '" + totalHours + "'WHERE employeeID = '" + empID + "';";
                MySqlCommand cmd4 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd4.ExecuteNonQuery());

                conn.Close();
            }
            else 
            {
                MessageBox.Show("Project Leader cannot be removed.");
            }
        } //END REMOVEEMPLOYEE: MM and SZ   

        public void EditID(String newID)
        {
            projectID = newID;
        }


    } // END INTERNAL CLASS EDGELOOK
} // END EDGELOOK