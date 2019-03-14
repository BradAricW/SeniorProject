using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EDGELook 
{
    public class DBConn
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connString;
        private MySqlConnection conn;
        private int eID;
        private String projectID;

        //CONSTRUCTOR
        public DBConn()
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";


        }

        public void addProject(String Num, String Desc, String dueDates, String Phase, String Deliv, int Hours, String Status, String noteInsert)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn = new MySqlConnection(connString);
            //MySqlCommand command = conn.CreateCommand();

            String addProj = "INSERT INTO Project VALUES (\'" + Num + "\', " + 322 + ", \'" + Desc + " \', \'" + Phase + " \', \'" + dueDates + " \', \'" + Deliv + "\', " + Hours + ", \'" + Status + "\');";

            //MySqlCommand cmd = new MySqlCommand(addProj, this.conn);

            MySqlCommand cmd = new MySqlCommand("INSERT INTO Notes (notes) VALUES @noteValue);", conn);
            cmd.Parameters.AddWithValue("@noteValue", noteInsert);
            cmd.ExecuteNonQuery();

            //MySqlCommand cmd1 = new MySqlCommand(addNotes, this.conn);
            //Console.WriteLine(cmd1.ExecuteNonQuery());

            //String getMyID = "SELECT employeeID FROM Employee as E WHERE " + this.eID + " == E.employeeID";
            //String setMyID = "UPDATE WorksOn SET employeeID = " + getMyID + "WHERE employeeID = this.eID";
            //MySqlCommand cmd2 = new MySqlCommand(setMyID, this.conn);

            //String setOtherID = "UPDATE WorksOn SET employeeID = " + getMyID + "WHERE employeeID = this.eID";
            //MySqlCommand cmd3 = new MySqlCommand(setOtherID, this.conn);

            //Console.WriteLine(cmd.ExecuteNonQuery());
            //Console.WriteLine(cmd1.ExecuteNonQuery());

        }

        public void assignEmployee(Boolean myselfButton)
        {
            conn.Open();
            if (myselfButton)
              
            {

                String getMyID = "SELECT employeeID FROM Employee as E WHERE " + this.eID + " == E.employeeID;";
                MySqlCommand cmd = new MySqlCommand(getMyID, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                String getProjectID = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " == P.prjNo;";
                MySqlCommand cmd2 = new MySqlCommand(getProjectID, this.conn);
                MySqlDataReader reader1 = cmd2.ExecuteReader();

                String setMyID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + getMyID + "\'," + getProjectID + "\');";
                MySqlCommand cmd1 = new MySqlCommand(setMyID, this.conn);
                Console.WriteLine(cmd1.ExecuteNonQuery());
            }
            //Get ID through Email or from input box
            String otherID = " ";

            String getProjectID2 = "SELECT prjNo FROM Project as P WHERE " + this.projectID + " == P.prjNo;";
            MySqlCommand cmd3 = new MySqlCommand(getProjectID2, this.conn);
            MySqlDataReader reader2 = cmd3.ExecuteReader();

            String setotherID = "INSERT INTO WorksOn (employeeID, prjNo) VALUES (\'" + otherID + "\'," + getProjectID2 + "\');";
            MySqlCommand cmd4 = new MySqlCommand(setotherID, this.conn);
            Console.WriteLine(cmd4.ExecuteNonQuery());
        }

        public int editHours(int empHours)
        {
            int currentHours = 0;
            String getHours = "SELECT hoursAvail FROM Employee as E WHERE " + this.eID + " == E.employeeID;";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentHours = reader.GetInt16("hoursAvail");
            }
            if (empHours != currentHours)
            {
                String setHours = "UPDATE Employee SET hoursAvail = " + empHours + "WHERE employeeID = this.eID;";
                MySqlCommand cmd2 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                currentHours = empHours;
            }
            return currentHours;
        }
        public void setEID(int employeeID)
        {
            eID = employeeID;
        }

        //public void login (String username, String password)
        //{
        //    String getLogin = "SELECT employeeID FROM Employee WHERE email = " + username + " AND pssword = " + password + ";";
        //    MySqlCommand cmd = new MySqlCommand(getLogin, this.conn);
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        eID = reader.getInt16("employeeID");
        //    }
        //    if (eID == null)
        //    {
        //        Console.WriteLine("Not valid login");
        //    }
        //    else
        //        Console.WriteLine("Logged in");
        //    return eID;
        //} // Login


        //// Not Tested!!!!!!!
        public void editNotes(String addNotes)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn = new MySqlConnection(connString);

            MySqlCommand cmd = new MySqlCommand("select * from Project;", conn);
        }

        public void editProj(String Num, String Desc, String dueDates, String Phase, String Deliv, int Hours, String Status)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn = new MySqlConnection(connString);
            MessageBox.Show(Num);

            String edProj = "UPDATE Project set prjNo = '" + Num + "' where prjNo = 'uu';";
            MySqlCommand cmd = new MySqlCommand(edProj, conn);
            //MessageBox.Show("Project changed to " + Num);
        }


    } // Class DBConn END
} // Name Space EdgeLook END
