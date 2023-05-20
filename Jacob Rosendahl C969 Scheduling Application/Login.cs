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

        public static bool canClose = false;
        public static bool loginSuccessful = false;
        public static Login login;

		public Login()
		{
			InitializeComponent();
            if (Program.language == "es")
            {
                label1.Text = "Usuario";
                label2.Text = "Contraseña";
                this.Text = "Acceso";
                loginButton.Text = "Acceso";
                exitButton.Text = "Salida";
            }
            canClose = false;
            loginSuccessful = false;
            login = this;
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Maybe use a lambda here to check the password
            //Maybe also create an exception if the username/password don't match
            if (true)
            {
                HomeMenu homeMenu = new HomeMenu();
                homeMenu.Show();
                loginSuccessful = true;
                Close();
            }
            else
            {
                MessageBox.Show("Username and password don't match");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginSuccessful == true)
            {
            }
            else if (canClose == false && Program.language == "es")
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "¿Cierra la aplicación?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    canClose = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (canClose == false && (Program.language != "es"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Close application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    canClose = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
