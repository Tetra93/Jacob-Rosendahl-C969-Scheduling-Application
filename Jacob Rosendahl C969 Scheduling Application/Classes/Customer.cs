using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    public class Customer
    {
        public static Customer customer = new Customer();

        public int ID { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public string Phone { set; get; }

        public string City { set; get; }

        public string Country { set; get; }
    }
}
