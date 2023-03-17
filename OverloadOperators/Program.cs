using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Arie";
            employee.LastName = "Eskinazi";
            employee.ID = 2;

            Employee employee2 = new Employee();
            employee2.FirstName = "Dana";
            employee2.LastName = "Rei";
            employee2.ID = 1;

            Console.WriteLine(employee.ID == employee2.ID);

            Console.ReadLine();

        }
    }
}
