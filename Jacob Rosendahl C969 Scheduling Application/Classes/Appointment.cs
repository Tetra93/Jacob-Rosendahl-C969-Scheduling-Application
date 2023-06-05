using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jacob_Rosendahl_C969_Scheduling_Application.Database;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    public class Appointment
    {
        public static Appointment appointment = new Appointment();

        public int AppointmentID { set; get; }

        public string Type { set; get; }

        public int CustomerID { set; get; }

        public string Customer { set; get; }

        public string Consultant { set; get; }

        public DateTime Date { set; get; }

        public TimeSpan StartTime { set; get; }

        public TimeSpan EndTime { set; get; }

        public static BindingList<Appointment> AllAppointments = new BindingList<Appointment>();

        public static BindingList<Appointment> AppointmentsFiltered = new BindingList<Appointment>();

        public static void PopulateAppointments()
        {
            AllAppointments.Clear();
            DBConnection.SqlString = @"SELECT a.appointmentId, a.type, c.customerID, c.customerName, u.userName, a.start, a.end
                                       FROM customer c
                                       JOIN appointment a
                                       ON c.customerID = a.customerID
                                       JOIN user u
                                       ON a.userID = u.userID";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            DBConnection.Reader = DBConnection.Cmd.ExecuteReader();
            if (DBConnection.Reader.HasRows)
            {
                while (DBConnection.Reader.Read())
                {
                    //I'm using a lambda here to convert UTC to local time so I don't need to create
                    //multiple variables or methods for changing the DateTime to UTC then changing
                    //that to a TimeSpan to display only the time. The lambda returns only the 
                    //TimeOfDay of the DateTime argument. The DateTime is given to it in local time.
                    Func<DateTime, TimeSpan> localTime = d => d.TimeOfDay;

                    AllAppointments.Add(new Appointment()
                    {
                        AppointmentID = DBConnection.Reader.GetInt32(0),
                        Type = DBConnection.Reader.GetString(1),
                        CustomerID = DBConnection.Reader.GetInt32(2),
                        Customer = DBConnection.Reader.GetString(3),
                        Consultant = DBConnection.Reader.GetString(4),
                        Date = DBConnection.Reader.GetDateTime(5).Date,
                        StartTime = localTime(DBConnection.Reader.GetDateTime(5).ToLocalTime()),
                        EndTime = localTime(DBConnection.Reader.GetDateTime(6).ToLocalTime())
                    });
                }
            }
            DBConnection.Reader.Close();
        }

        public static void UserFilter (string user)
        {
            AppointmentsFiltered.Clear();
            foreach (Appointment appointment in AllAppointments)
                if (appointment.Consultant == user)
                {
                    AppointmentsFiltered.Add(appointment);
                }
        }

        public static bool TimeCheck()
        {
            bool doAlert = false;
            foreach (Appointment appointment in AllAppointments)
            {
                DateTime date = appointment.Date.ToLocalTime();
                if (date == DateTime.Now.Date)
                {
                    TimeSpan time = appointment.StartTime - DateTime.Now.TimeOfDay;
                    if (time.TotalMinutes <= 15)
                    {
                        doAlert = true;
                        break;
                    }
                }
            }
            return doAlert;
        }
    }
}
