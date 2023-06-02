using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Database
{
    class DBCustomerAdd
    {

        public static void AddCustomer()
        {

        }

        public static void AddAddress()
        {

        }

        public static void AddCity()
        {
            if (DBCustomerChecks.CityCheck() == false)
            {
                DBCustomerChecks.CountryCheck();
                DBConnection.SqlString = $"INSERT INTO city (cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ({DBCustomerChecks.LastCityID + 1}, \"{AddModifyCustomer.City}\", {DBCustomerChecks.LastCountryID}, CURRENT_TIMESTAMP(), \"{Login.UserName}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\")";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }

        public static void AddCountry()
        {
            if (DBCustomerChecks.CountryCheck() == false)
            {
                DBConnection.SqlString = $"INSERT INTO country (countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ({DBCustomerChecks.LastCountryID + 1}, \"{AddModifyCustomer.Country}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\")";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }
    }
}
