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
            int[] counts = new int[12];
            foreach (Appointment appointment in Appointment.AllAppointments)
            {
                counts[appointment.Date.Month]++;
            }
            appointmentMonths = new BindingList<AppointmentMonths>();
            AppointmentMonths newMonths1 = new AppointmentMonths
            {
                Month = "January",
                NumberOfAppointments = counts[0]
            };
            appointmentMonths.Add(newMonths1);
            AppointmentMonths newMonths2 = new AppointmentMonths 
            { 
                Month = "February", 
                NumberOfAppointments = counts[1] 
            };
            appointmentMonths.Add(newMonths2);
            //appointmentMonths.Add(new AppointmentMonths(Month = "March", NumberOfAppointments = counts[2]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "April", NumberOfAppointments = counts[3]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "May", NumberOfAppointments = counts[4]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "June", NumberOfAppointments = counts[5]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "July", NumberOfAppointments = counts[6]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "August", NumberOfAppointments = counts[7]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "September", NumberOfAppointments = counts[8]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "October", NumberOfAppointments = counts[9]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "November", NumberOfAppointments = counts[10]));
            //appointmentMonths.Add(new AppointmentMonths(Month = "December", NumberOfAppointments = counts[11]));
        }
    }
}
