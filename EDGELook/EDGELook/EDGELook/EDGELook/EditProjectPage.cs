﻿
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
    internal class EditProjectPage
    {
        private string projectNum;
        private string projectDesc;
        private string projectDueDates;
        private string projectPhase;
        private string projectDeliverables;
        private int projectHours;
        private string projectStatus;


        private string server;
        private string database;
        private string uid;
        private string password;
        private string connString;

        private MySqlConnection con;
        //private DBConn conn;

        //Edit Project
        public void EditProject (TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox, ListBox projectPageNotesBox)
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            con = new MySqlConnection(connString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //conn = new DBConn();
            projectNum = projectPagePNumBox.Text;
            projectDesc = projectPageDescriptionBox.Text;
            projectDueDates = projectPageDueBox.Text;
            projectPhase = projectPagePhaseBox.Text;
            projectDeliverables = projectPageDeliverablesBox.Text;
            projectHours = int.Parse(projectPageHoursTextBox.Text);
            projectStatus = projectPageStatusBox.Text;

            String pNumCompare = "SELECT prjNo FROM Project WHERE prjNo = '" + projectNum + "';";
            MySqlCommand compare = new MySqlCommand(pNumCompare);
           // MySqlDataReader dr = compare.ExecuteReader(); 

            Console.WriteLine(pNumCompare);
            if(pNumCompare == null)
            //if (dr.GetString(0) == null)
            {
                //Conn.editProj(projectNum, projectDesc, projectDueDates, projectPhase, projectDeliverables, projectHours, projectStatus);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Project VALUES description = '" + projectDesc +
                                                                        "', dueDate = '" + projectDueDates +
                                                                        "', prjPhase = '" + projectPhase +
                                                                        "', deliverables = '" + projectDeliverables +
                                                                        "', hoursNeeded = " + projectHours +
                                                                        ", prjStatus = '" + projectStatus +
                                                                        "' WHERE prjNo = '" + projectNum + "';", con);
                cmd.ExecuteReader();

                Console.WriteLine("Project Added");
            }
            else
            {
                //Conn.editProj(projectNum, projectDesc, projectDueDates, projectPhase, projectDeliverables, projectHours, projectStatus);
                MySqlCommand cmd = new MySqlCommand("UPDATE Project SET description = '" + projectDesc +
                                                                        "', dueDate = '" + projectDueDates +
                                                                        "', prjPhase = '" + projectPhase +
                                                                        "', deliverables = '" + projectDeliverables +
                                                                        "', hoursNeeded = " + projectHours +
                                                                        ", prjStatus = '" + projectStatus +
                                                                        "' WHERE prjNo = '" + projectNum + "';", con);
                cmd.ExecuteReader();

                Console.WriteLine("Project Changed");
            }

        } // END EDITPROJECT


        // Auto Display Project Info in Edit Project Page
        public void AutoDisplay(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox, ListBox projectPageNotesBox)
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
            MySqlCommand cmd = new MySqlCommand("select * from Project, Notes where employeeID = 425 and prjLeader = 425;", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectPagePNumBox.Text = dr.GetString(0);
                projectPageDescriptionBox.Text = dr.GetString(2);
                projectPagePhaseBox.Text = dr.GetString(3);
                projectPageDueBox.Text = dr.GetString(4);
                projectPageDeliverablesBox.Text = dr.GetString(5);
                projectPageHoursTextBox.Text = dr.GetString(6);
                projectPageStatusBox.Text = dr.GetString(7);
               // textBoxNotes.Text = dr.GetString(10);
               DisplayNotes(projectPagePNumBox.Text, projectPageNotesBox);
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

            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Notes (employeeID, projNo, timeStamp, notes) VALUES (000, " + projectPagePNumBox + ", NOW(), " + projectPageNotesBox + "; ", con);

        }

        // Displays Notes in the Edit Project Page
        public void DisplayNotes(String projectPagePNumBox, ListBox projectPageNotesBox) {

            String server = "athena";
            String database = "sevenwonders";
            String uid = "sevenwonders";
            String password = "sw_db";
            String connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            bool temp = false;
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT timeStamp, notes  FROM Notes WHERE prjNo = '" + projectPagePNumBox +"';", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectPageNotesBox.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }
        } // END EDIT NOTES

        } // END EDITPROJECTPAGE
} // END EDGELOOK