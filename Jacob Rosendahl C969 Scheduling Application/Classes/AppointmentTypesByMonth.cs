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

        public string Type { set; get; }
        public string Month { set; get; }
        public int Count { set; get; }

        public Dictionary<string, int> AppointmentTypes;

        public static List<AppointmentTypesByMonth> appointmentMonthsList;

        public static BindingList<AppointmentTypesByMonth> appointmentMonthsBindingList;

        public static void CountMonths()
        {
            if (appointmentMonthsList != null)
            {
                appointmentMonthsList.Clear();
            }
            appointmentMonthsList = new List<AppointmentTypesByMonth>();
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
            appointmentMonthsList.Add(newMonths1);
            AppointmentTypesByMonth newMonths2 = new AppointmentTypesByMonth 
            { 
                Month = "February", 
            };
            appointmentMonthsList.Add(newMonths2);

            AppointmentTypesByMonth newMonths3 = new AppointmentTypesByMonth
            {
                Month = "March",
            };
            appointmentMonthsList.Add(newMonths3);
            AppointmentTypesByMonth newMonths4 = new AppointmentTypesByMonth
            {
                Month = "April",
            };
            appointmentMonthsList.Add(newMonths4);
            AppointmentTypesByMonth newMonths5 = new AppointmentTypesByMonth
            {
                Month = "May",
            };
            appointmentMonthsList.Add(newMonths5);
            AppointmentTypesByMonth newMonths6 = new AppointmentTypesByMonth
            {
                Month = "June",
            };
            appointmentMonthsList.Add(newMonths6);
            AppointmentTypesByMonth newMonths7 = new AppointmentTypesByMonth
            {
                Month = "July",
            };
            appointmentMonthsList.Add(newMonths7);

            AppointmentTypesByMonth newMonths8 = new AppointmentTypesByMonth
            {
                Month = "August",
            };
            appointmentMonthsList.Add(newMonths8);
            AppointmentTypesByMonth newMonths9 = new AppointmentTypesByMonth
            {
                Month = "September",
            };
            appointmentMonthsList.Add(newMonths9);
            AppointmentTypesByMonth newMonths10 = new AppointmentTypesByMonth
            {
                Month = "October",
            };
            appointmentMonthsList.Add(newMonths10);
            AppointmentTypesByMonth newMonths11 = new AppointmentTypesByMonth
            {
                Month = "November",
            };
            appointmentMonthsList.Add(newMonths11);
            AppointmentTypesByMonth newMonths12 = new AppointmentTypesByMonth
            {
                Month = "December",
            };
            appointmentMonthsList.Add(newMonths12);
        }
    }
}
