using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdminClassLibrary
{
    public class Admin
    {
        private int adminID;
        private string adminFname;
        private string adminLname;
        private string adminSpecial;


        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public string AdminFname
        {
            get { return adminFname; }
            set { adminFname = value; }
        }

        public string AdminLname
        {
            get { return adminLname; }
            set { adminLname = value; }
        }

        public string AdminSpecial
        {
            get { return adminSpecial; }
            set { adminSpecial = value; }
        }


        public void DisplayAdminInfo()
        {
            Console.WriteLine($"Admin ID: {adminID}");
            Console.WriteLine($"Admin Name: {adminFname} {adminLname}");
            Console.WriteLine($"Admin Specialization: {adminSpecial}");
        }
    }

}
