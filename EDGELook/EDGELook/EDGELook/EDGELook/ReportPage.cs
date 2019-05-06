using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class ReportPage
    {
        //initialize variables and setup
        private MySqlConnection conn;

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        }//end setup

        //displays
        public void ListVacations(DataGridView vacationGrid)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT E.fname AS First, E.lname AS Last, V.startDate AS Start, V.endDate AS End, V.status AS Status FROM Vacation V, Employee E WHERE E.employeeID = V.employeeID;", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                vacationGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end list vacations

        public void ListProjects(DataGridView projectsGrid)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT E.fname AS Name, P.prjNo AS 'Project Number', P.description AS Description, PP.prjPhase AS Phase, PP.phaseDueDate AS 'Due Date', P.deliverables AS Deliverables, P.hoursNeeded AS 'Estimated Hours', PP.status AS Status FROM Employee E, Project P, ProjectPhase PP WHERE P.prjLeader = E.employeeID AND P.prjNo = PP.prjNo AND P.prjComplete = 0; ", conn);
                DataTable table = new DataTable();
                da.Fill(table);
                projectsGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end list projects

        //primary functionality
        public void CreateReport(DataGridView DGV)
        {
            String filename = "";           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                String columnNames = "";
                String[] output = new String[DGV.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Your file was generated and its ready for use.");
            }
        }//end create report

    }//end class
}//end namespace
