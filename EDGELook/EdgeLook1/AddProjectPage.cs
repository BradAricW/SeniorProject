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

namespace EdgeLook1
{
    public partial class AddProjectPage : Form
    {
        private string projectNum;
        private string projectDesc;
        private string projectDueDates;
        private string projectPhase;
        private string projectDeliverables;
        private int projectHours;
        private string projectStatus;
        private string projectNotes;

        private DBConn Conn;
         
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void checkAssigned_checkBox(object sender, EventArgs e)
        {

        }

        private void projectNumLabel(object sender, EventArgs e)
        {

        }

        private void label8_Notes(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Notes(object sender, EventArgs e)
        {

        }

        private void button3_AddMyself(object sender, EventArgs e)
        {
            Conn = new DBConn();
            Boolean addedMyself = true;
            Conn.assignEmployee(addedMyself);


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_SelectEmployee(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProjectPage_Load(object sender, EventArgs e)
        {

        }

        private void addProject_Click(object sender, EventArgs e)
        {

            Conn = new DBConn();
            projectNum = textBoxProjectNumber.Text;
            projectDesc = textBoxProjectDescription.Text;
            projectDueDates = textBoxProjectDueDates.Text;
            projectPhase = textBoxProjectPhase.Text;
            projectDeliverables = textBoxProjectDeliverables.Text;
            projectHours = int.Parse(textBoxProjectHours.Text);
            projectStatus = textBoxProjectStatus.Text;
            projectNotes = TextBoxNotes.Text;
            //String addProj = "INSERT INTO PROJECT VALUES (\'" + projectNum + "\', "+ 322 + ", \'" + projectDesc + " \', \'" + projectPhase + " \', \'" + projectDueDates + " \', \'" + projectDeliverables +  "\', " + projectHours + ", \'" + projectStatus + "\');";
            //MessageBox.Show(addProj);
            Conn.addProject(projectNum,projectDesc,projectDueDates,projectPhase,projectDeliverables,projectHours,projectStatus,projectNotes);

        }

        private void textBox_ProjectNumber(object sender, EventArgs e)
        {
          
        }

        private void textBox_ProjectName(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_DueDate(object sender, EventArgs e)
        {

        }

        private void buttonClick_Remove(object sender, EventArgs e)
        {

        }

        private void buttonClick_Add(object sender, EventArgs e)
        {

        }

        private void listView1_EmployeeList(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_ProjectDueDates(object sender, EventArgs e)
        {

        }

        private void label1_Assigned(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxProjectPhase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
