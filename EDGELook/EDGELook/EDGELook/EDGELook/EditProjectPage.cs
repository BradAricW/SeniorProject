
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
    class EditProjectPage
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
        

        private int flag = 0;

        //private MySqlConnection con;
        private DBConn sql = new DBConn();

        public int getFlag()
        {
            return flag;
        }
        public void setFlag(int n)
        {
             flag = n;
            Console.WriteLine("Flag Set: " + flag);
        }


        //Edit Project
        public void EditProject(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox, ListBox projectPageNotesBox, int? eID)
        {
            int flag = getFlag();

            projectNum = projectPagePNumBox.Text;
            projectDesc = projectPageDescriptionBox.Text;
            projectDueDates = projectPageDueBox.Text;
            projectPhase = projectPagePhaseBox.Text;
            projectDeliverables = projectPageDeliverablesBox.Text;
            projectHours = int.Parse(projectPageHoursTextBox.Text);
            projectStatus = projectPageStatusBox.Text;

            if (flag == 1)
            { // if its an update
                String upDateProject = ("UPDATE Project SET description = '" + projectDesc +
                                                                       "', dueDate = '" + projectDueDates +
                                                                       "', prjPhase = '" + projectPhase +
                                                                       "', deliverables = '" + projectDeliverables +
                                                                       "', hoursNeeded = " + projectHours +
                                                                       ", prjStatus = '" + projectStatus +
                                                                       "' WHERE prjNo = '" + projectNum + "';");
                sql.queryRunner(upDateProject);
                MessageBox.Show("Project Changed");
            }
            else if (flag == 0)
            { // if its a new project

                String addProject = ("INSERT INTO Project (prjNo, prjLeader, description, prjPhase, dueDate, deliverables, hoursNeeded, prjStatus)" + 
                                             "VALUES ('" + projectNum + "', " + "'" + eID + "', '" + projectDesc + "', '" + projectPhase + "', '" + projectDueDates + "', '" + projectDeliverables + "', '" + projectHours + "', '" + projectStatus + "');");
                MessageBox.Show(addProject);
                sql.queryRunner(addProject);
                MessageBox.Show("Project Added");
            }
            else
            {
                Console.WriteLine("ISSUE WITH EDIT PROJECT! FLAG PASSED INCORRECT VALUE.");
            }

        } // END EDITPROJECT


        // Auto Display Project Info in Edit Project Page
        public void AutoDisplay(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox, int? eID)
        {
            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            bool temp = false;
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            String getProjInfo = "select * from Project, Notes where employeeID = " + eID + " and prjLeader = " + eID + ";";
            MySqlCommand cmd = new MySqlCommand(getProjInfo, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectPagePNumBox.Text = dr.GetString(0);
                notesPNum = dr.GetString(0);
                projectPageDescriptionBox.Text = dr.GetString(2);
                projectPagePhaseBox.Text = dr.GetString(3);
                projectPageDueBox.Text = dr.GetString(4);
                projectPageDeliverablesBox.Text = dr.GetString(5);
                projectPageHoursTextBox.Text = dr.GetString(6);
                projectPageStatusBox.Text = dr.GetString(7);
                // textBoxNotes.Text = dr.GetString(10);
                //DisplayNotes(projectPagePNumBox.Text, projectPageNotesBox);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();
        } // END AUTODISPLAY


        public void AddNotes(TextBox projectPagePNumBox, ListBox projectPageNotesBox)
        {
            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connString); //this might be the new connection that is causing issues (message from MM)
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Notes (employeeID, projNo, timeStamp, notes) VALUES (000, " + projectPagePNumBox + ", NOW(), " + projectPageNotesBox + "; ", con);

        } // END ADDNOTES

        // Displays Notes in the Edit Project Page
        //public void DisplayNotes(String projectPagePNumBox, ListBox projectPageNotesBox)
        public void DisplayNotes(DataGridView grid)
        {

            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            bool temp = false;
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            //MySqlCommand cmd = new MySqlCommand("SELECT timeStamp, notes  FROM Notes WHERE prjNo = '" + projectPagePNumBox + "';", con);
            //MySqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    projectPageNotesBox.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            //}
            MySqlDataAdapter da = new MySqlDataAdapter("select nDate, notes from Notes where prjNo = '" + notesPNum +"';",con);
            DataTable table = new DataTable();
            da.Fill(table);
            grid.DataSource = table;
            //grid.Columns[0].Visible = false;
        } // END EDIT NOTES

        public void ListProjects(DataGridView projectsGrid, int? eID)
        {
            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("Select prjNo, Description from Project where prjLeader = '" + eID + "';",con);
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
        }
    //    public void AssignEmployee(Boolean myselfButton)
    //    {
    //        //conn.Open();
    //        if (myselfButton)

    //        {

    //            String getMyID = "SELECT employeeID FROM Employee as E WHERE " + this.eID + " == E.employeeID;"; //login ID from employee table
    //            MySqlCommand cmd = new MySqlCommand(getMyID, this.conn);
    //            MySqlDataReader reader = cmd.ExecuteReader();

    //            String getProjectID = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " == P.prjNo;";
    //            MySqlCommand cmd2 = new MySqlCommand(getProjectID, this.conn);
    //            MySqlDataReader reader1 = cmd2.ExecuteReader();

    //            String setMyID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + getMyID + "\'," + getProjectID + "\');";
    //            MySqlCommand cmd1 = new MySqlCommand(setMyID, this.conn);
    //            Console.WriteLine(cmd1.ExecuteNonQuery());
    //        }

    //        //Get ID through Email or from input box
    //        String otherID = " ";

    //        String getProjectID2 = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " == P.prjNo;";
    //        MySqlCommand cmd3 = new MySqlCommand(getProjectID2, this.conn);
    //        MySqlDataReader reader2 = cmd3.ExecuteReader();

    //        String setotherID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + otherID + "\'," + getProjectID2 + "\');";
    //        MySqlCommand cmd4 = new MySqlCommand(setotherID, this.conn);
    //        Console.WriteLine(cmd4.ExecuteNonQuery());

    //    } //END ASSIGNEMPLOYEE: MM and SZ


    //    public void RemoveEmployee(String firstName, String lastName)
    //    { //get first name and last name as parameter?
    //        //conn.Open();
    //        String getMyID = "SELECT employeeID FROM Employee WHERE fname = " + firstName + " AND lname = " + lastName + "";
    //        MySqlCommand cmd = new MySqlCommand(getMyID, this.conn);
    //        MySqlDataReader reader = cmd.ExecuteReader();

    //        String removeID = "DELETE employeeID FROM WorksOn WHERE employeeID == " + getMyID + " ";
    //        MySqlCommand cmd1 = new MySqlCommand(removeID, this.conn);
    //        MySqlDataReader query = cmd1.ExecuteNonQuery();

    //    } //END REMOVEEMPLOYEE: MM and SZ   


    } // END INTERNAL CLASS EDGELOOK
} // END EDGELOOK