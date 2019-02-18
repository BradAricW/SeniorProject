using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBar
{
    public partial class TaskBar : Form
    {
        bool isSideMenuPanelOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isSideMenuPanelOpen == true)
            {
                sideMenuOptionsPanel.Height -= 10;
                if (sideMenuOptionsPanel.Height == 0)
                {
                    timer1.Stop();
                    isSideMenuPanelOpen = false;
                }
            }
            else if(isSideMenuPanelOpen == false)
            {
                sideMenuOptionsPanel.Height += 10;
                if(sideMenuOptionsPanel.Height == 210)
                {
                    timer1.Stop();
                    isSideMenuPanelOpen = true;
                }
            }
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signed Out");
        }

        private void sideMenuPanel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Buttons
        // Side/Drop Down Menu Buttons
        private void homeButtonSideMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Button Clicked (Side Menu)");
        }

        private void projectsButtonSideMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projects Button Clicked (Side Menu)");
        }

        private void employeesSideMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employees Button Clicked (Side Menu)");
        }

        private void schedulesButtonSideMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schedules Button Clicked (Side Menu)");
        }

        private void aboutButtonSideMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About Button Clicked (Side Menu)");
        }

        // Main Menu Buttons
        private void homeButtonMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Button Clicked");
        }

        private void projectsButtonMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projects Button Clicked");

        }

        private void employeesButtonMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employees Button Clicked");

        }

        private void scheduelsButtonMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduels Button Clicked");
        }


    }
}
