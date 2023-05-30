using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jacob_Rosendahl_C969_Scheduling_Application.Classes;

namespace Jacob_Rosendahl_C969_Scheduling_Application
{
    public partial class Reports : Form
    {
        public static BindingList<object> appointmentsByMonth = new BindingList<object>();

        public static BindingList<object> consultantSchedule = new BindingList<object>();

        public static BindingList<object> thirdList = new BindingList<object>();

        public Reports()
        {
            InitializeComponent();
            reportTypeBox.Items.Add("Number of appointments by month");
            reportTypeBox.Items.Add("Consultant schedules");
            reportTypeBox.Items.Add("Third option");
            foreach (string user in User.userList)
            {
                peopleListBox.Items.Add(user);
            }
        }

        private void ReportTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reportTypeBox.SelectedItem.ToString() == "Number of appointments by month")
            {
                AppointmentMonths.CountMonths();
                dataGridView1.DataSource = AppointmentMonths.appointmentMonths;
                dataGridView1.Refresh();
            }
            if(reportTypeBox.SelectedItem.ToString() != "Consultant schedules")
            {
                peopleListBox.Visible = false;
            }
            else
            {
                peopleListBox.Visible = true;
            }
        }

        private void PeopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = peopleListBox.SelectedItem.ToString();
            Appointment.UserFilter(user);
            dataGridView1.DataSource = Appointment.AppointmentsFiltered;
            dataGridView1.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeMenu.homeMenu.Show();
        }

    }
}
