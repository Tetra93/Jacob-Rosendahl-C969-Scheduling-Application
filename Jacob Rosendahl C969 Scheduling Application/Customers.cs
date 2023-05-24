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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            dataGridView1.DataSource = Customer.Customers;
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
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

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeMenu.homeMenu.Show();
        }
    }
}
