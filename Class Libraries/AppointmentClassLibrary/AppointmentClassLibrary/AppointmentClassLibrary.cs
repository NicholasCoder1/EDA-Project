using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppointmentClassLibrary
{
    public class Admin
    {
        public int AdminID { get; set; }

    }

    public class Appointment : Admin
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }

    }
    

}
