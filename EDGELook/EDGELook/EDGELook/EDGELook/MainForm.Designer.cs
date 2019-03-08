namespace EDGELook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBackPanel = new System.Windows.Forms.Panel();
            this.titleFrontPanel = new System.Windows.Forms.Panel();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.eMailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.taskbarMenu = new System.Windows.Forms.Panel();
            this.schedulesButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.profileBackPanel = new System.Windows.Forms.Panel();
            this.profileHoursTextBox = new System.Windows.Forms.TextBox();
            this.profileProjectList = new System.Windows.Forms.ListBox();
            this.profileEmailLabel = new System.Windows.Forms.Label();
            this.profilePhoneLabel = new System.Windows.Forms.Label();
            this.profileEndLabel = new System.Windows.Forms.Label();
            this.profileStartLabel = new System.Windows.Forms.Label();
            this.profileHoursLabel2 = new System.Windows.Forms.Label();
            this.profileProjectsLabel = new System.Windows.Forms.Label();
            this.profileContactLabel = new System.Windows.Forms.Label();
            this.profileVacationLabel = new System.Windows.Forms.Label();
            this.profileHoursLabel1 = new System.Windows.Forms.Label();
            this.profileViewButton = new System.Windows.Forms.Button();
            this.profileEditButton3 = new System.Windows.Forms.Button();
            this.profileEditButton1 = new System.Windows.Forms.Button();
            this.profileEditButton2 = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.formBGTemp = new System.Windows.Forms.Panel();
            this.loginBG = new System.Windows.Forms.Panel();
            this.profileBG = new System.Windows.Forms.Panel();
            this.titleBackPanel.SuspendLayout();
            this.titleFrontPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.taskbarMenu.SuspendLayout();
            this.profileBackPanel.SuspendLayout();
            this.loginBG.SuspendLayout();
            this.profileBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBackPanel
            // 
            this.titleBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.titleBackPanel.Controls.Add(this.titleFrontPanel);
            this.titleBackPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBackPanel.Name = "titleBackPanel";
            this.titleBackPanel.Size = new System.Drawing.Size(925, 65);
            this.titleBackPanel.TabIndex = 0;
            // 
            // titleFrontPanel
            // 
            this.titleFrontPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.titleFrontPanel.Controls.Add(this.signOutLabel);
            this.titleFrontPanel.Controls.Add(this.titleLabel);
            this.titleFrontPanel.Location = new System.Drawing.Point(0, 0);
            this.titleFrontPanel.Name = "titleFrontPanel";
            this.titleFrontPanel.Size = new System.Drawing.Size(925, 55);
            this.titleFrontPanel.TabIndex = 0;
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutLabel.ForeColor = System.Drawing.Color.White;
            this.signOutLabel.Location = new System.Drawing.Point(839, 9);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(58, 16);
            this.signOutLabel.TabIndex = 2;
            this.signOutLabel.Text = "Sign Out";
            this.signOutLabel.Visible = false;
            this.signOutLabel.Click += new System.EventHandler(this.SignOutLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(360, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(206, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "EDGELook";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passBox);
            this.loginPanel.Controls.Add(this.emailBox);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Controls.Add(this.eMailLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Location = new System.Drawing.Point(312, 75);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(300, 242);
            this.loginPanel.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(183, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Create Account]";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(188, 150);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(83, 112);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(180, 20);
            this.passBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(83, 75);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(180, 20);
            this.emailBox.TabIndex = 3;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(10, 113);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 15);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password: ";
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailLabel.ForeColor = System.Drawing.Color.White;
            this.eMailLabel.Location = new System.Drawing.Point(32, 76);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(45, 15);
            this.eMailLabel.TabIndex = 1;
            this.eMailLabel.Text = "Email: ";
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(121, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 24);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // taskbarMenu
            // 
            this.taskbarMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.taskbarMenu.Controls.Add(this.schedulesButton);
            this.taskbarMenu.Controls.Add(this.employeesButton);
            this.taskbarMenu.Controls.Add(this.projectsButton);
            this.taskbarMenu.Controls.Add(this.homeButton);
            this.taskbarMenu.Location = new System.Drawing.Point(0, 65);
            this.taskbarMenu.Name = "taskbarMenu";
            this.taskbarMenu.Size = new System.Drawing.Size(925, 40);
            this.taskbarMenu.TabIndex = 12;
            this.taskbarMenu.Visible = false;
            // 
            // schedulesButton
            // 
            this.schedulesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.schedulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulesButton.Location = new System.Drawing.Point(562, 0);
            this.schedulesButton.Name = "schedulesButton";
            this.schedulesButton.Size = new System.Drawing.Size(100, 40);
            this.schedulesButton.TabIndex = 3;
            this.schedulesButton.Text = "Schedules";
            this.schedulesButton.UseVisualStyleBackColor = true;
            this.schedulesButton.Click += new System.EventHandler(this.SchedulesButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.Location = new System.Drawing.Point(462, 0);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(100, 40);
            this.employeesButton.TabIndex = 2;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.projectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsButton.Location = new System.Drawing.Point(362, 0);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Size = new System.Drawing.Size(100, 40);
            this.projectsButton.TabIndex = 1;
            this.projectsButton.Text = "Projects";
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.ProjectsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(262, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 40);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // profileBackPanel
            // 
            this.profileBackPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profileBackPanel.Controls.Add(this.profileHoursTextBox);
            this.profileBackPanel.Controls.Add(this.profileProjectList);
            this.profileBackPanel.Controls.Add(this.profileEmailLabel);
            this.profileBackPanel.Controls.Add(this.profilePhoneLabel);
            this.profileBackPanel.Controls.Add(this.profileEndLabel);
            this.profileBackPanel.Controls.Add(this.profileStartLabel);
            this.profileBackPanel.Controls.Add(this.profileHoursLabel2);
            this.profileBackPanel.Controls.Add(this.profileProjectsLabel);
            this.profileBackPanel.Controls.Add(this.profileContactLabel);
            this.profileBackPanel.Controls.Add(this.profileVacationLabel);
            this.profileBackPanel.Controls.Add(this.profileHoursLabel1);
            this.profileBackPanel.Controls.Add(this.profileViewButton);
            this.profileBackPanel.Controls.Add(this.profileEditButton3);
            this.profileBackPanel.Controls.Add(this.profileEditButton1);
            this.profileBackPanel.Controls.Add(this.profileEditButton2);
            this.profileBackPanel.Location = new System.Drawing.Point(315, 61);
            this.profileBackPanel.Name = "profileBackPanel";
            this.profileBackPanel.Size = new System.Drawing.Size(300, 327);
            this.profileBackPanel.TabIndex = 13;
            // 
            // profileHoursTextBox
            // 
            this.profileHoursTextBox.Location = new System.Drawing.Point(60, 37);
            this.profileHoursTextBox.Name = "profileHoursTextBox";
            this.profileHoursTextBox.Size = new System.Drawing.Size(35, 20);
            this.profileHoursTextBox.TabIndex = 14;
            // 
            // profileProjectList
            // 
            this.profileProjectList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.profileProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileProjectList.FormattingEnabled = true;
            this.profileProjectList.ItemHeight = 15;
            this.profileProjectList.Location = new System.Drawing.Point(0, 235);
            this.profileProjectList.Name = "profileProjectList";
            this.profileProjectList.ScrollAlwaysVisible = true;
            this.profileProjectList.Size = new System.Drawing.Size(300, 64);
            this.profileProjectList.TabIndex = 13;
            // 
            // profileEmailLabel
            // 
            this.profileEmailLabel.AutoSize = true;
            this.profileEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileEmailLabel.Location = new System.Drawing.Point(8, 190);
            this.profileEmailLabel.Name = "profileEmailLabel";
            this.profileEmailLabel.Size = new System.Drawing.Size(45, 15);
            this.profileEmailLabel.TabIndex = 12;
            this.profileEmailLabel.Text = "Email: ";
            // 
            // profilePhoneLabel
            // 
            this.profilePhoneLabel.AutoSize = true;
            this.profilePhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.profilePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profilePhoneLabel.Location = new System.Drawing.Point(8, 170);
            this.profilePhoneLabel.Name = "profilePhoneLabel";
            this.profilePhoneLabel.Size = new System.Drawing.Size(59, 15);
            this.profilePhoneLabel.TabIndex = 11;
            this.profilePhoneLabel.Text = "Phone #: ";
            // 
            // profileEndLabel
            // 
            this.profileEndLabel.AutoSize = true;
            this.profileEndLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileEndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileEndLabel.Location = new System.Drawing.Point(110, 109);
            this.profileEndLabel.Name = "profileEndLabel";
            this.profileEndLabel.Size = new System.Drawing.Size(32, 15);
            this.profileEndLabel.TabIndex = 10;
            this.profileEndLabel.Text = "End:";
            // 
            // profileStartLabel
            // 
            this.profileStartLabel.AutoSize = true;
            this.profileStartLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileStartLabel.Location = new System.Drawing.Point(8, 109);
            this.profileStartLabel.Name = "profileStartLabel";
            this.profileStartLabel.Size = new System.Drawing.Size(38, 15);
            this.profileStartLabel.TabIndex = 9;
            this.profileStartLabel.Text = "Start: ";
            // 
            // profileHoursLabel2
            // 
            this.profileHoursLabel2.AutoSize = true;
            this.profileHoursLabel2.BackColor = System.Drawing.Color.Transparent;
            this.profileHoursLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileHoursLabel2.Location = new System.Drawing.Point(8, 38);
            this.profileHoursLabel2.Name = "profileHoursLabel2";
            this.profileHoursLabel2.Size = new System.Drawing.Size(46, 15);
            this.profileHoursLabel2.TabIndex = 8;
            this.profileHoursLabel2.Text = "Hours: ";
            // 
            // profileProjectsLabel
            // 
            this.profileProjectsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileProjectsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.profileProjectsLabel.Location = new System.Drawing.Point(0, 213);
            this.profileProjectsLabel.Name = "profileProjectsLabel";
            this.profileProjectsLabel.Size = new System.Drawing.Size(300, 20);
            this.profileProjectsLabel.TabIndex = 7;
            this.profileProjectsLabel.Text = "Projects";
            // 
            // profileContactLabel
            // 
            this.profileContactLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileContactLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.profileContactLabel.Location = new System.Drawing.Point(0, 142);
            this.profileContactLabel.Name = "profileContactLabel";
            this.profileContactLabel.Size = new System.Drawing.Size(300, 20);
            this.profileContactLabel.TabIndex = 6;
            this.profileContactLabel.Text = "Contact Information";
            // 
            // profileVacationLabel
            // 
            this.profileVacationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileVacationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileVacationLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.profileVacationLabel.Location = new System.Drawing.Point(1, 71);
            this.profileVacationLabel.Name = "profileVacationLabel";
            this.profileVacationLabel.Size = new System.Drawing.Size(300, 20);
            this.profileVacationLabel.TabIndex = 5;
            this.profileVacationLabel.Text = "Vacation Dates";
            // 
            // profileHoursLabel1
            // 
            this.profileHoursLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileHoursLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileHoursLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.profileHoursLabel1.Location = new System.Drawing.Point(0, 0);
            this.profileHoursLabel1.Name = "profileHoursLabel1";
            this.profileHoursLabel1.Size = new System.Drawing.Size(300, 20);
            this.profileHoursLabel1.TabIndex = 4;
            this.profileHoursLabel1.Text = "Hours Available";
            // 
            // profileViewButton
            // 
            this.profileViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileViewButton.FlatAppearance.BorderSize = 0;
            this.profileViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileViewButton.ForeColor = System.Drawing.Color.Snow;
            this.profileViewButton.Location = new System.Drawing.Point(113, 301);
            this.profileViewButton.Name = "profileViewButton";
            this.profileViewButton.Size = new System.Drawing.Size(75, 23);
            this.profileViewButton.TabIndex = 3;
            this.profileViewButton.Text = "View";
            this.profileViewButton.UseVisualStyleBackColor = false;
            // 
            // profileEditButton3
            // 
            this.profileEditButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileEditButton3.FlatAppearance.BorderSize = 0;
            this.profileEditButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileEditButton3.ForeColor = System.Drawing.Color.Snow;
            this.profileEditButton3.Location = new System.Drawing.Point(221, 176);
            this.profileEditButton3.Name = "profileEditButton3";
            this.profileEditButton3.Size = new System.Drawing.Size(75, 23);
            this.profileEditButton3.TabIndex = 2;
            this.profileEditButton3.Text = "Edit";
            this.profileEditButton3.UseVisualStyleBackColor = false;
            // 
            // profileEditButton1
            // 
            this.profileEditButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileEditButton1.FlatAppearance.BorderSize = 0;
            this.profileEditButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileEditButton1.ForeColor = System.Drawing.Color.Snow;
            this.profileEditButton1.Location = new System.Drawing.Point(221, 34);
            this.profileEditButton1.Name = "profileEditButton1";
            this.profileEditButton1.Size = new System.Drawing.Size(75, 23);
            this.profileEditButton1.TabIndex = 0;
            this.profileEditButton1.Text = "Edit";
            this.profileEditButton1.UseVisualStyleBackColor = false;
            // 
            // profileEditButton2
            // 
            this.profileEditButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileEditButton2.FlatAppearance.BorderSize = 0;
            this.profileEditButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileEditButton2.ForeColor = System.Drawing.Color.Snow;
            this.profileEditButton2.Location = new System.Drawing.Point(221, 105);
            this.profileEditButton2.Name = "profileEditButton2";
            this.profileEditButton2.Size = new System.Drawing.Size(75, 23);
            this.profileEditButton2.TabIndex = 1;
            this.profileEditButton2.Text = "Edit";
            this.profileEditButton2.UseVisualStyleBackColor = false;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileLabel.Location = new System.Drawing.Point(411, 34);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(92, 24);
            this.profileLabel.TabIndex = 14;
            this.profileLabel.Text = "My Profile";
            // 
            // formBGTemp
            // 
            this.formBGTemp.Location = new System.Drawing.Point(0, 105);
            this.formBGTemp.Name = "formBGTemp";
            this.formBGTemp.Size = new System.Drawing.Size(910, 465);
            this.formBGTemp.TabIndex = 16;
            this.formBGTemp.Visible = false;
            // 
            // loginBG
            // 
            this.loginBG.Controls.Add(this.loginPanel);
            this.loginBG.Location = new System.Drawing.Point(0, 105);
            this.loginBG.Name = "loginBG";
            this.loginBG.Size = new System.Drawing.Size(910, 465);
            this.loginBG.TabIndex = 17;
            // 
            // profileBG
            // 
            this.profileBG.Controls.Add(this.profileBackPanel);
            this.profileBG.Controls.Add(this.profileLabel);
            this.profileBG.Location = new System.Drawing.Point(0, 105);
            this.profileBG.Name = "profileBG";
            this.profileBG.Size = new System.Drawing.Size(910, 465);
            this.profileBG.TabIndex = 18;
            this.profileBG.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 561);
            this.Controls.Add(this.taskbarMenu);
            this.Controls.Add(this.titleBackPanel);
            this.Controls.Add(this.formBGTemp);
            this.Controls.Add(this.loginBG);
            this.Controls.Add(this.profileBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EDGELook";
            this.titleBackPanel.ResumeLayout(false);
            this.titleFrontPanel.ResumeLayout(false);
            this.titleFrontPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.taskbarMenu.ResumeLayout(false);
            this.profileBackPanel.ResumeLayout(false);
            this.profileBackPanel.PerformLayout();
            this.loginBG.ResumeLayout(false);
            this.profileBG.ResumeLayout(false);
            this.profileBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBackPanel;
        private System.Windows.Forms.Panel titleFrontPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.Panel taskbarMenu;
        private System.Windows.Forms.Button schedulesButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel profileBackPanel;
        private System.Windows.Forms.TextBox profileHoursTextBox;
        private System.Windows.Forms.ListBox profileProjectList;
        private System.Windows.Forms.Label profileEmailLabel;
        private System.Windows.Forms.Label profilePhoneLabel;
        private System.Windows.Forms.Label profileEndLabel;
        private System.Windows.Forms.Label profileStartLabel;
        private System.Windows.Forms.Label profileHoursLabel2;
        private System.Windows.Forms.Label profileProjectsLabel;
        private System.Windows.Forms.Label profileContactLabel;
        private System.Windows.Forms.Label profileVacationLabel;
        private System.Windows.Forms.Label profileHoursLabel1;
        private System.Windows.Forms.Button profileViewButton;
        private System.Windows.Forms.Button profileEditButton3;
        private System.Windows.Forms.Button profileEditButton1;
        private System.Windows.Forms.Button profileEditButton2;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel formBGTemp;
        private System.Windows.Forms.Panel loginBG;
        private System.Windows.Forms.Panel profileBG;
    }
}

