using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Mira", 981123, "Manager", 8600);
            employees[1] = new Employee("Pete", 451235, "Programmer", 6442);
            employees[2] = new Employee("Jani", 956743, "Programmer", 4355);

            employees[0].PrintEmployeeInfo();
            employees[1].PrintEmployeeInfo();
            employees[2].PrintEmployeeInfo();

            employees[0].CompareSalary(employees[1]);
            employees[0].CompareSalary(employees[2]);

            Console.ReadKey();
        }
    }
}
