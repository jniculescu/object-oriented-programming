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
            employees[0] = new Employee("Amanda", 123456, "Manager", 4900);
            employees[1] = new Employee("Henna", 234567, "Programmer", 5500);
            employees[2] = new Employee("Tia", 345678, "Programmer", 6000);

            employees[0].PrintEmployeeInfo();
            employees[1].PrintEmployeeInfo();
            employees[2].PrintEmployeeInfo();

            employees[0].CompareSalary(employees[1]);
            employees[0].CompareSalary(employees[2]);

            Console.ReadKey();
        }
    }
}
