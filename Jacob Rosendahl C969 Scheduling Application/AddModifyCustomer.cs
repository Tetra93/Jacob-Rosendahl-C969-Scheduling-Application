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
using Jacob_Rosendahl_C969_Scheduling_Application.Database;

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

        public static bool canSave = false;

        public AddModifyCustomer()
        {
            InitializeComponent();
        }

        public static void ClearAll()
        {
            CustomerID = 0;
            CustomerName = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            Country = string.Empty;
            Phone = string.Empty;
        }

        private void AddModifyCustomer_Load(object sender, EventArgs e)
        {
            if (this.Text == "Add Customer")
            {
                CustomerID = (Customer.Customers.Last().CustomerID + 1);
                IDTextBox.Text = CustomerID.ToString();
                canSave = false;
            }
            if (this.Text == "Update Customer")
            {
                CustomerID = Customers.ID;
                IDTextBox.Text = CustomerID.ToString();
                canSave = true;
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
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show($"{textBox.Name} cannot be empty.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            MessageBox.Show(DBCustomerChecks.CustomerCheck().ToString());
            MessageBox.Show(DBCustomerChecks.AddressCheck().ToString());
            DBCustomerAdd.AddCountry();
            DBCustomerAdd.AddCity();
            ClearAll();
            this.Close();
            Customers.customers.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.Close();
            Customers.customers.Show();
        }

    }
}
