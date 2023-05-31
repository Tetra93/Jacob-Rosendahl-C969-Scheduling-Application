using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Database
{
    class DBCustomerChecks
    {
        public static bool CustomerCheck()
        {
            bool customerExists = false;
            DBConnection.SqlString = "SELECT * FROM customer";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            DBConnection.Reader = DBConnection.Cmd.ExecuteReader();
            if (DBConnection.Reader.HasRows)
            {
                while (DBConnection.Reader.Read())
                {
                    int ID = DBConnection.Reader.GetInt32(0);
                    if(ID == AddModifyCustomer.CustomerID)
                    {
                        customerExists = true;
                    }
                }
            }
            return customerExists;
        }

        public static bool AddressCheck()
        {
            bool addressExists = false;
            DBConnection.SqlString = "SELECT * FROM customer";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            DBConnection.Reader = DBConnection.Cmd.ExecuteReader();
            if (DBConnection.Reader.HasRows)
            {
                while (DBConnection.Reader.Read())
                {
                    int ID = DBConnection.Reader.GetInt32(0);
                    if (ID == AddModifyCustomer.CustomerID)
                    {
                        addressExists = true;
                    }
                }
            }
            return addressExists;
        }

        public static bool CityCheck()
        {
            bool cityExists = false;

            return cityExists;
        }

        public static bool CountryCheck()
        {
            bool countryExists = false;

            return countryExists;
        }
    }
}
