using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Database
{
    class DBConnection
    {
        public static MySqlConnection Conn { get; set; }

        public static void StartConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                Conn = new MySqlConnection(constr);

                Conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
