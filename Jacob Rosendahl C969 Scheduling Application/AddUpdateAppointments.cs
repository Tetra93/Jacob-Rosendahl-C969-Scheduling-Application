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
    public partial class AddUpdateAppointments : Form
    {
        public AddUpdateAppointments()
        {
            InitializeComponent();
        }

        private void AddUpdateAppointments_Load(object sender, EventArgs e)
        {
            foreach (Customer customer in Customer.Customers)
            {
                customerName.Items.Add(customer.Name);
            }
            foreach (string user in User.userList)
            {
                consultantName.Items.Add(user);
            }
        }

        private void CustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultantName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Appointments.appointments.Show();
        }
    }
}
