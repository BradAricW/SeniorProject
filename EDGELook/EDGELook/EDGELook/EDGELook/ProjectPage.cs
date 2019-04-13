
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

                String addProject = ("INSERT INTO Project (prjNo, prjLeader, description, prjPhase, dueDate, deliverables, hoursNeeded, prjStatus)" + 
                                             "VALUES ('" + projectNum + "', " + "'" + eID + "', '" + projectDesc + "', '" + projectPhase + "', '" + projectDueDates + "', '" + projectDeliverables + "', '" + projectHours + "', '" + projectStatus + "');");
                MySqlCommand cmd = new MySqlCommand(addProject, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(addProject);
                MessageBox.Show("Project Added");
            }
            else
            {
                Console.WriteLine("ISSUE WITH EDIT PROJECT! FLAG PASSED INCORRECT VALUE.");
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
            conn.Open();
            String notes = "INSERT INTO Notes (employeeID, prjNo, nDate, notes) VALUES (" + eID + ", \"" + projectPagePNumBox.Text + "\", NOW(), '" + projectPageNotesBox.Text + "'); ";
            MySqlCommand cmd = new MySqlCommand(notes, conn);
            cmd.ExecuteNonQuery();
            projectPageNotesBox.Text = "";
            conn.Close();

        } // END ADDNOTES

        public void DisplayEmployees(DataGridView unassigned, DataGridView assigned)
        {
            conn.Open();
            //populate assigned gird
            MySqlDataAdapter da = new MySqlDataAdapter("select fname, lname, hours from Employee e, WorksOn w where w.employeeID = e.employeeID AND w.prjNo = '" + projectID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            assigned.DataSource = table;
            assigned.Columns[0].Width = 55;
            assigned.Columns[1].Width = 55;
            assigned.Columns[1].Width = 47;
            //populate unassigned grid
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT fname, lname, hoursavail FROM Employee e WHERE(not exists(SELECT * FROM WorksOn w WHERE prjNo = '" + projectID + "' AND e.employeeID = w.employeeID)) OR(not exists(SELECT * FROM WorksOn x WHERE e.employeeID = x.employeeID))", conn);
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

            MySqlDataAdapter da = new MySqlDataAdapter("Select prjNo, Description from Project ;",conn); //where prjLeader = '" + eID + "'
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

                String setHours = "UPDATE WorksOn SET hours = '" + hours + "'WHERE employeeID = '" + eID + "';";
                MySqlCommand cmd5 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd5.ExecuteNonQuery());
                conn.Close();
            }

            
        }
        public String AssignEmployee(Boolean myselfButton, int hours, int? eID, String firstName, String lastName)
        {
            String setHours = "";
            conn.Open();
            String getHours = "SELECT hoursAvail FROM Employee E WHERE " + eID + " = E.employeeID;";
            MySqlCommand cmd6 = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader3 = cmd6.ExecuteReader();
            int checkHours = int.Parse(getHours);
            if(hours <= checkHours) {
                if (myselfButton == true)
                {

                    String getMyID = "SELECT employeeID FROM Employee as E WHERE " + eID + " = E.employeeID;"; //login ID from employee table
                    MySqlCommand cmd = new MySqlCommand(getMyID, this.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //check how we get correct project number
                    String getProjectID = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " = P.prjNo;";
                    MySqlCommand cmd2 = new MySqlCommand(getProjectID, this.conn);
                    MySqlDataReader reader1 = cmd2.ExecuteReader();

                    String setMyID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + getMyID + "\'," + getProjectID + "\');";
                    MySqlCommand cmd1 = new MySqlCommand(setMyID, this.conn);
                    Console.WriteLine(cmd1.ExecuteNonQuery());

                    conn.Close();
                }
                else
                {

                    //conn.Open();
                    //Get ID through Email or from input box
                    String otherID = " ";

                    String getProjectID2 = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " == P.prjNo;";
                    MySqlCommand cmd3 = new MySqlCommand(getProjectID2, this.conn);
                    MySqlDataReader reader2 = cmd3.ExecuteReader();
                        
                    String setotherID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + otherID + "\'," + getProjectID2 + "\');";
                    MySqlCommand cmd4 = new MySqlCommand(setotherID, this.conn);
                    Console.WriteLine(cmd4.ExecuteNonQuery());
                    conn.Close();
                }

                conn.Open();

                setHours = "UPDATE WorksOn SET hours = '" + hours + "'WHERE employeeID = '" + eID + "';";
                MySqlCommand cmd5 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd5.ExecuteNonQuery());
                conn.Close();
            }
            
            else {
                MessageBox.Show("Not enough hours available to be added to project.");
                //String error = "error"; //how to show this
            }
            String ret = firstName + " " + lastName + " " + setHours;
            return ret;

        } //END ASSIGNEMPLOYEE: MM and SZ


        public String RemoveEmployee(String firstName, String lastName, int? eID)
        { //get first name and last name as parameter?
            conn.Open();
            String getMyID = "SELECT employeeID FROM Employee WHERE fname = " + firstName + " AND lname = " + lastName + "";
            MySqlCommand cmd = new MySqlCommand(getMyID, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            String getHours = "SELECT hours FROM WorksOn WHERE employeeID == " + getMyID + " ";
            MySqlCommand cmd2 = new MySqlCommand(getMyID, this.conn);
            MySqlDataReader reader1 = cmd2.ExecuteReader();
            //String hours = getHours.ToString();

            String removeID = "DELETE employeeID FROM WorksOn WHERE employeeID == " + getMyID + " ";
            MySqlCommand cmd1 = new MySqlCommand(removeID, conn);
            Console.WriteLine(cmd1.ExecuteNonQuery());

            //hoursAvail: fix this to make hoursAvail plus getHours
            String setHours = "UPDATE Employee SET hoursAvail = '" + getHours + "'WHERE employeeID = '" + eID + "';";
            MySqlCommand cmd3 = new MySqlCommand(setHours, this.conn);
            Console.WriteLine(cmd3.ExecuteNonQuery());

            //conn.Open();
            conn.Close();
            String ret = firstName + " " + lastName + " " + getHours;
            return ret;

        } //END REMOVEEMPLOYEE: MM and SZ   

        public void EditID(String newID)
        {
            projectID = newID;
        }


    } // END INTERNAL CLASS EDGELOOK
} // END EDGELOOK