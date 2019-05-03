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
        //initialize variables and setup
        private String server;
        private String database;
        private String uid;
        private String password;
        private String connString;
        private MySqlConnection conn;

        public DBConn()
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" + database + ";" + "uid=" + uid + ";" + "password=" + password + ";" + "convert zero datetime=True; SslMode = none";
        } //end constructor

        public MySqlConnection Dbsetup()
        {
            conn = new MySqlConnection(connString);
            return conn;
        } //end db setup
        
        public String ConnectionSetUp()
        {
            this.server = "athena";
            this.database = "sevenwonders";
            this.uid = "sevenwonders";
            this.password = "sw_db";
            this.connString = "server=" + server + ";" + "database=" + database + ";" + "uid=" + uid + ";" + "password=" + password + ";" + "convert zero datetime=True; SslMode = none";
            return connString;
        } //end connection setup

    } // Class DBConn END
} // Name Space EdgeLook END
