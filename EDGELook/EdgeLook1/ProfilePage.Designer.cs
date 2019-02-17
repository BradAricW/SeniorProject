namespace EdgeLook1
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.editButton1 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.editButton3 = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.hoursLabel1 = new System.Windows.Forms.Label();
            this.sevenWonders = new System.Windows.Forms.Label();
            this.edgeLogo = new System.Windows.Forms.Label();
            this.vacationLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.hoursLabel2 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.ListBox();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton1
            // 
            this.editButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.editButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton1.ForeColor = System.Drawing.Color.Snow;
            this.editButton1.Location = new System.Drawing.Point(221, 34);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(75, 23);
            this.editButton1.TabIndex = 0;
            this.editButton1.Text = "Edit";
            this.editButton1.UseVisualStyleBackColor = false;
            this.editButton1.Click += new System.EventHandler(this.EditButton1_Click);
            // 
            // editButton2
            // 
            this.editButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.editButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton2.ForeColor = System.Drawing.Color.Snow;
            this.editButton2.Location = new System.Drawing.Point(221, 105);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(75, 23);
            this.editButton2.TabIndex = 1;
            this.editButton2.Text = "Edit";
            this.editButton2.UseVisualStyleBackColor = false;
            this.editButton2.Click += new System.EventHandler(this.EditButton2_Click);
            // 
            // editButton3
            // 
            this.editButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.editButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton3.ForeColor = System.Drawing.Color.Snow;
            this.editButton3.Location = new System.Drawing.Point(221, 176);
            this.editButton3.Name = "editButton3";
            this.editButton3.Size = new System.Drawing.Size(75, 23);
            this.editButton3.TabIndex = 2;
            this.editButton3.Text = "Edit";
            this.editButton3.UseVisualStyleBackColor = false;
            this.editButton3.Click += new System.EventHandler(this.EditButton3_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.ForeColor = System.Drawing.Color.Snow;
            this.viewButton.Location = new System.Drawing.Point(113, 301);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.profileLabel.Location = new System.Drawing.Point(342, 11);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(92, 24);
            this.profileLabel.TabIndex = 4;
            this.profileLabel.Text = "My Profile";
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backPanel.Controls.Add(this.projectList);
            this.backPanel.Controls.Add(this.emailLabel);
            this.backPanel.Controls.Add(this.phoneLabel);
            this.backPanel.Controls.Add(this.endLabel);
            this.backPanel.Controls.Add(this.startLabel);
            this.backPanel.Controls.Add(this.hoursLabel2);
            this.backPanel.Controls.Add(this.projectsLabel);
            this.backPanel.Controls.Add(this.contactLabel);
            this.backPanel.Controls.Add(this.vacationLabel);
            this.backPanel.Controls.Add(this.hoursLabel1);
            this.backPanel.Controls.Add(this.viewButton);
            this.backPanel.Controls.Add(this.editButton3);
            this.backPanel.Controls.Add(this.editButton1);
            this.backPanel.Controls.Add(this.editButton2);
            this.backPanel.Location = new System.Drawing.Point(246, 43);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(300, 327);
            this.backPanel.TabIndex = 5;
            this.backPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hoursLabel1
            // 
            this.hoursLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.hoursLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.hoursLabel1.Location = new System.Drawing.Point(0, 0);
            this.hoursLabel1.Name = "hoursLabel1";
            this.hoursLabel1.Size = new System.Drawing.Size(300, 20);
            this.hoursLabel1.TabIndex = 4;
            this.hoursLabel1.Text = "Hours Available";
            // 
            // sevenWonders
            // 
            this.sevenWonders.Image = ((System.Drawing.Image)(resources.GetObject("sevenWonders.Image")));
            this.sevenWonders.Location = new System.Drawing.Point(396, 376);
            this.sevenWonders.Name = "sevenWonders";
            this.sevenWonders.Size = new System.Drawing.Size(111, 65);
            this.sevenWonders.TabIndex = 6;
            // 
            // edgeLogo
            // 
            this.edgeLogo.Image = ((System.Drawing.Image)(resources.GetObject("edgeLogo.Image")));
            this.edgeLogo.Location = new System.Drawing.Point(290, 376);
            this.edgeLogo.Name = "edgeLogo";
            this.edgeLogo.Size = new System.Drawing.Size(100, 65);
            this.edgeLogo.TabIndex = 7;
            // 
            // vacationLabel
            // 
            this.vacationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.vacationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacationLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vacationLabel.Location = new System.Drawing.Point(1, 71);
            this.vacationLabel.Name = "vacationLabel";
            this.vacationLabel.Size = new System.Drawing.Size(300, 20);
            this.vacationLabel.TabIndex = 5;
            this.vacationLabel.Text = "Vacation Dates";
            // 
            // contactLabel
            // 
            this.contactLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.contactLabel.Location = new System.Drawing.Point(0, 142);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(300, 20);
            this.contactLabel.TabIndex = 6;
            this.contactLabel.Text = "Contact Information";
            // 
            // projectsLabel
            // 
            this.projectsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.projectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.projectsLabel.Location = new System.Drawing.Point(0, 213);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(300, 20);
            this.projectsLabel.TabIndex = 7;
            this.projectsLabel.Text = "Projects";
            // 
            // hoursLabel2
            // 
            this.hoursLabel2.AutoSize = true;
            this.hoursLabel2.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel2.Location = new System.Drawing.Point(8, 38);
            this.hoursLabel2.Name = "hoursLabel2";
            this.hoursLabel2.Size = new System.Drawing.Size(46, 15);
            this.hoursLabel2.TabIndex = 8;
            this.hoursLabel2.Text = "Hours: ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.startLabel.Location = new System.Drawing.Point(8, 109);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(38, 15);
            this.startLabel.TabIndex = 9;
            this.startLabel.Text = "Start: ";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.endLabel.Location = new System.Drawing.Point(110, 109);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(32, 15);
            this.endLabel.TabIndex = 10;
            this.endLabel.Text = "End:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.phoneLabel.Location = new System.Drawing.Point(8, 170);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(59, 15);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Phone #: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.emailLabel.Location = new System.Drawing.Point(8, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 15);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email: ";
            // 
            // projectList
            // 
            this.projectList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectList.FormattingEnabled = true;
            this.projectList.ItemHeight = 15;
            this.projectList.Location = new System.Drawing.Point(0, 235);
            this.projectList.Name = "projectList";
            this.projectList.ScrollAlwaysVisible = true;
            this.projectList.Size = new System.Drawing.Size(300, 64);
            this.projectList.TabIndex = 13;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edgeLogo);
            this.Controls.Add(this.sevenWonders);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.backPanel);
            this.Name = "ProfilePage";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button editButton1;
        private System.Windows.Forms.Button editButton2;
        private System.Windows.Forms.Button editButton3;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label hoursLabel1;
        private System.Windows.Forms.Label sevenWonders;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label hoursLabel2;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label vacationLabel;
        private System.Windows.Forms.Label edgeLogo;
        private System.Windows.Forms.ListBox projectList;
    }
}