using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    public class Appointment
    {
        public static Appointment appointment = new Appointment();

        public string Type { set; get; }

        public string Customer { set; get; }

        public DateTime Time { set; get; }

        public int UserID { set; get; }

    }
}
