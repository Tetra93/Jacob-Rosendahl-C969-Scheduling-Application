using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    class AppointmentTypesByMonth
    {
        public string Month { set; get; }

        public Dictionary<string, int> AppointmentTypes;

        public static BindingList<AppointmentTypesByMonth> appointmentMonths;

        public static void CountMonths()
        {
            if (appointmentMonths != null)
            {
                appointmentMonths.Clear();
            }
            appointmentMonths = new BindingList<AppointmentTypesByMonth>();
            AppointmentTypesByMonth newMonths1 = new AppointmentTypesByMonth
            {
                Month = "January",
                AppointmentTypes = new Dictionary<string, int>()
            };
            foreach (Appointment appointment in Appointment.AllAppointments)
            {
                if (!newMonths1.AppointmentTypes.Keys.Contains(appointment.Type))
                {
                    newMonths1.AppointmentTypes.Add(appointment.Type, 0);
                }
                if (newMonths1.AppointmentTypes.ContainsKey(appointment.Type))
                {
                    newMonths1.AppointmentTypes[appointment.Type]++;
                }
            }
            appointmentMonths.Add(newMonths1);
            AppointmentTypesByMonth newMonths2 = new AppointmentTypesByMonth 
            { 
                Month = "February", 
            };
            appointmentMonths.Add(newMonths2);

            AppointmentTypesByMonth newMonths3 = new AppointmentTypesByMonth
            {
                Month = "March",
            };
            appointmentMonths.Add(newMonths3);
            AppointmentTypesByMonth newMonths4 = new AppointmentTypesByMonth
            {
                Month = "April",
            };
            appointmentMonths.Add(newMonths4);
            AppointmentTypesByMonth newMonths5 = new AppointmentTypesByMonth
            {
                Month = "May",
            };
            appointmentMonths.Add(newMonths5);
            AppointmentTypesByMonth newMonths6 = new AppointmentTypesByMonth
            {
                Month = "June",
            };
            appointmentMonths.Add(newMonths6);
            AppointmentTypesByMonth newMonths7 = new AppointmentTypesByMonth
            {
                Month = "July",
            };
            appointmentMonths.Add(newMonths7);

            AppointmentTypesByMonth newMonths8 = new AppointmentTypesByMonth
            {
                Month = "August",
            };
            appointmentMonths.Add(newMonths8);
            AppointmentTypesByMonth newMonths9 = new AppointmentTypesByMonth
            {
                Month = "September",
            };
            appointmentMonths.Add(newMonths9);
            AppointmentTypesByMonth newMonths10 = new AppointmentTypesByMonth
            {
                Month = "October",
            };
            appointmentMonths.Add(newMonths10);
            AppointmentTypesByMonth newMonths11 = new AppointmentTypesByMonth
            {
                Month = "November",
            };
            appointmentMonths.Add(newMonths11);
            AppointmentTypesByMonth newMonths12 = new AppointmentTypesByMonth
            {
                Month = "December",
            };
            appointmentMonths.Add(newMonths12);
        }
    }
}
