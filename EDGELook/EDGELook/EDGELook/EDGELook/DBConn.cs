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
        private int? eID;
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

        // AMANDA - Added to try to run queries from EditPage 3/25/2019 6:52 PM
        public void queryRunner(String input)
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Query Passed");

            MySqlCommand cmd = new MySqlCommand(input, conn);
            Console.WriteLine("Input: " + input);
            Console.WriteLine("cmd: " + cmd);
            Console.WriteLine(cmd.ExecuteNonQuery());
        }

        public void AddProject(String Num, String Desc, String dueDates, String Phase, String Deliv, int Hours, String Status, String noteInsert)
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

            MySqlCommand cmd = new MySqlCommand(addProj, this.conn);
            Console.WriteLine(cmd.ExecuteNonQuery());
 

        }

        

        /*public int EditHours(int empHours)
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MySqlCommand cmd = new MySqlCommand("UPDATE Employee SET hoursAvail = '" + empHours + "'WHERE employeeID = '" + this.eID + "';", conn);
            Console.WriteLine(cmd.ExecuteNonQuery());

            int currentHours = 0;
            /*String getHours = "SELECT hoursAvail FROM Employee WHERE employeeID = '" + this.eID + "';";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentHours = reader.GetInt16("hoursAvail");
            }
            Console.WriteLine(currentHours);
            if (empHours != currentHours)
            {
                String setHours = "UPDATE Employee SET hoursAvail = " + empHours + "WHERE employeeID = this.eID;";
                MySqlCommand cmd2 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine("Hours Updated");
               // Console.WriteLine(cmd2.ExecuteNonQuery());
                currentHours = empHours;
            }
            return currentHours;
        }*/
        public void SetEID(int employeeID)
        {
            eID = employeeID;
        }

        /*public int? Login (String username, String password)
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + username + "' AND pssword = '" + password + "';";
            MySqlCommand cmd = new MySqlCommand(getLogin, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eID = reader.GetInt16("employeeID");
            }
            if (eID == null)
            {
                Console.WriteLine("Not valid login");
            }
            else
                Console.WriteLine("Logged in");
            return eID;
        } // Login*/


        //// Not Tested!!!!!!!
        public void EditNotes(String addNotes)
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

        public void EditProj(String Num, String Desc, String dueDates, String Phase, String Deliv, int Hours, String Status)
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
        public String connectionSetUp()
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";
            return connString;
        }


    } // Class DBConn END
} // Name Space EdgeLook END
