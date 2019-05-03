using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class PasswordPage
    {
        //initialize variables and setup
        private MySqlConnection conn;

        public void Setup(MySqlConnection newConn)
        {
            conn = newConn;
        } //end setup

        //core functionality
        public void ChangePass(TextBox currentPassBox, TextBox newPassBox, String eID)
        {
            conn.Open();

            String newPassword = newPassBox.Text;
            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
            }
            else
            {
                String testID = null;
                String getID = "SELECT employeeID FROM Employee WHERE employeeID = '" + eID + "';";
                MySqlCommand cmd = new MySqlCommand(getID, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    testID = reader.GetString("employeeID");
                }
                reader.Close();

                if (testID != null)
                {
                    String oldPass = currentPassBox.Text;
                    String testPass = null;
                    String getPass = "SELECT pssword FROM Employee WHERE employeeID = '" + eID + "' AND BINARY pssword = '" + oldPass + "';";
                    cmd = new MySqlCommand(getPass, this.conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        testPass = reader.GetString("pssword");
                    }
                    reader.Close();

                    if (testPass != null)
                    {
                        String setPassword = "UPDATE Employee SET pssword = '" + newPassword + "' WHERE employeeID = " + eID + ";";
                        cmd = new MySqlCommand(setPassword, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Current Password Invalid. Unable to change password.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email.");
                }
            }
            conn.Close();
        } //end change password

        public void ResetPass(TextBox resetBox)
        {
            String email = resetBox.Text;
            String newPass = RandomPassword();
            conn.Open();

            String testEmail = null;
            String getEmail = "SELECT email FROM Employee WHERE email = '" + email + "';";
            MySqlCommand cmd = new MySqlCommand(getEmail, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                testEmail = reader.GetString("email");
            }
            reader.Close();

            if (testEmail != null)
            {

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("edgelookserver@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Password Reset";
                    mail.Body = "Your temporary EdgeLook password is: " + newPass + "\nPlease change password after next login. \n\nIf you did not request a reset, or if issues persist, please contact your system administrator.";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("edgelookserver@gmail.com", "edgeLook1!");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("New Password Sent");

                    cmd = new MySqlCommand("UPDATE Employee SET pssword = '" + newPass + "' WHERE email = '" + email + "';", conn);
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No such email.");
            }
            conn.Close();
        } //end reset password

        public String RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        } //end random password

        public String RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        } //end random string

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        } //end random number
    }//end class
}//end namespace