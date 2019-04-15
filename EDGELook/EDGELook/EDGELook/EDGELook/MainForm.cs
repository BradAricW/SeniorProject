
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
        AdminPage admin;
        ProjectPage edit = new ProjectPage();
        EmployeePage employee = new EmployeePage();
        private DBConn dbconn;
        private MySqlConnection conn;
        ProfilePage profile;
        int? eID;
        private int hours;
        private String testPrjNo;
        private String profilePrjNo;
        private String empNo, tempEID;
        private Boolean isAdmin = false;

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
            employee.Setup(conn);
            /*
            //QUICK LOGIN
            emailBox.Text = "iris@yahoo.com";
            passBox.Text = "******";
            */

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
                emailBox.Text = "";

                profile = new ProfilePage();
                profile.Setup(conn, eID);
                profile.GetHours(profileHoursTextBox);
                profile.GetEmail(profileEmailTextBox);
                profile.GetPhone(profilePhoneTextBox);
                profile.ListProjects(profileProjectGrid);
                edit.Setup(conn);
                isAdmin = profile.getAdmin();
                if(isAdmin == true)
                {
                    admin = new AdminPage();
                    admin.Setup(conn);
                    this.adminLabel.Visible = true;
                }
            }
            passBox.Text = "";


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
            this.adminLabel.Visible = false;
            this.adminBackPanel.Visible = false;

            //clear all data
            this.Clear();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = true;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.Clear();

            profile.GetHours(profileHoursTextBox);
            profile.GetEmail(profileEmailTextBox);
            profile.GetPhone(profilePhoneTextBox);
            profile.ListProjects(profileProjectGrid);
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = true;
            this.adminBackPanel.Visible = false;
            this.Clear();

            //dbconn = new DBConn();
            //conn = dbconn.Dbsetup();
            //edit.Setup(conn);

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
            this.adminBackPanel.Visible = false;
            this.Clear();

            employee.ListEmployees(searchEmployeesGrid, eID);
        }

        private void SchedulesButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = true;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.Clear();
        }

        private void ResetPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            this.adminBackPanel.Visible = false;

            employee.GetHours(employeePageHoursBox);
            employee.GetEmail(employeeEmailTextBox);
            employee.GetPhone(employeePhoneTextBox);
            employee.ListProjects(employeeProjectGrid);
            employee.NameDisplay(employeePageLabel);
        }

        private void SearchProjectsViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.EditID(testPrjNo);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageDueDateBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID, testPrjNo);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
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
            this.adminBackPanel.Visible = false;

            Clear();
            edit.setFlag(0);
            Console.WriteLine("Add Project. Flag set to 0");
        }


        // Button Functionality

        // Update Project
        private void ProjectPageUpdateButton_Click(object sender, EventArgs e)
        {
            //dbconn = new DBConn();
            //conn = dbconn.Dbsetup();
            //edit.Setup(conn);
            
            edit.EditProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDueDateBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID);
        }

        private void ProjectPageAddSelfButton_Click(object sender, EventArgs e)
        {
            //Boolean addedMyself = true;
            //String firstName = "";
            //String lastName = "";

            hours = int.Parse(projectPageEditEmployeeText.Text); //get hours from input box

            //String ret = "";
            edit.AssignMyself(hours, eID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);


            //edit.AssignEmployee(addedMyself, hours, eID);
            /* if (this.projectPageToBeAssignedListBox.SelectedIndex >= 0)
             {
                 this.projectPageToBeAssignedListBox.Items.RemoveAt(this.projectPageEmployeeList.SelectedIndex);
                 String ret = "";
                 String fullName = this.projectPageEmployeeList.ToString();
                 string[] names = fullName.Split(' ');
                 firstName = names[0];
                 lastName = names[1];
                 ret = edit.AssignEmployee(addedMyself, hours, eID, firstName, lastName);
                 projectPageEmployeeList.Items.Add(ret); 

             } //SZ, MM: add self button 
             NOTE: Was not working even before I changed to grid, definitely doesn't now. -Brad */
        }

        private void ProjectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            edit.Setup(conn);

            edit.AddNotes(eID, projectPagePNumBox, projectPageNotesTextBox);
            edit.DisplayNotes(notesGridView);
        }

        private void ProfileEditButton1_Click(object sender, EventArgs e)
        {
            profile.EditMyHours(profileHoursTextBox, eID);
            //profile.EditVacation(profileStartDate, profileEndDate);
        }

        private void ProjectPageRemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            String firstName = "Iris";
            String lastName = "Ivy";
            edit.RemoveEmployee(firstName, lastName);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            //edit.RemoveEmployee(firstName, lastName);
            /*if(this.projectPageEmployeeList.SelectedIndex >= 0)
            {
                this.projectPageEmployeeList.Items.RemoveAt(this.projectPageEmployeeList.SelectedIndex);
                String ret = "";
                String fullName = this.projectPageEmployeeList.ToString();
                string[] names = fullName.Split(' ');
                firstName = names[0];
                lastName = names[1];
                ret = edit.RemoveEmployee(firstName, lastName, eID);
                projectPageToBeAssignedListBox.Items.Add(ret);

            } Same note as before: wasn't working, changed to grid, now needs to be rewritten -Brad*/
        }

        private void ProjectPageAddEmployeeButton_Click(object sender, EventArgs e)
        {
            String fname = "Iris";
            String lname = "Ivy";
            hours = int.Parse(projectPageEditEmployeeText.Text);
            edit.AssignEmployee(hours, fname, lname);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);

        } //SZ, MM: add employee button 

        private void ProjectPageEditEmployeeText_TextChanged(object sender, EventArgs e)
        {
            
            hours = int.Parse(projectPageEditEmployeeText.Text);
            
        } //SZ, MM: input text box for hours



        private void Clear()
        {
            projectPagePNumBox.Text = projectPageDescriptionBox.Text = projectPagePhaseBox.Text = projectPageDeliverablesBox.Text = projectPageStatusBox.Text = "";
            projectPageHoursBox.Value = 0;
            profileHoursTextBox.Text =  profileEmailTextBox.Text = profilePhoneTextBox.Text = "";
            searchProjectsTextBox.Text = searchEmployeesTextBox.Text = "";
            employeePageHoursBox.Text =  employeeEmailTextBox.Text = employeePhoneTextBox.Text = "";
        }

        private void ProjectsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = projectsGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectsGrid.Rows[selectedRowIndex];
                //testPrjNo = selectedRow.Cells[0].Value.ToString();
                testPrjNo = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void ProfileProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (profileProjectGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = profileProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = profileProjectGrid.Rows[selectedRowIndex];
                profilePrjNo = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void ProfileViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.scheduleBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.EditID(profilePrjNo);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageDueDateBox, projectPagePhaseBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID, profilePrjNo);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.setFlag(1);
            Console.WriteLine("Edit Project. Flag set to 1");
        }

        private void SearchEmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searchEmployeesGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = searchEmployeesGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = searchEmployeesGrid.Rows[selectedRowIndex];
                empNo = selectedRow.Cells[0].Value.ToString();
                employee.SetID(empNo);
            }
        }

        private void ProfileEditButton2_Click(object sender, EventArgs e)
        {
            profile.EditContact(profileEmailTextBox, profilePhoneTextBox);
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            isAdmin = profile.getAdmin();
            if (isAdmin == true)
            {
                this.searchProjectsBG.Visible = false;
                this.profileBG.Visible = false;
                this.scheduleBG.Visible = false;
                this.employeePageBG.Visible = false;
                this.projectPageBG.Visible = false;
                this.searchEmployeesBG.Visible = false;
                this.adminBackPanel.Visible = true;

                admin.DisplayEmployees(adminEmployeeGrid);

            }
        }

        private void AdminRemoveUserButton_Click(object sender, EventArgs e)
        {
            admin.RemoveEmployee(tempEID);
            admin.DisplayEmployees(adminEmployeeGrid);
        }

        private void AdminUpdateUserButton_Click(object sender, EventArgs e)
        {
            admin.UpdateEmployee(tempEID, adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminHoursBox, adminCheckBox);
            admin.DisplayEmployees(adminEmployeeGrid);
        }

        private void AdminSelectUserButton_Click(object sender, EventArgs e)
        {
            admin.SelectEmployee(tempEID, adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminHoursBox, adminCheckBox);
        }

        private void AdminAddUserButton_Click(object sender, EventArgs e)
        {
            admin.NewEmployee(adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminPassBox, adminHoursBox, adminCheckBox);
            admin.DisplayEmployees(adminEmployeeGrid);
        }

        private void searchProjectsSearchButton_Click(object sender, EventArgs e)
        {
            edit.ProjectSearch(searchProjectsTextBox.Text, projectsGrid);
        }

        private void projectPageAddHoursButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminEmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (adminEmployeeGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = adminEmployeeGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = adminEmployeeGrid.Rows[selectedRowIndex];
                tempEID = selectedRow.Cells[0].Value.ToString();  
            }
        }
    }
}
