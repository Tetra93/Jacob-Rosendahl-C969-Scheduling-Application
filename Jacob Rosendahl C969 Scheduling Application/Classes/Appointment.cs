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

        public string Customer { set; get; }

        public string UserName { set; get; }

        public string Type { set; get; }

        public DateTime Date { set; get; }

        public DateTime StartTime { set; get; }

        public DateTime EndTime { set; get; }


        public static BindingList<Appointment> Appointments = new BindingList<Appointment>();

        public static void PopulateAppointments()
        {
            DBConnection.SqlString = @"SELECT c.customerName, u.userName, a.type, a.start, a.end
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
                    Appointments.Add(new Appointment()
                    {
                        Customer = DBConnection.Reader.GetString(0),
                        UserName = DBConnection.Reader.GetString(1),
                        Type = DBConnection.Reader.GetString(2),
                        Date = DBConnection.Reader.GetDateTime(3),
                        StartTime = DBConnection.Reader.GetDateTime(3),
                        EndTime = DBConnection.Reader.GetDateTime(4)
                    });
                }
            }
            DBConnection.Reader.Close();
        }
    }
}
