namespace TaskBar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sideMenuOptionsPanel = new System.Windows.Forms.Panel();
            this.aboutButtonSideMenu = new System.Windows.Forms.Button();
            this.schedulesButtonSideMenu = new System.Windows.Forms.Button();
            this.employeesSideMenuButton = new System.Windows.Forms.Button();
            this.projectsButtonSideMenu = new System.Windows.Forms.Button();
            this.homeButtonSideMenu = new System.Windows.Forms.Button();
            this.scheduelsButtonMain = new System.Windows.Forms.Button();
            this.employeesButtonMain = new System.Windows.Forms.Button();
            this.projectsButtonMain = new System.Windows.Forms.Button();
            this.homeButtonMain = new System.Windows.Forms.Button();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Label();
            this.sideMenuPanel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.sideMenuOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.sideMenuOptionsPanel);
            this.panelMain.Controls.Add(this.scheduelsButtonMain);
            this.panelMain.Controls.Add(this.employeesButtonMain);
            this.panelMain.Controls.Add(this.projectsButtonMain);
            this.panelMain.Controls.Add(this.homeButtonMain);
            this.panelMain.Controls.Add(this.employeeIDLabel);
            this.panelMain.Controls.Add(this.signOut);
            this.panelMain.Controls.Add(this.sideMenuPanel);
            this.panelMain.Controls.Add(this.HeaderLabel);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Location = new System.Drawing.Point(117, 80);
            this.panelMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(2986, 1395);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sideMenuOptionsPanel
            // 
            this.sideMenuOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideMenuOptionsPanel.Controls.Add(this.aboutButtonSideMenu);
            this.sideMenuOptionsPanel.Controls.Add(this.schedulesButtonSideMenu);
            this.sideMenuOptionsPanel.Controls.Add(this.employeesSideMenuButton);
            this.sideMenuOptionsPanel.Controls.Add(this.projectsButtonSideMenu);
            this.sideMenuOptionsPanel.Controls.Add(this.homeButtonSideMenu);
            this.sideMenuOptionsPanel.Location = new System.Drawing.Point(32, 120);
            this.sideMenuOptionsPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.sideMenuOptionsPanel.Name = "sideMenuOptionsPanel";
            this.sideMenuOptionsPanel.Size = new System.Drawing.Size(412, 0);
            this.sideMenuOptionsPanel.TabIndex = 1;
            this.sideMenuOptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // aboutButtonSideMenu
            // 
            this.aboutButtonSideMenu.Location = new System.Drawing.Point(0, 467);
            this.aboutButtonSideMenu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.aboutButtonSideMenu.Name = "aboutButtonSideMenu";
            this.aboutButtonSideMenu.Size = new System.Drawing.Size(412, 125);
            this.aboutButtonSideMenu.TabIndex = 4;
            this.aboutButtonSideMenu.Text = "About";
            this.aboutButtonSideMenu.UseVisualStyleBackColor = true;
            this.aboutButtonSideMenu.Click += new System.EventHandler(this.aboutButtonSideMenu_Click);
            // 
            // schedulesButtonSideMenu
            // 
            this.schedulesButtonSideMenu.Location = new System.Drawing.Point(0, 350);
            this.schedulesButtonSideMenu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.schedulesButtonSideMenu.Name = "schedulesButtonSideMenu";
            this.schedulesButtonSideMenu.Size = new System.Drawing.Size(412, 125);
            this.schedulesButtonSideMenu.TabIndex = 3;
            this.schedulesButtonSideMenu.Text = "Schedules";
            this.schedulesButtonSideMenu.UseVisualStyleBackColor = true;
            this.schedulesButtonSideMenu.Click += new System.EventHandler(this.schedulesButtonSideMenu_Click);
            // 
            // employeesSideMenuButton
            // 
            this.employeesSideMenuButton.Location = new System.Drawing.Point(0, 233);
            this.employeesSideMenuButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.employeesSideMenuButton.Name = "employeesSideMenuButton";
            this.employeesSideMenuButton.Size = new System.Drawing.Size(412, 125);
            this.employeesSideMenuButton.TabIndex = 2;
            this.employeesSideMenuButton.Text = "Employees";
            this.employeesSideMenuButton.UseVisualStyleBackColor = true;
            this.employeesSideMenuButton.Click += new System.EventHandler(this.employeesSideMenuButton_Click);
            // 
            // projectsButtonSideMenu
            // 
            this.projectsButtonSideMenu.Location = new System.Drawing.Point(0, 117);
            this.projectsButtonSideMenu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.projectsButtonSideMenu.Name = "projectsButtonSideMenu";
            this.projectsButtonSideMenu.Size = new System.Drawing.Size(412, 125);
            this.projectsButtonSideMenu.TabIndex = 1;
            this.projectsButtonSideMenu.Text = "Projects";
            this.projectsButtonSideMenu.UseVisualStyleBackColor = true;
            this.projectsButtonSideMenu.Click += new System.EventHandler(this.projectsButtonSideMenu_Click);
            // 
            // homeButtonSideMenu
            // 
            this.homeButtonSideMenu.Location = new System.Drawing.Point(0, 0);
            this.homeButtonSideMenu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.homeButtonSideMenu.Name = "homeButtonSideMenu";
            this.homeButtonSideMenu.Size = new System.Drawing.Size(412, 125);
            this.homeButtonSideMenu.TabIndex = 0;
            this.homeButtonSideMenu.Text = "Home";
            this.homeButtonSideMenu.UseVisualStyleBackColor = true;
            this.homeButtonSideMenu.Click += new System.EventHandler(this.homeButtonSideMenu_Click);
            // 
            // scheduelsButtonMain
            // 
            this.scheduelsButtonMain.BackColor = System.Drawing.Color.White;
            this.scheduelsButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduelsButtonMain.Location = new System.Drawing.Point(2128, 427);
            this.scheduelsButtonMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.scheduelsButtonMain.Name = "scheduelsButtonMain";
            this.scheduelsButtonMain.Size = new System.Drawing.Size(573, 162);
            this.scheduelsButtonMain.TabIndex = 9;
            this.scheduelsButtonMain.Text = "Schedules";
            this.scheduelsButtonMain.UseVisualStyleBackColor = false;
            this.scheduelsButtonMain.Click += new System.EventHandler(this.scheduelsButtonMain_Click);
            // 
            // employeesButtonMain
            // 
            this.employeesButtonMain.BackColor = System.Drawing.Color.White;
            this.employeesButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButtonMain.Location = new System.Drawing.Point(1536, 427);
            this.employeesButtonMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.employeesButtonMain.Name = "employeesButtonMain";
            this.employeesButtonMain.Size = new System.Drawing.Size(573, 162);
            this.employeesButtonMain.TabIndex = 8;
            this.employeesButtonMain.Text = "Employees";
            this.employeesButtonMain.UseVisualStyleBackColor = false;
            this.employeesButtonMain.Click += new System.EventHandler(this.employeesButtonMain_Click);
            // 
            // projectsButtonMain
            // 
            this.projectsButtonMain.BackColor = System.Drawing.Color.White;
            this.projectsButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsButtonMain.Location = new System.Drawing.Point(944, 427);
            this.projectsButtonMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.projectsButtonMain.Name = "projectsButtonMain";
            this.projectsButtonMain.Size = new System.Drawing.Size(573, 162);
            this.projectsButtonMain.TabIndex = 7;
            this.projectsButtonMain.Text = "Projects";
            this.projectsButtonMain.UseVisualStyleBackColor = false;
            this.projectsButtonMain.Click += new System.EventHandler(this.projectsButtonMain_Click);
            // 
            // homeButtonMain
            // 
            this.homeButtonMain.BackColor = System.Drawing.Color.White;
            this.homeButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButtonMain.Location = new System.Drawing.Point(352, 427);
            this.homeButtonMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.homeButtonMain.Name = "homeButtonMain";
            this.homeButtonMain.Size = new System.Drawing.Size(573, 162);
            this.homeButtonMain.TabIndex = 6;
            this.homeButtonMain.Text = "Home";
            this.homeButtonMain.UseVisualStyleBackColor = false;
            this.homeButtonMain.Click += new System.EventHandler(this.homeButtonMain_Click);
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(2223, 256);
            this.employeeIDLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(754, 88);
            this.employeeIDLabel.TabIndex = 5;
            this.employeeIDLabel.Text = "Welcome, Example!";
            this.employeeIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // signOut
            // 
            this.signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.Location = new System.Drawing.Point(2685, 28);
            this.signOut.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(263, 91);
            this.signOut.TabIndex = 3;
            this.signOut.Text = "Sign Out";
            this.signOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.White;
            this.sideMenuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuPanel.Location = new System.Drawing.Point(16, 28);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(238, 83);
            this.sideMenuPanel.TabIndex = 0;
            this.sideMenuPanel.Text = "Menu";
            this.sideMenuPanel.Click += new System.EventHandler(this.sideMenuPanel_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.Blue;
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(2986, 344);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "EDGELook";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-10, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2996, 418);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3217, 1588);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.sideMenuOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel sideMenuOptionsPanel;
        private System.Windows.Forms.Label sideMenuPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button employeesSideMenuButton;
        private System.Windows.Forms.Button projectsButtonSideMenu;
        private System.Windows.Forms.Button homeButtonSideMenu;
        private System.Windows.Forms.Button aboutButtonSideMenu;
        private System.Windows.Forms.Button schedulesButtonSideMenu;
        private System.Windows.Forms.Label signOut;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scheduelsButtonMain;
        private System.Windows.Forms.Button employeesButtonMain;
        private System.Windows.Forms.Button projectsButtonMain;
        private System.Windows.Forms.Button homeButtonMain;
        private System.Windows.Forms.Label employeeIDLabel;
    }
}

