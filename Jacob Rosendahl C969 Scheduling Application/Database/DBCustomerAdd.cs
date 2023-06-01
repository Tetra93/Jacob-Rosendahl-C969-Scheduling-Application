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

        }

        public static void AddCountry()
        {
            if (DBCustomerChecks.CountryCheck() == false)
            {
                DBConnection.SqlString = $"INSERT INTO Country (countryID, country, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ({DBCustomerChecks.LastCityID}, {AddModifyCustomer.Country}, {DateTime.Now}, {Login.UserName}, {DateTime.Now}, {Login.UserName})";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                
            }
        }
    }
}
