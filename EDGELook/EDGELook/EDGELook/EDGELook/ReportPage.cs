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
        private MySqlConnection conn;

        public void CreateReport(DataGridView DGV)
        {
            string filename = "";           
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
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];
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

        }

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        }
        public void ListVacations(DataGridView vacationGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Vacation;", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            vacationGrid.DataSource = table;
            conn.Close();
        }
        public void ListProjects(DataGridView projectsGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("select E.fname as NAME, P.prjNo as PROJECT NUMBER, P.description as DESCRIPTION, PP.prjPhase as PHASE, PP.phaseDueDate as DUE DATE, P.deliverables as DELIVERABLES, P.hoursNeeded as ESTIMATED HOURS, PP.status as STATUS from Employee E, Project P, ProjectPhase PP where P.prjLeader = E.employeeID AND P.prjNo = PP.prjNo AND P.prjComplete = 0; ", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            projectsGrid.DataSource = table;
            conn.Close();
        }
    }
}
