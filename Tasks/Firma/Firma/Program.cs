using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company();
            company1._address = "somewhere 123";
            company1._title = "the nimi";
            company1._phone = 040096534;
            company1._income = 900000;
            company1._expenses = 778654;
            Company company2 = new Company(company1);

            Company company3 = new Company("comp3", "comp 3", 04006723, 1006777, 467568);
                        
            company1.ShowInfo();
            company2.ShowInfo();
            company2.ShowProfit();
            company3.ShowProfit();

            Console.ReadKey();
        }
    }
}
