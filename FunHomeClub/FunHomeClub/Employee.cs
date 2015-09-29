using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunHomeClub
{
    public class Employee
    {
        public string username { get; set; }
        public string password { get; set; }
        public string position { get; set; }
        public string employeeID { get; set; }

        public Employee()
        {

        }

        public Employee(string employeeID, string username, string password, string position) {
            this.employeeID = employeeID;
            this.username = username;
            this.password = password;
            this.position = position;
        }
    }
}
