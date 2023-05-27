using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    class AppointmentMonths
    {
        public string Month { set; get; }

        public int NumberOfAppointments { set; get; }

        //public AppointmentMonths(string Month, int NumberOfAppointments) { }

        public static BindingList<AppointmentMonths> appointmentMonths;

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
            appointmentMonths = new BindingList<AppointmentMonths>();
            AppointmentMonths newMonths1 = new AppointmentMonths
            {
                Month = "January",
                NumberOfAppointments = counts[1]
            };
            appointmentMonths.Add(newMonths1);
            AppointmentMonths newMonths2 = new AppointmentMonths 
            { 
                Month = "February", 
                NumberOfAppointments = counts[2] 
            };
            appointmentMonths.Add(newMonths2);

            AppointmentMonths newMonths3 = new AppointmentMonths
            {
                Month = "March",
                NumberOfAppointments = counts[3]
            };
            appointmentMonths.Add(newMonths3);
            AppointmentMonths newMonths4 = new AppointmentMonths
            {
                Month = "April",
                NumberOfAppointments = counts[4]
            };
            appointmentMonths.Add(newMonths4);
            AppointmentMonths newMonths5 = new AppointmentMonths
            {
                Month = "May",
                NumberOfAppointments = counts[5]
            };
            appointmentMonths.Add(newMonths5);
            AppointmentMonths newMonths6 = new AppointmentMonths
            {
                Month = "June",
                NumberOfAppointments = counts[6]
            };
            appointmentMonths.Add(newMonths6);
            AppointmentMonths newMonths7 = new AppointmentMonths
            {
                Month = "July",
                NumberOfAppointments = counts[7]
            };
            appointmentMonths.Add(newMonths7);

            AppointmentMonths newMonths8 = new AppointmentMonths
            {
                Month = "August",
                NumberOfAppointments = counts[8]
            };
            appointmentMonths.Add(newMonths8);
            AppointmentMonths newMonths9 = new AppointmentMonths
            {
                Month = "September",
                NumberOfAppointments = counts[9]
            };
            appointmentMonths.Add(newMonths9);
            AppointmentMonths newMonths10 = new AppointmentMonths
            {
                Month = "October",
                NumberOfAppointments = counts[10]
            };
            appointmentMonths.Add(newMonths10);
            AppointmentMonths newMonths11 = new AppointmentMonths
            {
                Month = "November",
                NumberOfAppointments = counts[11]
            };
            appointmentMonths.Add(newMonths11);
            AppointmentMonths newMonths12 = new AppointmentMonths
            {
                Month = "December",
                NumberOfAppointments = counts[12]
            };
            appointmentMonths.Add(newMonths12);
        }
    }
}
