namespace EdgeLook1
{
    partial class AddProjectPage
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
            this.projectNumberLabel = new System.Windows.Forms.Label();
            this.textBoxProjectNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.textBoxProjectDueDates = new System.Windows.Forms.TextBox();
            this.textBoxProjectPhase = new System.Windows.Forms.TextBox();
            this.textBoxProjectDeliverables = new System.Windows.Forms.TextBox();
            this.textBoxProjectHours = new System.Windows.Forms.TextBox();
            this.textBoxProjectStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNumberLabel
            // 
            this.projectNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.projectNumberLabel.ForeColor = System.Drawing.Color.Snow;
            this.projectNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.projectNumberLabel.Name = "projectNumberLabel";
            this.projectNumberLabel.Size = new System.Drawing.Size(450, 29);
            this.projectNumberLabel.TabIndex = 1;
            this.projectNumberLabel.Text = "Project Number                                  ";
            this.projectNumberLabel.Click += new System.EventHandler(this.projectNumLabel);
            // 
            // textBoxProjectNumber
            // 
            this.textBoxProjectNumber.Location = new System.Drawing.Point(3, 34);
            this.textBoxProjectNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectNumber.Name = "textBoxProjectNumber";
            this.textBoxProjectNumber.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectNumber.TabIndex = 3;
            this.textBoxProjectNumber.Text = "Input Project Number";
            this.textBoxProjectNumber.TextChanged += new System.EventHandler(this.textBox_ProjectNumber);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description                                  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxProjectDescription
            // 
            this.textBoxProjectDescription.Location = new System.Drawing.Point(3, 99);
            this.textBoxProjectDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectDescription.Name = "textBoxProjectDescription";
            this.textBoxProjectDescription.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectDescription.TabIndex = 5;
            this.textBoxProjectDescription.Text = "Input Description";
            this.textBoxProjectDescription.TextChanged += new System.EventHandler(this.textBox_ProjectName);
            // 
            // textBoxProjectDueDates
            // 
            this.textBoxProjectDueDates.Location = new System.Drawing.Point(3, 164);
            this.textBoxProjectDueDates.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectDueDates.Name = "textBoxProjectDueDates";
            this.textBoxProjectDueDates.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectDueDates.TabIndex = 6;
            this.textBoxProjectDueDates.Text = "Input Due Dates";
            // 
            // textBoxProjectPhase
            // 
            this.textBoxProjectPhase.Location = new System.Drawing.Point(3, 229);
            this.textBoxProjectPhase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectPhase.Name = "textBoxProjectPhase";
            this.textBoxProjectPhase.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectPhase.TabIndex = 7;
            this.textBoxProjectPhase.Text = "Input Phase";
            // 
            // textBoxProjectDeliverables
            // 
            this.textBoxProjectDeliverables.Location = new System.Drawing.Point(3, 294);
            this.textBoxProjectDeliverables.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectDeliverables.Name = "textBoxProjectDeliverables";
            this.textBoxProjectDeliverables.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectDeliverables.TabIndex = 8;
            this.textBoxProjectDeliverables.Text = "Input Deliverables";
            // 
            // textBoxProjectHours
            // 
            this.textBoxProjectHours.Location = new System.Drawing.Point(3, 359);
            this.textBoxProjectHours.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectHours.Name = "textBoxProjectHours";
            this.textBoxProjectHours.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectHours.TabIndex = 9;
            this.textBoxProjectHours.Text = "Input Hours";
            this.textBoxProjectHours.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxProjectStatus
            // 
            this.textBoxProjectStatus.Location = new System.Drawing.Point(3, 424);
            this.textBoxProjectStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxProjectStatus.Name = "textBoxProjectStatus";
            this.textBoxProjectStatus.Size = new System.Drawing.Size(452, 26);
            this.textBoxProjectStatus.TabIndex = 10;
            this.textBoxProjectStatus.Text = "Input Status";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Due Date                                    ";
            this.label3.Click += new System.EventHandler(this.label_DueDate);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phase                                       ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deliverables                                       ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(3, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hours                                       ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(3, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status                                     ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(519, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 92);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addProject_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.Location = new System.Drawing.Point(3, 35);
            this.TextBoxNotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(384, 453);
            this.TextBoxNotes.TabIndex = 19;
            this.TextBoxNotes.Text = "";
            this.TextBoxNotes.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(253, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Add Myself";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 65);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(114, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Assigned? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(19, 152);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(298, 26);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "[Please Select]";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(200, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 42);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "List of Employees On Project";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(28, 328);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 148);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(391, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 488);
            this.flowLayoutPanel1.TabIndex = 28;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TextBoxNotes);
            this.panel1.Location = new System.Drawing.Point(863, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 492);
            this.panel1.TabIndex = 29;
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
            this.panel2.Location = new System.Drawing.Point(30, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 493);
            this.panel2.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Edit Employee";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assigned                                 ";
            // 
            // AddProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1341, 778);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "AddProjectPage";
            this.Text = "AddProjectPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProjectPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label projectNumberLabel;
        private System.Windows.Forms.TextBox textBoxProjectNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProjectDescription;
        private System.Windows.Forms.TextBox textBoxProjectDueDates;
        private System.Windows.Forms.TextBox textBoxProjectPhase;
        private System.Windows.Forms.TextBox textBoxProjectDeliverables;
        private System.Windows.Forms.TextBox textBoxProjectHours;
        private System.Windows.Forms.TextBox textBoxProjectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox TextBoxNotes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}