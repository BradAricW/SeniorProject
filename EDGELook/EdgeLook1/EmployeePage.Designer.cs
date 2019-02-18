namespace EdgeLook1
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.backPanel = new System.Windows.Forms.Panel();
            this.projectList = new System.Windows.Forms.ListBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.hoursLabel2 = new System.Windows.Forms.Label();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.vacationLabel = new System.Windows.Forms.Label();
            this.hoursLabel1 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.edgeLogo = new System.Windows.Forms.Label();
            this.sevenWonders = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.backPanel.Location = new System.Drawing.Point(375, 65);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(450, 503);
            this.backPanel.TabIndex = 6;
            // 
            // projectList
            // 
            this.projectList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectList.FormattingEnabled = true;
            this.projectList.ItemHeight = 22;
            this.projectList.Location = new System.Drawing.Point(0, 362);
            this.projectList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectList.Name = "projectList";
            this.projectList.ScrollAlwaysVisible = true;
            this.projectList.Size = new System.Drawing.Size(448, 92);
            this.projectList.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.emailLabel.Location = new System.Drawing.Point(12, 292);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 22);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email: ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.phoneLabel.Location = new System.Drawing.Point(12, 262);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 22);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Phone #: ";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.endLabel.Location = new System.Drawing.Point(165, 168);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(47, 22);
            this.endLabel.TabIndex = 10;
            this.endLabel.Text = "End:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.startLabel.Location = new System.Drawing.Point(12, 168);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(58, 22);
            this.startLabel.TabIndex = 9;
            this.startLabel.Text = "Start: ";
            // 
            // hoursLabel2
            // 
            this.hoursLabel2.AutoSize = true;
            this.hoursLabel2.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel2.Location = new System.Drawing.Point(12, 58);
            this.hoursLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursLabel2.Name = "hoursLabel2";
            this.hoursLabel2.Size = new System.Drawing.Size(68, 22);
            this.hoursLabel2.TabIndex = 8;
            this.hoursLabel2.Text = "Hours: ";
            // 
            // projectsLabel
            // 
            this.projectsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.projectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.projectsLabel.Location = new System.Drawing.Point(0, 328);
            this.projectsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(450, 31);
            this.projectsLabel.TabIndex = 7;
            this.projectsLabel.Text = "Projects";
            // 
            // contactLabel
            // 
            this.contactLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.contactLabel.Location = new System.Drawing.Point(0, 218);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(450, 31);
            this.contactLabel.TabIndex = 6;
            this.contactLabel.Text = "Contact Information";
            // 
            // vacationLabel
            // 
            this.vacationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.vacationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacationLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vacationLabel.Location = new System.Drawing.Point(2, 109);
            this.vacationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vacationLabel.Name = "vacationLabel";
            this.vacationLabel.Size = new System.Drawing.Size(450, 31);
            this.vacationLabel.TabIndex = 5;
            this.vacationLabel.Text = "Vacation Dates";
            // 
            // hoursLabel1
            // 
            this.hoursLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.hoursLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.hoursLabel1.Location = new System.Drawing.Point(0, 0);
            this.hoursLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursLabel1.Name = "hoursLabel1";
            this.hoursLabel1.Size = new System.Drawing.Size(450, 31);
            this.hoursLabel1.TabIndex = 4;
            this.hoursLabel1.Text = "Hours Available";
            this.hoursLabel1.Click += new System.EventHandler(this.hoursLabel1_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.ForeColor = System.Drawing.Color.Snow;
            this.viewButton.Location = new System.Drawing.Point(170, 463);
            this.viewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(112, 35);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.employeeLabel.Location = new System.Drawing.Point(369, 17);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(157, 32);
            this.employeeLabel.TabIndex = 7;
            this.employeeLabel.Text = "Employee: ";
            // 
            // edgeLogo
            // 
            this.edgeLogo.Image = ((System.Drawing.Image)(resources.GetObject("edgeLogo.Image")));
            this.edgeLogo.Location = new System.Drawing.Point(438, 577);
            this.edgeLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edgeLogo.Name = "edgeLogo";
            this.edgeLogo.Size = new System.Drawing.Size(150, 100);
            this.edgeLogo.TabIndex = 9;
            // 
            // sevenWonders
            // 
            this.sevenWonders.Image = ((System.Drawing.Image)(resources.GetObject("sevenWonders.Image")));
            this.sevenWonders.Location = new System.Drawing.Point(597, 577);
            this.sevenWonders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sevenWonders.Name = "sevenWonders";
            this.sevenWonders.Size = new System.Drawing.Size(166, 100);
            this.sevenWonders.TabIndex = 8;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.edgeLogo);
            this.Controls.Add(this.sevenWonders);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeePage";
            this.Text = "Employee Page";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.ListBox projectList;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label hoursLabel2;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label vacationLabel;
        private System.Windows.Forms.Label hoursLabel1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label edgeLogo;
        private System.Windows.Forms.Label sevenWonders;
    }
}