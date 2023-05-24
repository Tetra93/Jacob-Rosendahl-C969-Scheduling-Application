using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacob_Rosendahl_C969_Scheduling_Application.Classes
{
    public class User
    {
        public static User user = new User();

        public int UserID { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }


    }
}
