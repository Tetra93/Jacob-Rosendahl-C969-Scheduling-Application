using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jacob_Rosendahl_C969_Scheduling_Application
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            reportTypeBox.Items.Add("Reports by month");
            reportTypeBox.Items.Add("Consultant schedules");
            reportTypeBox.Items.Add("Third option");
            peopleListBox.Items.Add("Person 1");
            peopleListBox.Items.Add("Person 2");
        }

        private void ReportTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reportTypeBox.SelectedItem.ToString() == "Consultant schedules")
            {
                peopleListBox.Visible = true;
            }
            else
            {
                peopleListBox.Visible = false;
            }
        }

        private void PeopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
