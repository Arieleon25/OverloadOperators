using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee : Person 
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
