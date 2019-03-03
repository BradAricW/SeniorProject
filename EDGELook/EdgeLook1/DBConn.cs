﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EdgeLook1
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

        //CONSTRUCTOR
        public DBConn()
        {
            //this.server = "athena";
            //this.database = "sevenwonders";
            //this.uid = "sevenwonders";
            //this.password = "sw_db";
            //this.connstring = "server=" + server + ";" + "database=" +
            //database + ";" + "uid=" + uid + ";" + "password=" + password + ";";

             
        }

        public void addProject(String Num, String Desc, String dueDates, String Phase, String Deliv, int Hours, String Status)
        {
            server = "localhost";
            database = "edge";
            uid = "root";
            password = "valeriyk1";
            connString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";


            conn = new MySqlConnection(connString);
            //MySqlCommand command = conn.CreateCommand();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            String addProj = "INSERT INTO Project VALUES (\'" + Num + "\', " + 322 + ", \'" + Desc + " \', \'" + Phase + " \', \'" + dueDates + " \', \'" + Deliv + "\', " + Hours + ", \'" + Status + "\');";
            MySqlCommand cmd = new MySqlCommand(addProj, this.conn);
            Console.WriteLine(cmd.ExecuteNonQuery());
            
        }
        public void editHours(int empHours)
        {
            int currentHours = 0;
            String getHours = "SELECT hoursAvail FROM Employee as E WHERE " + this.eID + " == E.employeeID";
            MySqlCommand cmd = new MySqlCommand(getHours, this.conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentHours = reader.GetInt16("hoursAvail");
            }
            if(empHours != currentHours)
            {
                String setHours = "UPDATE Employee SET hoursAvail = " + empHours + "WHERE employeeID = this.eID";
                MySqlCommand cmd2 = new MySqlCommand(setHours, this.conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }
        public void setEID(int employeeID)
        {
            eID = employeeID;
        }
    }
}