
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
        
        LoginPage login;
        AdminPage admin;
        ReportPage report;
        ProjectPage edit;
        EmployeePage employee;
        private DBConn dbconn;
        private MySqlConnection conn;
        ProfilePage profile;
        int? eID;
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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //setup Connection object
            dbconn = new DBConn();
            conn = dbconn.Dbsetup();
            login = new LoginPage();
            login.Setup(conn);
            employee = new EmployeePage();
            employee.Setup(conn);

            ////QUICK LOGIN
            //emailBox.Text = "iris@yahoo.com";
            //passBox.Text = "******";


            eID = login.Login(emailBox, passBox);
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
                report = new ReportPage();
                report.Setup(conn);
                edit = new ProjectPage();
                edit.Setup(conn);
                isAdmin = profile.GetAdmin();
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
            Clear();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = true;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            Clear();

            profile.GetHours(profileHoursTextBox);
            profile.GetEmail(profileEmailTextBox);
            profile.GetPhone(profilePhoneTextBox);
            profile.ListProjects(profileProjectGrid);
            profile.ListVacations(vacationsGrid);
            profile.GetName(profileFNameBox, profileLNameBox);
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = true;
            this.adminBackPanel.Visible = false;
            Clear();

            edit.ListProjects(projectsGrid, eID);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = true;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            Clear();

            employee.ListEmployees(searchEmployeesGrid, eID);
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.reportsBG.Visible = true;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = false;
            this.searchEmployeesBG.Visible = false;
            this.searchProjectsBG.Visible = false;
            this.adminBackPanel.Visible = false;
            Clear();

            report.ListProjects(weeklyReportGrid);
            report.ListVacations(vacationReportGrid);
        }

        private void ResetPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SearchEmployeesViewButton_Click(object sender, EventArgs e)
        {
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
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
            employee.ListVacations(employeeVacationsGrid);
            employee.GetName(employeeFNameBox, employeeLNameBox);
        }

        private void SearchProjectsViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        }

        private void SearchProjectsPageAddProjectButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.SetFlag(0);
            edit.EditID(null);
            edit.ListPhases(phasesGrid);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
        }


        // Button Functionality

        // Update Project
        private void ProjectPageUpdateButton_Click(object sender, EventArgs e)
        {
            edit.SetCompleteIncomplete(completeCheckBox);
            edit.EditProject(projectPagePNumBox, projectPageDescriptionBox, projectPageDeliverablesBox, projectPageHoursBox, projectPageStatusBox, eID);

            testPrjNo = projectPagePNumBox.Text;
            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        }

        private void ProjectPageAddNotesButton_Click(object sender, EventArgs e)
        {
            edit.AddNotes(eID, projectPagePNumBox, projectPageNotesTextBox);
            edit.DisplayNotes(notesGridView);
        }

        private void ProjectPageRemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            edit.RemoveEmployee(removeEID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
        } //Remove Employee 

        private void ProjectPageAddEmployeeButton_Click(object sender, EventArgs e)
        {
            try { hours = int.Parse(projectPageEditEmployeeText.Text); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            edit.AssignEmployee(hours, assignEID);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);

        } //Add Employee

        private void Clear()
        {
            projectPagePNumBox.Text = projectPageDescriptionBox.Text = projectPagePhaseBox.Text = projectPageDeliverablesBox.Text = projectPageStatusBox.Text = "";
            projectPageLeaderFNameBox.Text = projectPageLeaderLNameBox.Text = "";
            projectPageHoursBox.Value = 0;
            profileFNameBox.Text = profileLNameBox.Text = profileHoursTextBox.Text =  profileEmailTextBox.Text = profilePhoneTextBox.Text = "";
            searchProjectsTextBox.Text = searchEmployeesTextBox.Text = "";
            employeeFNameBox.Text = employeeLNameBox.Text = employeePageHoursBox.Text = employeeEmailTextBox.Text = employeePhoneTextBox.Text = "";
        }

        private void ProjectsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = projectsGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectsGrid.Rows[selectedRowIndex];
                //testPrjNo = selectedRow.Cells[0].Value.ToString();
                testPrjNo = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void ProfileProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (profileProjectGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = profileProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = profileProjectGrid.Rows[selectedRowIndex];
                profilePrjNo = selectedRow.Cells[0].Value.ToString();
                profileProjectHoursBox.Text = profile.GetProjHours(profilePrjNo).ToString();
            }
        }

        private void ProfileViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.EditID(profilePrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, profilePrjNo, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
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

        private void ProfileEditContactButton_Click(object sender, EventArgs e)
        {
            profile.EditContact(profileEmailTextBox, profilePhoneTextBox);
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            isAdmin = profile.GetAdmin();
            if (isAdmin == true)
            {
                this.searchProjectsBG.Visible = false;
                this.profileBG.Visible = false;
                this.reportsBG.Visible = false;
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
        }

        private void ProjectPageAddHoursButton_Click(object sender, EventArgs e)
        {

        }

       

        private void ProjectPageAssignmentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectPageAssignmentGrid.SelectedCells.Count > 0) {
                int selectedRowIndex = projectPageAssignmentGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = projectPageAssignmentGrid.Rows[selectedRowIndex];
                assignEID = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void ProjectPageOnProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectPageOnProjectGrid.SelectedCells.Count > 0)
            {

            int selectedRowIndex = projectPageOnProjectGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = projectPageOnProjectGrid.Rows[selectedRowIndex];
            removeEID = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void SearchEmployeesButton_Click(object sender, EventArgs e)
        {
            employee.EmployeeSearch(searchEmployeesTextBox.Text, searchEmployeesGrid);
        }

        private void PhasesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (phasesGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = phasesGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = phasesGrid.Rows[selectedRowIndex];
                tempPhase = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void AddVacationButton_Click(object sender, EventArgs e)
        {
            profile.EditVacation(profileStartDate, profileEndDate);
            profile.ListVacations(vacationsGrid);
        }

        private void RemoveVacationButton_Click(object sender, EventArgs e)
        {
            profile.RemoveVacation(tempVac);
            profile.ListVacations(vacationsGrid);
        }

        private void ProfileEditProjectHoursButton_Click(object sender, EventArgs e)
        {
            profile.EditProjectHours(profileProjectHoursBox, profilePrjNo);
            profile.ListProjects(profileProjectGrid);
            profile.GetHours(profileHoursTextBox);
        }

        private void ProfileEditHoursButton_Click(object sender, EventArgs e)
        {
            profile.EditMyHours(profileHoursTextBox);
        }

        private void WeeklyReportButton_Click(object sender, EventArgs e)
        {
            report.CreateReport(weeklyReportGrid);
        }

        private void VacationReportButton_Click(object sender, EventArgs e)
        {
            report.CreateReport(vacationReportGrid);
        }

        private void ProjectPageUpdatePhaseButton_Click(object sender, EventArgs e)
        {
            testPrjNo = projectPagePNumBox.Text;
            edit.UpdatePhase(projectPagePhaseBox, projectPageDueDateBox, projectPageStatusBox);
                        
            edit.EditID(testPrjNo);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        }

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
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, testPrjNo, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
        }

        private void ProfileChangePassButton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePageViewButton_Click(object sender, EventArgs e)
        {
            this.searchProjectsBG.Visible = false;
            this.profileBG.Visible = false;
            this.reportsBG.Visible = false;
            this.employeePageBG.Visible = false;
            this.projectPageBG.Visible = true;
            this.searchEmployeesBG.Visible = false;
            this.adminBackPanel.Visible = false;

            Clear();
            edit.EditID(tempEmpPrj);
            edit.ListPhases(phasesGrid);
            edit.AutoDisplay(projectPagePNumBox, projectPageDescriptionBox, projectPageLeaderLNameBox, projectPageLeaderFNameBox, projectPageDeliverablesBox, projectPageHoursBox, tempEmpPrj, completeCheckBox);
            edit.DisplayNotes(notesGridView);
            edit.DisplayEmployees(projectPageAssignmentGrid, projectPageOnProjectGrid);
            edit.SetFlag(1);
            Console.WriteLine("Edit Project. Flag set to 1");
        }

        private void EmployeeProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeProjectGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = employeeProjectGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeeProjectGrid.Rows[selectedRowIndex];
                tempEmpPrj = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void VacationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vacationsGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = vacationsGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = vacationsGrid.Rows[selectedRowIndex];
                tempVac = selectedRow.Cells[0].Value.ToString();
            }
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
