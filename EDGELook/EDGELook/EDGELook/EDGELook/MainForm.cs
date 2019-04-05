
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
    public partial class MainForm : Form
    {
        
        LoginPage login;
        //private int loginResult;
        EditProjectPage edit = new EditProjectPage();
        private DBConn dbconn;
        private MySqlConnection conn;
        ProfilePage profile;
        int? eID;
        private String testPrjNo;

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
            //QUICK LOGIN
            emailBox.Text = "iris@yahoo.com";
            passBox.Text = "******";

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
            emailBox.Text = passBox.Text = "";
           

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

            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            edit.Setup(conn);

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

            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            edit.Setup(conn);
            Clear();
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageDueDateBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID,testPrjNo);
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
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            edit.Setup(conn);
            edit.EditProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDueDateBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, projectPageNotesBox, eID);
        }

        private void ProjectPageAddSelfButton_Click(object sender, EventArgs e)
        {
            Boolean addedMyself = true;
            //edit.AssignEmployee(addedMyself);
        }

        private void ProjectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            edit.Setup(conn);

            edit.AddNotes(eID, projectPagePNumBox, projectPageNotesTextBox);
            edit.DisplayNotes(notesGridView);
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
            if(this.projectPageEmployeeList.SelectedIndex >= 0)
            {
                this.projectPageEmployeeList.Items.RemoveAt(this.projectPageEmployeeList.SelectedIndex);
                String ret = "";
                String fullName = this.projectPageEmployeeList.ToString();
                string[] names = fullName.Split(' ');
                firstName = names[0];
                lastName = names[1];
                ret = edit.RemoveEmployee(firstName, lastName);
                projectPageToBeAssignedListBox.Items.Add(ret);

            }
        }

        private void projectPageEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void projectsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(projectsGrid.CurrentRow.Index != -1)
            {
                testPrjNo = projectsGrid.CurrentRow.Cells[0].Value.ToString();
            }
        }
        void Clear()
        {
            //projectPagePNumBox.Text = projectPageDescriptionBox.Text = projectPageDueBox.Text = projectPagePhaseBox.Text = projectPageDeliverablesBox.Text = projectPageStatusBox.Text = "";
            //projectPageHoursBox.Value = 0;
        }
    }
}
