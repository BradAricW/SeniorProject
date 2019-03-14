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

        public void Login (TextBox emailBox, TextBox passwordBox)
        {
            Conn = new DBConn();
            email = emailBox.Text;
            password = passwordBox.Text;
            Conn.login(email, password);
        }
    }
}
