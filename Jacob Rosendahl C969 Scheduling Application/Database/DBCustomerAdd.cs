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
            if (DBCustomerChecks.CustomerCheck() == false)
            {
                DBConnection.SqlString = $"INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ({DBCustomerChecks.LastCustomerID + 1}, \"{AddModifyCustomer.CustomerName}\", {DBCustomerChecks.LastCustomerID}, 1, CURRENT_TIMESTAMP(), \"{Login.UserName}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\")";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }

        public static void AddAddress()
        {
            if (DBCustomerChecks.AddressCheck() == false)
            {
                DBCustomerChecks.CityCheck();
                DBCustomerChecks.CustomerCheck();
                DBConnection.SqlString = $"INSERT INTO address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ({DBCustomerChecks.LastCustomerID}, \"{AddModifyCustomer.Address}\", \" \", {DBCustomerChecks.LastCityID}, \"{AddModifyCustomer.PostalCode}\", \"{AddModifyCustomer.Phone}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\", CURRENT_TIMESTAMP(), \"{Login.UserName}\")";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }

        public static void CustomerAddressCorrect()
        {
            if (DBCustomerChecks.CustomerCheck() == true)
            {
                DBConnection.SqlString = $"UPDATE customer" +
                    $"SET addressId = {DBCustomerChecks.LastCustomerID} " +
                    $"WHERE customerId = {DBCustomerChecks.LastCustomerID}";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
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
