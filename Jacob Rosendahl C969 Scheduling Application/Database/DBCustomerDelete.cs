using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Database
{
    class DBCustomerDelete
    {
        public static void DeleteCustomer()
        {
            if (DBCustomerChecks.CustomerCheck(Customers.ID) == true)
            {
                DBConnection.SqlString = $"DELETE FROM customer WHERE customerId = {Customers.ID}";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAddress()
        {
            if (DBCustomerChecks.AddressCheck(Customers.ID) == true)
            {
                DBConnection.SqlString = $"DELETE FROM address WHERE addressId = {Customers.ID}";
                DBConnection.Cmd = new MySqlCommand(DBConnection.SqlString, DBConnection.Conn);
                DBConnection.Cmd.ExecuteNonQuery();
            }
        }
    }
}
