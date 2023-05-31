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
    public partial class AddModifyCustomer : Form
    {
        public static int CustomerID { set; get; }
        public static string CustomerName { set; get; }
        public static string Address { set; get; }
        public static string City { set; get; }
        public static string Country { set; get; }
        public static string Phone { set; get; }

        public AddModifyCustomer()
        {
            InitializeComponent();
        }

        private void AddModifyCustomer_Load(object sender, EventArgs e)
        {
            if (this.Text == "Add Customer")
            {

            }
            if (this.Text == "Update Customer")
            {
                IDTextBox.Text = Customers.ID.ToString();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CustomerName = nameTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Address = addressTextBox.Text;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            City = cityTextBox.Text;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            Country = countryTextBox.Text;
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            Phone = phoneTextBox.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers.customers.Show();
        }

    }
}
