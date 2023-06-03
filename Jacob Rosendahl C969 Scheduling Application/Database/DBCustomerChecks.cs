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
        public static int LastCustomerID { set; get; }

        public static string PostalCode { set; get; }

        public static int LastCityID { set; get; }

        public static int LastCountryID { set; get; }

        public static bool CustomerCheck(int inputID)
        {
            bool customerExists = false;
            DBConnection.SqlString = "SELECT customerID FROM customer";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            using (DBConnection.Reader = DBConnection.Cmd.ExecuteReader())
            {
                if (DBConnection.Reader.HasRows)
                {
                    while (DBConnection.Reader.Read())
                    {
                        int ID = DBConnection.Reader.GetInt32(0);
                        LastCustomerID = ID;
                        if (ID == inputID)
                        {
                            customerExists = true;
                            break;
                        }
                    }
                }
            }
            return customerExists;
        }

        public static bool AddressCheck(int inputID)
        {
            bool addressExists = false;
            DBConnection.SqlString = "SELECT * FROM address";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            using (DBConnection.Reader = DBConnection.Cmd.ExecuteReader())
            {
                if (DBConnection.Reader.HasRows)
                {
                    while (DBConnection.Reader.Read())
                    {
                        int ID = DBConnection.Reader.GetInt32(0);
                        LastCustomerID = ID;
                        PostalCode = DBConnection.Reader.GetString(4);
                        if (ID == inputID)
                        {
                            addressExists = true;
                            break;
                        }
                    }
                }
            }
            return addressExists;
        }

        public static bool CityCheck()
        {
            bool cityExists = false;
            string cityName;
            DBConnection.SqlString = "SELECT * FROM city";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            using (DBConnection.Reader = DBConnection.Cmd.ExecuteReader())
            {
                if (DBConnection.Reader.HasRows)
                {
                    while (DBConnection.Reader.Read())
                    {
                        cityName = DBConnection.Reader.GetString(1).ToUpper();
                        LastCityID = DBConnection.Reader.GetInt32(0);
                        if (cityName == AddUpdateCustomer.City.ToUpper())
                        {
                            cityExists = true;
                            break;
                        }
                    }
                }
            }
            if (cityExists == false)
            {
                LastCityID++;
            }
            return cityExists;
        }

        public static bool CountryCheck()
        {
            bool countryExists = false;
            string countryName;
            DBConnection.SqlString = "SELECT * FROM country";
            DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
            using (DBConnection.Reader = DBConnection.Cmd.ExecuteReader())
            {
                if (DBConnection.Reader.HasRows)
                {
                    while (DBConnection.Reader.Read())
                    {
                        countryName = DBConnection.Reader.GetString(1).ToUpper();
                        LastCountryID = DBConnection.Reader.GetInt32(0);
                        if (countryName == AddUpdateCustomer.Country.ToUpper())
                        {
                            countryExists = true;
                            break;
                        }
                    }
                }
            }
            if(countryExists == false)
            {
                LastCountryID++;
            }
            return countryExists;
        }
    }
}
