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
        private string email;
        private string password;
        private DBConn Conn;
        private int result, success;

        public int Login (TextBox emailBox, TextBox passwordBox)
        {
            Conn = new DBConn();
            email = emailBox.Text;
            password = passwordBox.Text;
            result = Conn.Login(email, password);
            if (result == null)
                success = 0;
            else
                success = 1;
            return success;
        }
    }
}
