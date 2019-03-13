using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGELook
{
    class ProfilePage
    {
        private int myHours;
        private DBConn Conn;

        public void EditMyHours(TextBox hoursBox)
        {
            Conn = new DBConn();
            myHours = int.Parse(hoursBox.Text);
            Conn.editHours(myHours);
        }
    }
}
