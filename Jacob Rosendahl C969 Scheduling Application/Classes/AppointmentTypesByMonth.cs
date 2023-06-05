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

        public int NumberOfAppointments { set; get; }

        //public AppointmentMonths(string Month, int NumberOfAppointments) { }

        public static BindingList<AppointmentTypesByMonth> appointmentMonths;

        public static void CountMonths()
        {
            if (appointmentMonths != null)
            {
                appointmentMonths.Clear();
            }
            int[] counts = new int[13];
            foreach (Appointment appointment in Appointment.AllAppointments)
            {
                counts[appointment.Date.Month]++;
            }
            appointmentMonths = new BindingList<AppointmentTypesByMonth>();
            AppointmentTypesByMonth newMonths1 = new AppointmentTypesByMonth
            {
                Month = "January",
                NumberOfAppointments = counts[1]
            };
            appointmentMonths.Add(newMonths1);
            AppointmentTypesByMonth newMonths2 = new AppointmentTypesByMonth 
            { 
                Month = "February", 
                NumberOfAppointments = counts[2] 
            };
            appointmentMonths.Add(newMonths2);

            AppointmentTypesByMonth newMonths3 = new AppointmentTypesByMonth
            {
                Month = "March",
                NumberOfAppointments = counts[3]
            };
            appointmentMonths.Add(newMonths3);
            AppointmentTypesByMonth newMonths4 = new AppointmentTypesByMonth
            {
                Month = "April",
                NumberOfAppointments = counts[4]
            };
            appointmentMonths.Add(newMonths4);
            AppointmentTypesByMonth newMonths5 = new AppointmentTypesByMonth
            {
                Month = "May",
                NumberOfAppointments = counts[5]
            };
            appointmentMonths.Add(newMonths5);
            AppointmentTypesByMonth newMonths6 = new AppointmentTypesByMonth
            {
                Month = "June",
                NumberOfAppointments = counts[6]
            };
            appointmentMonths.Add(newMonths6);
            AppointmentTypesByMonth newMonths7 = new AppointmentTypesByMonth
            {
                Month = "July",
                NumberOfAppointments = counts[7]
            };
            appointmentMonths.Add(newMonths7);

            AppointmentTypesByMonth newMonths8 = new AppointmentTypesByMonth
            {
                Month = "August",
                NumberOfAppointments = counts[8]
            };
            appointmentMonths.Add(newMonths8);
            AppointmentTypesByMonth newMonths9 = new AppointmentTypesByMonth
            {
                Month = "September",
                NumberOfAppointments = counts[9]
            };
            appointmentMonths.Add(newMonths9);
            AppointmentTypesByMonth newMonths10 = new AppointmentTypesByMonth
            {
                Month = "October",
                NumberOfAppointments = counts[10]
            };
            appointmentMonths.Add(newMonths10);
            AppointmentTypesByMonth newMonths11 = new AppointmentTypesByMonth
            {
                Month = "November",
                NumberOfAppointments = counts[11]
            };
            appointmentMonths.Add(newMonths11);
            AppointmentTypesByMonth newMonths12 = new AppointmentTypesByMonth
            {
                Month = "December",
                NumberOfAppointments = counts[12]
            };
            appointmentMonths.Add(newMonths12);
        }
    }
}
