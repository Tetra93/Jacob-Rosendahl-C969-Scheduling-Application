using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jacob_Rosendahl_C969_Scheduling_Application.Classes;

namespace Jacob_Rosendahl_C969_Scheduling_Application
{
    public partial class Appointments : Form
    {
        public static Appointments appointments;
        public Appointments()
        {
            InitializeComponent();
            dataGridView1.DataSource = Appointment.AllAppointments;
            allRadio.Checked = true;
            appointments = this;
        }

        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadio.Checked)
            {
                fromDate.Enabled = false;
                toDate.Enabled = false;
                dataGridView1.DataSource = Appointment.AllAppointments;
            }
        }

        private void CurrentWeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (currentWeekRadio.Checked)
            {
                fromDate.Enabled = false;
                toDate.Enabled = false;
                Appointment.AppointmentsFiltered.Clear();
                foreach (Appointment appointment in Appointment.AllAppointments)
                    if (appointment.Date.Year == DateTime.Now.Year)
                    {
                        int appointmentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(appointment.Date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                        int currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                        if (appointmentWeek == currentWeek)
                        {
                            Appointment.AppointmentsFiltered.Add(appointment);
                        }
                    }
                dataGridView1.DataSource = Appointment.AppointmentsFiltered;
                dataGridView1.Refresh();
            }
        }

        private void CurrentMonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMonthRadio.Checked)
            {
                fromDate.Enabled = false;
                toDate.Enabled = false;
                Appointment.AppointmentsFiltered.Clear();
                foreach (Appointment appointment in Appointment.AllAppointments)
                    if (appointment.Date.Year == DateTime.Now.Year)
                    {
                        int appointmentMonth = appointment.Date.Month;
                        int currentMonth = DateTime.Now.Month;
                        if (appointmentMonth == currentMonth)
                        {
                            Appointment.AppointmentsFiltered.Add(appointment);
                        }
                    }
                dataGridView1.DataSource = Appointment.AppointmentsFiltered;
                dataGridView1.Refresh();
            }
        }

            private void OtherRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (otherRadio.Checked)
            {
                fromDate.Enabled = true;
                toDate.Enabled = true;
                Appointment.AppointmentsFiltered.Clear();
            }
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            Appointment.AppointmentsFiltered.Clear();
            try
            {
                if (fromDate.Value > toDate.Value)
                {
                    fromDate.Value = toDate.Value;
                    throw new Exception("Starting date cannot be later than the ending date");
                }
                foreach (Appointment appointment in Appointment.AllAppointments)
                    if (appointment.Date >= fromDate.Value && appointment.Date <= toDate.Value)
                    {
                        Appointment.AppointmentsFiltered.Add(appointment);
                    }
                dataGridView1.DataSource = Appointment.AppointmentsFiltered;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            Appointment.AppointmentsFiltered.Clear();
            try
            {
                if (fromDate.Value > toDate.Value)
                {
                    toDate.Value = fromDate.Value;
                    throw new Exception("Starting date cannot be later than the ending date");
                }
                foreach (Appointment appointment in Appointment.AllAppointments)
                    if (appointment.Date >= fromDate.Value && appointment.Date <= toDate.Value)
                    {
                        Appointment.AppointmentsFiltered.Add(appointment);
                    }
                dataGridView1.DataSource = Appointment.AppointmentsFiltered;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Appointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeMenu.homeMenu.Show();
        }

    }
}
