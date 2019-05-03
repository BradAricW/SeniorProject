﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class LoginPage
    {
        //initialize variables and setup
        private String email;
        private String password;
        private MySqlConnection conn;
        private String eID;

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        } //end setup

        //core functionality
        public String Login (TextBox emailBox, TextBox passwordBox)
        {
            email = emailBox.Text;
            password = passwordBox.Text;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + email + "' AND BINARY pssword = '" + password + "';";
            String getLogin = "SELECT employeeID FROM Employee WHERE email = '" + email + "' AND BINARY pssword = SHA2('" + password + "', CONCAT('$6$', SUBSTRING(SHA(RAND()), -16)));"; 
            MySqlCommand cmd = new MySqlCommand(getLogin, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eID = reader.GetString(0);
            }
            if (eID == null)
            {
                MessageBox.Show("Not valid login");
            }
            conn.Close();
            return eID;
        } //end login

    }
}
