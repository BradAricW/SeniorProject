
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace EDGELook
{
    public partial class MainForm : Form
    {
        //initialize variables and setup
        PasswordPage passPage;
        LoginPage login;
        AdminPage admin;
        ReportPage report;
        ProjectPage edit;
        EmployeePage employee;
        private DBConn dbconn;
        private MySqlConnection conn;
        ProfilePage profile;
        private String eID;
        private int hours;
        private String testPrjNo;
        private String profilePrjNo;
        private String empNo, tempEID;
        private Boolean isAdmin = false;
        private String assignEID, removeEID;
        private String tempPhase, tempVac, tempEmpPrj;

        public MainForm()
        {
            InitializeComponent();
            //setup page classes and connections
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();

            login = new LoginPage();
            login.Setup(conn);

            passPage = new PasswordPage();
            passPage.Setup(conn);

            profile = new ProfilePage();
            profile.Setup(conn, eID);

            report = new ReportPage();
            report.Setup(conn);

            edit = new ProjectPage();
            edit.Setup(conn);

            employee = new EmployeePage();
            employee.Setup(conn);
        } //end MainForm

        //BUTTONS

        //Login Buttons
        private void LoginButton_Click(object sender, EventArgs e)
        {
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            login = new LoginPage();
            login.Setup(conn);
            employee = new EmployeePage();
            employee.Setup(conn);
            this.eID = login.Login(emailBox, passBox);
            int success;
            if (eID == null)
            {
                success = 0;
            }
            else
            {
                success = 1;
            }
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
                profile.GetName(profileFNameBox, profileLNameBox);
                profile.ListProjects(profileProjectGrid);
                profile.ListVacations(vacationsGrid);
                
                isAdmin = profile.GetAdmin();
                if(isAdmin == true)
                {
                    admin = new AdminPage();
                    admin.Setup(conn);
                    this.adminLabel.Visible = true;
                }
            }
            passBox.Text = "";


        } //end login button

        private void ResetPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = true;
            this.changePassBG.Visible = false;
        } //end reset password button

        //Password Buttons
        private void ResetButton_Click(object sender, EventArgs e)
        {
            passPage.ResetPass(resetBox);

            Clear();
            this.loginBG.Visible = true;
            this.taskbarMenu.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
        } //end password reset button

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            passPage.ChangePass(currentPassBox, newPassBox, eID);

            currentPassBox.Text = newPassBox.Text = "";

            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = true;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
        } //end password change button

        private void ResetPassExitLabel_Click(object sender, EventArgs e)
        {
            Clear();
            this.loginBG.Visible = true;
            this.taskbarMenu.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
        } //end reset pass exit button

        private void ChangePassExitLabel_Click(object sender, EventArgs e)
        {
            Clear();
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = true;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            profile.GetHours(profileHoursTextBox);
            profile.GetEmail(profileEmailTextBox);
            profile.GetPhone(profilePhoneTextBox);
            profile.GetName(profileFNameBox, profileLNameBox);
            profile.ListProjects(profileProjectGrid);
            profile.ListVacations(vacationsGrid);
        } //end change pass exit button

        //Taskbar Buttons
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
            this.reportsBG.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            //clear all data
            Clear();
        } //end signout button

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = true;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
            Clear();

            profile.GetHours(profileHoursTextBox);
            profile.GetEmail(profileEmailTextBox);
            profile.GetPhone(profilePhoneTextBox);
            profile.ListProjects(profileProjectGrid);
            profile.ListVacations(vacationsGrid);
            profile.GetName(profileFNameBox, profileLNameBox);
        } //end home button

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = true;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
            Clear();

            edit.ListProjects(projectsGrid, eID);
        } //end project button

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
            Clear();

            employee.ListEmployees(searchEmployeesGrid, eID);
        } //end employees button

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = true;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;
            Clear();

            report.ListProjects(weeklyReportGrid);
            report.ListVacations(vacationReportGrid);
        } //end reports button

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            isAdmin = profile.GetAdmin();
            if (isAdmin == true)
            {
                this.signOutLabel.Visible = true;
                this.loginBG.Visible = false;
                this.taskbarMenu.Visible = true;
                this.searchProjectsBG.Visible = false;
                this.profileBG.Visible = false;
                this.reportsBG.Visible = false;
                this.employeePageBG.Visible = false;
                this.projectPageBG.Visible = false;
                this.searchEmployeesBG.Visible = false;
                this.adminBackPanel.Visible = true;
                this.resetPassBG.Visible = false;
                this.changePassBG.Visible = false;

                admin.DisplayEmployees(adminEmployeeGrid);

            }
        } //end admin button

        //Admin Buttons
        private void AdminClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        } //end admin clear button

        private void AdminResetPasswordButton_Click(object sender, EventArgs e)
        {
            admin.ResetPassword(adminEmployeeIDBox, adminPassBox);
        } //end admin reset password button

        private void AdminUpdateUserButton_Click(object sender, EventArgs e)
        {
            admin.UpdateEmployee(adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminHoursBox, adminCheckBox, activeCheckBox);
            admin.DisplayEmployees(adminEmployeeGrid);
        } //end admin update user button

        private void AdminSelectUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tempEID);
            admin.SelectEmployee(tempEID, adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminHoursBox, adminCheckBox, activeCheckBox);
        } // end admin select user button

        private void AdminAddUserButton_Click(object sender, EventArgs e)
        {
            if (adminEmployeeIDBox.Text == "" || adminEmployeeIDBox.Text == null)
            {
                MessageBox.Show("Please add employee ID");
            }
            else if (adminEmailBox.Text == "" || adminEmailBox.Text == null)
            {
                MessageBox.Show("Please add employee email");
            }
            else if (adminPassBox.Text == "" || adminPassBox.Text == null)
            {
                MessageBox.Show("Please add employee password");
            }
            else
            {
                admin.NewEmployee(adminEmployeeIDBox, adminFNameBox, adminLNameBox, adminEmailBox, adminPhoneBox, adminPassBox, adminHoursBox, adminCheckBox, activeCheckBox);
                admin.DisplayEmployees(adminEmployeeGrid);

            }
        } // end admin add user button

        //Profile Buttons
        private void ProfileChangePassButton_Click(object sender, EventArgs e)
        {
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = true;
        } //end profile change password button

        private void ProfileViewButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            Clear();
            edit.EditID(profilePrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, profilePrjNo, completeCheckBox);
            edit.HoursDisplay(projectHoursLabel2);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        } //end profile view button

        private void ProfileEditContactButton_Click(object sender, EventArgs e)
        {
            profile.EditContact(profileEmailTextBox, profilePhoneTextBox, profileFNameBox, profileLNameBox);
        } //end profile edit contact button

        private void AddVacationButton_Click(object sender, EventArgs e)
        {
            profile.EditVacation(profileStartDate, profileEndDate);
            profile.ListVacations(vacationsGrid);
        } //end profile add vacation button

        private void RemoveVacationButton_Click(object sender, EventArgs e)
        {
            profile.RemoveVacation(tempVac);
            profile.ListVacations(vacationsGrid);
        } //end profile remove vacation button

        private void ProfileEditProjectHoursButton_Click(object sender, EventArgs e)
        {
            profile.EditProjectHours(profileProjectHoursBox, profilePrjNo);
            profile.ListProjects(profileProjectGrid);
            profile.GetHours(profileHoursTextBox);
        } //end profile edit project hours button

        private void ProfileEditHoursButton_Click(object sender, EventArgs e)
        {
            profile.EditMyHours(profileHoursTextBox);
        } //end profile edit hours button

        //Search Project Page Buttons
        private void SearchProjectsViewButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            Clear();
            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.HoursDisplay(projectHoursLabel2);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        } //end search projects view button

        private void SearchProjectsPageAddProjectButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            Clear();
            edit.SetFlag(0);
            edit.EditID(null);
            edit.ListPhases(phasesGrid);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
        } //end search projects page add project button

        private void SearchProjectsSearchButton_Click(object sender, EventArgs e)
        {
            bool pRadioChecked = projectNumRadioButton.Checked;
            bool dRadioChecked = projectDescriptionRadioButton.Checked;
            bool lRadioChecked = projectLeaderRadioButton.Checked;
            int passable;

            if (pRadioChecked == true)
            {
                passable = 1;
            }
            else if (dRadioChecked == true)
            {
                passable = 2;
            }
            else if (lRadioChecked == true)
            {
                passable = 3;
            }
            else
            {
                passable = 4;
            }
            edit.ProjectSearch(searchProjectsTextBox.Text, projectsGrid, passable);
        }   //end project search button

        //Project Page Buttons
        private void ProjectPageUpdateHoursButton_Click(object sender, EventArgs e)
        {
            try { hours = int.Parse(projectPageEditEmployeeText.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            edit.AssignEmployee(hours, removeEID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.HoursDisplay(projectHoursLabel2);
        } //end project page update hours button

        private void ProjectPageUpdateButton_Click(object sender, EventArgs e)
        {
            if (projectPagePNumBox.Text == "" || projectPagePNumBox.Text == null)
            {
                MessageBox.Show("Must enter project number");
            }
            else
            {
                edit.SetCompleteIncomplete(completeCheckBox);
                edit.EditProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID);

                testPrjNo = projectPagePNumBox.Text;
                edit.EditID(testPrjNo);
                edit.ListPhases(phasesGrid);
                edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
                edit.HoursDisplay(projectHoursLabel2);
                edit.DisplayNotes(notesGridView);
                edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
                edit.SetFlag(1);
            }
        } //end project page update button

        private void ProjectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            edit.AddNotes(eID, projectPagePNumBox, projectPageNotesTextBox);
            edit.DisplayNotes(notesGridView);
        } //end project page add notes button

        private void ProjectPageRemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            edit.RemoveEmployee(removeEID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
        } //end project page Remove Employee button

        private void ProjectPageAddEmployeeButton_Click(object sender, EventArgs e)
        {
            try { hours = int.Parse(projectPageEditEmployeeText.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            edit.AssignEmployee(hours, assignEID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.HoursDisplay(projectHoursLabel2);

        } //end project page Add Employee button

        private void ProjectPageUpdatePhaseButton_Click(object sender, EventArgs e)
        {
            testPrjNo = projectPagePNumBox.Text;
            edit.UpdatePhase(projectPagePhaseBox, projectPageDueDateBox, projectPageStatusBox);

            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.HoursDisplay(projectHoursLabel2);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        } //end project page edit phase button

        private void EditLeaderButton_Click(object sender, EventArgs e)
        {
            try { hours = int.Parse(projectPageEditEmployeeText.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            edit.UpdateLeader(assignEID);
            edit.AssignEmployee(hours, assignEID);

            testPrjNo = projectPagePNumBox.Text;
            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.HoursDisplay(projectHoursLabel2);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.HoursDisplay(projectHoursLabel2);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        } //end project page edit leader button

        //Search Employee Page Buttons
        private void SearchEmployeesViewButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = true;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            employee.GetHours(employeePageHoursBox);
            employee.GetEmail(employeeEmailTextBox);
            employee.GetPhone(employeePhoneTextBox);
            employee.ListProjects(employeeProjectGrid);
            employee.NameDisplay(employeePageLabel);
            employee.ListVacations(employeeVacationsGrid);
            employee.GetName(employeeFNameBox, employeeLNameBox);
        } //end search employees view button

        private void SearchEmployeesButton_Click(object sender, EventArgs e)
        {
            employee.EmployeeSearch(searchEmployeesTextBox.Text, searchEmployeesGrid);
        } //end search employees button

        //Employee Page Buttons
        private void EmployeePageViewButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;
            this.resetPassBG.Visible = false;
            this.changePassBG.Visible = false;

            Clear();
            edit.EditID(tempEmpPrj);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, tempEmpPrj, completeCheckBox);
            edit.HoursDisplay(projectHoursLabel2);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        } //end employee page view button

        //Reports Buttons
        private void WeeklyReportButton_Click(object sender, EventArgs e)
        {
            report.CreateReport(weeklyReportGrid);
        } //end weekly report button

        private void VacationReportButton_Click(object sender, EventArgs e)
        {
            report.CreateReport(vacationReportGrid);
        } //end vacation report button

        //GRIDS

        //profile grids
        private void ProfileProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (profileProjectGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = profileProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = profileProjectGrid.Rows[selectedRowIndex];
                profilePrjNo = selectedRow.Cells[0].Value.ToString();
                profileProjectHoursBox.Text = profile.GetProjHours(profilePrjNo).ToString();
            }
        } //end profile projects grid

        private void VacationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vacationsGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = vacationsGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = vacationsGrid.Rows[selectedRowIndex];
                tempVac = selectedRow.Cells[0].Value.ToString();
            }
        } //end profile vacations grid

        //project grids

        private void ProjectsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = projectsGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectsGrid.Rows[selectedRowIndex];
                testPrjNo = selectedRow.Cells[2].Value.ToString();
            }
        } //end projects grid

        private void ProjectPageAssignmentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectPageAssignmentGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = projectPageAssignmentGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectPageAssignmentGrid.Rows[selectedRowIndex];
                assignEID = selectedRow.Cells[0].Value.ToString();
            }
        } //end project page assignment grid

        private void ProjectPageOnProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectPageOnProjectGrid.SelectedCells.Count > 0)
            {

                int selectedRowIndex = projectPageOnProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectPageOnProjectGrid.Rows[selectedRowIndex];
                removeEID = selectedRow.Cells[0].Value.ToString();
            }
        } //end project page on project grid

        private void PhasesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (phasesGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = phasesGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = phasesGrid.Rows[selectedRowIndex];
                tempPhase = selectedRow.Cells[0].Value.ToString();
            }
        } //end project page phases grid

        //employee grids
        private void SearchEmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searchEmployeesGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = searchEmployeesGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = searchEmployeesGrid.Rows[selectedRowIndex];
                empNo = selectedRow.Cells[0].Value.ToString();
                employee.SetID(empNo);
            }
        } //end search employees grid
               
        private void EmployeeProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeProjectGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = employeeProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeeProjectGrid.Rows[selectedRowIndex];
                tempEmpPrj = selectedRow.Cells[0].Value.ToString();
            }
        } //end employee project grid

        //admin grids
        private void AdminEmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (adminEmployeeGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = adminEmployeeGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = adminEmployeeGrid.Rows[selectedRowIndex];
                tempEID = selectedRow.Cells[0].Value.ToString();
                MessageBox.Show(tempEID);
            }
        } //end admin grid

        //other functions
        private void Clear()
        {
            projectPagePNumBox.Text = projectPageDescriptionBox.Text = projectPagePhaseBox.Text = projectPageDeliverablesBox.Text = projectPageStatusBox.Text = "";
            projectPageLeaderFNameBox.Text = projectPageLeaderLNameBox.Text = "";
            projectPageHoursBox.Value = 0;
            adminEmailBox.Text = adminEmployeeIDBox.Text = adminFNameBox.Text = adminHoursBox.Text = adminLNameBox.Text = adminPassBox.Text = adminPhoneBox.Text = "";
            profileFNameBox.Text = profileLNameBox.Text = profileHoursTextBox.Text = profileEmailTextBox.Text = profilePhoneTextBox.Text = "";
            searchProjectsTextBox.Text = searchEmployeesTextBox.Text = "";
            employeeFNameBox.Text = employeeLNameBox.Text = employeePageHoursBox.Text = employeeEmailTextBox.Text = employeePhoneTextBox.Text = "";
        }
    }//end class
}//end namespace
