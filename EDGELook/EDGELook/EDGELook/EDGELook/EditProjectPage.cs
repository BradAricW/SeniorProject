
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private DBConn Conn;

        //edit project final
        public void editProject (TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox)
        {
            Conn = new DBConn();
            projectNum = projectPagePNumBox.Text;
            projectDesc = projectPageDescriptionBox.Text;
            projectDueDates = projectPageDueBox.Text;
            projectPhase = projectPagePhaseBox.Text;
            projectDeliverables = projectPageDeliverablesBox.Text;
            projectHours = int.Parse(projectPageHoursTextBox.Text);
            projectStatus = projectPageStatusBox.Text;
            //MessageBox.Show(projectNum);
            Conn.editProj(projectNum, projectDesc, projectDueDates, projectPhase, projectDeliverables, projectHours, projectStatus);

        } // END EDITPROJECT

        //dummy button to display project data
        public void autoDisplay(TextBox projectPagePNumBox, TextBox projectPageDescriptionBox, TextBox projectPageDueBox, TextBox projectPagePhaseBox, TextBox projectPageDeliverablesBox, TextBox projectPageHoursTextBox, TextBox projectPageStatusBox)
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
            MySqlCommand cmd = new MySqlCommand("select * from Project, Notes where employeeID = 322 and prjLeader = 322;", con);
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
                temp = true;
            }

            if (temp == false)
                MessageBox.Show("not found");
            con.Close();
        }

        } // END EDITPROJECTPAGE
} v// END EDGELOOK