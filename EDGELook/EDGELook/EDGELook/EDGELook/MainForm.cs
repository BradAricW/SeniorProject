﻿using System;
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
    public partial class MainForm : Form
    {
        LoginPage login;
        //private int loginResult;
        EditProjectPage edit = new EditProjectPage();
        private DBConn dbconn;
        private MySqlConnection conn;
        ProfilePage profile;
        int? eID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //setup Connection object
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            login = new LoginPage();
            login.Setup(conn);

            eID = login.Login(emailBox, passBox);
            int success;
            if (eID == null)
                success = 0;
            else
                success = 1;
            if (success == 1)
            {
                this.signOutLabel.Visible = true;
                this.loginBG.Visible = false;
                this.taskbarMenu.Visible = true;
                this.profileBG.Visible = true;
            }
            profile = new ProfilePage();
            profile.Setup(conn, eID);
            profile.GetHours(profileHoursTextBox);
           

        }
        //private void 

        private void SignOutLabel_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = false;
            this.loginBG.Visible = true;
            this.taskbarMenu.Visible = false;
            this.profileBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = true;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = true;


            edit.ListProjects(projectsGrid, eID);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = true;
            this.searchProjectsBG.Visible = false;
        }

        private void SchedulesButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = true;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
        }

        private void CreateAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SearchEmployeesViewButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = true;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
        }

        private void SearchProjectsViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;


            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageDueBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursTextBox, projectPageStatusBox, eID);
            edit.DisplayNotes(notesGridView);
            edit.setFlag(1);
            Console.WriteLine("Edit Project. Flag set to 1");
        }

        private void SearchProjectsPageAddProjectButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;

            edit.setFlag(0);
            Console.WriteLine("Add Project. Flag set to 0");
        }


        // Button Functionality

        // Update Project
        private void ProjectPageUpdateButton_Click(object sender, EventArgs e)
        {
            edit.EditProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDueBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursTextBox, projectPageStatusBox, projectPageNotesBox, eID);
        }

        private void ProjectPageAddSelfButton_Click(object sender, EventArgs e)
        {
            Boolean addedMyself = true;
            //edit.AssignEmployee(addedMyself);
        }

        private void ProjectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            edit.AddNotes(projectPagePNumBox, projectPageNotesBox);
        }

        private void SearchProjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfileEditButton1_Click(object sender, EventArgs e)
        {
            profile.EditMyHours(profileHoursTextBox, eID);
        }

        private void projectPageRemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            String firstName = "";
            String lastName = "";
            //edit.RemoveEmployee(firstName, lastName);
        }
    }
}
