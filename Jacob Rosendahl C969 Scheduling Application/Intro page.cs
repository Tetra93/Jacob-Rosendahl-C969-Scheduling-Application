using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application
{
    public partial class Intro : Form
    {

        public Intro()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            //MySqlConnection conn = null;

            //try
            //{
            //    conn = new MySqlConnection(constr);

            //    conn.Open();

            //    MessageBox.Show("It works, yo");
            //}
            //catch(MySqlException ex)
            //{
            //    MessageBox.Show("It don't work, yo");
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //}

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Close application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
