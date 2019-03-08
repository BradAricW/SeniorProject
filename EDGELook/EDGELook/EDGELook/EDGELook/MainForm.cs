using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = true;
            this.loginBG.Visible = false;
            this.taskbarMenu.Visible = true;
            this.profileBG.Visible = true;
        }

        private void SignOutLabel_Click(object sender, EventArgs e)
        {
            this.signOutLabel.Visible = false;
            this.loginBG.Visible = true;
            this.taskbarMenu.Visible = false;
            this.profileBG.Visible = false;
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

    }
}
