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

        EditProjectPage edit = new EditProjectPage();
        private DBConn Conn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = true;
        }

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

            edit.autoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageDueBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursTextBox, projectPageStatusBox, projectPageNotesBox);
        }

        private void SearchProjectsPageAddProjectButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
        }


        // Button Functionality

        // Update Project
        private void projectPageUpdateButton_Click(object sender, EventArgs e)
        {
            edit.editProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDueBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursTextBox, projectPageStatusBox, projectPageNotesBox);
        }

        private void projectPageAddSelfButton_Click(object sender, EventArgs e)
        {
            Conn = new DBConn();
            Boolean addedMyself = true;
            Conn.assignEmployee(addedMyself);
        }

        private void projectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            edit.addNotes(projectPagePNumBox, projectPageNotesBox);
        }
    }
}
