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
    public partial class EditProjectPage : Form
    {

        private DBConn Conn;

        public EditProjectPage()
        {
            InitializeComponent();
        }

        private void projectNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectNumber(object sender, EventArgs e)
        {

        }

        private void label2_Description(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectDescription(object sender, EventArgs e)
        {

        }

        private void label3_DueDate(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectDueDates(object sender, EventArgs e)
        {

        }

        private void label4_Phase(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectPhase(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectDeliverables(object sender, EventArgs e)
        {

        }

        private void label6_Hour(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectHours(object sender, EventArgs e)
        {

        }

        private void label7_Status(object sender, EventArgs e)
        {

        }

        private void textBox_ProjectStatus(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_AddProject(object sender, EventArgs e)
        {

        }

        private void listView_ListOfEmployeeOfProject(object sender, EventArgs e)
        {

        }

        private void button_Remove(object sender, EventArgs e)
        {

        }

        private void button_Add(object sender, EventArgs e)
        {

        }

        private void textBox8_EditEmployee(object sender, EventArgs e)
        {

        }

        private void label_EditEmployee(object sender, EventArgs e)
        {

        }

        private void checkBox1_Assigned(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_EditProject(object sender, EventArgs e)
        {

        }

        private void button5_AddNotes(object sender, EventArgs e)
        {
           DBConn.editNotes(TextBoxNotes);
        }

        private void label_Notes(object sender, EventArgs e)
        {

        }

        private void TextBoxNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Deliverables(object sender, EventArgs e)
        {

        }
    }
}
