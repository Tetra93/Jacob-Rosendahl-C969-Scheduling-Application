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
	public partial class Login : Form
	{
        public static Login login;

		public Login()
		{
			InitializeComponent();
            login = this;
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Exit application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
                Application.Exit();
			}
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HomeMenu homeMenu = new HomeMenu();
            homeMenu.Show();
            Close();
        }
    }
}
