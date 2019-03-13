﻿namespace EdgeLook1
{
    partial class EditProjectPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.projectNumberLabel = new System.Windows.Forms.Label();
            this.textBoxProjectNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProjectDueDates = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProjectPhase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProjectDeliverables = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProjectHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProjectStatus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.displayText = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.projectNumberLabel);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectNumber);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectDescription);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectDueDates);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectPhase);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectDeliverables);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectHours);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProjectStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(285, 67);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 316);
            this.flowLayoutPanel1.TabIndex = 29;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // projectNumberLabel
            // 
            this.projectNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.projectNumberLabel.ForeColor = System.Drawing.Color.Snow;
            this.projectNumberLabel.Location = new System.Drawing.Point(2, 0);
            this.projectNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectNumberLabel.Name = "projectNumberLabel";
            this.projectNumberLabel.Size = new System.Drawing.Size(300, 19);
            this.projectNumberLabel.TabIndex = 1;
            this.projectNumberLabel.Text = "Project Number                                  ";
            this.projectNumberLabel.Click += new System.EventHandler(this.projectNumberLabel_Click);
            // 
            // textBoxProjectNumber
            // 
            this.textBoxProjectNumber.Location = new System.Drawing.Point(2, 22);
            this.textBoxProjectNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectNumber.Name = "textBoxProjectNumber";
            this.textBoxProjectNumber.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectNumber.TabIndex = 3;
            this.textBoxProjectNumber.TextChanged += new System.EventHandler(this.textBox_ProjectNumber);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description                                  ";
            this.label2.Click += new System.EventHandler(this.label2_Description);
            // 
            // textBoxProjectDescription
            // 
            this.textBoxProjectDescription.Location = new System.Drawing.Point(2, 67);
            this.textBoxProjectDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectDescription.Name = "textBoxProjectDescription";
            this.textBoxProjectDescription.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectDescription.TabIndex = 5;
            this.textBoxProjectDescription.TextChanged += new System.EventHandler(this.textBox_ProjectDescription);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(2, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Due Date                                    ";
            this.label3.Click += new System.EventHandler(this.label3_DueDate);
            // 
            // textBoxProjectDueDates
            // 
            this.textBoxProjectDueDates.Location = new System.Drawing.Point(2, 112);
            this.textBoxProjectDueDates.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectDueDates.Name = "textBoxProjectDueDates";
            this.textBoxProjectDueDates.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectDueDates.TabIndex = 6;
            this.textBoxProjectDueDates.TextChanged += new System.EventHandler(this.textBox_ProjectDueDates);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phase                                       ";
            this.label4.Click += new System.EventHandler(this.label4_Phase);
            // 
            // textBoxProjectPhase
            // 
            this.textBoxProjectPhase.Location = new System.Drawing.Point(2, 157);
            this.textBoxProjectPhase.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectPhase.Name = "textBoxProjectPhase";
            this.textBoxProjectPhase.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectPhase.TabIndex = 7;
            this.textBoxProjectPhase.Text = "Input Phase";
            this.textBoxProjectPhase.TextChanged += new System.EventHandler(this.textBox_ProjectPhase);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(2, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deliverables                                       ";
            this.label5.Click += new System.EventHandler(this.label5_Deliverables);
            // 
            // textBoxProjectDeliverables
            // 
            this.textBoxProjectDeliverables.Location = new System.Drawing.Point(2, 202);
            this.textBoxProjectDeliverables.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectDeliverables.Name = "textBoxProjectDeliverables";
            this.textBoxProjectDeliverables.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectDeliverables.TabIndex = 8;
            this.textBoxProjectDeliverables.Text = "Input Deliverables";
            this.textBoxProjectDeliverables.TextChanged += new System.EventHandler(this.textBox_ProjectDeliverables);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(2, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hours                                       ";
            this.label6.Click += new System.EventHandler(this.label6_Hour);
            // 
            // textBoxProjectHours
            // 
            this.textBoxProjectHours.Location = new System.Drawing.Point(2, 247);
            this.textBoxProjectHours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectHours.Name = "textBoxProjectHours";
            this.textBoxProjectHours.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectHours.TabIndex = 9;
            this.textBoxProjectHours.Text = "Input Hours";
            this.textBoxProjectHours.TextChanged += new System.EventHandler(this.textBox_ProjectHours);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(2, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status                                     ";
            this.label7.Click += new System.EventHandler(this.label7_Status);
            // 
            // textBoxProjectStatus
            // 
            this.textBoxProjectStatus.Location = new System.Drawing.Point(2, 292);
            this.textBoxProjectStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProjectStatus.Name = "textBoxProjectStatus";
            this.textBoxProjectStatus.Size = new System.Drawing.Size(302, 20);
            this.textBoxProjectStatus.TabIndex = 10;
            this.textBoxProjectStatus.Text = "Input Status";
            this.textBoxProjectStatus.TextChanged += new System.EventHandler(this.textBox_ProjectStatus);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxNotes);
            this.panel1.Location = new System.Drawing.Point(625, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 320);
            this.panel1.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes";
            this.label8.Click += new System.EventHandler(this.label_Notes);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(2, 23);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(258, 295);
            this.textBoxNotes.TabIndex = 19;
            this.textBoxNotes.Text = "";
            this.textBoxNotes.TextChanged += new System.EventHandler(this.TextBoxNotes_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(29, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 320);
            this.panel2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Edit Employee";
            this.label9.Click += new System.EventHandler(this.label_EditEmployee);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(19, 213);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(184, 97);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_ListOfEmployeeOfProject);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assigned                                 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(74, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Assigned? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_Assigned);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(13, 99);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "[Please Select]";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_EditEmployee);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(134, 145);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 28);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Add);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "List of Employees On Project";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Remove);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(178, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 24);
            this.button3.TabIndex = 32;
            this.button3.Text = "Add Myself";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_AddProject);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(476, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Edit Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_EditProject);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(800, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 28);
            this.button5.TabIndex = 34;
            this.button5.Text = "Add Notes";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_AddNotes);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(378, 446);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 58);
            this.button6.TabIndex = 35;
            this.button6.Text = "Save Project";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(629, 446);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(122, 48);
            this.displayText.TabIndex = 36;
            this.displayText.Text = "displayText";
            this.displayText.UseVisualStyleBackColor = true;
            this.displayText.Click += new System.EventHandler(this.displayText_Click);
            // 
            // EditProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 548);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditProjectPage";
            this.Text = "EditProjectPage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label projectNumberLabel;
        private System.Windows.Forms.TextBox textBoxProjectNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProjectDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProjectDueDates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProjectPhase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProjectDeliverables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProjectHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProjectStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox textBoxNotes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button displayText;
    }
}