using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public void CreateMainReport(TextBox reportNameBox)
        {
            string reportName = reportNameBox.Text;
            string header = "NAME, PROJECT NUMBER, DESCRIPTION, PHASE, DUE DATE, DELIVERABLES, ESTIMATED HOURS, STATUS";
            string filePath = @"" + reportName + ".csv";
            File.WriteAllText(filePath, header);
        }

        public void CreateVacationReport(TextBox reportNameBox)
        {
            string reportName = reportNameBox.Text;
            string header = "FIRST NAME, LAST NAME, START DATE, END DATE";
            string filePath = @"" + reportName + ".csv";
            File.WriteAllText(filePath, header);
        }

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        }
    }
}
