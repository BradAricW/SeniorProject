using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeLook1
{
    public partial class AddProjectPage : Form
    {
        private String projectNum;
        private String projectDesc;
        private String projectDueDates;
        private String projectPhase;
        private String projectDeliverables;
        private int projectHours;
        private String projectStatus;
        private String projectNotes;
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void projectNumLabel(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
            projectNum = textBoxProjectNumber.Text;
            projectDesc = textBoxProjectDescription.Text;
            projectDueDates = textBoxProjectDueDates.Text;
            projectPhase = textBoxProjectPhase.Text;
            projectDueDates = textBoxProjectDueDates.Text;
            projectHours = int.Parse(textBoxProjectHours.Text);
            projectDeliverables = textBoxProjectDeliverables.Text;
            projectStatus = textBoxProjectStatus.Text;
            projectNotes = TextBoxNotes.Text;
            MessageBox.Show(projectNum + " " + projectDesc);
            

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
