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
    public partial class ProfilePage : Form
    {
        private DBConn Conn;
        private int hoursNum;
        private int eID;
        public ProfilePage()
        {
            InitializeComponent();
            Conn = new DBConn();
            Conn.setEID(eID);
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            //Conn = new DBConn();
            hoursNum = int.Parse(hoursTextBox.Text);
            hoursNum = Conn.editHours(hoursNum);
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {

        }

        private void EditButton3_Click(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {

        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {

        }

        private void SchedulesButton_Click(object sender, EventArgs e)
        {

        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            
        }
    }
}
